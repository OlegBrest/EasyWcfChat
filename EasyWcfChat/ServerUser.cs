using System.Runtime.Serialization;
using System.ServiceModel;
using System.Xml.Linq;

namespace EasyWcfChat
{
    [DataContract(Name = "UsersList")]
    public class ServerUser
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public OperationContext operationContext { get; set; }

    }
}
