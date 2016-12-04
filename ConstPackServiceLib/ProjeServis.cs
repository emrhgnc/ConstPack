using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataLayer;
using System.Data.SqlClient;
using System.ServiceModel;

namespace ConstPackServiceLib
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class ProjeServis :IProjeServis
    {
        ProjeData pd = new ProjeData();

        //public List<tbl_Proje> ProjeListesi()
        //{
        //    List<tbl_Proje> projeListesi =  pd.Projeler();
        //    return projeListesi;
        //}
    }
}
