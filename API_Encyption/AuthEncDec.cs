using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Encyption
{
    public class AuthEncDec : EncDec
    {

        public void Encryption(bool val)
        {
            EncDecModel.Encryption = val;
        }

        public string GenerateToken(string tokenParameter)
        {
            Token token = new Token();
            return token.CreateToken(tokenParameter);
        }

        public string EncryptBool(string plainText, byte[] key, byte[] iv)
        {
            try
            {
                plainText = plainText == "0" ? "false" :
                       plainText == "1" ? "true" :
                       plainText;

                return EncryptBool(plainText, key, iv);
            }
            catch (FormatException e)
            {
                return "Something went wrong, please contact your administrator";
            }
        }

        public string EncryptBool(string plainText)
        {
            try
            {
                plainText = plainText == "0" ? "false" :
                        plainText == "1" ? "true" :
                        plainText;

                return EncryptBoolean(Convert.ToBoolean(plainText));
            }
            catch (System.FormatException e)
            {
                return "Something went wrong, please contact your administrator";            
            }
        }

        public string DecryptBool(string cipherText, byte[] key, byte[] iv)
        {
            return DecryptBool(cipherText.Replace('"', ' ').Trim(), key, iv);
        }

        public string DecryptBool(bool cipherBoolean)
        {
            return DecryptBoolean(cipherBoolean);
        }


        public string Encrypt(string plainText)
        {
            return EncryptString(plainText);
        }

        public string Decrypt(string cipherText)
        {
            return DecryptString(cipherText.Replace('"', ' ').Trim());
        }

        public string Encrypt(string plainText, byte[] key, byte[] iv)
        {
            return EncryptString(plainText, key, iv);
        }

        public string Decrypt(string cipherText, byte[] key, byte[] iv)
        {
            return DecryptString(cipherText.Replace('"', ' ').Trim(), key, iv);
        }
    }
}
