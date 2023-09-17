﻿using BookReadingEvent.Core.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookReadingEvent.Core.IRepositories
{
    public interface IAccountRepository
    {
        Task<IdentityResult> CreateUser(SignUp user);
        Task<SignInResult> LoginUser(Login user);
        Task SignOut();
        string GetEmail(string organiser);
    }
}
