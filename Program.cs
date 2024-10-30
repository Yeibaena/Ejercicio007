
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            // Solicitar datos al usuario
            int creditos = SolicitarEntero("Ingrese el número de créditos:");
            int estrato = SolicitarEntero("Ingrese el estrato (1, 2 o 3):");
            double valorCredito = SolicitarDouble("Ingrese el valor del crédito:");

            // Crear una instancia de la clase Estudiante
            Estudiante estudiante = new Estudiante(creditos, estrato, valorCredito);

            // Calcular el costo de la matrícula y el subsidio
            double costoMatricula = estudiante.CalcularMatricula();
            double subsidio = estudiante.CalcularSubsidio();

            // Mostrar los resultados
            Console.WriteLine($"El costo de la matrícula es: {costoMatricula:C}");
            Console.WriteLine($"El valor del subsidio es: {subsidio:C}");

            // Preguntar al usuario si desea calcular la matrícula de otro estudiante
            Console.WriteLine("¿Desea calcular la matrícula de otro estudiante? (s/n)");
            string respuesta = Console.ReadLine();
            if (respuesta.ToLower() != "s")
            {
                break;
            }
        }
    }

    static int SolicitarEntero(string mensaje)
    {
        int valor;
        while (true)
        {
            Console.WriteLine(mensaje);
            if (int.TryParse(Console.ReadLine(), out valor))
            {
                break;
            }
            else
            {
                Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero.");
            }
        }
        return valor;
    }

    static double SolicitarDouble(string mensaje)
    {
        double valor;
        while (true)
        {
            Console.WriteLine(mensaje);
            if (double.TryParse(Console.ReadLine(), out valor))
            {
                break;
            }
            else
            {
                Console.WriteLine("Entrada no válida. Por favor, ingrese un número decimal.");
            }
        }
        return valor;
    }
}
