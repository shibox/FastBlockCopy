using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FastBlockCopy;

namespace FastBlockCopyTests
{
    [TestClass]
    public class FastBufferTests
    {
        [TestMethod]
        public void TestCopy()
        {
            for (int i = 0; i < 1024; i++)
            {
                var src = new byte[i];
                var dst = new byte[i];
                var rd = new Random(Guid.NewGuid().GetHashCode());
                rd.NextBytes(src);
                FastBuffer.BlockCopy(src, 0, dst, 0, src.Length);
                for (int n = 0; n < i; n++)
                    Assert.AreEqual(src[n], dst[n]);
            }
        }
    
    }
}
