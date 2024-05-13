using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bio_helper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string Input;
        private void button2_Click(object sender, EventArgs e)
        {
            OutputBox.Clear();
            InputBox.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Trans = new Trans();
            Input = InputBox.Text;
            Input = Input.ToUpper();
            string result1 = "";
           
            if (comboBox1.Text == "Protein to DNA")
            {
                 List<string> dnaseq = new List<string>();

                    foreach (char x in Input)
                    {
                        string d = Trans.TRANS(x);
                        dnaseq.Add(d);
                    }

                 _ = dnaseq.ToArray();

                 result1 = string.Join("", dnaseq);                 
            }

            if (comboBox1.Text == "DNA to Protein")
            {
                string proteinseq = "";

                for (int i = 0; i < Input.Length; i += 3)
                {
                    string d = Input.Substring(i, Math.Min(3, Input.Length - i));
                    char c = Trans.TRSL(d);
                    proteinseq += c;
                }

                _ = proteinseq.ToArray();

                result1 = string.Join("", proteinseq);

            }

            OutputBox.Text = result1;
            
        }     

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form dlg1 = new Form
            {
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Size = new Size(700, 300)
            };

            Label lbabout = new Label
            {
                Text = "Thanks for using this program!\n\nThis program is free and open source. " +
                "\n\nIf you have any questions or suggestions, please contact me at Github:https://github.com/ioLilin!" +
                "\n\n感谢使用本程序！本程序为免费开源软件，如果您有任何问题或建议，请通过Github联系我:https://github.com/ioLilin!\n\nGYQ",

                Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right,
                AutoSize = true
            };


            // 将Label添加到对话框的Controls集合中
            dlg1.Controls.Add(lbabout);

            dlg1.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Copyclick(object sender, EventArgs e)
        {
            Clipboard.SetText(OutputBox.Text);
        }
    }


    public class Trans
    {       

        public string TRANS(char a)
        {
            string[] b = new string[0];

            switch (a)
            {
                case 'A':
                    b = Condon.codon_A;
                    break;
                case 'G':
                    b = Condon.codon_G;
                    break;
                case 'E':
                    b = Condon.codon_E;
                    break;
                case 'D':
                    b = Condon.codon_D;
                    break;
                case 'V':
                    b = Condon.codon_V;
                    break;
                case 'R':
                    b = Condon.codon_R;
                    break;
                case 'S':
                    b = Condon.codon_S;
                    break;
                case 'K':
                    b = Condon.codon_K;
                    break;
                case 'N':
                    b = Condon.codon_N;
                    break;
                case 'M':
                    b = Condon.codon_M;
                    break;
                case 'I':
                    b = Condon.codon_I;
                    break;
                case 'T':
                    b = Condon.codon_T;
                    break;
                case 'W':
                    b = Condon.codon_W;
                    break;
                case 'C':
                    b = Condon.codon_C;
                    break;
                case 'Y':
                    b = Condon.codon_Y;
                    break;
                case 'L':
                    b = Condon.codon_L;
                    break;
                case 'F':
                    b = Condon.codon_F;
                    break;
                case 'Q':
                    b = Condon.codon_Q;
                    break;
                case 'H':
                    b = Condon.codon_H;
                    break;
                case 'P':
                    b = Condon.codon_P;
                    break;
                default:
                    b = new string[] { "NNN" };
                    break;
            }

            Random random = new Random();    // 使用 Random 类来获取随机索引
            int randomIndex = random.Next(b.Length);   // 随机索引
            string c = b[randomIndex];     // 将随机选中的字符串赋值给字符串 c
            return c;
        }
        public char TRSL(string ps)
        {
            char fc = ps.Substring(0, 1)[0]; // 获取第一个字符
            char sc = ps.Substring(1, 1)[0]; // 获取第二个字符
            char tc = ps.Substring(2, 1)[0]; // 获取第三个字符
            char AA = '*';
                        
            if(fc == 'A')
            {
                if(sc == 'A')
                {
                    if(tc == 'A' || tc == 'G')  AA = 'K'; 
                    if(tc == 'C' || tc == 'T')  AA = 'N';
                }
                if(sc == 'T')
                {
                    if(tc == 'A' || tc == 'C' || tc == 'T')  AA = 'I';
                    if(tc == 'G')  AA = 'M';
                }
                if(sc == 'C')  AA = 'T';
                if(sc == 'G')
                {
                    if (tc == 'C' || tc == 'T') AA = 'S';
                    if (tc == 'A' || tc == 'G') AA = 'R';
                }
            }
            if (fc == 'T')
            {
                if (sc == 'A')
                {
                    if (tc == 'C' || tc == 'T') AA = 'Y';
                    if (tc == 'A' || tc == 'G') AA = '*';
                }
                if (sc == 'T')
                {
                    if (tc == 'C' || tc == 'T') AA = 'F';
                    if (tc == 'A' || tc == 'G') AA = 'L';
                }
                if (sc == 'C') AA = 'S';
                if (sc == 'G')
                {
                    if (tc == 'C' || tc == 'T') AA = 'C';
                    if (tc == 'G') AA = 'W';
                    if (tc == 'A') AA = '*';
                }
            }
            if (fc == 'C')
            {
                if (sc == 'A')
                {
                    if (tc == 'C' || tc == 'T') AA = 'H';
                    if (tc == 'A' || tc == 'G') AA = 'Q';
                }
                if (sc == 'T') AA = 'L';
                if (sc == 'C') AA = 'P';
                if (sc == 'G') AA = 'R';
            }
            if (fc == 'G')
            {
                if (sc == 'A')
                {
                    if (tc == 'C' || tc == 'T') AA = 'D';
                    if (tc == 'A' || tc == 'G') AA = 'E';
                }
                if (sc == 'T') AA = 'V';
                if (sc == 'C') AA = 'A';
                if (sc == 'G') AA = 'G';
            }     
              return AA;
        }
    }

    public class Condon
    {
        public static string[] codon_A = new string[] { "GCG", "GCG", "GCG", "GCG", "GCG", "GCA", "GCA", "GCA", "GCT", "GCT", "GCC", "GCC", "GCC" };

        public static string[] codon_G = new string[] { "GGG", "GGG", "GGG", "GGT", "GGT", "GGT", "GGC", "GGC", "GGC", "GGC" };

        public static string[] codon_E = new string[] { "GAG", "GAA", "GAA" };

        public static string[] codon_D = new string[] { "GAT", "GAT", "GAC" };

        public static string[] codon_V = new string[] { "GTG", "GTG", "GTG", "GTG", "GTA", "GTA", "GTT", "GTT", "GTT", "GTC", "GTC" };

        public static string[] codon_R = new string[] {
    "AGG", "AGA", "CGG", "CGG", "CGA", "CGA", "CGT", "CGT", "CGT", "CGT", "CGT", "CGT", "CGT", "CGT", "CGT", "CGT", "CGT",
    "CGT", "CGT", "CGT", "CGT", "CGT", "CGT", "CGT", "CGT", "CGC", "CGC", "CGC", "CGC", "CGC", "CGC", "CGC",
    "CGC", "CGC", "CGC", "CGC", "CGC", "CGC", "CGC", "CGC", "CGC"
    };

        public static string[] codon_S = new string[] { "AGT", "AGC", "AGC", "TCG", "TCA", "TCT", "TCC" };

        public static string[] codon_K = new string[] { "AAG", "AAA", "AAA", "AAA" };

        public static string[] codon_N = new string[] { "AAT", "AAC" };

        public static string[] codon_I = new string[] {
    "ATA", "ATC", "ATC", "ATC", "ATC", "ATT", "ATT", "ATT", "ATT", "ATT"
    };

        public static string[] codon_T = new string[] {
    "ACG", "ACG", "ACG", "ACA", "ACT", "ACT", "ACC", "ACC", "ACC", "ACC"
    };

        public static string[] codon_C = new string[] { "TGT", "TGC" };

        public static string[] codon_Y = new string[] { "TAT", "TAT", "TAT", "TAC", "TAC" };

        public static string[] codon_L = new string[] {
    "TTG", "TTA", "CTG", "CTG", "CTG", "CTG", "CTG", "CTA", "CTT", "CTC"
    };

        public static string[] codon_F = new string[] { "TTT", "TTC" };

        public static string[] codon_Q = new string[] { "CAG", "CAG", "CAA" };

        public static string[] codon_H = new string[] {
    "CAT", "CAT", "CAT", "CAT", "CAC", "CAC", "CAC"
    };

        public static string[] codon_P = new string[] {
    "CCG", "CCG", "CCG", "CCG", "CCG", "CCA", "CCA", "CCT", "CCT", "CCC"
    };

        public static string[] codon_M = new string[] { "ATG" };

        public static string[] codon_W = new string[] { "TGG" };
    }
}