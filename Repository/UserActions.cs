using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using login_registro_asp.Data;
using login_registro_asp.Models;

namespace login_registro_asp.Repository
{
    public class UserActions : IUser
    {
        private UserContext _userContext;

        public UserActions(UserContext userContext) => _userContext = userContext;
    public UserModel Add(UserModel user){
        _userContext.user.Add(user);
        _userContext.SaveChanges();
        return user;
    }
    }

}