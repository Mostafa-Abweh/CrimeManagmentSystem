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


        public bool SignVictimToCrime(VictimFile victimFile) 
        {
            var p = new DynamicParameters();
            p.Add("@VictimId", victimFile.VictimId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@CrimeId", victimFile.CrimeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dBContext.Connection.ExecuteAsync("InsertVictimFile", p, commandType: CommandType.StoredProcedure);
            return true;
        } 
        public bool SignSectionToCrime(SectionFile sectionFile) 
        {
            var p = new DynamicParameters();
            p.Add("@SectionId", sectionFile.SectionId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@CrimeId", sectionFile.CrimeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dBContext.Connection.ExecuteAsync("InsertSectionFile", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool SignAcussedToCrime(AcussedFile acussedFile) 
        {
            var p = new DynamicParameters();
            p.Add("@AcussedId", acussedFile.AcussedId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@CrimeId", acussedFile.CrimeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dBContext.Connection.ExecuteAsync("InsertAcussedFile", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool SignWitnessToCrime(WitnessFile witnessFile) 
        {
            var p = new DynamicParameters();
            p.Add("@WitnessId", witnessFile.WitnessId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@CrimeId", witnessFile.CrimeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dBContext.Connection.ExecuteAsync("InsertWitnessFile", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool SignOfficerToCrime(OfficerFile officerFile) 
        {
            var p = new DynamicParameters();
            p.Add("@OfficerId", officerFile.OfficerId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@CrimeId", officerFile.CrimeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dBContext.Connection.ExecuteAsync("InsertOfficerFile", p, commandType: CommandType.StoredProcedure);
            return true;
        } 
        public bool SignStationToCrime(PoliceStationFile policeStationFile) 
        {
            var p = new DynamicParameters();
            p.Add("@PoliceStationId", policeStationFile.PoliceStationId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@CrimeId", policeStationFile.CrimeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dBContext.Connection.ExecuteAsync("InsertPoliceStationFile", p, commandType: CommandType.StoredProcedure);
            return true;
        } 
        public bool SignLawyerToCrime(LawyerFile lawyerFile) 
        {
            var p = new DynamicParameters();
            p.Add("@LawyerId", lawyerFile.LawyerId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@CrimeId", lawyerFile.CrimeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dBContext.Connection.ExecuteAsync("InsertLawyerFile", p, commandType: CommandType.StoredProcedure);
            return true;
        } 
        public bool SignEvidenceToCrime(EvidenceFile evidenceFile) 
        {
            var p = new DynamicParameters();
            p.Add("@EvidenceId", evidenceFile.EvidenceId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@CrimeId", evidenceFile.CrimeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dBContext.Connection.ExecuteAsync("InsertEvidenceFile", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool SignJudgeToCrime(JudgeFile judgeFile) 
        {
            var p = new DynamicParameters();
            p.Add("@JudgeId", judgeFile.JudgeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@CrimeId", judgeFile.CrimeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dBContext.Connection.ExecuteAsync("InsertJudgeFile", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        //****************************************************UnSign*********************************************************************
        public bool UnSignVictimToCrime(VictimFile victimFile) 
        {
            var p = new DynamicParameters();
            p.Add("@VictimId", victimFile.VictimId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@CrimeId", victimFile.CrimeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dBContext.Connection.ExecuteAsync("DeleteVictimFile", p, commandType: CommandType.StoredProcedure);
            return true;
        } 
        public bool UnSignSectionToCrime(SectionFile sectionFile) 
        {
            var p = new DynamicParameters();
            p.Add("@SectionId", sectionFile.SectionId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@CrimeId", sectionFile.CrimeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dBContext.Connection.ExecuteAsync("DeleteSectionFile", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool UnSignAcussedToCrime(AcussedFile acussedFile) 
        {
            var p = new DynamicParameters();
            p.Add("@AcussedId", acussedFile.AcussedId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@CrimeId", acussedFile.CrimeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dBContext.Connection.ExecuteAsync("DeleteAcussedFile", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool UnSignWitnessToCrime(WitnessFile witnessFile) 
        {
            var p = new DynamicParameters();
            p.Add("@WitnessId", witnessFile.WitnessId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@CrimeId", witnessFile.CrimeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dBContext.Connection.ExecuteAsync("DeleteWitnessFile", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool UnSignOfficerToCrime(OfficerFile officerFile) 
        {
            var p = new DynamicParameters();
            p.Add("@OfficerId", officerFile.OfficerId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@CrimeId", officerFile.CrimeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dBContext.Connection.ExecuteAsync("DeleteOfficerFile", p, commandType: CommandType.StoredProcedure);
            return true;
        } 
        public bool UnSignStationToCrime(PoliceStationFile policeStationFile) 
        {
            var p = new DynamicParameters();
            p.Add("@PoliceStationId", policeStationFile.PoliceStationId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@CrimeId", policeStationFile.CrimeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dBContext.Connection.ExecuteAsync("DeletePoliceStationFile", p, commandType: CommandType.StoredProcedure);
            return true;
        } 
        public bool UnSignLawyerToCrime(LawyerFile lawyerFile) 
        {
            var p = new DynamicParameters();
            p.Add("@LawyerId", lawyerFile.LawyerId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@CrimeId", lawyerFile.CrimeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dBContext.Connection.ExecuteAsync("DeleteLawyerFile", p, commandType: CommandType.StoredProcedure);
            return true;
        } 
        public bool UnSignEvidenceToCrime(EvidenceFile evidenceFile) 
        {
            var p = new DynamicParameters();
            p.Add("@EvidenceId", evidenceFile.EvidenceId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@CrimeId", evidenceFile.CrimeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dBContext.Connection.ExecuteAsync("DeleteEvidenceFile", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool UnSignJudgeToCrime(JudgeFile judgeFile) 
        {
            var p = new DynamicParameters();
            p.Add("@JudgeId", judgeFile.JudgeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@CrimeId", judgeFile.CrimeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dBContext.Connection.ExecuteAsync("DeleteJudgeFile", p, commandType: CommandType.StoredProcedure);
            return true;
        } 
        
        
        //*****************************************************UpdateSign**********************************************************************
        
        public bool UpdateSignVictimToCrime(VictimFile victimFile,int NewCrimeId, int NewVictimId) 
        {
            var p = new DynamicParameters();
            p.Add("@VictimId", victimFile.VictimId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@NewVictimId", NewVictimId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@CrimeId", victimFile.CrimeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@NewCrimeId", NewCrimeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dBContext.Connection.ExecuteAsync("UpdateVictimFile", p, commandType: CommandType.StoredProcedure);
            return true;
        } 
        public bool UpdateSignSectionToCrime(SectionFile sectionFile, int NewCrimeId, int NewSectionId) 
        {
            var p = new DynamicParameters();
            p.Add("@SectionId", sectionFile.SectionId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@NewSectionId", NewSectionId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@CrimeId", sectionFile.CrimeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@NewCrimeId", NewCrimeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dBContext.Connection.ExecuteAsync("UpdateSectionFile", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool UpdateSignAcussedToCrime(AcussedFile acussedFile, int NewCrimeId, int NewAcussedId) 
        {
            var p = new DynamicParameters();
            p.Add("@AcussedId", acussedFile.AcussedId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@NewAcussedId", NewAcussedId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@CrimeId", acussedFile.CrimeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@NewCrimeId", NewCrimeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dBContext.Connection.ExecuteAsync("UpdateAcussedFile", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool UpdateSignWitnessToCrime(WitnessFile witnessFile, int NewCrimeId, int NewWitnessId) 
        {
            var p = new DynamicParameters();
            p.Add("@WitnessId", witnessFile.WitnessId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@NewWitnessId", NewWitnessId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@CrimeId", witnessFile.CrimeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@NewCrimeId", NewCrimeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dBContext.Connection.ExecuteAsync("UpdateWitnessFile", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool UpdateSignOfficerToCrime(OfficerFile officerFile, int NewCrimeId, int NewOfficerId) 
        {
            var p = new DynamicParameters();
            p.Add("@OfficerId", officerFile.OfficerId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@NewOfficerId", NewOfficerId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@CrimeId", officerFile.CrimeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@NewCrimeId", NewCrimeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dBContext.Connection.ExecuteAsync("UpdateOfficerFile", p, commandType: CommandType.StoredProcedure);
            return true;
        } 
        public bool UpdateSignStationToCrime(PoliceStationFile policeStationFile, int NewCrimeId, int NewPoliceStationId) 
        {
            var p = new DynamicParameters();
            p.Add("@PoliceStationId", policeStationFile.PoliceStationId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@NewPoliceStationId", NewPoliceStationId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@CrimeId", policeStationFile.CrimeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@NewCrimeId", NewCrimeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dBContext.Connection.ExecuteAsync("UpdatePoliceStationFile", p, commandType: CommandType.StoredProcedure);
            return true;
        } 
        public bool UpdateSignLawyerToCrime(LawyerFile lawyerFile, int NewCrimeId, int NewLawyerId) 
        {
            var p = new DynamicParameters();
            p.Add("@LawyerId", lawyerFile.LawyerId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@NewLawyerId", NewLawyerId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@CrimeId", lawyerFile.CrimeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@NewCrimeId", NewCrimeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dBContext.Connection.ExecuteAsync("UpdateLawyerFile", p, commandType: CommandType.StoredProcedure);
            return true;
        } 
        public bool UpdateSignEvidenceToCrime(EvidenceFile evidenceFile, int NewCrimeId, int NewEvidenceId) 
        {
            var p = new DynamicParameters();
            p.Add("@EvidenceId", evidenceFile.EvidenceId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@NewEvidenceId", NewEvidenceId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@CrimeId", evidenceFile.CrimeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@NewCrimeId", NewCrimeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dBContext.Connection.ExecuteAsync("UpdateEvidenceFile", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool UpdateSignJudgeToCrime(JudgeFile judgeFile, int NewCrimeId, int NewJudgeId) 
        {
            var p = new DynamicParameters();
            p.Add("@JudgeId", judgeFile.JudgeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@NewJudgeId", NewJudgeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@CrimeId", judgeFile.CrimeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@NewCrimeId", NewCrimeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dBContext.Connection.ExecuteAsync("UpdateJudgeFile", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        //*****************************************GetAll****************************************************************
        //public async Task<List<Crime>> GetAll(int id)
        //{
        //    var p = new DynamicParameters();
        //    p.Add("@CrimeId", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
        //    var result = await _dBContext.Connection.QueryAsync<Crime>("GetByIdCrime", p, commandType: CommandType.StoredProcedure);
        //    return result.ToList();
        //}

    }
}
