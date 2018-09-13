using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CareerCloud.BusinessLogicLayer;
using CareerCloud.EntityFrameworkDataAccess;
using CareerCloud.Pocos;

namespace CareerCloud.WCF
{
    public class Applicant : IApplicant
    {
        //ApplicantEducation

        public void AddApplicantEducation(ApplicantEducationPoco[] pocos)
        {
            var repo = new EFGenericRepository<ApplicantEducationPoco>(false);
            var logic = new ApplicantEducationLogic(repo);
            logic.Add(pocos);
        }

        public List<ApplicantEducationPoco> GetAllApplicantEducation()
        {
            var repo = new EFGenericRepository<ApplicantEducationPoco>(false);
            var logic = new ApplicantEducationLogic(repo);
            return logic.GetAll();
        }

        public ApplicantEducationPoco GetSingleApplicantEducation(string Id)
        {
            var repo = new EFGenericRepository<ApplicantEducationPoco>(false);
            var logic = new ApplicantEducationLogic(repo);
            return logic.Get(Guid.Parse(Id));
        }

        public void RemoveApplicantEducation(ApplicantEducationPoco[] pocos)
        {
            var repo = new EFGenericRepository<ApplicantEducationPoco>(false);
            var logic = new ApplicantEducationLogic(repo);
            logic.Delete(pocos);
        }

        public void UpdateApplicantEducation(ApplicantEducationPoco[] pocos)
        {
            var repo = new EFGenericRepository<ApplicantEducationPoco>(false);
            var logic = new ApplicantEducationLogic(repo);
            logic.Update(pocos);
        }

        // ApplicantJobApplication

        public void AddApplicantJobApplication(ApplicantJobApplicationPoco[] pocos)
        {
            var repo = new EFGenericRepository<ApplicantJobApplicationPoco>(false);
            var logic = new ApplicantJobApplicationLogic(repo);
            logic.Add(pocos);
        }

        public List<ApplicantJobApplicationPoco> GetAllApplicantJobApplication()
        {
            var repo = new EFGenericRepository<ApplicantJobApplicationPoco>(false);
            var logic = new ApplicantJobApplicationLogic(repo);
            return logic.GetAll();
        }

        public ApplicantJobApplicationPoco GetSingleApplicantJobApplication(string Id)
        {
            var repo = new EFGenericRepository<ApplicantJobApplicationPoco>(false);
            var logic = new ApplicantJobApplicationLogic(repo);
            return logic.Get(Guid.Parse(Id));
        }

        public void RemoveApplicantJobApplication(ApplicantJobApplicationPoco[] pocos)
        {
            var repo = new EFGenericRepository<ApplicantJobApplicationPoco>(false);
            var logic = new ApplicantJobApplicationLogic(repo);
            logic.Delete(pocos);
        }
        public void UpdateApplicantJobApplication(ApplicantJobApplicationPoco[] pocos)
        {
            var repo = new EFGenericRepository<ApplicantJobApplicationPoco>(false);
            var logic = new ApplicantJobApplicationLogic(repo);
            logic.Update(pocos);
        }

        // ApplicantProfile

        public void AddApplicantProfile(ApplicantProfilePoco[] pocos)
        {
            var repo = new EFGenericRepository<ApplicantProfilePoco>(false);
            var logic = new ApplicantProfileLogic(repo);
            logic.Add(pocos);

        }

        public List<ApplicantProfilePoco> GetAllApplicantProfile()
        {
            var repo = new EFGenericRepository<ApplicantProfilePoco>(false);
            var logic = new ApplicantProfileLogic(repo);
            return logic.GetAll();
        }

        public ApplicantProfilePoco GetSingleApplicantProfile(string Id)
        {
            var repo = new EFGenericRepository<ApplicantProfilePoco>(false);
            var logic = new ApplicantProfileLogic(repo);
            return logic.Get(Guid.Parse(Id));
        }

        public void RemoveApplicantProfile(ApplicantProfilePoco[] pocos)
        {
            var repo = new EFGenericRepository<ApplicantProfilePoco>(false);
            var logic = new ApplicantProfileLogic(repo);
            logic.Delete(pocos);
        }

        public void UpdateApplicantProfile(ApplicantProfilePoco[] pocos)
        {
            var repo = new EFGenericRepository<ApplicantProfilePoco>(false);
            var logic = new ApplicantProfileLogic(repo);
            logic.Update(pocos);
        }

