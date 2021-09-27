using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        public static void Main(string[] args)
        {
            string path = "DC=contoso,DC=local";
            DirectoryEntryConfigurationSettings(path);
        }


        static void DirectoryEntryConfigurationSettings(string domainADsPath)
        {
            // Bind to current domain

            DirectoryEntry entry = new DirectoryEntry("LDAP://192.168.92.200/" + domainADsPath, "contoso\\administrator", "Br@sil01");
            DirectoryEntryConfiguration entryConfiguration = entry.Options;

            Console.WriteLine("Server: " + entryConfiguration.GetCurrentServerName());
            Console.WriteLine("Page Size: " + entryConfiguration.PageSize.ToString());
            Console.WriteLine("Password Encoding: " +
                entryConfiguration.PasswordEncoding.ToString());
            Console.WriteLine("Password Port: " +
                entryConfiguration.PasswordPort.ToString());
            Console.WriteLine("Referral: " + entryConfiguration.Referral.ToString());
            Console.WriteLine("Security Masks: " +
                entryConfiguration.SecurityMasks.ToString());
            Console.WriteLine("Is Mutually Authenticated: " +
                entryConfiguration.IsMutuallyAuthenticated().ToString());
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}


