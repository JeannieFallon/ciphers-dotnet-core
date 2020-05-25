using System;

namespace CiphersWeb.Models
{
    public class CaesarText : Text
    {
        public int Key { get; set; }

        public CaesarText(string plainTxt, int key) : base(plainTxt)
        {
            Key = key;
        }
    }
}
