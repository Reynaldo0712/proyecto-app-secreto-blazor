using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea5.Data
{
    public class User
    {
        public int UserId { get; set; }
        public string Cedula { get; set; }
        public string Clave { get; set; }
        public string State { get; set; }

        public List<Secret> _Secrets { get; } = new List<Secret>();
    }
}
