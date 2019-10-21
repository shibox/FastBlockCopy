using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Tools
{
    public class SwitchBit
    {
        static readonly byte[] Lookup1 = new byte[] { 0, 1, 0, 2, 0, 0, 3, 0, 0, 0, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 7, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };
        readonly byte[] Lookup2 = new byte[] { };
        readonly byte[] Lookup3 = new byte[] { };
        readonly byte[] Lookup4 = new byte[] { };
        readonly byte[] Lookup5 = new byte[] { };
        readonly byte[] Lookup6 = new byte[] { };
        readonly byte[] Lookup7 = new byte[] { };
        readonly byte[] Lookup8 = new byte[] { };


        public unsafe static void SwitchBench16(byte[] data, int[] rs, byte[] bits, int count)
        {
            int n = 0;
            int v = 0;
            for (int i = 0; i < count; i++)
            {
                n += 8;
                v = bits[i];
            Count1:
                {
                    rs[data[n + 0]]++;
                }
            Count2:
                {

                }
            Count3:
                {

                }
            Count4:
                {

                }
            Count5:
                {

                }
            Count6:
                {

                }
            Count7:
                {

                }
            Count8:
                {
                    rs[data[n + 0]]++;
                    rs[data[n + 1]]++;
                    rs[data[n + 2]]++;
                    rs[data[n + 3]]++;
                    rs[data[n + 4]]++;
                    rs[data[n + 5]]++;
                    rs[data[n + 6]]++;
                    rs[data[n + 7]]++;
                }
            }
        

        }

        private unsafe static void Count1(int[] rs,byte[] data,int start, int n)
        {
            rs[data[start + n]]++;
        }

        private unsafe static void Count2(int[] rs, byte[] data, int start, int n0,int n1)
        {
            rs[data[start + n0]]++;
            rs[data[start + n1]]++;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private unsafe static void Count1(int* rs, byte* data, int offset)
        {
            rs[*(data + offset)]++;
        }

        
        public unsafe static int[] SwitchBench256DiffRSSort(byte[] data, byte[] bs, int count)
        {
            //int[] rs = new int[256];
            int* rs = stackalloc int[256];
            fixed (byte* pd = &bs[0],pdd=&data[0])
            {
                byte* pp = pd;
                byte* dd = pdd;
                byte v = 0;
                for (int i = 0; i < bs.Length; i++)
                {
                    v = *(pp + i);
                    switch (v)
                    {
                        case 1:
                            {
                                //rs[1]++;
                                //break;
                                //offset = 1;
                                goto Size1;
                                //Count1(rs, dd, 1);
                                break;
                            }
                        case 2:
                            {
                                //rs[2]++;
                                //break;
                                //offset = 2;
                                goto Size1;
                                //Count1(rs, dd, 2);
                                break;
                            }
                        case 4:
                            {
                                //rs[4]++;
                                //break;
                                //offset = 4;
                                goto Size1;
                                //Count1(rs, dd, 3);
                                break;
                            }
                        case 8:
                            {
                                //rs[8]++;
                                //break;
                                //offset = 8;
                                goto Size1;
                                //Count1(rs, dd, 4);
                                break;
                            }
                        case 16:
                            {
                                //rs[16]++;
                                //break;
                                //offset = 16;
                                goto Size1;
                                //Count1(rs, dd, 5);
                                break;
                            }
                        case 32:
                            {
                                //rs[32]++;
                                //break;
                                //offset = 32;
                                goto Size1;
                                //Count1(rs, dd, 6);
                                break;
                            }
                        case 64:
                            {
                                //rs[64]++;
                                //break;
                                //offset = 64;
                                goto Size1;
                                //Count1(rs, dd, 7);
                                break;
                            }
                        case 128:
                            {
                                //rs[128]++;
                                //break;
                                //offset = 128;
                                goto Size1;
                                //Count1(rs, dd, 8);
                                break;
                            }

                        case 0:
                            {
                                //rs[0]++;
                                //break;
                                //offset = 0;
                                //goto Size1;
                                break;
                            }
                        //case 1:
                        //    {
                        //        rs[1]++;
                        //        break;
                        //    }
                        //case 2:
                        //    {
                        //        rs[2]++;
                        //        break;
                        //    }
                        case 3:
                            {
                                rs[3]++;
                                break;
                            }
                        //case 4:
                        //    {
                        //        rs[4]++;
                        //        break;
                        //    }
                        case 5:
                            {
                                rs[5]++;
                                break;
                            }
                        case 6:
                            {
                                rs[6]++;
                                break;
                            }
                        case 7:
                            {
                                rs[7]++;
                                break;
                            }
                        //case 8:
                        //    {
                        //        rs[8]++;
                        //        break;
                        //    }
                        case 9:
                            {
                                rs[9]++;
                                break;
                            }
                        case 10:
                            {
                                rs[10]++;
                                break;
                            }
                        case 11:
                            {
                                rs[11]++;
                                break;
                            }
                        case 12:
                            {
                                rs[12]++;
                                break;
                            }
                        case 13:
                            {
                                rs[13]++;
                                break;
                            }
                        case 14:
                            {
                                rs[14]++;
                                break;
                            }
                        case 15:
                            {
                                rs[15]++;
                                break;
                            }
                        //case 16:
                        //    {
                        //        rs[16]++;
                        //        break;
                        //    }
                        case 17:
                            {
                                rs[17]++;
                                break;
                            }
                        case 18:
                            {
                                rs[18]++;
                                break;
                            }
                        case 19:
                            {
                                rs[19]++;
                                break;
                            }
                        case 20:
                            {
                                rs[20]++;
                                break;
                            }
                        case 21:
                            {
                                rs[21]++;
                                break;
                            }
                        case 22:
                            {
                                rs[22]++;
                                break;
                            }
                        case 23:
                            {
                                rs[23]++;
                                break;
                            }
                        case 24:
                            {
                                rs[24]++;
                                break;
                            }
                        case 25:
                            {
                                rs[25]++;
                                break;
                            }
                        case 26:
                            {
                                rs[26]++;
                                break;
                            }
                        case 27:
                            {
                                rs[27]++;
                                break;
                            }
                        case 28:
                            {
                                rs[28]++;
                                break;
                            }
                        case 29:
                            {
                                rs[29]++;
                                break;
                            }
                        case 30:
                            {
                                rs[30]++;
                                break;
                            }
                        case 31:
                            {
                                rs[31]++;
                                break;
                            }
                        //case 32:
                        //    {
                        //        rs[32]++;
                        //        break;
                        //    }
                        case 33:
                            {
                                rs[33]++;
                                break;
                            }
                        case 34:
                            {
                                rs[34]++;
                                break;
                            }
                        case 35:
                            {
                                rs[35]++;
                                break;
                            }
                        case 36:
                            {
                                rs[36]++;
                                break;
                            }
                        case 37:
                            {
                                rs[37]++;
                                break;
                            }
                        case 38:
                            {
                                rs[38]++;
                                break;
                            }
                        case 39:
                            {
                                rs[39]++;
                                break;
                            }
                        case 40:
                            {
                                rs[40]++;
                                break;
                            }
                        case 41:
                            {
                                rs[41]++;
                                break;
                            }
                        case 42:
                            {
                                rs[42]++;
                                break;
                            }
                        case 43:
                            {
                                rs[43]++;
                                break;
                            }
                        case 44:
                            {
                                rs[44]++;
                                break;
                            }
                        case 45:
                            {
                                rs[45]++;
                                break;
                            }
                        case 46:
                            {
                                rs[46]++;
                                break;
                            }
                        case 47:
                            {
                                rs[47]++;
                                break;
                            }
                        case 48:
                            {
                                rs[48]++;
                                break;
                            }
                        case 49:
                            {
                                rs[49]++;
                                break;
                            }
                        case 50:
                            {
                                rs[50]++;
                                break;
                            }
                        case 51:
                            {
                                rs[51]++;
                                break;
                            }
                        case 52:
                            {
                                rs[52]++;
                                break;
                            }
                        case 53:
                            {
                                rs[53]++;
                                break;
                            }
                        case 54:
                            {
                                rs[54]++;
                                break;
                            }
                        case 55:
                            {
                                rs[55]++;
                                break;
                            }
                        case 56:
                            {
                                rs[56]++;
                                break;
                            }
                        case 57:
                            {
                                rs[57]++;
                                break;
                            }
                        case 58:
                            {
                                rs[58]++;
                                break;
                            }
                        case 59:
                            {
                                rs[59]++;
                                break;
                            }
                        case 60:
                            {
                                rs[60]++;
                                break;
                            }
                        case 61:
                            {
                                rs[61]++;
                                break;
                            }
                        case 62:
                            {
                                rs[62]++;
                                break;
                            }
                        case 63:
                            {
                                rs[63]++;
                                break;
                            }
                        //case 64:
                        //    {
                        //        rs[64]++;
                        //        break;
                        //    }
                        case 65:
                            {
                                rs[65]++;
                                break;
                            }
                        case 66:
                            {
                                rs[66]++;
                                break;
                            }
                        case 67:
                            {
                                rs[67]++;
                                break;
                            }
                        case 68:
                            {
                                rs[68]++;
                                break;
                            }
                        case 69:
                            {
                                rs[69]++;
                                break;
                            }
                        case 70:
                            {
                                rs[70]++;
                                break;
                            }
                        case 71:
                            {
                                rs[71]++;
                                break;
                            }
                        case 72:
                            {
                                rs[72]++;
                                break;
                            }
                        case 73:
                            {
                                rs[73]++;
                                break;
                            }
                        case 74:
                            {
                                rs[74]++;
                                break;
                            }
                        case 75:
                            {
                                rs[75]++;
                                break;
                            }
                        case 76:
                            {
                                rs[76]++;
                                break;
                            }
                        case 77:
                            {
                                rs[77]++;
                                break;
                            }
                        case 78:
                            {
                                rs[78]++;
                                break;
                            }
                        case 79:
                            {
                                rs[79]++;
                                break;
                            }
                        case 80:
                            {
                                rs[80]++;
                                break;
                            }
                        case 81:
                            {
                                rs[81]++;
                                break;
                            }
                        case 82:
                            {
                                rs[82]++;
                                break;
                            }
                        case 83:
                            {
                                rs[83]++;
                                break;
                            }
                        case 84:
                            {
                                rs[84]++;
                                break;
                            }
                        case 85:
                            {
                                rs[85]++;
                                break;
                            }
                        case 86:
                            {
                                rs[86]++;
                                break;
                            }
                        case 87:
                            {
                                rs[87]++;
                                break;
                            }
                        case 88:
                            {
                                rs[88]++;
                                break;
                            }
                        case 89:
                            {
                                rs[89]++;
                                break;
                            }
                        case 90:
                            {
                                rs[90]++;
                                break;
                            }
                        case 91:
                            {
                                rs[91]++;
                                break;
                            }
                        case 92:
                            {
                                rs[92]++;
                                break;
                            }
                        case 93:
                            {
                                rs[93]++;
                                break;
                            }
                        case 94:
                            {
                                rs[94]++;
                                break;
                            }
                        case 95:
                            {
                                rs[95]++;
                                break;
                            }
                        case 96:
                            {
                                rs[96]++;
                                break;
                            }
                        case 97:
                            {
                                rs[97]++;
                                break;
                            }
                        case 98:
                            {
                                rs[98]++;
                                break;
                            }
                        case 99:
                            {
                                rs[99]++;
                                break;
                            }
                        case 100:
                            {
                                rs[100]++;
                                break;
                            }
                        case 101:
                            {
                                rs[101]++;
                                break;
                            }
                        case 102:
                            {
                                rs[102]++;
                                break;
                            }
                        case 103:
                            {
                                rs[103]++;
                                break;
                            }
                        case 104:
                            {
                                rs[104]++;
                                break;
                            }
                        case 105:
                            {
                                rs[105]++;
                                break;
                            }
                        case 106:
                            {
                                rs[106]++;
                                break;
                            }
                        case 107:
                            {
                                rs[107]++;
                                break;
                            }
                        case 108:
                            {
                                rs[108]++;
                                break;
                            }
                        case 109:
                            {
                                rs[109]++;
                                break;
                            }
                        case 110:
                            {
                                rs[110]++;
                                break;
                            }
                        case 111:
                            {
                                rs[111]++;
                                break;
                            }
                        case 112:
                            {
                                rs[112]++;
                                break;
                            }
                        case 113:
                            {
                                rs[113]++;
                                break;
                            }
                        case 114:
                            {
                                rs[114]++;
                                break;
                            }
                        case 115:
                            {
                                rs[115]++;
                                break;
                            }
                        case 116:
                            {
                                rs[116]++;
                                break;
                            }
                        case 117:
                            {
                                rs[117]++;
                                break;
                            }
                        case 118:
                            {
                                rs[118]++;
                                break;
                            }
                        case 119:
                            {
                                rs[119]++;
                                break;
                            }
                        case 120:
                            {
                                rs[120]++;
                                break;
                            }
                        case 121:
                            {
                                rs[121]++;
                                break;
                            }
                        case 122:
                            {
                                rs[122]++;
                                break;
                            }
                        case 123:
                            {
                                rs[123]++;
                                break;
                            }
                        case 124:
                            {
                                rs[124]++;
                                break;
                            }
                        case 125:
                            {
                                rs[125]++;
                                break;
                            }
                        case 126:
                            {
                                rs[126]++;
                                break;
                            }
                        case 127:
                            {
                                rs[127]++;
                                break;
                            }
                        //case 128:
                        //    {
                        //        rs[128]++;
                        //        break;
                        //    }
                        case 129:
                            {
                                rs[129]++;
                                break;
                            }
                        case 130:
                            {
                                rs[130]++;
                                break;
                            }
                        case 131:
                            {
                                rs[131]++;
                                break;
                            }
                        case 132:
                            {
                                rs[132]++;
                                break;
                            }
                        case 133:
                            {
                                rs[133]++;
                                break;
                            }
                        case 134:
                            {
                                rs[134]++;
                                break;
                            }
                        case 135:
                            {
                                rs[135]++;
                                break;
                            }
                        case 136:
                            {
                                rs[136]++;
                                break;
                            }
                        case 137:
                            {
                                rs[137]++;
                                break;
                            }
                        case 138:
                            {
                                rs[138]++;
                                break;
                            }
                        case 139:
                            {
                                rs[139]++;
                                break;
                            }
                        case 140:
                            {
                                rs[140]++;
                                break;
                            }
                        case 141:
                            {
                                rs[141]++;
                                break;
                            }
                        case 142:
                            {
                                rs[142]++;
                                break;
                            }
                        case 143:
                            {
                                rs[143]++;
                                break;
                            }
                        case 144:
                            {
                                rs[144]++;
                                break;
                            }
                        case 145:
                            {
                                rs[145]++;
                                break;
                            }
                        case 146:
                            {
                                rs[146]++;
                                break;
                            }
                        case 147:
                            {
                                rs[147]++;
                                break;
                            }
                        case 148:
                            {
                                rs[148]++;
                                break;
                            }
                        case 149:
                            {
                                rs[149]++;
                                break;
                            }
                        case 150:
                            {
                                rs[150]++;
                                break;
                            }
                        case 151:
                            {
                                rs[151]++;
                                break;
                            }
                        case 152:
                            {
                                rs[152]++;
                                break;
                            }
                        case 153:
                            {
                                rs[153]++;
                                break;
                            }
                        case 154:
                            {
                                rs[154]++;
                                break;
                            }
                        case 155:
                            {
                                rs[155]++;
                                break;
                            }
                        case 156:
                            {
                                rs[156]++;
                                break;
                            }
                        case 157:
                            {
                                rs[157]++;
                                break;
                            }
                        case 158:
                            {
                                rs[158]++;
                                break;
                            }
                        case 159:
                            {
                                rs[159]++;
                                break;
                            }
                        case 160:
                            {
                                rs[160]++;
                                break;
                            }
                        case 161:
                            {
                                rs[161]++;
                                break;
                            }
                        case 162:
                            {
                                rs[162]++;
                                break;
                            }
                        case 163:
                            {
                                rs[163]++;
                                break;
                            }
                        case 164:
                            {
                                rs[164]++;
                                break;
                            }
                        case 165:
                            {
                                rs[165]++;
                                break;
                            }
                        case 166:
                            {
                                rs[166]++;
                                break;
                            }
                        case 167:
                            {
                                rs[167]++;
                                break;
                            }
                        case 168:
                            {
                                rs[168]++;
                                break;
                            }
                        case 169:
                            {
                                rs[169]++;
                                break;
                            }
                        case 170:
                            {
                                rs[170]++;
                                break;
                            }
                        case 171:
                            {
                                rs[171]++;
                                break;
                            }
                        case 172:
                            {
                                rs[172]++;
                                break;
                            }
                        case 173:
                            {
                                rs[173]++;
                                break;
                            }
                        case 174:
                            {
                                rs[174]++;
                                break;
                            }
                        case 175:
                            {
                                rs[175]++;
                                break;
                            }
                        case 176:
                            {
                                rs[176]++;
                                break;
                            }
                        case 177:
                            {
                                rs[177]++;
                                break;
                            }
                        case 178:
                            {
                                rs[178]++;
                                break;
                            }
                        case 179:
                            {
                                rs[179]++;
                                break;
                            }
                        case 180:
                            {
                                rs[180]++;
                                break;
                            }
                        case 181:
                            {
                                rs[181]++;
                                break;
                            }
                        case 182:
                            {
                                rs[182]++;
                                break;
                            }
                        case 183:
                            {
                                rs[183]++;
                                break;
                            }
                        case 184:
                            {
                                rs[184]++;
                                break;
                            }
                        case 185:
                            {
                                rs[185]++;
                                break;
                            }
                        case 186:
                            {
                                rs[186]++;
                                break;
                            }
                        case 187:
                            {
                                rs[187]++;
                                break;
                            }
                        case 188:
                            {
                                rs[188]++;
                                break;
                            }
                        case 189:
                            {
                                rs[189]++;
                                break;
                            }
                        case 190:
                            {
                                rs[190]++;
                                break;
                            }
                        case 191:
                            {
                                rs[191]++;
                                break;
                            }
                        case 192:
                            {
                                rs[192]++;
                                break;
                            }
                        case 193:
                            {
                                rs[193]++;
                                break;
                            }
                        case 194:
                            {
                                rs[194]++;
                                break;
                            }
                        case 195:
                            {
                                rs[195]++;
                                break;
                            }
                        case 196:
                            {
                                rs[196]++;
                                break;
                            }
                        case 197:
                            {
                                rs[197]++;
                                break;
                            }
                        case 198:
                            {
                                rs[198]++;
                                break;
                            }
                        case 199:
                            {
                                rs[199]++;
                                break;
                            }
                        case 200:
                            {
                                rs[200]++;
                                break;
                            }
                        case 201:
                            {
                                rs[201]++;
                                break;
                            }
                        case 202:
                            {
                                rs[202]++;
                                break;
                            }
                        case 203:
                            {
                                rs[203]++;
                                break;
                            }
                        case 204:
                            {
                                rs[204]++;
                                break;
                            }
                        case 205:
                            {
                                rs[205]++;
                                break;
                            }
                        case 206:
                            {
                                rs[206]++;
                                break;
                            }
                        case 207:
                            {
                                rs[207]++;
                                break;
                            }
                        case 208:
                            {
                                rs[208]++;
                                break;
                            }
                        case 209:
                            {
                                rs[209]++;
                                break;
                            }
                        case 210:
                            {
                                rs[210]++;
                                break;
                            }
                        case 211:
                            {
                                rs[211]++;
                                break;
                            }
                        case 212:
                            {
                                rs[212]++;
                                break;
                            }
                        case 213:
                            {
                                rs[213]++;
                                break;
                            }
                        case 214:
                            {
                                rs[214]++;
                                break;
                            }
                        case 215:
                            {
                                rs[215]++;
                                break;
                            }
                        case 216:
                            {
                                rs[216]++;
                                break;
                            }
                        case 217:
                            {
                                rs[217]++;
                                break;
                            }
                        case 218:
                            {
                                rs[218]++;
                                break;
                            }
                        case 219:
                            {
                                rs[219]++;
                                break;
                            }
                        case 220:
                            {
                                rs[220]++;
                                break;
                            }
                        case 221:
                            {
                                rs[221]++;
                                break;
                            }
                        case 222:
                            {
                                rs[222]++;
                                break;
                            }
                        case 223:
                            {
                                rs[223]++;
                                break;
                            }
                        case 224:
                            {
                                rs[224]++;
                                break;
                            }
                        case 225:
                            {
                                rs[225]++;
                                break;
                            }
                        case 226:
                            {
                                rs[226]++;
                                break;
                            }
                        case 227:
                            {
                                rs[227]++;
                                break;
                            }
                        case 228:
                            {
                                rs[228]++;
                                break;
                            }
                        case 229:
                            {
                                rs[229]++;
                                break;
                            }
                        case 230:
                            {
                                rs[230]++;
                                break;
                            }
                        case 231:
                            {
                                rs[231]++;
                                break;
                            }
                        case 232:
                            {
                                rs[232]++;
                                break;
                            }
                        case 233:
                            {
                                rs[233]++;
                                break;
                            }
                        case 234:
                            {
                                rs[234]++;
                                break;
                            }
                        case 235:
                            {
                                rs[235]++;
                                break;
                            }
                        case 236:
                            {
                                rs[236]++;
                                break;
                            }
                        case 237:
                            {
                                rs[237]++;
                                break;
                            }
                        case 238:
                            {
                                rs[238]++;
                                break;
                            }
                        case 239:
                            {
                                rs[239]++;
                                break;
                            }
                        case 240:
                            {
                                rs[240]++;
                                break;
                            }
                        case 241:
                            {
                                rs[241]++;
                                break;
                            }
                        case 242:
                            {
                                rs[242]++;
                                break;
                            }
                        case 243:
                            {
                                rs[243]++;
                                break;
                            }
                        case 244:
                            {
                                rs[244]++;
                                break;
                            }
                        case 245:
                            {
                                rs[245]++;
                                break;
                            }
                        case 246:
                            {
                                rs[246]++;
                                break;
                            }
                        case 247:
                            {
                                rs[247]++;
                                break;
                            }
                        case 248:
                            {
                                rs[248]++;
                                break;
                            }
                        case 249:
                            {
                                rs[249]++;
                                break;
                            }
                        case 250:
                            {
                                rs[250]++;
                                break;
                            }
                        case 251:
                            {
                                rs[251]++;
                                break;
                            }
                        case 252:
                            {
                                rs[252]++;
                                break;
                            }
                        case 253:
                            {
                                rs[253]++;
                                break;
                            }
                        case 254:
                            {
                                rs[254]++;
                                break;
                            }
                        case 255:
                            {
                                rs[255]++;
                                break;
                            }
                    }
                Size1:
                    {
                        int offset = Lookup1[v];
                        rs[*(dd + offset)]++;
                    }
                    dd += 8;
                }
            
            }
            return new int[] { };
        }



    }
}
