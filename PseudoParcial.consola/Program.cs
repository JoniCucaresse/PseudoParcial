using System.Diagnostics;

namespace PseudoParcial.consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double area, volumen, generatriz;
            double radio = PedirDouble("Ingrese el valor del radio del cono: ");
            double altura = PedirDouble("Ingrese el valor de la altura del cono: ");

            if (altura>0)
            {
                if (radio>0)
                {
                    generatriz = CalcularGeneratriz(radio, altura);
                    area = CalcularArea(radio, generatriz);
                    volumen = CalcularVolumen(radio, altura);

                    Console.WriteLine($"El area del cono es: {area}");
                    Console.WriteLine($"El volumen del cono es: {volumen}");

                }
                else
                {
                    Console.WriteLine("Radio mal ingresado");
                }
            }
            else
            {
                Console.WriteLine("Altura mal ingresada");
            }

        }
        private static double PedirDouble(string Mensaje)
        {
            double nro = 0;
            do
            {
                Console.Write(Mensaje);
                string strConsola = Console.ReadLine();
                if (!double.TryParse(strConsola, out nro))
                {
                    Console.WriteLine("Número mal ingresado");

                }
                else
                {
                    break;
                }

            } while (true);
            return nro;
        }

        private static double CalcularVolumen(double radio, double altura) => (Math.PI * Math.Pow(radio, 2) * altura) / 3;

        private static double CalcularArea(double radio, double generatriz) => Math.PI * radio * (radio + generatriz);

        private static double CalcularGeneratriz(double radio, double altura)=>Math.Sqrt(Math.Pow(radio, 2)+Math.Pow(altura, 2));
      
    }
}