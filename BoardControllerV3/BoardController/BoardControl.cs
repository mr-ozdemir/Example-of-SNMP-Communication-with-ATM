using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime

///Developed by Mr.Ozdemir///

namespace BoardController
{


    public partial class Board : Form
    {

        public static int Selectitem;
        public static int SelectİtemTestQuantity;
        public static int SelectİtemStandbyTime;
        public static bool Stop = false;


        public Board()
        {


            InitializeComponent();

        }

        private void changeallbuttonstatus(bool status)
        {
            CloseAllBut.Enabled = status;

            M1Open.Enabled = status;
            M1Close.Enabled = status;
            M2Close.Enabled = status;
            M2Open.Enabled = status;
            Alarm.Enabled = status;
            Led.Enabled = status;
            Selenoid.Enabled = status;
            Role4.Enabled = status;
            DissConnectBut.Enabled = status;
            StartBut.Enabled = status;
            FinishBut.Enabled = status;
            TestM1CLO.Enabled = status;
            TestM1OP.Enabled = status;
            TestM2OP.Enabled = status;
            TestM2CLO.Enabled = status;

        }

        public void CloseAllMethod()
        {


            boardControl.setCommandOFF(boardControlHelper.relayName.role1);
            boardControl.setCommandOFF(boardControlHelper.relayName.role2);
            boardControl.setCommandOFF(boardControlHelper.relayName.role3);
            boardControl.setCommandOFF(boardControlHelper.relayName.role4);
            boardControl.setCommandOFF(boardControlHelper.relayName.role5);
            boardControl.setCommandOFF(boardControlHelper.relayName.role6);
            boardControl.setCommandOFF(boardControlHelper.relayName.role7);
            boardControl.setCommandOFF(boardControlHelper.relayName.role8);
        }



        private void CloseAll_Click(object sender, EventArgs e)
        {

            Stop = true;

            CloseAllMethod();
        }


        public static boardControlHelper boardControl;

        private void Connect_Click(object sender, EventArgs e)

        {



            boardControl = new boardControlHelper(textBox1.Text, Int32.Parse(textBox2.Text), textBox3.Text);



            try
            {

                Ping myping = new Ping();

                IPAddress ip;
                if (!IPAddress.TryParse(textBox1.Text, out ip))
                {
                    MessageBox.Show("Lütfen İP Adresi yazınız.");
                    return;
                }


                PingReply pReply = myping.Send(textBox1.Text, 5000);
                if (pReply.Status == IPStatus.TimedOut)

                {

                    MessageBox.Show("ping'e Ulaşılamadı");
                    return;

                }
                else
                {

                    boardControl.openConnection();
                    MessageBox.Show("Bağlandı");
                    ConnectBut.Enabled = false;
                    changeallbuttonstatus(true);
                }

            }
            catch
            {

            }

        }
        private void Board_Load(object sender, EventArgs e)
        {
            TimeBox.SelectedIndex = 1;
            changeallbuttonstatus(false);
            StandbyTimeBox.SelectedIndex = 3;
            TestQuantityBox.SelectedIndex = 2;
        }

        //-----------------------------------------------------------------------------
        public void M1OpenMethot()
        {

            boardControl.setCommandOFF(boardControlHelper.relayName.role5);
            boardControl.setCommandON(boardControlHelper.relayName.role6);
            Thread.Sleep(Selectitem);
            boardControl.setCommandOFF(boardControlHelper.relayName.role6);

        }

        private void M1open_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(M1OpenMethot);
            th.Start();
        }
        //-----------------------------------------------------------------------------

        public void LedMethot()
        {

            boardControl.setCommandON(boardControlHelper.relayName.role2);
            Thread.Sleep(Selectitem);
            boardControl.setCommandOFF(boardControlHelper.relayName.role2);

        }


