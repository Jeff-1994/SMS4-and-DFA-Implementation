using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS4
{
    class Nibble
    {

        int nibble;

        public Nibble()
        {
            this.nibble = 0;
        }

        public Nibble(int num)
        {
            this.nibble = num;
        }

        public Nibble(String num)
        {
            switch(num)
            {
                case "A":
                    this.nibble = 10;
                    break;
                case "a":
                    this.nibble = 10;
                    break;
                case "B":
                    this.nibble = 11;
                    break;
                case "b":
                    this.nibble = 11;
                    break;
                case "C":
                    this.nibble = 12;
                    break;
                case "c":
                    this.nibble = 12;
                    break;
                case "D":
                    this.nibble = 13;
                    break;
                case "d":
                    this.nibble = 13;
                    break;
                case "E":
                    this.nibble = 14;
                    break;
                case "e":
                    this.nibble = 14;
                    break;
                case "F":
                    this.nibble = 15;
                    break;
                case "f":
                    this.nibble = 15;
                    break;
                default:
                    int tempNum = Convert.ToInt32(num);
                    if (tempNum >= 0 && tempNum <= 9)
                    {
                        this.nibble = tempNum;
                    }
                    else
                    {
                        this.nibble = -1;
                    }
                    break;
            }
        }

        public static Boolean isNibble(char ch)
        {
            Boolean flag = false;
            if(ch == '0')
            {
                flag = true;
            }
            else
            {
                switch(ch)
                {
                    case 'A':
                        flag = true;
                        break;
                    case 'a':
                        flag = true;
                        break;
                    case 'B':
                        flag = true;
                        break;
                    case 'b':
                        flag = true;
                        break;
                    case 'C':
                        flag = true;
                        break;
                    case 'c':
                        flag = true;
                        break;
                    case 'D':
                        flag = true;
                        break;
                    case 'd':
                        flag = true;
                        break;
                    case 'E':
                        flag = true;
                        break;
                    case 'e':
                        flag = true;
                        break;
                    case 'F':
                        flag = true;
                        break;
                    case 'f':
                        flag = true;
                        break;
                    default:
                        try
                        {
                            int res = Convert.ToInt32(new string(ch, 1));
                            flag = true;
                        }
                        catch(Exception ex)
                        {
                            flag = false;
                            // Console.WriteLine(ex.Message);
                        }
                        // if(res < 10 && res > 0)
                        //     flag = true;
                        // else
                        //     flag = false;
                        break;
                }
            }
            return flag;
        }

        public static Nibble operator |(Nibble num1, Nibble num2)
        {
            String BiNum1 = getBinaryNibble(num1.nibble);
            String BiNum2 = getBinaryNibble(num2.nibble);

            int res = getHexNibble(xOr(BiNum1 , BiNum2));

            return (new Nibble(res));
        }

        public static String xOr(String Num1, String Num2)
        {
            String result = "";
            for (int i = Num1.Length - 1; i >= 0; i--)
            {
                if (Num1[i] == Num2[i])
                {
                    result = "0" + result;
                }
                else
                {
                    result = "1" + result;
                }
            }

            return result;
        }

        public static String getBinaryNibble(int hex)
        {
            String result;
            switch (hex)
            {
                case 0:
                    result = "0000";
                    break;
                case 1:
                    result = "0001";
                    break;
                case 2:
                    result = "0010";
                    break;
                case 3:
                    result = "0011";
                    break;
                case 4:
                    result = "0100";
                    break;
                case 5:
                    result = "0101";
                    break;
                case 6:
                    result = "0110";
                    break;
                case 7:
                    result = "0111";
                    break;
                case 8:
                    result = "1000";
                    break;
                case 9:
                    result = "1001";
                    break;
                case 10:
                    result = "1010";
                    break;
                case 11:
                    result = "1011";
                    break;
                case 12:
                    result = "1100";
                    break;
                case 13:
                    result = "1101";
                    break;
                case 14:
                    result = "1110";
                    break;
                case 15:
                    result = "1111";
                    break;
                default:
                    result = "EROR";
                    break;
            }

            return result;
        }

        public static int getHexNibble(String bin)
        {
            int result;
            switch (bin)
            {
                case "0000":
                    result = 0;
                    break;
                case "0001":
                    result = 1;
                    break;
                case "0010":
                    result = 2;
                    break;
                case "0011":
                    result = 3;
                    break;
                case "0100":
                    result = 4;
                    break;
                case "0101":
                    result = 5;
                    break;
                case "0110":
                    result = 6;
                    break;
                case "0111":
                    result = 7;
                    break;
                case "1000":
                    result = 8;
                    break;
                case "1001":
                    result = 9;
                    break;
                case "1010":
                    result = 10;
                    break;
                case "1011":
                    result = 11;
                    break;
                case "1100":
                    result = 12;
                    break;
                case "1101":
                    result = 13;
                    break;
                case "1110":
                    result = 14;
                    break;
                case "1111":
                    result = 15;
                    break;
                default:
                    result = -1;
                    break;
            }

            return result;
        }

        public static String getHexNibble(int hex)
        {
            String result;
            switch (hex)
            {
                case 10:
                    result = "A";
                    break;
                case 11:
                    result = "B";
                    break;
                case 12:
                    result = "C";
                    break;
                case 13:
                    result = "D";
                    break;
                case 14:
                    result = "E";
                    break;
                case 15:
                    result = "F";
                    break;
                default:
                    result = hex.ToString();
                    break;
            }

            return result;
        }

        public String nibbleToBitString()
        {
            return getBinaryNibble(this.nibble);
        }

        public static String nibbleToHexString(String input)
        {
            return getHexNibble(getHexNibble(input));
        }

        public int nibbleValue
        {
            get
            {
                return this.nibble;
            }

            set
            {
                this.nibble = value;
            }
        }
    }

    class Byte
    {
        Nibble[] _byte = new Nibble[2];

        public Byte()
        {
            this._byte[0] = new Nibble();
            this._byte[1] = new Nibble();
        }

        public Byte(Nibble num1 , Nibble num2)
        {
            this._byte[0] = num1;
            this._byte[1] = num2;
        }

        public Byte(String num)
        {
            this._byte[0] = new Nibble(num[0].ToString());
            this._byte[1] = new Nibble(num[1].ToString());
        }

        public Byte(String num1 , String num2)
        {
            this._byte[0] = new Nibble(num1);
            this._byte[1] = new Nibble(num2);
        }

        public static Byte operator |(Byte num1, Byte num2)
        {
            Byte tempByte = new Byte();

            tempByte._byte[0] = num1._byte[0] | num2._byte[0];
            tempByte._byte[1] = num1._byte[1] | num2._byte[1];

            return tempByte;
        }

        public String getHexByte()
        {
            return Nibble.getHexNibble(this._byte[0].nibbleValue) +
                   " " +
                   Nibble.getHexNibble(this._byte[1].nibbleValue);
        }

        public String byteToBitString()
        {
            return this._byte[0].nibbleToBitString() + this._byte[1].nibbleToBitString();
        }

        public static String byteToHexString(String input)
        {
            String nibble0 = input.Substring(0,4);
            String nibble1 = input.Substring(4,4);
            return Nibble.nibbleToHexString(nibble0) + Nibble.nibbleToHexString(nibble1);
        }

        public Nibble[] byteValue
        {
            get
            {
                return this._byte;
            }

            set
            {
                this._byte = value;
            }
        }
    }

    class Block
    {
        Byte[] block = new Byte[4];

        public Block()
        {
            for (int i = 0; i < 4; i++)
            {
                block[i] = new Byte();
            }
        }

        public Block(Byte b1 , Byte b2 , Byte b3 , Byte b4)
        {
            this.blockValues[0] = b1;
            this.blockValues[1] = b2;
            this.blockValues[2] = b3;
            this.blockValues[3] = b4;
        }

        public Block(String input)
        {
            input = removeWhiteSpaces(input);

            for (int i = 0; i < input.Length; i += 2)
            {
                String num1 = input[i].ToString();
                String num2 = input[i+1].ToString();
                block[i/2] = new Byte(num1 , num2);
            }
        }

        public static Block operator |(Block blc1 , Block blc2)
        {
            Block result = new Block();
            for (int i = 0; i < 4; i++)
            {
                result.block[i] = blc1.block[i] | blc2.block[i];
            }
            return result;
        }

        public static Block operator <<(Block blc , int quantity)
        {
            String BiNum = blc.blockToBitString();
            String result = blockToHexString(BiNum.Substring(quantity) + BiNum.Substring(0 , quantity));
            return new Block(result);
        }

        public static Block operator >>(Block blc , int quantity)
        {
            String BiNum = blc.blockToBitString();
            String result = blockToHexString(BiNum.Substring(BiNum.Length - quantity) + BiNum.Substring(0 , BiNum.Length - quantity));
            return new Block(result);
        }

        public static String removeWhiteSpaces(String input)
        {
            String output = "";

            for (int i = 0; i < input.Length; i++)
            {
                if(Nibble.isNibble(input[i]))
                {
                    output += input[i];
                }
            }

            return output;
        }

        public String blockToHexString()
        {
            return removeWhiteSpaces(getBlockValues());
        }

        public String blockToBitString()
        {
            return this.block[0].byteToBitString() +
                   this.block[1].byteToBitString() +
                   this.block[2].byteToBitString() +
                   this.block[3].byteToBitString();
        }

        public static String blockToHexString(String input)
        {
            String byte0 = input.Substring(0,8);
            String byte1 = input.Substring(8,8);
            String byte2 = input.Substring(16,8);
            String byte3 = input.Substring(24,8);

            return Byte.byteToHexString(byte0) +
                   Byte.byteToHexString(byte1) +
                   Byte.byteToHexString(byte2) +
                   Byte.byteToHexString(byte3);
        }

        public String getBlockValues()
        {
            String output = "";
            for (int i = 0; i < 4; i++)
            {
                output += this.block[i].getHexByte() + "\t";
            }
            return output;
        }

        public void showBlock()
        {
            Console.WriteLine(getBlockValues());
        }

        internal Byte[] blockValues { get => block; set => block = value; }
    }

    class BigBlock
    {
        Block[] big_block;

        public BigBlock()
        {
            this.big_block = new Block[4];
        }

        public BigBlock(Block blc1 , Block blc2 , Block blc3 , Block blc4)
        {
            this.big_block = new Block[4];
            this.big_block[0] = blc1;
            this.big_block[1] = blc2;
            this.big_block[2] = blc3;
            this.big_block[3] = blc4;
        }

        public BigBlock(Block[] array)
        {
            this.big_block = array;
        }

        public BigBlock(String input)
        {
            input = Block.removeWhiteSpaces(input);

            this.big_block = new Block[4];
            this.big_block[0] = new Block(input.Substring(0,8));
            this.big_block[1] = new Block(input.Substring(8,8));
            this.big_block[2] = new Block(input.Substring(16,8));
            this.big_block[3] = new Block(input.Substring(24,8));
        }

        public Block bigBlockIntoBlock(int blockNumber)
        {
            return this.big_block[blockNumber];
        }

        public String getBigBlockValues()
        {
            String output = "";
            for (int i = 0; i < 4; i++)
            {
                output += this.big_block[i].getBlockValues();
            }
            return output;
        }

        public void showBigBlock(String message)
        {
            Console.WriteLine(message);
            Console.WriteLine(getBigBlockValues());
        }

        internal Block[] bigBlock { get => big_block; set => big_block = value; }
    }

    class SMS4
    {
        BigBlock plainText;
        BigBlock key;
        BigBlock cipherText;

        String[,] sBox = 
        {
                          {"D6", "90", "E9", "FE", "CC", "E1", "3D", "B7", "16", "B6", "14", "C2", "28", "FB", "2C", "05"},
                          {"2B", "67", "9A", "76", "2A", "BE", "04", "C3", "AA", "44", "13", "26", "49", "86", "06", "99"},
                          {"9C", "42", "50", "F4", "91", "EF", "98", "7A", "33", "54", "0B", "43", "ED", "CF", "AC", "62"},
                          {"E4", "B3", "1C", "A9", "C9", "08", "E8", "95", "80", "DF", "94", "FA", "75", "8F", "3F", "A6"},
                          {"47", "07", "A7", "FC", "F3", "73", "17", "BA", "83", "59", "3C", "19", "E6", "85", "4F", "A8"},
                          {"68", "6B", "81", "B2", "71", "64", "DA", "8B", "F8", "EB", "0F", "4B", "70", "56", "9D", "35"},
                          {"1E", "24", "0E", "5E", "63", "58", "D1", "A2", "25", "22", "7C", "3B", "01", "21", "78", "87"},
                          {"D4", "00", "46", "57", "9F", "D3", "27", "52", "4C", "36", "02", "E7", "A0", "C4", "C8", "9E"},
                          {"EA", "BF", "8A", "D2", "40", "C7", "38", "B5", "A3", "F7", "F2", "CE", "F9", "61", "15", "A1"},
                          {"E0", "AE", "5D", "A4", "9B", "34", "1A", "55", "AD", "93", "32", "30", "F5", "8C", "B1", "E3"},
                          {"1D", "F6", "E2", "2E", "82", "66", "CA", "60", "C0", "29", "23", "AB", "0D", "53", "4E", "6F"},
                          {"D5", "DB", "37", "45", "DE", "FD", "8E", "2F", "03", "FF", "6A", "72", "6D", "6C", "5B", "51"},
                          {"8D", "1B", "AF", "92", "BB", "DD", "BC", "7F", "11", "D9", "5C", "41", "1F", "10", "5A", "D8"},
                          {"0A", "C1", "31", "88", "A5", "CD", "7B", "BD", "2D", "74", "D0", "12", "B8", "E5", "B4", "B0"},
                          {"89", "69", "97", "4A", "0C", "96", "77", "7E", "65", "B9", "F1", "09", "C5", "6E", "C6", "84"},
                          {"18", "F0", "7D", "EC", "3A", "DC", "4D", "20", "79", "EE", "5F", "3E", "D7", "CB", "39", "48"},
        };

        static String[] COSTANT_KEY = 
        {
            "00070E15", "1C232A31", "383F464D", "545B6269",
            "70777E85", "8C939AA1", "A8AFB6BD", "C4CBD2D9",
            "E0E7EEF5", "FC030A11", "181F262D", "343B4249",
            "50575E65", "6C737A81", "888F969D", "A4ABB2B9",
            "C0C7CED5", "DCE3EAF1", "F8FF060D", "141B2229",
            "30373E45", "4C535A61", "686F767D", "848B9299",
            "A0A7AEB5", "BCC3CAD1", "D8DFE6ED", "F4FB0209",
            "10171E25", "2C333A41", "484F565D", "646B7279"
        };

        Block[] CK = getConstantKey();
        BigBlock FK = new BigBlock(new Block("A3B1BAC6"), new Block("56AA3350"),
                                   new Block("677D9197"), new Block("B27022DC"));

        public SMS4()
        {
            PlainText = new BigBlock();
            Key = new BigBlock();
            CipherText = new BigBlock();
        }

        public BigBlock encryption(BigBlock plain , BigBlock key, Boolean showEncDetails)
        {
            BigBlock cipher = new BigBlock();
            Block[] rk = keySchedule(key);

            Block[] X = new Block[36];
            X[0] = plain.bigBlockIntoBlock(0);
            X[1] = plain.bigBlockIntoBlock(1);
            X[2] = plain.bigBlockIntoBlock(2);
            X[3] = plain.bigBlockIntoBlock(3);

            
            Block[] roundKeys = new Block[32];

            // Creating round keys:
            for (int i = 0; i < 32; i++)
            {
                X[i+4] = F(new BigBlock(X[i], X[i+1], X[i+2], X[i+3]), rk[i]);
            }

            cipher = R(new BigBlock(X[32], X[33], X[34], X[35]));

            if(showEncDetails)
            {
                for (int i = 4; i < 36; i++)
                {
                    Console.Write(("X_" + i) + " :   " + X[i].getBlockValues() + "\t\t");
                    Console.WriteLine(("rk_" + (i-4)) + " :   " + rk[i-4].getBlockValues());
                }
            }

            return cipher;
        }

        public BigBlock decryption(BigBlock cipher , BigBlock key, Boolean showDecDetails)
        {
            BigBlock plain = new BigBlock();
            Block[] rk = keySchedule(key);

            Block[] Y = new Block[36];
            Y[0] = cipher.bigBlockIntoBlock(0);
            Y[1] = cipher.bigBlockIntoBlock(1);
            Y[2] = cipher.bigBlockIntoBlock(2);
            Y[3] = cipher.bigBlockIntoBlock(3);

            
            Block[] roundKeys = new Block[32];

            // Creating round keys:
            for (int i = 0; i < 32; i++)
            {
                Y[i+4] = F(new BigBlock(Y[i], Y[i+1], Y[i+2], Y[i+3]), rk[31-i]);
            }

            plain = R(new BigBlock(Y[32], Y[33], Y[34], Y[35]));

            if(showDecDetails)
            {
                for (int i = 4; i < 36; i++)
                {
                    Console.Write(("Y_" + i) + " :   " + Y[i].getBlockValues() + "\t\t");
                    Console.WriteLine(("rk_" + (i-4)) + " :   " + rk[35-i].getBlockValues());
                }
            }

            return plain;
        }

        public Block[] keySchedule(BigBlock key)
        {
            //  Creating Block MK = (MK0 , MK1 , MK2 , MK3):
            Block MK0 = key.bigBlockIntoBlock(0);
            Block MK1 = key.bigBlockIntoBlock(1);
            Block MK2 = key.bigBlockIntoBlock(2);
            Block MK3 = key.bigBlockIntoBlock(3);
            
            //  Creating Block K = (K0 , K1 , K2 , K3):
            Block[] K = new Block[36];
            K[0] = MK0 | FK.bigBlock[0];
            K[1] = MK1 | FK.bigBlock[1];
            K[2] = MK2 | FK.bigBlock[2];
            K[3] = MK3 | FK.bigBlock[3];

            
            Block[] roundKeys = new Block[32];

            // Creating round keys:
            for (int i = 0; i < 32; i++)
            {
                K[i+4] =  K[i] | T_p(K[i+1] | K[i+2] | K[i+3] | CK[i]);
                roundKeys[i] = K[i+4];
            }
            
            return roundKeys;
        }

        public Block F(BigBlock input, Block roundKey)
        {
            Block X0 = input.bigBlock[0];
            Block X1 = input.bigBlock[1];
            Block X2 = input.bigBlock[2];
            Block X3 = input.bigBlock[3];
            Block output = X0 | T(X1 | X2 | X3 | roundKey);
            return output;
        }

        public Block T(Block input)
        {
            Block output = L(Tau(input));
            return output;
        }

        public Block T_p(Block input)
        {
            Block output = L_p(Tau(input));
            return output;
        }

        public Block Tau(Block input)
        {
            Byte a0 = input.blockValues[0];
            Byte a1 = input.blockValues[1];
            Byte a2 = input.blockValues[2];
            Byte a3 = input.blockValues[3];

            Block output = new Block(getSboxValue(a0), getSboxValue(a1), getSboxValue(a2), getSboxValue(a3));
            
            return output;
        }

        public Block L(Block input)
        {
            return input | (input << 2) | (input << 10) | (input << 18) | (input << 24);
        }

        public Block L_p(Block input)
        {
            return input | (input << 13) | (input << 23);
        }

        public BigBlock R(BigBlock input)
        {
            BigBlock output = new BigBlock(input.bigBlock[3] , input.bigBlock[2] ,
                                           input.bigBlock[1] , input.bigBlock[0]);
            return output;
        }


        public Byte getSboxValue(Byte input)
        {
            Byte output;

            int rowNumber = Convert.ToInt32(input.byteValue[0].nibbleValue);
            int colNumber = Convert.ToInt32(input.byteValue[1].nibbleValue);
            String result = sBox[rowNumber, colNumber];
            //int num1 = Convert.ToInt32(result[0].ToString());
            output = new Byte(result);

            return output;
        }

        public static Block[] getConstantKey()
        {
            Block[] CKi = new Block[32];
            for (int i = 0; i < 32; i++)
            {
                CKi[i] = new Block(COSTANT_KEY[i]);
            }
            return CKi;
        }

        internal BigBlock PlainText { get => plainText; set => plainText = value; }
        internal BigBlock Key { get => key; set => key = value; }
        internal BigBlock CipherText { get => cipherText; set => cipherText = value; }
    }
}
