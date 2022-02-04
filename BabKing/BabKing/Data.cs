using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabKing
{
    class Data
    {
        private byte[] _arData;

        public byte[] ArData
        {
            get
            {
                return _arData;
            }
            set
            {
                _arData = value;
            }
        }

        public void GetDataFromFile(string strFileName)
        {
            try
            {
                _arData = File.ReadAllBytes(strFileName);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
