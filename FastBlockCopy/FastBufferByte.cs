using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FastBlockCopy
{
    public static partial class FastBuffer
    {
        public unsafe static void BlockCopy(this byte[] src, int srcOffset, int[] dst, int dstOffset, int count)
        {
            if (Vector.IsHardwareAccelerated)
            {
                if (count > 512 + 64)
                {
                    Array.Copy(src, srcOffset, dst, dstOffset, count);
                    return;
                }
                if (src == null) throw new ArgumentNullException(nameof(src));
                if (dst == null) throw new ArgumentNullException(nameof(dst));
                if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
                if (count == 0) return;
                if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
                if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

                while (count >= int8VecSpan4)
                {
                    Vector.AsVectorInt32(new Vector<byte>(src, srcOffset)).CopyTo(dst, dstOffset);
                    Vector.AsVectorInt32(new Vector<byte>(src, srcOffset + int8VecSpan1)).CopyTo(dst, dstOffset + int8VecSpan1);
                    Vector.AsVectorInt32(new Vector<byte>(src, srcOffset + int8VecSpan2)).CopyTo(dst, dstOffset + int8VecSpan2);
                    Vector.AsVectorInt32(new Vector<byte>(src, srcOffset + int8VecSpan3)).CopyTo(dst, dstOffset + int8VecSpan3);
                    if (count == int8VecSpan4) return;
                    count -= int8VecSpan4;
                    srcOffset += int8VecSpan4;
                    dstOffset += int8VecSpan4;
                }
                if (count >= int8VecSpan2)
                {
                    Vector.AsVectorInt32(new Vector<byte>(src, srcOffset)).CopyTo(dst, dstOffset);
                    Vector.AsVectorInt32(new Vector<byte>(src, srcOffset + int8VecSpan1)).CopyTo(dst, dstOffset + int8VecSpan1);
                    if (count == int8VecSpan2) return;
                    count -= int8VecSpan2;
                    srcOffset += int8VecSpan2;
                    dstOffset += int8VecSpan2;
                }
                if (count >= int8VecSpan1)
                {
                    Vector.AsVectorInt32(new Vector<byte>(src, srcOffset)).CopyTo(dst, dstOffset);
                    if (count == int8VecSpan1) return;
                    count -= int8VecSpan1;
                    srcOffset += int8VecSpan1;
                    dstOffset += int8VecSpan1;
                }
                if (count > 0)
                {
                    fixed (byte* srcOrigin = src)
                    fixed (int* dstOrigin = dst)
                    {
                        var pSrc = srcOrigin + srcOffset;
                        var dSrc = dstOrigin + dstOffset;

                        if (count >= int64Span1)
                        {
                            var lpSrc = (long*)pSrc;
                            var ldSrc = (long*)dSrc;

                            if (count < int64Span2)
                            {
                                count -= int64Span1;
                                pSrc += int64Span1;
                                dSrc += int64Span1;
                                *ldSrc = *lpSrc;
                            }
                            else if (count < int64Span3)
                            {
                                count -= int64Span2;
                                pSrc += int64Span2;
                                dSrc += int64Span2;
                                *ldSrc = *lpSrc;
                                *(ldSrc + 1) = *(lpSrc + 1);
                            }
                            else
                            {
                                count -= int64Span3;
                                pSrc += int64Span3;
                                dSrc += int64Span3;
                                *ldSrc = *lpSrc;
                                *(ldSrc + 1) = *(lpSrc + 1);
                                *(ldSrc + 2) = *(lpSrc + 2);
                            }
                        }
                        if (count >= int32Span1)
                        {
                            var ipSrc = (int*)pSrc;
                            var idSrc = (int*)dSrc;
                            count -= int32Span1;
                            pSrc += int32Span1;
                            dSrc += int32Span1;
                            *idSrc = *ipSrc;
                        }
                        while (count > 0)
                        {
                            count--;
                            *dSrc = *pSrc;
                            dSrc += 1;
                            pSrc += 1;
                        }
                    }
                }
            }
            else
            {
                Array.Copy(src, srcOffset, dst, dstOffset, count);
                return;
            }
        }

        public unsafe static void BlockCopyUnCheck(this byte[] src, int srcOffset, int[] dst, int dstOffset, int count)
        {
            if (Vector.IsHardwareAccelerated)
            {
                if (count > 512 + 64)
                {
                    Array.Copy(src, srcOffset, dst, dstOffset, count);
                    return;
                }
                if (src == null) throw new ArgumentNullException(nameof(src));
                if (dst == null) throw new ArgumentNullException(nameof(dst));
                if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
                if (count == 0) return;
                if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
                if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

                while (count >= int8VecSpan4)
                {
                    Vector.AsVectorInt32(new Vector<byte>(src, srcOffset)).CopyTo(dst, dstOffset);
                    Vector.AsVectorInt32(new Vector<byte>(src, srcOffset + int8VecSpan1)).CopyTo(dst, dstOffset + int8VecSpan1);
                    Vector.AsVectorInt32(new Vector<byte>(src, srcOffset + int8VecSpan2)).CopyTo(dst, dstOffset + int8VecSpan2);
                    Vector.AsVectorInt32(new Vector<byte>(src, srcOffset + int8VecSpan3)).CopyTo(dst, dstOffset + int8VecSpan3);
                    if (count == int8VecSpan4) return;
                    count -= int8VecSpan4;
                    srcOffset += int8VecSpan4;
                    dstOffset += int8VecSpan4;
                }
                if (count >= int8VecSpan2)
                {
                    Vector.AsVectorInt32(new Vector<byte>(src, srcOffset)).CopyTo(dst, dstOffset);
                    Vector.AsVectorInt32(new Vector<byte>(src, srcOffset + int8VecSpan1)).CopyTo(dst, dstOffset + int8VecSpan1);
                    if (count == int8VecSpan2) return;
                    count -= int8VecSpan2;
                    srcOffset += int8VecSpan2;
                    dstOffset += int8VecSpan2;
                }
                if (count >= int8VecSpan1)
                {
                    Vector.AsVectorInt32(new Vector<byte>(src, srcOffset)).CopyTo(dst, dstOffset);
                    if (count == int8VecSpan1) return;
                    count -= int8VecSpan1;
                    srcOffset += int8VecSpan1;
                    dstOffset += int8VecSpan1;
                }
                if (count > 0)
                {
                    fixed (byte* srcOrigin = src)
                    fixed (int* dstOrigin = dst)
                    {
                        var pSrc = srcOrigin + srcOffset;
                        var dSrc = dstOrigin + dstOffset;

                        if (count >= int64Span1)
                        {
                            var lpSrc = (long*)pSrc;
                            var ldSrc = (long*)dSrc;

                            if (count < int64Span2)
                            {
                                count -= int64Span1;
                                pSrc += int64Span1;
                                dSrc += int64Span1;
                                *ldSrc = *lpSrc;
                            }
                            else if (count < int64Span3)
                            {
                                count -= int64Span2;
                                pSrc += int64Span2;
                                dSrc += int64Span2;
                                *ldSrc = *lpSrc;
                                *(ldSrc + 1) = *(lpSrc + 1);
                            }
                            else
                            {
                                count -= int64Span3;
                                pSrc += int64Span3;
                                dSrc += int64Span3;
                                *ldSrc = *lpSrc;
                                *(ldSrc + 1) = *(lpSrc + 1);
                                *(ldSrc + 2) = *(lpSrc + 2);
                            }
                        }
                        if (count >= int32Span1)
                        {
                            var ipSrc = (int*)pSrc;
                            var idSrc = (int*)dSrc;
                            count -= int32Span1;
                            pSrc += int32Span1;
                            dSrc += int32Span1;
                            *idSrc = *ipSrc;
                        }
                        while (count > 0)
                        {
                            count--;
                            *dSrc = *pSrc;
                            dSrc += 1;
                            pSrc += 1;
                        }
                    }
                }
            }
            else
            {
                Array.Copy(src, srcOffset, dst, dstOffset, count);
                return;
            }
        }
    }
}
