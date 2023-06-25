namespace Proyecto.Model
{
    public class Alumno
    {
        public string nombre { get; set; }
        public string calificacion { get; set; }
        public string curso { get; set; }
        public Alumno() 
        {
        }

        public Alumno(string nombre, string calificacion, string curso)
        {
            this.nombre = nombre;
            this.calificacion = calificacion;
            this.curso = curso;
        }
    }
}
