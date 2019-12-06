using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyPal.Model.Repository
{
    public static class UserRepository
    {
        public static StudyPalContext Context = new StudyPalContext();

        public static List<User> GetUsers()
        {
            return Context.Users.ToList();
        }

        public static bool AuthenticateUser(string username, string password)
        {
            List<User> users = GetUsers();
            foreach(User user in users)
            {
                if(user.UserName.Equals(username) && user.Password.Equals(password))
                {
                    return true;
                }
            }
            return false;
        }


        public static User GetUserById(int id)
        {
            return Context.Users.Where(s=> s.UserId  == id).FirstOrDefault();
        }

        public static int RemoveUser(User user)
        {
            Context.Users.Remove(user);
            return Context.SaveChanges();
        }

        public static int AddUser(User user)
        {
            Context.Users.Add(user);
            return Context.SaveChanges();
        }

        public static int UpdateUser(User user)
        {
            Context.Users.Add(user);
            return Context.SaveChanges();
        }

        public static int Save()
        {
            return Context.SaveChanges();
        }


        public static User FindUserByUserName(string name)
        {
            return Context.Users.Where(s=> s.UserName.Equals(name)).FirstOrDefault();
        }

    }
}
