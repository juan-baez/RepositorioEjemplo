using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEjemplo
{
    public class Usuario
    {
        public string Username { get; set; }
        public string Password { private get; set; }

        public string GetEncryptedPassword()
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(this.Password));
        }
    }
}