        private void Led_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(LedMethot);
            th.Start();

        }

        //-----------------------------------------------------------------------------

        public void M1CloseMethot()
        {
            boardControl.setCommandOFF(boardControlHelper.relayName.role6);
            boardControl.setCommandON(boardControlHelper.relayName.role5);
            Thread.Sleep(Selectitem);
            boardControl.setCommandOFF(boardControlHelper.relayName.role5);
        }



        private void M1close_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(M1CloseMethot);
            th.Start();

        }

        //-----------------------------------------------------------------------------
        private void M2OpenMethot()
        {
            boardControl.setCommandOFF(boardControlHelper.relayName.role7);
            boardControl.setCommandON(boardControlHelper.relayName.role8);
            rejectpocetON(true);
            Thread.Sleep(Selectitem);
            boardControl.setCommandOFF(boardControlHelper.relayName.role8);
        }

        private void M2Open_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(M2OpenMethot);
            th.Start();
        }

        //-----------------------------------------------------------------------------



        private void M2CloseMethot()
        {
            boardControl.setCommandOFF(boardControlHelper.relayName.role8);
            boardControl.setCommandON(boardControlHelper.relayName.role7);
          
            Thread.Sleep(Selectitem);
            boardControl.setCommandOFF(boardControlHelper.relayName.role7);
        }

        private void M2Close_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(M2CloseMethot);
            th.Start();


        }
        //------------------------------------------------------------------------------------

        public void AlarmMethot()
        {

            boardControl.setCommandON(boardControlHelper.relayName.role1);
            Thread.Sleep(Selectitem);
            boardControl.setCommandOFF(boardControlHelper.relayName.role1);


        }


        private void Alarm_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(AlarmMethot);
            th.Start();


        }
        //------------------------------------------------------------------------------------------

        public void SelenoidMethot()
        {

            boardControl.setCommandON(boardControlHelper.relayName.role3);
            Thread.Sleep(Selectitem);

            boardControl.setCommandOFF(boardControlHelper.relayName.role3);


        }


        private void Selenoid_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(SelenoidMethot);
            th.Start();

        }

        //-------------------------------------------------------------------------------------------

        public void Role4Methot()
        {

            boardControl.setCommandON(boardControlHelper.relayName.role4);
            Thread.Sleep(Selectitem);
            boardControl.setCommandOFF(boardControlHelper.relayName.role4);

        }

        //-----------------------------------------------------------------------------------------------

        private void Role4_Click(object sender, EventArgs e)
        {
            Role4Methot();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            boardControl.closeconnection();
            ConnectBut.Enabled = true;
            changeallbuttonstatus(false);
            MessageBox.Show("Bağlantı Kesildi");

        }



        private void TimeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Selectitem = int.Parse(TimeBox.SelectedItem.ToString());
        }

        private void Board_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if(boardControl!=null)
                boardControl.closeconnection();
            }
            catch (Exception)
            {
                //
            }
        }

        void FinishMet()
        {
            
            Stop = true;
            CloseAllMethod();
            MessageBox.Show("Test Durduruldu");
        }
        private void FinishBut_Click(object sender, EventArgs e)
        {

            Thread Fth = new Thread(FinishMet);
            Fth.Start();

        }

        private void TestQuantityBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectİtemTestQuantity = int.Parse(TestQuantityBox.SelectedItem.ToString());

        }

        private void StandbyTimeBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            SelectİtemStandbyTime = int.Parse(StandbyTimeBox.SelectedItem.ToString());


        }
    

        public static void hopperPocketON(bool pocketValue)
        {
          


                int hopperONswitch, hopperOFFswitch;
                hopperONswitch = Int32.Parse(boardControl.getsensorValue(5));
                hopperOFFswitch = Int32.Parse(boardControl.getsensorValue(6));

                //return;
                if (pocketValue)
                {
                    if (hopperONswitch < 10)
                    {
                        //logforApplication.Info("Kabul Kapak zaten açık.=>" + hopperONswitch);
                        return;
                    }
                    string relayStatus = boardControl.getStatusOfrelay(boardControlHelper.relayName.role6);
                    if (relayStatus == "1")
                    {
                        //messageboxes.showpopupMessage("Kapak işleminin bitmesini bekleyiniz.", Application.Current.Dispatcher);
                        //logforApplication.Info("Kapak işleminin bitmesini bekleyiniz. Kabul gozu kapagi zaten islemde, ACILIYOR");
                        return;
                    }

                    bool reslt = boardControl.setCommandON(boardControlHelper.relayName.role6);
                    //logforApplication.Info("Kabul gozu kapagi acildi");
                }
                else
                {
                    if (hopperOFFswitch < 10)
                    {
                        //logforApplication.Info("Kabul Kapak zaten kapali.=>" + hopperOFFswitch);
                        return;
                    }
                    string relayStatus = boardControl.getStatusOfrelay(boardControlHelper.relayName.role5);
                    if (relayStatus == "1")
                    {
                        //logforApplication.Info("Kapak işleminin bitmesini bekleyiniz. Kabul gozu kapagi zaten islemde, kapaniyor");
                        return;
                    }
                    bool reslt = boardControl.setCommandON(boardControlHelper.relayName.role5);
                    //logforApplication.Info("Kabul gozu kapagi kapatildi");
                }
          
        }

        

        public static void rejectpocetON(bool pocketValue)
        {

            
                int rejectONswitch, rejectOFFswitch;
                rejectONswitch = Int32.Parse(boardControl.getsensorValue(7));
                rejectOFFswitch = Int32.Parse(boardControl.getsensorValue(8));


                //return;
                if (pocketValue)
                {
                    if (rejectONswitch < 10)
                    {
                        //logforApplication.Info("İade Kapak zaten açık.=>" + hopperONswitch);
                        return;
                    }
                    string relayStatus = boardControl.getStatusOfrelay(boardControlHelper.relayName.role8);
                    if (relayStatus == "1")
                    {
                        //messageboxes.showpopupMessage("Kapak işleminin bitmesini bekleyiniz.", Application.Current.Dispatcher);
                        //logforApplication.Info("Kapak işleminin bitmesini bekleyiniz. Kabul gozu kapagi zaten islemde, ACILIYOR");
                        return;
                    }
                    
                    bool reslt = boardControl.setCommandON(boardControlHelper.relayName.role8);
                    //logforApplication.Info("Kabul gozu kapagi acildi");
                }
                else
                {
                    if (rejectOFFswitch < 10)
                    {
                        //logforApplication.Info("İade Kapak zaten kapali.=>" + hopperOFFswitch);
                        return;
                    }
                    string relayStatus = boardControl.getStatusOfrelay(boardControlHelper.relayName.role7);
                    if (relayStatus == "1")
                    {
                        //logforApplication.Info("Kapak işleminin bitmesini bekleyiniz. Kabul gozu kapagi zaten islemde, kapaniyor");
                        return;
                    }
                    bool reslt = boardControl.setCommandON(boardControlHelper.relayName.role7);
                    //logforApplication.Info("İade gozu kapagi kapatildi");
                }
            
           
        }
        

        public static int OpenCounter = 0;
        public static int CloseCounter = 0;
        private void StartBut_Click(object sender, EventArgs e)
        {
            Thread TestTh = new Thread(TestMethot);
            TestTh.Start();
        }

        private void updateOpenlabel() 
        {
            if (OpenTestLab.InvokeRequired)
            {
                OpenTestLab.Invoke(new MethodInvoker(() => { OpenTestLab.Text = "Açılma Adedi: " + OpenCounter; }));
            }
        }
        private void updateCloselabel()
        {
            if (CloseTestLab.InvokeRequired)
            {
                CloseTestLab.Invoke(new MethodInvoker(() => { CloseTestLab.Text = "Kapanma Adedi: " + CloseCounter; }));
            }
        }
        public void TestMethot()
        {
            //test başlarken kapaklar kapatılır
            //hopperPocketON(false);
            //rejectpocetON(false);
            Stop = false;
            CloseCounter = 0;
            OpenCounter = 0;
            try
            {
                while (OpenCounter < SelectİtemTestQuantity && CloseCounter < SelectİtemTestQuantity)
                {

                    //hopperPocketON(true);
                    //rejectpocetON(true);
                    OpenCounter++;
                    Thread.Sleep(SelectİtemStandbyTime);
                    //hopperPocketON(false);
                    //rejectpocetON(false);
                    CloseCounter++;
                    Thread.Sleep(SelectİtemStandbyTime);   
                    updateOpenlabel();
                    updateCloselabel();
                  
                    if(Stop == true)
                    {
                        break;

                    }

                }
             
               if(OpenCounter == SelectİtemTestQuantity)
                {
                    MessageBox.Show("Test Başarıyla Gerçekleşti");


                }


            }
            catch (Exception ex)
            {
                Stop = true;
                CloseAllMethod();
                MessageBox.Show("Hata Anında Test Adedi " +
                    "\nAçılma: " + OpenCounter +
                    "\nKapanma:" + CloseCounter);
            }

        }

        private void CloseAllBut2_Click(object sender, EventArgs e)
        {
            Stop = true;
            CloseAllMethod();
          

        }

        void TestM1OPMet()
        {
            boardControl.setCommandOFF(boardControlHelper.relayName.role5);

            
            hopperPocketON(true);



        }

        private void TestM1OP_Click(object sender, EventArgs e)
        {
            Thread TM1 = new Thread(TestM1OPMet);
            TM1.Start();


        }

        void TestM1CLOMet()
        {

            boardControl.setCommandOFF(boardControlHelper.relayName.role6);
            hopperPocketON(false);

        }

        private void TestM1CLO_Click(object sender, EventArgs e)
        {

            Thread TM2 = new Thread(TestM1CLOMet);
            TM2.Start();
        }

        void TestM2OPMet()
        {

            boardControl.setCommandOFF(boardControlHelper.relayName.role7);
            rejectpocetON(true);


        }

        private void TestM2OP_Click(object sender, EventArgs e)
        {
            Thread TM3 = new Thread(TestM2OPMet);
            TM3.Start();

        }

        void TestM2CLOMet()
        {
            boardControl.setCommandOFF(boardControlHelper.relayName.role8);
            rejectpocetON(false);
           


        }
        private void TestM2CLO_Click(object sender, EventArgs e)
        {

            Thread TM3 = new Thread(TestM2CLOMet);
            TM3.Start();
        }
    }
}
