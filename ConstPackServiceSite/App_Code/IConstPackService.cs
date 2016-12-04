using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web.UI;
using EntityLayer;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IConstPackService" in both code and config file together.
[ServiceContract]
public interface IConstPackService
{
        [WebGet(UriTemplate = "users", ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        List<Kullanici> KullaniciListesi();
}
