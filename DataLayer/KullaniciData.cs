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
    public class KullaniciData
    {
        SqlHelper db = new SqlHelper();
        List<Kullanici> KullaniciListesi;
        public List<Kullanici> Kullanicilar()
        {
            KullaniciListesi = new List<Kullanici>();
            db.prepareCommand("SELECT * FROM tbl_Kullanici", CommandType.Text);
            SqlDataReader dr = db.runCommandReturnReader();
            while (dr.Read())
            {
                KullaniciListesi.Add(new Kullanici
                {
                    kullaniciId = Convert.ToInt32(dr["intKullaniciId"]),
                    kullaniciAdi = dr["strKullaniciAdi"].ToString(),
                    unvan = dr["strUnvan"].ToString(),
                    rolId = Convert.ToInt32(dr["intRol"]),
                    eposta = dr["strEposta"].ToString(),
                    durum = Convert.ToBoolean(dr["blDurum"]),
                });
            }
            return KullaniciListesi;
        }
        public Base GetUser(string eMail,string password)
        {
            Kullanici userItem = null;
            SqlHelper db = new SqlHelper();
            Base b = new Base();
            db.prepareCommand("SELECT * FROM tbl_Kullanici WHERE strEposta=@strEposta AND strPassword=@strPassword", CommandType.Text, new SqlParameter[] {
                new SqlParameter() {ParameterName="@strEposta",Value=eMail, SqlDbType=SqlDbType.NVarChar },
                new SqlParameter() {ParameterName="@strPassword", Value=password, SqlDbType=SqlDbType.NVarChar }
            });
            SqlDataReader dr = db.runCommandReturnReader();
            if (dr.Read())
            {
                userItem = new Kullanici();
                userItem.kullaniciId = Convert.ToInt32(dr["intKullaniciId"]);
                userItem.kullaniciAdi = dr["strKullaniciAdi"].ToString();
                userItem.unvan = dr["strUnvan"].ToString();
                userItem.rolId = Convert.ToInt32(dr["intRol"]);
                userItem.eposta = dr["strEposta"].ToString();
                userItem.durum = Convert.ToBoolean(dr["blDurum"]);
            }

            dr.Dispose();
            if (userItem != null)
            {
                b.result = true;
                b.data = userItem;
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
