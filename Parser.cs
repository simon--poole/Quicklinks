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
            match = System.Text.RegularExpressions.Regex.Match(command, @"twitch (.+)");
            if (match.Groups.Count > 1)
            {
                string value = "Browser http://twitch.tv/" + match.Groups[1].Value;
                return value;
            }
            match = System.Text.RegularExpressions.Regex.Match(command, @"(ogn|ongamenet|champions)");
            if (match.Groups.Count > 1)
            {
                string value = "CMD_hidden livestreamer http://twitch.tv/ongamenet mobile_High";
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
            string[] commands = command.Split(new string[]{" "}, 2,System.StringSplitOptions.None);
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
                case "CMD_hidden":
                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                    startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    startInfo.FileName = "cmd.exe";
                    startInfo.Arguments = "/c " + data;
                    process.StartInfo = startInfo;
                    process.Start();
                    break;
                default:
                    try
                    {
                        System.Diagnostics.Process.Start(data);
                    }
                    catch (Exception E)
                    {
                        MessageBox.Show(E.Message);
                    }
                    break;
            }

        }
    }
}
