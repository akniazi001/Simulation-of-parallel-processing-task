using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Timers;
using System.Timers;
using System.Windows.Forms;
using System.Threading;
using System.Text;
using System.Data;
using System.Timers;
using System.Net.Mail;
using System.Diagnostics;
using System.Timers;
namespace bonespoint
{
    public partial class Form1 : Form
    {
        private static System.Timers.Timer aTimer;
        public Form1()
        {
            InitializeComponent();
            mask();

        }
        protected void mask()
        {
            txtmask1.Text = "0";
            txtmask2.Text = "0";
            txtmask3.Text = "0";
            txtmask4.Text = "0";

        }
        int[,] A = new int[4, 4];
        int[,] R = new int[4, 4];
        int[,] B = new int[4, 4];
        Int64[,] C = new Int64[4, 4];
        protected void rest()
        {
            lbl_a1.Text = "";
            lbl_a2.Text = "";
            lbl_a3.Text = "";
            lbl_a4.Text = "";

            lbl_b1.Text = "";
            lbl_b2.Text = "";
            lbl_b3.Text = "";
            lbl_b4.Text = "";

        }
        protected void initializeAandB() 
        {
            rest();
            txtmask1.Text = "1";
            txtmask2.Text = "1";
            txtmask3.Text = "1";
            txtmask4.Text = "1";

            var r = new Random();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {

                    A[i, j] = r.Next(1, 9);
                    B[i, j] = r.Next(1, 9);
                    C[i, j] = 0;
                    if (i == 0)
                    {
                        lbl_a1.Text += A[i, j].ToString() + "   ";
                        lbl_b1.Text += B[i, j].ToString() + "   ";
                        txtbxc1.Text = "0";
                        txtbxc2.Text = "0";
                        txtbxc3.Text = "0";
                        txtbxc4.Text = "0";
                        txtbxc5.Text = "0";
                        txtbxc6.Text = "0";
                        txtbxc7.Text = "0";
                        txtbxc8.Text = "0";
                        txtbxc9.Text = "0";
                        txtbxc10.Text = "0";
                        txtbxc11.Text = "0";
                        txtbxc12.Text = "0";
                        txtbxc13.Text = "0";
                        txtbxc14.Text = "0";
                        txtbxc15.Text = "0";
                        txtbxc16.Text = "0";
                    }
                    if (i == 1)
                    {
                        lbl_a2.Text += A[i, j].ToString() + "   ";
                        lbl_b2.Text += B[i, j].ToString() + "   ";
                    }
                    if (i == 2)
                    {
                        lbl_a3.Text += A[i, j].ToString() + "   ";
                        lbl_b3.Text += B[i, j].ToString() + "   ";
                    }
                    if (i == 3)
                    {
                        lbl_a4.Text += A[i, j].ToString() + "   ";
                        lbl_b4.Text += B[i, j].ToString() + "   ";

                    }
                }

                //    load_AtoR(0);///////////////////////first row of A load to R
            }
           
      
        }
      
