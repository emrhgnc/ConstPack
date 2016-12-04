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
    public interface IProjeServis
    {
        [WebGet(UriTemplate = "Projects", ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        List<tbl_Proje> ProjeListesi();
    }
}
