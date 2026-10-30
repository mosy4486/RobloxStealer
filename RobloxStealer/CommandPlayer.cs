using System;
using System.Collections.Generic;
using System.Text;

namespace RobloxStealer
{
    public class CommandPlayer
    {
        public static void CommandList()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CommandList");
            foreach (var value in Enum.GetValues(typeof(InputType))) sb.AppendLine(value.ToString());

            Console.WriteLine(sb.ToString());
        }

        public static void PlayerInfo()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Player Info");
            sb.AppendLine($"UserName: ");
            sb.AppendLine($"DisplayName: ");
            sb.AppendLine($"Id: ");

            Console.WriteLine(sb.ToString());
        }
    }
}
