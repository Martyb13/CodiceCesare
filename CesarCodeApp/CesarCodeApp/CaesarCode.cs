using System;
using System.Collections.Generic;
using System.Text;

namespace CaesarCipherLibrary
{
    public class CaesarCode:CaesarCipher
    {
        public string CipherText { get; set; }
        public CaesarCode(string message, int key)
        {
            Key = key;
            CipherText = DoWork(message);
        }
    }
}
