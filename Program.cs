// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

namespace CalculadoraMultiFuncional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string eleccion;
            do
            {
                Console.Clear();
                Console.WriteLine("Bienvenido a su calculadora multifuncional");
                Console.WriteLine("Elige que tipo de operacion quieres realizar y digite su numero como indicador \r\n");
                Console.WriteLine("1) Basica                      2) conversion de temperatura");
                Console.WriteLine("3) Convercion de peso          4) Conversion de Longitud");
                Console.WriteLine("7) Salir");

                eleccion = Console.ReadLine();

                try
                {
                    switch (eleccion)
                    {

                        case "1":
                            string basica;
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("Basica");


                                Console.WriteLine("Elige que tipo de operacion quieres realizar y digite su numero como indicador \r\n");
                                Console.WriteLine("1) Suma de dos numeros                      2) Resta de dos numeros");
                                Console.WriteLine("3) Multiplicacion de dos numeros            4) Division de dos numeros");
                                Console.WriteLine("7) Salir");
                                basica = Console.ReadLine();
                                switch (basica)
                                {

                                    case "1":
                                        double num1, num2, r;
                                        string s;

                                        do
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Digite el primer numero");
                                            num1 = Convert.ToDouble(Console.ReadLine());
                                            Console.WriteLine("Digite el segundo numero");
                                            num2 = Convert.ToDouble(Console.ReadLine());
                                            r = num1 + num2;
                                            Console.WriteLine("La suma es: " + r);
                                            Console.WriteLine("Digite (7) Para regresar al menú anterior o (Enter) para continuar");
                                            s = Console.ReadLine();
                                        } while (s != "7");

                                        break;
                                    case "2":

                                        do
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Digite el primer numero");
                                            num1 = Convert.ToDouble(Console.ReadLine());
                                            Console.WriteLine("Digite el segundo numero");
                                            num2 = Convert.ToDouble(Console.ReadLine());
                                            r = num1 - num2;
                                            Console.WriteLine("La resta es: " + r);
                                            Console.WriteLine("Digite (7) Para regresar al menú anterior o (Enter) para continuar");
                                            s = Console.ReadLine();
                                        } while (s != "7");
                                        break;
                                    case "3":

                                        do
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Digite el primer numero");
                                            num1 = Convert.ToDouble(Console.ReadLine());
                                            Console.WriteLine("Digite el segundo numero");
                                            num2 = Convert.ToDouble(Console.ReadLine());
                                            r = num1 * num2;
                                            Console.WriteLine("La multiplicacion es: " + r);
                                            Console.WriteLine("Digite (7) Para regresar al menú anterior o (Enter) para continuar");
                                            s = Console.ReadLine();
                                        } while (s != "7");
                                        break;
                                    case "4":

                                        do
                                        {

                                            Console.Clear();
                                            Console.WriteLine("Digite el primer numero");
                                            num1 = Convert.ToDouble(Console.ReadLine());
                                            Console.WriteLine("Digite el segundo numero");
                                            num2 = Convert.ToDouble(Console.ReadLine());
                                            r = num1 / num2;
                                            Console.WriteLine("La division es: " + r);
                                            Console.WriteLine("Digite (7) Para regresar al menú anterior o (Enter) para continuar");
                                            s = Console.ReadLine();
                                        } while (s != "7");
                                        break;
                                    default:
                                        break;
                                }
                            } while (basica != "7");
                            break;
                        case "2":
                            string opcion;
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("Temperatura");


                                Console.WriteLine("Elige una opcion \r\n");
                                Console.WriteLine("1) Fahrenheit a Celsius  2) Celsius a Fahrenheit");
                                Console.WriteLine("3) Kelvin a Celcius      4) Kelvin a Fahrenheit");
                                Console.WriteLine("7) Salir");

                                opcion = Console.ReadLine();
                                switch (opcion)
                                {
                                    case "1":
                                        string s;
                                        do
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Ingrese los grados fahrenheit");
                                            double temp1 = Convert.ToDouble(Console.ReadLine());
                                            Console.WriteLine("Temperatura igual a: " + (temp1 - 32) / 1.8 + "° Celcius");
                                            Console.WriteLine("Digite (7) PPara regresar al menú anterior o (Enter) para continuar");
                                            s = Console.ReadLine();
                                        } while (s != "7");


                                        break;
                                    case "2":
                                        do
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Ingrese los grados celcius");
                                            double temp2 = Convert.ToDouble(Console.ReadLine());
                                            Console.WriteLine("Temperatura igual a: " + ((1.8 * temp2) + 32) + "° fahrenheit");
                                            Console.WriteLine("Digite (7) Para regresar al menú anterior o (Enter) para continuar");
                                            s = Console.ReadLine();
                                        } while (s != "7");
                                        break;
                                    case "3":
                                        do
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Ingrese la temperatura kelvin");
                                            double temp3 = Convert.ToDouble(Console.ReadLine());
                                            Console.WriteLine("Temperatura igual a: " + (temp3 - 273.1) + "° Cencius");
                                            Console.WriteLine("Digite (7) Para regresar al menú anterior o (Enter) para continuar");
                                            s = Console.ReadLine();
                                        } while (s != "7");
                                        break;
                                    case "4":
                                        do
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Ingrese la temperatura kelvin");
                                            double temp4 = Convert.ToDouble(Console.ReadLine());
                                            Console.WriteLine("Temperatura igual a: " + (temp4 - 273.1) * 9 / 5 + 32 + "° fehrenheit");
                                            Console.WriteLine("Digite (7) Para regresar al menú anterior o (Enter) para continuar");
                                            s = Console.ReadLine();
                                        } while (s != "7");
                                        break;

                                    default:
                                        break;
                                }
                            } while (opcion != "7");
                            break;


                        case "3":
                            string peso;
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("Peso");
                                Console.WriteLine("Elige una opcion");
                                Console.WriteLine("1) Kilogramo a Libras           2) Libras a Kilogramos");
                                Console.WriteLine("3) Hectogramo a Kilogramos      4) Libras a Hectogramo");
                                Console.WriteLine("7) Salir");

                                peso = Console.ReadLine();
                                switch (peso)
                                {
                                    case "1":

                                        string s;
                                        do
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Ingrese los kilogramos");
                                            double peso1 = Convert.ToDouble(Console.ReadLine());
                                            Console.WriteLine("El peso es igual a: " + (peso1 * 2.2) + " Libras");
                                            Console.WriteLine("Digite (7) Para regresar al menú anterior o (Enter) para continuar");
                                            s = Console.ReadLine();
                                        } while (s != "7");
                                        break;
                                        

                                    case "2":

                                        do
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Ingrese las libras");
                                            double peso2 = Convert.ToDouble(Console.ReadLine());
                                            Console.WriteLine("El peso es igual a: " + (peso2 / 2.2) + " kilogramos");
                                            Console.WriteLine("Digite (7) Para regresar al menú anterior o (Enter) para continuar");
                                            s = Console.ReadLine();
                                        } while (s != "7");
                                        break;

                                    case "3":
                                        do
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Ingrese los hectogramos");
                                            double peso3 = Convert.ToDouble(Console.ReadLine());
                                            Console.WriteLine("El peso es igual a: " + (peso3 / 10) + " kilogramos");
                                            Console.WriteLine("Digite (7) Para regresar al menú anterior o (Enter) para continuar");
                                            s = Console.ReadLine();
                                        } while (s != "7");
                                        break;

                                    case "4":
                                        do
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Ingrese las libras");
                                            double peso4 = Convert.ToDouble(Console.ReadLine());
                                            Console.WriteLine("El peso es igual a: " + (peso4 * 4.536) + " hectogramos");
                                            Console.WriteLine("Digite (7) PPara regresar al menú anterior o (Enter) para continuar");
                                            s = Console.ReadLine();
                                        } while (s != "7");
                                        break;
                                }
                            } while (peso != "7");
                            break;
                        case "4":
                            string longitud;

                            do
                            {
                                Console.Clear();
                                Console.WriteLine("Longitud");
                                Console.WriteLine("Elige que tipo de operacion quieres realizar y digite su numero como indicador \r\n");
                                Console.WriteLine("1) Pulgadas a centimetros                   2) Kilometros a metros");
                                Console.WriteLine("3) Pies a centimetros                       4) Millas a kilometros");
                                Console.WriteLine("7) Salir");

                                longitud = Console.ReadLine();

                                switch (longitud)
                                {
                                    case "1":
                                        string s;
                                        do
                                        {
                                            double num1, r;
                                            Console.Clear();
                                            Console.WriteLine("ingrese las pulgadas");
                                            num1 = Convert.ToDouble(Console.ReadLine());
                                            r = num1 * 2.54;
                                            Console.WriteLine(r + " Centimetros");
                                            Console.WriteLine("Digite (7) Para regresar al menú anterior o (Enter) para continuar");
                                            s = Console.ReadLine();
                                        } while (s != "7");

                                        break;
                                    case "2":
                                        do
                                        {
                                            double num1, r;
                                            Console.Clear();
                                            Console.WriteLine("ingrese los Kilometros");
                                            num1 = Convert.ToDouble(Console.ReadLine());
                                            r = num1 * 1000;
                                            Console.WriteLine(r + " Metros");
                                            Console.WriteLine("Digite (7) Para regresar al menú anterior o (Enter) para continuar");
                                            s = Console.ReadLine();
                                        } while (s != "7");
                                        break;
                                    case "3":
                                        do
                                        {
                                            double num1, r;
                                            Console.Clear();
                                            Console.WriteLine("ingrese los pies");
                                            num1 = Convert.ToDouble(Console.ReadLine());
                                            r = num1 * 30.48;
                                            Console.WriteLine(r + " Centimetros");
                                            Console.WriteLine("Digite (7) Para regresar al menú anterior o (Enter) para continuar");
                                            s = Console.ReadLine();
                                        } while (s != "7");
                                        break;
                                    case "4":
                                        do
                                        {
                                            double num1, r;
                                            Console.Clear();
                                            Console.WriteLine("ingrese las millas");
                                            num1 = Convert.ToDouble(Console.ReadLine());
                                            r = num1 * 1.609344;
                                            Console.WriteLine(r + " kilometros");
                                            Console.WriteLine("Digite (7) Para regresar al menú anterior o (Enter) para continuar");
                                            s = Console.ReadLine();
                                        } while (s != "7");
                                        break;
                                    default:
                                        break;
                                }
                            } while (longitud != "7");
                            break;

                        default:
                            break;
                    }
                }
                catch (Exception error)
                {
                    Console.Clear();
                    Console.WriteLine("No se puede realizar operaciones con letras o con signos y caracteres especiales. " + error);
                    Console.ReadLine();
                }
                


            } while (eleccion != "7");
            Console.WriteLine("Gracias por preferirnos lo esperamos pronto (Presione enter para salir)");
            Console.ReadLine();
            Environment.Exit(0);
        }
    }
}