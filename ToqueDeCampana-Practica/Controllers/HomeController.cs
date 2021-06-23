using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ToqueDeCampana_Practica.Models;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Http;
using static System.Net.Mime.MediaTypeNames;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace ToqueDeCampana.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly bd_toque_campanaV3Context _context;
        private readonly IHostingEnvironment Environment;
        // private readonly FormCollection _formCollection;
        public object SerializerSettings { get; set; }
        public HomeController(ILogger<HomeController> logger , bd_toque_campanaV3Context context, IHostingEnvironment _environment)
        {
            //_formCollection = formCollection;
            _logger = logger;
            _context = context;
            Environment = _environment;
        }
        public IActionResult Index()
        {
           
            return View();
        }


        [HttpPost]
        public ActionResult Login(String email, String clave){

            if(!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(clave)){

              var user=  _context.TblAlumnos.FirstOrDefault(e => e.VchCorreo == email && e.VchMatricula == clave);
                

                if (user!=null)
                {

                    return RedirectToAction("Alumno", "Home", new { matricula = user.VchMatricula });

                   // return (ActionResult)Login(newuser.VchNombre);
                }
                else
                {
                    return (ActionResult)Login("Lo sentimos!!, No estas Registrado en el sistema");
                }

            }
            else{

                return (ActionResult)Login("Campos vacios, Por favor llene los Campos");

            }
        }

      

        public IActionResult Login(String menssaje = "")
        {
            ViewBag.Menssaje = menssaje;
            return View();
        }

        public IActionResult Mensaje(String menssaje = "")
        {
            ViewBag.Menssaje = menssaje;
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Alumno(String matricula)
        {


            ToqueDeCampana_Practica.Models.TblAlumno tblAlumno = new ToqueDeCampana_Practica.Models.TblAlumno();
            var usuario =_context.TblAlumnos.FirstOrDefault(e => e.VchMatricula == matricula);

            tblAlumno.IdAlumnos = usuario.IdAlumnos;
            tblAlumno.VchNombre = usuario.VchNombre; 
            tblAlumno.VchApellidos = usuario.VchApellidos;
            tblAlumno.VchCorreo = usuario.VchCorreo;
            tblAlumno.VchMatricula =matricula;
            tblAlumno.VchTel1 = usuario.VchTel1;
            tblAlumno.VchTel2 = usuario.VchTel2;
            tblAlumno.VchFoto = usuario.VchFoto;
            tblAlumno.VchColonia = usuario.VchColonia;



            ViewData["alumno"] = tblAlumno;
            ViewData["titulo"] = "Datos del alumno";
            ObtieneCarrera();
            ObtieneResidencia();

            return View(tblAlumno);
        }


        public IActionResult ObtieneCarrera()
        {
            var carrera = _context.TblUniversidads.ToList();

            List<SelectListItem> items = carrera.ConvertAll(d =>
            {
                return new SelectListItem()
                {
                    Text = d.VchUniversidad.ToString(),
                    Value = d.IdUniversidad.ToString(),
                    Selected = false
                };
            });

            ViewBag.Item = items;
            return View(); 
        }

        public JsonResult GetCarreraId(int Id)
        {
            var Carrera = _context.TblCarreras.Where(x => x.IdUniversidad1==Id).ToList();
            Console.WriteLine(Carrera);


            var json = JsonSerializer.Serialize(Carrera);

            Console.WriteLine(json);
            
            return Json(json);

        }
        public IActionResult ObtieneResidencia()
        {
            var residencias = _context.TblResidencia.ToList();

            List<SelectListItem> ciudad = residencias.ConvertAll(d =>
            {
                return new SelectListItem()
                {
                    Text = d.VchCiudad.ToString(),
                    Value = d.IdResidencia.ToString(),
                    Selected = false
                };
            });

            ViewBag.Ciudad = ciudad;
            return View();
        }
        public JsonResult GetResidencia(int Id)
        {
            var Residencia = _context.TblResidencia.Where(x => x.IdResidencia == Id).ToList();
            Console.WriteLine(Residencia);


            var json = JsonSerializer.Serialize(Residencia);

            Console.WriteLine(json);

            return Json(json);

        }

        [HttpPost]
        public IActionResult Post(TblAlumno alumno)
        {
            _context.TblAlumnos.Attach(alumno);
          
            
            _context.Entry(alumno).Property(x => x.VchTel1).IsModified = true;
            _context.Entry(alumno).Property(x => x.VchTel2).IsModified = true;
            _context.Entry(alumno).Property(x => x.VchTalla).IsModified = true;
            _context.Entry(alumno).Property(x => x.VchMaps).IsModified = true;
            _context.Entry(alumno).Property(x => x.VchDisertacion).IsModified = true;
            _context.Entry(alumno).Property(x => x.VchCPostal).IsModified = true;
            _context.Entry(alumno).Property(x => x.VchColonia).IsModified = true;
            _context.Entry(alumno).Property(x => x.VchCalle).IsModified = true;
            _context.Entry(alumno).Property(x => x.Vchtype).IsModified = true;
            _context.Entry(alumno).Property(x => x.IntNoExterior).IsModified = true;
            _context.Entry(alumno).Property(x => x.IntNoInterior).IsModified = true;
            _context.Entry(alumno).Property(x => x.DtFechaIngreso).IsModified = true;
            _context.Entry(alumno).Property(x => x.BtEstatus).IsModified = true;
            _context.Entry(alumno).Property(x => x.VchAcompanante1).IsModified = true;
            _context.Entry(alumno).Property(x => x.VchAcompanante2).IsModified = true;
            _context.Entry(alumno).Property(x => x.IdCarrera2).IsModified = true;
            _context.Entry(alumno).Property(x => x.IdResidencia2).IsModified = true;
            _context.Entry(alumno).Property(x => x.IdUniversidad2).IsModified = true;
            

            _context.SaveChanges();

            return RedirectToAction("Login", "Home" );
        }

        [HttpPost]
        public IActionResult img_save( ViewImage imagens)
        {

            var filename = imagens.imagename;
            

            string wwwPath = this.Environment.WebRootPath;
            string contentPath = this.Environment.ContentRootPath;
            string foto = null;

            string path = Path.Combine(this.Environment.WebRootPath, "img");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            
            string fileName = Guid.NewGuid().ToString() + Path.GetFileName(filename.FileName);

         
            using (FileStream stream = new FileStream(Path.Combine(path, fileName), FileMode.Create))
            {
               
                filename.CopyTo(stream);
     
            }

            TblAlumno alumno = new TblAlumno();
            alumno.IdAlumnos = Convert.ToInt32(imagens.id);
            alumno.VchMatricula = imagens.VchMatricula;
            alumno.VchFoto = fileName;

            _context.TblAlumnos.Attach(alumno);
            _context.Entry(alumno).Property(x => x.VchFoto).IsModified = true;

            _context.SaveChanges();

            return RedirectToAction("Alumno", "Home", new { matricula = alumno.VchMatricula });
        }

        [HttpPost]
        public IActionResult Mensaje(TblAlumno alumno)
        {
            

            _context.TblAlumnos.Update(alumno);
            _context.SaveChanges();

            return (ActionResult)Mensaje("Muchas gracias, tu información se ha guardado satisfactoriamente en los próximos días recibirás en tu correo electrónico institucional la fecha y horario para tu Toque de Campana Virtual y el envío de tu kit a tu domicilio ¡Te esperamos en el Commencement PR21! ");


        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
