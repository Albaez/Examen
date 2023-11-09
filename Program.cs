using Examen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Clase clase = new Clase("Alba Zuniga", "T32321061", "alba@unitec.edu", "Programación II", "18:30 pm - 19:30 pm", "Ing. Roger Ivan Gurdian Castillo");

            
            clase.mostrarClase();
            clase.mostrarAlumno();

            
            double nota1, nota2, nota3;

            
            try
            {
                
                Console.Write("Ingrese la nota 1: ");
                nota1 = double.Parse(Console.ReadLine());
                Console.Write("Ingrese la nota 2: ");
                nota2 = double.Parse(Console.ReadLine());
                Console.Write("Ingrese la nota 3: ");
                nota3 = double.Parse(Console.ReadLine());

                
                Promedio promedio = new Promedio(nota1, nota2, nota3);

               
                Console.WriteLine(promedio.mostrarPromedio(nota1, nota2, nota3));
            }
            catch (Exception e)
            {
                
                Console.WriteLine("Ha ocurrido un error: " + e.Message);
            }
        }
    }
}

