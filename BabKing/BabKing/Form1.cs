using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BabKing
{
    public partial class Form1 : Form
    {
        const int BITS_IN_BYTE = 8;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*Random rnd = new Random();
            int size = 1073741824 / 256;
            byte[] arRand = new byte[size];
            for (int i = 0; i < size; i++)
            {
                arRand[i] = Convert.ToByte(rnd.Next(0, 255));
            }
            File.WriteAllBytes("randomfil4MB.txt", arRand);*/
            /*Data primaryData = new Data();
            primaryData.GetDataFromFile("voyna-i-mir.txt");

            Babkin bbk = new Babkin(63);
            bbk.ParseDataBlocks(primaryData);
            bbk.CodeData();

            using (FileStream fs = new FileStream("BabkinResult.bbk", FileMode.Create))
            {
                using (BinaryWriter bw = new BinaryWriter(fs))
                {
                    bw.Write((byte)bbk.iSzBlocks);
                    foreach (var element in bbk.lstDataCode)
                    {
                        bw.Write((byte)element.Item1);
                        bw.Write((byte)element.Item2.ToByteArray().Length);
                        bw.Write(element.Item2.ToByteArray());
                    }
                }
            }

            Babkin resBbk = Babkin.GetDataFromBabkinFile("BabkinResult.bbk");
            resBbk.DecodeBabkin();
            Data resData = resBbk.BabkinToData();

            File.WriteAllBytes("Babkin.txt", resData.ArData);*/

        }

        private void btChooseResourceFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog OPF = new OpenFileDialog();
            if (OPF.ShowDialog() == DialogResult.OK)
            {
                tbResourceFileDir.Text = OPF.FileName;
            }
        }

        private void btChooseResultFile_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog OPF = new SaveFileDialog();
            OPF.FileName = "*.bbk";
            OPF.Filter = "Файлы bbk|*.bbk";
            if (OPF.ShowDialog() == DialogResult.OK)
            {
                tbResultFileDir.Text = OPF.FileName;
            }
        }

        private void btCoding_Click(object sender, EventArgs e)
        {
            Data primaryData = new Data();
            primaryData.GetDataFromFile(tbResourceFileDir.Text);

            Babkin bbk = new Babkin(Convert.ToInt32(tbBlockLength.Text));/*
            if(bbk.iSzBlocks > 63)
            {
                MessageBox.Show("Длина блока пока что должна быть меньше 64");
                return;
            }*/
            bbk.ParseDataBlocks(primaryData);
            bbk.CodeData();

            using (FileStream fs = new FileStream(tbResultFileDir.Text, FileMode.Create))
            {
                using (BinaryWriter bw = new BinaryWriter(fs))
                {
                    bw.Write((byte)bbk.iSzBlocks);
                    foreach (var element in bbk.lstDataCode)
                    {
                        bw.Write((byte)element.Item1);
                        bw.Write((byte)element.Item2.ToByteArray().Length);
                        bw.Write(element.Item2.ToByteArray());
                    }
                }
            }
            MessageBox.Show("Кодирование завершено");
        }

        private void btChooseResourceFileDecode_Click(object sender, EventArgs e)
        {
            OpenFileDialog OPF = new OpenFileDialog();
            OPF.Filter = "Файлы bbk|*.bbk";
            if (OPF.ShowDialog() == DialogResult.OK)
            {
                tbResourceFileDecode.Text = OPF.FileName;
            }
        }

        private void btChooseResultFileDecode_Click(object sender, EventArgs e)
        { 
            SaveFileDialog OPF = new SaveFileDialog();
            OPF.FileName = "*.txt";
            if (OPF.ShowDialog() == DialogResult.OK)
            {
                tbResultFileDecode.Text = OPF.FileName;
            }
        }

        private void btDecoding_Click(object sender, EventArgs e)
        {
            Babkin resBbk = Babkin.GetDataFromBabkinFile(tbResourceFileDecode.Text);
            resBbk.DecodeBabkin();
            Data resData = resBbk.BabkinToData();

            File.WriteAllBytes(tbResultFileDecode.Text, resData.ArData);

            MessageBox.Show("Декодирование завершено");
        }


        private void btChooseResultFileRnd_Click(object sender, EventArgs e)
        {
            SaveFileDialog OPF = new SaveFileDialog();
            OPF.FileName = "*.rnd";
            if (OPF.ShowDialog() == DialogResult.OK)
            {
                tbResultFileRnd.Text = OPF.FileName;
            }
        }

        private void btChooseResourceFileRnd_Click(object sender, EventArgs e)
        {
            OpenFileDialog OPF = new OpenFileDialog();
            OPF.Filter = "Файлы bbk|*.*";
            if (OPF.ShowDialog() == DialogResult.OK)
            {
                tbResourceFileRnd.Text = OPF.FileName;
            }
        }

        private void btGetRandom_Click(object sender, EventArgs e)
        {
            Data primaryData = new Data();
            primaryData.GetDataFromFile(tbResourceFileRnd.Text);

            Babkin bbk = new Babkin(Convert.ToInt32(tbRndLength.Text));
            bbk.ParseDataBlocks(primaryData);
            bbk.CodeData();

            using (FileStream fs = new FileStream(tbResultFileRnd.Text, FileMode.Create))
            {
                using (BinaryWriter bw = new BinaryWriter(fs))
                {
                    BigInteger tempCodeSequence = 0;
                    int currentTempCodeLength = 0;
                    BigInteger uiByteMask = 0xFF;
                    BigInteger uiRemainsMask;
                    List<BigInteger> lstCurrentDataBlocks = new List<BigInteger>();
                    int iSzShift;
                    int iBILength;

                    foreach (var element in bbk.lstDataCode)
                    {
                        iBILength = Babkin.GetBigIntegerBitsLength(element.Item2);
                        tempCodeSequence <<= iBILength;
                        tempCodeSequence |= element.Item2;
                        currentTempCodeLength += iBILength;
                        while (currentTempCodeLength > BITS_IN_BYTE)
                        {
                            iSzShift = currentTempCodeLength - BITS_IN_BYTE;
                            /*BigInteger ccc = uiByteMask << iSzShift;
                            BigInteger ddd = tempCodeSequence & (uiByteMask << iSzShift);
                            BigInteger eee = (tempCodeSequence & (uiByteMask << iSzShift)) >> iSzShift;

                            ulong aaa = (ulong)(tempCodeSequence & (uiByteMask << iSzShift)) >> iSzShift;
                            byte bbb = (byte)((tempCodeSequence & (uiByteMask << iSzShift)) >> iSzShift);*/
                            bw.Write((byte)((tempCodeSequence & (uiByteMask << iSzShift)) >> iSzShift));
                            uiRemainsMask = (BigInteger)(((BigInteger)1 << iSzShift) - 1);
                            tempCodeSequence &= uiRemainsMask;
                            currentTempCodeLength -= BITS_IN_BYTE;
                        }
                    }

                    if (currentTempCodeLength != 0)
                    {
                        bw.Write((byte)(tempCodeSequence << (BITS_IN_BYTE - currentTempCodeLength)));
                    }
                }
            }
            MessageBox.Show("Кодирование завершено");
        }
    }
}
