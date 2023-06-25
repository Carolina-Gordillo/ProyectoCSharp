using System;
using Microsoft.AspNetCore.Mvc;
using Proyecto.Model;

namespace Proyecto.Controllers
{
    [ApiController]
    [Route("/api/v1/[controller]")]
    public class AlumnoController
    {
        public AlumnoController() 
        {
        }

        [HttpGet(Name = "GetAlumno")]
        public List<Alumno> dameLista()
        {
            List<Alumno> lista = new List<Alumno>();
            lista.Add(new Alumno("Carolina", "9", "Java"));
            lista.Add(new Alumno("Caro", "8", "CSharp"));
            lista.Add(new Alumno("Lina", "7", "Java"));
            lista.Add(new Alumno("Joel", "9", "CSharp"));
            lista.Add(new Alumno("Carlos", "8", "Android"));
            lista.Add(new Alumno("Gabriel", "7", "Flutter"));
            return lista;
        }

        [HttpGet]
        [Route ("/buscarAlumno")]
        public dynamic dameAlumno(string nombreAlumno)
        {
            Alumno respuesta = null;
            foreach (Alumno elemento in dameLista()) 
            {
                if (elemento.nombre == nombreAlumno)
                {
                    respuesta = elemento; break;
                }
            }

            if (respuesta != null)
            {
                return new
                {
                    stauts = 200,
                    Datos = respuesta
                };
            }
            return new
            {     
                status = 404
            };
            
        }

        //////////
        //BUSCAR POR CURSO
        
         [HttpGet]
        [Route ("/buscarCurso")]
        public dynamic dameCurso(string nombreCurso)
        {
            List<Alumno> respuesta_curso = new List<Alumno>();
            foreach (Alumno elemento_curso in dameLista()) 
            {
                if (elemento_curso.curso == nombreCurso)
                {
                    respuesta_curso.Add((elemento_curso)); //break;                   
                }

            }
            
           if (respuesta_curso != null)
            {
                if (!respuesta_curso.Any())
                {
                    return new
                    {
                        status = 404
                    };
                }
                return new
                {
                    status = 200,
                    Datos = respuesta_curso
                };
            }

           return new
            {
                status = 404
            };
            
        }  

        //////

    }
}
