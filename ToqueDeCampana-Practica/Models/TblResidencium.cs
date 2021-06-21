using System;
using System.Collections.Generic;

#nullable disable

namespace ToqueDeCampana_Practica.Models
{
    public partial class TblResidencium
    {
        public TblResidencium()
        {
            TblAlumnos = new HashSet<TblAlumno>();
            TblUniversidads = new HashSet<TblUniversidad>();
        }

        public int IdResidencia { get; set; }
        public string VchCiudad { get; set; }
        public string VchMunicipio { get; set; }
        public string VchEstado { get; set; }
        public string VchPais { get; set; }
        public string VchCPostal { get; set; }

        public virtual ICollection<TblAlumno> TblAlumnos { get; set; }
        public virtual ICollection<TblUniversidad> TblUniversidads { get; set; }
    }
}
