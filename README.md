# FastBlockCopy
Copy is optimized for small data,such as 32 bytes. in 32 bytes it can 1.5x than Buffer.BlockCopy(),in 100 bytes,it fast than 1.2x,is is more,use Buffer.BlockCopy(),is fast.

use:

1 FastBuffer.UnsafeBlockCopy(from, 0, to, 0, 100); without bounds checking,also it more fast

2 FastBuffer.BlockCopy(from, 0, to, 0, 100); with bounds checking

and it also can use:from.UnsafeBlockCopy(0, to, 0, 100)

# 但是：在NET5下测试，无论是在小字节还是在多字节下，性能基本都差不多了，直接用系统的就可以了