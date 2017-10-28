using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS_Calhas.Model
{
    public class Cheque
    {
        public int Id { get; set; }//chave primaria auto-incremento
        public string Cliente { get; set; }//nome do cliente
        public string CodBanco { get; set; }//código do banco
        public string Banco { get; set; }//nome do banco
        public string NumCheque { get; set; }//numero do cheque
        public string Conta { get; set; }//numero da conta
        public double Valor { get; set; }//valor do cheque
        public string DataCheque { get; set; }//data do cheque, dia que vai descontar
        public string DataCompensacao { get; set; }//data que o usuario registrou que o cheque foi descontado
        public bool Compensado { get; set; }//se o cheque ja foi compensado.
    }
}
