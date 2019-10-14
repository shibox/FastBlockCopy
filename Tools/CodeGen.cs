using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Tools
{
    public class CodeGen
    {
        public static void Create()
        {
            File.WriteAllText("CreateSwitchCode.cs", CreateSwitchCode());
        }

        public static string CreateSwitchCode()
        {
            StringBuilder sb = new StringBuilder();
            //for (int i = 0; i < 256; i++)
            //{
            //    sb.AppendLine(string.Format("int i_{0} = 0;", i));
            //}
            sb.AppendLine("switch (*bs)");
            sb.AppendLine("{");
            for (int i = 0; i < 256; i++)
            {
                sb.AppendLine(string.Format("case {0}:", i));
                sb.AppendLine("{");
                sb.AppendLine(string.Format("n++;", i));
                sb.AppendLine("break;");
                sb.AppendLine("}");
            }
            sb.AppendLine("default:");
            sb.AppendLine("break;");
            sb.AppendLine("}");
            return sb.ToString();
        }


    }
}
