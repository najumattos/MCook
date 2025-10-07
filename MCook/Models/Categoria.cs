using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MCook.Models
{
    [Table("Categoria")]
    public class Categoria
    {
        [Key]
        public int Id { get; set; }

        
    }
}