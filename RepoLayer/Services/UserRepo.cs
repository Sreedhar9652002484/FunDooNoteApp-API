using CommonLayer.Model;
using Microsoft.Extensions.Configuration;
using RepoLayer.Context;
using RepoLayer.Entity;
using RepoLayer.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepoLayer.Services
{
    public class UserRepo: IUserRepo
    {
        private readonly FunDoContext funDoContext;
        private readonly IConfiguration configuration;

        public UserRepo(FunDoContext funDoContext, IConfiguration configuration)
        {
            this.funDoContext = funDoContext;
            this.configuration = configuration;
        }

        public UserEntity UserReg(UserRegModel model)
        {
            try
            {
                UserEntity user = new UserEntity();
                user.FirstName = model.FirstName;
                user.LastName = model.LastName;
                user.DateOfBirth = model.DateOfBirth;
                user.Email = model.Email;
                user.Password = model.Password;
                
                funDoContext.Users.Add(user);
                funDoContext.SaveChanges();
               
               if(user != null)
                {
                    return user;
                }
                   
                else return null;

            }
            catch (Exception)
            {

                throw;
            }
        }

        
    }
}
