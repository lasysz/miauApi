using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
   public class Aluno
    {
        public Guid Id { get; set;}
        public string? Nome { get; set; }
        public string? Escola { get; set; }
        public string? Professor { get; set; }
    }
}
