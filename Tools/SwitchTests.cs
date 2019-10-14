using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

namespace Tools
{
    public class SwitchTests
    {
        public unsafe static void Run()
        {
            Random rd = new Random(Guid.NewGuid().GetHashCode());
            byte[] bytes = new byte[100000000];
            //for (int i = 0; i < bytes.Length; i++)
            //    bytes[i] = 200;
            rd.NextBytes(bytes);
            Stopwatch w = Stopwatch.StartNew();
            //fixed (byte* pd = &bytes[0])
            //{
            //    SwitchBench(pd,bytes.Length);
            //}
            Funs(bytes);
            Console.WriteLine($"SwitchBench Cost:{w.ElapsedMilliseconds}");

            w = Stopwatch.StartNew();
            fixed (byte* pd = &bytes[0])
            {
                //SwitchBench2(pd, bytes.Length);
                SwitchBench3(bytes, bytes.Length);
            }
            //Funs(bytes);
            Console.WriteLine($"SwitchBench2 Cost:{w.ElapsedMilliseconds}");

            ArraySegment<byte>[] arrays = new ArraySegment<byte>[] { new ArraySegment<byte>(bytes) };
            w = Stopwatch.StartNew();
            GTop1(arrays, null, new int[256], bytes.Length);
            Console.WriteLine($"ArrayBench Cost:{w.ElapsedMilliseconds}");

            w = Stopwatch.StartNew();
            //fixed (byte* pd = &bytes[0])
            //{
            //    SwitchBench(pd, bytes.Length);
            //}
            int[] rs = Funs(bytes);
            //Console.WriteLine(rs);
            Console.WriteLine($"SwitchBench Cost:{w.ElapsedMilliseconds}");

            w = Stopwatch.StartNew();
            fixed (byte* pd = &bytes[0])
            {
                //SwitchBench2(pd, bytes.Length);
                SwitchBench3(bytes, bytes.Length);
            }
            //Funs(bytes);
            Console.WriteLine($"SwitchBench2 Cost:{w.ElapsedMilliseconds}");

            w = Stopwatch.StartNew();
            GTop1(arrays, null, new int[256], bytes.Length);
            Console.WriteLine($"ArrayBench Cost:{w.ElapsedMilliseconds}");
        }

