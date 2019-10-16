using System;
using System.Collections.Generic;
using System.Text;

namespace Tools
{
    public class FunsMap16
    {
        public unsafe static int[] Funs(byte[] arr)
        {
            FFFP[] func = new FFFP[16];
            func[0] = FP_000;
            func[1] = FP_001;
            func[2] = FP_002;
            func[3] = FP_003;
            func[4] = FP_004;
            func[5] = FP_005;
            func[6] = FP_006;
            func[7] = FP_007;
            func[8] = FP_008;
            func[9] = FP_009;
            func[10] = FP_010;
            func[11] = FP_011;
            func[12] = FP_012;
            func[13] = FP_013;
            func[14] = FP_014;
            func[15] = FP_015;

            int[] rs = new int[256];
            int* rss = stackalloc int[rs.Length];
            fixed (byte* pd = &arr[0])
            {
                byte* ap0 = pd;
                const int bsize = 8;
                int length = arr.Length;
                int blockCount = length / bsize;
                int i = 0;
                for (; i < blockCount * bsize; i += bsize)
                {
                    //func[*(ap0 + 0)](rss);
                    //func[*(ap0 + 1)](rss);
                    //func[*(ap0 + 2)](rss);
                    //func[*(ap0 + 3)](rss);
                    //func[*(ap0 + 4)](rss);
                    //func[*(ap0 + 5)](rss);
                    //func[*(ap0 + 6)](rss);
                    //func[*(ap0 + 7)](rss);
                    func[*(ap0 + 0) & 0x0F](rss);
                    func[*(ap0 + 1) & 0x0F](rss);
                    func[*(ap0 + 2) & 0x0F](rss);
                    func[*(ap0 + 3) & 0x0F](rss);
                    func[*(ap0 + 4) & 0x0F](rss);
                    func[*(ap0 + 5) & 0x0F](rss);
                    func[*(ap0 + 6) & 0x0F](rss);
                    func[*(ap0 + 7) & 0x0F](rss);
                    ap0 += 8;
                }
            }
            for (int i = 0; i < rs.Length; i++)
                rs[i] += rss[i];
            return rs;
        }

        unsafe delegate void FFFP(int* rs);

        public unsafe static void FP_000(int* rs)
        {
            rs[0]++;
        }
        public unsafe static void FP_001(int* rs)
        {
            rs[1]++;
        }
        public unsafe static void FP_002(int* rs)
        {
            rs[2]++;
        }
        public unsafe static void FP_003(int* rs)
        {
            rs[3]++;
        }
        public unsafe static void FP_004(int* rs)
        {
            rs[4]++;
        }
        public unsafe static void FP_005(int* rs)
        {
            rs[5]++;
        }
        public unsafe static void FP_006(int* rs)
        {
            rs[6]++;
        }
        public unsafe static void FP_007(int* rs)
        {
            rs[7]++;
        }
        public unsafe static void FP_008(int* rs)
        {
            rs[8]++;
        }
        public unsafe static void FP_009(int* rs)
        {
            rs[9]++;
        }
        public unsafe static void FP_010(int* rs)
        {
            rs[10]++;
        }
        public unsafe static void FP_011(int* rs)
        {
            rs[11]++;
        }
        public unsafe static void FP_012(int* rs)
        {
            rs[12]++;
        }
        public unsafe static void FP_013(int* rs)
        {
            rs[13]++;
        }
        public unsafe static void FP_014(int* rs)
        {
            rs[14]++;
        }
        public unsafe static void FP_015(int* rs)
        {
            rs[15]++;
        }
    }
}
