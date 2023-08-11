using BusinessLayer.Interface;
using CommonLayer.Model;
using RepoLayer.Entity;
using RepoLayer.Interface;
using RepoLayer.Services;
using System;
using System.Collections.Generic;
using System.Text;
using static RepoLayer.Services.UserRepo;

namespace BusinessLayer.Services
{
    public class UserBusiness : IUserBusiness
    {
        private readonly IUserRepo _userRepo;
        //private readonly IUserRepo _loginRepo;

        public UserBusiness(IUserRepo userRepo)
        {
            _userRepo = userRepo;
            //_loginRepo = loginRepo;  
        }


        // //This is the UserReg method implementation using UserRegModel
        public UserEntity UserReg(UserRegModel model)
        {
            try
            {
                return _userRepo.UserReg(model);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}