using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ePlayer
    {
        [Key]
        public string maCauThu { get; set; }
        public string tenCauThu { get; set; }
        public string soDT { get; set; }
        public string email { get; set; }
        public string maDoiBong { get; set; }
        public virtual eTeam eTeam { get; set; }
      
    }
}
