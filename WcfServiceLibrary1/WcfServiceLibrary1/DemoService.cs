using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    [DataContract]
    public class EmpData
    {
        [DataMember]
        public string EmpName; //data members
        [DataMember]
        public string EmpId;
       
    }
    [ServiceContract]
    public interface IDemo
    {
        [OperationContract]
        string GetEmpData(EmpData empData);
    }
    public class Demo : IDemo
    {
        public string GetEmpData(EmpData empData)
        {
            return string.Format("Employee name {0} and emplyoee ID {1}",empData.EmpName,empData.EmpId);
        }
    }
}
