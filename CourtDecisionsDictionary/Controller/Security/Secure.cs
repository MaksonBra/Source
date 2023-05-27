using System.Text;
using System.Security.Cryptography;

namespace CourtDecisionsDictionary.Controller.Security
{
    /// <summary>
    /// Класс информационной безопасности
    /// </summary>
    public class Secure
    {
        // Хешировать по SHA256
        public static string Hash(string data)
        {
            string result = "";
            SHA256 hf = SHA256.Create();
            byte[] hash = hf.ComputeHash(Encoding.ASCII.GetBytes(data));
            for (int i = 0; i < hash.Length; i++)
                result += $"{hash[i]:X2}";
            return result;
        }
    }
}