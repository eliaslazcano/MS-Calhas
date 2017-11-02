using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS_Calhas.Model
{
    public class Section //o nome é pra desfarçar, esta é uma classe que guarda o endereço MAC da maquina e a data da ativacao
    {
        [Key]
        public string unification { get; set; }//endereco mac
        public string inauguracao { get; set; }//data ativacao
    }
}
