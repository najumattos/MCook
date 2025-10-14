using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MCook.Models;

namespace MCook.ViewModels
{
    public class HomeVM
    {
        public List<Categoria> Categorias { get; set; }
        public List<Receita> Receitas { get; set; }
    }
}