        public unsafe static void SwitchBench(byte* bs,int count)
        {
            int i_0 = 0;
            int i_1 = 0;
            int i_2 = 0;
            int i_3 = 0;
            int i_4 = 0;
            int i_5 = 0;
            int i_6 = 0;
            int i_7 = 0;
            int i_8 = 0;
            int i_9 = 0;
            int i_10 = 0;
            int i_11 = 0;
            int i_12 = 0;
            int i_13 = 0;
            int i_14 = 0;
            int i_15 = 0;
            int i_16 = 0;
            int i_17 = 0;
            int i_18 = 0;
            int i_19 = 0;
            int i_20 = 0;
            int i_21 = 0;
            int i_22 = 0;
            int i_23 = 0;
            int i_24 = 0;
            int i_25 = 0;
            int i_26 = 0;
            int i_27 = 0;
            int i_28 = 0;
            int i_29 = 0;
            int i_30 = 0;
            int i_31 = 0;
            int i_32 = 0;
            int i_33 = 0;
            int i_34 = 0;
            int i_35 = 0;
            int i_36 = 0;
            int i_37 = 0;
            int i_38 = 0;
            int i_39 = 0;
            int i_40 = 0;
            int i_41 = 0;
            int i_42 = 0;
            int i_43 = 0;
            int i_44 = 0;
            int i_45 = 0;
            int i_46 = 0;
            int i_47 = 0;
            int i_48 = 0;
            int i_49 = 0;
            int i_50 = 0;
            int i_51 = 0;
            int i_52 = 0;
            int i_53 = 0;
            int i_54 = 0;
            int i_55 = 0;
            int i_56 = 0;
            int i_57 = 0;
            int i_58 = 0;
            int i_59 = 0;
            int i_60 = 0;
            int i_61 = 0;
            int i_62 = 0;
            int i_63 = 0;
            int i_64 = 0;
            int i_65 = 0;
            int i_66 = 0;
            int i_67 = 0;
            int i_68 = 0;
            int i_69 = 0;
            int i_70 = 0;
            int i_71 = 0;
            int i_72 = 0;
            int i_73 = 0;
            int i_74 = 0;
            int i_75 = 0;
            int i_76 = 0;
            int i_77 = 0;
            int i_78 = 0;
            int i_79 = 0;
            int i_80 = 0;
            int i_81 = 0;
            int i_82 = 0;
            int i_83 = 0;
            int i_84 = 0;
            int i_85 = 0;
            int i_86 = 0;
            int i_87 = 0;
            int i_88 = 0;
            int i_89 = 0;
            int i_90 = 0;
            int i_91 = 0;
            int i_92 = 0;
            int i_93 = 0;
            int i_94 = 0;
            int i_95 = 0;
            int i_96 = 0;
            int i_97 = 0;
            int i_98 = 0;
            int i_99 = 0;
            int i_100 = 0;
            int i_101 = 0;
            int i_102 = 0;
            int i_103 = 0;
            int i_104 = 0;
            int i_105 = 0;
            int i_106 = 0;
            int i_107 = 0;
            int i_108 = 0;
            int i_109 = 0;
            int i_110 = 0;
            int i_111 = 0;
            int i_112 = 0;
            int i_113 = 0;
            int i_114 = 0;
            int i_115 = 0;
            int i_116 = 0;
            int i_117 = 0;
            int i_118 = 0;
            int i_119 = 0;
            int i_120 = 0;
            int i_121 = 0;
            int i_122 = 0;
            int i_123 = 0;
            int i_124 = 0;
            int i_125 = 0;
            int i_126 = 0;
            int i_127 = 0;
            int i_128 = 0;
            int i_129 = 0;
            int i_130 = 0;
            int i_131 = 0;
            int i_132 = 0;
            int i_133 = 0;
            int i_134 = 0;
            int i_135 = 0;
            int i_136 = 0;
            int i_137 = 0;
            int i_138 = 0;
            int i_139 = 0;
            int i_140 = 0;
            int i_141 = 0;
            int i_142 = 0;
            int i_143 = 0;
            int i_144 = 0;
            int i_145 = 0;
            int i_146 = 0;
            int i_147 = 0;
            int i_148 = 0;
            int i_149 = 0;
            int i_150 = 0;
            int i_151 = 0;
            int i_152 = 0;
            int i_153 = 0;
            int i_154 = 0;
            int i_155 = 0;
            int i_156 = 0;
            int i_157 = 0;
            int i_158 = 0;
            int i_159 = 0;
            int i_160 = 0;
            int i_161 = 0;
            int i_162 = 0;
            int i_163 = 0;
            int i_164 = 0;
            int i_165 = 0;
            int i_166 = 0;
            int i_167 = 0;
            int i_168 = 0;
            int i_169 = 0;
            int i_170 = 0;
            int i_171 = 0;
            int i_172 = 0;
            int i_173 = 0;
            int i_174 = 0;
            int i_175 = 0;
            int i_176 = 0;
            int i_177 = 0;
            int i_178 = 0;
            int i_179 = 0;
            int i_180 = 0;
            int i_181 = 0;
            int i_182 = 0;
            int i_183 = 0;
            int i_184 = 0;
            int i_185 = 0;
            int i_186 = 0;
            int i_187 = 0;
            int i_188 = 0;
            int i_189 = 0;
            int i_190 = 0;
            int i_191 = 0;
            int i_192 = 0;
            int i_193 = 0;
            int i_194 = 0;
            int i_195 = 0;
            int i_196 = 0;
            int i_197 = 0;
            int i_198 = 0;
            int i_199 = 0;
            int i_200 = 0;
            int i_201 = 0;
            int i_202 = 0;
            int i_203 = 0;
            int i_204 = 0;
            int i_205 = 0;
            int i_206 = 0;
            int i_207 = 0;
            int i_208 = 0;
            int i_209 = 0;
            int i_210 = 0;
            int i_211 = 0;
            int i_212 = 0;
            int i_213 = 0;
            int i_214 = 0;
            int i_215 = 0;
            int i_216 = 0;
            int i_217 = 0;
            int i_218 = 0;
            int i_219 = 0;
            int i_220 = 0;
            int i_221 = 0;
            int i_222 = 0;
            int i_223 = 0;
            int i_224 = 0;
            int i_225 = 0;
            int i_226 = 0;
            int i_227 = 0;
            int i_228 = 0;
            int i_229 = 0;
            int i_230 = 0;
            int i_231 = 0;
            int i_232 = 0;
            int i_233 = 0;
            int i_234 = 0;
            int i_235 = 0;
            int i_236 = 0;
            int i_237 = 0;
            int i_238 = 0;
            int i_239 = 0;
            int i_240 = 0;
            int i_241 = 0;
            int i_242 = 0;
            int i_243 = 0;
            int i_244 = 0;
            int i_245 = 0;
            int i_246 = 0;
            int i_247 = 0;
            int i_248 = 0;
            int i_249 = 0;
            int i_250 = 0;
            int i_251 = 0;
            int i_252 = 0;
            int i_253 = 0;
            int i_254 = 0;
            int i_255 = 0;
            for (int i = 0; i < count; i++)
            {
                switch (*(bs+i))
                {
                    case 0:
                        {
                            i_0++;
                            break;
                        }
                    case 1:
                        {
                            i_1++;
                            break;
                        }
                    case 2:
                        {
                            i_2++;
                            break;
                        }
                    case 3:
                        {
                            i_3++;
                            break;
                        }
                    case 4:
                        {
                            i_4++;
                            break;
                        }
                    case 5:
                        {
                            i_5++;
                            break;
                        }
                    case 6:
                        {
                            i_6++;
                            break;
                        }
                    case 7:
                        {
                            i_7++;
                            break;
                        }
                    case 8:
                        {
                            i_8++;
                            break;
                        }
                    case 9:
                        {
                            i_9++;
                            break;
                        }
                    case 10:
                        {
                            i_10++;
                            break;
                        }
                    case 11:
                        {
                            i_11++;
                            break;
                        }
                    case 12:
                        {
                            i_12++;
                            break;
                        }
                    case 13:
                        {
                            i_13++;
                            break;
                        }
                    case 14:
                        {
                            i_14++;
                            break;
                        }
                    case 15:
                        {
                            i_15++;
                            break;
                        }
                    case 16:
                        {
                            i_16++;
                            break;
                        }
                    case 17:
                        {
                            i_17++;
                            break;
                        }
                    case 18:
                        {
                            i_18++;
                            break;
                        }
                    case 19:
                        {
                            i_19++;
                            break;
                        }
                    case 20:
                        {
                            i_20++;
                            break;
                        }
                    case 21:
                        {
                            i_21++;
                            break;
                        }
                    case 22:
                        {
                            i_22++;
                            break;
                        }
                    case 23:
                        {
                            i_23++;
                            break;
                        }
                    case 24:
                        {
                            i_24++;
                            break;
                        }
                    case 25:
                        {
                            i_25++;
                            break;
                        }
                    case 26:
                        {
                            i_26++;
                            break;
                        }
                    case 27:
                        {
                            i_27++;
                            break;
                        }
                    case 28:
                        {
                            i_28++;
                            break;
                        }
                    case 29:
                        {
                            i_29++;
                            break;
                        }
                    case 30:
                        {
                            i_30++;
                            break;
                        }
                    case 31:
                        {
                            i_31++;
                            break;
                        }
                    case 32:
                        {
                            i_32++;
                            break;
                        }
                    case 33:
                        {
                            i_33++;
                            break;
                        }
                    case 34:
                        {
                            i_34++;
                            break;
                        }
                    case 35:
                        {
                            i_35++;
                            break;
                        }
                    case 36:
                        {
                            i_36++;
                            break;
                        }
                    case 37:
                        {
                            i_37++;
                            break;
                        }
                    case 38:
                        {
                            i_38++;
                            break;
                        }
                    case 39:
                        {
                            i_39++;
                            break;
                        }
                    case 40:
                        {
                            i_40++;
                            break;
                        }
                    case 41:
                        {
                            i_41++;
                            break;
                        }
                    case 42:
                        {
                            i_42++;
                            break;
                        }
                    case 43:
                        {
                            i_43++;
                            break;
                        }
                    case 44:
                        {
                            i_44++;
                            break;
                        }
                    case 45:
                        {
                            i_45++;
                            break;
                        }
                    case 46:
                        {
                            i_46++;
                            break;
                        }
                    case 47:
                        {
                            i_47++;
                            break;
                        }
                    case 48:
                        {
                            i_48++;
                            break;
                        }
                    case 49:
                        {
                            i_49++;
                            break;
                        }
                    case 50:
                        {
                            i_50++;
                            break;
                        }
                    case 51:
                        {
                            i_51++;
                            break;
                        }
                    case 52:
                        {
                            i_52++;
                            break;
                        }
                    case 53:
                        {
                            i_53++;
                            break;
                        }
                    case 54:
                        {
                            i_54++;
                            break;
                        }
                    case 55:
                        {
                            i_55++;
                            break;
                        }
                    case 56:
                        {
                            i_56++;
                            break;
                        }
                    case 57:
                        {
                            i_57++;
                            break;
                        }
                    case 58:
                        {
                            i_58++;
                            break;
                        }
                    case 59:
                        {
                            i_59++;
                            break;
                        }
                    case 60:
                        {
                            i_60++;
                            break;
                        }
                    case 61:
                        {
                            i_61++;
                            break;
                        }
                    case 62:
                        {
                            i_62++;
                            break;
                        }
                    case 63:
                        {
                            i_63++;
                            break;
                        }
                    case 64:
                        {
                            i_64++;
                            break;
                        }
                    case 65:
                        {
                            i_65++;
                            break;
                        }
                    case 66:
                        {
                            i_66++;
                            break;
                        }
                    case 67:
                        {
                            i_67++;
                            break;
                        }
                    case 68:
                        {
                            i_68++;
                            break;
                        }
                    case 69:
                        {
                            i_69++;
                            break;
                        }
                    case 70:
                        {
                            i_70++;
                            break;
                        }
                    case 71:
                        {
                            i_71++;
                            break;
                        }
                    case 72:
                        {
                            i_72++;
                            break;
                        }
                    case 73:
                        {
                            i_73++;
                            break;
                        }
                    case 74:
                        {
                            i_74++;
                            break;
                        }
                    case 75:
                        {
                            i_75++;
                            break;
                        }
                    case 76:
                        {
                            i_76++;
                            break;
                        }
                    case 77:
                        {
                            i_77++;
                            break;
                        }
                    case 78:
                        {
                            i_78++;
                            break;
                        }
                    case 79:
                        {
                            i_79++;
                            break;
                        }
                    case 80:
                        {
                            i_80++;
                            break;
                        }
                    case 81:
                        {
                            i_81++;
                            break;
                        }
                    case 82:
                        {
                            i_82++;
                            break;
                        }
                    case 83:
                        {
                            i_83++;
                            break;
                        }
                    case 84:
                        {
                            i_84++;
                            break;
                        }
                    case 85:
                        {
                            i_85++;
                            break;
                        }
                    case 86:
                        {
                            i_86++;
                            break;
                        }
                    case 87:
                        {
                            i_87++;
                            break;
                        }
                    case 88:
                        {
                            i_88++;
                            break;
                        }
                    case 89:
                        {
                            i_89++;
                            break;
                        }
                    case 90:
                        {
                            i_90++;
                            break;
                        }
                    case 91:
                        {
                            i_91++;
                            break;
                        }
                    case 92:
                        {
                            i_92++;
                            break;
                        }
                    case 93:
                        {
                            i_93++;
                            break;
                        }
                    case 94:
                        {
                            i_94++;
                            break;
                        }
                    case 95:
                        {
                            i_95++;
                            break;
                        }
                    case 96:
                        {
                            i_96++;
                            break;
                        }
                    case 97:
                        {
                            i_97++;
                            break;
                        }
                    case 98:
                        {
                            i_98++;
                            break;
                        }
                    case 99:
                        {
                            i_99++;
                            break;
                        }
                    case 100:
                        {
                            i_100++;
                            break;
                        }
                    case 101:
                        {
                            i_101++;
                            break;
                        }
                    case 102:
                        {
                            i_102++;
                            break;
                        }
                    case 103:
                        {
                            i_103++;
                            break;
                        }
                    case 104:
                        {
                            i_104++;
                            break;
                        }
                    case 105:
                        {
                            i_105++;
                            break;
                        }
                    case 106:
                        {
                            i_106++;
                            break;
                        }
                    case 107:
                        {
                            i_107++;
                            break;
                        }
                    case 108:
                        {
                            i_108++;
                            break;
                        }
                    case 109:
                        {
                            i_109++;
                            break;
                        }
                    case 110:
                        {
                            i_110++;
                            break;
                        }
                    case 111:
                        {
                            i_111++;
                            break;
                        }
                    case 112:
                        {
                            i_112++;
                            break;
                        }
                    case 113:
                        {
                            i_113++;
                            break;
                        }
                    case 114:
                        {
                            i_114++;
                            break;
                        }
                    case 115:
                        {
                            i_115++;
                            break;
                        }
                    case 116:
                        {
                            i_116++;
                            break;
                        }
                    case 117:
                        {
                            i_117++;
                            break;
                        }
                    case 118:
                        {
                            i_118++;
                            break;
                        }
                    case 119:
                        {
                            i_119++;
                            break;
                        }
                    case 120:
                        {
                            i_120++;
                            break;
                        }
                    case 121:
                        {
                            i_121++;
                            break;
                        }
                    case 122:
                        {
                            i_122++;
                            break;
                        }
                    case 123:
                        {
                            i_123++;
                            break;
                        }
                    case 124:
                        {
                            i_124++;
                            break;
                        }
                    case 125:
                        {
                            i_125++;
                            break;
                        }
                    case 126:
                        {
                            i_126++;
                            break;
                        }
                    case 127:
                        {
                            i_127++;
                            break;
                        }
                    case 128:
                        {
                            i_128++;
                            break;
                        }
                    case 129:
                        {
                            i_129++;
                            break;
                        }
                    case 130:
                        {
                            i_130++;
                            break;
                        }
                    case 131:
                        {
                            i_131++;
                            break;
                        }
                    case 132:
                        {
                            i_132++;
                            break;
                        }
                    case 133:
                        {
                            i_133++;
                            break;
                        }
                    case 134:
                        {
                            i_134++;
                            break;
                        }
                    case 135:
                        {
                            i_135++;
                            break;
                        }
                    case 136:
                        {
                            i_136++;
                            break;
                        }
                    case 137:
                        {
                            i_137++;
                            break;
                        }
                    case 138:
                        {
                            i_138++;
                            break;
                        }
                    case 139:
                        {
                            i_139++;
                            break;
                        }
                    case 140:
                        {
                            i_140++;
                            break;
                        }
                    case 141:
                        {
                            i_141++;
                            break;
                        }
                    case 142:
                        {
                            i_142++;
                            break;
                        }
                    case 143:
                        {
                            i_143++;
                            break;
                        }
                    case 144:
                        {
                            i_144++;
                            break;
                        }
                    case 145:
                        {
                            i_145++;
                            break;
                        }
                    case 146:
                        {
                            i_146++;
                            break;
                        }
                    case 147:
                        {
                            i_147++;
                            break;
                        }
                    case 148:
                        {
                            i_148++;
                            break;
                        }
                    case 149:
                        {
                            i_149++;
                            break;
                        }
                    case 150:
                        {
                            i_150++;
                            break;
                        }
                    case 151:
                        {
                            i_151++;
                            break;
                        }
                    case 152:
                        {
                            i_152++;
                            break;
                        }
                    case 153:
                        {
                            i_153++;
                            break;
                        }
                    case 154:
                        {
                            i_154++;
                            break;
                        }
                    case 155:
                        {
                            i_155++;
                            break;
                        }
                    case 156:
                        {
                            i_156++;
                            break;
                        }
                    case 157:
                        {
                            i_157++;
                            break;
                        }
                    case 158:
                        {
                            i_158++;
                            break;
                        }
                    case 159:
                        {
                            i_159++;
                            break;
                        }
                    case 160:
                        {
                            i_160++;
                            break;
                        }
                    case 161:
                        {
                            i_161++;
                            break;
                        }
                    case 162:
                        {
                            i_162++;
                            break;
                        }
                    case 163:
                        {
                            i_163++;
                            break;
                        }
                    case 164:
                        {
                            i_164++;
                            break;
                        }
                    case 165:
                        {
                            i_165++;
                            break;
                        }
                    case 166:
                        {
                            i_166++;
                            break;
                        }
                    case 167:
                        {
                            i_167++;
                            break;
                        }
                    case 168:
                        {
                            i_168++;
                            break;
                        }
                    case 169:
                        {
                            i_169++;
                            break;
                        }
                    case 170:
                        {
                            i_170++;
                            break;
                        }
                    case 171:
                        {
                            i_171++;
                            break;
                        }
                    case 172:
                        {
                            i_172++;
                            break;
                        }
                    case 173:
                        {
                            i_173++;
                            break;
                        }
                    case 174:
                        {
                            i_174++;
                            break;
                        }
                    case 175:
                        {
                            i_175++;
                            break;
                        }
                    case 176:
                        {
                            i_176++;
                            break;
                        }
                    case 177:
                        {
                            i_177++;
                            break;
                        }
                    case 178:
                        {
                            i_178++;
                            break;
                        }
                    case 179:
                        {
                            i_179++;
                            break;
                        }
                    case 180:
                        {
                            i_180++;
                            break;
                        }
                    case 181:
                        {
                            i_181++;
                            break;
                        }
                    case 182:
                        {
                            i_182++;
                            break;
                        }
                    case 183:
                        {
                            i_183++;
                            break;
                        }
                    case 184:
                        {
                            i_184++;
                            break;
                        }
                    case 185:
                        {
                            i_185++;
                            break;
                        }
                    case 186:
                        {
                            i_186++;
                            break;
                        }
                    case 187:
                        {
                            i_187++;
                            break;
                        }
                    case 188:
                        {
                            i_188++;
                            break;
                        }
                    case 189:
                        {
                            i_189++;
                            break;
                        }
                    case 190:
                        {
                            i_190++;
                            break;
                        }
                    case 191:
                        {
                            i_191++;
                            break;
                        }
                    case 192:
                        {
                            i_192++;
                            break;
                        }
                    case 193:
                        {
                            i_193++;
                            break;
                        }
                    case 194:
                        {
                            i_194++;
                            break;
                        }
                    case 195:
                        {
                            i_195++;
                            break;
                        }
                    case 196:
                        {
                            i_196++;
                            break;
                        }
                    case 197:
                        {
                            i_197++;
                            break;
                        }
                    case 198:
                        {
                            i_198++;
                            break;
                        }
                    case 199:
                        {
                            i_199++;
                            break;
                        }
                    case 200:
                        {
                            i_200++;
                            break;
                        }
                    case 201:
                        {
                            i_201++;
                            break;
                        }
                    case 202:
                        {
                            i_202++;
                            break;
                        }
                    case 203:
                        {
                            i_203++;
                            break;
                        }
                    case 204:
                        {
                            i_204++;
                            break;
                        }
                    case 205:
                        {
                            i_205++;
                            break;
                        }
                    case 206:
                        {
                            i_206++;
                            break;
                        }
                    case 207:
                        {
                            i_207++;
                            break;
                        }
                    case 208:
                        {
                            i_208++;
                            break;
                        }
                    case 209:
                        {
                            i_209++;
                            break;
                        }
                    case 210:
                        {
                            i_210++;
                            break;
                        }
                    case 211:
                        {
                            i_211++;
                            break;
                        }
                    case 212:
                        {
                            i_212++;
                            break;
                        }
                    case 213:
                        {
                            i_213++;
                            break;
                        }
                    case 214:
                        {
                            i_214++;
                            break;
                        }
                    case 215:
                        {
                            i_215++;
                            break;
                        }
                    case 216:
                        {
                            i_216++;
                            break;
                        }
                    case 217:
                        {
                            i_217++;
                            break;
                        }
                    case 218:
                        {
                            i_218++;
                            break;
                        }
                    case 219:
                        {
                            i_219++;
                            break;
                        }
                    case 220:
                        {
                            i_220++;
                            break;
                        }
                    case 221:
                        {
                            i_221++;
                            break;
                        }
                    case 222:
                        {
                            i_222++;
                            break;
                        }
                    case 223:
                        {
                            i_223++;
                            break;
                        }
                    case 224:
                        {
                            i_224++;
                            break;
                        }
                    case 225:
                        {
                            i_225++;
                            break;
                        }
                    case 226:
                        {
                            i_226++;
                            break;
                        }
                    case 227:
                        {
                            i_227++;
                            break;
                        }
                    case 228:
                        {
                            i_228++;
                            break;
                        }
                    case 229:
                        {
                            i_229++;
                            break;
                        }
                    case 230:
                        {
                            i_230++;
                            break;
                        }
                    case 231:
                        {
                            i_231++;
                            break;
                        }
                    case 232:
                        {
                            i_232++;
                            break;
                        }
                    case 233:
                        {
                            i_233++;
                            break;
                        }
                    case 234:
                        {
                            i_234++;
                            break;
                        }
                    case 235:
                        {
                            i_235++;
                            break;
                        }
                    case 236:
                        {
                            i_236++;
                            break;
                        }
                    case 237:
                        {
                            i_237++;
                            break;
                        }
                    case 238:
                        {
                            i_238++;
                            break;
                        }
                    case 239:
                        {
                            i_239++;
                            break;
                        }
                    case 240:
                        {
                            i_240++;
                            break;
                        }
                    case 241:
                        {
                            i_241++;
                            break;
                        }
                    case 242:
                        {
                            i_242++;
                            break;
                        }
                    case 243:
                        {
                            i_243++;
                            break;
                        }
                    case 244:
                        {
                            i_244++;
                            break;
                        }
                    case 245:
                        {
                            i_245++;
                            break;
                        }
                    case 246:
                        {
                            i_246++;
                            break;
                        }
                    case 247:
                        {
                            i_247++;
                            break;
                        }
                    case 248:
                        {
                            i_248++;
                            break;
                        }
                    case 249:
                        {
                            i_249++;
                            break;
                        }
                    case 250:
                        {
                            i_250++;
                            break;
                        }
                    case 251:
                        {
                            i_251++;
                            break;
                        }
                    case 252:
                        {
                            i_252++;
                            break;
                        }
                    case 253:
                        {
                            i_253++;
                            break;
                        }
                    case 254:
                        {
                            i_254++;
                            break;
                        }
                    case 255:
                        {
                            i_255++;
                            break;
                        }
                    default:
                        break;
                }
            }
            

        }

