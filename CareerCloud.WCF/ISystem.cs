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
    public interface ISystem
    {

        // SystemCountryCode

        [OperationContract]
        void AddSystemCountryCode(SystemCountryCodePoco[] pocos);

        [OperationContract]
        List<SystemCountryCodePoco> GetAllSystemCountryCode();
        
        [OperationContract]
        SystemCountryCodePoco GetSingleSystemCountryCode(string Id);

        [OperationContract]
        void RemoveSystemCountryCode(SystemCountryCodePoco[] pocos);

        [OperationContract]
        void UpdateSystemCountryCode(SystemCountryCodePoco[] pocos);

        // SystemLanguageCode

        [OperationContract]
        void AddSystemLanguageCode(SystemLanguageCodePoco[] pocos);

        [OperationContract]
        List<SystemLanguageCodePoco> GetAllSystemLanguageCode();

        [OperationContract]
        SystemLanguageCodePoco GetSingleSystemLanguageCode(string Id);

        [OperationContract]
        void RemoveSystemLanguageCode(SystemLanguageCodePoco[] pocos);

        [OperationContract]
        void UpdateSystemLanguageCode(SystemLanguageCodePoco[] pocos);

        

    }


}
