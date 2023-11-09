using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    interface PromedioInterfaz
    {
        
        string mostrarPromedio();
        string mostrarPromedio(double nota1, double nota2, double nota3);
        double calcularPromedio();
        double calcularPromedio(double nota1, double nota2, double nota3);
    }

    
    class Promedio : PromedioInterfaz
    {
        
        private double nota1;
        private double nota2;
        private double nota3;

        
        public Promedio(double nota1, double nota2, double nota3)
        {
            this.nota1 = nota1;
            this.nota2 = nota2;
            this.nota3 = nota3;
        }

        
        public string mostrarPromedio()
        {
            return "El promedio es: " + calcularPromedio();
        }

        
        public string mostrarPromedio(double nota1, double nota2, double nota3)
        {
            return "El promedio es: " + calcularPromedio(nota1, nota2, nota3);
        }

        
        public double calcularPromedio()
        {
            return (nota1 + nota2 + nota3) / 3;
        }

        
        public double calcularPromedio(double nota1, double nota2, double nota3)
        {
            return (nota1 + nota2 + nota3) / 3;
        }
    }

}
