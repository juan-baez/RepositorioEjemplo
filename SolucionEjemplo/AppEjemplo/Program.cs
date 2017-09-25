using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEjemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("------------");

            Usuario usuario = new Usuario()
            {
                Username = "user",
                Password = "1234"
            };

            Console.WriteLine("¡Hola {0}! Su contraseña es: {1}", usuario.Username, usuario.Password);
            Console.WriteLine("Presione cualquier tecla para finalizar la aplicación...");

            Console.Read();
        }

        private static int Sumar(int x, int y)
        {
            return x + y;
        }
    }
}
