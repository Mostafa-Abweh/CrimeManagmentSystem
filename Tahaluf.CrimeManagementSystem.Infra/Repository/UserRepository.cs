using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tahaluf.CrimeManagementSystem.Core.Common;
using Tahaluf.CrimeManagementSystem.Core.Data;
using Tahaluf.CrimeManagementSystem.Core.Repository;

namespace Tahaluf.CrimeManagementSystem.Infra.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly IDBContext _dBContext;
        public UserRepository(IDBContext _dBContext)
        { this._dBContext = _dBContext; }
        public int Create(User user)
        {
            var p = new DynamicParameters();

            p.Add("@UserId", user.UserId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@UserName", user.UserName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@UserPassword", user.UserPassword, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@IdentityNumber", user.IdentityNumber, dbType: DbType.String, direction: ParameterDirection.Input);

            var result = _dBContext.Connection.ExecuteAsync("InsertUser", p, commandType: CommandType.StoredProcedure);
            return 1;
        }
        public async Task<List<User>> GetAll()
        {
            var result = await _dBContext.Connection.QueryAsync<User>("GetALLUser", commandType: CommandType.StoredProcedure);

            return result.ToList();
        }
        public int Update(User user)
        {
            var p = new DynamicParameters();

            p.Add("@UserId", user.UserId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@UserName", user.UserName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@UserPassword", user.UserPassword, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@IdentityNumber", user.IdentityNumber, dbType: DbType.String, direction: ParameterDirection.Input);

            var result = _dBContext.Connection.ExecuteAsync("UpdateUser", p, commandType: CommandType.StoredProcedure);
            return 1;

        }
        public bool Delete(int id)
        {
            var p = new DynamicParameters();
            p.Add("@UserId", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dBContext.Connection.ExecuteAsync("DeleteUser", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public async Task<List<User>> GetById(int id)
        {
            var p = new DynamicParameters();
            p.Add("@UserId", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = await _dBContext.Connection.QueryAsync<User>("GetByIdUser", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }


    }
}
