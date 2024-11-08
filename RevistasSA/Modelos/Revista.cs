using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevistasSA.Modelos
{
    public class Revista
    {
        public int RevistaID { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public string Categoria { get; set; }
        public string Frecuencia { get; set; }
    }

}
