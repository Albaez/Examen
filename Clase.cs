using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Clase : Alumno
    {
        
        private string nombreClase;
        private string horaClase;
        private string nombreCatedratico;

       
        public Clase(string nombre, string numeroCuenta, string email, string nombreClase, string horaClase, string nombreCatedratico) : base(nombre, numeroCuenta, email)
        {
            this.nombreClase = nombreClase;
            this.horaClase = horaClase;
            this.nombreCatedratico = nombreCatedratico;
        }

       
        public void mostrarClase()
        {
            Console.WriteLine("Nombre de la clase: " + nombreClase);
            Console.WriteLine("Hora de la clase " + horaClase);
            Console.WriteLine("Catedratico " + nombreCatedratico);
        }

        
        public override void mostrarAlumno()
        {
            Console.WriteLine("Nombre del Alumno: " + nombre);
            Console.WriteLine("Numero de Cuenta: " + numeroCuenta);
            Console.WriteLine("Correo electrónico: " + email);
        }
    }

}
