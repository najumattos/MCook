using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MCook.Data;
using MCook.Helpers;
using MCook.Models;
using MCook.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace MCook.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly AppDbContext _context;
        private readonly object _signInManager;
        private readonly UserManager<string> _userManager;
        private readonly ILogger<UsuarioService> _logger;

        public UsuarioService(
            AppDbContext context,
            SignInManager<Usuario> signInManager,
            UserManager<string> userManager,
            ILogger<UsuarioService> logger
        )
        {
            _context = context;
            _signInManager = signInManager;
            _userManager = userManager;
            _logger = logger;
        }
        public async Task<SignInResult> LoginUsuario(LoginVM login)
        {
            string userName = login.Email;
            if(Helper.IsValidEmail(login.Email)){
                var user = await _userManager.FindByEmailAsync(login.Email);
                if(user != null) userName = user.UserName;
            }
            var result = await _signInManager.PasswordSignAscyn()
        }

        public Task LogoutUsuario()
        {
            throw new NotImplementedException();
        }
    }
}