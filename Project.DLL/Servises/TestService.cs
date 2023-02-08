using Project.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.Services
{
    public class UserService
    {
        public List<UserDto> GetAllDisableUsers()
        {

            var userRep = new UserRepository();
            var users = userRep.Users;
            return new List<UserDto>() { new UserDto() { Name = users[0].Name } };
                  
        }
    }
}
