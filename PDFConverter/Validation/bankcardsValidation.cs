using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Validation
{
    public class bankcardsValidation
    {
        public string MatchCard(string cardnumber)
        {
            string bank;
            Regex Visa = new Regex(@"^4[0-9]{12}(?:[0-9]{3})?$");
            Regex MasterCard = new Regex(@"^5[1-5][0-9]{14}$");
            Regex AmericanExpress = new Regex(@"^3[47][0-9]{13}$");
            Regex DinersClub = new Regex(@"^3(?:0[0-5]|[68][0-9])[0-9]{11}$");
            Regex Discover = new Regex(@"^6(?:0110[0-9]|011[2-4][0-9]|01174|0117[7-9]|0118[6-9]|0119[‌​0-9]|4[4-9][0-9]{3}|‌​5[0-9]{4})[0-9]{10}$");
            Regex JCB = new Regex(@"^(?:2131|1800|35\d{3})\d{11}$");
            Regex Debit = new Regex(@"^(6767|6334)(-\d{4}){3}($|\d{2,3}$)");

            if (Visa.Match(cardnumber).Success == true)
                bank = "Visa";
            else if (MasterCard.Match(cardnumber).Success == true)
                bank = "Master Card";
            else if (AmericanExpress.Match(cardnumber).Success == true)
                bank = "American Express";
            else if (DinersClub.Match(cardnumber).Success == true)
                bank = "Diners Club";
            else if (Discover.Match(cardnumber).Success == true)
                bank = "Discover";
            else if (JCB.Match(cardnumber).Success == true)
                bank = "JCB";
            else if (Debit.Match(cardnumber).Success == true)
                bank = "Standard Debit Card";
            else
                bank = "Unknown";

                return bank;
        }
    }
}
