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
        public int matchNum;
        public ParserRegex(String regex1, String result, Boolean match, int matchid=1)
        {
            this.regex = regex1;
            this.Results = result;
            this.containsMatch = match;
            this.matchNum = matchid;
        }
    }
    static class Debugger
    {
        public static void Log(string Input)
        {
            Program.MainForm.textBox1.AppendText(Input+"\n");
        }
    }
    static class Parser
    {
        private static string Definer(string command)
        {
            ParserRegex[] rules = new ParserRegex[10];
            rules[0] = new ParserRegex(@"\/r\/(.+)", @"Browser http://reddit.com/r/{match}", true);
            rules[1] = new ParserRegex(@"(google|search) (.+)", @"Browser https://www.google.co.uk/?gws_rd=cr&ei=AtumUtL6Nq3Y0QXknIDoDQ#q={match}", true, 2);
            rules[2] = new ParserRegex(@"twitch (.+)", @"Browser http://twitch.tv/{match}", true);
            rules[3] = new ParserRegex(@"reddit (.+)", @"Browser http://www.reddit.com/#page={match}", true);
            rules[4] = new ParserRegex(@"(ogn|ongamenet|champions)", "CMD_hidden livestreamer http://twitch.tv/ongamenet mobile_High", false);
            rules[5] = new ParserRegex(@"(twitch|lol|lolstreams)", @"Browser http://twitch.tv/directory/game/League%20of%20Legends", false);
            rules[6] = new ParserRegex(@"(twitter|tweet|twit)", @"Browser http://twitter.com", false);
            rules[7] = new ParserRegex(@"(fb|facebook)", @"Browser http://facebook.com", false);
            rules[8] = new ParserRegex(@"(reddit|rdt)", @"Browser http://www.reddit.com/", false);
            rules[9] = new ParserRegex(@"(google|search)", @"Browser http://google.com", false);
            Match match;
            foreach (ParserRegex current in rules)
            {
                match = Regex.Match(command, current.regex);
                if (match.Groups.Count > 1)
                {
                    string result = current.Results;
                    if (current.containsMatch)
                    {
                        result = result.Replace("{match}", match.Groups[current.matchNum].Value);
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
            Debugger.Log("Command input:  "+command);
            command = Parser.Definer(command);
            Debugger.Log("Interpreted as: " + command);
            string[] commands = command.Split(new string[]{" "}, 2,System.StringSplitOptions.None);
            string operand = commands[0];
            string data = (commands.Length > 1 ? commands[1] : "no data");
            Parser.Run(operand, data);
        }
        private static void Run(string operand, string data){
            switch (operand)
            {
                case "File":
                    Debugger.Log("Opening file: " + data);
                    System.Diagnostics.Process.Start(data);
                    break;
                case "Browser":
                    Debugger.Log("Opening site: " + data);
                    System.Diagnostics.Process.Start(data);
                    break;
                case "CMD_hidden":
                    Debugger.Log("Running command: " + data);
                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                    startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    startInfo.FileName = "cmd.exe";
                    startInfo.Arguments = "/c " + data;
                    process.StartInfo = startInfo;
                    process.Start();
                    break;
                default:
                    Debugger.Log("Unknown operand....attempting to run command.");
                    try
                    {
                        System.Diagnostics.Process.Start(data);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Unable to parse command!","Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        Debugger.Log("Unable to run command.");
                    }
                    break;
            }
            Debugger.Log("Command complete");
            Debugger.Log("");

        }
    }
}
