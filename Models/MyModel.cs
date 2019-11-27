using System;

namespace Rand_Passcode.Models
{
    public class RandomString
    {
        public string Passcode { get; set; }

        public string Random()
        {
            var Char = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var stringChar = new Char[14];
            Random Rand = new Random();
            for (int i = 0; i < stringChar.Length; i++)
            {
                stringChar[i] = Char[Rand.Next(Char.Length)];
            }
            var Finalstring = new string(stringChar);
            return Finalstring;
        }

    }
}