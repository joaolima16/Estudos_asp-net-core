using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using login_registro_asp.Models;

namespace login_registro_asp.Repository
{
    public interface IUser
    {
        UserModel Add(UserModel user);
        List<UserModel> SelectUser(UserModel user);
        List<UserModel> lstUsers();
    }
}