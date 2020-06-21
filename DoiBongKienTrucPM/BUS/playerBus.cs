using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class playerBus
    {
         playerDal bus;
        public playerBus()
        {
            bus = new playerDal();
        }
        public List<ePlayer> getALlPlayer()
        {
            return bus.getAllPlayer();
        }
        public List<ePlayer> getALlPlayerTheoTeam(string ten)
        {
            return bus.getAllPlayerTheoTeam(ten);
        }
        public bool CreatPlayer(ePlayer e)
        {
            return bus.CreatePlayer(e);
        }
        public bool updatePlayer(ePlayer e)
        {
            return bus.updatePlayer(e);
        }
        public bool deletePlayer(string e)
        {
            return bus.deletePlayer(e);
        }
    }
}
