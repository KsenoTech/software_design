using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    public class Player
    {
        public int Id { get; set; }
        public string Gender { get; set; }

        public string Name { get; set; }

        public DateTime BirthDate { get; set; }

        public int? TeamId { get; set; }
        public Team Team { get; set; }
    }
}
