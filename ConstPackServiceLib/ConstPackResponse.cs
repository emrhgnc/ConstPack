using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataLayer;
using System.Data;
using System.Data.SqlClient;

namespace ConstPackServiceLib
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class ConstPackResponse
    {
        //KullaniciData kd = new KullaniciData();
        //ProjeData pd = new ProjeData();

        //public Kullanici getUser(string ePosta, string password)
        //{
        //    Kullanici userItem = new Kullanici();
        //    SqlHelper db = new SqlHelper();
        //    db.prepareCommand("SELECT * FROM tbl_Kullanici WHERE strEposta=@strEposta", CommandType.Text, new SqlParameter[] {
        //        new SqlParameter() {ParameterName="@strEposta",Value=ePosta, SqlDbType=SqlDbType.NVarChar },
        //        new SqlParameter() {ParameterName="@strPassword", Value=password, SqlDbType=SqlDbType.Text }
        //    });
        //    SqlDataReader dr = db.runCommandReturnReader();
        //    while (dr.Read())
        //    {
        //        userItem.intKullaniciId = Convert.ToInt32(dr["intKullaniciId"]);
        //        userItem.strKullaniciAdi = dr["strKullaniciAdi"].ToString();
        //        userItem.strUnvan = dr["strUnvan"].ToString();
        //        userItem.intRol = Convert.ToInt32(dr["intRol"]);
        //        userItem.strEposta = dr["strEposta"].ToString();
        //        userItem.dtSonGiriş = Convert.ToDateTime(dr["dtSonGiris"]);
        //        userItem.blOturum = Convert.ToBoolean(dr["blOturum"]);
        //        userItem.blDurum = Convert.ToBoolean(dr["blDurum"]);
        //    }
        //    dr.Dispose();
        //    return userItem;
        //}

        //public List<Kullanici> KullaniciListesi()
        //{
        //    List<Kullanici>  KullaniciListesi = new List<Kullanici>();
        //    SqlHelper db = new SqlHelper();
        //    db.prepareCommand("SELECT * FROM tbl_Kullanici", CommandType.Text);
        //    SqlDataReader dr = db.runCommandReturnReader();
        //    while (dr.Read())
        //    {
        //        KullaniciListesi.Add(new Kullanici
        //        {
        //            intKullaniciId = Convert.ToInt32(dr["intKullaniciId"]),
        //            strKullaniciAdi = dr["strKullaniciAdi"].ToString(),
        //            strUnvan = dr["strUnvan"].ToString(),
        //            intRol = Convert.ToInt32(dr["intRol"]),
        //            strEposta = dr["strEposta"].ToString(),
        //            dtSonGiriş = Convert.ToDateTime(dr["dtSonGiris"]),
        //            blOturum = Convert.ToBoolean(dr["blOturum"]),
        //            blDurum = Convert.ToBoolean(dr["blDurum"]),
        //        });
        //    }
        //    dr.Dispose();
        //    return KullaniciListesi;
        //}

        //public List<tbl_Proje> ProjeListesi()
        //{
        //    List<tbl_Proje> ProjeListesi = new List<tbl_Proje>();
        //    SqlHelper db = new SqlHelper();
        //    ProjeListesi = new List<tbl_Proje>();
        //    db.prepareCommand("SELECT * FROM tbl_Proje", CommandType.Text);
        //    SqlDataReader dr = db.runCommandReturnReader();
        //    while (dr.Read())
        //    {
        //        ProjeListesi.Add(new tbl_Proje
        //        {
        //            intProjeId = Convert.ToInt32(dr["intProjeId"]),
        //            strPorjeAdi = dr["strPorjeAdi"].ToString()
        //        });
        //    }
        //    dr.Dispose();
        //    return ProjeListesi;
        //}
    }
}
