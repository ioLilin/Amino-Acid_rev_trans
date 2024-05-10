using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

            List<string> dnaseq = new List<string>();

            foreach (char x in Input)
            {
                string d = Trans.TRANS(x);
                dnaseq.Add(d);
            }

            _ = dnaseq.ToArray();
            string result = string.Join("", dnaseq);
          
            OutputBox.Text = result;
        }
        public string GetInputValue()
        {
            return Input;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form dlg1 = new Form();
            dlg1.FormBorderStyle = FormBorderStyle.FixedDialog;
            dlg1.Size = new Size(700, 300);

            Label lbabout = new Label();
            lbabout.Text = "Thanks for using this program!\n\nThis program is free and open source. " +
                "\n\nIf you have any questions or suggestions, please contact me at Github:https://github.com/ioLilin!" +
                "\n\n感谢使用本程序！本程序为免费开源软件，如果您有任何问题或建议，请通过Github联系我:https://github.com/ioLilin!\n\nGYQ";               
           // lbabout.Location = new Point(dlg1.Width / 2 - lbabout.Width / 2, dlg1.Height / 2 - lbabout.Height / 2);
            lbabout.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbabout.AutoSize = true;

            // 将Label添加到对话框的Controls集合中
            dlg1.Controls.Add(lbabout);

            dlg1.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

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