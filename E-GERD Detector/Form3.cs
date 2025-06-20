using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerdQ
{
    public partial class Form3 : Form
    {
        private String name;
        private int age;
        private String gender;
        private int gerdQ;
        private int lifeStyle;
        private double BMI, pH;
        private double finalResult;
        private String BMI_Type, GERDQ_Type, pH_Type, final_result_type;
        private String[] finalResult_Type = { "Tidak Terindikasi GERD", "Berisiko Tinggi Terkena GERD", "Terindikasi GERD" };
        String[] BMI_Categories = { "Underweight", "Normal", "Overweight", "Obesity", "Obesity 2", "Obesity 3" };
        public Form3(String recname, int recage, String recgender, int recgerdQ, int reclifestyle, double recBMI, double recpH)
        {
            InitializeComponent();
            name        = recname;
            age         = recage;
            gender      = recgender;
            gerdQ       = recgerdQ;
            lifeStyle   = reclifestyle;
            BMI         = recBMI;
            pH          = recpH;

            if (BMI < 18.5)
            {
                BMI_Type= BMI_Categories[0];
            }
            else if (BMI >= 18.5 && BMI <= 24.9)
            {
                BMI_Type = BMI_Categories[1];
            }
            else if (BMI >= 25 && BMI <= 29.9)
            {
                BMI_Type = BMI_Categories[2];
            }
            else
            {
                BMI_Type = BMI_Categories[3];
            }

            if(pH >= 6.1)
            {
                pH_Type = "Normal";
            } else if (pH < 6.1)
            {
                pH_Type = "Asam";
            } else
            {
                pH_Type = "null";
            }

            if (gerdQ >= 8)
            {
                GERDQ_Type = "Berpotensi";
            } else
            {
                GERDQ_Type = "Tidak";
            }

            finalResult = diagnose_Process(GERDQ_Type, BMI_Type, pH_Type);
            if (finalResult == 0)
            {
                finalResultPanel_result_lbl.Text = finalResult_Type[0];
                finalResultPanel_result_lbl.BackColor = Color.Red;
                finalResultPanel_Sign.Image = Properties.Resources.no;
                final_result_type = "Tidak Terdeteksi GERD";
            } else if (finalResult == 0.5)
            {
                finalResultPanel_result_lbl.Text = finalResult_Type[1];
                finalResultPanel_result_lbl.BackColor = Color.Yellow;
                finalResultPanel_Sign.Image = Properties.Resources.attention;
                final_result_type = "Berisiko Tinggi Terkena GERD";
            } else if (finalResult == 1)
            {
                finalResultPanel_result_lbl.Text = finalResult_Type[2];
                finalResultPanel_result_lbl.BackColor = Color.Green;
                finalResultPanel_Sign.Image = Properties.Resources.yes;
                final_result_type = "Terdeteksi Dini GERD";
            } else
            {
                finalResultPanel_result_lbl.Text = "Null";
            }
            profile_data();
        }
        double diagnose_Process(String gerdq, String BMI, String ph)
        {
            //RULE
            //1
            if(BMI == BMI_Categories[0] || (gerdq == "Berpotensi" && ph == "Normal"))
            {
                return 1;
            }
            //2
            else if (BMI == BMI_Categories[0] || (gerdq == "Berpotensi" && ph == "Asam"))
            {
                return 1;
            }
            //3
            else if (BMI == BMI_Categories[0] || (gerdq == "Tidak" && ph == "Normal"))
            {
                return 0;
            }
            //4
            else if (BMI == BMI_Categories[0] || (gerdq == "Tidak" && ph == "Asam"))
            {
                return 0;
            }
            //5
            else if (BMI == BMI_Categories[1] || (gerdq == "Berpotensi" && ph == "Normal"))
            {
                return 1;
            }
            //6
            else if (BMI == BMI_Categories[1] || (gerdq == "Berpotensi" && ph == "Asam"))
            {
                return 1;
            }
            //7
            else if (BMI == BMI_Categories[1] || (gerdq == "Tidak" && ph == "Normal"))
            {
                return 0;
            }
            //8
            else if (BMI == BMI_Categories[1] || (gerdq == "Tidak" && ph == "Asam"))
            {
                return 0;
            }
            //9
            else if (BMI == BMI_Categories[2] || (gerdq == "Berpotensi" && ph == "Normal"))
            {
                return 1;
            }
            //10
            else if (BMI == BMI_Categories[2] || (gerdq == "Berpotensi" && ph == "Asam"))
            {
                return 1;
            }
            //11
            else if (BMI == BMI_Categories[2] || (gerdq == "Tidak" && ph == "Normal"))
            {
                return 0.5;
            }
            //12
            else if (BMI == BMI_Categories[2] || (gerdq == "Tidak" && ph == "Asam"))
            {
                return 0.5;
            }
            //13
            else if (BMI == BMI_Categories[3] || (gerdq == "Berpotensi" && ph == "Normal"))
            {
                return 1;
            }
            //14
            else if (BMI == BMI_Categories[3] || (gerdq == "Berpotensi" && ph == "Asam"))
            {
                return 1;
            }
            //15
            else if (BMI == BMI_Categories[3] || (gerdq == "Tidak" && ph == "Normal"))
            {
                return 0.5;
            }
            //16
            else if (BMI == BMI_Categories[3] || (gerdq == "Tidak" && ph == "Asam"))
            {
                return 0.5;
            } else
            {
                return 2;
            }
        }

        void profile_data()
        {
            String profile = "========================\r\n" +
                             "\t  Profil Pasien    \r\n" +
                             "========================\r\n" +
                             $"Nama\t= {name}\r\n" +
                             $"Umur\t= {age}\r\n" +
                             $"Gender\t= {gender}\r\n" +
                             $"GERDQ\t= {gerdQ}\r\n" +
                             $"BMI\t= {BMI}\r\n" +
                             $"Kategori\t= {BMI_Type}\r\n" +
                             $"pH\t= {pH}\r\n" +
                             $"Hasil\t= {final_result_type}\r\n" +
                             "========================";
            allDataPanel_txtBox.Text = profile;

            String tips_GERD_detected = "Untuk mengatasi gejala dan mencegah kekambuhan," +
                " bisa dilakukan dengan melakukan modifikasi gaya hidup.\r\n\r\n" +
                "1. Menurunkan berat badan bila penderita obesitas atau menjaga berat sesuai" +
                " dengan IMT Normal.\r\n\r\n" +
                "2. Meninggikan kepala ± 15-20cm / menjaga kepala agar tetap elevasi saat " +
                "posisi berbaring.\r\n\r\n" +
                "3. Makan malam paling lambat 2-3 jam sebelum tidur.\r\n\r\n" +
                "4. Menghindari makanan yang dapat merangsang GERD seperti cokelat, minuman" +
                " kafein, alkohol, dan makanan berlemak, asam, dan pedas.\r\n\r\n" +
                "Segera hubungi dokter untuk pemeriksaan dan penanganan lebih lanjut.";

            String tips_Overweight_detected = "IMT dengan kategori berat badan lebih hingga " +
                "obesitas dapat meningkatkan risiko tinggi terkena GERD. Sangat disarankan " +
                "untuk menurunkan berat badan menjadi ideal.";
            String tips_nonDetected = "Untuk mencegah terjadinya GERD bisa dilakukan dengan" +
                " cara berikut\r\n\r\n" +
                "1. Usahakan agar berat badan tetap ideal.\r\n" +
                "2. Hindari makanan berlemak, pedas, dan asam.\r\n" +
                "3. Tidak berbaring setelah makan.\r\n" +
                "4. Hidari rokok dan alkohol.\r\n" +
                "5. Batasi konsumsi kafein.\r\n" +
                "6. Kelola stres dengan baik.";

            if(finalResult==0.5)
            {
                tipsPanel_txtBox.Text = tips_Overweight_detected;
            } else if (finalResult == 1)
            {
                tipsPanel_txtBox.Text = tips_GERD_detected;
            } else
            {
                tipsPanel_txtBox.Text = tips_nonDetected;
            }

        }

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
            if(dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(diff));
            }
        }

        private void statusPnl_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void finalResultPanel_saveData_btn_Click(object sender, EventArgs e)
        {
            String fileToSave = allDataPanel_txtBox.Text + "\r\n\r\n" + tipsPanel_txtBox.Text;

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Title = "Simpan Data Pasien",
                Filter = "Text Files (*.txt)|*.txt",
                FileName = "Pasien - " + name
            };

            if(saveFileDialog.ShowDialog()==DialogResult.OK)
            {
                try
                {
                    File.WriteAllText(saveFileDialog.FileName, fileToSave);
                    MessageBox.Show("File telah tersimpan !", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menyimpan pesan : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void finalResultPanel_Home_btn_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void statusBarPnl_MinBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void statusBarPnl_CloseBtn_Click(object sender, EventArgs e)
        {
            this.FormClosed += Form3_FormClosed;
            this.Close();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
