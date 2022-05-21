using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BabKing
{
    class Babkin
    {
        const int BITS_IN_BYTE = 8;
        const int MAX_BYTE_VALUE = 255;

        public List<BigInteger> lstDataBlocks;
        public List<(int, BigInteger)> lstDataCode;
        public int iSzBlocks;

        public static BigInteger[] arFactorial = { BigInteger.Parse("1"), BigInteger.Parse("1"), BigInteger.Parse("2"), BigInteger.Parse("6"),
            BigInteger.Parse("24"), BigInteger.Parse("120"), BigInteger.Parse("720"), BigInteger.Parse("5040"),
            BigInteger.Parse("40320"), BigInteger.Parse("362880"), BigInteger.Parse("3628800"),
            BigInteger.Parse("39916800"), BigInteger.Parse("479001600"), BigInteger.Parse("6227020800"),
            BigInteger.Parse("87178291200"), BigInteger.Parse("1307674368000"), BigInteger.Parse("20922789888000"),
            BigInteger.Parse("355687428096000"), BigInteger.Parse("6402373705728000"),
            BigInteger.Parse("121645100408832000"), BigInteger.Parse("2432902008176640000"),
            BigInteger.Parse("51090942171709440000"), BigInteger.Parse("1124000727777607680000"),
            BigInteger.Parse("25852016738884976640000"), BigInteger.Parse("620448401733239439360000"),
            BigInteger.Parse("15511210043330985984000000"), BigInteger.Parse("403291461126605635584000000"),
            BigInteger.Parse("10888869450418352160768000000"), BigInteger.Parse("304888344611713860501504000000"),
            BigInteger.Parse("8841761993739701954543616000000"), BigInteger.Parse("265252859812191058636308480000000"),
            BigInteger.Parse("8222838654177922817725562880000000"),BigInteger.Parse("263130836933693530167218012160000000"),
            BigInteger.Parse("8683317618811886495518194401280000000"),
            BigInteger.Parse("295232799039604140847618609643520000000"),
            BigInteger.Parse("10333147966386144929666651337523200000000"),
            BigInteger.Parse("371993326789901217467999448150835200000000"),
            BigInteger.Parse("13763753091226345046315979581580902400000000"),
            BigInteger.Parse("523022617466601111760007224100074291200000000"),
            BigInteger.Parse("20397882081197443358640281739902897356800000000"),
            BigInteger.Parse("815915283247897734345611269596115894272000000000"),
            BigInteger.Parse("33452526613163807108170062053440751665152000000000"),
            BigInteger.Parse("1405006117752879898543142606244511569936384000000000"),
            BigInteger.Parse("60415263063373835637355132068513997507264512000000000"),
            BigInteger.Parse("2658271574788448768043625811014615890319638528000000000"),
            BigInteger.Parse("119622220865480194561963161495657715064383733760000000000"),
            BigInteger.Parse("5502622159812088949850305428800254892961651752960000000000"),
            BigInteger.Parse("258623241511168180642964355153611979969197632389120000000000"),
            BigInteger.Parse("12413915592536072670862289047373375038521486354677760000000000"),
            BigInteger.Parse("608281864034267560872252163321295376887552831379210240000000000"),
            BigInteger.Parse("30414093201713378043612608166064768844377641568960512000000000000"),
            BigInteger.Parse("1551118753287382280224243016469303211063259720016986112000000000000"),
            BigInteger.Parse("80658175170943878571660636856403766975289505440883277824000000000000"),
            BigInteger.Parse("4274883284060025564298013753389399649690343788366813724672000000000000"),
            BigInteger.Parse("230843697339241380472092742683027581083278564571807941132288000000000000"),
            BigInteger.Parse("12696403353658275925965100847566516959580321051449436762275840000000000000"),
            BigInteger.Parse("710998587804863451854045647463724949736497978881168458687447040000000000000"),
            BigInteger.Parse("40526919504877216755680601905432322134980384796226602145184481280000000000000"),
            BigInteger.Parse("2350561331282878571829474910515074683828862318181142924420699914240000000000000"),
            BigInteger.Parse("138683118545689835737939019720389406345902876772687432540821294940160000000000000"),
            BigInteger.Parse("8320987112741390144276341183223364380754172606361245952449277696409600000000000000"),
            BigInteger.Parse("507580213877224798800856812176625227226004528988036003099405939480985600000000000000"),
            BigInteger.Parse("31469973260387937525653122354950764088012280797258232192163168247821107200000000000000"),
            BigInteger.Parse("1982608315404440064116146708361898137544773690227268628106279599612729753600000000000000"),
            BigInteger.Parse("126886932185884164103433389335161480802865516174545192198801894375214704230400000000000000"), //64!
            BigInteger.Parse("8247650592082470666723170306785496252186258551345437492922123134388955774976000000000000000"),
            BigInteger.Parse("544344939077443064003729240247842752644293064388798874532860126869671081148416000000000000000"),
            BigInteger.Parse("36471110918188685288249859096605464427167635314049524593701628500267962436943872000000000000000"),
            BigInteger.Parse("2480035542436830599600990418569171581047399201355367672371710738018221445712183296000000000000000"),
            BigInteger.Parse("171122452428141311372468338881272839092270544893520369393648040923257279754140647424000000000000000"),
            BigInteger.Parse("11978571669969891796072783721689098736458938142546425857555362864628009582789845319680000000000000000"),
            BigInteger.Parse("850478588567862317521167644239926010288584608120796235886430763388588680378079017697280000000000000000"),
            BigInteger.Parse("61234458376886086861524070385274672740778091784697328983823014963978384987221689274204160000000000000000"),
            BigInteger.Parse("4470115461512684340891257138125051110076800700282905015819080092370422104067183317016903680000000000000000"),
            BigInteger.Parse("330788544151938641225953028221253782145683251820934971170611926835411235700971565459250872320000000000000000"),
            BigInteger.Parse("24809140811395398091946477116594033660926243886570122837795894512655842677572867409443815424000000000000000000"),
            BigInteger.Parse("1885494701666050254987932260861146558230394535379329335672487982961844043495537923117729972224000000000000000000"),
            BigInteger.Parse("145183092028285869634070784086308284983740379224208358846781574688061991349156420080065207861248000000000000000000"),
            BigInteger.Parse("11324281178206297831457521158732046228731749579488251990048962825668835325234200766245086213177344000000000000000000"),
            BigInteger.Parse("894618213078297528685144171539831652069808216779571907213868063227837990693501860533361810841010176000000000000000000"),
            BigInteger.Parse("71569457046263802294811533723186532165584657342365752577109445058227039255480148842668944867280814080000000000000000000") //80
        };

        public Babkin(int szBlocks)
        {
            lstDataBlocks = new List<BigInteger>();
            lstDataCode = new List<(int, BigInteger)>();
            iSzBlocks = szBlocks;
            BigInteger uiBlockMask = (BigInteger)((1 << iSzBlocks) - 1);
        }
        public void ParseDataBlocks(Data data)
        {
            /*if (iSzBlocks > sizeof(UInt64) * BITS_IN_BYTE)
            {
                throw new Exception("Invalid size of block (must be <= 8)");
            }*/

            BigInteger tempCodeSequence = 0;
            int currentTempCodeLength = 0;
            BigInteger uiBlockMask = ((BigInteger)1 << iSzBlocks) - 1;
            BigInteger uiRemainsMask;
            List<BigInteger> lstCurrentDataBlocks = new List<BigInteger>();
            int iSzShift;

            foreach (var element in data.ArData)
            {
                tempCodeSequence <<= BITS_IN_BYTE;
                tempCodeSequence |= element;
                currentTempCodeLength += BITS_IN_BYTE;
                while (currentTempCodeLength >= iSzBlocks)
                {
                    iSzShift = currentTempCodeLength - iSzBlocks;
                    lstDataBlocks.Add((BigInteger)((tempCodeSequence & (uiBlockMask << iSzShift)) >> iSzShift));
                    uiRemainsMask = (BigInteger)((1 << iSzShift) - 1);
                    tempCodeSequence &= uiRemainsMask;
                    currentTempCodeLength -= iSzBlocks;
                }
            }

            if (currentTempCodeLength != 0)
            {
                lstDataBlocks.Add((BigInteger)(tempCodeSequence << (iSzBlocks - currentTempCodeLength)));
                Console.WriteLine(lstDataBlocks[lstDataBlocks.Count - 1]);
            }
        }

        public List<int> GetIndexOnes(BigInteger block)
        {
            List<int> lstIndexOnes = new List<int>();
            BigInteger tempData = block;
            BigInteger uiCurrentBitMask = (BigInteger)1 << (iSzBlocks - 1);

            for (int i = 1; i <= iSzBlocks; i++)
            {
                if ((tempData & uiCurrentBitMask) != 0)
                {
                    lstIndexOnes.Add(i);
                }
                tempData <<= 1;
            }
            return lstIndexOnes;
        }

        BigInteger GetNumberCombination(int n, int k)
        {
            if (n < k) return 0;
            return arFactorial[n] / (arFactorial[n - k] * arFactorial[k]);
        }

        public void CodeData()
        {
            List<int> lstIndexOnes;
            BigInteger code;
            foreach (var element in lstDataBlocks)
            {
                code = 0;
                lstIndexOnes = GetIndexOnes(element);
                for (int i = 1; i <= lstIndexOnes.Count; i++)
                {
                    code += GetNumberCombination(lstIndexOnes[i - 1] - 1, i);
                }
                lstDataCode.Add((lstIndexOnes.Count, code));
            }
        }

        public static string ConvertBigIntToBinaryStr(BigInteger bigNumber)
        {
            byte[] BigIArray = bigNumber.ToByteArray();
            return string.Concat(BigIArray.Select(b => Convert.ToString(b, 2).PadLeft(8, '0')).Reverse());
        }

        public static Babkin GetDataFromBabkinFile(string strFileName)
        {
            int k = 0;
            int lengthBk;
            BigInteger bk;
            Babkin bbk;


            using (FileStream fs = new FileStream(strFileName, FileMode.Open))
            {
                using (BinaryReader br = new BinaryReader(fs))
                {
                    bbk = new Babkin(br.ReadByte());
                    while (br.PeekChar() > -1)
                    {
                        k = br.ReadByte();
                        lengthBk = br.ReadByte();
                        bk = new BigInteger(br.ReadBytes(lengthBk));
                        bbk.lstDataCode.Add((k, bk));
                    }
                   
                }
            }

            return bbk;
        }

        public void DecodeBabkin()
        {
            List<int> lstIndexOnes = new List<int>();
            BigInteger biTempData;
            BigInteger tempNumberCombination;
            int iNumberOnes;
            int stepCounter;

            for (int listCounter = 0; listCounter < this.lstDataCode.Count; listCounter++)
            {
                stepCounter = this.iSzBlocks;
                iNumberOnes = this.lstDataCode[listCounter].Item1;
                biTempData = this.lstDataCode[listCounter].Item2;
                while (iNumberOnes != 0)
                {
                    do
                    {
                        tempNumberCombination = GetNumberCombination
                            (stepCounter - 1, iNumberOnes);
                        stepCounter--;
                    }
                    while (tempNumberCombination > biTempData);
                    biTempData -= tempNumberCombination;
                    lstIndexOnes.Add(++stepCounter);
                    iNumberOnes--;
                }

                this.lstDataBlocks.Add(0);
                foreach(var element in lstIndexOnes)
                {
                    this.lstDataBlocks[this.lstDataBlocks.Count - 1] |= 
                        ((BigInteger)1 << this.iSzBlocks - element);
                }

                lstIndexOnes.Clear();
            }
        }

        public Data BabkinToData()
        {
            Data dataResult = new Data();
            List<byte> data = new List<byte>();
            int currentBlockLength = 0;
            BigInteger currentData = 0;
            UInt64 maskByte = 0xFF;

            foreach(var element in this.lstDataBlocks)
            {
                currentData = (currentData << this.iSzBlocks) 
                    | (element);
                currentBlockLength += this.iSzBlocks;
                while (currentBlockLength > BITS_IN_BYTE)
                {
                    data.Add((byte)((currentData & ((BigInteger)maskByte << (currentBlockLength - BITS_IN_BYTE)))
                        >> (currentBlockLength - BITS_IN_BYTE)));
                    currentBlockLength -= BITS_IN_BYTE;
                }
                currentData &= (1 << currentBlockLength) - 1;
            }
            dataResult.ArData = data.ToArray();
            return dataResult;
        }

        public static int GetBigIntegerBitsLength(BigInteger biNumber)
        {
            int numberBits = 0;
            BigInteger number = biNumber;
            if(biNumber == 0 || biNumber == 1)
            {
                return 1;
            }

            do
            {
                number >>= 1;
                numberBits++;
            }
            while (number > 0);

            return numberBits;
        }

    }
}
