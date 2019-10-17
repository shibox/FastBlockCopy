using System;
using System.Collections.Generic;
using System.Text;

namespace Tools
{
    public class SwitchBit
    {
        public unsafe static void SwitchBench16(byte[] data, int[] rs, byte[] bits, int count)
        {
            int n = 0;
            int v = 0;
            for (int i = 0; i < count; i++)
            {
                v = bits[i];
                switch (v)
                {
                    case 0:
                        {
                            
                            break;
                        }
                    case 1:
                        {
                            n++;
                            break;
                        }
                    case 2:
                        {
                            n++;
                            break;
                        }
                    case 3:
                        {
                            n++;
                            break;
                        }
                    
                }
            }


        }

    }
}
