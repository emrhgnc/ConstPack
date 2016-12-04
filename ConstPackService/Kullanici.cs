using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using EntityLayer;
using DataLayer;
using System.Data.SqlClient;

namespace ConstPackService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class Kullanici : IKullanici
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader dr;
        KullaniciData kd = new KullaniciData();
        public List<CKullanici> Kullanicilar()
        {
            List<CKullanici> kullanicilar = kd.Kullanicilar();
            return kullanicilar;
        }
    }
}