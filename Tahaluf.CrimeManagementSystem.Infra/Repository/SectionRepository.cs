using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Tahaluf.CrimeManagementSystem.Core.Common;
using Tahaluf.CrimeManagementSystem.Core.Data;
using Tahaluf.CrimeManagementSystem.Core.DTOs;
using Tahaluf.CrimeManagementSystem.Core.Repository;

namespace Tahaluf.CrimeManagementSystem.Infra.Repository
{
    public class SectionRepository: ISectionRepository
    {
        private readonly IDBContext _dBContext;
        public SectionRepository(IDBContext _dBContext) { this._dBContext = _dBContext; }
        public int Create(Section section)
        {
            var p = new DynamicParameters();

            p.Add("@SectionName", section.SectionName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Description", section.Description, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = _dBContext.Connection.ExecuteAsync("InsertSection", p, commandType: CommandType.StoredProcedure);
            return 1;
        }
        public List<Section> GetAll()
        {
            List<Section> result = (List<Section>)_dBContext.Connection.Query<Section>("GetAllSection", commandType: CommandType.StoredProcedure);

            return result;
        }
        public int Update(Section section)
        {
            var p = new DynamicParameters();
            p.Add("@SectionId", section.SectionId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@SectionName", section.SectionName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Description", section.Description, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = _dBContext.Connection.ExecuteAsync("UpdateSection", p, commandType: CommandType.StoredProcedure);
            return 1;
        }
        public bool Delete(int id)
        {
            var p = new DynamicParameters();
            p.Add("@SectionId", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dBContext.Connection.ExecuteAsync("DeleteSection", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public Section GetById(int id)
        {
            var p = new DynamicParameters();
            p.Add("@SectionId", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            Section result = (Section)_dBContext.Connection.Query<Section>("GetByIdSection", p, commandType: CommandType.StoredProcedure);
            return result;
        }
        public List<Section> Search(SectionDTO sectionDTO)
        {
            var p = new DynamicParameters();
            p.Add("@SectionName", sectionDTO.SectionName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@CrimeId", sectionDTO.CrimeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<Section> result = (List<Section>)_dBContext.Connection.Query<Section>("SearchJudge", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
    }
}
