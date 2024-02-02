using System;
using ConsoleApp3;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3
{
    public class Class1
    {
        public static void Main(String[] args)
        {
            Calcular g = new Calcular();
            double n1 = new double();
            double n2 = new double();
            double resul1, resul2, resul3, resul4;
            int opc = 0;
                
            do 
            {
                n1 = g.validar("Digite el primer numero: ");

            }while(n1 <= 0 || n1 > 1000000000);
            g.setA(n1);

            do
            {
                n2 = g.validar("Digite el segundo numero: ");

            } while (n2 <= 0 || n2 > 1000000000);
            g.setB(n2);

            resul1 = g.getnum(n1, n2);

            resul2 = g.getnum1(n2, n1);

            resul3 = g.getnum2(n1, n2);

            resul4 = g.getnum3(n1, n2);

            Console.WriteLine("Selecccione la operacion que desea realizar: ");
            Console.WriteLine("1-Suma ");
            Console.WriteLine("2-Resta ");
            Console.WriteLine("3-Multiplicacion");
            Console.WriteLine("4-Division");
            do
            {
                opc = g.validar("Seleccione");
            } while (opc <= 0 || opc > 4);


            switch (opc)
            {
                case 1:
                    {
                        Console.WriteLine("El resultado de la suma es: ");
                        Console.WriteLine(resul1);
                break;
                    }

                case 2:
                    {
                        Console.WriteLine("El resultado de la resta es: ");
                        Console.WriteLine(resul2);
                break;
                    }

                case 3:
                    {
                        Console.WriteLine("El resultado de la multiplicacion es: ");
                        Console.WriteLine(resul3);
                break;
                    }

                case 4:
                    {
                        Console.WriteLine("El resultado de la division es: ");
                        Console.WriteLine(resul4);
                        break;
                    }
            }
        }


    }
}
