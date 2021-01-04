using System;
using System.Linq;
using System.Text;

namespace HashingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = "";

            Console.WriteLine("Pick a type of Hashing: \n1. Hmacsha256 \n2. Hmacsha1 \n3. Hmacsha512 \n4. Hmacmd5 \n5. Sha1 \n6. Sha256 \n7. Sha512 \n8. md5 ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice != 0)
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("You have chosen Hmacsha256.");
                        Console.WriteLine();

                        Console.WriteLine("Please type in your key: ");
                        key = Console.ReadLine();
                        Console.WriteLine();

                        Console.WriteLine("Please type in your string to be hashed:");
                        var hashedHmacSha256 = Hmac.ComputeHmacsha256(Encoding.UTF8.GetBytes(Console.ReadLine()), GenerateKey(key.ToCharArray().Length, key));
                        Console.WriteLine();

                        Console.WriteLine("Your hashed string:");
                        Console.WriteLine(Convert.ToBase64String(hashedHmacSha256));
                        Console.WriteLine();
                        Console.WriteLine("Your hashed string in hex:");
                        Console.WriteLine(BitConverter.ToString(hashedHmacSha256).Replace("-", string.Empty));

                        break;

                    case 2:
                        Console.WriteLine("You have chosen Hmacsha1.");
                        Console.WriteLine();

                        Console.WriteLine("Please type in your key: ");
                        key = Console.ReadLine();
                        Console.WriteLine();

                        Console.WriteLine("Please type in your string to be hashed:");
                        var hashedHmacSha1 = Hmac.ComputeHmacsha1(Encoding.UTF8.GetBytes(Console.ReadLine()), GenerateKey(key.ToCharArray().Length, key));
                        Console.WriteLine();

                        Console.WriteLine("Your hashed string:");
                        Console.WriteLine(Convert.ToBase64String(hashedHmacSha1));
                        Console.WriteLine("Your hashed string in hex:");
                        Console.WriteLine(BitConverter.ToString(hashedHmacSha1).Replace("-", string.Empty));
                        break;

                    case 3:
                        Console.WriteLine("You have chosen Hmacsha512.");
                        Console.WriteLine();

                        Console.WriteLine("Please type in your key: ");
                        key = Console.ReadLine();
                        Console.WriteLine();

                        Console.WriteLine("Please type in your string to be hashed:");
                        var hashedHmacSha512 = Hmac.ComputeHmacsha512(Encoding.UTF8.GetBytes(Console.ReadLine()), GenerateKey(key.ToCharArray().Length, key));
                        Console.WriteLine();

                        Console.WriteLine("Your hashed string:");
                        Console.WriteLine(Convert.ToBase64String(hashedHmacSha512));
                        Console.WriteLine("Your hashed string in hex:");
                        Console.WriteLine(BitConverter.ToString(hashedHmacSha512).Replace("-", string.Empty));
                        break;

                    case 4:
                        Console.WriteLine("You have chosen Hmacmd5.");
                        Console.WriteLine();

                        Console.WriteLine("Please type in your key: ");
                        key = Console.ReadLine();
                        Console.WriteLine();

                        Console.WriteLine("Please type in your string to be hashed:");
                        var hashedHmacMd5 = Hmac.ComputeHmacmd5(Encoding.UTF8.GetBytes(Console.ReadLine()), GenerateKey(key.ToCharArray().Length, key));
                        Console.WriteLine();

                        Console.WriteLine("Your hashed string:");
                        Console.WriteLine(Convert.ToBase64String(hashedHmacMd5));
                        Console.WriteLine("Your hashed string in hex:");
                        Console.WriteLine(BitConverter.ToString(hashedHmacMd5).Replace("-", string.Empty));
                        break;

                    case 5:
                        Console.WriteLine("You have chosen Sha1.");
                        Console.WriteLine();

                        Console.WriteLine("Please type in your string to be hashed:");
                        var hashedSha1 = HashData.ComputeHashSha1(Encoding.UTF8.GetBytes(Console.ReadLine()));
                        Console.WriteLine();

                        Console.WriteLine("Your hashed string:");
                        Console.WriteLine(Convert.ToBase64String(hashedSha1));
                        Console.WriteLine("Your hashed string in hex:");
                        Console.WriteLine(BitConverter.ToString(hashedSha1).Replace("-", string.Empty));
                        break;

                    case 6:
                        Console.WriteLine("You have chosen Sha256.");
                        Console.WriteLine();

                        Console.WriteLine("Please type in your string to be hashed:");
                        var hashedSha256 = HashData.ComputeHashSha256(Encoding.UTF8.GetBytes(Console.ReadLine()));
                        Console.WriteLine();

                        Console.WriteLine("Your hashed string:");
                        Console.WriteLine(Convert.ToBase64String(hashedSha256));
                        Console.WriteLine("Your hashed string in hex:");
                        Console.WriteLine(BitConverter.ToString(hashedSha256).Replace("-", string.Empty));
                        break;

                    case 7:
                        Console.WriteLine("You have chosen Sha512.");
                        Console.WriteLine();

                        Console.WriteLine("Please type in your string to be hashed:");
                        var hashedSha512 = HashData.ComputeHashSha512(Encoding.UTF8.GetBytes(Console.ReadLine()));
                        Console.WriteLine();

                        Console.WriteLine("Your hashed string:");
                        Console.WriteLine(Convert.ToBase64String(hashedSha512));
                        Console.WriteLine("Your hashed string in hex:");
                        Console.WriteLine(BitConverter.ToString(hashedSha512).Replace("-", string.Empty));
                        break;

                    case 8:
                        Console.WriteLine("You have chosen Sha512.");
                        Console.WriteLine();

                        Console.WriteLine("Please type in your string to be hashed:");
                        var hashedmd5 = HashData.ComputeHashMd5(Encoding.UTF8.GetBytes(Console.ReadLine()));
                        Console.WriteLine();

                        Console.WriteLine("Your hashed string:");
                        Console.WriteLine(Convert.ToBase64String(hashedmd5));
                        Console.WriteLine("Your hashed string in hex:");
                        Console.WriteLine(BitConverter.ToString(hashedmd5).Replace("-", string.Empty));
                        break;
                }
            }
            Console.ReadKey();
        }

        public static byte[] GenerateKey(int keysize, string msg)
        {
            var newByte = new byte[keysize];
            foreach (char item in msg)
            {
                newByte.Append(Convert.ToByte(item));
            }

            return newByte;
        }
    }
}
