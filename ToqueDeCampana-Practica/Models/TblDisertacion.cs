using System;
using System.Collections.Generic;

#nullable disable

namespace ToqueDeCampana_Practica.Models
{
    public partial class TblDisertacion
    {
        public TblDisertacion()
        {
            TblAlumnos = new HashSet<TblAlumno>();
        }

        public int IdDisertacion { get; set; }
        public string VchNombre { get; set; }
        public string VchDescripcion { get; set; }

        public virtual ICollection<TblAlumno> TblAlumnos { get; set; }
    }
}
