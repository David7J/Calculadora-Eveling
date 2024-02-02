using System;
using System.Text;

namespace ConsoleApp3
{
    public class Calcular
    {
        double a, b;

        public Calcular()
        {

        }

        public Calcular(double a)
        {
            this.a = a;
        }

        public void setA(double a)
        {
            this.a=a;
        }

        public void setB(double b)
        {
            this.b=b;   
        }

        public double getnum(double a, double b)
        {
            return a + b;
        }

        public double getnum1(double a, double b)
        {
            return a - b;
        }

        public double getnum2(double a, double b)
        {
            return a * b;
        }

        public double getnum3(double a, double b)
        {
            return a / b;           
        }

        public int validar(String Mensaje)
        {
            int num = 0, v;
            do
            {
                v = 1;
                try
                {
                    Console.WriteLine(Mensaje);
                    num = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception error)
                {
                    v = 0;
                    Console.WriteLine("No se aceptan letras: ", error.Message);
                }
            } while (v == 0);
            return num;
        }

    }

}
