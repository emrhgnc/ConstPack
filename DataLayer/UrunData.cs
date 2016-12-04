using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using EntityLayer;
using System.Data.SqlClient;
using System.Data;

namespace DataLayer
{
    public class UrunData
    {
        SqlHelper db = new SqlHelper();
        List<Urun> urunListesi;
        public Base Urunler(Kat kat)
        {
            urunListesi = new List<Urun>();
            Base b = new Base();
            db.prepareCommand("SELECT * FROM tbl_Urun WHERE intKatId=@intKatId", CommandType.Text, new SqlParameter[] {
                new SqlParameter() {ParameterName="@intKatId",Value=kat.katid, SqlDbType=SqlDbType.Int }
            });
            SqlDataReader dr = db.runCommandReturnReader();
            while (dr.Read())
            {
                urunListesi.Add(new Urun
                {
                    urunId = Convert.ToInt32(dr["intUrun"]),
                    katId = Convert.ToInt32(dr["intKatId"]),
                    urunAdi = dr["strAdi"].ToString(),
                    durum = Convert.ToBoolean(dr["blDurum"]),
                });
            }
            if (urunListesi.Count > 0)
            {
                b.result = true;
                b.data = urunListesi;
            }
            else
            {
                b.result = false;
                b.errorId = 101;
                b.errorMsg = "Internal Server Error";
            }
            return b;
        }
        public Base Urunler(int id)
        {
            urunListesi = new List<Urun>();
            Base b = new Base();
            db.prepareCommand("SELECT * FROM tbl_Urun WHERE intKatId=@intKatId", CommandType.Text, new SqlParameter[] {
                new SqlParameter() {ParameterName="@intKatId",Value=id, SqlDbType=SqlDbType.Int }
            });
            SqlDataReader dr = db.runCommandReturnReader();
            while (dr.Read())
            {
                urunListesi.Add(new Urun
                {
                    urunId = Convert.ToInt32(dr["intUrun"]),
                    katId = Convert.ToInt32(dr["intKatId"]),
                    urunAdi = dr["strAdi"].ToString(),
                    durum = Convert.ToBoolean(dr["blDurum"]),
                });
            }
            if (urunListesi.Count > 0)
            {
                b.result = true;
                b.data = urunListesi;
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
