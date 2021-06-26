using System;
using System.Collections.Generic;

#nullable disable

namespace ToqueDeCampana_Practica.Models
{
    public partial class TblKit
    {
        public TblKit()
        {
            TblAlumnoIdKit1Navigations = new HashSet<TblAlumno>();
            TblAlumnoIdKit2Navigations = new HashSet<TblAlumno>();
        }

        public int IdKit { get; set; }
        public string VchNombre { get; set; }
        public string ImgKit { get; set; }
        public string VchDescripcion { get; set; }
        public int? IntCategoria { get; set; }

        public virtual ICollection<TblAlumno> TblAlumnoIdKit1Navigations { get; set; }
        public virtual ICollection<TblAlumno> TblAlumnoIdKit2Navigations { get; set; }
    }
}
