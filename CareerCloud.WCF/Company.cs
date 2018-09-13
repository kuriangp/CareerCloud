using CareerCloud.BusinessLogicLayer;
using CareerCloud.EntityFrameworkDataAccess;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.WCF
{
    public class Company : ICompany
    {
        // CompanyDescription
        public void AddCompanyDescription(CompanyDescriptionPoco[] pocos)
        {
            var repo = new EFGenericRepository<CompanyDescriptionPoco>(false);
            var logic = new CompanyDescriptionLogic(repo);
            logic.Add(pocos);
        }

        public List<CompanyDescriptionPoco> GetAllCompanyDescription()
        {
            var repo = new EFGenericRepository<CompanyDescriptionPoco>(false);
            var logic = new CompanyDescriptionLogic(repo);
            return logic.GetAll();
        }

        public CompanyDescriptionPoco GetSingleCompanyDescription(string Id)
        {
            var repo = new EFGenericRepository<CompanyDescriptionPoco>(false);
            var logic = new CompanyDescriptionLogic(repo);
            return logic.Get(Guid.Parse(Id));
        }

        public void RemoveCompanyDescription(CompanyDescriptionPoco[] pocos)
        {
            var repo = new EFGenericRepository<CompanyDescriptionPoco>(false);
            var logic = new CompanyDescriptionLogic(repo);
            logic.Delete(pocos);
        }

        public void UpdateCompanyDescription(CompanyDescriptionPoco[] pocos)
        {
            var repo = new EFGenericRepository<CompanyDescriptionPoco>(false);
            var logic = new CompanyDescriptionLogic(repo);
            logic.Update(pocos);
        }

        // CompanyJobDescription

        public void AddCompanyJobDescription(CompanyJobDescriptionPoco[] pocos)
        {
            var repo = new EFGenericRepository<CompanyJobDescriptionPoco>(false);
            var logic = new CompanyJobDescriptionLogic(repo);
            logic.Add(pocos);
        }

        public List<CompanyJobDescriptionPoco> GetAllCompanyJobDescription()
        {
            var repo = new EFGenericRepository<CompanyJobDescriptionPoco>(false);
            var logic = new CompanyJobDescriptionLogic(repo);
            return logic.GetAll();
        }

        public CompanyJobDescriptionPoco GetSingleCompanyJobDescription(string Id)
        {
            var repo = new EFGenericRepository<CompanyJobDescriptionPoco>(false);
            var logic = new CompanyJobDescriptionLogic(repo);
            return logic.Get(Guid.Parse(Id));
        }

        public void RemoveCompanyJobDescription(CompanyJobDescriptionPoco[] pocos)
        {
            var repo = new EFGenericRepository<CompanyJobDescriptionPoco>(false);
            var logic = new CompanyJobDescriptionLogic(repo);
            logic.Delete(pocos);
        }

        public void UpdateCompanyJobDescription(CompanyJobDescriptionPoco[] pocos)
        {
            var repo = new EFGenericRepository<CompanyJobDescriptionPoco>(false);
            var logic = new CompanyJobDescriptionLogic(repo);
            logic.Update(pocos);
        }

        // CompanyJobEducation
        public void AddCompanyJobEducation(CompanyJobEducationPoco[] pocos)
        {
            var repo = new EFGenericRepository<CompanyJobEducationPoco>(false);
            var logic = new CompanyJobEducationLogic(repo);
            logic.Add(pocos);
        }

        public List<CompanyJobEducationPoco> GetAllCompanyJobEducation()
        {
            var repo = new EFGenericRepository<CompanyJobEducationPoco>(false);
            var logic = new CompanyJobEducationLogic(repo);
            return logic.GetAll();
        }

        public CompanyJobEducationPoco GetSingleCompanyJobEducation(string Id)
        {
            var repo = new EFGenericRepository<CompanyJobEducationPoco>(false);
            var logic = new CompanyJobEducationLogic(repo);
            return logic.Get(Guid.Parse(Id));
        }

        public void RemoveCompanyJobEducation(CompanyJobEducationPoco[] pocos)
        {
            var repo = new EFGenericRepository<CompanyJobEducationPoco>(false);
            var logic = new CompanyJobEducationLogic(repo);
            logic.Delete(pocos);
        }

        public void UpdateCompanyJobEducation(CompanyJobEducationPoco[] pocos)
        {
            var repo = new EFGenericRepository<CompanyJobEducationPoco>(false);
            var logic = new CompanyJobEducationLogic(repo);
            logic.Update(pocos);
        }

        // CompanyJob

        public void AddCompanyJob(CompanyJobPoco[] pocos)
        {
            var repo = new EFGenericRepository<CompanyJobPoco>(false);
            var logic = new CompanyJobLogic(repo);
            logic.Add(pocos);
        }

        public List<CompanyJobPoco> GetAllCompanyJob()
        {
            var repo = new EFGenericRepository<CompanyJobPoco>(false);
            var logic = new CompanyJobLogic(repo);
            return logic.GetAll();
        }

        public CompanyJobPoco GetSingleCompanyJob(string Id)
        {
            var repo = new EFGenericRepository<CompanyJobPoco>(false);
            var logic = new CompanyJobLogic(repo);
            return logic.Get(Guid.Parse(Id));
        }

        public void RemoveCompanyJob(CompanyJobPoco[] pocos)
        {
            var repo = new EFGenericRepository<CompanyJobPoco>(false);
            var logic = new CompanyJobLogic(repo);
            logic.Delete(pocos);
        }

        public void UpdateCompanyJob(CompanyJobPoco[] pocos)
        {
            var repo = new EFGenericRepository<CompanyJobPoco>(false);
            var logic = new CompanyJobLogic(repo);
            logic.Update(pocos);
        }

        // CompanyJobSkill

        public void AddCompanyJobSkill(CompanyJobSkillPoco[] pocos)
        {
            var repo = new EFGenericRepository<CompanyJobSkillPoco>(false);
            var logic = new CompanyJobSkillLogic(repo);
            logic.Add(pocos);
        }

        public List<CompanyJobSkillPoco> GetAllCompanyJobSkill()
        {
            var repo = new EFGenericRepository<CompanyJobSkillPoco>(false);
            var logic = new CompanyJobSkillLogic(repo);
            return logic.GetAll();
        }

        public CompanyJobSkillPoco GetSingleCompanyJobSkill(string Id)
        {
            var repo = new EFGenericRepository<CompanyJobSkillPoco>(false);
            var logic = new CompanyJobSkillLogic(repo);
            return logic.Get(Guid.Parse(Id));
        }

        public void RemoveCompanyJobSkill(CompanyJobSkillPoco[] pocos)
        {
            var repo = new EFGenericRepository<CompanyJobSkillPoco>(false);
            var logic = new CompanyJobSkillLogic(repo);
            logic.Delete(pocos);
        }

        public void UpdateCompanyJobSkill(CompanyJobSkillPoco[] pocos)
        {
            var repo = new EFGenericRepository<CompanyJobSkillPoco>(false);
            var logic = new CompanyJobSkillLogic(repo);
            logic.Update(pocos);
        }

        // CompanyLocation

        public void AddCompanyLocation(CompanyLocationPoco[] pocos)
        {
            var repo = new EFGenericRepository<CompanyLocationPoco>(false);
            var logic = new CompanyLocationLogic(repo);
            logic.Add(pocos);
        }

        public List<CompanyLocationPoco> GetAllCompanyLocation()
        {
            var repo = new EFGenericRepository<CompanyLocationPoco>(false);
            var logic = new CompanyLocationLogic(repo);
            return logic.GetAll();
        }

        public CompanyLocationPoco GetSingleCompanyLocation(string Id)
        {
            var repo = new EFGenericRepository<CompanyLocationPoco>(false);
            var logic = new CompanyLocationLogic(repo);
            return logic.Get(Guid.Parse(Id));
        }

        public void RemoveCompanyLocation(CompanyLocationPoco[] pocos)
        {
            var repo = new EFGenericRepository<CompanyLocationPoco>(false);
            var logic = new CompanyLocationLogic(repo);
            logic.Delete(pocos);
        }

        public void UpdateCompanyLocation(CompanyLocationPoco[] pocos)
        {
            var repo = new EFGenericRepository<CompanyLocationPoco>(false);
            var logic = new CompanyLocationLogic(repo);
            logic.Update(pocos);
        }

        // CompanyProfile

        public void AddCompanyProfile(CompanyProfilePoco[] pocos)
        {
            var repo = new EFGenericRepository<CompanyProfilePoco>(false);
            var logic = new CompanyProfileLogic(repo);
            logic.Add(pocos);
        }

        public List<CompanyProfilePoco> GetAllCompanyProfile()
        {
            var repo = new EFGenericRepository<CompanyProfilePoco>(false);
            var logic = new CompanyProfileLogic(repo);
            return logic.GetAll();
        }

        public CompanyProfilePoco GetSingleCompanyProfile(string Id)
        {
            var repo = new EFGenericRepository<CompanyProfilePoco>(false);
            var logic = new CompanyProfileLogic(repo);
            return logic.Get(Guid.Parse(Id));
        }

        public void RemoveCompanyProfile(CompanyProfilePoco[] pocos)
        {
            var repo = new EFGenericRepository<CompanyProfilePoco>(false);
            var logic = new CompanyProfileLogic(repo);
            logic.Delete(pocos);
        }

        public void UpdateCompanyProfile(CompanyProfilePoco[] pocos)
        {
            var repo = new EFGenericRepository<CompanyProfilePoco>(false);
            var logic = new CompanyProfileLogic(repo);
            logic.Update(pocos);
        }

       
    }

}
