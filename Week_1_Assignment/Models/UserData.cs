using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Week_1_Assignment.Models
{
    public class UserData : IUser
    {
        static List<User> Users = new List<User>()
        {
            new User
            {
                UserID=1,
                Name="Deepanshu Ahuja",
                Mobile="7206969076",
                Address="316, New Colony, Palwal",
                State="Haryana",
                Country="India",
                AccountType="Current"
            },
            new User
            {
                UserID=2,
                Name="Pawan",
                Mobile="9834638202",
                Address="210, Preet Colony, Delhi",
                State="Delhi",
                Country="India",
                AccountType="Saving"
            },
            new User
            {
                UserID=3,
                Name="Mahesh",
                Mobile="8947320348",
                Address="720, 2nd FLoor, Pushpa Enclave",
                State="New Delhi",
                Country="India",
                AccountType="Current"
            },
            new User
            {
                UserID=4,
                Name="Ramesh",
                Mobile="8634542234",
                Address="540, New Colony, Palwal",
                State="Haryana",
                Country="India",
                AccountType="Saving"
            }
        };

        public List<User> GetUsers()
        {
            return Users;
        }
        public bool DeleteUser(int Id)
        {
            var User = Users.Find(x => x.UserID == Id);
            Users.Remove(User);
            return true;
        }

        public bool UpdateUser(User _user)
        {
            var User = Users.Find(x => x.UserID == _user.UserID);
            
            User.UserID = _user.UserID;
            User.Name = _user.Name;
            User.Mobile = _user.Mobile;
            User.Address = _user.Address;
            User.State = _user.State;
            User.Country = _user.Country;
            User.AccountType = _user.AccountType;

            return true;
        }

        public User GetDetailsByID(int Id)
        {
            var User = Users.Find(x => x.UserID == Id);
            return User;
        }

        public void CreateUser(User _user)
        {
            Users.Add(_user);
            
        }
    }
}
