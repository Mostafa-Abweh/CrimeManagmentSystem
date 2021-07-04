using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tahaluf.CrimeManagementSystem.Core.Common;
using Tahaluf.CrimeManagementSystem.Core.Data;
using Tahaluf.CrimeManagementSystem.Core.DTOs;
using Tahaluf.CrimeManagementSystem.Core.Repository;

namespace Tahaluf.CrimeManagementSystem.Infra.Repository
{
  public class CrimeRepository: ICrimeRepository
    {
        private readonly IDBContext _dBContext;
        public CrimeRepository(IDBContext _dBContext) { this._dBContext = _dBContext; }
        public int Create(Crime crime)
        {
            var p = new DynamicParameters();

            p.Add("@Report", crime.Report, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@DateOfOffence", crime.DateOfOffence, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("@TimeOfCrime", crime.TimeOfCrime, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("@DateOfReport", crime.DateOfReport, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("@CaseStatus", crime.CaseStatus, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@FirId", crime.FIRId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@Description", crime.Description, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Location", crime.Location, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@CloseDate", crime.CloseDate, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@CrimeTitle", crime.CrimeTitle, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = _dBContext.Connection.ExecuteAsync("InsertCrime", p, commandType: CommandType.StoredProcedure);
            return 1;
        }
        public async  Task<List<Crime>> GetAll()
        {
            var result = await _dBContext.Connection.QueryAsync<Crime>("GetAllCrime", commandType: CommandType.StoredProcedure);

            return result.ToList();
        }
        public int Update(Crime crime)
        {
            var p = new DynamicParameters();
            p.Add("@CrimeId", crime.CrimeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@Report", crime.Report, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@DateOfOffence", crime.DateOfOffence, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("@TimeOfCrime", crime.TimeOfCrime, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("@DateOfReport", crime.DateOfReport, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("@CaseStatus", crime.CaseStatus, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@FirId", crime.FIRId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@Description", crime.Description, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Location", crime.Location, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@CloseDate", crime.CloseDate, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@CrimeTitle", crime.CrimeTitle, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = _dBContext.Connection.ExecuteAsync("UpdateCrime", p, commandType: CommandType.StoredProcedure);
            return 1;
        }
        public bool Delete(int id)
        {
            var p = new DynamicParameters();
            p.Add("@CrimeId", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dBContext.Connection.ExecuteAsync("DeleteCrime", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public async Task<List<Crime>> GetById(int id)
        {
            var p = new DynamicParameters();
            p.Add("@CrimeId", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = await _dBContext.Connection.QueryAsync<Crime>("GetByIdCrime", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
        public async Task<List<Crime>> Search(CrimeDTO crimeDTO)
        {
            var p = new DynamicParameters();
            p.Add("@CrimeTtile", crimeDTO.CrimeTtile, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@SortType", crimeDTO.SortType, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@SortingCol", crimeDTO.SortingCol, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Location", crimeDTO.Location, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@JudgeId", crimeDTO.JudgeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@SectionId", crimeDTO.SectionId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@AcussedId", crimeDTO.AcussedId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@WitnessId", crimeDTO.WitnessId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@VictimId", crimeDTO.VictimId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@OfficerId", crimeDTO.OfficerId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@LawyerId", crimeDTO.LawyerId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@EvidenceId", crimeDTO.EvidenceId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@PoliceStationId", crimeDTO.PoliceStationId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@PageNumber", crimeDTO.PageNumber, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@RowsOfPage", crimeDTO.RowsOfPage, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@TotalCount", crimeDTO.TotalCount, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@DateFrom", crimeDTO.DateFrom, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("@DateTo", crimeDTO.DateTo, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            var result = await _dBContext.Connection.QueryAsync<Crime>("SearchJudge", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
    }
}
