using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CiphersWeb.Models;

namespace CiphersWeb.Controllers
{
    public class Rot13Controller : BaseController
    {
        public Rot13Text GetRot13Text(Rot13Text rText)
        {
            foreach (char plnChar in rText.PlainText)
            {
                rText.StrBuild.Append(GetCipherLetter(plnChar, rText.Key));
            }

            rText.CipherText = rText.StrBuild.ToString();
            return rText;
        }
    }
}
