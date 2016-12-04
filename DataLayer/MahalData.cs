using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataLayer;
using System.Data;
using System.Data.SqlClient;

namespace DataLayer
{
    public class MahalData
    {
        SqlHelper db = new SqlHelper();
        List<Mahal> mahalListesi;
        public Base Mahaller(Urun urun)
        {
            mahalListesi = new List<Mahal>();
            Base b = new Base();
            db.prepareCommand("SELECT * FROM tbl_Mahal WHERE intUrunId=@intUrunId", CommandType.Text, new SqlParameter[] {
                new SqlParameter() {ParameterName="@intUrunId",Value=urun.urunId, SqlDbType=SqlDbType.Int }
            });
            SqlDataReader dr = db.runCommandReturnReader();
            while (dr.Read())
            {
                mahalListesi.Add(new Mahal
                {
                    mahalId = Convert.ToInt32(dr["intMahalId"]),
                    urunId = Convert.ToInt32(dr["intUrunId"]),
                    mahalAdi = dr["strMahalAdi"].ToString(),
                    mahalTipId= Convert.ToInt32(dr["intMahalTipId"]),
                    durum = Convert.ToBoolean(dr["blDurum"])
                });
            }
            if (mahalListesi.Count > 0)
            {
                b.result = true;
                b.data = mahalListesi;
            }
            else
            {
                b.result = false;
                b.errorId = 101;
                b.errorMsg = "Internal Server Error";
            }
            return b;
        }
        public Base Mahaller(int id)
        {
            mahalListesi = new List<Mahal>();
            Base b = new Base();
            db.prepareCommand("SELECT * FROM tbl_Mahal WHERE intUrunId=@intUrunId", CommandType.Text, new SqlParameter[] {
                new SqlParameter() {ParameterName="@intUrunId",Value=id, SqlDbType=SqlDbType.Int }
            });
            SqlDataReader dr = db.runCommandReturnReader();
            while (dr.Read())
            {
                mahalListesi.Add(new Mahal
                {
                    mahalId = Convert.ToInt32(dr["intMahalId"]),
                    urunId = Convert.ToInt32(dr["intUrunId"]),
                    mahalAdi = dr["strMahalAdi"].ToString(),
                    mahalTipId = Convert.ToInt32(dr["intMahalTipId"]),
                    durum = Convert.ToBoolean(dr["blDurum"])
                });
            }
            if (mahalListesi.Count > 0)
            {
                b.result = true;
                b.data = mahalListesi;
            }
            else
            {
                b.result = false;
                b.errorId = 101;
                b.errorMsg = "Internal Server Error";
            }
            return b;
        }
    }
}
