using LostFound.Modals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LostFound.Services.Interfaces
{
   public interface IUserService
    {
        public List<UserDetails> GetUserDetails();
        public UserDetails GetUserDetail(Guid Id);
        public UserDetails AddUser(UserDetails user);
        public UserDetails EditUser(UserDetails user);
        public UserDetails DeleteUser(UserDetails user);
    }
}
