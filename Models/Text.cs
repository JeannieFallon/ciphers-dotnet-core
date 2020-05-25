using System;

namespace CiphersWeb.Models
{
    public abstract class Text
    {
        public string PlainText { get; set; }
        public string CipherText { get; set; }

        //TODO is this a terrible idea?
        public StringBuilder StrBuild { get; set; }

        public Text(string plainText)
        {
            StrBuild = new StringBuilder();
            PlainText = plainText;
        }
    }
}
