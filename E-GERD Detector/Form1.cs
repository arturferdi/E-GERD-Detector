using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerdQ
{
    public partial class Form1 : Form
    {
        //=========================================================================================//
        //=========================================FUNCTION========================================//
        //=========================================================================================//
        string name = "";
        int age;
        string gender = "";
        int timerChoose;
        bool Back = false;
        bool GerdQNav = false;
        int GerdQPage = 0;
        

        //------------------------------------------//
        //-----------GERD Q RADIO BUTTON------------//
        int Q1 = -1;
        int Q2 = -1;
        int Q3 = -1;
        int Q4 = -1;
        int Q5 = -1;
        int Q6 = -1;
        //-----------GERD Q RADIO BUTTON------------//
        //------------------------------------------//
        //------------------------------------------//
        //-----------LIFESTYLE RADIO BUTTON------------//
        int Ql1 = -1;
        int Ql2 = -1;
        int Ql3 = -1;
        int Ql4 = -1;
        //-----------LIFESTYLE RADIO BUTTON------------//
        //------------------------------------------//
        public Form1()
        {
            InitializeComponent();
            signUpPnl_gender_cbBox.SelectedIndex = 0;
            signUpPnl_name_Txt.Focus();
            this.Width = 650;
            this.Height = 430;
            GerdQ4to6ConfigLocation();
            GerdQresultConfigLocation();
            lifeStyleConfigLocation();
            //Form2 form2 = new Form2(name, age, gender, GerdQresult, lifestyleResult);
            //form2.Show();
        }
        //===========================================//
        //===========DRAG AND DROP FORM==============//
        bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private void statusPnl_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }
        private void statusPnl_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(diff));
            }
        }
        private void statusPnl_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        //===========DRAG AND DROP FORM===============//
        //============================================//
        void closeApp()
        {
            this.Close();
        }
        void minimizeApp()
        {
            this.WindowState = FormWindowState.Minimized;
        }
        void signUpPress()
        {
            timerChoose = 0;
            Back = false;
            if (signUpPnl_name_Txt.Text == "" || signUpPnl_age_Txt.Text == "")
            {
                MessageBox.Show("Terdapat kotak yang belum diisi", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            } else if (Int32.Parse(signUpPnl_age_Txt.Text) > 100)
            {
                MessageBox.Show("Usia yang anda masukan salah", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            } else
            {
                name = signUpPnl_name_Txt.Text;
                age = Int32.Parse(signUpPnl_age_Txt.Text);
                gender = signUpPnl_gender_cbBox.Text;
            }
            timer1.Start();
        }
        void GerdQ4to6ConfigLocation()
        {
            GerdQPnl_Q4Pnl.Left = 600;
            GerdQPnl_Q4Pnl.Top = 68;
            GerdQPnl_Q5Pnl.Left = 600;
            GerdQPnl_Q5Pnl.Top = 143;
            GerdQPnl_Q6Pnl.Left = 600;
            GerdQPnl_Q6Pnl.Top = 230;
        }//Gerdq question 4 to 6 config location
        void GerdQresultConfigLocation()
        {
            GerdQResultPnl.Left = 655;
            GerdQResultPnl.Top = 90;
        }
        void lifeStyleConfigLocation()
        {
            lifeStylePnl.Left = 655;
            lifeStylePnl.Top = 54;
        }

        //=========================================================================================//
        //=========================================FUNCTION========================================//
        //=========================================================================================//


        //-------------------------STATUS BAR CONTROL-------------------------//
        //--------------------------------------------------------------------//
        private void statusBarPnl_CloseBtn_Click(object sender, EventArgs e)
        {
            closeApp();
        } //Close Button
        private void statusBarPnl_MinBtn_Click(object sender, EventArgs e)
        {
            minimizeApp();
        } //Minimize Button
        //-------------------------STATUS BAR CONTROL-------------------------//
        //--------------------------------------------------------------------//

        //--------------------------------------------------------------------//
        //----------------------------SIGNUP PANEL----------------------------//
        private void signUpPnl_name_Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        } 
        private void signUpPnl_name_Txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                signUpPnl_age_Txt.Focus();
        }
        private void signUpPnl_age_Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void signUpPnl_age_Txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                signUpPnl_gender_cbBox.Focus();
        }
        private void signUpPnl_gender_cbBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                signUpPnl_signUp_Btn.Focus();
        }
        private void signUpPnl_signUp_Btn_Click(object sender, EventArgs e)
        {
            signUpPress();
        }
        void signUpMove()
        {
            if (signUpPnl.Left > -500)
            {
                signUpPnl.Left -= 10;
                timer1.Interval = 1;
            }
            else
            {
                timerChoose = 1;
                Back = false;
            }
        } //timer1
        void signUpBack()
        {
            if (signUpPnl.Left < 154)
            {
                signUpPnl.Left += 10;
                timer1.Interval = 1;
            }
            else
            {
                timer1.Stop();
            }
        } //timer1
        void GerdQMove()
        {
            if (GerdQPnl.Left >= 35)
            {
                GerdQPnl.Left -= 5;
                timer1.Interval = 1;
            }
        } //timer1
        void GerdQBack()
        {
            if (GerdQPnl.Left <= 655)
            {
                GerdQPnl.Left += 5;
                timer1.Interval = 1;
            }
            else
            {
                timerChoose = 0;
                Back = true;
            }
        } //timer1
        
        void GerdQResultMoveTolifeStyle()
        {
            if (lifeStylePnl.Left >= 35)
            {
                lifeStylePnl.Left -= 5;
            }
            else
            {
                timer1.Stop();
                GerdQPnl_PageTimer.Stop();
            }
            if (GerdQResultPnl.Left > -500)
            {
                GerdQResultPnl.Left -= 10;
            } 
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(timerChoose==0 && Back == false)
            {
                signUpMove();
            } else if(timerChoose == 1 && Back == false)
            {
                GerdQMove();
            }

            if(timerChoose==0 && Back == true)
            {
                signUpBack();
            } else if(timerChoose==1 && Back == true)
            {
                GerdQBack();
            }
            if(timerChoose == 3)
            {
                GerdQResultMoveTolifeStyle();
            }
            
        }
        //----------------------------SIGNUP PANEL----------------------------//
        //--------------------------------------------------------------------//

        //--------------------------------------------------------------------//
        //----------------------------GERDQ PANEL-----------------------------//
        int cond;
        int GerdQresult;
        //=====================================================================//
        //=========================FUNGSI YANG DIATUR OLEH TOMBOL PADA GERDQPANEL=======================//
        int GerdQNextPage()
        {
            /*
             Fungsi ini hanya berlaku untuk halaman pertama yang terdiri dari pertanyaan 1-3. GerdQNextPage merupakan penentu dari bool GerdQNav yang terdapat
            di button GerdQPnl_Next_btn.
            Pada fungsi ini, saat terdapat satu pertanyaan yang tidak diisi, maka fungsi ini akan mengembalikan nilai 0, dan apabila sudah terisi semua,
            maka akan mengaktifkan beberapa fungsi seperti yang sudah dijellaskan pada baris kode dibawah ini, salah satunya adalah GerdQPage
            yang diisi dengan nilai 0. GerdQPage digunakan untuk mengatur halaman pertanyaan, jika pertanyaan 1-3 sudah terjawab.
            Selain itu GerdQPnl pagetimer juga akan aktif yang dimana pengaturan GerdQPage akan terpanggil disana.
             */
            if (Q1 == -1 || Q2 == -1 || Q2 == -1)
            {
                MessageBox.Show("Terdapat kuisioner yang belum terisi, silahkan periksa kembali", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }
            else
            {
                GerdQPnl_Next_btn.Text = "Finish";
                GerdQPnl_Prev_btn.Text = "Kembali";
                GerdQPage = 0;
                GerdQPnl_PageTimer.Start();
                GerdQPnl_Page1_LED.FillColor = Color.Gray;
                GerdQPnl_Page2_LED.FillColor = Color.GreenYellow;
            }
            return 1;
        } //TOMBOL LANJUT
        void GerdQPrevBackPage()
        {
            /*
             Merupakan tombol kembali
             */
            if (GerdQPnl_Prev_btn.Text == "Menu Awal" && GerdQNav == false)
            {
                Back = true;
                timerChoose = 1;
                timer1.Start();
            }
            if (GerdQPnl_Prev_btn.Text == "Kembali" && GerdQNav == true)
            {
                //Q1-3 Kembali, Prev button = Menu Awal, nex button = Lanjut, GerdQNav = false;
                GerdQPnl_Next_btn.Text = "Lanjut";
                GerdQPnl_Prev_btn.Text = "Menu Awal";
                GerdQNav = false;
                GerdQPage = 1;
                GerdQPnl_PageTimer.Start();
                GerdQPnl_Page1_LED.FillColor = Color.GreenYellow;
                GerdQPnl_Page2_LED.FillColor = Color.Gray;
            }
        } //TOMBOL KEMBALI
        int GerdQFinishPage()
        {
            if (Q4 == -1 || Q5 == -1 || Q6 == -1)
            {
                MessageBox.Show("Terdapat kuisioner yang belum terisi, silahkan periksa kembali", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }
            else
            {
                DialogResult hasil = MessageBox.Show("Apakah anda yakin dengan jawaban anda ?", "Konfirmasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (hasil == DialogResult.OK)
                {
                    GerdQresult = Q1 + Q2 + Q3 + Q4 + Q5 + Q6;
                }
                else if (hasil == DialogResult.Cancel)
                {
                    return 0;
                }
                MessageBox.Show("Anda telah menyelesaikan kuisioner GERD Q", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 2;
            }

        } //TOMBOL FINISH
        //=====================================================================//
        //=========================FUNGSI YANG DIATUR OLEH TOMBOL PADA GERDQPANEL=======================//

        private void GerdQPnl_Prev_btn_Click(object sender, EventArgs e)
        {
            GerdQPrevBackPage();
        }
        private void GerdQPnl_Next_btn_Click(object sender, EventArgs e)
        {
            /*
             Kondisi default GerdQNav adalah false. Panel pertanyaan gerdq untuk yang pertama adalah pertanyaan 1-3. GerdQNav digunakan untuk 
            mengaktifkan kondisi dari next button, apakah button lanjut ke halaman 2 yaitu pertanyaan 4-6, atau lanjut ke panel gerdqfinishpage.
            Pada saat kondisi gerdqnav false, fungsi GerdQNextPage() akan dipanggil jika tombol ditekan dan akan mengembalikan nilai return 0 atau 1.
            Jika cond menghasilkan 0, maka GerdQNav akan tetap false yang berarti terdapat pertanyaan yang belum diisi dari nomer 1 - 3. Jika cond
            menghasilkan nilai 1, maka GerdQNav akan bernilai true. 
             */
            if(GerdQNav==false)
            {
                //Q1-3 Go, Q4-6 Come Next button = Finish, Prev button = Kembali, GerdQNav = true;
                cond = GerdQNextPage();
            } else if (GerdQNav==true)
            {
                cond = GerdQFinishPage();
            } 

            if(cond==1)
            {
                GerdQNav = !GerdQNav;
                cond = 0;
            } else if(cond==2)
            {
                GerdQPage = 3;
            }
        }

        //=================================================================//
        //===================FUNGSI YANG DIATUR OLEH GerdQPnl_PageTime==================//
        //Menuju ke halaman 2
        void GerdQ1Left()
        {
            if (GerdQPnl_Q1Pnl.Left > -600)
            {
                GerdQPnl_Q1Pnl.Left -= 5;
                GerdQPnl_Q2Pnl.Left -= 5;
                GerdQPnl_Q3Pnl.Left -= 5;
                if (GerdQPnl_Q1Pnl.Left < 0)
                {
                    GerdQ2Come();
                }
                GerdQPnl_PageTimer.Interval = 1;
            }
        }//gerdqtimer //QUIESTION 1 OUT
        void GerdQ2Come()
        {
            //Page 2 in
            if (GerdQPnl_Q4Pnl.Left > 15)
            {
                GerdQPnl_Q4Pnl.Left -= 5;
                GerdQPnl_Q5Pnl.Left -= 5;
                GerdQPnl_Q6Pnl.Left -= 5;
            }
        }//gerdqtimer //QUESTION 4 IN
        //===================FUNGSI YANG SALING BERKAITAN==================//
        //=================================================================//

        //=================================================================//
        //===================FUNGSI YANG DIATUR OLEH GerdQPnl_PageTime==================//
        //Kembali ke halaman 1
        void GerdQ1Come()
        {
            if (GerdQPnl_Q1Pnl.Left < 15)
            {
                GerdQPnl_Q1Pnl.Left += 5;
                GerdQPnl_Q2Pnl.Left += 5;
                GerdQPnl_Q3Pnl.Left += 5;
                if (GerdQPnl_Q1Pnl.Left > -599)
                {
                    GerdQ2Left();
                }
                GerdQPnl_PageTimer.Interval = 1;
            }
        }//gerdqtimer //QUESTION 1 IN 
        void GerdQ2Left()
        {
            //Page 1 in, page 2 out
            if (GerdQPnl_Q4Pnl.Left < 600)
            {
                GerdQPnl_Q4Pnl.Left += 5;
                GerdQPnl_Q5Pnl.Left += 5;
                GerdQPnl_Q6Pnl.Left += 5;
            }
        }//gerdqtimer //QUESTION 4 OUT
        //===================FUNGSI YANG SALING BERKAITAN==================//
        //=================================================================//

        //=================================================================//
        //===================FUNGSI YANG DIATUR OLEH GerdQPnl_PageTime==================//
        //Tombol Finish ditekan dan GerdQPnl out dan GerdQresultPnl in
        //Fungsi ini dipanggil di GerdQPnl_PageTimer
        void GerdQPnlleft()
        {
            if (GerdQPnl.Left > -600)
            {
                GerdQPnl.Left -= 5;
            }
            if (GerdQPnl.Left < 0)
            {
                GerdQresultIn();
            }
            GerdQPnl_PageTimer.Interval = 1;
        }
        void GerdQresultIn()
        {
            if (GerdQResultPnl.Left >= 185)
            {
                GerdQResultPnl.Left -= 5;
            }
        }
        //===================FUNGSI YANG SALING BERKAITAN==================//
        //=================================================================//

        private void GerdQPnl_PageTimer_Tick(object sender, EventArgs e)
        {
            /*
             GerdQPage berfungsi untuk menentukan halaman yang terdiri dari pertanyaan.
             */
            if(GerdQPage == 0)
            {
                GerdQ1Left();
            } else if(GerdQPage == 1)
            {
                GerdQ1Come();
            } else if(GerdQPage == 3) //diatur di pada tombol GerdQPnl_Next_btn
            {
                GerdQPnlleft();
            }
            else
            {
                GerdQPnl_PageTimer.Stop();
            }
            GerdQPnl_PageTimer.Interval = 1;
        }
        private void GerdQPnl_Q1Pnl_Ans0_CheckedChanged(object sender, EventArgs e)
        {
            Q1 = 0;
        }
        private void GerdQPnl_Q1Pnl_Ans1_CheckedChanged(object sender, EventArgs e)
        {
            Q1 = 1;
        }
        private void GerdQPnl_Q1Pnl_Ans2_CheckedChanged(object sender, EventArgs e)
        {
            Q1 = 2;
        }
        private void GerdQPnl_Q1Pnl_Ans3_CheckedChanged(object sender, EventArgs e)
        {
            Q1 = 3;
        }
        private void GerdQPnl_Q2Pnl_Ans0_CheckedChanged(object sender, EventArgs e)
        {
            Q2 = 0;
        }
        private void GerdQPnl_Q2Pnl_Ans1_CheckedChanged(object sender, EventArgs e)
        {
            Q2 = 1;
        }
        private void GerdQPnl_Q2Pnl_Ans2_CheckedChanged(object sender, EventArgs e)
        {
            Q2 = 2;
        }
        private void GerdQPnl_Q2Pnl_Ans3_CheckedChanged(object sender, EventArgs e)
        {
            Q2 = 3;
        }
        private void GerdQPnl_Q3Pnl_Ans0_CheckedChanged(object sender, EventArgs e)
        {
            Q3 = 0;
        }
        private void GerdQPnl_Q3Pnl_Ans1_CheckedChanged(object sender, EventArgs e)
        {
            Q3 = 1;
        }
        private void GerdQPnl_Q3Pnl_Ans2_CheckedChanged(object sender, EventArgs e)
        {
            Q3 = 2;
        }
        private void GerdQPnl_Q3Pnl_Ans3_CheckedChanged(object sender, EventArgs e)
        {
            Q3 = 3;
        }
        private void GerdQPnl_Q4Pnl_Ans0_CheckedChanged(object sender, EventArgs e)
        {
            Q4 = 0;
        }
        private void GerdQPnl_Q4Pnl_Ans1_CheckedChanged(object sender, EventArgs e)
        {
            Q4 = 1;
        }
        private void GerdQPnl_Q4Pnl_Ans2_CheckedChanged(object sender, EventArgs e)
        {
            Q4 = 2;
        }
        private void GerdQPnl_Q4Pnl_Ans3_CheckedChanged(object sender, EventArgs e)
        {
            Q4 = 3;
        }
        private void GerdQPnl_Q5Pnl_Ans0_CheckedChanged(object sender, EventArgs e)
        {
            Q5 = 0;
        }
        private void GerdQPnl_Q5Pnl_Ans1_CheckedChanged(object sender, EventArgs e)
        {
            Q5 = 1;
        }
        private void GerdQPnl_Q5Pnl_Ans2_CheckedChanged(object sender, EventArgs e)
        {
            Q5 = 2;
        }
        private void GerdQPnl_Q5Pnl_Ans3_CheckedChanged(object sender, EventArgs e)
        {
            Q5 = 3;
        }
        private void GerdQPnl_Q6Pnl_Ans0_CheckedChanged(object sender, EventArgs e)
        {
            Q6 = 0;
        }
        private void GerdQPnl_Q6Pnl_Ans1_CheckedChanged(object sender, EventArgs e)
        {
            Q6 = 1;
        }
        private void GerdQPnl_Q6Pnl_Ans2_CheckedChanged(object sender, EventArgs e)
        {
            Q6 = 2;
        }
        private void GerdQPnl_Q6Pnl_Ans3_CheckedChanged(object sender, EventArgs e)
        {
            Q6 = 3;
        }
        private void lifeStylePnl_Q1Pnl_Ans0_CheckedChanged(object sender, EventArgs e)
        {
            Ql1 = 0;
        }
        private void lifeStylePnl_Q1Pnl_Ans1_CheckedChanged(object sender, EventArgs e)
        {
            Ql1 = 1;
        }
        private void lifeStylePnl_Q2Pnl_Ans0_CheckedChanged(object sender, EventArgs e)
        {
            Ql2 = 0;
        }
        private void lifeStylePnl_Q2Pnl_Ans1_CheckedChanged(object sender, EventArgs e)
        {
            Ql2 = 1;
        }
        private void lifeStylePnl_Q3Pnl_Ans0_CheckedChanged(object sender, EventArgs e)
        {
            Ql3 = 0;
        }
        private void lifeStylePnl_Q3Pnl_Ans1_CheckedChanged(object sender, EventArgs e)
        {
            Ql3 = 1;
        }
        private void lifeStylePnl_Q4Pnl_Ans0_CheckedChanged(object sender, EventArgs e)
        {
            Ql4 = 0;
        }
        private void lifeStylePnl_Q4Pnl_Ans1_CheckedChanged(object sender, EventArgs e)
        {
            Ql4 = 1;
        }

        private void GerdQResultPnl_Next_Btn_Click(object sender, EventArgs e)
        {
            //timerChoose = 3;
            lifeStylefinish();
        }

        int lifestyleResult;
        void lifeStylefinish()
        {
            DialogResult result = MessageBox.Show("Silahkan tekan OK jika ingin lanjut.", "Konfirmasi", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                //MessageBox.Show("Anda telah menjawab Kuesioner Gerd Q dan Life Style");
                lifestyleResult = Ql1 + Ql2 + Ql3 + Ql4;
                Form2 form2 = new Form2(name, age, gender, GerdQresult, lifestyleResult);
                form2.Show();
                this.Hide();
            }
        }
        private void lifeStylePnl_Finish_btn_Click(object sender, EventArgs e)
        {
            if(Ql1==-1 || Ql2==-1 || Ql3==-1 || Ql4==-1)
            {
                MessageBox.Show("Terdapat jawaban yang belum diisi. Silahkan periksa kembali jawaban anda.");
            } else
            {
                lifeStylefinish();
            }
        }
        //----------------------------GERDQ PANEL-----------------------------//
        //--------------------------------------------------------------------//
    }
}
