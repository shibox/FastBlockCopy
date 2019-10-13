using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace FastBlockCopy
{
    public static partial class FastBuffer
    {
        public static void VectorizedCopy(byte[] src, byte[] dst, int count)
        {
            VectorCopy(src, 0, dst, 0, count);
        }

        #region old

        private static readonly int _vectorSpan = Vector<byte>.Count;
        private static readonly int _vectorSpan2 = Vector<byte>.Count + Vector<byte>.Count;
        private static readonly int _vectorSpan3 = Vector<byte>.Count + Vector<byte>.Count + Vector<byte>.Count;
        private static readonly int _vectorSpan4 = Vector<byte>.Count + Vector<byte>.Count + Vector<byte>.Count + Vector<byte>.Count;

        public unsafe static void VectorCopy(byte[] src, int srcOffset, byte[] dst, int dstOffset, int count)
        {
            while (count >= _vectorSpan)
            {
                new Vector<byte>(src, srcOffset).CopyTo(dst, dstOffset);
                srcOffset += _vectorSpan;
                dstOffset += _vectorSpan;
                count -= _vectorSpan;
            }

            if (count > 0)
            {
                fixed (byte* srcOrigin = src)
                fixed (byte* dstOrigin = dst)
                {
                    var pSrc = srcOrigin + srcOffset;
                    var dSrc = dstOrigin + dstOffset;
                    while (count >= 4)
                    {
                        *dSrc = *pSrc;
                        *(dSrc + 1) = *(pSrc + 1);
                        *(dSrc + 2) = *(pSrc + 2);
                        *(dSrc + 3) = *(pSrc + 3);
                        pSrc += 4;
                        dSrc += 4;
                        count -= 4;
                    }
                    while (count > 0)
                    {
                        *(dSrc++) = *(pSrc++);
                        count--;
                    }
                }
            }
        }

        //public unsafe static void VectorCopyUnrolled2(byte[] src, int srcOffset, byte[] dst, int dstOffset, int count)
        //{
        //    while (count >= _vectorSpan2)
        //    {
        //        new Vector<byte>(src, srcOffset).CopyTo(dst, dstOffset);
        //        new Vector<byte>(src, srcOffset + _vectorSpan).CopyTo(dst, dstOffset + _vectorSpan);
        //        srcOffset += _vectorSpan2;
        //        dstOffset += _vectorSpan2;
        //        count -= _vectorSpan2;
        //    }

        //    if (count >= _vectorSpan)
        //    {
        //        new Vector<byte>(src, srcOffset).CopyTo(dst, dstOffset);
        //        srcOffset += _vectorSpan;
        //        dstOffset += _vectorSpan;
        //        count -= _vectorSpan;
        //    }

        //    if (count > 0)
        //    {
        //        fixed (byte* srcOrigin = src)
        //        fixed (byte* dstOrigin = dst)
        //        {
        //            var pSrc = srcOrigin + srcOffset;
        //            var dSrc = dstOrigin + dstOffset;
        //            while (count >= 4)
        //            {
        //                *dSrc = *pSrc;
        //                *(dSrc + 1) = *(pSrc + 1);
        //                *(dSrc + 2) = *(pSrc + 2);
        //                *(dSrc + 3) = *(pSrc + 3);
        //                pSrc += 4;
        //                dSrc += 4;
        //                count -= 4;
        //            }
        //            while (count > 0)
        //            {
        //                *(dSrc++) = *(pSrc++);
        //                count--;
        //            }
        //        }
        //    }
        //}

        //public unsafe static void VectorCopyUnrolled4(byte[] src, int srcOffset, byte[] dst, int dstOffset, int count)
        //{
        //    while (count >= _vectorSpan4)
        //    {
        //        new Vector<byte>(src, srcOffset).CopyTo(dst, dstOffset);
        //        new Vector<byte>(src, srcOffset + _vectorSpan).CopyTo(dst, dstOffset + _vectorSpan);
        //        new Vector<byte>(src, srcOffset + _vectorSpan2).CopyTo(dst, dstOffset + _vectorSpan2);
        //        new Vector<byte>(src, srcOffset + _vectorSpan3).CopyTo(dst, dstOffset + _vectorSpan3);
        //        srcOffset += _vectorSpan4;
        //        dstOffset += _vectorSpan4;
        //        count -= _vectorSpan4;
        //    }

        //    while (count >= _vectorSpan)
        //    {
        //        new Vector<byte>(src, srcOffset).CopyTo(dst, dstOffset);
        //        srcOffset += _vectorSpan;
        //        dstOffset += _vectorSpan;
        //        count -= _vectorSpan;
        //    }

        //    if (count > 0)
        //    {
        //        fixed (byte* srcOrigin = src)
        //        fixed (byte* dstOrigin = dst)
        //        {
        //            var pSrc = srcOrigin + srcOffset;
        //            var dSrc = dstOrigin + dstOffset;
        //            while (count >= 4)
        //            {
        //                *dSrc = *pSrc;
        //                *(dSrc + 1) = *(pSrc + 1);
        //                *(dSrc + 2) = *(pSrc + 2);
        //                *(dSrc + 3) = *(pSrc + 3);
        //                pSrc += 4;
        //                dSrc += 4;
        //                count -= 4;
        //            }
        //            while (count > 0)
        //            {
        //                *(dSrc++) = *(pSrc++);
        //                count--;
        //            }
        //        }
        //    }
        //}

        #endregion

    }
}
