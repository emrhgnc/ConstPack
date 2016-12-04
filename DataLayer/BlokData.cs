using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Data;
using System.Data.SqlClient;

namespace DataLayer
{
    public class BlokData
    {
        SqlHelper db = new SqlHelper();
        List<Blok> blokListesi;
        public Base Bloklar(Proje proje)
        {
            blokListesi = new List<Blok>();
            Base b = new Base();
            db.prepareCommand("SELECT * FROM tbl_Blok WHERE intProjeId=@intProjeId", CommandType.Text, new SqlParameter[] {
                new SqlParameter() {ParameterName="@intProjeId",Value=proje.projeId, SqlDbType=SqlDbType.Int }
            });
            SqlDataReader dr = db.runCommandReturnReader();
            while (dr.Read())
            {
                blokListesi.Add(new Blok
                {
                    blokId = Convert.ToInt32(dr["intBlokId"]),
                    projeId = Convert.ToInt32(dr["intProjeId"]),
                    blokAdi = dr["strBlokAdi"].ToString(),
                    durum = Convert.ToBoolean(dr["blDurum"]),
                });
            }
            if(blokListesi.Count>0)
            {
                b.result = true;
                b.data = blokListesi;
            }
            else
            {
                b.result = false;
                b.errorId = 101;
                b.errorMsg = "Internal Server Error";
            }
            return b;
        }
        public Base Bloklar(int id)
        {
            blokListesi = new List<Blok>();
            Base b = new Base();
            db.prepareCommand("SELECT * FROM tbl_Blok WHERE intProjeId=@intProjeId", CommandType.Text, new SqlParameter[] {
                new SqlParameter() {ParameterName="@intProjeId",Value=id, SqlDbType=SqlDbType.Int }
            });
            SqlDataReader dr = db.runCommandReturnReader();
            while (dr.Read())
            {
                blokListesi.Add(new Blok
                {
                    blokId = Convert.ToInt32(dr["intBlokId"]),
                    projeId = Convert.ToInt32(dr["intProjeId"]),
                    blokAdi = dr["strBlokAdi"].ToString(),
                    durum = Convert.ToBoolean(dr["blDurum"]),
                });
            }
            if (blokListesi.Count > 0)
            {
                b.result = true;
                b.data = blokListesi;
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
