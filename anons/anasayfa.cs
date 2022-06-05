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
    public partial class anasayfa : Form
    {

      
        public anasayfa()
        {
            InitializeComponent();
           
        }

        SoundPlayer splayer = new SoundPlayer();
        private void btnanaonset_Click(object sender, EventArgs e)
        {
        
            try
            {

                SoundPlayer splayer8 = new SoundPlayer();

                splayer8.SoundLocation = Application.StartupPath + "\\Sesler\\zil_plaka.wav";
                splayer8.Play();
                Thread.Sleep(2000);

                ////plaka şehir no
                int il = Convert.ToInt32(txt_il.Text);
                int il1 = (il / 10) * 10;
                int il2 = il % 10;
                //textBox4.Text = il.ToString();
                string dizin = Application.StartupPath + "\\Sesler\\Rakamlar\\" + il1 + ".wav";
                string dizin2 = Application.StartupPath + "\\Sesler\\Rakamlar\\" + il2 + ".wav";
                SoundPlayer splayer = new SoundPlayer();
                splayer.SoundLocation = dizin;
                splayer.Play();
                Thread.Sleep(900);

                if (il < 10)
                {
                    SoundPlayer splayer2 = new SoundPlayer();
                    int ill = int.Parse(txt_il.Text);

                    splayer2.SoundLocation = Application.StartupPath + "\\Sesler\\Rakamlar\\" + ill + ".wav";
                    splayer2.Play();
                    Thread.Sleep(700);

                }
                if (il > 10 && il2 != 0)
                {
                    SoundPlayer splayer2 = new SoundPlayer();
                    splayer2.SoundLocation = dizin2;
                    splayer2.Play();
                    Thread.Sleep(1000);
                }
                ////plaka şehir no

                //// plaka harf kısmı
                try
                {



                    string[] harf = new string[3];
                    string kontrol = guna2TextBox2.Text;

                    for (int i = 0; i < kontrol.Length; i++)
                    {
                        harf[i] = Convert.ToString(kontrol[i]);
                    }
                    for (int i = 0; i < harf.Length; i++)
                    {
                        splayer.SoundLocation = Application.StartupPath + "\\Sesler\\İLLER\\" + harf[i] + ".wav";
                        splayer.Play();
                        Thread.Sleep(1100);
                    }


                }
                catch (Exception aciklama)
                {

                  
                }

                //// plaka harf kısmı

                //// plaka kod kısmı
                int no1, no2, no3, no4;
                if (txt_no.Text.Length == 4)
                {
                    int no = int.Parse(txt_no.Text);
                    no1 = (no / 1000) * 10;
                    if (no % 1000 == 0)
                    {
                        if (no > 1000)
                        {

                            splayer.SoundLocation = Application.StartupPath + "\\Sesler\\Rakamlar\\" + no / 1000 + ".wav";
                            splayer.Play();
                            Thread.Sleep(900);
                        }
                        splayer.SoundLocation = Application.StartupPath + "\\Sesler\\Rakamlar\\1000.wav";
                        splayer.Play();
                        Thread.Sleep(900);

                    }
                    else
                    {
                        no2 = ((no - (no1 * 100)) / 100);
                        no3 = ((no - ((no1 + no2) * 100)) / 10) * 10;
                        no4 = (no - (((no1 + no2) * 100) + no3));



                        if (no4 != 0 && no2 != 0 && no3 != 0)
                        {
                            listBox1.Items.Add(no1.ToString() + no2.ToString() + no3.ToString() + no4.ToString());
                            splayer.SoundLocation = Application.StartupPath + "\\Sesler\\Rakamlar\\" + no1 + ".wav";
                            splayer.Play();
                            Thread.Sleep(900);
                            splayer.SoundLocation = Application.StartupPath + "\\Sesler\\Rakamlar\\" + no2 + ".wav";
                            splayer.Play();
                            Thread.Sleep(900);
                            splayer.SoundLocation = Application.StartupPath + "\\Sesler\\Rakamlar\\" + no3 + ".wav";
                            splayer.Play();
                            Thread.Sleep(900);
                            splayer.SoundLocation = Application.StartupPath + "\\Sesler\\Rakamlar\\" + no4 + ".wav";
                            splayer.Play();
                            Thread.Sleep(900);

                        }
                        else if (no2 == 0 && no4 == 0)
                        {
                            splayer.SoundLocation = Application.StartupPath + "\\Sesler\\Rakamlar\\" + no1 + ".wav";
                            splayer.Play();
                            Thread.Sleep(900);
                            splayer.SoundLocation = Application.StartupPath + "\\Sesler\\Rakamlar\\" + no3 + ".wav";
                            splayer.Play();
                            Thread.Sleep(900);

                        }
                        else if (no3 == 0)
                        {
                            listBox1.Items.Add(no1.ToString() + no2.ToString() + no3.ToString() + no4.ToString());
                            splayer.SoundLocation = Application.StartupPath + "\\Sesler\\Rakamlar\\" + no1 + ".wav";
                            splayer.Play();
                            Thread.Sleep(900);
                            splayer.SoundLocation = Application.StartupPath + "\\Sesler\\Rakamlar\\0.wav";
                            splayer.Play();
                            Thread.Sleep(900);
                            splayer.SoundLocation = Application.StartupPath + "\\Sesler\\Rakamlar\\" + no4 + ".wav";
                            splayer.Play();
                            Thread.Sleep(900);
                        }
                        else if (no2 == 0)
                        {
                            listBox1.Items.Add(no1.ToString() + no2.ToString() + no3.ToString() + no4.ToString());
                            splayer.SoundLocation = Application.StartupPath + "\\Sesler\\Rakamlar\\" + no1 + ".wav";
                            splayer.Play();
                            Thread.Sleep(900);
                            splayer.SoundLocation = Application.StartupPath + "\\Sesler\\Rakamlar\\" + no3 + ".wav";
                            splayer.Play();
                            Thread.Sleep(900);
                            splayer.SoundLocation = Application.StartupPath + "\\Sesler\\Rakamlar\\" + no4 + ".wav";
                            splayer.Play();
                            Thread.Sleep(900);
                        }
                        else if (no4 == 0)
                        {
                            splayer.SoundLocation = Application.StartupPath + "\\Sesler\\Rakamlar\\" + no1 + ".wav";
                            splayer.Play();
                            Thread.Sleep(900);
                            splayer.SoundLocation = Application.StartupPath + "\\Sesler\\Rakamlar\\" + no2 + ".wav";
                            splayer.Play();
                            Thread.Sleep(900);
                            splayer.SoundLocation = Application.StartupPath + "\\Sesler\\Rakamlar\\" + no3 + ".wav";
                            splayer.Play();
                            Thread.Sleep(900);
                        }

                    }
                }


                else if (txt_no.Text.Length == 3)
                {
                    int no = int.Parse(txt_no.Text);
                    no1 = (no / 100) * 100;
                    if (no % 100 == 0)
                    {
                        listBox1.Items.Add(no1.ToString());
                        splayer.SoundLocation = Application.StartupPath + "\\Sesler\\Rakamlar\\" + no1 + ".wav";
                        splayer.Play();
                        Thread.Sleep(850);
                    }
                    else
                    {
                        no2 = ((no - no1) / 10) * 10;
                        no3 = (no - (no1 + no2));



                        if (no3 != 0 && no2 != 0)
                        {
                            listBox1.Items.Add(no1.ToString() + no2.ToString() + no3.ToString());
                            splayer.SoundLocation = Application.StartupPath + "\\Sesler\\Rakamlar\\" + no1 + ".wav";
                            splayer.Play();
                            Thread.Sleep(800);
                            splayer.SoundLocation = Application.StartupPath + "\\Sesler\\Rakamlar\\" + no2 + ".wav";
                            splayer.Play();
                            Thread.Sleep(900);
                            splayer.SoundLocation = Application.StartupPath + "\\Sesler\\Rakamlar\\" + no3 + ".wav";
                            splayer.Play();
                            Thread.Sleep(800);
                        }
                        else if (no1 == 0 && no2 == 0)
                        {
                            listBox1.Items.Add(no1.ToString() + no2.ToString() + no3.ToString());
                            splayer.SoundLocation = Application.StartupPath + "\\Sesler\\Rakamlar\\" + no1 + ".wav";
                            splayer.Play();
                            Thread.Sleep(800);
                            splayer.SoundLocation = Application.StartupPath + "\\Sesler\\Rakamlar\\" + no2 + ".wav";
                            splayer.Play();
                            Thread.Sleep(900);
                            splayer.SoundLocation = Application.StartupPath + "\\Sesler\\Rakamlar\\" + no3 + ".wav";
                            splayer.Play();
                            
                        }
                        else if (no2 == 0)
                        {
                            listBox1.Items.Add(no1.ToString() + no3.ToString());
                            splayer.SoundLocation = Application.StartupPath + "\\Sesler\\Rakamlar\\" + no1 + ".wav";
                            splayer.Play();
                            Thread.Sleep(800);
                            splayer.SoundLocation = Application.StartupPath + "\\Sesler\\Rakamlar\\" + no3 + ".wav";
                            splayer.Play();
                            Thread.Sleep(800);

                        }
                        else if (no3 == 0)
                        {
                            listBox1.Items.Add(no1.ToString() + no2.ToString());
                            splayer.SoundLocation = Application.StartupPath + "\\Sesler\\Rakamlar\\" + no1 + ".wav";
                            splayer.Play();
                            Thread.Sleep(800);
                            splayer.SoundLocation = Application.StartupPath + "\\Sesler\\Rakamlar\\" + no2 + ".wav";
                            splayer.Play();                          
                        }

                    }


                }
                ///plaka kod kısmı
                splayer8.SoundLocation = Application.StartupPath + "\\Sesler\\plakali.wav";
                splayer8.Play();
            }
            catch (Exception)
            {
            
            }
        }

        private void btnzil_Click(object sender, EventArgs e)
        {
            splayer.SoundLocation = Application.StartupPath + "\\Sesler\\zil_plaka.wav";
            splayer.Play();
            Thread.Sleep(200);
        }

        private void btnpersonelanons_Click(object sender, EventArgs e)
        {
            Form pa = Application.OpenForms["plakaanons"];

            if (pa != null)
            {
                pa.Show();
                Form ka = Application.OpenForms["anasayfa"];
                ka.Close();

            }                                      
        }

        string dosyaisim;
        private void anonset(string dosyaisim)
        {
            splayer.SoundLocation = Application.StartupPath + dosyaisim;
            splayer.Play();
            Thread.Sleep(200);
        }
        private void btnrakam0_Click(object sender, EventArgs e)
        {
            dosyaisim = "\\Sesler\\Rakamlar\\" + "0.wav";
            anonset(dosyaisim);
        }

        private void btnrakam1_Click(object sender, EventArgs e)
        {
            dosyaisim = "\\Sesler\\Rakamlar\\" + "1.wav";
            anonset(dosyaisim);
        }

        private void btnrakam2_Click(object sender, EventArgs e)
        {
            dosyaisim = "\\Sesler\\Rakamlar\\" + "2.wav";
            anonset(dosyaisim);
        }

        private void btnrakam3_Click(object sender, EventArgs e)
        {
            dosyaisim = "\\Sesler\\Rakamlar\\" + "3.wav";
            anonset(dosyaisim);
        }

        private void btnrakam4_Click(object sender, EventArgs e)
        {
            dosyaisim = "\\Sesler\\Rakamlar\\" + "4.wav";
            anonset(dosyaisim);
        }

        private void btnrakam5_Click(object sender, EventArgs e)
        {
            dosyaisim = "\\Sesler\\Rakamlar\\" + "5.wav";
            anonset(dosyaisim);
        }

        private void btnrakam6_Click(object sender, EventArgs e)
        {
            dosyaisim = "\\Sesler\\Rakamlar\\" + "6.wav";
            anonset(dosyaisim);
        }

        private void btnrakam7_Click(object sender, EventArgs e)
        {
            dosyaisim = "\\Sesler\\Rakamlar\\" + "7.wav";
            anonset(dosyaisim);
        }

        private void btnrakam8_Click(object sender, EventArgs e)
        {
            dosyaisim = "\\Sesler\\Rakamlar\\" + "8.wav";
            anonset(dosyaisim);
        }

        private void btnrakam9_Click(object sender, EventArgs e)
        {
            dosyaisim = "\\Sesler\\Rakamlar\\" + "9.wav";
            anonset(dosyaisim);
        }

        private void btnrakam00_Click(object sender, EventArgs e)
        {
            dosyaisim = "\\Sesler\\Rakamlar\\" + "00.wav";
            anonset(dosyaisim);
        }

        private void btnrakam10_Click(object sender, EventArgs e)
        {
            dosyaisim = "\\Sesler\\Rakamlar\\" + "10.wav";
            anonset(dosyaisim);
        }

        private void btnrakam20_Click(object sender, EventArgs e)
        {
            dosyaisim = "\\Sesler\\Rakamlar\\" + "20.wav";
            anonset(dosyaisim);
        }

        private void btnrakam30_Click(object sender, EventArgs e)
        {
            dosyaisim = "\\Sesler\\Rakamlar\\" + "30.wav";
            anonset(dosyaisim);
        }

        private void btnrakam40_Click(object sender, EventArgs e)
        {
            dosyaisim = "\\Sesler\\Rakamlar\\" + "40.wav";
            anonset(dosyaisim);
        }

        private void btnrakam50_Click(object sender, EventArgs e)
        {
            dosyaisim = "\\Sesler\\Rakamlar\\" + "50.wav";
            anonset(dosyaisim);
        }

        private void btnrakam60_Click(object sender, EventArgs e)
        {
            dosyaisim = "\\Sesler\\Rakamlar\\" + "60.wav";
            anonset(dosyaisim);
        }

        private void btnrakam70_Click(object sender, EventArgs e)
        {
            dosyaisim = "\\Sesler\\Rakamlar\\" + "70.wav";
            anonset(dosyaisim);
        }

        private void btnrakam80_Click(object sender, EventArgs e)
        {
            dosyaisim = "\\Sesler\\Rakamlar\\" + "80.wav";
            anonset(dosyaisim);
        }

        private void btnrakam90_Click(object sender, EventArgs e)
        {
            dosyaisim = "\\Sesler\\Rakamlar\\" + "90.wav";
            anonset(dosyaisim);
        }

        private void btnrakam100_Click(object sender, EventArgs e)
        {
            dosyaisim = "\\Sesler\\Rakamlar\\" + "100.wav";
            anonset(dosyaisim);
        }

        private void btnrakam200_Click(object sender, EventArgs e)
        {
            dosyaisim = "\\Sesler\\Rakamlar\\" + "200.wav";
            anonset(dosyaisim);
        }

        private void btnrakam300_Click(object sender, EventArgs e)
        {
            dosyaisim = "\\Sesler\\Rakamlar\\" + "300.wav";
            anonset(dosyaisim);
        }

        private void btnrakam400_Click(object sender, EventArgs e)
        {
            dosyaisim = "\\Sesler\\Rakamlar\\" + "400.wav";
            anonset(dosyaisim);
        }

        private void btnrakam500_Click(object sender, EventArgs e)
        {
            dosyaisim = "\\Sesler\\Rakamlar\\" + "500.wav";
            anonset(dosyaisim);
        }

        private void btnrakam600_Click(object sender, EventArgs e)
        {
            dosyaisim = "\\Sesler\\Rakamlar\\" + "600.wav";
            anonset(dosyaisim);
        }

        private void btnrakam700_Click(object sender, EventArgs e)
        {
            dosyaisim = "\\Sesler\\Rakamlar\\" + "700.wav";
            anonset(dosyaisim);
        }

        private void btnrakam800_Click(object sender, EventArgs e)
        {
            dosyaisim = "\\Sesler\\Rakamlar\\" + "800.wav";
            anonset(dosyaisim);
        }

        private void btnrakam900_Click(object sender, EventArgs e)
        {
            dosyaisim = "\\Sesler\\Rakamlar\\" + "900.wav";
            anonset(dosyaisim);
        }

        private void btnsehira_Click(object sender, EventArgs e)
        {
            dosyaisim = "\\Sesler\\İLLER\\" + "A.wav";
            anonset(dosyaisim);
        }

        private void btnsehirb_Click(object sender, EventArgs e)
        {
            dosyaisim = "\\Sesler\\İLLER\\" + "B.wav";
            anonset(dosyaisim);
        }

        private void btnsehirc_Click(object sender, EventArgs e)
        {
            dosyaisim = "\\Sesler\\İLLER\\" + "C.wav";
            anonset(dosyaisim);
        }

        private void btnsehird_Click(object sender, EventArgs e)
        {
            dosyaisim = "\\Sesler\\İLLER\\" + "D.wav";
            anonset(dosyaisim);
        }

        private void btnsehire_Click(object sender, EventArgs e)
        {
            dosyaisim = "\\Sesler\\İLLER\\" + "E.wav";
            anonset(dosyaisim);
        }

        private void btnsehirf_Click(object sender, EventArgs e)
        {
            dosyaisim = "\\Sesler\\İLLER\\" + "F.wav";
            anonset(dosyaisim);
        }

        private void btnsehirg_Click(object sender, EventArgs e)
        {
            dosyaisim = "\\Sesler\\İLLER\\" + "G.wav";
            anonset(dosyaisim);
        }

        private void btnsehirh_Click(object sender, EventArgs e)
        {
            dosyaisim = "\\Sesler\\İLLER\\" + "H.wav";
            anonset(dosyaisim);
        }

        private void btnsehirı_Click(object sender, EventArgs e)
        {
            dosyaisim = "\\Sesler\\İLLER\\" + "I.wav";
            anonset(dosyaisim);
        }

        private void btnsehiri_Click(object sender, EventArgs e)
        {
            dosyaisim = "\\Sesler\\İLLER\\" + "İ.wav";
            anonset(dosyaisim);
        }

        private void btnsehirj_Click(object sender, EventArgs e)
        {
            dosyaisim = "\\Sesler\\İLLER\\" + "J.wav";
            anonset(dosyaisim);
        }

        private void btnsehirk_Click(object sender, EventArgs e)
        {
            dosyaisim = "\\Sesler\\İLLER\\" + "K.wav";
            anonset(dosyaisim);
        }

        private void btnsehirl_Click(object sender, EventArgs e)
        {
            dosyaisim = "\\Sesler\\İLLER\\" + "L.wav";
            anonset(dosyaisim);
        }

        private void btnsehirm_Click(object sender, EventArgs e)
        {
            dosyaisim = "\\Sesler\\İLLER\\" + "M.wav";
            anonset(dosyaisim);
        }

        private void btnsehirn_Click(object sender, EventArgs e)
        {
            dosyaisim = "\\Sesler\\İLLER\\" + "N.wav";
            anonset(dosyaisim);
        }

        private void btnsehiro_Click(object sender, EventArgs e)
        {
            dosyaisim = "\\Sesler\\İLLER\\" + "O.wav";
            anonset(dosyaisim);
        }

        private void btnsehirp_Click(object sender, EventArgs e)
        {
            dosyaisim = "\\Sesler\\İLLER\\" + "P.wav";
            anonset(dosyaisim);
        }

        private void btnsehirr_Click(object sender, EventArgs e)
        {
            dosyaisim = "\\Sesler\\İLLER\\" + "R.wav";
            anonset(dosyaisim);
        }

        private void btnsehirs_Click(object sender, EventArgs e)
        {
            dosyaisim = "\\Sesler\\İLLER\\" + "S.wav";
            anonset(dosyaisim);
        }

        private void btnsehirt_Click(object sender, EventArgs e)
        {
            dosyaisim = "\\Sesler\\İLLER\\" + "T.wav";
            anonset(dosyaisim);
        }

        private void btnsehiru_Click(object sender, EventArgs e)
        {
            dosyaisim = "\\Sesler\\İLLER\\" + "U.wav";
            anonset(dosyaisim);
        }

        private void btnsehirv_Click(object sender, EventArgs e)
        {
            dosyaisim = "\\Sesler\\İLLER\\" + "V.wav";
            anonset(dosyaisim);
        }

        private void btnsehiry_Click(object sender, EventArgs e)
        {
            dosyaisim = "\\Sesler\\İLLER\\" + "Y.wav";
            anonset(dosyaisim);
        }

        private void btnsehirz_Click(object sender, EventArgs e)
        {
            dosyaisim = "\\Sesler\\İLLER\\" + "Z.wav";
            anonset(dosyaisim);
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            guna2TextBox2.Text = guna2TextBox2.Text.ToUpper();
            guna2TextBox2.SelectionStart = guna2TextBox2.Text.Length;
        }

        private void txt_il_TextChanged(object sender, EventArgs e)
        {
            if (txt_il.Text != "")
            {
                int sayi = Convert.ToInt32(txt_il.Text);
                if (sayi >= 81)
                {
                    MessageBox.Show("01 ile 81 arasında sayı giriniz");
                    txt_il.Clear();
                }
            }
        }

        private void txt_il_KeyPress(object sender, KeyPressEventArgs e)
        {
            txt_il.MaxLength = 2;
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_no_KeyPress(object sender, KeyPressEventArgs e)
        {
            txt_no.MaxLength = 4;
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void guna2TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            guna2TextBox2.ShortcutsEnabled = false;
            guna2TextBox2.MaxLength = 4;
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
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
