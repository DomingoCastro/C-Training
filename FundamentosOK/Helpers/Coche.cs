using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosOK.Helpers
{
    public class Coche
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public virtual string GetCoche()
        {
            return Marca + Modelo;
        }
        public override string ToString()
        {
            return Marca + " " + Modelo;
        }
        private int _VelocidadMaxima = 300;
        int velocidadActual = 0;
        string direccion = "";
        bool Estado = false;
        public void Acelerar()
        {
            if (Estado == false)
            {
                Console.WriteLine("El coche esta apagado.");
            }
            else if (velocidadActual < _VelocidadMaxima)
            {
                velocidadActual = velocidadActual + 20;
                Console.WriteLine("La velocidad acutal es de: " + velocidadActual);
            }
            else if (velocidadActual >= _VelocidadMaxima)
            {
                throw new Exception("Velocidad Máxima alcanzada");
            }
        }
        public int GetVelocidadMaxima()
        {
            return _VelocidadMaxima;
        }
        public void Frenar()
        {
            if (velocidadActual == 0)
            {
                Console.WriteLine("No puedo frenar más");
            }
            else
            {
                velocidadActual = velocidadActual - 20;
                Console.WriteLine("Velocidad Actual: " + velocidadActual);
            }
        }
        public void Arrancar()
        {
            if (Estado == false)
            {
                Estado = true;
                Console.WriteLine("Coche arrancado");
            }
            else
            {
                Console.WriteLine("El coche ya esta arrancado");
            }
        }
        public void Detener()
        {
            if (Estado == false)
            {
                Console.WriteLine("El coche ya esta detenido");
            }
            else
            {
                Estado = false;
                velocidadActual = 0;
                Console.WriteLine("Coche apagado");
            }
        }
        public void Girar()
        {
            if (direccion == "Norte")
            {
                direccion = "Este";
                Console.WriteLine(direccion);
            }
            else if (direccion == "Este")
            {
                direccion = "Sur";
                Console.WriteLine(direccion);
            }
            else if (direccion == "Sur")
            {
                direccion = "Oeste";
                Console.WriteLine(direccion);
            }
            else
            {
                direccion = "Norte";
                Console.WriteLine(direccion);
            }
        }
        public void AcelerarCantidad()
        {
            if (Estado == false)
            {
                Console.WriteLine("El coche esta apagado.");
            }
            else if (velocidadActual < _VelocidadMaxima)
            {
                Console.WriteLine("A que velocidad quieres ir?");
                int velocidadnueva = int.Parse(Console.ReadLine());
                int cantidadnuevavelocidad = velocidadActual + velocidadnueva;

                while (cantidadnuevavelocidad > _VelocidadMaxima)
                {
                    Console.WriteLine("Demasiada cantidad tu velocidad actual es superior a la máxima del vehiculo, ingresa otra cantidad");
                    cantidadnuevavelocidad = 0;
                    velocidadnueva = int.Parse(Console.ReadLine());
                    cantidadnuevavelocidad = velocidadnueva + velocidadActual;
                }

                velocidadActual = velocidadActual + velocidadnueva;
                Console.WriteLine("La velocidad acutal es de: " + velocidadActual);
            }
            if (velocidadActual >= _VelocidadMaxima)
            {
                throw new Exception("Velocidad Máxima alcanzada");
            }
        }
    }
}