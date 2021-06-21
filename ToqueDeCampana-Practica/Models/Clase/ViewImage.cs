using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToqueDeCampana_Practica.Models
{
    public class ViewImage
    {

        public int id { get; set; }
        public string VchMatricula { get; set; }
        public IFormFile imagename { get; set; }
    }
}
