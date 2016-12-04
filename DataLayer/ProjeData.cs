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
    public class ProjeData
    {
        SqlHelper db = new SqlHelper();
        List<Proje> ProjeListesi;
        public Base Projeler(Kullanici user)
        {
            ProjeListesi = new List<Proje>();
            Base b = new Base();
            db.prepareCommand("SELECT * FROM tbl_Proje WHERE intUser=@intUser", CommandType.Text, new SqlParameter[] {
                new SqlParameter() {ParameterName="@intUser",Value=user.kullaniciId, SqlDbType=SqlDbType.Int }
            });
            SqlDataReader dr = db.runCommandReturnReader();
            while (dr.Read())
            {
                ProjeListesi.Add(new Proje
                {
                    projeId = Convert.ToInt32(dr["intProjeId"]),
                    projeAdi = dr["strPorjeAdi"].ToString(),
                });
            }
            if (ProjeListesi.Count > 0)
            {
                b.result = true;
                b.data = ProjeListesi;
            }
            else
            {
                b.result = false;
                b.errorId = 101;
                b.errorMsg = "Internal Server Error";
            }
            return b;
        }
        public Base Projeler(int id)
        {
            Base b = new Base();
            ProjeListesi = new List<Proje>();
            db.prepareCommand("SELECT * FROM tbl_Proje WHERE intUser=@intUser", CommandType.Text, new SqlParameter[] {
                new SqlParameter() {ParameterName="@intUser",Value=id, SqlDbType=SqlDbType.Int }
            });
            SqlDataReader dr = db.runCommandReturnReader();
            while (dr.Read())
            {
                ProjeListesi.Add(new Proje
                {
                    projeId = Convert.ToInt32(dr["intProjeId"]),
                    projeAdi = dr["strPorjeAdi"].ToString(),
                });
            }
            if (ProjeListesi.Count > 0)
            {
                b.result = true;
                b.data = ProjeListesi;   
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
