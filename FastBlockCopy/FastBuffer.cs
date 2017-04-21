using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FastBlockCopy
{
    /// <summary>
    /// 高性能的数据拷贝对象
    /// </summary>
    public static partial class FastBuffer
    {
        /// <summary>
        /// Copy is optimized for small data,such as 16 bytes. 
        /// This method is optimized at the IL level to be extremely efficient for copies smaller than
        /// 4096 bytes or heterogeneous workloads with occasional big copies.
        /// 
        /// 该方法针对特别小的数据拷贝进行了优化，如16字节
        /// 原则上，该方法特别适合拷贝4096字节以下的数据。
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        /// <param name="count"></param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void UnsafeBlockCopy(byte* src, byte* dst, int count)
        {
            SMALLTABLE:
            switch (count)
            {
                case 16:
                    *(long*)dst = *(long*)src;
                    *(long*)(dst + 8) = *(long*)(src + 8);
                    return;
                case 15:
                    *(short*)(dst + 12) = *(short*)(src + 12);
                    *(dst + 14) = *(src + 14);
                    goto case 12;
                case 14:
                    *(short*)(dst + 12) = *(short*)(src + 12);
                    goto case 12;
                case 13:
                    *(dst + 12) = *(src + 12);
                    goto case 12;
                case 12:
                    *(long*)dst = *(long*)src;
                    *(int*)(dst + 8) = *(int*)(src + 8);
                    return;
                case 11:
                    *(short*)(dst + 8) = *(short*)(src + 8);
                    *(dst + 10) = *(src + 10);
                    goto case 8;
                case 10:
                    *(short*)(dst + 8) = *(short*)(src + 8);
                    goto case 8;
                case 9:
                    *(dst + 8) = *(src + 8);
                    goto case 8;
                case 8:
                    *(long*)dst = *(long*)src;
                    return;
                case 7:
                    *(short*)(dst + 4) = *(short*)(src + 4);
                    *(dst + 6) = *(src + 6);
                    goto case 4;
                case 6:
                    *(short*)(dst + 4) = *(short*)(src + 4);
                    goto case 4;
                case 5:
                    *(dst + 4) = *(src + 4);
                    goto case 4;
                case 4:
                    *(int*)dst = *(int*)src;
                    return;
                case 3:
                    *(dst + 2) = *(src + 2);
                    goto case 2;
                case 2:
                    *(short*)dst = *(short*)src;
                    return;
                case 1:
                    *dst = *src;
                    return;
                case 0:
                    return;
                default:
                    break;
            }

            long* lpSrc = (long*)src;
            long* ldSrc = (long*)dst;
            while (count >= 64)
            {
                *(ldSrc + 0) = *(lpSrc + 0);
                *(ldSrc + 1) = *(lpSrc + 1);
                *(ldSrc + 2) = *(lpSrc + 2);
                *(ldSrc + 3) = *(lpSrc + 3);
                *(ldSrc + 4) = *(lpSrc + 4);
                *(ldSrc + 5) = *(lpSrc + 5);
                *(ldSrc + 6) = *(lpSrc + 6);
                *(ldSrc + 7) = *(lpSrc + 7);
                if (count == 64)
                    return;
                count -= 64;
                lpSrc += 8;
                ldSrc += 8;
            }
            if (count > 32)
            {
                *(ldSrc + 0) = *(lpSrc + 0);
                *(ldSrc + 1) = *(lpSrc + 1);
                *(ldSrc + 2) = *(lpSrc + 2);
                *(ldSrc + 3) = *(lpSrc + 3);
                count -= 32;
                lpSrc += 4;
                ldSrc += 4;
            }
            if (count > 16)
            {
                *(ldSrc + 0) = *(lpSrc + 0);
                *(ldSrc + 1) = *(lpSrc + 1);
                count -= 16;
                lpSrc += 2;
                ldSrc += 2;
            }
            src = (byte*)lpSrc;
            dst = (byte*)ldSrc;
            goto SMALLTABLE;
        }

    }
}
