using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea5.Data
{
    public class Secret
    {
        public int SecretId { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public double Valor_monetario { get; set; }
        public DateTime Fecha { get; set; }
        public string Lugar { get; set; }
        public double Lat { get; set; }
        public double Lng { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
