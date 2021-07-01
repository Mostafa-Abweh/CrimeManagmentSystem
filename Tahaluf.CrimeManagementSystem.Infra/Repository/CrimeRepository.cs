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
        public List<Crime> GetAll()
        {
            List<Crime> result = (List<Crime>)_dBContext.Connection.Query<Crime>("GetAllCrime", commandType: CommandType.StoredProcedure);

            return result;
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
        public Crime GetById(int id)
        {
            var p = new DynamicParameters();
            p.Add("@CrimeId", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            Crime result = (Crime)_dBContext.Connection.Query<Crime>("GetByIdCrime", p, commandType: CommandType.StoredProcedure);
            return result;
        }
        public List<Crime> Search(CrimeDTO crimeDTO)
        {
            var p = new DynamicParameters();
            p.Add("@SectionName", crimeDTO.CrimeTtile, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@SectionName", crimeDTO.SortType, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@CrimeId", crimeDTO.SortingCol, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@CrimeId", crimeDTO.Location, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@CrimeId", crimeDTO.JudgeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@CrimeId", crimeDTO.SectionId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@CrimeId", crimeDTO.AcussedId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@CrimeId", crimeDTO.WitnessId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@CrimeId", crimeDTO.VictimId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@CrimeId", crimeDTO.OfficerId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@CrimeId", crimeDTO.LawyerId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@CrimeId", crimeDTO.EvidenceId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@CrimeId", crimeDTO.PoliceStationId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@CrimeId", crimeDTO.PageNumber, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@CrimeId", crimeDTO.RowsOfPage, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@CrimeId", crimeDTO.TotalCount, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@CrimeId", crimeDTO.DateFrom, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("@CrimeId", crimeDTO.DateTo, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            IEnumerable<Crime> result = (List<Crime>)_dBContext.Connection.Query<Crime>("SearchJudge", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
    }
}
