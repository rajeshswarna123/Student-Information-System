using AutoMapper;
using SIS.Core.ClientContext;
using SIS.Core.JWTHelper;
using SIS.Interfaces.Repositories;
using SIS.Interfaces.Services;
using SIS.Models;
using System;
using System.Linq;

namespace SIS.Services
{
    public class SecurityService : ISecurityService
    {
        private readonly ISecurityRepository _securityRepository;
        private JwtIssuerOptions _jwtIssuerOptions { get; set; }

        private readonly IMapper _mapper;
        public SecurityService(ISecurityRepository securityRepository, JwtIssuerOptions jwtIssuerOptions,
                           IMapper mapper)
        {
            this._securityRepository = securityRepository;
            _mapper = mapper;
            _jwtIssuerOptions = jwtIssuerOptions;
        }
        public UserProfile Login(string email, string password)
        {
            var users = _securityRepository.GetByCondition(user => user.Email.ToLower() == email.ToLower());
            if (users.Count() == 0)
            {
                throw new UnauthorizedException("User not found");
            }
            var user = users.First();
            if(!password.Equals(user.Password, StringComparison.InvariantCultureIgnoreCase))
            {
                throw new UnauthorizedException("Invalid Credentitals!");
            }
            //if (!EncryptionHelper.VerifyMd5Hash(password, user.Password))
            //{
            //    throw new UnauthorizedException("Invalid Credentitals!");
            //}
            var userProfile = _mapper.Map<UserProfile>(user);
            userProfile.Token = JwtTokenHelper.GenerateJSONWebToken(_jwtIssuerOptions, user.Id);
            return userProfile;
        }
    }
}
