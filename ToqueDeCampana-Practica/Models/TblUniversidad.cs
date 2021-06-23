using System;
using System.Collections.Generic;

#nullable disable

namespace ToqueDeCampana_Practica.Models
{
    public partial class TblUniversidad
    {
        public TblUniversidad()
        {
            TblAlumnos = new HashSet<TblAlumno>();
            TblCarreras = new HashSet<TblCarrera>();
        }

        public int IdUniversidad { get; set; }
        public string VchUniversidad { get; set; }
        public string VchTelefono { get; set; }
        public string Vchemail { get; set; }
        public bool? BtEstatus { get; set; }
        public int IdResidencia1 { get; set; }

        public virtual TblResidencium IdResidencia1Navigation { get; set; }
        public virtual ICollection<TblAlumno> TblAlumnos { get; set; }
        public virtual ICollection<TblCarrera> TblCarreras { get; set; }
    }
}
