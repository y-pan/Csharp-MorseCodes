using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


//using WMPLib;//Doesn't play .mp3

/*
1. short mark, dot or "dit" (·) — 1
2. longer mark, dash or "dah" (–) — 111
3. intra-character gap (between the dots and dashes within a character) — 0
4. short gap (between letters) — 000
5. medium gap (between words) — 0000000
          1         2         3         4         5         6         7         8
12345678901234567890123456789012345678901234567890123456789012345678901234567890123456789
 
M------   O----------   R------   S----   E       C----------   O----------   D------   E

===.===...===.===.===...=.===.=...=.=.=...=.......===.=.===.=...===.===.===...===.=.=...=
   ^               ^    ^       ^             ^
   |              dah  dit      |             |
symbol space                letter space    word space

A •-    N -•    0 -----
B -•••  O ---   1 •----
C -•-•  P •--•  2 ••---
D -••   Q --•-  3 •••--
E •     R •-•   4 ••••-
F ••-•  S •••   5 •••••
G --•   T -     6 -••••
H ••••  U ••-   7 --•••
I ••    V •••-  8 ---••
J •---  W •--   9 ----•
K -•-   X -••-  • •-•-•-
L •-••  Y -•--  , --••--
M --    Z --••  ? ••--••
 */
namespace Morse_Codes
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string Translate(string input)
        {
            //space in text -> / in morse
            string[] textArray = new string[] {
                "A",        "B",        "C",        "D",        "E",        "F",        "G", 
                "H",        "I",        "J",        "K",        "L",        "M",        "N",
                "O",        "P",        "Q",        "R",        "S",        "T",        "U", 
                "V",        "W",        "X",        "Y",        "Z", 
                "0",        "1",        "2",        "3",        "4",        "5",        "6",
                "7",        "8",        "9",
                ".",        ","};
            string[] morseArray = new string[] { 
                ".-",       "-...",     "-.-.",     "-..",      ".",        "..-.",     "--.",
                "....",     "..",       ".---",     "-.-",      ".-..",     "--",       "-.", 
                "---",      ".--.",     "--.-",     ".-.",      "...",      "-",        "..-", 
                "...-",     ".--",      "-..-",     "-.--",     "--..", 
                "-----",    ".----",    "..---",    "...--",     "....-",     ".....",  "-....",     
                "--...",    "---..",    "----.",        
                ".-.-.-",   "--..--",};

            string output = "";
            if (rbT2M.Checked)//text -> morse  
            {
                foreach (char c in input)
                //search the index of c, then get the morceArray[index], space cannot represent in wordArray
                {
                    switch (c)
                    {
                        case ' ':
                            output += "/";
                            break;
                        default:
                            if (textArray.Contains(c.ToString()))//c is recognized
                            {
                                output += morseArray[Array.IndexOf(textArray, c.ToString())] + " ";
                            }
                            else
                            {
                                output += c.ToString();//c is not recognized but just output orignally.
                            }
                            break;
                    }
                }
            }
            else//morse -> text
            {
                string temp = "";
                string lastInText = input.Substring(input.Length - 1, 1);
                if (lastInText != " " || lastInText != "/")//add a " " to the end where is no " "
                {
                    input += " ";
                }
                foreach (char c in input)//start converting
                {
                    if (temp == "" && (c == ' ' || c == '/'))//useless ' ' and '/' ->" "
                    {
                        output += " ";
                    }
                    else//useful information
                    {
                        switch (c)
                        {
                            case '.':
                            case '-':
                                temp += c;
                                break;
                            case ' ':
                            case '/':
                                output += textArray[Array.IndexOf(morseArray, temp)];//get the letter 
                                temp = "";
                                break;
                            default:
                                output += c.ToString();//c is not recognized but ouput orignally
                                temp = "";
                                break;
                        }
                    }
                }
            }
            return output;
        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {
            string input;
            if (rbT2M.Checked)//text -> morse
            {
                input = (txtText.Text).ToUpper();
                txtMorse.Text = Translate(input);
            }
            else//morse -> text
            {
                input = txtMorse.Text;
                txtText.Text = Translate(input);
            }
        }

        private void rbT2M_CheckedChanged(object sender, EventArgs e)
        {
            txtText.ReadOnly = false;
            txtMorse.ReadOnly = true;
            // txtMorse.Clear();
        }

        private void rbM2T_CheckedChanged(object sender, EventArgs e)
        {
            txtMorse.ReadOnly = false;
            txtText.ReadOnly = true;
            //txtText.Clear();
        }

        private void btnPlaySounds_Click(object sender, EventArgs e)//player doesn't work
        {  
            //open
            SoundPlayer diPlayer = new SoundPlayer(Morse_Codes.Properties.Resources.di);
            SoundPlayer daPlayer = new SoundPlayer(Morse_Codes.Properties.Resources.da);
            SoundPlayer spacePlayer = new SoundPlayer(Morse_Codes.Properties.Resources.piano_a3);
            //Beep.BeepBeep(1000, 1000, 1000);
            //Console.Beep(5000, 1000);
            
            string codes = txtMorse.Text;

            foreach (char c in codes)//without MessageBox.Show(c.ToString()), only play the last 1 sound, is it too fast and mix together to hear?
            {
                switch (c)
                {
                    case '.':
                        //diPlayer.Play();
                        Console.Beep(4000, 250);
                        break;
                    case '-':
                        Console.Beep(1000, 250);
                        break;
                    case ' ':
                        Console.Beep(500, 750);
                        break;
                    case '/':
                        Console.Beep(250, 750);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}

