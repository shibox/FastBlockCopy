# FastBlockCopy
Copy is optimized for small data,such as 32 bytes. in 32 bytes it can 2.5x than Buffer.BlockCopy(),in 200 bytes,it fast than 2x,in 1024 bytes,it fast than 1.25x,in any case,it fast!

use:

1 FastBuffer.UnsafeBlockCopy(from, 0, to, 0, 100); without bounds checking,also it more fast

2 FastBuffer.BlockCopy(from, 0, to, 0, 100); with bounds checking

and it also can use:from.UnsafeBlockCopy(0, to, 0, 100)
