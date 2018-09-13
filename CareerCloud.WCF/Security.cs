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
    public class Security : ISecurity
    {
        // SecurityLogin

        public void AddSecurityLogin(SecurityLoginPoco[] pocos)
        {
            var repo = new EFGenericRepository<SecurityLoginPoco>(false);
            var logic = new SecurityLoginLogic(repo);
            logic.Add(pocos);
        }

        public List<SecurityLoginPoco> GetAllSecurityLogin()
        {
            var repo = new EFGenericRepository<SecurityLoginPoco>(false);
            var logic = new SecurityLoginLogic(repo);
            return logic.GetAll();
        }

        public SecurityLoginPoco GetSingleSecurityLogin(string Id)
        {
            var repo = new EFGenericRepository<SecurityLoginPoco>(false);
            var logic = new SecurityLoginLogic(repo);
            return logic.Get(Guid.Parse(Id));
        }

        public void RemoveSecurityLogin(SecurityLoginPoco[] pocos)
        {
            var repo = new EFGenericRepository<SecurityLoginPoco>(false);
            var logic = new SecurityLoginLogic(repo);
            logic.Delete(pocos);
        }

        public void UpdateSecurityLogin(SecurityLoginPoco[] pocos)
        {
            var repo = new EFGenericRepository<SecurityLoginPoco>(false);
            var logic = new SecurityLoginLogic(repo);
            logic.Update(pocos);
        }

        //SecurityLoginsLog

        public void AddSecurityLoginsLog(SecurityLoginsLogPoco[] pocos)
        {
            var repo = new EFGenericRepository<SecurityLoginsLogPoco>(false);
            var logic = new SecurityLoginsLogLogic(repo);
            logic.Add(pocos);
        }

        public List<SecurityLoginsLogPoco> GetAllSecurityLoginsLog()
        {
            var repo = new EFGenericRepository<SecurityLoginsLogPoco>(false);
            var logic = new SecurityLoginsLogLogic(repo);
            return logic.GetAll();
        }

        public SecurityLoginsLogPoco GetSingleSecurityLoginsLog(string Id)
        {
            var repo = new EFGenericRepository<SecurityLoginsLogPoco>(false);
            var logic = new SecurityLoginsLogLogic(repo);
            return logic.Get(Guid.Parse(Id));
        }

        public void RemoveSecurityLoginsLog(SecurityLoginsLogPoco[] pocos)
        {
            var repo = new EFGenericRepository<SecurityLoginsLogPoco>(false);
            var logic = new SecurityLoginsLogLogic(repo);
            logic.Delete(pocos);
        }

        public void UpdateSecurityLoginsLog(SecurityLoginsLogPoco[] pocos)
        {
            var repo = new EFGenericRepository<SecurityLoginsLogPoco>(false);
            var logic = new SecurityLoginsLogLogic(repo);
            logic.Update(pocos);
        }

        // SecurityLoginsRole

        public void AddSecurityLoginsRole(SecurityLoginsRolePoco[] pocos)
        {
            var repo = new EFGenericRepository<SecurityLoginsRolePoco>(false);
            var logic = new SecurityLoginsRoleLogic(repo);
            logic.Add(pocos);
        }

        public List<SecurityLoginsRolePoco> GetAllSecurityLoginsRole()
        {
            var repo = new EFGenericRepository<SecurityLoginsRolePoco>(false);
            var logic = new SecurityLoginsRoleLogic(repo);
            return logic.GetAll();
        }

        public SecurityLoginsRolePoco GetSingleSecurityLoginsRole(string Id)
        {
            var repo = new EFGenericRepository<SecurityLoginsRolePoco>(false);
            var logic = new SecurityLoginsRoleLogic(repo);
            return logic.Get(Guid.Parse(Id));
        }

        public void RemoveSecurityLoginsRole(SecurityLoginsRolePoco[] pocos)
        {
            var repo = new EFGenericRepository<SecurityLoginsRolePoco>(false);
            var logic = new SecurityLoginsRoleLogic(repo);
            logic.Delete(pocos);
        }

        public void UpdateSecurityLoginsRole(SecurityLoginsRolePoco[] pocos)
        {
            var repo = new EFGenericRepository<SecurityLoginsRolePoco>(false);
            var logic = new SecurityLoginsRoleLogic(repo);
            logic.Update(pocos);
        }

        // SecurityRole

        public void AddSecurityRole(SecurityRolePoco[] pocos)
        {
            var repo = new EFGenericRepository<SecurityRolePoco>(false);
            var logic = new SecurityRoleLogic(repo);
            logic.Add(pocos);
        }

        public List<SecurityRolePoco> GetAllSecurityRole()
        {
            var repo = new EFGenericRepository<SecurityRolePoco>(false);
            var logic = new SecurityRoleLogic(repo);
            return logic.GetAll();
        }

        public SecurityRolePoco GetSingleSecurityRole(string Id)
        {
            var repo = new EFGenericRepository<SecurityRolePoco>(false);
            var logic = new SecurityRoleLogic(repo);
            return logic.Get(Guid.Parse(Id));
        }

        public void RemoveSecurityRole(SecurityRolePoco[] pocos)
        {
            var repo = new EFGenericRepository<SecurityRolePoco>(false);
            var logic = new SecurityRoleLogic(repo);
            logic.Delete(pocos);
        }

        public void UpdateSecurityRole(SecurityRolePoco[] pocos)
        {
            var repo = new EFGenericRepository<SecurityRolePoco>(false);
            var logic = new SecurityRoleLogic(repo);
            logic.Update(pocos);
        }

        
    }

}
