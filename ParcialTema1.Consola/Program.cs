namespace ParcialTema1.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Double Area, Volumen, Altura, Radio, Base, Contador;
           Contador = 0;
            try
            {
                do
                {
                    Console.Write("Ingresar la Altura del cilindro (Poner 0 en Radio y Altura para finalizar):");
                    Altura = Double.Parse(Console.ReadLine());
                    Console.Write("Ingresar el Radio del cilindro (Poner 0 en Radio y Altura para finalizar):");
                    Radio = Double.Parse(Console.ReadLine());
                    Area = sacararea(Radio, Altura);
                    Base = sacarbase(Radio);
                    Volumen = sacarvolumen(Base, Altura);
                    if (Altura > 0 && Radio > 0)
                    {
                        Contador = Contador + 1;
                        Console.WriteLine($"El Area de un cilindro con Altura {Altura} y un radio de {Radio} es de {Math.Truncate(Area)}");
                        Console.WriteLine($"El Volumen de un cilindro con Altura {Altura} y un radio de {Radio} es de {Math.Truncate(Volumen)}");
                    }
                    if (Altura <= 0)
                    {
                        Console.WriteLine("La altura tiene que ser mayor a 0");
                    }
                    if (Radio <= 0)
                    {
                        Console.WriteLine("El radio tiene que ser mayor a 0");
                    }
                } while (Altura != 0 & Radio != 0);
                Console.WriteLine($"Se ingresaron una cantidad de {Contador}  Cilindros");
            }
            catch (Exception)
            {

                Console.WriteLine("Numero ingresado no es valido"); ;
            }
            
          
        }

        private static double sacarvolumen(double Base, double altura)
        {
            double resultado;
            resultado = Base * altura;
            return resultado;
        }

        private static double sacarbase(double radio)
        {
            Double Resultado;
            Resultado = Math.PI * Math.Pow(radio, 2);
            return Resultado;
        }

        private static double sacararea(double radio, double altura)
        {
            Double Resultado;
           Resultado=2 * Math.PI * radio * (altura + radio);
            return Resultado;
        }
    }
}