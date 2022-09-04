using System;
using Doonamis.Data;
using Doonamis.Data.Entities;
using DoonamisSPI.Controllers.Authentication.Requests;

namespace Doonamis.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private DataContext dataContext;

        public AuthenticationService(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public void Register(RegisterRequest request)
        {
            if (dataContext.Users.Any(x => x.Email == request.Email))
            {
                throw new Exception("User already exists");
            }

            var user = new User()
            {
                Email = request.Email,
                Password = request.Password, // Encrypt
                FirstName = request.FirstName,
                LastName = request.LastName
            };

            dataContext.Users.Add(user);
            dataContext.SaveChanges();
        }
    }
}

