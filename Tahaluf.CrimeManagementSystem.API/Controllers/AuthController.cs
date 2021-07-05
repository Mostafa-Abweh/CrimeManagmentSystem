//using Dapper;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Linq;
//using System.Threading.Tasks;
//using Tahaluf.CrimeManagementSystem.Core.Common;
//using Tahaluf.CrimeManagementSystem.Core.Data;
//using Tahaluf.CrimeManagementSystem.Core.DTOs;

//namespace Tahaluf.CrimeManagementSystem.API.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class AuthController : ControllerBase
//    {
//        private readonly IDBContext _dbContext;
//        [Route("Login")]
//        [HttpPost]
//        [ProducesResponseType(typeof(LoginDTO), StatusCodes.Status200OK)]
//        [ProducesResponseType(StatusCodes.Status400BadRequest)]
//        public async Task<string> Login(LoginDTO loginDTO) 
//        {
//            var _queryParameters = new DynamicParameters();
//            loginDTO.Password = _passwordHasher.HashPassword(loginDTO.Password);
//            _queryParameters.Add("@UserName", loginDTO.UserName, dbType: DbType.String, direction: ParameterDirection.Input);
//            _queryParameters.Add("@Password", loginDTO.Password, dbType: DbType.String, direction: ParameterDirection.Input);
//            var result = await _dbContext.Connection.QueryAsync<User, UserRoles, Permission, User>("SignIn"
//            , (user, userRole, permission) => {
//                user.Role = userRole;
//                user.Role.Permissions = user.Role.Permissions ?? new List<Permission>();
//                if (permission != null)
//                {
//                    user.Role.Permissions.Add(permission);
//                }
//                return user;
//            }
//            , splitOn: "RoleId,PermissionId"
//            , transaction: _dbContext.Transaction
//            , param: _queryParameters
//            , commandType: CommandType.StoredProcedure);

//            User user = new User
//            {
//                UserName=result.FirstOrDefault().UserName,
//                Email = result.FirstOrDefault().Email,
//                Gender = result.FirstOrDefault().Gender,
//                EmailIsConfirmed = result.FirstOrDefault().EmailIsConfirmed,
//                DateOfBirth = result.FirstOrDefault().DateOfBirth,
//                PhoneNumber = result.FirstOrDefault().PhoneNumber,
//                UserId = result.FirstOrDefault().UserId,
//                Role = new UserRole()
//                {
//                    RoleName = result.FirstOrDefault().Role.RoleName,
//                    RoleId = result.FirstOrDefault().Role.RoleId,
//                    Permissions = new HashSet<Permission>()
//                },

//            };
//            foreach (var item in result)
//            {
//                user.UserRoles.Role.RolePermissions.Permission.Add(item.User.UserRoles.Role..RolePermissions.Permission.FirstOrDefault());
//            }

//            var userPermissions = String.Join(",", user.Role.Permissions.Select(r => r.PermissionName));

//            var tokenHandler = new JwtSecurityTokenHandler();
//            var tokenKey = Encoding.ASCII.GetBytes(_configManager.Key);
//            var tokenDescriptor = new SecurityTokenDescriptor
//            {
//                Subject = new ClaimsIdentity(new Claim[]
//            {
//                    new Claim(CustomClaimTypes.FullNameEn, user.FirstName+" " + user.LastName),
//                    new Claim(CustomClaimTypes.UserId,Convert.ToString(user.UserId)),
//                    new Claim(CustomClaimTypes.Role, user.Role.RoleName),
//                    new Claim(CustomClaimTypes.Permission, userPermissions)
//            }),
//                Expires = DateTime.UtcNow.AddHours(1),
//                SigningCredentials = new SigningCredentials(
//            new SymmetricSecurityKey(tokenKey),
//            SecurityAlgorithms.HmacSha256Signature)
//            };
//            var token = tokenHandler.CreateToken(tokenDescriptor);
//            return tokenHandler.WriteToken(token);
//        }


//        [Route("Register")]
//        [HttpPost]
//        [ProducesResponseType(typeof(RegisterDTO), StatusCodes.Status200OK)]
//        [ProducesResponseType(StatusCodes.Status400BadRequest)]
//        public bool Register()         {

//            return false;
//        }
        



//    }
//}
