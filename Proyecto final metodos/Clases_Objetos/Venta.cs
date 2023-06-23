using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_final_metodos.Clases_Objetos
{
    public class Venta
    {
        public int id { get; set; }
        public string Comentarios { get; set; }
        public int idUsuario { get; set; }

        public Venta()
        {
            id = 0;
            Comentarios = string.Empty;
            idUsuario = 0;
        }

       
    }
}
