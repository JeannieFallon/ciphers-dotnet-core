using System;
using System.Collections.Generic;
using System.Text;

namespace CiphersWeb.Util
{
    public class CipherConstants
    {
        #region English alphabet length & ASCII ranges
        public const int ENG_ALPHA_LEN = 26;
        public const int ENG_UPPER_FLOOR = 65;
        public const int ENG_UPPER_CEILING = 90;
        public const int ENG_LOWER_FLOOR = 97;
        public const int ENG_LOWER_CEILING = 122;
        #endregion

        #region Cipher values
        public const int ROT13_SHIFT_VAL = 13;
        #endregion
    }
}
