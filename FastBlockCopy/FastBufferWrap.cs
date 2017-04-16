// Create By Shibox 


using System.Runtime.InteropServices;
using System;

namespace FastBlockCopy
{
    public static partial class FastBuffer
    {

			
			public unsafe static void BlockCopy(this Byte[] src, int srcOffset, Byte[] dst, int dstOffset, int count)
			{
				fixed (Byte* srcOrigin = &src[dstOffset])
				fixed (Byte* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this Byte[] src, int srcOffset, SByte[] dst, int dstOffset, int count)
			{
				fixed (Byte* srcOrigin = &src[dstOffset])
				fixed (SByte* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this Byte[] src, int srcOffset, UInt16[] dst, int dstOffset, int count)
			{
				fixed (Byte* srcOrigin = &src[dstOffset])
				fixed (UInt16* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this Byte[] src, int srcOffset, Int16[] dst, int dstOffset, int count)
			{
				fixed (Byte* srcOrigin = &src[dstOffset])
				fixed (Int16* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this Byte[] src, int srcOffset, UInt32[] dst, int dstOffset, int count)
			{
				fixed (Byte* srcOrigin = &src[dstOffset])
				fixed (UInt32* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this Byte[] src, int srcOffset, Int32[] dst, int dstOffset, int count)
			{
				fixed (Byte* srcOrigin = &src[dstOffset])
				fixed (Int32* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this Byte[] src, int srcOffset, UInt64[] dst, int dstOffset, int count)
			{
				fixed (Byte* srcOrigin = &src[dstOffset])
				fixed (UInt64* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this Byte[] src, int srcOffset, Int64[] dst, int dstOffset, int count)
			{
				fixed (Byte* srcOrigin = &src[dstOffset])
				fixed (Int64* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this Byte[] src, int srcOffset, Single[] dst, int dstOffset, int count)
			{
				fixed (Byte* srcOrigin = &src[dstOffset])
				fixed (Single* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this Byte[] src, int srcOffset, Double[] dst, int dstOffset, int count)
			{
				fixed (Byte* srcOrigin = &src[dstOffset])
				fixed (Double* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this SByte[] src, int srcOffset, Byte[] dst, int dstOffset, int count)
			{
				fixed (SByte* srcOrigin = &src[dstOffset])
				fixed (Byte* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this SByte[] src, int srcOffset, SByte[] dst, int dstOffset, int count)
			{
				fixed (SByte* srcOrigin = &src[dstOffset])
				fixed (SByte* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this SByte[] src, int srcOffset, UInt16[] dst, int dstOffset, int count)
			{
				fixed (SByte* srcOrigin = &src[dstOffset])
				fixed (UInt16* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this SByte[] src, int srcOffset, Int16[] dst, int dstOffset, int count)
			{
				fixed (SByte* srcOrigin = &src[dstOffset])
				fixed (Int16* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this SByte[] src, int srcOffset, UInt32[] dst, int dstOffset, int count)
			{
				fixed (SByte* srcOrigin = &src[dstOffset])
				fixed (UInt32* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this SByte[] src, int srcOffset, Int32[] dst, int dstOffset, int count)
			{
				fixed (SByte* srcOrigin = &src[dstOffset])
				fixed (Int32* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this SByte[] src, int srcOffset, UInt64[] dst, int dstOffset, int count)
			{
				fixed (SByte* srcOrigin = &src[dstOffset])
				fixed (UInt64* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this SByte[] src, int srcOffset, Int64[] dst, int dstOffset, int count)
			{
				fixed (SByte* srcOrigin = &src[dstOffset])
				fixed (Int64* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this SByte[] src, int srcOffset, Single[] dst, int dstOffset, int count)
			{
				fixed (SByte* srcOrigin = &src[dstOffset])
				fixed (Single* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this SByte[] src, int srcOffset, Double[] dst, int dstOffset, int count)
			{
				fixed (SByte* srcOrigin = &src[dstOffset])
				fixed (Double* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this UInt16[] src, int srcOffset, Byte[] dst, int dstOffset, int count)
			{
				fixed (UInt16* srcOrigin = &src[dstOffset])
				fixed (Byte* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this UInt16[] src, int srcOffset, SByte[] dst, int dstOffset, int count)
			{
				fixed (UInt16* srcOrigin = &src[dstOffset])
				fixed (SByte* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this UInt16[] src, int srcOffset, UInt16[] dst, int dstOffset, int count)
			{
				fixed (UInt16* srcOrigin = &src[dstOffset])
				fixed (UInt16* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this UInt16[] src, int srcOffset, Int16[] dst, int dstOffset, int count)
			{
				fixed (UInt16* srcOrigin = &src[dstOffset])
				fixed (Int16* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this UInt16[] src, int srcOffset, UInt32[] dst, int dstOffset, int count)
			{
				fixed (UInt16* srcOrigin = &src[dstOffset])
				fixed (UInt32* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this UInt16[] src, int srcOffset, Int32[] dst, int dstOffset, int count)
			{
				fixed (UInt16* srcOrigin = &src[dstOffset])
				fixed (Int32* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this UInt16[] src, int srcOffset, UInt64[] dst, int dstOffset, int count)
			{
				fixed (UInt16* srcOrigin = &src[dstOffset])
				fixed (UInt64* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this UInt16[] src, int srcOffset, Int64[] dst, int dstOffset, int count)
			{
				fixed (UInt16* srcOrigin = &src[dstOffset])
				fixed (Int64* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this UInt16[] src, int srcOffset, Single[] dst, int dstOffset, int count)
			{
				fixed (UInt16* srcOrigin = &src[dstOffset])
				fixed (Single* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this UInt16[] src, int srcOffset, Double[] dst, int dstOffset, int count)
			{
				fixed (UInt16* srcOrigin = &src[dstOffset])
				fixed (Double* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this Int16[] src, int srcOffset, Byte[] dst, int dstOffset, int count)
			{
				fixed (Int16* srcOrigin = &src[dstOffset])
				fixed (Byte* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this Int16[] src, int srcOffset, SByte[] dst, int dstOffset, int count)
			{
				fixed (Int16* srcOrigin = &src[dstOffset])
				fixed (SByte* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this Int16[] src, int srcOffset, UInt16[] dst, int dstOffset, int count)
			{
				fixed (Int16* srcOrigin = &src[dstOffset])
				fixed (UInt16* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this Int16[] src, int srcOffset, Int16[] dst, int dstOffset, int count)
			{
				fixed (Int16* srcOrigin = &src[dstOffset])
				fixed (Int16* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this Int16[] src, int srcOffset, UInt32[] dst, int dstOffset, int count)
			{
				fixed (Int16* srcOrigin = &src[dstOffset])
				fixed (UInt32* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this Int16[] src, int srcOffset, Int32[] dst, int dstOffset, int count)
			{
				fixed (Int16* srcOrigin = &src[dstOffset])
				fixed (Int32* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this Int16[] src, int srcOffset, UInt64[] dst, int dstOffset, int count)
			{
				fixed (Int16* srcOrigin = &src[dstOffset])
				fixed (UInt64* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this Int16[] src, int srcOffset, Int64[] dst, int dstOffset, int count)
			{
				fixed (Int16* srcOrigin = &src[dstOffset])
				fixed (Int64* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this Int16[] src, int srcOffset, Single[] dst, int dstOffset, int count)
			{
				fixed (Int16* srcOrigin = &src[dstOffset])
				fixed (Single* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this Int16[] src, int srcOffset, Double[] dst, int dstOffset, int count)
			{
				fixed (Int16* srcOrigin = &src[dstOffset])
				fixed (Double* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this UInt32[] src, int srcOffset, Byte[] dst, int dstOffset, int count)
			{
				fixed (UInt32* srcOrigin = &src[dstOffset])
				fixed (Byte* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this UInt32[] src, int srcOffset, SByte[] dst, int dstOffset, int count)
			{
				fixed (UInt32* srcOrigin = &src[dstOffset])
				fixed (SByte* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this UInt32[] src, int srcOffset, UInt16[] dst, int dstOffset, int count)
			{
				fixed (UInt32* srcOrigin = &src[dstOffset])
				fixed (UInt16* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this UInt32[] src, int srcOffset, Int16[] dst, int dstOffset, int count)
			{
				fixed (UInt32* srcOrigin = &src[dstOffset])
				fixed (Int16* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this UInt32[] src, int srcOffset, UInt32[] dst, int dstOffset, int count)
			{
				fixed (UInt32* srcOrigin = &src[dstOffset])
				fixed (UInt32* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this UInt32[] src, int srcOffset, Int32[] dst, int dstOffset, int count)
			{
				fixed (UInt32* srcOrigin = &src[dstOffset])
				fixed (Int32* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this UInt32[] src, int srcOffset, UInt64[] dst, int dstOffset, int count)
			{
				fixed (UInt32* srcOrigin = &src[dstOffset])
				fixed (UInt64* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this UInt32[] src, int srcOffset, Int64[] dst, int dstOffset, int count)
			{
				fixed (UInt32* srcOrigin = &src[dstOffset])
				fixed (Int64* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this UInt32[] src, int srcOffset, Single[] dst, int dstOffset, int count)
			{
				fixed (UInt32* srcOrigin = &src[dstOffset])
				fixed (Single* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this UInt32[] src, int srcOffset, Double[] dst, int dstOffset, int count)
			{
				fixed (UInt32* srcOrigin = &src[dstOffset])
				fixed (Double* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this Int32[] src, int srcOffset, Byte[] dst, int dstOffset, int count)
			{
				fixed (Int32* srcOrigin = &src[dstOffset])
				fixed (Byte* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this Int32[] src, int srcOffset, SByte[] dst, int dstOffset, int count)
			{
				fixed (Int32* srcOrigin = &src[dstOffset])
				fixed (SByte* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this Int32[] src, int srcOffset, UInt16[] dst, int dstOffset, int count)
			{
				fixed (Int32* srcOrigin = &src[dstOffset])
				fixed (UInt16* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this Int32[] src, int srcOffset, Int16[] dst, int dstOffset, int count)
			{
				fixed (Int32* srcOrigin = &src[dstOffset])
				fixed (Int16* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this Int32[] src, int srcOffset, UInt32[] dst, int dstOffset, int count)
			{
				fixed (Int32* srcOrigin = &src[dstOffset])
				fixed (UInt32* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this Int32[] src, int srcOffset, Int32[] dst, int dstOffset, int count)
			{
				fixed (Int32* srcOrigin = &src[dstOffset])
				fixed (Int32* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this Int32[] src, int srcOffset, UInt64[] dst, int dstOffset, int count)
			{
				fixed (Int32* srcOrigin = &src[dstOffset])
				fixed (UInt64* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this Int32[] src, int srcOffset, Int64[] dst, int dstOffset, int count)
			{
				fixed (Int32* srcOrigin = &src[dstOffset])
				fixed (Int64* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this Int32[] src, int srcOffset, Single[] dst, int dstOffset, int count)
			{
				fixed (Int32* srcOrigin = &src[dstOffset])
				fixed (Single* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this Int32[] src, int srcOffset, Double[] dst, int dstOffset, int count)
			{
				fixed (Int32* srcOrigin = &src[dstOffset])
				fixed (Double* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this UInt64[] src, int srcOffset, Byte[] dst, int dstOffset, int count)
			{
				fixed (UInt64* srcOrigin = &src[dstOffset])
				fixed (Byte* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this UInt64[] src, int srcOffset, SByte[] dst, int dstOffset, int count)
			{
				fixed (UInt64* srcOrigin = &src[dstOffset])
				fixed (SByte* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this UInt64[] src, int srcOffset, UInt16[] dst, int dstOffset, int count)
			{
				fixed (UInt64* srcOrigin = &src[dstOffset])
				fixed (UInt16* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this UInt64[] src, int srcOffset, Int16[] dst, int dstOffset, int count)
			{
				fixed (UInt64* srcOrigin = &src[dstOffset])
				fixed (Int16* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this UInt64[] src, int srcOffset, UInt32[] dst, int dstOffset, int count)
			{
				fixed (UInt64* srcOrigin = &src[dstOffset])
				fixed (UInt32* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this UInt64[] src, int srcOffset, Int32[] dst, int dstOffset, int count)
			{
				fixed (UInt64* srcOrigin = &src[dstOffset])
				fixed (Int32* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this UInt64[] src, int srcOffset, UInt64[] dst, int dstOffset, int count)
			{
				fixed (UInt64* srcOrigin = &src[dstOffset])
				fixed (UInt64* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this UInt64[] src, int srcOffset, Int64[] dst, int dstOffset, int count)
			{
				fixed (UInt64* srcOrigin = &src[dstOffset])
				fixed (Int64* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this UInt64[] src, int srcOffset, Single[] dst, int dstOffset, int count)
			{
				fixed (UInt64* srcOrigin = &src[dstOffset])
				fixed (Single* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this UInt64[] src, int srcOffset, Double[] dst, int dstOffset, int count)
			{
				fixed (UInt64* srcOrigin = &src[dstOffset])
				fixed (Double* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this Int64[] src, int srcOffset, Byte[] dst, int dstOffset, int count)
			{
				fixed (Int64* srcOrigin = &src[dstOffset])
				fixed (Byte* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this Int64[] src, int srcOffset, SByte[] dst, int dstOffset, int count)
			{
				fixed (Int64* srcOrigin = &src[dstOffset])
				fixed (SByte* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this Int64[] src, int srcOffset, UInt16[] dst, int dstOffset, int count)
			{
				fixed (Int64* srcOrigin = &src[dstOffset])
				fixed (UInt16* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this Int64[] src, int srcOffset, Int16[] dst, int dstOffset, int count)
			{
				fixed (Int64* srcOrigin = &src[dstOffset])
				fixed (Int16* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this Int64[] src, int srcOffset, UInt32[] dst, int dstOffset, int count)
			{
				fixed (Int64* srcOrigin = &src[dstOffset])
				fixed (UInt32* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this Int64[] src, int srcOffset, Int32[] dst, int dstOffset, int count)
			{
				fixed (Int64* srcOrigin = &src[dstOffset])
				fixed (Int32* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this Int64[] src, int srcOffset, UInt64[] dst, int dstOffset, int count)
			{
				fixed (Int64* srcOrigin = &src[dstOffset])
				fixed (UInt64* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this Int64[] src, int srcOffset, Int64[] dst, int dstOffset, int count)
			{
				fixed (Int64* srcOrigin = &src[dstOffset])
				fixed (Int64* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this Int64[] src, int srcOffset, Single[] dst, int dstOffset, int count)
			{
				fixed (Int64* srcOrigin = &src[dstOffset])
				fixed (Single* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this Int64[] src, int srcOffset, Double[] dst, int dstOffset, int count)
			{
				fixed (Int64* srcOrigin = &src[dstOffset])
				fixed (Double* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this Single[] src, int srcOffset, Byte[] dst, int dstOffset, int count)
			{
				fixed (Single* srcOrigin = &src[dstOffset])
				fixed (Byte* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this Single[] src, int srcOffset, SByte[] dst, int dstOffset, int count)
			{
				fixed (Single* srcOrigin = &src[dstOffset])
				fixed (SByte* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this Single[] src, int srcOffset, UInt16[] dst, int dstOffset, int count)
			{
				fixed (Single* srcOrigin = &src[dstOffset])
				fixed (UInt16* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this Single[] src, int srcOffset, Int16[] dst, int dstOffset, int count)
			{
				fixed (Single* srcOrigin = &src[dstOffset])
				fixed (Int16* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this Single[] src, int srcOffset, UInt32[] dst, int dstOffset, int count)
			{
				fixed (Single* srcOrigin = &src[dstOffset])
				fixed (UInt32* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this Single[] src, int srcOffset, Int32[] dst, int dstOffset, int count)
			{
				fixed (Single* srcOrigin = &src[dstOffset])
				fixed (Int32* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this Single[] src, int srcOffset, UInt64[] dst, int dstOffset, int count)
			{
				fixed (Single* srcOrigin = &src[dstOffset])
				fixed (UInt64* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this Single[] src, int srcOffset, Int64[] dst, int dstOffset, int count)
			{
				fixed (Single* srcOrigin = &src[dstOffset])
				fixed (Int64* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this Single[] src, int srcOffset, Single[] dst, int dstOffset, int count)
			{
				fixed (Single* srcOrigin = &src[dstOffset])
				fixed (Single* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this Single[] src, int srcOffset, Double[] dst, int dstOffset, int count)
			{
				fixed (Single* srcOrigin = &src[dstOffset])
				fixed (Double* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this Double[] src, int srcOffset, Byte[] dst, int dstOffset, int count)
			{
				fixed (Double* srcOrigin = &src[dstOffset])
				fixed (Byte* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this Double[] src, int srcOffset, SByte[] dst, int dstOffset, int count)
			{
				fixed (Double* srcOrigin = &src[dstOffset])
				fixed (SByte* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this Double[] src, int srcOffset, UInt16[] dst, int dstOffset, int count)
			{
				fixed (Double* srcOrigin = &src[dstOffset])
				fixed (UInt16* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this Double[] src, int srcOffset, Int16[] dst, int dstOffset, int count)
			{
				fixed (Double* srcOrigin = &src[dstOffset])
				fixed (Int16* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this Double[] src, int srcOffset, UInt32[] dst, int dstOffset, int count)
			{
				fixed (Double* srcOrigin = &src[dstOffset])
				fixed (UInt32* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this Double[] src, int srcOffset, Int32[] dst, int dstOffset, int count)
			{
				fixed (Double* srcOrigin = &src[dstOffset])
				fixed (Int32* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this Double[] src, int srcOffset, UInt64[] dst, int dstOffset, int count)
			{
				fixed (Double* srcOrigin = &src[dstOffset])
				fixed (UInt64* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this Double[] src, int srcOffset, Int64[] dst, int dstOffset, int count)
			{
				fixed (Double* srcOrigin = &src[dstOffset])
				fixed (Int64* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this Double[] src, int srcOffset, Single[] dst, int dstOffset, int count)
			{
				fixed (Double* srcOrigin = &src[dstOffset])
				fixed (Single* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void BlockCopy(this Double[] src, int srcOffset, Double[] dst, int dstOffset, int count)
			{
				fixed (Double* srcOrigin = &src[dstOffset])
				fixed (Double* dstOrigin = &dst[dstOffset])
				{
					UnsafeByteCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
		
    }
}