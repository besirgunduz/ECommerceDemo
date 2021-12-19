using ECommerceDemo.Business.Engines.Interfaces;
using ECommerceDemo.Business.Engines.Models;
using ECommerceDemo.Core.Utilities.Results;
using ECommerceDemo.Data.DAL.Security.Hashing;
using ECommerceDemo.Data.DAL.Security.JWT;
using ECommerceDemo.Data.Entities;
using System;

namespace ECommerceDemo.Business.Engines.Implementations
{
    public class AuthManager : IAuthService
    {
        private IUserService _userService;
        private ITokenHelper _tokenHelper;

        public AuthManager(IUserService userService, ITokenHelper tokenHelper)
        {
            _userService = userService;
            _tokenHelper = tokenHelper;
        }

        public IDataResult<User> Register(UserForRegisterModel userForRegisterModel, string password)
        {
            try
            {
                byte[] passwordHash, passwordSalt;
                HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);
                var user = new User
                {
                    Email = userForRegisterModel.Email,
                    FirstName = userForRegisterModel.FirstName,
                    LastName = userForRegisterModel.LastName,
                    PasswordHash = passwordHash,
                    PasswordSalt = passwordSalt,
                    Status = true
                };
                _userService.Add(user);
                return new SuccessDataResult<User>(user, "Added");
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<User>($"Error:{ex.Message}");

            }
        }

        public IDataResult<User> Login(UserForLoginModel userForLoginModel)
        {
            var userToCheck = _userService.GetByMail(userForLoginModel.Email);
            if (userToCheck == null)
            {
                return new ErrorDataResult<User>("User not found");
            }

            if (!HashingHelper.VerifyPasswordHash(userForLoginModel.Password, userToCheck.PasswordHash, userToCheck.PasswordSalt))
            {
                return new ErrorDataResult<User>("Password Error");
            }

            return new SuccessDataResult<User>(userToCheck, "Successful Login");
        }

        public IResult UserExists(string email)
        {
            if (_userService.GetByMail(email) != null)
            {
                return new ErrorResult("User Available");
            }
            return new SuccessResult();
        }

        public IDataResult<AccessToken> CreateAccessToken(User user)
        {
            try
            {
                var claims = _userService.GetClaims(user);
                var accessToken = _tokenHelper.CreateToken(user, claims);
                return new SuccessDataResult<AccessToken>(accessToken, "Token created");
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<AccessToken>($"Error:{ex.Message}");
            }
        }
    }
}
