using System;

namespace CiphersWeb.Models
{
    public class VigenereText : Text
    {
        public string KeyWord { get; set; }

        public VigenereText(string plainTxt, string keyWord) : base(plainTxt)
        {
            KeyWord = keyWord;
        }
    }
}
