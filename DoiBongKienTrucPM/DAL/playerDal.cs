using DataAccess;
using Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace DAL
{
    public class playerDal
    {
        DoiBongDBContex db;
        public playerDal()
        {
            db = new DoiBongDBContex();
        }
        public List<ePlayer> getAllPlayer()
        {
            return db.ePlayers.ToList();
        }
        public List<ePlayer> getAllPlayerTheoTeam(string ten)
        {
            return db.ePlayers.Where(x=>x.maDoiBong.Equals(ten)).ToList();
        }
        public bool CreatePlayer(ePlayer nguoiChoi)
        {
            if (db.ePlayers.Where(x => x.maCauThu.Equals(nguoiChoi.maCauThu)).FirstOrDefault()==null)
            {
                db.ePlayers.Add(nguoiChoi);
                db.SaveChanges();
                return true;
            }
            return false;
        }
        public bool updatePlayer(ePlayer e)
        {
            var result = db.ePlayers.Where(x => x.maCauThu.Equals(e.maCauThu)).FirstOrDefault();
            if (result != null)
            {
                result.maCauThu = e.maCauThu;
                result.tenCauThu = e.tenCauThu;
                result.email = e.email;
                result.maDoiBong = e.maDoiBong;
                result.soDT = e.soDT;
              //  db.ePlayers.AddOrUpdate(result);
                db.SaveChanges();
                return true;
            }
            return false;
        }
        public bool deletePlayer(string id)
        {
            var result = db.ePlayers.Where(x => x.maCauThu.Equals(id)).FirstOrDefault();
            if (result != null) { 
                db.ePlayers.Remove(result);
                db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
