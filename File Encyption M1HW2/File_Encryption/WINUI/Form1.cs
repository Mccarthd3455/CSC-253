using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
/**
* 9/11/2023
* CSC 253
* David McCarthy
* This program encrypts and decrypts a message text file.
*/
namespace WINUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> codes = new Dictionary<string, string>()
            {
                {"A", "!"},
                {"a", "1"},
                {"B", "@"},
                {"b", "2"},
                {"C", "#"},
                {"c", "3"},
                {"D", "$"},
                {"d", "4"},
                {"E", "%"},
                {"e", "5"},
                {"F", "^"},
                {"f", "6"},
                {"G", "&"},
                {"g" ,"7"},
                {"H", "*"},
                {"h", "8"},
                {"I", "("},
                {"i", "9"},
                {"J",")" },
                {"j", "0"},
                {"K", "_"},
                {"k", "-"},
                {"L", "+"},
                {"l","=" },
                {"M","{" },
                {"m","[" },
                {"N", "}"},
                {"n", "]"},
                {"O", "|"},
                {"o", "'"},
                {"P", "<"},
                {"p", ","},
                {"Q", ">"},
                {"q", "."},
                {"R", "?"},
                {"r", "/" },
                {"S", "~" },
                {"s", "`" },
                {"T", ":"},
                {"t", ";" },
                {"U", "A" },
                {"u", "a" },
                {"V" , "B"},
                {"v", "b" },
                {"W", "C" },
                {"w", "c"},
                {"X", "D"},
                {"x", "d"},
                {"Y", "E"},
                {"y", "e"},
                {"Z", "F" },
                {"z" , "f" }




            };
            StreamReader inputFile;
            StreamWriter outputFile;
            string message;
            inputFile = File.OpenText("NormalText.txt");
            message = inputFile.ReadLine();
            inputFile.Close();
            string[] normalMessage = message.Split(' ');
            string code;
            outputFile = File.CreateText("EncryptedMessage.txt");
            outputFile.Close();
            foreach (string messagechar in normalMessage)
            {
                if (codes.TryGetValue(messagechar, out code))
                {
                    outputFile = File.AppendText("EncryptedMessage.txt");
                    outputFile.Write(code);
                    outputFile.Write(" ");
                    outputFile.Close();
                }
                else
                {
                    outputFile = File.AppendText("EncryptedMessage.txt");
                    outputFile.Write(" ");
                    outputFile.Close();
                }
            }

        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> ReverseCodes = new Dictionary<string, string>()
            {
                {"!" ,"A" },
                {"1" ,"a" },
                {"@" ,"B" },
                {"2" ,"b" },
                {"#" ,"C" },
                {"3" ,"c" },
                {"$" ,"D" },
                {"4" ,"d" },
                {"%" ,"E" },
                {"5" ,"e" },
                {"^" ,"F" },
                {"6" ,"f" },
                {"&" ,"G" },
                {"7", "g" },
                {"*" ,"H" },
                {"8" ,"h" },
                {"(" ,"I" },
                {"9" ,"i" },
                {")","J" },
                {"0" ,"j" },
                {"_" ,"K" },
                {"+" ,"L" },
                {"=","l" },
                {"{","M" },
                {"[","m" },
                {"}" ,"N" },
                {"]" ,"n" },
                {"|" ,"O" },
                {"'" ,"o" },
                {"<" ,"P" },
                {"," ,"p" },
                {">" ,"Q" },
                {"." ,"q" },
                {"?" ,"R" },
                {"/" ,"r" },
                {"~" ,"S" },
                {"`" ,"s" },
                {":" ,"T" },
                {";" ,"t" },
                {"A" ,"U" },
                {"a" ,"u" },
                {"B" , "V" },
                {"b" ,"v" },
                {"C" ,"W" },
                {"c" ,"w" },
                {"D" ,"X" },
                {"d" ,"x" },
                {"E" ,"Y" },
                {"e" ,"y" },
                {"F" ,"Z" },
                {"f" , "z"}
            };
            StreamReader inputFile;
            StreamWriter outputFile;
            string encryptedMessage;
            inputFile = File.OpenText("EncryptedMessage.txt");
            encryptedMessage = inputFile.ReadLine();
            inputFile.Close();
            outputFile = File.CreateText("DecryptedMessage.txt");
            outputFile.Close();
            string[] decryptedMessage = encryptedMessage.Split(' ');
            string reverseCode;
            foreach (string encryptedChar in decryptedMessage)
            {
                if (ReverseCodes.TryGetValue(encryptedChar, out reverseCode))
                {
                    outputFile = File.AppendText("DecryptedMessage.txt");
                    outputFile.Write(reverseCode);
                    outputFile.Close();
                }
                else
                {
                    outputFile = File.AppendText("DecryptedMessage.txt");
                    outputFile.Write(" ");
                    outputFile.Close();
                }

            }
            label1.Text = encryptedMessage;

        }
    }
}
