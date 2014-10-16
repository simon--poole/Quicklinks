using System;
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
            rules[3] = new ParserRegex(@"wiki (.+)", @"Browser http://wikipedia.org/wiki/{match}", true);
            rules[4] = new ParserRegex(@"(twitter|tweet|twit)", @"Browser http://twitter.com", false);
            rules[5] = new ParserRegex(@"(fb|facebook)", @"Browser http://facebook.com", false);
            rules[5] = new ParserRegex(@"(video|vids)", @"File C:\Users\Simon\Videos", false);
            rules[6] = new ParserRegex(@"(docs|documents)", @"File C:\Users\Simon\Documents", false);
            rules[7] = new ParserRegex(@"(pictures|pics)", @"File C:\Users\Simon\Pictures", false);
            rules[8] = new ParserRegex(@"(music|songs)", @"File C:\Users\Simon\Music", false);
            rules[9] = new ParserRegex(@"(dl|downloads)", @"File C:\Users\Simon\Downloads", false);
            rules[9] = new ParserRegex(@"(git|github)", @"Browser http://github.com", false);
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
            string data = (commands.Length > 1 ? commands[1] : null);
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
