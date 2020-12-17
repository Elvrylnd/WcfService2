using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;

namespace WcfService2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string Insert(InsertUser user);
        [OperationContract]
        gettestdata GetInfo();
        [OperationContract]
        string Update(UpdateUser u);
        [OperationContract]
        string Delete(DeleteUser d);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class gettestdata
    {
        [DataMember]
        public DataTable table
        {
            get;
            set;
        }
    }

    [DataContract]
    public class InsertUser
    {
        string name = string.Empty;
        string email = string.Empty;

        [DataMember]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        [DataMember]
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    }

    [DataContract]
    public class UpdateUser
    {
        int uid;
        string name;
        string email;
        [DataMember]
        public int UID
        {
            get { return uid; }
            set { uid = value; }
        }
        [DataMember]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        [DataMember]
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    }

    [DataContract]
    public class DeleteUser
    {
        int uid;
        [DataMember]
        public int UID
        {
            get { return uid; }
            set { uid = value; }
        }
    }
}
