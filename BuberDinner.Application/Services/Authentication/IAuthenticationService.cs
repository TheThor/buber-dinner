﻿namespace BuberDinner.Application.Services.Authentication;

public interface IAuthenticationService
{
    AuthenticationResult Register(string firstname, string lastName, string email, string password);
    AuthenticationResult Login(string email, string password);
}