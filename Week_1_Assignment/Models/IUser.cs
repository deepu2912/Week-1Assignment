using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Week_1_Assignment.Models
{
    public interface IUser
    {
        List<User> GetUsers(); 
        User GetDetailsByID(int Id);
        bool DeleteUser(int Id);
        bool UpdateUser(User _User);
        void CreateUser(User _user);
    }
}