        protected void load_AtoR(int xi)          /////////////////load  A to R each time with value of X[i]
        {
            lblsp1_4.Text = "";
            lblsp2_4.Text = "";
            lblsp3_4.Text = "";
            lblsp4_4.Text = "";
            lblsp1_3.Text = "";
            lblsp2_3.Text = "";
            lblsp3_3.Text = "";
            lblsp4_3.Text = "";
           
            lbl_loadvalue.Text = "";
            lblloadA.Text = "";
            lblindexI.Text = (xi + 1).ToString();
            for (int j = 0; j < 4; j++)
            {
                R[xi, j] = A[xi, j];
                lblloadA.Text += A[xi, j].ToString() + "          ";
                lbl_loadvalue.Text += A[xi, j].ToString() + "          ";
                lblsp1_4.Text += A[xi, j].ToString();
                lblsp2_4.Text += A[xi, j].ToString();
                lblsp3_4.Text += A[xi, j].ToString();
                lblsp4_4.Text += A[xi, j].ToString();
               ///
                lblsp1_3.Text += A[xi, j].ToString();
                lblsp2_3.Text += A[xi, j].ToString();
                lblsp3_3.Text += A[xi, j].ToString();
                lblsp4_3.Text += A[xi, j].ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void btnload_c_Click(object sender, EventArgs e)
        {

           
        }

        protected void multiple_show(int i,int j)
        {
           // for (int i = 0; i < 4; i++)
            //{
                load_AtoR(i);
             

                for (int k = 0; k < 4; k++)
                {

                    lblsp1_1.Text = R[i, j].ToString();
                    lblsp2_1.Text = R[i, j].ToString();
                    lblsp3_1.Text = R[i, j].ToString();
                    lblsp4_1.Text = R[i, j].ToString();
                    txtp1.Text = R[i, j].ToString();
                    txtp2.Text = R[i, j].ToString();
                    txtp3.Text = R[i, j].ToString();
                    txtp4.Text = R[i, j].ToString();
                    C[i,k] = C[i, k] + R[i, j] * B[j, k];    
                //}
                if (k == 0 && i==0)
                    {
                        lbl_showivalue.Text = (i + 1).ToString();
                        lbl_showjvalue.Text = (k + 1).ToString();
                    
                        txtbs1.Text = B[j, k].ToString();
                        txtbxc1.Text = C[i, k].ToString();
                        lblsp1_2.Text = B[j, k].ToString();
                        lblsp2_2.Text = B[j, k].ToString();
                        lblsp3_2.Text = B[j, k].ToString();
                        lblsp4_2.Text = B[j, k].ToString();
                    }
                    if (k == 1 && i == 0)
                    {
                        lbl_showivalue.Text = (i + 1).ToString();
                        lbl_showjvalue.Text = (k + 1).ToString();
                        txtbs2.Text = B[j, k].ToString();
                        txtbxc2.Text = C[i, k].ToString();
                        lblsp1_2.Text += B[j, k].ToString();
                        lblsp2_2.Text += B[j, k].ToString();
                        lblsp3_2.Text += B[j, k].ToString();
                        lblsp4_2.Text += B[j, k].ToString();
                    } if (k == 2 && i == 0)
                    {
                        lbl_showivalue.Text = (i + 1).ToString();
                        lbl_showjvalue.Text = (k + 1).ToString();
                        txtbs3.Text = B[j, k].ToString();
                        txtbxc3.Text = C[i, j].ToString();
                        lblsp1_2.Text += B[j, k].ToString();
                        lblsp2_2.Text += B[j, k].ToString();
                        lblsp3_2.Text += B[j, k].ToString();
                        lblsp4_2.Text += B[j, k].ToString();
                    } if (k == 3 && i == 0)
                    {
                        lbl_showivalue.Text = (i + 1).ToString();
                        lbl_showjvalue.Text = (k + 1).ToString();
                        txtbs4.Text = B[j, k].ToString();
                        txtbxc4.Text = C[i, k].ToString(); lblsp1_2.Text += B[j, k].ToString();
                        lblsp2_2.Text += B[j, k].ToString();
                        lblsp3_2.Text += B[j, k].ToString();
                        lblsp4_2.Text += B[j, k].ToString();
                    }//////i 0 end
                    if (k == 0 && i == 1)
                    {
                        lbl_showivalue.Text = (i + 1).ToString();
                        lbl_showjvalue.Text = (k+ 1).ToString();
                        txtbs1.Text = B[j, k].ToString();
                        txtbxc5.Text = C[i, k].ToString(); 
                        lblsp1_2.Text = B[j, k].ToString();
                        lblsp2_2.Text = B[j, k].ToString();
                        lblsp3_2.Text = B[j, k].ToString();
                        lblsp4_2.Text = B[j, k].ToString();
                    }
                    if (k == 1 && i == 1)
                    {
                        lbl_showivalue.Text = (i + 1).ToString();
                        lbl_showjvalue.Text = (k + 1).ToString();
                        txtbs2.Text = B[j, k].ToString();
                        txtbxc6.Text = C[i, k].ToString(); lblsp1_2.Text += B[j, k].ToString();
                        lblsp2_2.Text += B[j, k].ToString();
                        lblsp3_2.Text += B[j, k].ToString();
                        lblsp4_2.Text += B[j, k].ToString();
                    }
                    if (k == 2 && i == 1)
                    {
                        txtbs3.Text = B[j, k].ToString();
                        lbl_showivalue.Text = (i + 1).ToString();
                        lbl_showjvalue.Text = (k + 1).ToString();
                        txtbxc7.Text = C[i, k].ToString(); lblsp1_2.Text += B[j, k].ToString();
                        lblsp2_2.Text += B[j, k].ToString();
                        lblsp3_2.Text += B[j, k].ToString();
                        lblsp4_2.Text += B[j, k].ToString();
                    }
                    if (k == 3 && i == 1)
                    {
                        txtbs4.Text = B[j, k].ToString();
                        lbl_showivalue.Text = (i + 1).ToString();
                        lbl_showjvalue.Text = (k + 1).ToString();
                        txtbxc8.Text = C[i, k].ToString(); lblsp1_2.Text += B[j, k].ToString();
                        lblsp2_2.Text += B[j, k].ToString();
                        lblsp3_2.Text += B[j, k].ToString();
                        lblsp4_2.Text += B[j, k].ToString();
                    }/////////end i=1
                    if (k == 0 && i ==2)
                    {
                        lbl_showivalue.Text = (i + 1).ToString();
                        lbl_showjvalue.Text = (k + 1).ToString();
                        txtbs1.Text = B[j, k].ToString();
                        txtbxc9.Text = C[i, k].ToString(); 
                        lblsp1_2.Text = B[j, k].ToString();
                        lblsp2_2.Text = B[j, k].ToString();
                        lblsp3_2.Text = B[j, k].ToString();
                        lblsp4_2.Text = B[j, k].ToString();
                    }
                    if (k == 1 && i == 2)
                    {
                        lbl_showivalue.Text = (i + 1).ToString();
                        lbl_showjvalue.Text = (k + 1).ToString();
                        txtbs2.Text = B[j, k].ToString();
                        txtbxc10.Text = C[i, k].ToString(); lblsp1_2.Text += B[j, k].ToString();
                        lblsp2_2.Text += B[j, k].ToString();
                        lblsp3_2.Text += B[j, k].ToString();
                        lblsp4_2.Text += B[j, k].ToString();
                    }
                    if (k == 2 && i == 2)
                    {
                        lbl_showivalue.Text = (i + 1).ToString();
                        lbl_showjvalue.Text = (k + 1).ToString();
                        txtbs3.Text = B[j, k].ToString();
                        txtbxc11.Text = C[i, k].ToString(); lblsp1_2.Text += B[j, k].ToString();
                        lblsp2_2.Text += B[j, k].ToString();
                        lblsp3_2.Text += B[j, k].ToString();
                        lblsp4_2.Text += B[j, k].ToString();
                    }
                    if (k == 3 && i == 2)
                    {
                        lbl_showivalue.Text = (i + 1).ToString();
                        lbl_showjvalue.Text = (k + 1).ToString();
                        txtbs4.Text = B[j, k].ToString();
                        txtbxc12.Text = C[i, k].ToString(); lblsp1_2.Text += B[j, k].ToString();
                        lblsp2_2.Text += B[j, k].ToString();
                        lblsp3_2.Text += B[j, k].ToString();
                        lblsp4_2.Text += B[j, k].ToString();
                    }/////////end i=2
                    if (k == 0 && i == 3)
                    {
                        lbl_showivalue.Text = (i + 1).ToString();
                        lbl_showjvalue.Text = (k + 1).ToString();
                        txtbs1.Text = B[j, k].ToString();
                        txtbxc13.Text = C[i, k].ToString(); 
                        lblsp1_2.Text = B[j, k].ToString();
                        lblsp2_2.Text = B[j, k].ToString();
                        lblsp3_2.Text = B[j, k].ToString();
                        lblsp4_2.Text = B[j, k].ToString();
                    }
                    if (k == 1 && i == 3)
                    {
                        lbl_showivalue.Text = (i + 1).ToString();
                        lbl_showjvalue.Text = (k + 1).ToString();
                        txtbs2.Text = B[j, k].ToString();
                        txtbxc14.Text = C[i, k].ToString(); lblsp1_2.Text += B[j, k].ToString();
                        lblsp2_2.Text += B[j, k].ToString();
                        lblsp3_2.Text += B[j, k].ToString();
                        lblsp4_2.Text += B[j, k].ToString();
                    }
                    if (k == 2 && i == 3)
                    {
                        lbl_showivalue.Text = (i + 1).ToString();
                        lbl_showjvalue.Text = (k + 1).ToString();
                        txtbs3.Text = B[j, k].ToString();
                        txtbxc15.Text = C[i, k].ToString(); lblsp1_2.Text += B[j, k].ToString();
                        lblsp2_2.Text += B[j, k].ToString();
                        lblsp3_2.Text += B[j, k].ToString();
                        lblsp4_2.Text += B[j, k].ToString();
                    }
                    if (k == 3 && i == 3)
                    {
                        lbl_showivalue.Text = (i + 1).ToString();
                        lbl_showjvalue.Text = (k + 1).ToString();
                        txtbs4.Text = B[j, k].ToString();
                        txtbxc16.Text = C[i, k].ToString(); lblsp1_2.Text += B[j, k].ToString();
                        lblsp2_2.Text += B[j, k].ToString();
                        lblsp3_2.Text += B[j, k].ToString();
                        lblsp4_2.Text += B[j, k].ToString();
                    }/////////end i=3
                }
                    

                    lblindexI.Text = (i + 1).ToString();
                    lblindexj.Text = (j + 1).ToString();

                    if (i == 0 && j == 0)
                    {
                       // txtbxc1.Text = C[i, j].ToString();
                        lbl_a1.BackColor = Color.Red;
                       // lbl_b4.BackColor = Color.Green;
                        lbl_b1.BackColor = Color.Red;

                        lbl_b1.BackColor = Color.Red;
                    }
                    if (i == 0 && j == 1)
                    {
                       // txtbxc2.Text = C[i, j].ToString();
                        lbl_b1.BackColor = Color.Green;
                        lbl_b2.BackColor = Color.Red;


                    }
                    if (i == 0 && j == 2)
                    {
                        //txtbxc3.Text = C[i, j].ToString();
                        lbl_b2.BackColor = Color.Green;
                        lbl_b3.BackColor = Color.Red;



                    }////row 2
                    if (i == 0 && j == 3)
                    {
                        //txtbxc4.Text = C[i, j].ToString();
                        lbl_b3.BackColor = Color.Green;
                        lbl_b4.BackColor = Color.Red;

                    }
                    if (i == 1 && j == 0)
                    {
                        //txtbxc5.Text = C[i, j].ToString();
                        lbl_a2.BackColor = Color.Red;
                        lbl_b4.BackColor = Color.Green; 
                        lbl_b1.BackColor = Color.Red;

                    }
                    if (i == 1 && j == 1)
                    {
                        //txtbxc6.Text = C[i, j].ToString();
                        lbl_b1.BackColor = Color.Green;
                        lbl_b2.BackColor = Color.Red;

                    }
                    if (i == 1 && j == 2)
                    {
                        //txtbxc7.Text = C[i, j].ToString();

                        lbl_b2.BackColor = Color.Green;
                        lbl_b3.BackColor = Color.Red;
                    }
                    if (i == 1 && j == 3)
                    {
                        //txtbxc8.Text = C[i, j].ToString();
                        lbl_b3.BackColor = Color.Green;
                        lbl_b4.BackColor = Color.Red;

                    }
                    /////////////row 2
                    if (i == 2 && j == 0)
                    {
                        //txtbxc9.Text = C[i, j].ToString();
                        lbl_a3.BackColor = Color.Red;
                        lbl_b4.BackColor = Color.Green;
                        lbl_b1.BackColor = Color.Red;

                    }
                    if (i == 2 && j == 1)
                    {
                        //txtbxc10.Text = C[i, j].ToString();
                        lbl_b1.BackColor = Color.Green;
                        lbl_b2.BackColor = Color.Red;

                    }
                    if (i == 2 && j == 2)
                    {
                        //txtbxc11.Text = C[i, j].ToString();
                        lbl_b2.BackColor = Color.Green;
                        lbl_b3.BackColor = Color.Red;

                    }
                    if (i == 2 && j == 3)
                    {
                        //txtbxc12.Text = C[i, j].ToString();
                        lbl_b3.BackColor = Color.Green;
                        lbl_b4.BackColor = Color.Red;

                    }    //////////////row 3
                    if (i == 3 && j == 0)
                    {
                        //txtbxc13.Text = C[i, j].ToString();

                        lbl_a4.BackColor = Color.Red;
                        lbl_b4.BackColor = Color.Green;
                        lbl_b1.BackColor = Color.Red;
                    }
                    if (i == 3 && j == 1)
                    {
                        //txtbxc14.Text = C[i, j].ToString();
                        lbl_b1.BackColor = Color.Green;
                        lbl_b2.BackColor = Color.Red;

                    }
                    if (i == 3 && j == 2)
                    {
                        //txtbxc15.Text = C[i, j].ToString();
                        lbl_b2.BackColor = Color.Green;
                        lbl_b3.BackColor = Color.Red;


                    }
                    if (i == 3 && j == 3)
                    {
                        //txtbxc16.Text = C[i, j].ToString();
                        lbl_b3.BackColor = Color.Green;
                        lbl_b4.BackColor = Color.Red;


                    }
                
                //} //j end
               
            //} //i end
        
        
        } 

   
        int j = 0;int  m=0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (A[0, 0] == 0)
            {
                initializeAandB();
            }
            timer1.Start();
            timer1.Interval = 4000;
           
            multiple_show(m,j);
            j++;
            if (j == 4)
            {
                m++;
                j = 0;
            }
            if (m == 4) 
            {
                timer1.Stop();
                resetregister();
              
            }
        }
        protected void resetregister() 
        {
            txtmask1.Text = "0";
            txtmask2.Text = "0";
            txtmask3.Text = "0";
            txtmask4.Text = "0";
////
            lblloadA.Text = "";
            lbl_loadvalue.Text = "";
            txtbs1.Text = "";
            txtbs2.Text = ""; 
            txtbs3.Text = ""; 
            txtbs4.Text = "";
            txtp1.Text = "";

            txtp2.Text = "";
            txtp3.Text = "";
            txtp4.Text = "";
            lblsp1_1.Text = "< >";
            lblsp1_2.Text = "< >";
            lblsp1_3.Text = "< >";
            lblsp1_4.Text = "< >";
            lblsp2_1.Text = "< >";
            lblsp2_2.Text = "< >";
            lblsp2_3.Text = "< >";
            lblsp2_4.Text = "< >";
            lblsp3_1.Text = "< >";
            lblsp3_2.Text = "< >";
            lblsp3_3.Text = "< >";
            lblsp3_4.Text = "< >";
            lblsp4_1.Text = "< >";
            lblsp4_2.Text = "< >";
            lblsp4_3.Text = "< >";
            lblsp4_4.Text = "< >";

            lblindexI.Text = "0";
            lblindexj.Text = "0";
            lbl_showivalue.Text = "0";
            lbl_showjvalue.Text = "0";

        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

        }

       
 


        }


    }


