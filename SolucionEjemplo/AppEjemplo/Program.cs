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

            Console.WriteLine("¡Hola {0}! Su contraseña es: {1}", usuario.Username, usuario.GetEncryptedPassword());

            Random random = new Random();
            int x = random.Next(1, 100);
            int y = random.Next(1, 100);

            int total = Sumar(x, y);

            Console.WriteLine("Operación matemática: {0} + {1} = {2}", x, y, total);
            
            Console.WriteLine("Presione cualquier tecla para finalizar la aplicación...");

            Console.Read();
        }

        private static int Sumar(int x, int y)
        {
            return x + y;
        }
    }
}
