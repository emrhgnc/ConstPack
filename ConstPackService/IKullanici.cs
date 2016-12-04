using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Collections;

namespace ConstPackService
{
    [ServiceContract]
    public interface IKullanici
    {
        [WebGet(UriTemplate = "tbl_Kullanici", ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        List<CKullanici> Kullanicilar();
    }
}
