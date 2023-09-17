using AutoMapper;
using BookReadingEvent.Interfaces;
using BookReadingEvent.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookReadingEvent.Application.Interfaces;
using BookReadingEvent.Application.Models;



namespace BookReadingEvent.Services
{
    public class AccountPageService : IAccountPageService
    {
        private readonly IAccountService _accountService;
        private readonly IMapper _mapper;

        public AccountPageService(IAccountService accountService, IMapper mapper)
        {
            this._accountService = accountService;
            this._mapper = mapper;
        }
        public async Task<IdentityResult> CreateUser(SignUpViewModel signUpViewModel)
        {

            // mapping from viewmodel to application model
            var mapped = _mapper.Map<SignUpModel>(signUpViewModel);
            if (mapped == null)
                throw new Exception($"Entity could not be mapped.");

            ///calling application layer using mapped
            //outputting result in the same return type

            var entityDto = await _accountService.CreateUser(mapped);
            return entityDto;


        }

        public async Task<SignInResult> LoginUser(LoginViewModel loginViewModel)
        {
            // mapping from viewmodel to application model
            var mapped = _mapper.Map<LoginModel>(loginViewModel);
            if (mapped == null)
                throw new Exception($"Entity could not be mapped.");

            ///calling application layer using mapped
            //outputting result in the same return type
            var entityDto = await _accountService.LoginUser(mapped);
            return entityDto;

        }

        public async Task SignOut()
        {
            await _accountService.SignOut();
        }

        public string GetEmail(string organiser)
        {
            return _accountService.GetEmail(organiser);
        }
    }
}
