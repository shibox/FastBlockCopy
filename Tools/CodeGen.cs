//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Tools
//{
//    public class CodeGen
//    {
//        public static void Create()
//        { 
        
//        }

//        public static string CreateFastDecodeNew()
//        {
//            int l1 = 0, l2 = 0, l3 = 0, l4 = 0;
//            StringBuilder sb = new StringBuilder();
//            for (int i = 0; i < 256; i++)
//            {
//                sb.AppendLine(string.Format("case {0}:", i));
//            }
//            sb.AppendLine("switch (*bs)");
//            sb.AppendLine("{");
//            for (int i = 0; i < 256; i++)
//            {
//                sb.AppendLine(string.Format("case {0}:", i));
//                sb.AppendLine("{");
//                //SizeofDecode(sb, i, ref l1, ref l2, ref l3, ref l4);

//                sb.AppendLine("break;");
//                sb.AppendLine("}");
//            }
//            sb.AppendLine("default:");
//            sb.AppendLine("break;");
//            sb.AppendLine("}");
//            return sb.ToString();
//        }


//    }
//}
