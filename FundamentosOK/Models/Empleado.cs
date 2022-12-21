using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosOK.Models
{
    public class Empleado : Persona
    {
        public override string GetNombreCompleto()
        {
            return this.Nombre + " " + this.Apellido + " " + this.SalarioMinimo;
        }

        protected int SalarioMinimo {get; set;}

        //El empleado tendra un salario minimo de 900
        public Empleado()
        {
            this.SalarioMinimo= 900;
        }
        // creamos un metodo para mostrar el salario minimo
        public void MostrarSalarioMinimo()
        {
            Console.WriteLine("Salario minimo: " + this.SalarioMinimo);
        }
    }
}
