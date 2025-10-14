using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MCook.ViewModels
{
    public class LoginVM
    {
        public string Email { get; set; }
        public string Senha { get; set; }
        public bool Lembrar { get; set; }

        public string UrlRetorno { get; set; }
    }
}