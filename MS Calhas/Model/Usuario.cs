using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS_Calhas.Model
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public int DataCadastro { get; set; }
        //Atributos ant-roubo:
        public bool Violacao { get; set; }
        public string DataViolacao { get; set; }
        public string HoraViolacao { get; set; }
    }
}
