using System;
using Doonamis.Data;
using Doonamis.Data.Entities;
using Doonamis.Services;
using DoonamisSPI.Controllers.Authentication.Requests;
using Microsoft.EntityFrameworkCore;
using Moq;

namespace DoonamisTests.Services
{
    public class AuthenticationServiceTests
    {
        IAuthenticationService authenticationService;
        Mock<DataContext> dataContext;

        public AuthenticationServiceTests()
        {
            dataContext = new Mock<DataContext>(null);
            authenticationService = new AuthenticationService(dataContext.Object);
        }

        // [Fact] Not working
        public void Register_Success()
        {
            var request = new RegisterRequest()
            {
                Email = "test@email.com",
                Password = "Test123",
                ConfirmPassword = "Test123",
                FirstName = "Name",
                LastName = "LastName"
            };

            dataContext.Setup(d => d.Users.Add(It.IsAny<User>())).Verifiable();

            authenticationService.Register(request);
        }
    }
}

