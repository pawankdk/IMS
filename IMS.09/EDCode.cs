using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace IMS._09
{
    class EDCode
    {
        public string PassED(string data)
        {
            SHA1 sha = SHA1.Create();
            byte[] EDdata = sha.ComputeHash(Encoding.Default.GetBytes(data));
            StringBuilder returnValue = new StringBuilder();
            for (int i = 0; i < EDdata.Length; i++)
            {
                returnValue.Append(EDdata[i].ToString());
            }
            return returnValue.ToString();
        }
    }
}
