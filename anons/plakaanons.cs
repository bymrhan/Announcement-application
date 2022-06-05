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
using System.Threading;

namespace anons
{
    public partial class plakaanons : Form
    {
        public plakaanons()
        {
            InitializeComponent();
        }
        SoundPlayer splayer = new SoundPlayer();
        
        private void btnzil_Click(object sender, EventArgs e)
        {

            splayer.SoundLocation = Application.StartupPath + "\\Sesler\\zil_plaka.wav";          
            splayer.Play();
            Thread.Sleep(200);
        }

        private void btnplaka_Click(object sender, EventArgs e)
        {
            this.Hide();
            anasayfa frm = new anasayfa();
            frm.ShowDialog();
            
        }
        string dosyaisim;
        private void anonset(string dosyaisim)
        {
            splayer.SoundLocation = Application.StartupPath + "\\Sesler\\personel\\"+dosyaisim;
            splayer.Play();
            Thread.Sleep(200);
        }
        
        private void btncuma_Click(object sender, EventArgs e)
        {
            dosyaisim = "cuma.wav";
            anonset(dosyaisim);
        }

        private void btnmaske_Click(object sender, EventArgs e)
        {
            dosyaisim = "maske-sosy.wav";
            anonset(dosyaisim);
        }

        private void btn15dk_Click(object sender, EventArgs e)
        {
            dosyaisim = "cuma15.wav";
            anonset(dosyaisim);
        }

        private void btnkapanıs_Click(object sender, EventArgs e)
        {
            dosyaisim = "kapandi.wav";
            anonset(dosyaisim);
        }

        private void btnkasa_Click(object sender, EventArgs e)
        {         
            dosyaisim = "kasaya ltf.wav";
            anonset(dosyaisim);
           
        }

        private void btnali_Click(object sender, EventArgs e)
        {
            dosyaisim = "ali.wav";
            anonset(dosyaisim);
        }

        private void btnhamit_Click(object sender, EventArgs e)
        {
            dosyaisim = "hamit.wav";
            anonset(dosyaisim);
        }

        private void btnhalil_Click(object sender, EventArgs e)
        {
            dosyaisim = "halil.wav";
            anonset(dosyaisim);
        }

        private void btnmerve_Click(object sender, EventArgs e)
        {
            dosyaisim = "merve.wav";
            anonset(dosyaisim);
        }

        private void btnmuhammed_Click(object sender, EventArgs e)
        {
            dosyaisim = "muhammed.wav";
            anonset(dosyaisim);
        }

        private void btnoguzhan_Click(object sender, EventArgs e)
        {
            dosyaisim = "oguzhan.wav";
            anonset(dosyaisim);
        }

        private void btnomer_Click(object sender, EventArgs e)
        {
            dosyaisim = "omer.wav";
            anonset(dosyaisim);
        }

        private void btnruveyda_Click(object sender, EventArgs e)
        {
            dosyaisim = "ruveyda.wav";
            anonset(dosyaisim);
        }

        private void btnyakup_Click(object sender, EventArgs e)
        {
            dosyaisim = "yakup.wav";
            anonset(dosyaisim);
        }

        private void btnzeynep_Click(object sender, EventArgs e)
        {
            dosyaisim = "zeynep.wav";
            anonset(dosyaisim);
        }

        private void btngulsen_Click(object sender, EventArgs e)
        {
            dosyaisim = "gulsen.wav";
            anonset(dosyaisim);
        }

        private void btnayse_Click(object sender, EventArgs e)
        {
            dosyaisim = "ayse.wav";
            anonset(dosyaisim);
        }

        private void btnaysegul_Click(object sender, EventArgs e)
        {
            dosyaisim = "aysegul.wav";
            anonset(dosyaisim);
        }

        private void btnazize_Click(object sender, EventArgs e)
        {
            dosyaisim = "azize.wav";
            anonset(dosyaisim);
        }

        private void btnburak_Click(object sender, EventArgs e)
        {
            dosyaisim = "burak.wav";
            anonset(dosyaisim);
        }

        private void btnemin_Click(object sender, EventArgs e)
        {
            dosyaisim = "emin.wav";
            anonset(dosyaisim);
        }

        private void btnemincan_Click(object sender, EventArgs e)
        {
            dosyaisim = "emincan.wav";
            anonset(dosyaisim);
        }

        private void btnerol_Click(object sender, EventArgs e)
        {
            dosyaisim = "erol.wav";
            anonset(dosyaisim);
        }

        private void btnfurkan_Click(object sender, EventArgs e)
        {
            dosyaisim = "furkan.wav";
            anonset(dosyaisim);
        }

        private void btngizem_Click(object sender, EventArgs e)
        {
            dosyaisim = "gizem.wav";
            anonset(dosyaisim);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime bugun = DateTime.Now;
            zaman.Text = bugun.ToString();
        }

        private void plakaanons_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            Form pa = Application.OpenForms["plakaanons"];
            Form ka = Application.OpenForms["anasayfa"];

            if (pa != null && pa != null)
            {
                pa.Close();            
                ka.Close();
            }
        }
    }
}
