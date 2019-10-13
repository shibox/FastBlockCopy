// Create By Shibox 


using System.Runtime.InteropServices;
using System;

namespace FastBlockCopy
{
    public static partial class FastBuffer
    {

			
			public unsafe static void UnsafeBlockCopy(this byte[] src, int srcOffset, byte[] dst, int dstOffset, int count)
			{
				fixed (byte* srcOrigin = &src[srcOffset])
				fixed (byte* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this byte[] src, int srcOffset, sbyte[] dst, int dstOffset, int count)
			{
				fixed (byte* srcOrigin = &src[srcOffset])
				fixed (sbyte* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this byte[] src, int srcOffset, ushort[] dst, int dstOffset, int count)
			{
				fixed (byte* srcOrigin = &src[srcOffset])
				fixed (ushort* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this byte[] src, int srcOffset, short[] dst, int dstOffset, int count)
			{
				fixed (byte* srcOrigin = &src[srcOffset])
				fixed (short* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this byte[] src, int srcOffset, uint[] dst, int dstOffset, int count)
			{
				fixed (byte* srcOrigin = &src[srcOffset])
				fixed (uint* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this byte[] src, int srcOffset, int[] dst, int dstOffset, int count)
			{
				fixed (byte* srcOrigin = &src[srcOffset])
				fixed (int* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this byte[] src, int srcOffset, ulong[] dst, int dstOffset, int count)
			{
				fixed (byte* srcOrigin = &src[srcOffset])
				fixed (ulong* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this byte[] src, int srcOffset, long[] dst, int dstOffset, int count)
			{
				fixed (byte* srcOrigin = &src[srcOffset])
				fixed (long* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this byte[] src, int srcOffset, float[] dst, int dstOffset, int count)
			{
				fixed (byte* srcOrigin = &src[srcOffset])
				fixed (float* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this byte[] src, int srcOffset, double[] dst, int dstOffset, int count)
			{
				fixed (byte* srcOrigin = &src[srcOffset])
				fixed (double* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this sbyte[] src, int srcOffset, byte[] dst, int dstOffset, int count)
			{
				fixed (sbyte* srcOrigin = &src[srcOffset])
				fixed (byte* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this sbyte[] src, int srcOffset, sbyte[] dst, int dstOffset, int count)
			{
				fixed (sbyte* srcOrigin = &src[srcOffset])
				fixed (sbyte* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this sbyte[] src, int srcOffset, ushort[] dst, int dstOffset, int count)
			{
				fixed (sbyte* srcOrigin = &src[srcOffset])
				fixed (ushort* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this sbyte[] src, int srcOffset, short[] dst, int dstOffset, int count)
			{
				fixed (sbyte* srcOrigin = &src[srcOffset])
				fixed (short* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this sbyte[] src, int srcOffset, uint[] dst, int dstOffset, int count)
			{
				fixed (sbyte* srcOrigin = &src[srcOffset])
				fixed (uint* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this sbyte[] src, int srcOffset, int[] dst, int dstOffset, int count)
			{
				fixed (sbyte* srcOrigin = &src[srcOffset])
				fixed (int* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this sbyte[] src, int srcOffset, ulong[] dst, int dstOffset, int count)
			{
				fixed (sbyte* srcOrigin = &src[srcOffset])
				fixed (ulong* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this sbyte[] src, int srcOffset, long[] dst, int dstOffset, int count)
			{
				fixed (sbyte* srcOrigin = &src[srcOffset])
				fixed (long* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this sbyte[] src, int srcOffset, float[] dst, int dstOffset, int count)
			{
				fixed (sbyte* srcOrigin = &src[srcOffset])
				fixed (float* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this sbyte[] src, int srcOffset, double[] dst, int dstOffset, int count)
			{
				fixed (sbyte* srcOrigin = &src[srcOffset])
				fixed (double* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this ushort[] src, int srcOffset, byte[] dst, int dstOffset, int count)
			{
				fixed (ushort* srcOrigin = &src[srcOffset])
				fixed (byte* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this ushort[] src, int srcOffset, sbyte[] dst, int dstOffset, int count)
			{
				fixed (ushort* srcOrigin = &src[srcOffset])
				fixed (sbyte* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this ushort[] src, int srcOffset, ushort[] dst, int dstOffset, int count)
			{
				fixed (ushort* srcOrigin = &src[srcOffset])
				fixed (ushort* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this ushort[] src, int srcOffset, short[] dst, int dstOffset, int count)
			{
				fixed (ushort* srcOrigin = &src[srcOffset])
				fixed (short* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this ushort[] src, int srcOffset, uint[] dst, int dstOffset, int count)
			{
				fixed (ushort* srcOrigin = &src[srcOffset])
				fixed (uint* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this ushort[] src, int srcOffset, int[] dst, int dstOffset, int count)
			{
				fixed (ushort* srcOrigin = &src[srcOffset])
				fixed (int* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this ushort[] src, int srcOffset, ulong[] dst, int dstOffset, int count)
			{
				fixed (ushort* srcOrigin = &src[srcOffset])
				fixed (ulong* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this ushort[] src, int srcOffset, long[] dst, int dstOffset, int count)
			{
				fixed (ushort* srcOrigin = &src[srcOffset])
				fixed (long* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this ushort[] src, int srcOffset, float[] dst, int dstOffset, int count)
			{
				fixed (ushort* srcOrigin = &src[srcOffset])
				fixed (float* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this ushort[] src, int srcOffset, double[] dst, int dstOffset, int count)
			{
				fixed (ushort* srcOrigin = &src[srcOffset])
				fixed (double* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this short[] src, int srcOffset, byte[] dst, int dstOffset, int count)
			{
				fixed (short* srcOrigin = &src[srcOffset])
				fixed (byte* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this short[] src, int srcOffset, sbyte[] dst, int dstOffset, int count)
			{
				fixed (short* srcOrigin = &src[srcOffset])
				fixed (sbyte* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this short[] src, int srcOffset, ushort[] dst, int dstOffset, int count)
			{
				fixed (short* srcOrigin = &src[srcOffset])
				fixed (ushort* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this short[] src, int srcOffset, short[] dst, int dstOffset, int count)
			{
				fixed (short* srcOrigin = &src[srcOffset])
				fixed (short* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this short[] src, int srcOffset, uint[] dst, int dstOffset, int count)
			{
				fixed (short* srcOrigin = &src[srcOffset])
				fixed (uint* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this short[] src, int srcOffset, int[] dst, int dstOffset, int count)
			{
				fixed (short* srcOrigin = &src[srcOffset])
				fixed (int* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this short[] src, int srcOffset, ulong[] dst, int dstOffset, int count)
			{
				fixed (short* srcOrigin = &src[srcOffset])
				fixed (ulong* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this short[] src, int srcOffset, long[] dst, int dstOffset, int count)
			{
				fixed (short* srcOrigin = &src[srcOffset])
				fixed (long* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this short[] src, int srcOffset, float[] dst, int dstOffset, int count)
			{
				fixed (short* srcOrigin = &src[srcOffset])
				fixed (float* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this short[] src, int srcOffset, double[] dst, int dstOffset, int count)
			{
				fixed (short* srcOrigin = &src[srcOffset])
				fixed (double* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this uint[] src, int srcOffset, byte[] dst, int dstOffset, int count)
			{
				fixed (uint* srcOrigin = &src[srcOffset])
				fixed (byte* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this uint[] src, int srcOffset, sbyte[] dst, int dstOffset, int count)
			{
				fixed (uint* srcOrigin = &src[srcOffset])
				fixed (sbyte* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this uint[] src, int srcOffset, ushort[] dst, int dstOffset, int count)
			{
				fixed (uint* srcOrigin = &src[srcOffset])
				fixed (ushort* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this uint[] src, int srcOffset, short[] dst, int dstOffset, int count)
			{
				fixed (uint* srcOrigin = &src[srcOffset])
				fixed (short* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this uint[] src, int srcOffset, uint[] dst, int dstOffset, int count)
			{
				fixed (uint* srcOrigin = &src[srcOffset])
				fixed (uint* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this uint[] src, int srcOffset, int[] dst, int dstOffset, int count)
			{
				fixed (uint* srcOrigin = &src[srcOffset])
				fixed (int* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this uint[] src, int srcOffset, ulong[] dst, int dstOffset, int count)
			{
				fixed (uint* srcOrigin = &src[srcOffset])
				fixed (ulong* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this uint[] src, int srcOffset, long[] dst, int dstOffset, int count)
			{
				fixed (uint* srcOrigin = &src[srcOffset])
				fixed (long* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this uint[] src, int srcOffset, float[] dst, int dstOffset, int count)
			{
				fixed (uint* srcOrigin = &src[srcOffset])
				fixed (float* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this uint[] src, int srcOffset, double[] dst, int dstOffset, int count)
			{
				fixed (uint* srcOrigin = &src[srcOffset])
				fixed (double* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this int[] src, int srcOffset, byte[] dst, int dstOffset, int count)
			{
				fixed (int* srcOrigin = &src[srcOffset])
				fixed (byte* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this int[] src, int srcOffset, sbyte[] dst, int dstOffset, int count)
			{
				fixed (int* srcOrigin = &src[srcOffset])
				fixed (sbyte* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this int[] src, int srcOffset, ushort[] dst, int dstOffset, int count)
			{
				fixed (int* srcOrigin = &src[srcOffset])
				fixed (ushort* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this int[] src, int srcOffset, short[] dst, int dstOffset, int count)
			{
				fixed (int* srcOrigin = &src[srcOffset])
				fixed (short* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this int[] src, int srcOffset, uint[] dst, int dstOffset, int count)
			{
				fixed (int* srcOrigin = &src[srcOffset])
				fixed (uint* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this int[] src, int srcOffset, int[] dst, int dstOffset, int count)
			{
				fixed (int* srcOrigin = &src[srcOffset])
				fixed (int* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this int[] src, int srcOffset, ulong[] dst, int dstOffset, int count)
			{
				fixed (int* srcOrigin = &src[srcOffset])
				fixed (ulong* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this int[] src, int srcOffset, long[] dst, int dstOffset, int count)
			{
				fixed (int* srcOrigin = &src[srcOffset])
				fixed (long* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this int[] src, int srcOffset, float[] dst, int dstOffset, int count)
			{
				fixed (int* srcOrigin = &src[srcOffset])
				fixed (float* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this int[] src, int srcOffset, double[] dst, int dstOffset, int count)
			{
				fixed (int* srcOrigin = &src[srcOffset])
				fixed (double* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this ulong[] src, int srcOffset, byte[] dst, int dstOffset, int count)
			{
				fixed (ulong* srcOrigin = &src[srcOffset])
				fixed (byte* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this ulong[] src, int srcOffset, sbyte[] dst, int dstOffset, int count)
			{
				fixed (ulong* srcOrigin = &src[srcOffset])
				fixed (sbyte* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this ulong[] src, int srcOffset, ushort[] dst, int dstOffset, int count)
			{
				fixed (ulong* srcOrigin = &src[srcOffset])
				fixed (ushort* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this ulong[] src, int srcOffset, short[] dst, int dstOffset, int count)
			{
				fixed (ulong* srcOrigin = &src[srcOffset])
				fixed (short* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this ulong[] src, int srcOffset, uint[] dst, int dstOffset, int count)
			{
				fixed (ulong* srcOrigin = &src[srcOffset])
				fixed (uint* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this ulong[] src, int srcOffset, int[] dst, int dstOffset, int count)
			{
				fixed (ulong* srcOrigin = &src[srcOffset])
				fixed (int* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this ulong[] src, int srcOffset, ulong[] dst, int dstOffset, int count)
			{
				fixed (ulong* srcOrigin = &src[srcOffset])
				fixed (ulong* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this ulong[] src, int srcOffset, long[] dst, int dstOffset, int count)
			{
				fixed (ulong* srcOrigin = &src[srcOffset])
				fixed (long* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this ulong[] src, int srcOffset, float[] dst, int dstOffset, int count)
			{
				fixed (ulong* srcOrigin = &src[srcOffset])
				fixed (float* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this ulong[] src, int srcOffset, double[] dst, int dstOffset, int count)
			{
				fixed (ulong* srcOrigin = &src[srcOffset])
				fixed (double* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this long[] src, int srcOffset, byte[] dst, int dstOffset, int count)
			{
				fixed (long* srcOrigin = &src[srcOffset])
				fixed (byte* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this long[] src, int srcOffset, sbyte[] dst, int dstOffset, int count)
			{
				fixed (long* srcOrigin = &src[srcOffset])
				fixed (sbyte* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this long[] src, int srcOffset, ushort[] dst, int dstOffset, int count)
			{
				fixed (long* srcOrigin = &src[srcOffset])
				fixed (ushort* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this long[] src, int srcOffset, short[] dst, int dstOffset, int count)
			{
				fixed (long* srcOrigin = &src[srcOffset])
				fixed (short* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this long[] src, int srcOffset, uint[] dst, int dstOffset, int count)
			{
				fixed (long* srcOrigin = &src[srcOffset])
				fixed (uint* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this long[] src, int srcOffset, int[] dst, int dstOffset, int count)
			{
				fixed (long* srcOrigin = &src[srcOffset])
				fixed (int* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this long[] src, int srcOffset, ulong[] dst, int dstOffset, int count)
			{
				fixed (long* srcOrigin = &src[srcOffset])
				fixed (ulong* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this long[] src, int srcOffset, long[] dst, int dstOffset, int count)
			{
				fixed (long* srcOrigin = &src[srcOffset])
				fixed (long* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this long[] src, int srcOffset, float[] dst, int dstOffset, int count)
			{
				fixed (long* srcOrigin = &src[srcOffset])
				fixed (float* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this long[] src, int srcOffset, double[] dst, int dstOffset, int count)
			{
				fixed (long* srcOrigin = &src[srcOffset])
				fixed (double* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this float[] src, int srcOffset, byte[] dst, int dstOffset, int count)
			{
				fixed (float* srcOrigin = &src[srcOffset])
				fixed (byte* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this float[] src, int srcOffset, sbyte[] dst, int dstOffset, int count)
			{
				fixed (float* srcOrigin = &src[srcOffset])
				fixed (sbyte* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this float[] src, int srcOffset, ushort[] dst, int dstOffset, int count)
			{
				fixed (float* srcOrigin = &src[srcOffset])
				fixed (ushort* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this float[] src, int srcOffset, short[] dst, int dstOffset, int count)
			{
				fixed (float* srcOrigin = &src[srcOffset])
				fixed (short* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this float[] src, int srcOffset, uint[] dst, int dstOffset, int count)
			{
				fixed (float* srcOrigin = &src[srcOffset])
				fixed (uint* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this float[] src, int srcOffset, int[] dst, int dstOffset, int count)
			{
				fixed (float* srcOrigin = &src[srcOffset])
				fixed (int* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this float[] src, int srcOffset, ulong[] dst, int dstOffset, int count)
			{
				fixed (float* srcOrigin = &src[srcOffset])
				fixed (ulong* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this float[] src, int srcOffset, long[] dst, int dstOffset, int count)
			{
				fixed (float* srcOrigin = &src[srcOffset])
				fixed (long* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this float[] src, int srcOffset, float[] dst, int dstOffset, int count)
			{
				fixed (float* srcOrigin = &src[srcOffset])
				fixed (float* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this float[] src, int srcOffset, double[] dst, int dstOffset, int count)
			{
				fixed (float* srcOrigin = &src[srcOffset])
				fixed (double* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this double[] src, int srcOffset, byte[] dst, int dstOffset, int count)
			{
				fixed (double* srcOrigin = &src[srcOffset])
				fixed (byte* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this double[] src, int srcOffset, sbyte[] dst, int dstOffset, int count)
			{
				fixed (double* srcOrigin = &src[srcOffset])
				fixed (sbyte* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this double[] src, int srcOffset, ushort[] dst, int dstOffset, int count)
			{
				fixed (double* srcOrigin = &src[srcOffset])
				fixed (ushort* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this double[] src, int srcOffset, short[] dst, int dstOffset, int count)
			{
				fixed (double* srcOrigin = &src[srcOffset])
				fixed (short* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this double[] src, int srcOffset, uint[] dst, int dstOffset, int count)
			{
				fixed (double* srcOrigin = &src[srcOffset])
				fixed (uint* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this double[] src, int srcOffset, int[] dst, int dstOffset, int count)
			{
				fixed (double* srcOrigin = &src[srcOffset])
				fixed (int* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this double[] src, int srcOffset, ulong[] dst, int dstOffset, int count)
			{
				fixed (double* srcOrigin = &src[srcOffset])
				fixed (ulong* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this double[] src, int srcOffset, long[] dst, int dstOffset, int count)
			{
				fixed (double* srcOrigin = &src[srcOffset])
				fixed (long* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this double[] src, int srcOffset, float[] dst, int dstOffset, int count)
			{
				fixed (double* srcOrigin = &src[srcOffset])
				fixed (float* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
				
			public unsafe static void UnsafeBlockCopy(this double[] src, int srcOffset, double[] dst, int dstOffset, int count)
			{
				fixed (double* srcOrigin = &src[srcOffset])
				fixed (double* dstOrigin = &dst[dstOffset])
				{
					UnsafeBlockCopy((byte*)srcOrigin, (byte*)dstOrigin, count);
				}
			}
		
		
			public unsafe static void BlockCopy(this byte[] src, int srcOffset, byte[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this byte[] src, int srcOffset, sbyte[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this byte[] src, int srcOffset, ushort[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this byte[] src, int srcOffset, short[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this byte[] src, int srcOffset, uint[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this byte[] src, int srcOffset, int[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this byte[] src, int srcOffset, ulong[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this byte[] src, int srcOffset, long[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this byte[] src, int srcOffset, float[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this byte[] src, int srcOffset, double[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this sbyte[] src, int srcOffset, byte[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this sbyte[] src, int srcOffset, sbyte[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this sbyte[] src, int srcOffset, ushort[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this sbyte[] src, int srcOffset, short[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this sbyte[] src, int srcOffset, uint[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this sbyte[] src, int srcOffset, int[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this sbyte[] src, int srcOffset, ulong[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this sbyte[] src, int srcOffset, long[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this sbyte[] src, int srcOffset, float[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this sbyte[] src, int srcOffset, double[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this ushort[] src, int srcOffset, byte[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this ushort[] src, int srcOffset, sbyte[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this ushort[] src, int srcOffset, ushort[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this ushort[] src, int srcOffset, short[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this ushort[] src, int srcOffset, uint[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this ushort[] src, int srcOffset, int[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this ushort[] src, int srcOffset, ulong[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this ushort[] src, int srcOffset, long[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this ushort[] src, int srcOffset, float[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this ushort[] src, int srcOffset, double[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this short[] src, int srcOffset, byte[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this short[] src, int srcOffset, sbyte[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this short[] src, int srcOffset, ushort[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this short[] src, int srcOffset, short[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this short[] src, int srcOffset, uint[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this short[] src, int srcOffset, int[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this short[] src, int srcOffset, ulong[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this short[] src, int srcOffset, long[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this short[] src, int srcOffset, float[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this short[] src, int srcOffset, double[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this uint[] src, int srcOffset, byte[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this uint[] src, int srcOffset, sbyte[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this uint[] src, int srcOffset, ushort[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this uint[] src, int srcOffset, short[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this uint[] src, int srcOffset, uint[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this uint[] src, int srcOffset, int[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this uint[] src, int srcOffset, ulong[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this uint[] src, int srcOffset, long[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this uint[] src, int srcOffset, float[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this uint[] src, int srcOffset, double[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this int[] src, int srcOffset, byte[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this int[] src, int srcOffset, sbyte[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this int[] src, int srcOffset, ushort[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this int[] src, int srcOffset, short[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this int[] src, int srcOffset, uint[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this int[] src, int srcOffset, int[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this int[] src, int srcOffset, ulong[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this int[] src, int srcOffset, long[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this int[] src, int srcOffset, float[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this int[] src, int srcOffset, double[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this ulong[] src, int srcOffset, byte[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this ulong[] src, int srcOffset, sbyte[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this ulong[] src, int srcOffset, ushort[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this ulong[] src, int srcOffset, short[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this ulong[] src, int srcOffset, uint[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this ulong[] src, int srcOffset, int[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this ulong[] src, int srcOffset, ulong[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this ulong[] src, int srcOffset, long[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this ulong[] src, int srcOffset, float[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this ulong[] src, int srcOffset, double[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this long[] src, int srcOffset, byte[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this long[] src, int srcOffset, sbyte[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this long[] src, int srcOffset, ushort[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this long[] src, int srcOffset, short[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this long[] src, int srcOffset, uint[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this long[] src, int srcOffset, int[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this long[] src, int srcOffset, ulong[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this long[] src, int srcOffset, long[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this long[] src, int srcOffset, float[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this long[] src, int srcOffset, double[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this float[] src, int srcOffset, byte[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this float[] src, int srcOffset, sbyte[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this float[] src, int srcOffset, ushort[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this float[] src, int srcOffset, short[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this float[] src, int srcOffset, uint[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this float[] src, int srcOffset, int[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this float[] src, int srcOffset, ulong[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this float[] src, int srcOffset, long[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this float[] src, int srcOffset, float[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this float[] src, int srcOffset, double[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this double[] src, int srcOffset, byte[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this double[] src, int srcOffset, sbyte[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this double[] src, int srcOffset, ushort[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this double[] src, int srcOffset, short[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this double[] src, int srcOffset, uint[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this double[] src, int srcOffset, int[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this double[] src, int srcOffset, ulong[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this double[] src, int srcOffset, long[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this double[] src, int srcOffset, float[] dst, int dstOffset, int count)
			{
				if (src == null) throw new ArgumentNullException(nameof(src));
		        if (dst == null) throw new ArgumentNullException(nameof(dst));
		        if (count < 0 || srcOffset < 0 || dstOffset < 0) throw new ArgumentOutOfRangeException(nameof(count));
		        if (count == 0) return;
		        if (srcOffset + count > src.Length) throw new ArgumentException(nameof(src));
		        if (dstOffset + count > dst.Length) throw new ArgumentException(nameof(dst));

				UnsafeBlockCopy(src,srcOffset,dst,dstOffset,count);
			}
				
			public unsafe static void BlockCopy(this double[] src, int srcOffset, double[] dst, int dstOffset, int count)
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