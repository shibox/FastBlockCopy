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
            File.WriteAllText("CreateSwitchCode.cs", CreateSwitchCodeMethod());
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

        public static string CreateSwitchCodeMethod()
        {
            StringBuilder sb = new StringBuilder();

            //case 0:
            //            rs[0]++;
            //break;

            for (int i = 0; i < 256; i++)
            {
                if (i == 1)
                    sb.Append("1,");
                if (i == 2)
                    sb.Append("2,");
                if (i == 4)
                    sb.Append("3,");
                if (i == 8)
                    sb.Append("4,");
                if (i == 16)
                    sb.Append("5,");
                if (i == 32)
                    sb.Append("6,");
                if (i == 64)
                    sb.Append("7,");
                if (i == 128)
                    sb.Append("8,");
                else
                    sb.Append("0,");
            }

            for (int i = 0; i < 256; i++)
            {
                string s = Convert.ToString(31, 2);
                sb.AppendLine($"case {i}:");
                sb.AppendLine("{");
                sb.AppendLine($"rs[{i}]++;");
                sb.AppendLine("break;");
                sb.AppendLine("}");
            }
            sb.AppendLine();

            for (int i = 0; i < 256; i++)
            {
                string s = Convert.ToString(31, 2);
                sb.AppendLine(string.Format("case {0}:", i));
                sb.AppendLine("{");
                sb.AppendLine(string.Format("n++;", i));
                sb.AppendLine("break;");
                sb.AppendLine("}");
            }
            sb.AppendLine();

            for (int i = 0; i < 256; i++)
            {
                sb.AppendLine(string.Format($"case Enum256.V_{i.ToString().PadLeft(3, '0')}:", i));
                sb.AppendLine("{");
                sb.AppendLine(string.Format("n++;", i));
                sb.AppendLine("break;");
                sb.AppendLine("}");
            }
            sb.AppendLine();

            for (int i = 0; i < 256; i++)
            {
                sb.AppendLine($"V_{i.ToString().PadLeft(3, '0')} = {i},");
            }
            sb.AppendLine();

            for (int i = 0; i < 256; i++)
            {
                sb.AppendLine($"case {i}:");
                sb.AppendLine($"    count++");
            }
            sb.AppendLine();

            for (int i = 0; i < 256; i++)
            {
                sb.AppendLine($"func[{i}] = FP_{i.ToString().PadLeft( 3, '0')};");
            }
            sb.AppendLine();

            for (int i = 0; i < 256; i++)
            {
                sb.AppendLine($"public unsafe static void FP_{i.ToString().PadLeft(3,'0')}(int* rs)");
                sb.AppendLine("{");
                sb.AppendLine(string.Format("rs[{0}]++;", i));
                sb.AppendLine("}");
            }
            sb.AppendLine();

            return sb.ToString();
        }


    }
}
