using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using login_registro_asp.Data;
using login_registro_asp.Models;
using Microsoft.EntityFrameworkCore;

namespace login_registro_asp.Repository
{
    public class UserActions : IUser
    {
        private UserContext _userContext;

        public UserActions(UserContext userContext) => _userContext = userContext;
        public UserModel Add(UserModel user)
        {
            _userContext.user.Add(user);
            _userContext.SaveChanges();
            return user;
        }

        public List<UserModel> lstUsers()
        {
            List<UserModel> lstUsers = new List<UserModel>( _userContext.user.ToList());
            return lstUsers;
        }

        public List<UserModel> SelectUser(UserModel user)
        {
            var _user =  _userContext.user.Where(S => S.Email == user.Email && S.Password == user.Password)
            .ToList();
            return _user;
        }


    }
}

