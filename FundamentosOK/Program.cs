
using FundamentosOK.Models;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace FundamentosOK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            persona.Nombre = "Maria";
            persona.Apellido = "Castro";
            persona.Edad = 28;
            persona.Nacionalidad = Paises.España;
            Console.WriteLine("Nombre de la persona " + persona.Nombre);
            Console.WriteLine("Edad: " + persona.Edad);
            Console.WriteLine("Pais: " + persona.Nacionalidad);
            // METODO PRINCIPAL DE EJECUCION
            // Realizamos la llamada a los metodos que deseemos
            //PositivoNegativo();
            //CalcularDiaNacimiento();
            //EjemploBucles();
            //ConjeturaCollatz();
            //MostrarPares();
            //SumaBucle();
            //EjemploClases();
            //ValidacionEmail();
            //SumaTexto();
            //ValidarIsbn();
            // EjemploColecciones();
            SumarColecciones();
        }


        static void SumarColecciones()
        {
            List<int> numeros = new List<int>();
            int opcion = 1;
            int suma = 0;
            float mediana = 0;
            while (opcion == 1)
            {
                Console.WriteLine("Introduce un numero");
                int number = int.Parse(Console.ReadLine());
                if (number != 0)
                {
                    numeros.Add(number);
                }
                else
                {
                    
                    Console.WriteLine("Elementos de la coleccion " + numeros.Count);
                    foreach(int num in numeros)
                    {
                        suma += num;

                        mediana = suma / numeros.Count;
                        
                    }
                    opcion = 0;
                    Console.WriteLine("La suma de los numeros es: " + suma);
                    Console.WriteLine("La media es: " + mediana);

                }
                
            }
        }     
        
        
        
        
        static void EjemploColecciones()
        {
            List<int> numeros = new List<int>();
            numeros.Add(1);
            numeros.Add(2);
            numeros.Add(3);
            Console.WriteLine("Elementos de la coleccion " + numeros.Count);
            foreach(int num in numeros)
            {
                Console.WriteLine(num);
            }
            //ARRAY
            List<string> nombres = new List<string>();
            nombres.Add("Ana");
            nombres.Add("Paco");
            nombres.Add("Ana");
            nombres.Add("Domi");
            // QUE SUCEDE SI ELIMINAMOS UN ELEMENTO COMO OBJETO
            // ELIMINA LA PRIMERA COINCIDENCIA
            //nombres.Remove("Ana");
            nombres.RemoveAt(3);
            foreach (string name in nombres)
            {
                Console.WriteLine(name);
            }
        }

        static void ValidarIsbn()
        {
            Console.WriteLine("Validar ISBN");
            Console.WriteLine("Introduce un ISBN correcto");
            string isbn = Console.ReadLine();
            if (isbn.Length != 10)
            {
                Console.WriteLine("El numero ISBN debe tener 10 caracteres");
            }
            else
            {
                int suma = 0;
                for (int i = 0; i < isbn.Length; i++)
                {
                    char caracter = isbn[i];
                    int numero = int.Parse(caracter.ToString());
                    int operacion = numero * (i + 1);
                    suma += operacion;
                }
                if (suma % 11 == 0)
                {
                    Console.WriteLine("Numero ISBN CORRECTO");
                }
                else
                {
                    Console.WriteLine("NUMERO ISBN INCORRECTO");
                }
            }
            
        
        
        }

        static void SumaTexto()
        {
            Console.WriteLine("Escribe un numero");
            string texto = Console.ReadLine();
            int suma = 0;
            for (int i = 0; i < texto.Length; i++)
            {
                Char caracter = texto[i];
                int numero = int.Parse(caracter.ToString());
                suma += numero;
                Console.WriteLine("La suma de " + texto + " es: " + suma);
            }
        }



        static void ValidacionEmail()
        {
            Console.WriteLine("Introduzca su email");
            string email = Console.ReadLine();
            if (email.Contains("@") == false)
            {
                Console.WriteLine("No existe @");
            }
            else if (email.IndexOf(".") == -1)
            {
                Console.WriteLine("No existe un .");
            }
            else if (email.StartsWith("@") || email.EndsWith("@") || email.StartsWith(".") || email.EndsWith(".")) 
            {
                Console.WriteLine("El email empieza o acaba con @ o .");
            }
            else if (email.LastIndexOf(".") < email.IndexOf("@"))
            {
                Console.WriteLine("Debe existir un . despues de la @");
            }
            // paco@gmail.com
            else if (email.IndexOf("@") != email.LastIndexOf("@"))
            {
                Console.WriteLine("Existen 2 @");
            }
            else
            {
                int ultimoPunto = email.LastIndexOf('.');
                string dominio = email.Substring(ultimoPunto+ 1);
                if (dominio.Length >= 2 && dominio.Length<= 4)
                {
                    Console.WriteLine("Email correcto");
                }
                else {
                    Console.WriteLine("El dominio debe ser de 2 a 4 caracteres");
                }
            }
        }



        static void EjemploClases()
        {
            DateTime fecha = DateTime.Now;
            Console.WriteLine(fecha.ToLongDateString());
            Console.WriteLine(fecha.ToShortDateString());
            for (int i = 0; i <= 255; i++)
            {
                char letra = (char)i;
                if (char.IsNumber(letra))
                {
                    Console.WriteLine(letra);
                }
            }
        }
       
        static void SumaBucle()
        {
            Console.WriteLine("Escribe un numero para sumar");
            int numero2 = int.Parse(Console.ReadLine());
            int opcion = 1;
            while (opcion == 1 )
            {
                Console.WriteLine("Escribe un numero para sumar");
                int numero1 = int.Parse(Console.ReadLine());
                if (numero1 != 0)
                {
                    int suma = numero1 + numero2;
                    numero2 = suma;
                    Console.WriteLine(suma);
                }
                else
                {
                    Console.WriteLine("Finish");
                    opcion = 0;
                }
            }


        }
        
        
        
        
        
        static void MostrarPares()
        {
            Console.WriteLine("Numero de inicio");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Numero de fin");
            int numero2 = int.Parse(Console.ReadLine());
            
            for (int i = numero1; i <=numero2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("PAR: " + i);
                }
            }
        }
        
        
        
        
        
        
        
        
        static void ConjeturaCollatz()
        {
            Console.WriteLine("Escribe un numero");
            int numero = int.Parse(Console.ReadLine());
            while (numero != 1)
            {
                if (numero % 2 == 0)
                {
                    numero = numero / 2;
                }
                else
                {
                    numero = numero * 3 + 1;
                }
                Console.WriteLine(numero);
            }
            

        }
        
        
        
        
        
        
        static void EjemploBucles()
        {

            int contador = 1;
            while (contador <= 10)
            {
                Console.WriteLine(contador);
                contador += 1;
            }
            
            
            //MOSTRAR UNA LISTA CON LOS NUMEROS DEL 1 AL 10
            // i++ se incrementa de 1 en 1 o usar i+= 1  for (int i = 1; i <=10; i+=2) {}
            //Console.WriteLine(i);
            
            // Para bucle inverso el siguiente: 

            for (int i = 10; i > 0; i--) { 
                Console.WriteLine(i);
            }
        }
        
        
        
        
        
        
        
        static void CalcularDiaNacimiento()
        {
            Console.WriteLine("Escribe tu día");
            int day = int.Parse(Console.ReadLine());
            Console.WriteLine("Escribe tu mes");
            int mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Escribe tu año");
            int anyo = int.Parse(Console.ReadLine());

            if (mes == 1)
            {
                mes = 13;
                anyo -= 1;
            }
            else if (mes == 2)
            {
                mes = 14;
                anyo -= 1;
            }

            int op1 = (mes + 1) * 3 / 5;
            int op2 = anyo / 4;
            int op3 = anyo / 100;
            int op4 = anyo / 400;
            int op5 = day + (mes * 2) + anyo + op1 + op2 - op3 + op4 + 2;
            int op6 = op5 / 7;
            int op7 = op5 - (op6 * 7);

            if (op7 == 0)
            {
                Console.WriteLine("Sábado");
            }
            else if (op7 == 1 )
            {
                Console.WriteLine("Domingo");
            }
            else if (op7 == 2 )
            {
                Console.WriteLine("Lunes");
            }
            else if (op7 == 3 )
            {
                Console.WriteLine("Martes");
            }
            else if (op7 == 4 ) {
                Console.WriteLine("Miercoles");
            }
            else if (op7 == 5 )
            {
                Console.WriteLine("Jueves");
            }
            else if (op7 == 6 )
            {
                Console.WriteLine("Viernes");
            }
            else
            {
                Console.WriteLine("ERROR");
            }
            Console.WriteLine("FIN DE PROGRAMA");
        }
        
        
        
        static void PositivoNegativo()
        {
            Console.WriteLine("Programa positivo negativo cero");
            Console.WriteLine("Escribe un numero");
            int numero = int.Parse(Console.ReadLine());
            if (numero == 0) {
                Console.WriteLine("Es neutral");
            }
            else if (numero > 0)
            {
                Console.WriteLine("Es positivo");
            }
            else
            {
                Console.WriteLine("Es negativo");
            }
        }
    }

}