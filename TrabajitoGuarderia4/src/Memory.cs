using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

using TrabajitoGuarderia4.src.classes;


namespace TrabajitoGuarderia4.src
{
    internal static class Memory
    {
        private static string programName = "[ProgramName]";
        private static List<Account> accounts = new List<Account>();

        public static List<Account> Accounts { get => accounts; set => accounts = value; }
        public static string ProgramName { get => programName; set => programName = value; }
    
    
        public static void Error(string message)
        {
            MessageBox.Show(message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
