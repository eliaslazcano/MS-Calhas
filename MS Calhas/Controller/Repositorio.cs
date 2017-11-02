using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MS_Calhas.Model;
using System.Windows.Forms;

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
        public static string DataParaString(this int data)
        {
            string dataCompleta = Convert.ToString(data);
            string ano = dataCompleta.Substring(0, 4);
            string mes = dataCompleta.Substring(4, 2);
            string dia = dataCompleta.Substring(6, 2);
            return dia + "/" + mes + "/" + ano;
        }
        /// <summary>
        /// Converte uma data de string "31/12/2017" para int 20171231
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static int DataParaInt(this string data)
        {
            string dia = data.Substring(0, 2), mes = data.Substring(3, 2), ano = data.Substring(6, 4);
            string resultado = ano + mes + dia;
            return Convert.ToInt32(resultado);
        }
        /// <summary>
        /// Devolve a diferença de dias entre duas datas
        /// </summary>
        /// <param name="dataMaisAntiga"></param>
        /// <param name="dataMaisModerna"></param>
        /// <returns></returns>
        public static int DataDiferenca(int dataMaisAntiga, int dataMaisModerna)
        {     
            int dia1 = Convert.ToInt32(DataParaString(dataMaisAntiga).Substring(0, 2));
            int mes1 = Convert.ToInt32(DataParaString(dataMaisAntiga).Substring(3, 2));
            int ano1 = Convert.ToInt32(DataParaString(dataMaisAntiga).Substring(6, 4));
            DateTime data1 = new DateTime(ano1, mes1, dia1);

            int dia2 = Convert.ToInt32(DataParaString(dataMaisModerna).Substring(0, 2));
            int mes2 = Convert.ToInt32(DataParaString(dataMaisModerna).Substring(3, 2));
            int ano2 = Convert.ToInt32(DataParaString(dataMaisModerna).Substring(6, 4));
            DateTime data2 = new DateTime(ano2, mes2, dia2);

            var resultado = (data2 - data1).Days;

            return resultado;
        }
        /// <summary>
        /// Valida a data de um MaskedTextBox, retornando TRUE se estiver tudo Ok.
        ///  A validação confere se a data está preenxida e se está correta ao numero maximo de Dia e Mês.
        /// </summary>
        /// <param name="txtData"></param>
        /// <returns>nada</returns>
        public static bool DataValidador(this MaskedTextBox txtData)
        {
            string diaText = txtData.Text.Substring(0, 2);
            string mesText = txtData.Text.Substring(3, 2);

            if (String.IsNullOrWhiteSpace(diaText) || String.IsNullOrWhiteSpace(mesText) || txtData.Text.Length != 10)
            {
                return false;
            }

            var dia = Convert.ToInt32(diaText);
            var mes = Convert.ToInt32(mesText);
            if (dia > 31)
            {
                return false;
            }
            if(mes > 12)
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// Valida a hora de um MaskedTextBox, returna TRUE caso tudo ok. A validação confere se a hora e o minuto está preenxido e se estão dentro dos numeros aceitaveis.
        /// </summary>
        /// <param name="txtHora"></param>
        /// <returns></returns>
        public static bool HoraValidador(this MaskedTextBox txtHora)
        {
            string hora = txtHora.Text.Substring(0, 2);
            string minuto = txtHora.Text.Substring(3, 2);

            if (String.IsNullOrWhiteSpace(hora) || String.IsNullOrWhiteSpace(minuto) || txtHora.Text.Length != 5)
            {
                return false;
            }
            var horaInt = Convert.ToInt32(hora);
            var minutoInt = Convert.ToInt32(minuto);
            if (horaInt > 24 || horaInt < 0)
            {
                return false;
            }
            if (minutoInt > 60 || minutoInt < 0)
            {
                return false;
            }
            return true;
        }
        public static string DataAtualString()
        {
            return DataAtualInt().DataParaString();
        }
        public static string HoraAtualString()
        {
            int hora = DateTime.Now.Hour;
            int minuto = DateTime.Now.Minute;
            string resultado = "";
            if (hora < 10)
            {
                resultado += "0" + hora;
            }
            else
            {
                resultado += hora;
            }
            if (minuto < 10)
            {
                resultado += "0" + minuto;
            }
            else
            {
                resultado += minuto;
            }
            return resultado;
        }
    }
}
