using System;using System.Collections.Generic;using System.Linq;using System.Text;namespace ConsoleApplication15{    class Calculadora //Nombre de nuestra clase.
    {
        private static int dividir;

        static void Main(string[] args)        {            Console.Title = "Calculadora 2"; //Sirve para agregarle un titulo a la ventana
            string resp = "";            do            {

                int Sumar = 0;
                var resto = 0;

                int valor1 = 0; //Aqui se almacenara el primer valor ingresado.
                int valor2 = 0; //Aqui se almacenara el segundo valor ingresado.
                int R = 0; //Aqui se almacenara el resultado de la operacion.

                //Aqui mostraremos los mensajes que apareceran en nuestra consola igual que el menu de seleccion.
                Console.WriteLine("Presione el simbolo para realizar la operacion:n");                Console.WriteLine("1 para sumar");                Console.WriteLine("2 para restar");                Console.WriteLine("3 para multiplicar");                Console.WriteLine("4 para dividir");                Console.Write("n Eliga Una Opcion: "); //Aqui es donde indicaremos que operacion vamos a realizar
                resp = Console.ReadLine();                string eleccion = Convert.ToString(resp);
                //Aqui se agregaran los mensajes para poder ingresar los datos.
                Console.WriteLine("nIngrese sus dos numerosn");                Console.Write("Valor1: ");                valor1 = int.Parse(Console.ReadLine());                Console.Write("Valor2: ");                valor2 = int.Parse(Console.ReadLine());                Console.WriteLine();                switch (eleccion)                {                    case "1":                        Console.WriteLine("El resultado de la suma es:");                        R = valor1 + valor2;                        Console.WriteLine("{0} + {1} = {2}", valor1, valor2, R);                        break;                    case "2":                        if (valor1 >= valor2)
                        {
                            for (int res = valor2; res < valor1; res++)
                            {
                                resto++;
                            }
                            Console.WriteLine("El resultdo de la resta es:" + resto);
                        }

                        else
                        {
                            for (int res = valor1; res < valor2; res++)
                            {
                                resto++;
                            }

                            Console.WriteLine("El resultdo de la resta es: -" + resto);
                        }
                                                   break;                    case "3":                        Console.WriteLine("El resultado de la multiplicacion es:");


                        for (int k = 0; k < valor2; ++k)
                        { //con k < cantidad te aseguras que no sobrepase de CINCO veces 
                            Sumar += valor1; //esta linea hace lo que decis en "5+5+5+5+5" y va a terminar en 25 
                        }
                        Console.WriteLine(Sumar); //muestra Suma, que es la sumaSucesiva 
                        Console.ReadKey(true); //esta linea es para que no se cierre la aplicacion y podas ver el resultado


                        break;                    case "4":                        for (int i = 0; i < valor1;i= i+valor2)
                        {
                            resto++;
                        }                        Console.WriteLine("El resultado de la division es:"+resto);                                                break;                }                Console.Write("n¿Desea Continuar? s/n: "); //Si para realizarlo de nuevo y no para salir.
                resp = Console.ReadLine();            }            while (resp == "s" || resp == "s");        }    }}
