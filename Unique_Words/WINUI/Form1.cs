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
* 11/19/2023
* CSC 253
* David McCarthy
* This program will read and get all the unique words in the duplicates.txt file when the user presses a button and display what the file says and what it looks
* looks like when the file is unduplicated
*/
namespace WINUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void readFileAndUnduplicatebutton_Click(object sender, EventArgs e)
        {
            var duplicatedWords = new List<String>();
            using (var reader = new StreamReader("duplicates.txt"))
            {
                while (!reader.EndOfStream)
                {
                    var LineRead = reader.ReadLine().Split(' ');
                    foreach (string word in LineRead)
                    {
                        duplicatedWords.Add(word);
                    }
                }
                reader.Close();
                foreach (string word in duplicatedWords)
                {
                    fileTextBox.AppendText(word);
                    fileTextBox.AppendText(" ");
                }
                var undupedwords = duplicatedWords.Distinct();
                foreach (var item in undupedwords)
                {
                    undupedWordsTextBox.AppendText(item);
                    undupedWordsTextBox.AppendText(" ");
                }
            }
        }
    }
}
