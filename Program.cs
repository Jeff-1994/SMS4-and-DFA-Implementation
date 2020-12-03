using System;

namespace SMS4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Convert PlainText , Key & CipherText To Program's Format : 
            String input = "01 23 45 67 89 ab cd ef fe dc ba 98 76 54 32 10";
            BigBlock plainText = new BigBlock(input);
            String k = "01 23 45 67 89 ab cd ef fe dc ba 98 76 54 32 10";
            BigBlock key = new BigBlock(k);
            String output = "68	1E DF 34 D2	06 96 5E 86	B3 E9 4F 53 6E 42 46";
            BigBlock cipherText = new BigBlock(output);
            /////////////////////////////////////////////////////////////////////////


            SMS4 system = new SMS4();

            // Encryption Result :
            //BigBlock cipher = system.encryption(plainText , key, false);
            //cipher.showBigBlock();

            // Decryption Result :
            // BigBlock plain = system.decryption(cipherText , key, false);
            // plain.showBigBlock();
        }
    }
}
