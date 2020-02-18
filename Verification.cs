using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace tpGestionBibliothèque
{
    static class Verification
    {
        public static bool IsAlphaWithCapitalFirst(string ch)
        {
            if (string.IsNullOrWhiteSpace(ch))
                return false;
            return Regex.Match(ch, "^[A-Z][a-zA-Z]*$").Success;
        }
        public static bool IsAlphabetic(string ch)
        {
            if (string.IsNullOrWhiteSpace(ch))
                return false;
            return Regex.Match(ch, "^[a-zA-Z]*$").Success;
        }

        public static Boolean isAlphaNumeric(string ch)
        {
            if (string.IsNullOrWhiteSpace(ch))
                return false;
            Regex rg = new Regex(@"^[a-zA-Z0-9\s,]*$");
            return rg.IsMatch(ch);
        }
        public static bool IsAdress(string ch)
        {
            if (string.IsNullOrWhiteSpace(ch))
                return false;
            return Regex.Match(ch, @"^[0-9]+\s+([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$").Success;
        }
        public static bool IsZipCode(string ch)
        {
            if (string.IsNullOrWhiteSpace(ch))
                return false;
            return Regex.Match(ch, @"^\d{4}$").Success;
        }
        public static bool IsPhoneNumber(string ch)
        {
            if (string.IsNullOrWhiteSpace(ch))
                return false;
            return Regex.Match(ch, @"^[1-9]\d{2}-[1-9]\d{3}-\d{3}$").Success;
        }
        public static bool IsEmail(string ch)
        {
            if (string.IsNullOrWhiteSpace(ch))
                return false;
            return Regex.Match(ch, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$").Success;
        }

        
        public static bool IsEmail2(string ch)
        {
            if (string.IsNullOrWhiteSpace(ch))
                return false;

            try
            {
                // Normalize the domain
                ch = Regex.Replace(ch, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    var domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException )
            {
                return false;
            }
            catch (ArgumentException )
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(ch,
                    @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                    @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }



    }
}
