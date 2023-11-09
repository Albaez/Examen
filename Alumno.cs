using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    abstract class Alumno
    {

        protected string nombre;
        protected string numeroCuenta;
        protected string email;

        
        public Alumno(string nombre, string numeroCuenta, string email)
        {
            this.nombre = nombre;
            this.numeroCuenta = numeroCuenta;
            this.email = email;
        }

      
        public abstract void mostrarAlumno();
    }

}
