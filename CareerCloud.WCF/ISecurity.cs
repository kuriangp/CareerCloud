using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.WCF
{
    [ServiceContract]

    public interface ISecurity
    {
        // SecurityLogin

        [OperationContract]
        void AddSecurityLogin(SecurityLoginPoco[] pocos);

        [OperationContract]
        List<SecurityLoginPoco> GetAllSecurityLogin();


        [OperationContract]
        SecurityLoginPoco GetSingleSecurityLogin(string Id);

        [OperationContract]
        void RemoveSecurityLogin(SecurityLoginPoco[] pocos);

        [OperationContract]
        void UpdateSecurityLogin(SecurityLoginPoco[] pocos);

        // SecurityLoginsLog

        [OperationContract]
        void AddSecurityLoginsLog(SecurityLoginsLogPoco[] pocos);

        [OperationContract]
        List<SecurityLoginsLogPoco> GetAllSecurityLoginsLog();


        [OperationContract]
        SecurityLoginsLogPoco GetSingleSecurityLoginsLog(string Id);

        [OperationContract]
        void RemoveSecurityLoginsLog(SecurityLoginsLogPoco[] pocos);

        [OperationContract]
        void UpdateSecurityLoginsLog(SecurityLoginsLogPoco[] pocos);

        // SecurityLoginsRole

        [OperationContract]
        void AddSecurityLoginsRole(SecurityLoginsRolePoco[] pocos);

        [OperationContract]
        List<SecurityLoginsRolePoco> GetAllSecurityLoginsRole();


        [OperationContract]
        SecurityLoginsRolePoco GetSingleSecurityLoginsRole(string Id);

        [OperationContract]
        void RemoveSecurityLoginsRole(SecurityLoginsRolePoco[] pocos);

        [OperationContract]
        void UpdateSecurityLoginsRole(SecurityLoginsRolePoco[] pocos);

        // SecurityRole

        [OperationContract]
        void AddSecurityRole(SecurityRolePoco[] pocos);

        [OperationContract]
        List<SecurityRolePoco> GetAllSecurityRole();


        [OperationContract]
        SecurityRolePoco GetSingleSecurityRole(string Id);

        [OperationContract]
        void RemoveSecurityRole(SecurityRolePoco[] pocos);

        [OperationContract]
        void UpdateSecurityRole(SecurityRolePoco[] pocos);

        

    }

}
