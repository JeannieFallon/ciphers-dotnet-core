using System;

namespace CiphersWeb.Models
{
    public class Rot13Text : Text
    {
        public int Key { get; set; }

        public Rot13Text(string plainTxt) : base(plainTxt)
        {
            Key = CipherConstants.ROT13_SHIFT_VAL;
        }
    }
}
