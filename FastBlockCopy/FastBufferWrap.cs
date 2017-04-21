// Create By Shibox 


using System.Runtime.InteropServices;
using System;

namespace FastBlockCopy
{
    public static partial class FastBuffer
    {

			
			public unsafe static void UnsafeBlockCopy(this Byte[] src, int srcOffset, Byte[] dst, int dstOffset, int count)
			{
				fixed (Byte* srcOrigin = &src[srcOffset])
				fixed (Byte* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this Byte[] src, int srcOffset, SByte[] dst, int dstOffset, int count)
			{
				fixed (Byte* srcOrigin = &src[srcOffset])
				fixed (SByte* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this Byte[] src, int srcOffset, UInt16[] dst, int dstOffset, int count)
			{
				fixed (Byte* srcOrigin = &src[srcOffset])
				fixed (UInt16* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this Byte[] src, int srcOffset, Int16[] dst, int dstOffset, int count)
			{
				fixed (Byte* srcOrigin = &src[srcOffset])
				fixed (Int16* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this Byte[] src, int srcOffset, UInt32[] dst, int dstOffset, int count)
			{
				fixed (Byte* srcOrigin = &src[srcOffset])
				fixed (UInt32* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this Byte[] src, int srcOffset, Int32[] dst, int dstOffset, int count)
			{
				fixed (Byte* srcOrigin = &src[srcOffset])
				fixed (Int32* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this Byte[] src, int srcOffset, UInt64[] dst, int dstOffset, int count)
			{
				fixed (Byte* srcOrigin = &src[srcOffset])
				fixed (UInt64* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this Byte[] src, int srcOffset, Int64[] dst, int dstOffset, int count)
			{
				fixed (Byte* srcOrigin = &src[srcOffset])
				fixed (Int64* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this Byte[] src, int srcOffset, Single[] dst, int dstOffset, int count)
			{
				fixed (Byte* srcOrigin = &src[srcOffset])
				fixed (Single* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this Byte[] src, int srcOffset, Double[] dst, int dstOffset, int count)
			{
				fixed (Byte* srcOrigin = &src[srcOffset])
				fixed (Double* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this SByte[] src, int srcOffset, Byte[] dst, int dstOffset, int count)
			{
				fixed (SByte* srcOrigin = &src[srcOffset])
				fixed (Byte* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this SByte[] src, int srcOffset, SByte[] dst, int dstOffset, int count)
			{
				fixed (SByte* srcOrigin = &src[srcOffset])
				fixed (SByte* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this SByte[] src, int srcOffset, UInt16[] dst, int dstOffset, int count)
			{
				fixed (SByte* srcOrigin = &src[srcOffset])
				fixed (UInt16* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this SByte[] src, int srcOffset, Int16[] dst, int dstOffset, int count)
			{
				fixed (SByte* srcOrigin = &src[srcOffset])
				fixed (Int16* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this SByte[] src, int srcOffset, UInt32[] dst, int dstOffset, int count)
			{
				fixed (SByte* srcOrigin = &src[srcOffset])
				fixed (UInt32* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this SByte[] src, int srcOffset, Int32[] dst, int dstOffset, int count)
			{
				fixed (SByte* srcOrigin = &src[srcOffset])
				fixed (Int32* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this SByte[] src, int srcOffset, UInt64[] dst, int dstOffset, int count)
			{
				fixed (SByte* srcOrigin = &src[srcOffset])
				fixed (UInt64* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this SByte[] src, int srcOffset, Int64[] dst, int dstOffset, int count)
			{
				fixed (SByte* srcOrigin = &src[srcOffset])
				fixed (Int64* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this SByte[] src, int srcOffset, Single[] dst, int dstOffset, int count)
			{
				fixed (SByte* srcOrigin = &src[srcOffset])
				fixed (Single* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this SByte[] src, int srcOffset, Double[] dst, int dstOffset, int count)
			{
				fixed (SByte* srcOrigin = &src[srcOffset])
				fixed (Double* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this UInt16[] src, int srcOffset, Byte[] dst, int dstOffset, int count)
			{
				fixed (UInt16* srcOrigin = &src[srcOffset])
				fixed (Byte* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this UInt16[] src, int srcOffset, SByte[] dst, int dstOffset, int count)
			{
				fixed (UInt16* srcOrigin = &src[srcOffset])
				fixed (SByte* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this UInt16[] src, int srcOffset, UInt16[] dst, int dstOffset, int count)
			{
				fixed (UInt16* srcOrigin = &src[srcOffset])
				fixed (UInt16* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this UInt16[] src, int srcOffset, Int16[] dst, int dstOffset, int count)
			{
				fixed (UInt16* srcOrigin = &src[srcOffset])
				fixed (Int16* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this UInt16[] src, int srcOffset, UInt32[] dst, int dstOffset, int count)
			{
				fixed (UInt16* srcOrigin = &src[srcOffset])
				fixed (UInt32* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this UInt16[] src, int srcOffset, Int32[] dst, int dstOffset, int count)
			{
				fixed (UInt16* srcOrigin = &src[srcOffset])
				fixed (Int32* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this UInt16[] src, int srcOffset, UInt64[] dst, int dstOffset, int count)
			{
				fixed (UInt16* srcOrigin = &src[srcOffset])
				fixed (UInt64* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this UInt16[] src, int srcOffset, Int64[] dst, int dstOffset, int count)
			{
				fixed (UInt16* srcOrigin = &src[srcOffset])
				fixed (Int64* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this UInt16[] src, int srcOffset, Single[] dst, int dstOffset, int count)
			{
				fixed (UInt16* srcOrigin = &src[srcOffset])
				fixed (Single* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this UInt16[] src, int srcOffset, Double[] dst, int dstOffset, int count)
			{
				fixed (UInt16* srcOrigin = &src[srcOffset])
				fixed (Double* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this Int16[] src, int srcOffset, Byte[] dst, int dstOffset, int count)
			{
				fixed (Int16* srcOrigin = &src[srcOffset])
				fixed (Byte* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this Int16[] src, int srcOffset, SByte[] dst, int dstOffset, int count)
			{
				fixed (Int16* srcOrigin = &src[srcOffset])
				fixed (SByte* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this Int16[] src, int srcOffset, UInt16[] dst, int dstOffset, int count)
			{
				fixed (Int16* srcOrigin = &src[srcOffset])
				fixed (UInt16* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this Int16[] src, int srcOffset, Int16[] dst, int dstOffset, int count)
			{
				fixed (Int16* srcOrigin = &src[srcOffset])
				fixed (Int16* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this Int16[] src, int srcOffset, UInt32[] dst, int dstOffset, int count)
			{
				fixed (Int16* srcOrigin = &src[srcOffset])
				fixed (UInt32* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this Int16[] src, int srcOffset, Int32[] dst, int dstOffset, int count)
			{
				fixed (Int16* srcOrigin = &src[srcOffset])
				fixed (Int32* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this Int16[] src, int srcOffset, UInt64[] dst, int dstOffset, int count)
			{
				fixed (Int16* srcOrigin = &src[srcOffset])
				fixed (UInt64* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this Int16[] src, int srcOffset, Int64[] dst, int dstOffset, int count)
			{
				fixed (Int16* srcOrigin = &src[srcOffset])
				fixed (Int64* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this Int16[] src, int srcOffset, Single[] dst, int dstOffset, int count)
			{
				fixed (Int16* srcOrigin = &src[srcOffset])
				fixed (Single* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this Int16[] src, int srcOffset, Double[] dst, int dstOffset, int count)
			{
				fixed (Int16* srcOrigin = &src[srcOffset])
				fixed (Double* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this UInt32[] src, int srcOffset, Byte[] dst, int dstOffset, int count)
			{
				fixed (UInt32* srcOrigin = &src[srcOffset])
				fixed (Byte* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this UInt32[] src, int srcOffset, SByte[] dst, int dstOffset, int count)
			{
				fixed (UInt32* srcOrigin = &src[srcOffset])
				fixed (SByte* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this UInt32[] src, int srcOffset, UInt16[] dst, int dstOffset, int count)
			{
				fixed (UInt32* srcOrigin = &src[srcOffset])
				fixed (UInt16* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this UInt32[] src, int srcOffset, Int16[] dst, int dstOffset, int count)
			{
				fixed (UInt32* srcOrigin = &src[srcOffset])
				fixed (Int16* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this UInt32[] src, int srcOffset, UInt32[] dst, int dstOffset, int count)
			{
				fixed (UInt32* srcOrigin = &src[srcOffset])
				fixed (UInt32* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this UInt32[] src, int srcOffset, Int32[] dst, int dstOffset, int count)
			{
				fixed (UInt32* srcOrigin = &src[srcOffset])
				fixed (Int32* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this UInt32[] src, int srcOffset, UInt64[] dst, int dstOffset, int count)
			{
				fixed (UInt32* srcOrigin = &src[srcOffset])
				fixed (UInt64* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this UInt32[] src, int srcOffset, Int64[] dst, int dstOffset, int count)
			{
				fixed (UInt32* srcOrigin = &src[srcOffset])
				fixed (Int64* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this UInt32[] src, int srcOffset, Single[] dst, int dstOffset, int count)
			{
				fixed (UInt32* srcOrigin = &src[srcOffset])
				fixed (Single* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this UInt32[] src, int srcOffset, Double[] dst, int dstOffset, int count)
			{
				fixed (UInt32* srcOrigin = &src[srcOffset])
				fixed (Double* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this Int32[] src, int srcOffset, Byte[] dst, int dstOffset, int count)
			{
				fixed (Int32* srcOrigin = &src[srcOffset])
				fixed (Byte* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this Int32[] src, int srcOffset, SByte[] dst, int dstOffset, int count)
			{
				fixed (Int32* srcOrigin = &src[srcOffset])
				fixed (SByte* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this Int32[] src, int srcOffset, UInt16[] dst, int dstOffset, int count)
			{
				fixed (Int32* srcOrigin = &src[srcOffset])
				fixed (UInt16* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this Int32[] src, int srcOffset, Int16[] dst, int dstOffset, int count)
			{
				fixed (Int32* srcOrigin = &src[srcOffset])
				fixed (Int16* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this Int32[] src, int srcOffset, UInt32[] dst, int dstOffset, int count)
			{
				fixed (Int32* srcOrigin = &src[srcOffset])
				fixed (UInt32* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this Int32[] src, int srcOffset, Int32[] dst, int dstOffset, int count)
			{
				fixed (Int32* srcOrigin = &src[srcOffset])
				fixed (Int32* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this Int32[] src, int srcOffset, UInt64[] dst, int dstOffset, int count)
			{
				fixed (Int32* srcOrigin = &src[srcOffset])
				fixed (UInt64* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this Int32[] src, int srcOffset, Int64[] dst, int dstOffset, int count)
			{
				fixed (Int32* srcOrigin = &src[srcOffset])
				fixed (Int64* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this Int32[] src, int srcOffset, Single[] dst, int dstOffset, int count)
			{
				fixed (Int32* srcOrigin = &src[srcOffset])
				fixed (Single* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this Int32[] src, int srcOffset, Double[] dst, int dstOffset, int count)
			{
				fixed (Int32* srcOrigin = &src[srcOffset])
				fixed (Double* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this UInt64[] src, int srcOffset, Byte[] dst, int dstOffset, int count)
			{
				fixed (UInt64* srcOrigin = &src[srcOffset])
				fixed (Byte* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this UInt64[] src, int srcOffset, SByte[] dst, int dstOffset, int count)
			{
				fixed (UInt64* srcOrigin = &src[srcOffset])
				fixed (SByte* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this UInt64[] src, int srcOffset, UInt16[] dst, int dstOffset, int count)
			{
				fixed (UInt64* srcOrigin = &src[srcOffset])
				fixed (UInt16* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this UInt64[] src, int srcOffset, Int16[] dst, int dstOffset, int count)
			{
				fixed (UInt64* srcOrigin = &src[srcOffset])
				fixed (Int16* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this UInt64[] src, int srcOffset, UInt32[] dst, int dstOffset, int count)
			{
				fixed (UInt64* srcOrigin = &src[srcOffset])
				fixed (UInt32* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this UInt64[] src, int srcOffset, Int32[] dst, int dstOffset, int count)
			{
				fixed (UInt64* srcOrigin = &src[srcOffset])
				fixed (Int32* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this UInt64[] src, int srcOffset, UInt64[] dst, int dstOffset, int count)
			{
				fixed (UInt64* srcOrigin = &src[srcOffset])
				fixed (UInt64* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this UInt64[] src, int srcOffset, Int64[] dst, int dstOffset, int count)
			{
				fixed (UInt64* srcOrigin = &src[srcOffset])
				fixed (Int64* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this UInt64[] src, int srcOffset, Single[] dst, int dstOffset, int count)
			{
				fixed (UInt64* srcOrigin = &src[srcOffset])
				fixed (Single* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this UInt64[] src, int srcOffset, Double[] dst, int dstOffset, int count)
			{
				fixed (UInt64* srcOrigin = &src[srcOffset])
				fixed (Double* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this Int64[] src, int srcOffset, Byte[] dst, int dstOffset, int count)
			{
				fixed (Int64* srcOrigin = &src[srcOffset])
				fixed (Byte* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this Int64[] src, int srcOffset, SByte[] dst, int dstOffset, int count)
			{
				fixed (Int64* srcOrigin = &src[srcOffset])
				fixed (SByte* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this Int64[] src, int srcOffset, UInt16[] dst, int dstOffset, int count)
			{
				fixed (Int64* srcOrigin = &src[srcOffset])
				fixed (UInt16* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this Int64[] src, int srcOffset, Int16[] dst, int dstOffset, int count)
			{
				fixed (Int64* srcOrigin = &src[srcOffset])
				fixed (Int16* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this Int64[] src, int srcOffset, UInt32[] dst, int dstOffset, int count)
			{
				fixed (Int64* srcOrigin = &src[srcOffset])
				fixed (UInt32* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this Int64[] src, int srcOffset, Int32[] dst, int dstOffset, int count)
			{
				fixed (Int64* srcOrigin = &src[srcOffset])
				fixed (Int32* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this Int64[] src, int srcOffset, UInt64[] dst, int dstOffset, int count)
			{
				fixed (Int64* srcOrigin = &src[srcOffset])
				fixed (UInt64* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this Int64[] src, int srcOffset, Int64[] dst, int dstOffset, int count)
			{
				fixed (Int64* srcOrigin = &src[srcOffset])
				fixed (Int64* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this Int64[] src, int srcOffset, Single[] dst, int dstOffset, int count)
			{
				fixed (Int64* srcOrigin = &src[srcOffset])
				fixed (Single* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this Int64[] src, int srcOffset, Double[] dst, int dstOffset, int count)
			{
				fixed (Int64* srcOrigin = &src[srcOffset])
				fixed (Double* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this Single[] src, int srcOffset, Byte[] dst, int dstOffset, int count)
			{
				fixed (Single* srcOrigin = &src[srcOffset])
				fixed (Byte* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this Single[] src, int srcOffset, SByte[] dst, int dstOffset, int count)
			{
				fixed (Single* srcOrigin = &src[srcOffset])
				fixed (SByte* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this Single[] src, int srcOffset, UInt16[] dst, int dstOffset, int count)
			{
				fixed (Single* srcOrigin = &src[srcOffset])
				fixed (UInt16* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this Single[] src, int srcOffset, Int16[] dst, int dstOffset, int count)
			{
				fixed (Single* srcOrigin = &src[srcOffset])
				fixed (Int16* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this Single[] src, int srcOffset, UInt32[] dst, int dstOffset, int count)
			{
				fixed (Single* srcOrigin = &src[srcOffset])
				fixed (UInt32* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this Single[] src, int srcOffset, Int32[] dst, int dstOffset, int count)
			{
				fixed (Single* srcOrigin = &src[srcOffset])
				fixed (Int32* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this Single[] src, int srcOffset, UInt64[] dst, int dstOffset, int count)
			{
				fixed (Single* srcOrigin = &src[srcOffset])
				fixed (UInt64* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this Single[] src, int srcOffset, Int64[] dst, int dstOffset, int count)
			{
				fixed (Single* srcOrigin = &src[srcOffset])
				fixed (Int64* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this Single[] src, int srcOffset, Single[] dst, int dstOffset, int count)
			{
				fixed (Single* srcOrigin = &src[srcOffset])
				fixed (Single* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this Single[] src, int srcOffset, Double[] dst, int dstOffset, int count)
			{
				fixed (Single* srcOrigin = &src[srcOffset])
				fixed (Double* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this Double[] src, int srcOffset, Byte[] dst, int dstOffset, int count)
			{
				fixed (Double* srcOrigin = &src[srcOffset])
				fixed (Byte* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this Double[] src, int srcOffset, SByte[] dst, int dstOffset, int count)
			{
				fixed (Double* srcOrigin = &src[srcOffset])
				fixed (SByte* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this Double[] src, int srcOffset, UInt16[] dst, int dstOffset, int count)
			{
				fixed (Double* srcOrigin = &src[srcOffset])
				fixed (UInt16* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this Double[] src, int srcOffset, Int16[] dst, int dstOffset, int count)
			{
				fixed (Double* srcOrigin = &src[srcOffset])
				fixed (Int16* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this Double[] src, int srcOffset, UInt32[] dst, int dstOffset, int count)
			{
				fixed (Double* srcOrigin = &src[srcOffset])
				fixed (UInt32* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this Double[] src, int srcOffset, Int32[] dst, int dstOffset, int count)
			{
				fixed (Double* srcOrigin = &src[srcOffset])
				fixed (Int32* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this Double[] src, int srcOffset, UInt64[] dst, int dstOffset, int count)
			{
				fixed (Double* srcOrigin = &src[srcOffset])
				fixed (UInt64* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this Double[] src, int srcOffset, Int64[] dst, int dstOffset, int count)
			{
				fixed (Double* srcOrigin = &src[srcOffset])
				fixed (Int64* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this Double[] src, int srcOffset, Single[] dst, int dstOffset, int count)
			{
				fixed (Double* srcOrigin = &src[srcOffset])
				fixed (Single* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this Double[] src, int srcOffset, Double[] dst, int dstOffset, int count)
			{
				fixed (Double* srcOrigin = &src[srcOffset])
				fixed (Double* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
		
		
			public unsafe static void BlockCopy(this Byte[] src, int srcOffset, Byte[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this Byte[] src, int srcOffset, SByte[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this Byte[] src, int srcOffset, UInt16[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this Byte[] src, int srcOffset, Int16[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this Byte[] src, int srcOffset, UInt32[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this Byte[] src, int srcOffset, Int32[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this Byte[] src, int srcOffset, UInt64[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this Byte[] src, int srcOffset, Int64[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this Byte[] src, int srcOffset, Single[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this Byte[] src, int srcOffset, Double[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this SByte[] src, int srcOffset, Byte[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this SByte[] src, int srcOffset, SByte[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this SByte[] src, int srcOffset, UInt16[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this SByte[] src, int srcOffset, Int16[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this SByte[] src, int srcOffset, UInt32[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this SByte[] src, int srcOffset, Int32[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this SByte[] src, int srcOffset, UInt64[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this SByte[] src, int srcOffset, Int64[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this SByte[] src, int srcOffset, Single[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this SByte[] src, int srcOffset, Double[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this UInt16[] src, int srcOffset, Byte[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this UInt16[] src, int srcOffset, SByte[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this UInt16[] src, int srcOffset, UInt16[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this UInt16[] src, int srcOffset, Int16[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this UInt16[] src, int srcOffset, UInt32[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this UInt16[] src, int srcOffset, Int32[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this UInt16[] src, int srcOffset, UInt64[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this UInt16[] src, int srcOffset, Int64[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this UInt16[] src, int srcOffset, Single[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this UInt16[] src, int srcOffset, Double[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this Int16[] src, int srcOffset, Byte[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this Int16[] src, int srcOffset, SByte[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this Int16[] src, int srcOffset, UInt16[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this Int16[] src, int srcOffset, Int16[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this Int16[] src, int srcOffset, UInt32[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this Int16[] src, int srcOffset, Int32[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this Int16[] src, int srcOffset, UInt64[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this Int16[] src, int srcOffset, Int64[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this Int16[] src, int srcOffset, Single[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this Int16[] src, int srcOffset, Double[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this UInt32[] src, int srcOffset, Byte[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this UInt32[] src, int srcOffset, SByte[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this UInt32[] src, int srcOffset, UInt16[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this UInt32[] src, int srcOffset, Int16[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this UInt32[] src, int srcOffset, UInt32[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this UInt32[] src, int srcOffset, Int32[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this UInt32[] src, int srcOffset, UInt64[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this UInt32[] src, int srcOffset, Int64[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this UInt32[] src, int srcOffset, Single[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this UInt32[] src, int srcOffset, Double[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this Int32[] src, int srcOffset, Byte[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this Int32[] src, int srcOffset, SByte[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this Int32[] src, int srcOffset, UInt16[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this Int32[] src, int srcOffset, Int16[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this Int32[] src, int srcOffset, UInt32[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this Int32[] src, int srcOffset, Int32[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this Int32[] src, int srcOffset, UInt64[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this Int32[] src, int srcOffset, Int64[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this Int32[] src, int srcOffset, Single[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this Int32[] src, int srcOffset, Double[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this UInt64[] src, int srcOffset, Byte[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this UInt64[] src, int srcOffset, SByte[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this UInt64[] src, int srcOffset, UInt16[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this UInt64[] src, int srcOffset, Int16[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this UInt64[] src, int srcOffset, UInt32[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this UInt64[] src, int srcOffset, Int32[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this UInt64[] src, int srcOffset, UInt64[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this UInt64[] src, int srcOffset, Int64[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this UInt64[] src, int srcOffset, Single[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this UInt64[] src, int srcOffset, Double[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this Int64[] src, int srcOffset, Byte[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this Int64[] src, int srcOffset, SByte[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this Int64[] src, int srcOffset, UInt16[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this Int64[] src, int srcOffset, Int16[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this Int64[] src, int srcOffset, UInt32[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this Int64[] src, int srcOffset, Int32[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this Int64[] src, int srcOffset, UInt64[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this Int64[] src, int srcOffset, Int64[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this Int64[] src, int srcOffset, Single[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this Int64[] src, int srcOffset, Double[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this Single[] src, int srcOffset, Byte[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this Single[] src, int srcOffset, SByte[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this Single[] src, int srcOffset, UInt16[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this Single[] src, int srcOffset, Int16[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this Single[] src, int srcOffset, UInt32[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this Single[] src, int srcOffset, Int32[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this Single[] src, int srcOffset, UInt64[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this Single[] src, int srcOffset, Int64[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this Single[] src, int srcOffset, Single[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this Single[] src, int srcOffset, Double[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this Double[] src, int srcOffset, Byte[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this Double[] src, int srcOffset, SByte[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this Double[] src, int srcOffset, UInt16[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this Double[] src, int srcOffset, Int16[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this Double[] src, int srcOffset, UInt32[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this Double[] src, int srcOffset, Int32[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this Double[] src, int srcOffset, UInt64[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this Double[] src, int srcOffset, Int64[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this Double[] src, int srcOffset, Single[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this Double[] src, int srcOffset, Double[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
		
    }
}