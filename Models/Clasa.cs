using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aplicatie_Web.Models
{
    public class Clasa
    {

        public int ClasaID { get; set; }
        public string Nume { get; set; }
        public int Ora_inceperii { get; set; }
        public int Durata { get; set; }

        public string Program { get; set; }

    }

   
}
