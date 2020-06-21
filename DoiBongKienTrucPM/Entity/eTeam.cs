using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class eTeam
    {
        [Key]
        public string maDoiBong { get; set; }
        public string tenDoiBong { get; set; }
        public ICollection<ePlayer> ePlayers { get; set; }
    }
}
