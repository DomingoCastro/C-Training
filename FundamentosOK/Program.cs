
using FundamentosOK.Helpers;
using FundamentosOK.Models;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace FundamentosOK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Empleado empleado= new Empleado();
            //empleado.MostrarSalarioMinimo();
            //// Creamos tambien un director
            //Director director= new Director();
            //director.MostrarSalarioMinimo();
            //Persona persona = new Persona();
            //Persona persona2 = new Persona("Lucas", "Martinez");
            //persona.Nombre = "Maria";
            //persona.Apellido = "Castro";
            //Console.WriteLine(persona.ToString());




            //persona.Edad = 28;
            //persona.Nacionalidad = Paises.España;
            //Console.WriteLine("Nombre de la persona " + persona.Nombre);
            //Console.WriteLine("Edad: " + persona.Edad);
            //Console.WriteLine("Pais: " + persona.Nacionalidad);
            //persona[0] = "Ojos negros";
            //persona[1] = "Alta";
            //Console.WriteLine(persona2.GetNombreCompleto(orden:true));

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
            //SumarColecciones();
            //AdministrarTemperaturas();
            //AdministrarTemperaturasHelper();
            ManejarCoche();
        }


        static void ManejarCoche()
        {

            Coche coche = new Coche();
            coche.Marca = "Opel";
            coche.Modelo = "Corsa";
            Console.WriteLine("Marca: " + coche.Marca+ " " +"Modelo: " + " "+ coche.Modelo);
            int opcion = -1;
            while (opcion != 0)
            {
                Console.WriteLine("Elije una opcion");
                Console.WriteLine("1.-Arrancar");
                Console.WriteLine("2.-Acelerar");
                Console.WriteLine("3.-Girar");
                Console.WriteLine("4.-Frenar");
                Console.WriteLine("5.-Apagar");
                Console.WriteLine("6.-Accelerar lo que quieras");
                Console.WriteLine("0.-Salir");
                opcion = int.Parse(Console.ReadLine());
                if (opcion == 1)
                {
                    coche.Arrancar();

                }
                else if (opcion == 2)
                {
                    coche.GetVelocidadMaxima();
                    coche.Acelerar();
                }
                else if (opcion == 3)
                {
                    coche.Girar();
                }
                else if (opcion == 4)
                {
                    coche.Frenar();
                }
                else if (opcion == 5)
                {
                    coche.Detener();
                }
                else if (opcion == 6)
                {
                    coche.AcelerarCantidad();
                }
                else if (opcion == 0)
                {
                    Console.WriteLine("Saliendo...");
                    opcion = 0;
                }
                else
                {
                    Console.WriteLine("ERROR NUMERO INCORRECTO");
                }
            }
        }


        static void AdministrarTemperaturasHelper()
        {
            HelperMeses helper = new HelperMeses();
            foreach (TemperaturaMes mes in helper.Meses)
            {
                Console.WriteLine("Nombre del mes: " + mes.NombreMes + " "+ "Máxima del mes: " + mes.Maxima+ " "+ "Minima del mes: " + mes.Minima + " "+ "Media del mes: "+ mes.GetMediaMes());
            }
            Console.WriteLine("Minima anual: " + helper.GetMediaAnual());
            Console.WriteLine("Maxima anual: " + helper.GetMaximaAnual());
            Console.WriteLine("Media anual: " + helper.GetMediaAnual());
        }

        static void AdministrarTemperaturas()
        {
            //QUEREMOS GENERAR 12 TEMPERATURAS ASIGNAREMOS VALORES ALEATORIOS PARA MAXIMO Y MINIMO
            // PARA GENERAR VALORES ALEATORIOS DENTRO DE NET SE UTILIZA LA CLASE RANDOM
            // DICHA CLASE TIENE UN METODO Next() QUE NOS DEVUELVE UN NUMERO ALEATORIO ENTRE UN MINIMO Y UN MAXIMO
            Random random= new Random();
            List<TemperaturaMes> meses = new List<TemperaturaMes>();
            // REALIZAMOS UN BUCLE DE 1 A 12 PARA IR CREANDO MES A MES Y AÑADIENDOLO A LA COLECCION
            for (int i = 1; i<= 12; i++)
            {
                TemperaturaMes mes = new TemperaturaMes();
                mes.NombreMes= "Mes " + i;
                mes.Maxima = random.Next(20, 60);
                mes.Minima= random.Next(-7, 17);
                meses.Add(mes);
            }
            foreach (TemperaturaMes mes in meses)
            {
                Console.WriteLine(mes.NombreMes +" "+ "Maxima: " + mes.Maxima +" "+ "Minima: " + mes.Minima +" "+ "Media: " + mes.GetMediaMes());
            }
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