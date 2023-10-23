using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial2Pilas
{
    public class Cliente
    {
        public int Turno { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public DateTime Fecha { get; set; }

        public Cliente(int turno, string nombre, string tipo, DateTime fecha)
        {
            Turno = turno;
            Nombre = nombre;
            Tipo = tipo;
            Fecha = fecha;
        }
    }
}
