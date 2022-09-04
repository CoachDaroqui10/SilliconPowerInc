using System;
using DoonamisSPI.Controllers.Authentication.Requests;

namespace Doonamis.Services
{
    public interface IAuthenticationService
    {
        void Register(RegisterRequest request);
    }
}

