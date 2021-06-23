using System;
using System.Collections.Generic;

#nullable disable

namespace ToqueDeCampana_Practica.Models
{
    public partial class TblAlumno
    {
        public int IdAlumnos { get; set; }
        public string VchMatricula { get; set; }
        public string VchNombre { get; set; }
        public string VchApellidos { get; set; }
        public string VchTel1 { get; set; }
        public string VchTel2 { get; set; }
        public string VchCorreo { get; set; }
        public string VchDisertacion { get; set; }
        public string Vchtype { get; set; }
        public string VchFoto { get; set; }
        public string VchAvatar { get; set; }
        public DateTime? DtFechaIngreso { get; set; }
        public string VchCalle { get; set; }
        public string VchColonia { get; set; }
        public string VchCPostal { get; set; }
        public int? IntNoExterior { get; set; }
        public int? IntNoInterior { get; set; }
        public string VchMaps { get; set; }
        public string VchTalla { get; set; }
        public string VchAcompanante1 { get; set; }
        public string VchAcompanante2 { get; set; }
        public bool? BtEstatus { get; set; }
        public int? IdKit1 { get; set; }
        public int? IdKit2 { get; set; }
        public int? IdDisertacion { get; set; }
        public int? IdUniversidad2 { get; set; }
        public int? IdCarrera2 { get; set; }
        public int? IdResidencia2 { get; set; }

        public virtual TblCarrera IdCarrera2Navigation { get; set; }
        public virtual TblDisertacion IdDisertacionNavigation { get; set; }
        public virtual TblKit IdKit1Navigation { get; set; }
        public virtual TblKit IdKit2Navigation { get; set; }
        public virtual TblResidencium IdResidencia2Navigation { get; set; }
        public virtual TblUniversidad IdUniversidad2Navigation { get; set; }
    }
}
