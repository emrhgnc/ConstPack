using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Data.SqlClient;
using System.Data;

namespace DataLayer
{
    public class KatData
    {
        SqlHelper db = new SqlHelper();
        List<Kat> katListesi;
        public Base Katlar(Blok blok)
        {
            katListesi = new List<Kat>();
            Base b = new Base();
            db.prepareCommand("SELECT * FROM tbl_Kat WHERE intBlokId=@intBlokId", CommandType.Text, new SqlParameter[] {
                new SqlParameter() {ParameterName="@intBlokId",Value=blok.blokId, SqlDbType=SqlDbType.Int }
            });
            SqlDataReader dr = db.runCommandReturnReader();
            while (dr.Read())
            {
                katListesi.Add(new Kat
                {
                    katid = Convert.ToInt32(dr["intKatId"]),
                    blokId = Convert.ToInt32(dr["intBlokId"]),
                    katAdi = dr["strAd"].ToString(),
                    durum = Convert.ToBoolean(dr["blDurum"]),
                });
            }
            if (katListesi.Count > 0)
            {
                b.result = true;
                b.data = katListesi;
            }
            else
            {
                b.result = false;
                b.errorId = 101;
                b.errorMsg = "Internal Server Error";
            }
            return b;
        }
        public Base Katlar(int id)
        {
            katListesi = new List<Kat>();
            Base b = new Base();
            db.prepareCommand("SELECT * FROM tbl_Kat WHERE intBlokId=@intBlokId", CommandType.Text, new SqlParameter[] {
                new SqlParameter() {ParameterName="@intBlokId",Value=id, SqlDbType=SqlDbType.Int }
            });
            SqlDataReader dr = db.runCommandReturnReader();
            while (dr.Read())
            {
                katListesi.Add(new Kat
                {
                    katid = Convert.ToInt32(dr["intKatId"]),
                    blokId = Convert.ToInt32(dr["intBlokId"]),
                    katAdi = dr["strAd"].ToString(),
                    durum = Convert.ToBoolean(dr["blDurum"]),
                });
            }
            if (katListesi.Count > 0)
            {
                b.result = true;
                b.data = katListesi;
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