        public unsafe static void SwitchBench2(byte* bs, int count)
        {
            int n = 0;
            for (int i = 0; i < count; i++)
            {
                switch (*(bs+i))
                {
                    case 0:
                        {
                            n++;
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
                    case 4:
                        {
                            n++;
                            break;
                        }
                    case 5:
                        {
                            n++;
                            break;
                        }
                    //case 6:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 7:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 8:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 9:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 10:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 11:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 12:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 13:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 14:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 15:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 16:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 17:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 18:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 19:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 20:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 21:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 22:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 23:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 24:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 25:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 26:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 27:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 28:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 29:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 30:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 31:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 32:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 33:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 34:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 35:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 36:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 37:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 38:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 39:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 40:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 41:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 42:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 43:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 44:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 45:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 46:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 47:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 48:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 49:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 50:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 51:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 52:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 53:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 54:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 55:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 56:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 57:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 58:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 59:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 60:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 61:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 62:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 63:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 64:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 65:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 66:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 67:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 68:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 69:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 70:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 71:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 72:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 73:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 74:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 75:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 76:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 77:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 78:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 79:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 80:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 81:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 82:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 83:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 84:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 85:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 86:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 87:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 88:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 89:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 90:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 91:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 92:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 93:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 94:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 95:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 96:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 97:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 98:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 99:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 100:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 101:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 102:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 103:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 104:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 105:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 106:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 107:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 108:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 109:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 110:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 111:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 112:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 113:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 114:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 115:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 116:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 117:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 118:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 119:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 120:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 121:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 122:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 123:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 124:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 125:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 126:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 127:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 128:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 129:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 130:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 131:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 132:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 133:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 134:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 135:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 136:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 137:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 138:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 139:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 140:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 141:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 142:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 143:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 144:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 145:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 146:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 147:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 148:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 149:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 150:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 151:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 152:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 153:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 154:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 155:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 156:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 157:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 158:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 159:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 160:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 161:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 162:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 163:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 164:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 165:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 166:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 167:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 168:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 169:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 170:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 171:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 172:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 173:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 174:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 175:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 176:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 177:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 178:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 179:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 180:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 181:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 182:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 183:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 184:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 185:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 186:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 187:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 188:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 189:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 190:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 191:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 192:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 193:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 194:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 195:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 196:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 197:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 198:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 199:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 200:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 201:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 202:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 203:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 204:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 205:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 206:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 207:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 208:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 209:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 210:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 211:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 212:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 213:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 214:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 215:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 216:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 217:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 218:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 219:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 220:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 221:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 222:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 223:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 224:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 225:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 226:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 227:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 228:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 229:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 230:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 231:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 232:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 233:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 234:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 235:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 236:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 237:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 238:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 239:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 240:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 241:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 242:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 243:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 244:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 245:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 246:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 247:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 248:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 249:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 250:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 251:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 252:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 253:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 254:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    //case 255:
                    //    {
                    //        n++;
                    //        break;
                    //    }
                    default:
                        break;
                }
            }
        }

        public unsafe static void SwitchBench3(byte[] bs, int count)
        {
            int n = 0;
            byte v = 0;
            for (int i = 0; i < count; i++)
            {
                v = bs[i];
                switch (v)
                {
                    case 0:
                        {
                            n++;
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
                    case 4:
                        {
                            n++;
                            break;
                        }
                    case 5:
                        {
                            n++;
                            break;
                        }
                    case 6:
                        {
                            n++;
                            break;
                        }
                    case 7:
                        {
                            n++;
                            break;
                        }
                    case 8:
                        {
                            n++;
                            break;
                        }
                    case 9:
                        {
                            n++;
                            break;
                        }
                    case 10:
                        {
                            n++;
                            break;
                        }
                    case 11:
                        {
                            n++;
                            break;
                        }
                    case 12:
                        {
                            n++;
                            break;
                        }
                    case 13:
                        {
                            n++;
                            break;
                        }
                    case 14:
                        {
                            n++;
                            break;
                        }
                    case 15:
                        {
                            n++;
                            break;
                        }
                    case 16:
                        {
                            n++;
                            break;
                        }
                    case 17:
                        {
                            n++;
                            break;
                        }
                    case 18:
                        {
                            n++;
                            break;
                        }
                    case 19:
                        {
                            n++;
                            break;
                        }
                    case 20:
                        {
                            n++;
                            break;
                        }
                    case 21:
                        {
                            n++;
                            break;
                        }
                    case 22:
                        {
                            n++;
                            break;
                        }
                    case 23:
                        {
                            n++;
                            break;
                        }
                    case 24:
                        {
                            n++;
                            break;
                        }
                    case 25:
                        {
                            n++;
                            break;
                        }
                    case 26:
                        {
                            n++;
                            break;
                        }
                    case 27:
                        {
                            n++;
                            break;
                        }
                    case 28:
                        {
                            n++;
                            break;
                        }
                    case 29:
                        {
                            n++;
                            break;
                        }
                    case 30:
                        {
                            n++;
                            break;
                        }
                    case 31:
                        {
                            n++;
                            break;
                        }
                    case 32:
                        {
                            n++;
                            break;
                        }
                    case 33:
                        {
                            n++;
                            break;
                        }
                    case 34:
                        {
                            n++;
                            break;
                        }
                    case 35:
                        {
                            n++;
                            break;
                        }
                    case 36:
                        {
                            n++;
                            break;
                        }
                    case 37:
                        {
                            n++;
                            break;
                        }
                    case 38:
                        {
                            n++;
                            break;
                        }
                    case 39:
                        {
                            n++;
                            break;
                        }
                    case 40:
                        {
                            n++;
                            break;
                        }
                    case 41:
                        {
                            n++;
                            break;
                        }
                    case 42:
                        {
                            n++;
                            break;
                        }
                    case 43:
                        {
                            n++;
                            break;
                        }
                    case 44:
                        {
                            n++;
                            break;
                        }
                    case 45:
                        {
                            n++;
                            break;
                        }
                    case 46:
                        {
                            n++;
                            break;
                        }
                    case 47:
                        {
                            n++;
                            break;
                        }
                    case 48:
                        {
                            n++;
                            break;
                        }
                    case 49:
                        {
                            n++;
                            break;
                        }
                    case 50:
                        {
                            n++;
                            break;
                        }
                    case 51:
                        {
                            n++;
                            break;
                        }
                    case 52:
                        {
                            n++;
                            break;
                        }
                    case 53:
                        {
                            n++;
                            break;
                        }
                    case 54:
                        {
                            n++;
                            break;
                        }
                    case 55:
                        {
                            n++;
                            break;
                        }
                    case 56:
                        {
                            n++;
                            break;
                        }
                    case 57:
                        {
                            n++;
                            break;
                        }
                    case 58:
                        {
                            n++;
                            break;
                        }
                    case 59:
                        {
                            n++;
                            break;
                        }
                    case 60:
                        {
                            n++;
                            break;
                        }
                    case 61:
                        {
                            n++;
                            break;
                        }
                    case 62:
                        {
                            n++;
                            break;
                        }
                    case 63:
                        {
                            n++;
                            break;
                        }
                    case 64:
                        {
                            n++;
                            break;
                        }
                    case 65:
                        {
                            n++;
                            break;
                        }
                    case 66:
                        {
                            n++;
                            break;
                        }
                    case 67:
                        {
                            n++;
                            break;
                        }
                    case 68:
                        {
                            n++;
                            break;
                        }
                    case 69:
                        {
                            n++;
                            break;
                        }
                    case 70:
                        {
                            n++;
                            break;
                        }
                    case 71:
                        {
                            n++;
                            break;
                        }
                    case 72:
                        {
                            n++;
                            break;
                        }
                    case 73:
                        {
                            n++;
                            break;
                        }
                    case 74:
                        {
                            n++;
                            break;
                        }
                    case 75:
                        {
                            n++;
                            break;
                        }
                    case 76:
                        {
                            n++;
                            break;
                        }
                    case 77:
                        {
                            n++;
                            break;
                        }
                    case 78:
                        {
                            n++;
                            break;
                        }
                    case 79:
                        {
                            n++;
                            break;
                        }
                    case 80:
                        {
                            n++;
                            break;
                        }
                    case 81:
                        {
                            n++;
                            break;
                        }
                    case 82:
                        {
                            n++;
                            break;
                        }
                    case 83:
                        {
                            n++;
                            break;
                        }
                    case 84:
                        {
                            n++;
                            break;
                        }
                    case 85:
                        {
                            n++;
                            break;
                        }
                    case 86:
                        {
                            n++;
                            break;
                        }
                    case 87:
                        {
                            n++;
                            break;
                        }
                    case 88:
                        {
                            n++;
                            break;
                        }
                    case 89:
                        {
                            n++;
                            break;
                        }
                    case 90:
                        {
                            n++;
                            break;
                        }
                    case 91:
                        {
                            n++;
                            break;
                        }
                    case 92:
                        {
                            n++;
                            break;
                        }
                    case 93:
                        {
                            n++;
                            break;
                        }
                    case 94:
                        {
                            n++;
                            break;
                        }
                    case 95:
                        {
                            n++;
                            break;
                        }
                    case 96:
                        {
                            n++;
                            break;
                        }
                    case 97:
                        {
                            n++;
                            break;
                        }
                    case 98:
                        {
                            n++;
                            break;
                        }
                    case 99:
                        {
                            n++;
                            break;
                        }
                    case 100:
                        {
                            n++;
                            break;
                        }
                    case 101:
                        {
                            n++;
                            break;
                        }
                    case 102:
                        {
                            n++;
                            break;
                        }
                    case 103:
                        {
                            n++;
                            break;
                        }
                    case 104:
                        {
                            n++;
                            break;
                        }
                    case 105:
                        {
                            n++;
                            break;
                        }
                    case 106:
                        {
                            n++;
                            break;
                        }
                    case 107:
                        {
                            n++;
                            break;
                        }
                    case 108:
                        {
                            n++;
                            break;
                        }
                    case 109:
                        {
                            n++;
                            break;
                        }
                    case 110:
                        {
                            n++;
                            break;
                        }
                    case 111:
                        {
                            n++;
                            break;
                        }
                    case 112:
                        {
                            n++;
                            break;
                        }
                    case 113:
                        {
                            n++;
                            break;
                        }
                    case 114:
                        {
                            n++;
                            break;
                        }
                    case 115:
                        {
                            n++;
                            break;
                        }
                    case 116:
                        {
                            n++;
                            break;
                        }
                    case 117:
                        {
                            n++;
                            break;
                        }
                    case 118:
                        {
                            n++;
                            break;
                        }
                    case 119:
                        {
                            n++;
                            break;
                        }
                    case 120:
                        {
                            n++;
                            break;
                        }
                    case 121:
                        {
                            n++;
                            break;
                        }
                    case 122:
                        {
                            n++;
                            break;
                        }
                    case 123:
                        {
                            n++;
                            break;
                        }
                    case 124:
                        {
                            n++;
                            break;
                        }
                    case 125:
                        {
                            n++;
                            break;
                        }
                    case 126:
                        {
                            n++;
                            break;
                        }
                    case 127:
                        {
                            n++;
                            break;
                        }
                    case 128:
                        {
                            n++;
                            break;
                        }
                    case 129:
                        {
                            n++;
                            break;
                        }
                    case 130:
                        {
                            n++;
                            break;
                        }
                    case 131:
                        {
                            n++;
                            break;
                        }
                    case 132:
                        {
                            n++;
                            break;
                        }
                    case 133:
                        {
                            n++;
                            break;
                        }
                    case 134:
                        {
                            n++;
                            break;
                        }
                    case 135:
                        {
                            n++;
                            break;
                        }
                    case 136:
                        {
                            n++;
                            break;
                        }
                    case 137:
                        {
                            n++;
                            break;
                        }
                    case 138:
                        {
                            n++;
                            break;
                        }
                    case 139:
                        {
                            n++;
                            break;
                        }
                    case 140:
                        {
                            n++;
                            break;
                        }
                    case 141:
                        {
                            n++;
                            break;
                        }
                    case 142:
                        {
                            n++;
                            break;
                        }
                    case 143:
                        {
                            n++;
                            break;
                        }
                    case 144:
                        {
                            n++;
                            break;
                        }
                    case 145:
                        {
                            n++;
                            break;
                        }
                    case 146:
                        {
                            n++;
                            break;
                        }
                    case 147:
                        {
                            n++;
                            break;
                        }
                    case 148:
                        {
                            n++;
                            break;
                        }
                    case 149:
                        {
                            n++;
                            break;
                        }
                    case 150:
                        {
                            n++;
                            break;
                        }
                    case 151:
                        {
                            n++;
                            break;
                        }
                    case 152:
                        {
                            n++;
                            break;
                        }
                    case 153:
                        {
                            n++;
                            break;
                        }
                    case 154:
                        {
                            n++;
                            break;
                        }
                    case 155:
                        {
                            n++;
                            break;
                        }
                    case 156:
                        {
                            n++;
                            break;
                        }
                    case 157:
                        {
                            n++;
                            break;
                        }
                    case 158:
                        {
                            n++;
                            break;
                        }
                    case 159:
                        {
                            n++;
                            break;
                        }
                    case 160:
                        {
                            n++;
                            break;
                        }
                    case 161:
                        {
                            n++;
                            break;
                        }
                    case 162:
                        {
                            n++;
                            break;
                        }
                    case 163:
                        {
                            n++;
                            break;
                        }
                    case 164:
                        {
                            n++;
                            break;
                        }
                    case 165:
                        {
                            n++;
                            break;
                        }
                    case 166:
                        {
                            n++;
                            break;
                        }
                    case 167:
                        {
                            n++;
                            break;
                        }
                    case 168:
                        {
                            n++;
                            break;
                        }
                    case 169:
                        {
                            n++;
                            break;
                        }
                    case 170:
                        {
                            n++;
                            break;
                        }
                    case 171:
                        {
                            n++;
                            break;
                        }
                    case 172:
                        {
                            n++;
                            break;
                        }
                    case 173:
                        {
                            n++;
                            break;
                        }
                    case 174:
                        {
                            n++;
                            break;
                        }
                    case 175:
                        {
                            n++;
                            break;
                        }
                    case 176:
                        {
                            n++;
                            break;
                        }
                    case 177:
                        {
                            n++;
                            break;
                        }
                    case 178:
                        {
                            n++;
                            break;
                        }
                    case 179:
                        {
                            n++;
                            break;
                        }
                    case 180:
                        {
                            n++;
                            break;
                        }
                    case 181:
                        {
                            n++;
                            break;
                        }
                    case 182:
                        {
                            n++;
                            break;
                        }
                    case 183:
                        {
                            n++;
                            break;
                        }
                    case 184:
                        {
                            n++;
                            break;
                        }
                    case 185:
                        {
                            n++;
                            break;
                        }
                    case 186:
                        {
                            n++;
                            break;
                        }
                    case 187:
                        {
                            n++;
                            break;
                        }
                    case 188:
                        {
                            n++;
                            break;
                        }
                    case 189:
                        {
                            n++;
                            break;
                        }
                    case 190:
                        {
                            n++;
                            break;
                        }
                    case 191:
                        {
                            n++;
                            break;
                        }
                    case 192:
                        {
                            n++;
                            break;
                        }
                    case 193:
                        {
                            n++;
                            break;
                        }
                    case 194:
                        {
                            n++;
                            break;
                        }
                    case 195:
                        {
                            n++;
                            break;
                        }
                    case 196:
                        {
                            n++;
                            break;
                        }
                    case 197:
                        {
                            n++;
                            break;
                        }
                    case 198:
                        {
                            n++;
                            break;
                        }
                    case 199:
                        {
                            n++;
                            break;
                        }
                    case 200:
                        {
                            n++;
                            break;
                        }
                    case 201:
                        {
                            n++;
                            break;
                        }
                    case 202:
                        {
                            n++;
                            break;
                        }
                    case 203:
                        {
                            n++;
                            break;
                        }
                    case 204:
                        {
                            n++;
                            break;
                        }
                    case 205:
                        {
                            n++;
                            break;
                        }
                    case 206:
                        {
                            n++;
                            break;
                        }
                    case 207:
                        {
                            n++;
                            break;
                        }
                    case 208:
                        {
                            n++;
                            break;
                        }
                    case 209:
                        {
                            n++;
                            break;
                        }
                    case 210:
                        {
                            n++;
                            break;
                        }
                    case 211:
                        {
                            n++;
                            break;
                        }
                    case 212:
                        {
                            n++;
                            break;
                        }
                    case 213:
                        {
                            n++;
                            break;
                        }
                    case 214:
                        {
                            n++;
                            break;
                        }
                    case 215:
                        {
                            n++;
                            break;
                        }
                    case 216:
                        {
                            n++;
                            break;
                        }
                    case 217:
                        {
                            n++;
                            break;
                        }
                    case 218:
                        {
                            n++;
                            break;
                        }
                    case 219:
                        {
                            n++;
                            break;
                        }
                    case 220:
                        {
                            n++;
                            break;
                        }
                    case 221:
                        {
                            n++;
                            break;
                        }
                    case 222:
                        {
                            n++;
                            break;
                        }
                    case 223:
                        {
                            n++;
                            break;
                        }
                    case 224:
                        {
                            n++;
                            break;
                        }
                    case 225:
                        {
                            n++;
                            break;
                        }
                    case 226:
                        {
                            n++;
                            break;
                        }
                    case 227:
                        {
                            n++;
                            break;
                        }
                    case 228:
                        {
                            n++;
                            break;
                        }
                    case 229:
                        {
                            n++;
                            break;
                        }
                    case 230:
                        {
                            n++;
                            break;
                        }
                    case 231:
                        {
                            n++;
                            break;
                        }
                    case 232:
                        {
                            n++;
                            break;
                        }
                    case 233:
                        {
                            n++;
                            break;
                        }
                    case 234:
                        {
                            n++;
                            break;
                        }
                    case 235:
                        {
                            n++;
                            break;
                        }
                    case 236:
                        {
                            n++;
                            break;
                        }
                    case 237:
                        {
                            n++;
                            break;
                        }
                    case 238:
                        {
                            n++;
                            break;
                        }
                    case 239:
                        {
                            n++;
                            break;
                        }
                    case 240:
                        {
                            n++;
                            break;
                        }
                    case 241:
                        {
                            n++;
                            break;
                        }
                    case 242:
                        {
                            n++;
                            break;
                        }
                    case 243:
                        {
                            n++;
                            break;
                        }
                    case 244:
                        {
                            n++;
                            break;
                        }
                    case 245:
                        {
                            n++;
                            break;
                        }
                    case 246:
                        {
                            n++;
                            break;
                        }
                    case 247:
                        {
                            n++;
                            break;
                        }
                    case 248:
                        {
                            n++;
                            break;
                        }
                    case 249:
                        {
                            n++;
                            break;
                        }
                    case 250:
                        {
                            n++;
                            break;
                        }
                    case 251:
                        {
                            n++;
                            break;
                        }
                    case 252:
                        {
                            n++;
                            break;
                        }
                    case 253:
                        {
                            n++;
                            break;
                        }
                    case 254:
                        {
                            n++;
                            break;
                        }
                    case 255:
                        {
                            n++;
                            break;
                        }
                    default:
                        break;
                }
            }
        }

        private unsafe static void GTop1(ArraySegment<byte>[] arrays, int[] masks, int[] rs, int count)
        {
            int* rss = stackalloc int[rs.Length];
            fixed (byte* pd = &arrays[0].Array[arrays[0].Offset])
            {
                byte* ap0 = pd;
                const int bsize = 8;
                int length = arrays[0].Count;
                int blockCount = length / bsize;
                int i = 0;
                for (; i < blockCount * bsize; i += bsize)
                {
                    rss[*(ap0 + 0)]++;
                    rss[*(ap0 + 1)]++;
                    rss[*(ap0 + 2)]++;
                    rss[*(ap0 + 3)]++;
                    rss[*(ap0 + 4)]++;
                    rss[*(ap0 + 5)]++;
                    rss[*(ap0 + 6)]++;
                    rss[*(ap0 + 7)]++;
                    ap0 += 8;
                }
                for (; i < length; i++)
                    rss[*ap0++]++;
            }
            for (int i = 0; i < rs.Length; i++)
                rs[i] += rss[i];
        }

        public unsafe static int[] Funs(byte[] arr)
        {
            //Action<int[], int>[] func = new Action<int[], int>[256];
            FFFP[] func = new FFFP[256];
            for (int i = 0; i < func.Length; i++)
                func[i] = FP;
            int[] rs = new int[256];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    func[arr[i]](rs,arr[i]);
            //}
            //return rs;

            int* rss = stackalloc int[rs.Length];
            fixed (byte* pd = &arr[0])
            {
                byte* ap0 = pd;
                const int bsize = 8;
                int length = arr.Length;
                int blockCount = length / bsize;
                int i = 0;
                for (; i < blockCount * bsize; i += bsize)
                {
                    //rss[*(ap0 + 0)]++;
                    //rss[*(ap0 + 1)]++;
                    //rss[*(ap0 + 2)]++;
                    //rss[*(ap0 + 3)]++;
                    //rss[*(ap0 + 4)]++;
                    //rss[*(ap0 + 5)]++;
                    //rss[*(ap0 + 6)]++;
                    //rss[*(ap0 + 7)]++;
                    //func[*(ap0 + 0)](rs, *(ap0 + 0));
                    //func[*(ap0 + 1)](rs, *(ap0 + 1));
                    //func[*(ap0 + 2)](rs, *(ap0 + 2));
                    //func[*(ap0 + 3)](rs, *(ap0 + 3));
                    //func[*(ap0 + 4)](rs, *(ap0 + 4));
                    //func[*(ap0 + 5)](rs, *(ap0 + 5));
                    //func[*(ap0 + 6)](rs, *(ap0 + 6));
                    //func[*(ap0 + 7)](rs, *(ap0 + 7));
                    func[*(ap0 + 0)](rss, *(ap0 + 0));
                    func[*(ap0 + 1)](rss, *(ap0 + 1));
                    func[*(ap0 + 2)](rss, *(ap0 + 2));
                    func[*(ap0 + 3)](rss, *(ap0 + 3));
                    func[*(ap0 + 4)](rss, *(ap0 + 4));
                    func[*(ap0 + 5)](rss, *(ap0 + 5));
                    func[*(ap0 + 6)](rss, *(ap0 + 6));
                    func[*(ap0 + 7)](rss, *(ap0 + 7));
                    ap0 += 8;
                }
                //for (; i < length; i++)
                //    rss[*ap0++]++;
            }
            for (int i = 0; i < rs.Length; i++)
                rs[i] += rss[i];
            return rs;
        }

        public static void F(int[] rs,int b)
        {
            rs[b]++;
        }


        public static void F2(int[] rs, int b)
        {
            rs[b]++;
        }

        public static void FF(object o)
        {
            
        }

        delegate void FFF(int[] rs, int b);

        unsafe delegate void FFFP(int* rs, int b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void FP(int* rs, int b)
        {
            rs[b]++;
        }

    }
}
