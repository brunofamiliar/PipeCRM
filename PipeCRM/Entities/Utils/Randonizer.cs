using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Entities.Utils
{
    public class Randonizer
    {
        private static readonly Random Rnd = new Random();

        public static string GenerateRID(int tamanho = 45)
        {
            try
            {
                string chars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                double salt = DateTime.UtcNow.Ticks;
                salt *= 10000;
                salt += Rnd.Next(1000000000);

                if (salt < 0)
                    salt *= -1;

                string saltInput = salt.ToString() + DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss");

                var di = new DriveInfo(Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)));
                var segmentA = BitConverter.GetBytes(di.RootDirectory.CreationTimeUtc.Ticks);
                var segmentB = Encoding.Default.GetBytes(saltInput.ToString() + di.ToString());

                double vlr = 0;
                saltInput = salt.ToString();

                for (int k = 0; k < saltInput.Length; k++)
                    vlr += saltInput[k] * (saltInput.Length - k);

                var segmentC = Encoding.Default.GetBytes(vlr.ToString() + (saltInput.Length + (vlr % 11)).ToString());

                string _final = BitConverter.ToString(Utilitis.CombineArrays<byte>(segmentA, segmentB, segmentC));

                string hash = new string(
                  Enumerable.Repeat(_final, tamanho)
                            .Select(s => s[Rnd.Next(s.Length)])
                            .ToArray());

                var result = new string(
                    Enumerable.Repeat(chars, 24)
                              .Select(s => s[Rnd.Next(s.Length)])
                              .ToArray());

                string final = GetSHA1(hash + _final + DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss") + result) + (Rnd.Next(10000) * vlr).ToString();
                hash = final;

                for (int i = final.Length; i < tamanho; i++)
                {
                    hash += GetSHA1(GenerateRID(tamanho));

                    if (hash.Length >= tamanho)
                        break;
                }

                return hash.Substring(0, tamanho).Trim();
            }
            catch (Exception x)
            {
                throw x;
            }
        }
        private static string GetSHA1(string value)
        {
            try
            {
                byte[] buffer = Encoding.Default.GetBytes(value);
                System.Security.Cryptography.SHA1CryptoServiceProvider cryptoTransformSHA1 = new System.Security.Cryptography.SHA1CryptoServiceProvider();
                string hash = BitConverter.ToString(cryptoTransformSHA1.ComputeHash(buffer)).Replace("-", "");

                return hash;

            }
            catch (Exception)
            {
                return "";
            }
        }
    }
}
