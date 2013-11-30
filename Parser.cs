using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace QuickLinks
{
    static class Parser
    {
        static string checkCommon(string command)
        {
            System.Text.RegularExpressions.Match match = System.Text.RegularExpressions.Regex.Match(command, @"\/r\/(.+)");
            if (match.Groups.Count > 1)
            {
                string value = "Browser http://reddit.com/r/"+match.Groups[1].Value;
                return value;
            }
            match = System.Text.RegularExpressions.Regex.Match(command, @"(\.com|\.co\.uk|www\.)");
            if (Uri.IsWellFormedUriString(command, UriKind.Absolute))
            {
                return "Browser " + command;
            }
            if(match.Groups.Count > 1 && !Uri.IsWellFormedUriString(command, UriKind.Absolute))
            {
                UriBuilder builder = new UriBuilder();
                builder.Host = command;
                return "Browser "+builder.ToString();
            }
            return "Error";
        }
        public static void Parse(string command)
        {
            command = checkCommon(command);
            string[] commands = command.Split(' ');
            string operand = commands[0];
            string data = commands[1];
            switch (operand)
            {
                case "File":
                    System.Diagnostics.Process.Start(data);
                    break;
                case "Browser":
                    System.Diagnostics.Process.Start(data);
                    break;
                default:
                    goto case "Browser";
            }

        }
    }
}
