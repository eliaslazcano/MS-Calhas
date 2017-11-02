using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS_Calhas.Model
{
    public class RegistroCarga
    {
        public enum Materiais
        {
            PU,
            Silicone
        };
        public enum Tipos
        {
            Entrada,
            Saida
        };

        public int Id { get; set; }
        public Materiais material { get; set; }
        public Tipos tipo { get; set; }
        public string data { get; set; }
        public string hora { get; set; }
        public int quantidade { get; set; }
        public Funcionario funcionario { get; set; }
        public int FuncionarioId { get; set; }
    }
}
