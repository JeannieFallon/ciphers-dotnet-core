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
    public class VigenereController : Controller
    {
        public VigenereText GetVigenereText(VigenereText vText)
        {
            List<int> shiftVals = CipherService.GetShiftVals(vText.KeyWord);
            int i = 0;

            while (i < vText.PlainText.Length)
            {
                for (int j = 0; j < shiftVals.Count; j++)
                {   
                    if (i >= vText.PlainText.Length)
                    {
                        break;
                    }
                    else
                    {
                        vText.StrBuild.Append(CipherService.GetCipherLetter(
                                                                vText.PlainText[i], 
                                                                shiftVals[j]));
                    }

                    i++;
                }
            }

            vText.CipherText = vText.StrBuild.ToString();
            return vText;
        }
    }
}
