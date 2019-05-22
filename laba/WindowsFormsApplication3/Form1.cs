using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        double a, b, c, d, PM, TM, size;

        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            sizetext.Text = "1";
            textBox1.Text = "1";
            comboBox2.SelectedIndex = 2; 
            comboBox3.SelectedIndex = 1;
            comboBox4.SelectedIndex = 2;
            comboBox5.SelectedIndex = 0; 
            comboBox6.SelectedIndex = 0; 
            comboBox7.SelectedIndex = 1;
            comboBox8.SelectedIndex = 1; 
            comboBox9.SelectedIndex = 2; 
            comboBox10.SelectedIndex = 2;
            comboBox11.SelectedIndex = 2; 
            comboBox12.SelectedIndex = 2; 
            comboBox13.SelectedIndex = 2; 
            comboBox14.SelectedIndex = 2; 
            comboBox15.SelectedIndex = 2; 
            comboBox15.SelectedIndex = 2;
            comboBox16.SelectedIndex = 2;
            comboBox17.SelectedIndex = 0;
            sced_box.SelectedIndex = 2;
            pmat_pox.SelectedIndex = 2;
            prec_box.SelectedIndex = 2;
            resl_box.SelectedIndex = 2;
            flex_box.SelectedIndex = 2;
            team_box.SelectedIndex = 2;
            prex_box.SelectedIndex = 3;
            pers_box.SelectedIndex = 3;
            ruse_box.SelectedIndex = 1;
            fcil_box.SelectedIndex = 3;
            pdif_box.SelectedIndex = 1;
            rcpx_box.SelectedIndex = 3;
            prec2_box.SelectedIndex = 2;
            flex2_box.SelectedIndex = 2;
            resl2_box.SelectedIndex = 2;
            team2_box.SelectedIndex = 2;
            pmat2_box.SelectedIndex = 2;
            rely2_box.SelectedIndex = 2;
            aexp2_box.SelectedIndex = 2;
            pcap2_box.SelectedIndex = 2;
            pexp2_box.SelectedIndex = 2;
            acap2_box.SelectedIndex = 2;
            pcon2_box.SelectedIndex = 2;
            ltex2_box.SelectedIndex = 2;
            data2_box.SelectedIndex = 1;
            ruse2_box.SelectedIndex = 1;
            sced2_box.SelectedIndex = 2;
            cplx2_box.SelectedIndex = 2;
            docu2_box.SelectedIndex = 2;
            site2_box.SelectedIndex = 2;
            tool2_box.SelectedIndex = 2;
            pvol2_box.SelectedIndex = 1;
            stor2_box.SelectedIndex = 0;
            time2_box.SelectedIndex = 0;
            textBox2.Text = "1";
            textBox3.Text = "1";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (sizetext.Text == "")
                {
                    string message = "Вы заполнили не все поля!";
                    DialogResult result;
                    string caption = "Ошибка ввода";
                    result = MessageBox.Show(message, caption);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        this.Close();
                    }
                }
                size = Convert.ToDouble(sizetext.Text);
            }
            catch
            { }
            
            int typeProject = comboBox1.SelectedIndex;
            switch (typeProject)
                {
                    case 0:
                        a = 2.4; b = 1.05; c = 2.5; d = 0.38;
                        PM = Math.Round((a * Math.Pow(size, b)), 3);
                        TM = Math.Round((c * Math.Pow(PM, d)), 3);
                        break;
                    case 1:
                        a = 3; b = 1.12; c = 2.5; d = 0.35;
                        PM = Math.Round((a * Math.Pow(size, b)), 3);
                        TM = Math.Round((c * Math.Pow(PM, d)), 3);
                        break;
                    case 2:
                        a = 3.6; b = 1.2; c = 2.5; d = 0.32;
                        PM = Math.Round((a * Math.Pow(size, b)), 3);
                        TM = Math.Round((c * Math.Pow(PM, d)), 3);
                        break;
                }

                resultPM.Text = PM.ToString();
                resultTM.Text = TM.ToString();
            
        }

        private void sizetext_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                if (e.KeyChar != ',' || sizetext.Text.IndexOf(",") != -1)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                if (e.KeyChar != ',' || textBox1.Text.IndexOf(",") != -1)
                {
                    e.Handled = true;
                }
            }
        }

        private void textbox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                if (e.KeyChar != ',' || textBox3.Text.IndexOf(",") != -1)
                {
                    e.Handled = true;
                }
            }
        }

        //inter 
        double[,] CD = {
                        {0.75,  0.88,   1,  1.15,   1.4,    0},
                        {0.94,  1,  1.08,   1.16,   0,  0},
                        {0.7, 0.85, 1, 1.15, 1.3, 1.65},
                        {1,1.06,1.21,1.56,0,0},
                        {1,1.06,1.21,1.56,0,0},
                        {0.87,1,1.15,1.3,0,0},
                        {0.87,1,1.07,1.15,0,0},
                        {1.46,1.19,1,0.86,0.71,0},
                        {1.29,1.13,1,0.91,0.82,0},
                        {1.42,1.17,1,0.86,0.7,0},
                        {1.21,1.1,1,0.9,0,0},
                        {1.14,1.07,1,0.95,0,0},
                        {1.21,1.1,1,0.91,0.82,0},
                        {1.24,1.1,1,0.91,0.83,0},
                        {1.23,1.08,1,1.04,1.1,0}
                        };

       

        double[] ai = new double[] { 3.2, 3.0, 2.8 };
        double[] bi = new double[] { 1.05, 1.12, 1.2 };

        double ctime = 2.5;
        double[] dtime = new double[] {0.38, 0.35, 0.32};

        

        private void button2_Click(object sender, EventArgs e)
        {
            double EAF = CD[0, comboBox2.SelectedIndex] * CD[1, comboBox3.SelectedIndex] * CD[2, comboBox4.SelectedIndex] *
                CD[3, comboBox5.SelectedIndex] * CD[4, comboBox6.SelectedIndex] * CD[5, comboBox7.SelectedIndex]
                * CD[6, comboBox8.SelectedIndex] * CD[7, comboBox9.SelectedIndex] * CD[8, comboBox10.SelectedIndex] * CD[9, comboBox11.SelectedIndex] * CD[10, comboBox12.SelectedIndex]
                * CD[11, comboBox13.SelectedIndex] * CD[12, comboBox14.SelectedIndex] * CD[13, comboBox15.SelectedIndex] * CD[14, comboBox16.SelectedIndex];

            int typeproject2 = comboBox17.SelectedIndex;

            try
            {
                switch (typeproject2)
                {
                    case 0:
                        PM = EAF * ai[0] * (Math.Pow(Convert.ToDouble(textBox1.Text), bi[0])); //кол во строк на коэф b
                        break;
                    case 1:
                        PM = EAF * ai[1] * (Math.Pow(Convert.ToDouble(textBox1.Text), bi[1])); //кол во строк на коэф b
                        break;
                    case 2:
                        PM = EAF * ai[2] * (Math.Pow(Convert.ToDouble(textBox1.Text), bi[2])); //кол во строк на коэф b
                        break;
                }
                label26.Text = Convert.ToString(Math.Round(PM, 3));

                double TM = new double(); //добавить время
                switch (typeproject2)
                {
                    case 0:
                        TM = ctime * (Math.Pow(PM, dtime[0]));
                        break;
                    case 1:
                        TM = ctime * (Math.Pow(PM, dtime[1]));
                        break;
                    case 2:
                        TM = ctime * (Math.Pow(PM, dtime[2]));
                        break;
                }

                label27.Text = Convert.ToString(Math.Round(TM, 3));

            }
            catch
            {
                    if (textBox1.Text == "")
                    {
                        string message = "Вы заполнили не все поля!";
                        DialogResult result;
                        string caption = "Ошибка ввода";
                        result = MessageBox.Show(message, caption);
                        if (result == System.Windows.Forms.DialogResult.Yes)
                        {
                            this.Close();
                        }
                    }   
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 0)
            {
                if (e.KeyChar != ',' || textBox2.Text.IndexOf(",") != -1)
                {
                    e.Handled = true;
                }
            }
        }

        //COCOMO II ED

        double[,] SF =
        {
            {6.2, 4.96, 3.72, 2.48, 1.24},
            {5.07, 4.05, 3.04, 2.03, 1.01},
            {7.07, 5.65, 4.24, 2.83, 1.41},
            {5.48, 4.38, 3.29,2.19,1.1 },
            {7.8,6.24,4.68,3.12,1.56 }
        };

       

        double[,] EM =
        {
            {2.12,1.62,1.26,1,0.83,0.63,0.5},
            {1.59,1.33,1.22,1,0.87,0.74,0.62 },
            {0.49,0.6,0.83,1,1.33,1.91,2.72 },
            {0.95,1,1.07,1.15,1.24,0,0 },
            {0.87,1,1.29,1.81,2.61,0,0 },
            {1.43,1.3,1.1,1,0.87,0.73,0.62 },
            {1.43,1.14,1,1,0,0,0 }
        };

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start("Cocomo.pdf");   
        }

        private void comboBox18_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        

        double B2 = 0.91;
        double Aed = 2.94;
        double Apd = 2.45;

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                ///ПРОВЕРИТЬ ИНДЕКСЫ С ТАБЛИЦЕЙ!!!!
                //расчет трудоемкости
                double PMED;
                
                double EAF = EM[0, pers_box.SelectedIndex] * EM[1, prex_box.SelectedIndex] * EM[2, rcpx_box.SelectedIndex] * EM[3, ruse_box.SelectedIndex] * EM[4, pdif_box.SelectedIndex] * EM[5, fcil_box.SelectedIndex] * EM[6, sced_box.SelectedIndex];

                //фактор масштаба
                double SFi = SF[0, prec_box.SelectedIndex] + SF[1, flex_box.SelectedIndex] + SF[2, resl_box.SelectedIndex] + SF[3, team_box.SelectedIndex] + SF[4, pmat_pox.SelectedIndex];


                double SFy = SF[0, prec_box.SelectedIndex] * SF[1, flex_box.SelectedIndex] * SF[2, resl_box.SelectedIndex] * SF[3, team_box.SelectedIndex] * SF[4, pmat_pox.SelectedIndex];

                double E = B2 + 0.01 * SFi;
                double D2 = 0.28;
                PMED = EAF * Aed * Math.Pow(Convert.ToDouble(textBox2.Text), E);

                //время разработки
                double SCED = EM[6, sced_box.SelectedIndex];
                double PMns = EM[0, pers_box.SelectedIndex] * EM[1, prex_box.SelectedIndex] * EM[2, rcpx_box.SelectedIndex] * EM[3, ruse_box.SelectedIndex] * EM[4, pdif_box.SelectedIndex] * EM[5, fcil_box.SelectedIndex];
                double TMed;
                double stepen = D2 + 0.2 * (E - B2);
                TMed = SCED * 3.67 * Math.Pow(PMns, stepen);

                if (textBox2.Text == "" || textBox2.Text == "0")
                {
                    label64.Text = "";
                    label66.Text = "";
                    label68.Text = "";
                    label62.Text = "Строк кода должно быть больше";

                }
                else
                {
                    label64.Text = Convert.ToString(Math.Round(TMed, 3));
                    label66.Text = Convert.ToString(Math.Round(EAF, 3));
                    label68.Text = Convert.ToString(Math.Round(SFi, 3));
                    label62.Text = Convert.ToString(Math.Round(PMED, 3));
                }
            }
            catch
            {
                if (textBox2.Text == "")
                {
                    string message = "Вы заполнили не все поля!";
                    DialogResult result;
                    string caption = "Ошибка ввода";
                    result = MessageBox.Show(message, caption);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        this.Close();
                    }
                }


            }
        }
           
        
       
        //PA
        
        double[,] EMpa =
        {
            {1.42,1.29,1,0.85,0.71,0 },
            {1.22,1.1,1,0.88,0.81,0 },
            {1.34,1.15,1,0.88,0.76,0 },
            {1.29,1.12,1,0.9,0.81,0 },
            {1.19,1.09,1,0.91,0.85,0 },
            {1.2,1.09,1,0.91,0.84,0 },
            {0.84,0.92,1,1.1,1.26,0 },
            {0.23,1,1.14,1.28,0,0 },
            {0.73,0.87,1,1.17,1.34,1.74 },
            {0.95,1,1.07,1.15,1.24,0 },
            {0.81,0.91,1,1.11,1.23,0 },
            {1,1.11,1.29,1.63,0,0 },
            {1,1.05,1.17,1.46,0,0 },
            {0.87,1,1.15,1.3,0,0 },
            {1.17,1.09,1,0.9,0.78,0 },
            {1.22,1.09,1,0.93,0.86,0.8 },
            {1.43,1.14,1,1,1,0 }
        };

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                //Расчет трудоемкости
                double PMpa;
                double EAF = EMpa[0, acap2_box.SelectedIndex] * EMpa[1, aexp2_box.SelectedIndex] * EMpa[2, pcap2_box.SelectedIndex] * EMpa[3, pcon2_box.SelectedIndex] * EMpa[4, pexp2_box.SelectedIndex] *
                    EMpa[5, ltex2_box.SelectedIndex] * EMpa[6, rely2_box.SelectedIndex] * EMpa[7, data2_box.SelectedIndex] * EMpa[8, cplx2_box.SelectedIndex] * EMpa[9, ruse2_box.SelectedIndex] * EMpa[10, docu2_box.SelectedIndex]
                    * EMpa[11, time2_box.SelectedIndex] * EMpa[12, stor2_box.SelectedIndex] * EMpa[13, pvol2_box.SelectedIndex] * EMpa[14, tool2_box.SelectedIndex] * EMpa[15, site2_box.SelectedIndex] * EMpa[16, sced2_box.SelectedIndex];
                double SFi = SF[0, prec_box.SelectedIndex] + SF[1, flex_box.SelectedIndex] + SF[2, resl_box.SelectedIndex] + SF[3, team_box.SelectedIndex] + SF[4, pmat_pox.SelectedIndex];

                double E = B2 + 0.01 * SFi;
                double SIZE = Convert.ToDouble(textBox3.Text);
                double PMns = EMpa[0, acap2_box.SelectedIndex] * EMpa[1, aexp2_box.SelectedIndex] * EMpa[2, pcap2_box.SelectedIndex] * EMpa[3, pcon2_box.SelectedIndex] * EMpa[4, pexp2_box.SelectedIndex] *
                    EMpa[5, ltex2_box.SelectedIndex] * EMpa[6, rely2_box.SelectedIndex] * EMpa[7, data2_box.SelectedIndex] * EMpa[8, cplx2_box.SelectedIndex] * EMpa[9, ruse2_box.SelectedIndex] * EMpa[10, docu2_box.SelectedIndex]
                    * EMpa[11, time2_box.SelectedIndex] * EMpa[12, stor2_box.SelectedIndex] * EMpa[13, pvol2_box.SelectedIndex] * EMpa[14, tool2_box.SelectedIndex] * EMpa[15, site2_box.SelectedIndex];
                PMpa = EAF * Apd * Math.Pow(SIZE, E);
                //Расчет времени
                double TMpa;
                double SCED = EMpa[16, sced2_box.SelectedIndex];
                double stepen = 0.28 + 0.2 * (E - B2);
                TMpa = SCED * 3.67 * Math.Pow(PMns, stepen);
                //
                //Сумма факторов масштаба
                double SFy = SF[0, prec_box.SelectedIndex] + SF[1, flex_box.SelectedIndex] + SF[2, resl_box.SelectedIndex] + SF[3, team_box.SelectedIndex] + SF[4, pmat_pox.SelectedIndex];
                //Выводы
                if (textBox3.Text == "" || textBox3.Text == "0")
                {
                    label72.Text = "";
                    label70.Text = "Строк кода должно быть больше";
                    label74.Text = "";
                    label76.Text = "";

                }
                else
                {
                    label70.Text = Convert.ToString(Math.Round(PMpa, 3));
                    label72.Text = Convert.ToString(Math.Round(TMpa, 3));
                    label74.Text = Convert.ToString(Math.Round(EAF, 3));
                    label76.Text = Convert.ToString(Math.Round(SFy, 3));
                }
            }
            catch
            {
                if (textBox3.Text == "")
                {
                    string message = "Вы заполнили не все поля!";
                    DialogResult result;
                    string caption = "Ошибка ввода";
                    result = MessageBox.Show(message, caption);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        this.Close();
                    }
                }

               
            }

        }



    }
}

       