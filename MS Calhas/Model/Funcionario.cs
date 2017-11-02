using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS_Calhas.Model
{
    public class Funcionario
    {
        public int FuncionarioId { get; set; }
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public List<RegistroCarga> RegistrosCarga { get; set; }
    }
}
