using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgi_Yarışması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int questionnumber = 0, trust = 0, wrong = 0;
        

        private void btnB_Click(object sender, EventArgs e)
        {
            btnsonraki.Enabled = true;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;

            label5.Text = btnB.Text;
            if (label4.Text == label5.Text)
            {
                trust++;
                lbldoğru.Text = trust.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                wrong++;
                lblyanlış.Text = wrong.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnsonraki.Enabled = true;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;


            label5.Text = btnC.Text;
            if (label4.Text == label5.Text)
            {
                trust++;
                lbldoğru.Text = trust.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                wrong++;
                lblyanlış.Text = wrong.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnsonraki.Enabled = true;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;


            label5.Text = btnD.Text;
            if (label4.Text == label5.Text)
            {
                trust++;
                lbldoğru.Text = trust.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                wrong++;
                lblyanlış.Text = wrong.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Enabled = false;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled=false;
            btnD.Enabled = false;
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            btnsonraki.Enabled = true;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;


            label5.Text = btnA.Text;
            if (label4.Text == label5.Text)
            {
                trust++;
                lbldoğru.Text = trust.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                wrong++;
                lblyanlış.Text = wrong.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnsonraki_Click(object sender, EventArgs e)
        {
            richTextBox1.Enabled=false;
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnsonraki.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            questionnumber++;
            lblsoruno.Text = questionnumber.ToString();

            if (questionnumber == 1)
            {
                richTextBox1.Text = "Cumhuriyet Kaç Yılında İlan edilmiştir?";
                btnA.Text = "1920";
                btnB.Text = "1921";
                btnC.Text = "1922";
                btnD.Text = "1923";
                label4.Text = "1923";
            }
            if (questionnumber == 2)
            {
                richTextBox1.Text = "Hangi İl Ege Bölgemizde Bulunmaz";
                btnA.Text = "İzmir";
                btnB.Text = "Balıkesir";
                btnC.Text = "Aydın";
                btnD.Text = "Manisa";
                label4.Text = "Balıkesir";

            }
            if (questionnumber == 3)
            {
                richTextBox1.Text = "Son Kuşlar kitabı hangi yazarımıza aittir?";
                btnA.Text = "Sait Faik";
                btnB.Text = "Cemal Süreya";
                btnC.Text = "Atilla İlhan";
                btnD.Text = "Reşat Nuri";
                label4.Text = "Sait Faik";
                btnsonraki.Text = "Sonuçlar";

            }
            if (questionnumber == 4)
            {
                questionnumber--;
                lblsoruno.Text = questionnumber.ToString();
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnsonraki.Enabled = false;
                MessageBox.Show("Doğru: " + trust + "\n" + "Yanlış: " + wrong);
            }
        }
    }
}
