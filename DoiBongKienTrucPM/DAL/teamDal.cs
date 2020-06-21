using DataAccess;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class teamDal
    {
        DoiBongDBContex db;
        public teamDal()
        {
            db = new DoiBongDBContex();
        }
        public List<eTeam> getALlTeam()
        {
            List<eTeam> list = db.eTeams.ToList();
            return list;
        }
        public bool CreateDoiBong(eTeam Doibong)
        {
            if (db.eTeams.Where(x => x.maDoiBong.Equals(Doibong.maDoiBong)).FirstOrDefault() == null)
            {
                db.eTeams.Add(Doibong);
                db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
