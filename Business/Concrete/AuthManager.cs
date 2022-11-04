using Business.Abstract;
using Business.Constants;
using Core.Entities.Concrete;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using Core.Utilities.Security.Hashing;
using Core.Utilities.Security.Jwt;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
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

        public IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);
            var user = new User
            {
                Email = userForRegisterDto.Email,
                FirstName = userForRegisterDto.FirstName,
                LastName = userForRegisterDto.LastName,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                Status = true
            };
            _userService.Add(user);
            return new DataSuccessResult<User>(user, "Kayıt İşlemi Başarıyla gerçekleşti");
        }

        public IDataResult<User> Login(UserForLoginDto userForLoginDto)
        {
            var userToCheck = _userService.Get(userForLoginDto.Email);
            if (userToCheck.Data == null)
            {
                return new DataErrorResult<User>("Bu Emaile Kayıtlı Bir hesap Bulunamadı");
            }

            if (!HashingHelper.VerifyPaswordHash(userForLoginDto.Password, userToCheck.Data.PasswordHash, userToCheck.Data.PasswordSalt))
            {
                return new DataErrorResult<User>("Parolanız Hatalı");
            }

            return new DataSuccessResult<User>(userToCheck.Data, "Giriş İşlemi Başarıyla gerçekleştiridi");
        }

        public IResult UserExists(string email)
        {
            if (_userService.Get(email).Data != null)
            {
                return new ErrorResult("Girilen Email ile Kayıtlı bir mail bulunmaktadır");
            }
            return new SuccessResult();
        }

        public IDataResult<AccessToken> CreateAccessToken(User user)
        {
            var claims = _userService.GetByUsersOperationClaim(user).Data;
            var accessToken = _tokenHelper.CreateToken(user, claims);
            return new DataSuccessResult<AccessToken>(accessToken, "");
        }

    }
}
