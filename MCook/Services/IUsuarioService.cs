using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MCook.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace MCook.Services
{
    public interface IUsuarioService
    {
        Task<SignInResult> LoginUsuario(LoginVM login);
        Task LogoutUsuario();
    }
}