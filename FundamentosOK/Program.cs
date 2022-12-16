namespace FundamentosOK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // METODO PRINCIPAL DE EJECUCION
            // Realizamos la llamada a los metodos que deseemos
            //PositivoNegativo();
            //CalcularDiaNacimiento();
            //EjemploBucles();
            //ConjeturaCollatz();
            //MostrarPares();
            SumaBucle();
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