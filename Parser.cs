using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace QuickLinks
{
    class ParserRegex
    {
        public String regex;
        public String Results;
        public Boolean containsMatch;
        public ParserRegex(String regex1, String result, Boolean match)
        {
            this.regex = regex1;
            this.Results = result;
            this.containsMatch = match;
        }
    }
    static class Parser
    {
        static string checkCommon(string command)
        {
            ParserRegex[] rules = new ParserRegex[5];
            rules[0] = new ParserRegex(@"\/r\/(.+)", @"Browser http://reddit.com/r/{match}", true);
            rules[1] = new ParserRegex(@"twitch (.+)", @"Browser http://twitch.tv/{match}", true);
            rules[3] = new ParserRegex(@"(ogn|ongamenet|champions)", "CMD_hidden livestreamer http://twitch.tv/ongamenet mobile_High", false);
            rules[4] = new ParserRegex(@"twitch (.+)", @"Browser http://twitch.tv/{match}", true);
            Match match;
            foreach (ParserRegex current in rules)
            {
                match = Regex.Match(command, current.regex);
                if (match.Groups.Count > 1)
                {
                    string result = current.Results;
                    if (current.containsMatch)
                    {
                        result = result.Replace("{match}", match.Groups[1].Value);
                    }
                    return result;
                }
            }
            match = System.Text.RegularExpressions.Regex.Match(command, @"(\.com|\.co\.uk|www\.)");
            if(match.Groups.Count > 1 && !Uri.IsWellFormedUriString(command, UriKind.Absolute))
            {
                UriBuilder builder = new UriBuilder();
                builder.Host = command;
                return "Browser "+builder.ToString();
            }
            else if (Uri.IsWellFormedUriString(command, UriKind.Absolute))
            {
                return "Browser " + command;
            }
            return command;
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
