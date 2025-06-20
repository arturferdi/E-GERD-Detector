using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GerdQ
{
    public partial class Form2 : Form
    {
        private String name;
        private int age;
        private String gender;
        private int gerdQ;
        private int lifeStyle;
        string response = ".";
        bool status = false; //for connected device
        bool Connect = true; //for button
        bool readyToReceive = false; //for get data
        bool expand = false;
        bool showScrt = true;
        double HB = 0;
        double WB = 0;
        double resultBMI;
        double pH;
        int returnConnectButton = 1;
        String[] BMI_Categories = { "Underweight", "Normal", "Overweight", "Obesity 1", "Obesity 2", "Obesity 3"};
        void deviceConnected()
        {
            serialPortPnl_indicator.FillColor = Color.Green;
            serialPortPnl_device.Text = "Online";
            getDatapnl.Enabled = true;
            readyToReceive = true;
        }
        void deviceDisconnected()
        {
            serialPortPnl_indicator.FillColor = Color.Red;
            serialPortPnl_device.Text = "Tidak Ada";
            serialPortPnl_connect_btn.Text = "Connect";
            serialPortPnl_cbbox.Enabled = true;
            getDatapnl.Enabled = false;
            readyToReceive = false;
        }
        void buttonRequestPressed()
        {
            serialPort1.WriteLine("request");
        } //Button request data sensor
        int buttonConnectPressed()
        {
            //serialPort1.PortName = serialPortCbBox.Text;

            if (serialPortPnl_cbbox.Text == "--Pilih port")
            {
                MessageBox.Show("Silahkan pilih port terlebih dahulu !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }

            try
            {
                serialPort1.PortName = serialPortPnl_cbbox.Text;
                serialPort1.BaudRate = 115200;
                serialPort1.Open();
                if (serialPort1.IsOpen)
                {
                    status = true;
                    serialPortPnl_connect_btn.Text = "Close";
                    serialPort1.WriteLine("Hello");
                    serialPortPnl_cbbox.Enabled = false;
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch (TimeoutException)
            {
                MessageBox.Show("Gagal terhubung. Operation Timed out");
                serialPort1.Close();
                status = false;
                Connect = true;
                serialPortPnl_connect_btn.Text = "Connect";
                return 0;
            }
            catch (Exception un)
            {
                MessageBox.Show(un.Message.ToString(), "Port Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Connect = true;
                serialPort1.Close();
                status = false;
                serialPortPnl_connect_btn.Text = "Connect";
                return 0;
            }
        } //Menghubungkan serial port
        int buttonDisconnectPressed()
        {
            deviceDisconnected();
            serialPort1.Close();
            serialPortPnl_connect_btn.Text = "Connect";
            expand = false;
            return 2;
        } //Memutuskan serial port
        void hubungPerangkat()
        {
            try
            {
                response = serialPort1.ReadLine().Trim();
                this.Invoke(new Action(() =>
                {
                    serialPortPnl_debug_txt.Text = response;
                    if (response == "online")
                    {
                        deviceConnected();
                    }
                    if (response != "online" && readyToReceive)
                    {
                        string[] values = response.Split(',');
                        HB = double.Parse(values[0]) / 100;
                        WB = double.Parse(values[1])/100;
                        pH = double.Parse(values[2])/100;
                        resultBMI = BMI(HB, WB);
                        getDatapnl_BMIval_txt.Text = resultBMI.ToString();
                        if(resultBMI<18.5)
                        {
                            getDatapnl_BMIcat_txt.Text = BMI_Categories[0];
                        } else if(resultBMI>=18.5 && resultBMI <= 24.9)
                        {
                            getDatapnl_BMIcat_txt.Text = BMI_Categories[1];
                        } else if(resultBMI>=25 && resultBMI <= 29.9)
                        {
                            getDatapnl_BMIcat_txt.Text = BMI_Categories[2];
                        } else if(resultBMI>=30 && resultBMI<=34.9)
                        {
                            getDatapnl_BMIcat_txt.Text = BMI_Categories[3];
                        } else if(resultBMI>=35 && resultBMI<=39.9)
                        {
                            getDatapnl_BMIcat_txt.Text = BMI_Categories[4];
                        } else
                        {
                            getDatapnl_BMIcat_txt.Text = BMI_Categories[5];
                        }
                        if (values.Length == 3) 
                        {
                            getDatapnl_height_txt.Text = values[0] + " cm";
                            getDatapnl_weight_txt.Text = values[1] + " kg";
                            getDatapnl_ph_txt.Text = values[2];
                            getDatapnl_transfer_btn.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Invalid data received", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        
                    }

                }));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }

        } //Memeriksa status FP Device
        public double BMI(double height, double weight)
        {
            double hg_m = height / 100;
            double bmi = (double)weight / (hg_m * hg_m);
            return Math.Round(bmi, 1);
        }
        void serialPortList()
        {
            String[] portList = System.IO.Ports.SerialPort.GetPortNames();
            var currentPorts = serialPortPnl_cbbox.Items.Cast<string>().ToArray();

            if (!currentPorts.SequenceEqual(portList))
            {
                serialPortPnl_cbbox.Items.Clear();
                serialPortPnl_cbbox.Items.AddRange(portList);
                serialPortPnl_cbbox.SelectedIndex = 0;

                if (status && (serialPort1.IsOpen == false))
                {
                    serialPort1.Close();
                    Connect = false;
                    status = false;
                    deviceDisconnected();
                    MessageBox.Show("Device disconneted", "Warning", MessageBoxButtons.OK);
                    expand = false;
                }
            }
        } //Menampilkan serial port yang tersedia pada saat program dimulai
        void serialPortUpdateList()
        {
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            timer1.Start();
        } //Selalu update serial port yang tersedia
        public Form2(String recName, int recAge, String recGender, int recGerdQ, int recLifeStyle)
        {
            InitializeComponent();
            serialPortUpdateList();
            getDatapnl.Enabled = false;
            getDatapnl_transfer_btn.Enabled = false;
            serialPortPnl_debug_txt.Visible = false;
            serialPort1.ReadTimeout = 1000;
            serialPort1.WriteTimeout = 1000;
            name = recName;
            age = recAge;
            gender = recGender;
            gerdQ = recGerdQ;
            lifeStyle = recLifeStyle;
            allDataPanel_name_lbl.Text = name;
            allDataPanel_gender_txt.Text = gender;
            allDataPanel_age_txt.Text = age.ToString();
            allDataPanel_gerdq_txt.Text = gerdQ.ToString();
            allDataPanel_lifestyle_txt.Text = lifeStyle.ToString();
            if(gender=="Laki-laki")
            {
                allDataPanel_profile.Image = Properties.Resources.user_male;
            } else
            {
                allDataPanel_profile.Image = Properties.Resources.user_female;
            }
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
        private void statusBarPnl_CloseBtn_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            this.FormClosed += Form2_FormClosed;
            this.Close();
        }
        private void statusBarPnl_MinBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void allDataPanel_gerdq_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            serialPortList();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            serialPortList();
        }

        private void serialPortPnl_connect_btn_Click(object sender, EventArgs e)
        {
            if (Connect == true)
            {
                //buttonConnectPressed();
                returnConnectButton = buttonConnectPressed();
            }
            if (Connect == false)
            {
                //buttonDisconnectPressed();
                returnConnectButton = buttonDisconnectPressed();
            }
            if (returnConnectButton == 1)
            {
                Connect = !Connect;
            }
            if (returnConnectButton == 2)
            {
                Connect = !Connect;
            }
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            hubungPerangkat();
        }

        private void getDatapnl_getData_btn_Click(object sender, EventArgs e)
        {
            buttonRequestPressed();
        }

        private void serialPortPnl_connect_btn_MouseDown(object sender, MouseEventArgs e)
        {
            if (showScrt)
            {
                if (e.Button == MouseButtons.Left && Control.ModifierKeys == Keys.Control)
                {
                    serialPortPnl_debug_txt.Visible = true;
                }
            }
            else
            {
                if (e.Button == MouseButtons.Left && Control.ModifierKeys == Keys.Control)
                {
                    serialPortPnl_debug_txt.Visible = false;
                }
            }
            showScrt = !(showScrt);
        }

        private void getDatapnl_transfer_btn_Click(object sender, EventArgs e)
        {
            allDataPanel_bmicat_txt.Text = getDatapnl_BMIcat_txt.Text;
            allDataPanel_bmival_txt.Text = resultBMI.ToString();
            allDataPanel_weight_txt.Text = WB + " Kg";
            allDataPanel_height_txt.Text = HB + " CM";
            allDataPanel_phVal_txt.Text = pH.ToString();
        }

        private void diagnose_btn_Click(object sender, EventArgs e)
        {
            if(allDataPanel_bmicat_txt.Text != getDatapnl_BMIcat_txt.Text || WB == 0)
            {
                MessageBox.Show("Data masih belum di perbarui, silahkan tekan Transfer Data " +
                    "terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                DialogResult result = MessageBox.Show("Apakah anda yakin dengan jawaban anda? Silahkan tekan OK apabila sudah yakin", "Konfirmasi", MessageBoxButtons.OKCancel);
                if(result==DialogResult.OK)
                {
                    Form3 form3 = new Form3(name, age, gender, gerdQ, lifeStyle, resultBMI, pH);
                    form3.Show();
                    this.Hide();
                }
            }

        }

        private void allDataPanel_age_txt_TextChanged(object sender, EventArgs e)
        {

        }
        //===========DRAG AND DROP FORM===============//
        //============================================//

    }
}
