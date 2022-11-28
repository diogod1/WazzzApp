using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;
using static BCrypt.Net.BCrypt;
using System.Xml.Serialization;

namespace Wazzaaap.BLL
{
    public class Encrypt
    {
        private int _cryptkey;

        public Encrypt()
        {
            _cryptkey = 12;
        }

        public string Encrypt_string(string plainText)
        {
            var chypherText = HashPassword(plainText,_cryptkey);
            return chypherText;
        }

        public int passwords_match(string cypherText, string password)
        {
            Boolean password_match = Verify(password, cypherText);
            if(password_match == true)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}   