        // ApplicantResume

        public void AddApplicantResume(ApplicantResumePoco[] pocos)
        {
            var repo = new EFGenericRepository<ApplicantResumePoco>(false);
            var logic = new ApplicantResumeLogic(repo);
            logic.Add(pocos);
        }

        public void UpdateApplicantResume(ApplicantResumePoco[] pocos)
        {
            var repo = new EFGenericRepository<ApplicantResumePoco>(false);
            var logic = new ApplicantResumeLogic(repo);
            logic.Update(pocos);
        }

        public ApplicantResumePoco GetSingleApplicantResume(string Id)
        {
            var repo = new EFGenericRepository<ApplicantResumePoco>(false);
            var logic = new ApplicantResumeLogic(repo);
            return logic.Get(Guid.Parse(Id));
        }

        public void RemoveApplicantResume(ApplicantResumePoco[] pocos)
        {
            var repo = new EFGenericRepository<ApplicantResumePoco>(false);
            var logic = new ApplicantResumeLogic(repo);
            logic.Delete(pocos);
        }

        public List<ApplicantResumePoco> GetAllApplicantResume()
        {
            var repo = new EFGenericRepository<ApplicantResumePoco>(false);
            var logic = new ApplicantResumeLogic(repo);
            return logic.GetAll();
        }


        // ApplicantSkill

        public void AddApplicantSkill(ApplicantSkillPoco[] pocos)
        {
            var repo = new EFGenericRepository<ApplicantSkillPoco>(false);
            var logic = new ApplicantSkillLogic(repo);
            logic.Add(pocos);
        }

        public void UpdateApplicantSkill(ApplicantSkillPoco[] pocos)
        {
            var repo = new EFGenericRepository<ApplicantSkillPoco>(false);
            var logic = new ApplicantSkillLogic(repo);
            logic.Update(pocos);
        }

        public List<ApplicantSkillPoco> GetAllApplicantSkill()
        {
            var repo = new EFGenericRepository<ApplicantSkillPoco>(false);
            var logic = new ApplicantSkillLogic(repo);
            return logic.GetAll();
        }

        public ApplicantSkillPoco GetSingleApplicantSkill(string Id)
        {
            var repo = new EFGenericRepository<ApplicantSkillPoco>(false);
            var logic = new ApplicantSkillLogic(repo);
            return logic.Get(Guid.Parse(Id));
        }

        public void RemoveApplicantSkill(ApplicantSkillPoco[] pocos)
        {
            var repo = new EFGenericRepository<ApplicantSkillPoco>(false);
            var logic = new ApplicantSkillLogic(repo);
            logic.Delete(pocos);
        }

        // ApplicantWorkHistory

        public void AddApplicantWorkHistory(ApplicantWorkHistoryPoco[] pocos)
        {
            var repo = new EFGenericRepository<ApplicantWorkHistoryPoco>(false);
            var logic = new ApplicantWorkHistoryLogic(repo);
            logic.Add(pocos);
        }

        public List<ApplicantWorkHistoryPoco> GetAllApplicantWorkHistory()
        {
            var repo = new EFGenericRepository<ApplicantWorkHistoryPoco>(false);
            var logic = new ApplicantWorkHistoryLogic(repo);
            return logic.GetAll();
        }

        public ApplicantWorkHistoryPoco GetSingleApplicantWorkHistory(string Id)
        {
            var repo = new EFGenericRepository<ApplicantWorkHistoryPoco>(false);
            var logic = new ApplicantWorkHistoryLogic(repo);
            return logic.Get(Guid.Parse(Id));
        }

        public void RemoveApplicantWorkHistory(ApplicantWorkHistoryPoco[] pocos)
        {
            var repo = new EFGenericRepository<ApplicantWorkHistoryPoco>(false);
            var logic = new ApplicantWorkHistoryLogic(repo);
            logic.Delete(pocos);
        }

        public void UpdateApplicantWorkHistory(ApplicantWorkHistoryPoco[] pocos)
        {
            var repo = new EFGenericRepository<ApplicantWorkHistoryPoco>(false);
            var logic = new ApplicantWorkHistoryLogic(repo);
            logic.Update(pocos);
        }

        
    }
}
