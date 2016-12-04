using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;

namespace ConstPackServiceLib
{
    [ServiceContract]
    public interface IConstPackResponse
    {
        [WebGet(UriTemplate = "users", ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        List<Kullanici> KullaniciListesi();

        [WebGet(UriTemplate = "getUser?strEposta={strEposta}&password={password}", ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        Kullanici getUser(string strEposta, string password);

        [WebGet(UriTemplate = "projects", ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        List<tbl_Proje> ProjeListesi();
    }
}
