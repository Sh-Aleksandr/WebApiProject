using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Repository
{
    public class UserRepository
    {

        public List<User> Users { get; set; } = new List<User>()
        { new User() {Name ="Leha"}, { new User() { Name = "Miha"} } };
    }
}
