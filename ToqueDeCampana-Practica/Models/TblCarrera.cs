using System;
using System.Collections.Generic;

#nullable disable

namespace ToqueDeCampana_Practica.Models
{
    public partial class TblCarrera
    {
        public TblCarrera()
        {
            TblAlumnos = new HashSet<TblAlumno>();
        }

        public int IdCarrera { get; set; }
        public string VchCarrera { get; set; }
        public string VchDescripcion { get; set; }
        public string VchSementre { get; set; }
        public bool? BtEstatus { get; set; }
        public int IdUniversidad1 { get; set; }

        public virtual TblUniversidad IdUniversidad1Navigation { get; set; }
        public virtual ICollection<TblAlumno> TblAlumnos { get; set; }
    }
}
