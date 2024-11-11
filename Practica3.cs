using System.Timers;

namespace PracticaEstructurasDeControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Edad;
            String nombreApellido;
            Boolean Licencia;
            Licencia = false;
            int dni;
            string RtaLicencia;

            Console.WriteLine("Bienvenido al sistema de registro de automotor, Por favor complete el cuestionario");
            Console.WriteLine("Ingrese su nombre y apellido");
            nombreApellido = Console.ReadLine();
            Console.WriteLine("Ingrese su dni");
            dni = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("¿Cual es su edad?");
            Edad = Convert.ToInt32(Console.ReadLine());
            if (Edad >= 18)
            {

                Console.WriteLine("Usted tiene licencia de conducir? (Si o No)");
                RtaLicencia = Console.ReadLine();

                if (RtaLicencia == "SI")
                {
                    Console.WriteLine("Bienvenido al sistema");
                }
                else if (RtaLicencia == "NO")
                {
                    Console.WriteLine("Debes tener Licencia de Conducir para registrarte en el sistema");
                }
            }
            else
            {
                Console.WriteLine("Debes ser Mayor de Edad Para registrarte");
            }
        }
    }
}
