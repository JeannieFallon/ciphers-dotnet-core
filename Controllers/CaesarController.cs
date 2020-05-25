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
    public class CaesarController : BaseController
    {
        public CaesarText GetCaesarText(CaesarText cText)
        {
            int shiftVal = cText.Key;
            foreach (char plnChar in cText.PlainText)
            {
                cText.StrBuild.Append(GetCipherLetter(plnChar, shiftVal));
            }

            cText.CipherText = cText.StrBuild.ToString();
            return cText;
        }
    }
}
