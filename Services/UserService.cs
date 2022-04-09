using LostFound.Modals;
using LostFound.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LostFound.Services
{
    public class UserService : IUserService
    {
        private readonly UserContext _usercontext;
        public UserService(UserContext usercontext)
        {
            _usercontext = usercontext;
        }

        public UserDetails AddUser(UserDetails user)
        {
            user.Id = new Guid();
            _usercontext.Add(user);
            _usercontext.SaveChanges();
            return user;
        }

        public UserDetails DeleteUser(UserDetails user)
        {
            _usercontext.Remove(user);
            _usercontext.SaveChanges();
            return user;
        }

        public UserDetails EditUser(UserDetails user)
        {
            _usercontext.Update(user);
            _usercontext.SaveChanges();
            return user;
        }


        public UserDetails GetUserDetail(Guid Id)
        {
            return _usercontext.UserDetails.AsNoTracking().SingleOrDefault(s=> s.Id== Id);
        }

        public List<UserDetails> GetUserDetails()
        {
            return _usercontext.UserDetails.AsNoTracking().ToList();
        }
    }
}
