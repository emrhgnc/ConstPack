using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using EntityLayer;
using DataLayer;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ConstPackService" in code, svc and config file together.
[ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
public class ConstPackService : IConstPackService
{
        KullaniciData kd = new KullaniciData();

    public List<Kullanici> KullaniciListesi()
    {
        List<Kullanici> kullaniciListesi = kd.Kullanicilar();
        return kullaniciListesi;
    }
}
