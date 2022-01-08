using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicatie_Web.Models
{
    public class Abonament
    {   
        [Key]
        public int AbonamentID { get; set; }
        public string NumeAbonament { get; set; }

       [Column(TypeName = "decimal(6, 2)")]
        public decimal PretAbonament { get; set; }
        public string ValabilitateAbonament  { get; set; }
    }
}
