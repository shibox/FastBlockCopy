using System;
using System.Collections.Generic;
using System.Text;

namespace Tools
{
    public class FunsMap
    {
        public unsafe static int[] Funs(byte[] arr)
        {
            //Action<int[], int>[] func = new Action<int[], int>[256];
            FFFP[] func = new FFFP[256];
            //for (int i = 0; i < func.Length; i++)
            //    func[i] = FP;
            func[0] = FP_000;
            func[1] = FP_001;
            func[2] = FP_002;
            func[3] = FP_003;
            func[4] = FP_004;
            func[5] = FP_005;
            func[6] = FP_006;
            func[7] = FP_007;
            func[8] = FP_008;
            func[9] = FP_009;
            func[10] = FP_010;
            func[11] = FP_011;
            func[12] = FP_012;
            func[13] = FP_013;
            func[14] = FP_014;
            func[15] = FP_015;
            func[16] = FP_016;
            func[17] = FP_017;
            func[18] = FP_018;
            func[19] = FP_019;
            func[20] = FP_020;
            func[21] = FP_021;
            func[22] = FP_022;
            func[23] = FP_023;
            func[24] = FP_024;
            func[25] = FP_025;
            func[26] = FP_026;
            func[27] = FP_027;
            func[28] = FP_028;
            func[29] = FP_029;
            func[30] = FP_030;
            func[31] = FP_031;
            func[32] = FP_032;
            func[33] = FP_033;
            func[34] = FP_034;
            func[35] = FP_035;
            func[36] = FP_036;
            func[37] = FP_037;
            func[38] = FP_038;
            func[39] = FP_039;
            func[40] = FP_040;
            func[41] = FP_041;
            func[42] = FP_042;
            func[43] = FP_043;
            func[44] = FP_044;
            func[45] = FP_045;
            func[46] = FP_046;
            func[47] = FP_047;
            func[48] = FP_048;
            func[49] = FP_049;
            func[50] = FP_050;
            func[51] = FP_051;
            func[52] = FP_052;
            func[53] = FP_053;
            func[54] = FP_054;
            func[55] = FP_055;
            func[56] = FP_056;
            func[57] = FP_057;
            func[58] = FP_058;
            func[59] = FP_059;
            func[60] = FP_060;
            func[61] = FP_061;
            func[62] = FP_062;
            func[63] = FP_063;
            func[64] = FP_064;
            func[65] = FP_065;
            func[66] = FP_066;
            func[67] = FP_067;
            func[68] = FP_068;
            func[69] = FP_069;
            func[70] = FP_070;
            func[71] = FP_071;
            func[72] = FP_072;
            func[73] = FP_073;
            func[74] = FP_074;
            func[75] = FP_075;
            func[76] = FP_076;
            func[77] = FP_077;
            func[78] = FP_078;
            func[79] = FP_079;
            func[80] = FP_080;
            func[81] = FP_081;
            func[82] = FP_082;
            func[83] = FP_083;
            func[84] = FP_084;
            func[85] = FP_085;
            func[86] = FP_086;
            func[87] = FP_087;
            func[88] = FP_088;
            func[89] = FP_089;
            func[90] = FP_090;
            func[91] = FP_091;
            func[92] = FP_092;
            func[93] = FP_093;
            func[94] = FP_094;
            func[95] = FP_095;
            func[96] = FP_096;
            func[97] = FP_097;
            func[98] = FP_098;
            func[99] = FP_099;
            func[100] = FP_100;
            func[101] = FP_101;
            func[102] = FP_102;
            func[103] = FP_103;
            func[104] = FP_104;
            func[105] = FP_105;
            func[106] = FP_106;
            func[107] = FP_107;
            func[108] = FP_108;
            func[109] = FP_109;
            func[110] = FP_110;
            func[111] = FP_111;
            func[112] = FP_112;
            func[113] = FP_113;
            func[114] = FP_114;
            func[115] = FP_115;
            func[116] = FP_116;
            func[117] = FP_117;
            func[118] = FP_118;
            func[119] = FP_119;
            func[120] = FP_120;
            func[121] = FP_121;
            func[122] = FP_122;
            func[123] = FP_123;
            func[124] = FP_124;
            func[125] = FP_125;
            func[126] = FP_126;
            func[127] = FP_127;
            func[128] = FP_128;
            func[129] = FP_129;
            func[130] = FP_130;
            func[131] = FP_131;
            func[132] = FP_132;
            func[133] = FP_133;
            func[134] = FP_134;
            func[135] = FP_135;
            func[136] = FP_136;
            func[137] = FP_137;
            func[138] = FP_138;
            func[139] = FP_139;
            func[140] = FP_140;
            func[141] = FP_141;
            func[142] = FP_142;
            func[143] = FP_143;
            func[144] = FP_144;
            func[145] = FP_145;
            func[146] = FP_146;
            func[147] = FP_147;
            func[148] = FP_148;
            func[149] = FP_149;
            func[150] = FP_150;
            func[151] = FP_151;
            func[152] = FP_152;
            func[153] = FP_153;
            func[154] = FP_154;
            func[155] = FP_155;
            func[156] = FP_156;
            func[157] = FP_157;
            func[158] = FP_158;
            func[159] = FP_159;
            func[160] = FP_160;
            func[161] = FP_161;
            func[162] = FP_162;
            func[163] = FP_163;
            func[164] = FP_164;
            func[165] = FP_165;
            func[166] = FP_166;
            func[167] = FP_167;
            func[168] = FP_168;
            func[169] = FP_169;
            func[170] = FP_170;
            func[171] = FP_171;
            func[172] = FP_172;
            func[173] = FP_173;
            func[174] = FP_174;
            func[175] = FP_175;
            func[176] = FP_176;
            func[177] = FP_177;
            func[178] = FP_178;
            func[179] = FP_179;
            func[180] = FP_180;
            func[181] = FP_181;
            func[182] = FP_182;
            func[183] = FP_183;
            func[184] = FP_184;
            func[185] = FP_185;
            func[186] = FP_186;
            func[187] = FP_187;
            func[188] = FP_188;
            func[189] = FP_189;
            func[190] = FP_190;
            func[191] = FP_191;
            func[192] = FP_192;
            func[193] = FP_193;
            func[194] = FP_194;
            func[195] = FP_195;
            func[196] = FP_196;
            func[197] = FP_197;
            func[198] = FP_198;
            func[199] = FP_199;
            func[200] = FP_200;
            func[201] = FP_201;
            func[202] = FP_202;
            func[203] = FP_203;
            func[204] = FP_204;
            func[205] = FP_205;
            func[206] = FP_206;
            func[207] = FP_207;
            func[208] = FP_208;
            func[209] = FP_209;
            func[210] = FP_210;
            func[211] = FP_211;
            func[212] = FP_212;
            func[213] = FP_213;
            func[214] = FP_214;
            func[215] = FP_215;
            func[216] = FP_216;
            func[217] = FP_217;
            func[218] = FP_218;
            func[219] = FP_219;
            func[220] = FP_220;
            func[221] = FP_221;
            func[222] = FP_222;
            func[223] = FP_223;
            func[224] = FP_224;
            func[225] = FP_225;
            func[226] = FP_226;
            func[227] = FP_227;
            func[228] = FP_228;
            func[229] = FP_229;
            func[230] = FP_230;
            func[231] = FP_231;
            func[232] = FP_232;
            func[233] = FP_233;
            func[234] = FP_234;
            func[235] = FP_235;
            func[236] = FP_236;
            func[237] = FP_237;
            func[238] = FP_238;
            func[239] = FP_239;
            func[240] = FP_240;
            func[241] = FP_241;
            func[242] = FP_242;
            func[243] = FP_243;
            func[244] = FP_244;
            func[245] = FP_245;
            func[246] = FP_246;
            func[247] = FP_247;
            func[248] = FP_248;
            func[249] = FP_249;
            func[250] = FP_250;
            func[251] = FP_251;
            func[252] = FP_252;
            func[253] = FP_253;
            func[254] = FP_254;
            func[255] = FP_255;


            int[] rs = new int[256];
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
                    func[*(ap0 + 0)](rss);
                    func[*(ap0 + 1)](rss);
                    func[*(ap0 + 2)](rss);
                    func[*(ap0 + 3)](rss);
                    func[*(ap0 + 4)](rss);
                    func[*(ap0 + 5)](rss);
                    func[*(ap0 + 6)](rss);
                    func[*(ap0 + 7)](rss);
                    ap0 += 8;
                }
            }
            for (int i = 0; i < rs.Length; i++)
                rs[i] += rss[i];
            return rs;
        }

        unsafe delegate void FFFP(int* rs);

        public unsafe static void FP_000(int* rs)
        {
            rs[0]++;
        }
        public unsafe static void FP_001(int* rs)
        {
            rs[1]++;
        }
        public unsafe static void FP_002(int* rs)
        {
            rs[2]++;
        }
        public unsafe static void FP_003(int* rs)
        {
            rs[3]++;
        }
        public unsafe static void FP_004(int* rs)
        {
            rs[4]++;
        }
        public unsafe static void FP_005(int* rs)
        {
            rs[5]++;
        }
        public unsafe static void FP_006(int* rs)
        {
            rs[6]++;
        }
        public unsafe static void FP_007(int* rs)
        {
            rs[7]++;
        }
        public unsafe static void FP_008(int* rs)
        {
            rs[8]++;
        }
        public unsafe static void FP_009(int* rs)
        {
            rs[9]++;
        }
        public unsafe static void FP_010(int* rs)
        {
            rs[10]++;
        }
        public unsafe static void FP_011(int* rs)
        {
            rs[11]++;
        }
        public unsafe static void FP_012(int* rs)
        {
            rs[12]++;
        }
        public unsafe static void FP_013(int* rs)
        {
            rs[13]++;
        }
        public unsafe static void FP_014(int* rs)
        {
            rs[14]++;
        }
        public unsafe static void FP_015(int* rs)
        {
            rs[15]++;
        }
        public unsafe static void FP_016(int* rs)
        {
            rs[16]++;
        }
        public unsafe static void FP_017(int* rs)
        {
            rs[17]++;
        }
        public unsafe static void FP_018(int* rs)
        {
            rs[18]++;
        }
        public unsafe static void FP_019(int* rs)
        {
            rs[19]++;
        }
        public unsafe static void FP_020(int* rs)
        {
            rs[20]++;
        }
        public unsafe static void FP_021(int* rs)
        {
            rs[21]++;
        }
        public unsafe static void FP_022(int* rs)
        {
            rs[22]++;
        }
        public unsafe static void FP_023(int* rs)
        {
            rs[23]++;
        }
        public unsafe static void FP_024(int* rs)
        {
            rs[24]++;
        }
        public unsafe static void FP_025(int* rs)
        {
            rs[25]++;
        }
        public unsafe static void FP_026(int* rs)
        {
            rs[26]++;
        }
        public unsafe static void FP_027(int* rs)
        {
            rs[27]++;
        }
        public unsafe static void FP_028(int* rs)
        {
            rs[28]++;
        }
        public unsafe static void FP_029(int* rs)
        {
            rs[29]++;
        }
        public unsafe static void FP_030(int* rs)
        {
            rs[30]++;
        }
        public unsafe static void FP_031(int* rs)
        {
            rs[31]++;
        }
        public unsafe static void FP_032(int* rs)
        {
            rs[32]++;
        }
        public unsafe static void FP_033(int* rs)
        {
            rs[33]++;
        }
        public unsafe static void FP_034(int* rs)
        {
            rs[34]++;
        }
        public unsafe static void FP_035(int* rs)
        {
            rs[35]++;
        }
        public unsafe static void FP_036(int* rs)
        {
            rs[36]++;
        }
        public unsafe static void FP_037(int* rs)
        {
            rs[37]++;
        }
        public unsafe static void FP_038(int* rs)
        {
            rs[38]++;
        }
        public unsafe static void FP_039(int* rs)
        {
            rs[39]++;
        }
        public unsafe static void FP_040(int* rs)
        {
            rs[40]++;
        }
        public unsafe static void FP_041(int* rs)
        {
            rs[41]++;
        }
        public unsafe static void FP_042(int* rs)
        {
            rs[42]++;
        }
        public unsafe static void FP_043(int* rs)
        {
            rs[43]++;
        }
        public unsafe static void FP_044(int* rs)
        {
            rs[44]++;
        }
        public unsafe static void FP_045(int* rs)
        {
            rs[45]++;
        }
        public unsafe static void FP_046(int* rs)
        {
            rs[46]++;
        }
        public unsafe static void FP_047(int* rs)
        {
            rs[47]++;
        }
        public unsafe static void FP_048(int* rs)
        {
            rs[48]++;
        }
        public unsafe static void FP_049(int* rs)
        {
            rs[49]++;
        }
        public unsafe static void FP_050(int* rs)
        {
            rs[50]++;
        }
        public unsafe static void FP_051(int* rs)
        {
            rs[51]++;
        }
        public unsafe static void FP_052(int* rs)
        {
            rs[52]++;
        }
        public unsafe static void FP_053(int* rs)
        {
            rs[53]++;
        }
        public unsafe static void FP_054(int* rs)
        {
            rs[54]++;
        }
        public unsafe static void FP_055(int* rs)
        {
            rs[55]++;
        }
        public unsafe static void FP_056(int* rs)
        {
            rs[56]++;
        }
        public unsafe static void FP_057(int* rs)
        {
            rs[57]++;
        }
        public unsafe static void FP_058(int* rs)
        {
            rs[58]++;
        }
        public unsafe static void FP_059(int* rs)
        {
            rs[59]++;
        }
        public unsafe static void FP_060(int* rs)
        {
            rs[60]++;
        }
        public unsafe static void FP_061(int* rs)
        {
            rs[61]++;
        }
        public unsafe static void FP_062(int* rs)
        {
            rs[62]++;
        }
        public unsafe static void FP_063(int* rs)
        {
            rs[63]++;
        }
        public unsafe static void FP_064(int* rs)
        {
            rs[64]++;
        }
        public unsafe static void FP_065(int* rs)
        {
            rs[65]++;
        }
        public unsafe static void FP_066(int* rs)
        {
            rs[66]++;
        }
        public unsafe static void FP_067(int* rs)
        {
            rs[67]++;
        }
        public unsafe static void FP_068(int* rs)
        {
            rs[68]++;
        }
        public unsafe static void FP_069(int* rs)
        {
            rs[69]++;
        }
        public unsafe static void FP_070(int* rs)
        {
            rs[70]++;
        }
        public unsafe static void FP_071(int* rs)
        {
            rs[71]++;
        }
        public unsafe static void FP_072(int* rs)
        {
            rs[72]++;
        }
        public unsafe static void FP_073(int* rs)
        {
            rs[73]++;
        }
        public unsafe static void FP_074(int* rs)
        {
            rs[74]++;
        }
        public unsafe static void FP_075(int* rs)
        {
            rs[75]++;
        }
        public unsafe static void FP_076(int* rs)
        {
            rs[76]++;
        }
        public unsafe static void FP_077(int* rs)
        {
            rs[77]++;
        }
        public unsafe static void FP_078(int* rs)
        {
            rs[78]++;
        }
        public unsafe static void FP_079(int* rs)
        {
            rs[79]++;
        }
        public unsafe static void FP_080(int* rs)
        {
            rs[80]++;
        }
        public unsafe static void FP_081(int* rs)
        {
            rs[81]++;
        }
        public unsafe static void FP_082(int* rs)
        {
            rs[82]++;
        }
        public unsafe static void FP_083(int* rs)
        {
            rs[83]++;
        }
        public unsafe static void FP_084(int* rs)
        {
            rs[84]++;
        }
        public unsafe static void FP_085(int* rs)
        {
            rs[85]++;
        }
        public unsafe static void FP_086(int* rs)
        {
            rs[86]++;
        }
        public unsafe static void FP_087(int* rs)
        {
            rs[87]++;
        }
        public unsafe static void FP_088(int* rs)
        {
            rs[88]++;
        }
        public unsafe static void FP_089(int* rs)
        {
            rs[89]++;
        }
        public unsafe static void FP_090(int* rs)
        {
            rs[90]++;
        }
        public unsafe static void FP_091(int* rs)
        {
            rs[91]++;
        }
        public unsafe static void FP_092(int* rs)
        {
            rs[92]++;
        }
        public unsafe static void FP_093(int* rs)
        {
            rs[93]++;
        }
        public unsafe static void FP_094(int* rs)
        {
            rs[94]++;
        }
        public unsafe static void FP_095(int* rs)
        {
            rs[95]++;
        }
        public unsafe static void FP_096(int* rs)
        {
            rs[96]++;
        }
        public unsafe static void FP_097(int* rs)
        {
            rs[97]++;
        }
        public unsafe static void FP_098(int* rs)
        {
            rs[98]++;
        }
        public unsafe static void FP_099(int* rs)
        {
            rs[99]++;
        }
        public unsafe static void FP_100(int* rs)
        {
            rs[100]++;
        }
        public unsafe static void FP_101(int* rs)
        {
            rs[101]++;
        }
        public unsafe static void FP_102(int* rs)
        {
            rs[102]++;
        }
        public unsafe static void FP_103(int* rs)
        {
            rs[103]++;
        }
        public unsafe static void FP_104(int* rs)
        {
            rs[104]++;
        }
        public unsafe static void FP_105(int* rs)
        {
            rs[105]++;
        }
        public unsafe static void FP_106(int* rs)
        {
            rs[106]++;
        }
        public unsafe static void FP_107(int* rs)
        {
            rs[107]++;
        }
        public unsafe static void FP_108(int* rs)
        {
            rs[108]++;
        }
        public unsafe static void FP_109(int* rs)
        {
            rs[109]++;
        }
        public unsafe static void FP_110(int* rs)
        {
            rs[110]++;
        }
        public unsafe static void FP_111(int* rs)
        {
            rs[111]++;
        }
        public unsafe static void FP_112(int* rs)
        {
            rs[112]++;
        }
        public unsafe static void FP_113(int* rs)
        {
            rs[113]++;
        }
        public unsafe static void FP_114(int* rs)
        {
            rs[114]++;
        }
        public unsafe static void FP_115(int* rs)
        {
            rs[115]++;
        }
        public unsafe static void FP_116(int* rs)
        {
            rs[116]++;
        }
        public unsafe static void FP_117(int* rs)
        {
            rs[117]++;
        }
        public unsafe static void FP_118(int* rs)
        {
            rs[118]++;
        }
        public unsafe static void FP_119(int* rs)
        {
            rs[119]++;
        }
        public unsafe static void FP_120(int* rs)
        {
            rs[120]++;
        }
        public unsafe static void FP_121(int* rs)
        {
            rs[121]++;
        }
        public unsafe static void FP_122(int* rs)
        {
            rs[122]++;
        }
        public unsafe static void FP_123(int* rs)
        {
            rs[123]++;
        }
        public unsafe static void FP_124(int* rs)
        {
            rs[124]++;
        }
        public unsafe static void FP_125(int* rs)
        {
            rs[125]++;
        }
        public unsafe static void FP_126(int* rs)
        {
            rs[126]++;
        }
        public unsafe static void FP_127(int* rs)
        {
            rs[127]++;
        }
        public unsafe static void FP_128(int* rs)
        {
            rs[128]++;
        }
        public unsafe static void FP_129(int* rs)
        {
            rs[129]++;
        }
        public unsafe static void FP_130(int* rs)
        {
            rs[130]++;
        }
        public unsafe static void FP_131(int* rs)
        {
            rs[131]++;
        }
        public unsafe static void FP_132(int* rs)
        {
            rs[132]++;
        }
        public unsafe static void FP_133(int* rs)
        {
            rs[133]++;
        }
        public unsafe static void FP_134(int* rs)
        {
            rs[134]++;
        }
        public unsafe static void FP_135(int* rs)
        {
            rs[135]++;
        }
        public unsafe static void FP_136(int* rs)
        {
            rs[136]++;
        }
        public unsafe static void FP_137(int* rs)
        {
            rs[137]++;
        }
        public unsafe static void FP_138(int* rs)
        {
            rs[138]++;
        }
        public unsafe static void FP_139(int* rs)
        {
            rs[139]++;
        }
        public unsafe static void FP_140(int* rs)
        {
            rs[140]++;
        }
        public unsafe static void FP_141(int* rs)
        {
            rs[141]++;
        }
        public unsafe static void FP_142(int* rs)
        {
            rs[142]++;
        }
        public unsafe static void FP_143(int* rs)
        {
            rs[143]++;
        }
        public unsafe static void FP_144(int* rs)
        {
            rs[144]++;
        }
        public unsafe static void FP_145(int* rs)
        {
            rs[145]++;
        }
        public unsafe static void FP_146(int* rs)
        {
            rs[146]++;
        }
        public unsafe static void FP_147(int* rs)
        {
            rs[147]++;
        }
        public unsafe static void FP_148(int* rs)
        {
            rs[148]++;
        }
        public unsafe static void FP_149(int* rs)
        {
            rs[149]++;
        }
        public unsafe static void FP_150(int* rs)
        {
            rs[150]++;
        }
        public unsafe static void FP_151(int* rs)
        {
            rs[151]++;
        }
        public unsafe static void FP_152(int* rs)
        {
            rs[152]++;
        }
        public unsafe static void FP_153(int* rs)
        {
            rs[153]++;
        }
        public unsafe static void FP_154(int* rs)
        {
            rs[154]++;
        }
        public unsafe static void FP_155(int* rs)
        {
            rs[155]++;
        }
        public unsafe static void FP_156(int* rs)
        {
            rs[156]++;
        }
        public unsafe static void FP_157(int* rs)
        {
            rs[157]++;
        }
        public unsafe static void FP_158(int* rs)
        {
            rs[158]++;
        }
        public unsafe static void FP_159(int* rs)
        {
            rs[159]++;
        }
        public unsafe static void FP_160(int* rs)
        {
            rs[160]++;
        }
        public unsafe static void FP_161(int* rs)
        {
            rs[161]++;
        }
        public unsafe static void FP_162(int* rs)
        {
            rs[162]++;
        }
        public unsafe static void FP_163(int* rs)
        {
            rs[163]++;
        }
        public unsafe static void FP_164(int* rs)
        {
            rs[164]++;
        }
        public unsafe static void FP_165(int* rs)
        {
            rs[165]++;
        }
        public unsafe static void FP_166(int* rs)
        {
            rs[166]++;
        }
        public unsafe static void FP_167(int* rs)
        {
            rs[167]++;
        }
        public unsafe static void FP_168(int* rs)
        {
            rs[168]++;
        }
        public unsafe static void FP_169(int* rs)
        {
            rs[169]++;
        }
        public unsafe static void FP_170(int* rs)
        {
            rs[170]++;
        }
        public unsafe static void FP_171(int* rs)
        {
            rs[171]++;
        }
        public unsafe static void FP_172(int* rs)
        {
            rs[172]++;
        }
        public unsafe static void FP_173(int* rs)
        {
            rs[173]++;
        }
        public unsafe static void FP_174(int* rs)
        {
            rs[174]++;
        }
        public unsafe static void FP_175(int* rs)
        {
            rs[175]++;
        }
        public unsafe static void FP_176(int* rs)
        {
            rs[176]++;
        }
        public unsafe static void FP_177(int* rs)
        {
            rs[177]++;
        }
        public unsafe static void FP_178(int* rs)
        {
            rs[178]++;
        }
        public unsafe static void FP_179(int* rs)
        {
            rs[179]++;
        }
        public unsafe static void FP_180(int* rs)
        {
            rs[180]++;
        }
        public unsafe static void FP_181(int* rs)
        {
            rs[181]++;
        }
        public unsafe static void FP_182(int* rs)
        {
            rs[182]++;
        }
        public unsafe static void FP_183(int* rs)
        {
            rs[183]++;
        }
        public unsafe static void FP_184(int* rs)
        {
            rs[184]++;
        }
        public unsafe static void FP_185(int* rs)
        {
            rs[185]++;
        }
        public unsafe static void FP_186(int* rs)
        {
            rs[186]++;
        }
        public unsafe static void FP_187(int* rs)
        {
            rs[187]++;
        }
        public unsafe static void FP_188(int* rs)
        {
            rs[188]++;
        }
        public unsafe static void FP_189(int* rs)
        {
            rs[189]++;
        }
        public unsafe static void FP_190(int* rs)
        {
            rs[190]++;
        }
        public unsafe static void FP_191(int* rs)
        {
            rs[191]++;
        }
        public unsafe static void FP_192(int* rs)
        {
            rs[192]++;
        }
        public unsafe static void FP_193(int* rs)
        {
            rs[193]++;
        }
        public unsafe static void FP_194(int* rs)
        {
            rs[194]++;
        }
        public unsafe static void FP_195(int* rs)
        {
            rs[195]++;
        }
        public unsafe static void FP_196(int* rs)
        {
            rs[196]++;
        }
        public unsafe static void FP_197(int* rs)
        {
            rs[197]++;
        }
        public unsafe static void FP_198(int* rs)
        {
            rs[198]++;
        }
        public unsafe static void FP_199(int* rs)
        {
            rs[199]++;
        }
        public unsafe static void FP_200(int* rs)
        {
            rs[200]++;
        }
        public unsafe static void FP_201(int* rs)
        {
            rs[201]++;
        }
        public unsafe static void FP_202(int* rs)
        {
            rs[202]++;
        }
        public unsafe static void FP_203(int* rs)
        {
            rs[203]++;
        }
        public unsafe static void FP_204(int* rs)
        {
            rs[204]++;
        }
        public unsafe static void FP_205(int* rs)
        {
            rs[205]++;
        }
        public unsafe static void FP_206(int* rs)
        {
            rs[206]++;
        }
        public unsafe static void FP_207(int* rs)
        {
            rs[207]++;
        }
        public unsafe static void FP_208(int* rs)
        {
            rs[208]++;
        }
        public unsafe static void FP_209(int* rs)
        {
            rs[209]++;
        }
        public unsafe static void FP_210(int* rs)
        {
            rs[210]++;
        }
        public unsafe static void FP_211(int* rs)
        {
            rs[211]++;
        }
        public unsafe static void FP_212(int* rs)
        {
            rs[212]++;
        }
        public unsafe static void FP_213(int* rs)
        {
            rs[213]++;
        }
        public unsafe static void FP_214(int* rs)
        {
            rs[214]++;
        }
        public unsafe static void FP_215(int* rs)
        {
            rs[215]++;
        }
        public unsafe static void FP_216(int* rs)
        {
            rs[216]++;
        }
        public unsafe static void FP_217(int* rs)
        {
            rs[217]++;
        }
        public unsafe static void FP_218(int* rs)
        {
            rs[218]++;
        }
        public unsafe static void FP_219(int* rs)
        {
            rs[219]++;
        }
        public unsafe static void FP_220(int* rs)
        {
            rs[220]++;
        }
        public unsafe static void FP_221(int* rs)
        {
            rs[221]++;
        }
        public unsafe static void FP_222(int* rs)
        {
            rs[222]++;
        }
        public unsafe static void FP_223(int* rs)
        {
            rs[223]++;
        }
        public unsafe static void FP_224(int* rs)
        {
            rs[224]++;
        }
        public unsafe static void FP_225(int* rs)
        {
            rs[225]++;
        }
        public unsafe static void FP_226(int* rs)
        {
            rs[226]++;
        }
        public unsafe static void FP_227(int* rs)
        {
            rs[227]++;
        }
        public unsafe static void FP_228(int* rs)
        {
            rs[228]++;
        }
        public unsafe static void FP_229(int* rs)
        {
            rs[229]++;
        }
        public unsafe static void FP_230(int* rs)
        {
            rs[230]++;
        }
        public unsafe static void FP_231(int* rs)
        {
            rs[231]++;
        }
        public unsafe static void FP_232(int* rs)
        {
            rs[232]++;
        }
        public unsafe static void FP_233(int* rs)
        {
            rs[233]++;
        }
        public unsafe static void FP_234(int* rs)
        {
            rs[234]++;
        }
        public unsafe static void FP_235(int* rs)
        {
            rs[235]++;
        }
        public unsafe static void FP_236(int* rs)
        {
            rs[236]++;
        }
        public unsafe static void FP_237(int* rs)
        {
            rs[237]++;
        }
        public unsafe static void FP_238(int* rs)
        {
            rs[238]++;
        }
        public unsafe static void FP_239(int* rs)
        {
            rs[239]++;
        }
        public unsafe static void FP_240(int* rs)
        {
            rs[240]++;
        }
        public unsafe static void FP_241(int* rs)
        {
            rs[241]++;
        }
        public unsafe static void FP_242(int* rs)
        {
            rs[242]++;
        }
        public unsafe static void FP_243(int* rs)
        {
            rs[243]++;
        }
        public unsafe static void FP_244(int* rs)
        {
            rs[244]++;
        }
        public unsafe static void FP_245(int* rs)
        {
            rs[245]++;
        }
        public unsafe static void FP_246(int* rs)
        {
            rs[246]++;
        }
        public unsafe static void FP_247(int* rs)
        {
            rs[247]++;
        }
        public unsafe static void FP_248(int* rs)
        {
            rs[248]++;
        }
        public unsafe static void FP_249(int* rs)
        {
            rs[249]++;
        }
        public unsafe static void FP_250(int* rs)
        {
            rs[250]++;
        }
        public unsafe static void FP_251(int* rs)
        {
            rs[251]++;
        }
        public unsafe static void FP_252(int* rs)
        {
            rs[252]++;
        }
        public unsafe static void FP_253(int* rs)
        {
            rs[253]++;
        }
        public unsafe static void FP_254(int* rs)
        {
            rs[254]++;
        }
        public unsafe static void FP_255(int* rs)
        {
            rs[255]++;
        }


    }
}
