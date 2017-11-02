using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;

namespace MS_Calhas.Controller
{
    public class MacAPI
    {
        /// <summary>
        /// Retorna o Endereco MAC da atual placa de rede em uso.
        /// </summary>
        /// <returns></returns>
        public static String obterMAC()
        {
            return (from nic in NetworkInterface.GetAllNetworkInterfaces()
                    where nic.OperationalStatus == OperationalStatus.Up
                    select nic.GetPhysicalAddress().ToString()
                          ).FirstOrDefault();
        }
    }
}
