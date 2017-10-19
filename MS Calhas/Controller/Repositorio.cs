using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MS_Calhas.Model;

namespace MS_Calhas.Controller
{
    static class Repositorio
    {
        public static Usuario usuarioAtivo { get; set; }//usuario online

        /// <summary>
        /// Retorna a data atual do computador em INT padrão 19991231
        /// formato ideal para ordenar datas ou salvar no banco.
        /// </summary>
        /// <returns></returns>
        public static int DataAtualInt()
        {
            int nDia = DateTime.Now.Day;
            int nMes = DateTime.Now.Month;
            int nAno = DateTime.Now.Year;
            string txtData = Convert.ToString(nAno);

            if (nMes < 10)
            {
                txtData += "0" + nMes;
            }
            else
            {
                txtData += Convert.ToString(nMes);
            }

            if (nDia < 10)
            {
                txtData += "0" + nDia;
            }
            else
            {
                txtData += Convert.ToString(nDia);
            }
            return Convert.ToInt32(txtData);
        }

        /// <summary>
        /// Converte uma data INT padrão 19991231 para string 31/12/1999
        /// </summary>
        /// <param name="data"></param>
        /// <returns>Retorna uma string</returns>
        /// <remarks>Só funciona se usar INT de 8 digitos padrão 20001231</remarks>
        public static string DataParaString(int data)
        {
            string dataCompleta = Convert.ToString(data);
            string ano = dataCompleta.Substring(0, 4);
            string mes = dataCompleta.Substring(4, 2);
            string dia = dataCompleta.Substring(6, 2);
            return dia + "/" + mes + "/" + ano;
        }
    }
}
