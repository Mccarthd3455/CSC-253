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
namespace WinUI
{
    /**
    * 9/18/2023
    * CSC 253
    * David McCarthy
    * This program takes a file and gets the indexs for the words in the file. (Check debug bin for WordIndex.Txt to see indexes)
    */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void indexFileButton_Click(object sender, EventArgs e)
        {
            List<int> aIndex = new List<int>() { };
            List<int> anIndex = new List<int>();
            List<int> asIndex = new List<int>();
            List<int> beginningIndex = new List<int>();
            List<int> butIndex = new List<int>();
            List<int> celebrationIndex = new List<int>();
            List<int> changeIndex = new List<int>();
            List<int> endIndex = new List<int>();
            List<int> freedomIndex = new List<int>();
            List<int> notIndex = new List<int>();
            List<int> observeIndex = new List<int>();
            List<int> ofIndex = new List<int>();
            List<int> partyIndex = new List<int>();
            List<int> renewalIndex = new List<int>();
            List<int> signifyingIndex = new List<int>();
            List<int> symbolizingIndex = new List<int>();
            List<int> todayIndex = new List<int>();
            List<int> victoryIndex = new List<int>();
            List<int> weIndex = new List<int>();
            List<int> wellIndex = new List<int>();
            Dictionary<string, List<int>> wordIndexes = new Dictionary<string, List<int>>()
            {
                {"a",aIndex},
                {"an",anIndex},
                {"as", asIndex},
                {"beginning", beginningIndex},
                {"but", butIndex},
                {"celebration", celebrationIndex},
                {"change", changeIndex},
                {"end", endIndex},
                {"freedom", freedomIndex},
                {"not", notIndex},
                {"observe", observeIndex},
                {"of", ofIndex},
                {"party", partyIndex},
                {"renewal", renewalIndex},
                {"signifying", signifyingIndex},
                {"symbolizing", symbolizingIndex},
                {"today", todayIndex},
                {"victory", victoryIndex},
                {"we", weIndex},
                {"well", wellIndex }
            };
            StreamReader Outputfile;
            string[] LineWords;
            int counter = 1;
            Outputfile = File.OpenText("Kennedy.txt");
            while (!Outputfile.EndOfStream)
            {
                LineWords = Outputfile.ReadLine().Split(' ');
                foreach (string word in LineWords)
                {
                    if (word == "a")
                    {
                        aIndex.Add(counter);
                    }
                    else if (word == "an")
                    {
                        anIndex.Add(counter);
                    }
                    else if (word == "as")
                    {
                        asIndex.Add(counter);
                    }
                    else if (word == "beginning")
                    {
                        beginningIndex.Add(counter);
                    }
                    else if (word == "but")
                    {
                        butIndex.Add(counter);
                    }
                    else if (word == "celebration")
                    {
                        celebrationIndex.Add(counter);
                    }
                    else if (word == "change")
                    {
                        changeIndex.Add(counter);
                    }
                    else if (word == "end")
                    {
                        endIndex.Add(counter);
                    }
                    else if (word == "freedom")
                    {
                        freedomIndex.Add(counter);
                    }
                    else if (word == "not")
                    {
                        notIndex.Add(counter);
                    }
                    else if (word == "observe")
                    {
                        observeIndex.Add(counter);
                    }
                    else if (word == "of")
                    {
                        ofIndex.Add(counter);
                    }
                    else if (word == "party")
                    {
                        partyIndex.Add(counter);
                    }
                    else if (word == "renewal")
                    {
                        renewalIndex.Add(counter);
                    }
                    else if (word == "signifying")
                    {
                        signifyingIndex.Add(counter);
                    }
                    else if (word == "symbolizing")
                    {
                        symbolizingIndex.Add(counter);
                    }
                    else if (word == "today")
                    {
                        todayIndex.Add(counter);
                    }
                    else if (word == "victory")
                    {
                        victoryIndex.Add(counter);
                    }
                    else if (word == "We")
                    {
                        weIndex.Add(counter);
                    }
                    else if (word == "well")
                    {
                        wellIndex.Add(counter);
                    }
                }
                counter++;
            }
            Outputfile.Close();
            StreamWriter inputFile;
            inputFile = File.CreateText("WordIndex.txt");
            inputFile.WriteLine("a: " + aIndex[0].ToString() + " " + aIndex[1].ToString() + " " + aIndex[2].ToString());
            inputFile.WriteLine("an: " + anIndex[0].ToString());
            inputFile.WriteLine("as: " + asIndex[0].ToString() + " " + asIndex[1].ToString() + " " + asIndex[2].ToString());
            inputFile.WriteLine("beginning: " + beginningIndex[0].ToString());
            inputFile.WriteLine("but: " + butIndex[0].ToString());
            inputFile.WriteLine("celebration: " + celebrationIndex[0].ToString());
            inputFile.WriteLine("change: " + changeIndex[0].ToString());
            inputFile.WriteLine("end: " + endIndex[0].ToString());
            inputFile.WriteLine("freedom: " + freedomIndex[0].ToString());
            inputFile.WriteLine("not: " + notIndex[0].ToString());
            inputFile.WriteLine("observe: " + observeIndex[0].ToString());
            inputFile.WriteLine("of: " + ofIndex[0].ToString() + " " + ofIndex[1].ToString());
            inputFile.WriteLine("party: " + partyIndex[0].ToString());
            inputFile.WriteLine("renewal: " + renewalIndex[0].ToString());
            inputFile.WriteLine("signifying: " + signifyingIndex[0].ToString());
            inputFile.WriteLine("symbolizing: " + symbolizingIndex[0].ToString());
            inputFile.WriteLine("today: " + todayIndex[0].ToString());
            inputFile.WriteLine("victory: " + victoryIndex[0].ToString());
            inputFile.WriteLine("We: " + weIndex[0].ToString());
            inputFile.WriteLine("well: " + wellIndex[0].ToString() + " " + wellIndex[1].ToString());
            inputFile.Close();
        }
    }
}

