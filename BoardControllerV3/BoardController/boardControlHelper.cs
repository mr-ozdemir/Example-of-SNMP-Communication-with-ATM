using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BoardController
{
    public class boardControlHelper
    {
        boardControl.boardAPI boardAPI;// = new boardControl.boardAPI("172.16.100.2", 161, "private");

        public boardControlHelper(string IP, int port, string community)
        {
            if (boardAPI == null)
            {
                boardAPI = new boardControl.boardAPI(IP, port, community);
            }
        }
        public void openConnection()
        {
            boardAPI.openConnection();
        }
        public void closeconnection()
        {
            boardAPI.closeConnection();
        }
        public enum relayName
        {
            role1 = 1,
            role2 = 2,
            role3 = 3,
            role4 = 4,
            role5 = 5,
            role6 = 6,
            role7 = 7,
            role8 = 8
        }
        public bool setCommandON(relayName relay)
        {
            int currentValueHopper, currentValueReject;
            currentValueHopper = Int32.Parse(boardAPI.getCurrentStatusCustom(".1.3.6.1.4.1.19865.1.2.3.3.0").GetVariable(0).NumericValueAsString);
            currentValueReject = Int32.Parse(boardAPI.getCurrentStatusCustom(".1.3.6.1.4.1.19865.1.2.3.4.0").GetVariable(0).NumericValueAsString);

            bool result = boardAPI.sendCommand(relay.GetHashCode().ToString(), "1");
            if (relay == relayName.role5 || relay == relayName.role6 || relay == relayName.role7 || relay == relayName.role8)
            {
                checkShutterCurrentStatus(currentValueHopper, currentValueReject);
            }
            return result;

        }
        public bool setCommandOFF(relayName relay)
        {
            return boardAPI.sendCommand(relay.GetHashCode().ToString(), "0");
        }

        public string getStatusOfrelay(relayName relay)
        {
            return boardAPI.getCurrentStatus(relay.GetHashCode().ToString()).GetVariable(0).NumericValueAsString;
        }


        public Dictionary<string, string> getOverallDeviceStatus()
        {
            Dictionary<string, string> devStatus = new Dictionary<string, string>();
            if (boardAPI.getCurrentStatusCustom(".1.3.6.1.4.1.19865.1.2.3.1.0").GetVariable(0).NumericValueAsString == "1023")
                devStatus.Add("titresim", "OK");
            else
                devStatus.Add("titresim", "Titreşim var");

            if (boardAPI.getCurrentStatusCustom(".1.3.6.1.4.1.19865.1.2.3.2.0").GetVariable(0).NumericValueAsString == "1023")
                devStatus.Add("DBMAnaKapak", "Kapali");
            else
                devStatus.Add("DBMAnaKapak", "Acik");

            if (Int32.Parse(boardAPI.getCurrentStatusCustom(".1.3.6.1.4.1.19865.1.2.3.5.0").GetVariable(0).NumericValueAsString) < 10)
                devStatus.Add("kabulgozu", "Kapak acik");

            if (Int32.Parse(boardAPI.getCurrentStatusCustom(".1.3.6.1.4.1.19865.1.2.3.6.0").GetVariable(0).NumericValueAsString) < 10)
                devStatus.Add("kabulgozu.", "Kapak kapali");

            if (Int32.Parse(boardAPI.getCurrentStatusCustom(".1.3.6.1.4.1.19865.1.2.3.7.0").GetVariable(0).NumericValueAsString) < 10)
                devStatus.Add("iadegozu", "Kapak acik");

            if (Int32.Parse(boardAPI.getCurrentStatusCustom(".1.3.6.1.4.1.19865.1.2.3.8.0").GetVariable(0).NumericValueAsString) < 10)
                devStatus.Add("iadegozu.", "Kapak kapali");

            String logText = String.Join(", ", devStatus.ToArray());

            return devStatus;
        }

        public string getsensorValue(int sensorNumber)
        {
            return boardAPI.getCurrentStatusCustom(".1.3.6.1.4.1.19865.1.2.3."+ sensorNumber + ".0").GetVariable(0).NumericValueAsString;
        }

        public void checkShutterCurrentStatus(int hopperCurrent, int rejectCurrent)
        {
            //Dictionary<string, string> devStatus = new Dictionary<string, string>();
            Thread t1 = new Thread(() =>
            {
                int i = 0;
                int initValuesw1, initValuesw2, currentValue;
                Thread.Sleep(1500);
                do
                {
                    currentValue = Int32.Parse(boardAPI.getCurrentStatusCustom(".1.3.6.1.4.1.19865.1.2.3.3.0").GetVariable(0).NumericValueAsString);
                    if (currentValue < hopperCurrent - 4)
                    {
                        shutterStuck("hopper");
                        i -= 5;
                    }
                    else if (currentValue > hopperCurrent + 4)
                    {
                        //Commons.logforApplication.Debug("AÇILIRKEN ZORLAMA hopperCurrent " + (hopperCurrent) + "  üstünde=>" + currentValue);
                    }
                    initValuesw1 = Int32.Parse(boardAPI.getCurrentStatusCustom(".1.3.6.1.4.1.19865.1.2.3.5.0").GetVariable(0).NumericValueAsString);
                    initValuesw2 = Int32.Parse(boardAPI.getCurrentStatusCustom(".1.3.6.1.4.1.19865.1.2.3.6.0").GetVariable(0).NumericValueAsString);
                    if (initValuesw1 > 890 || initValuesw2 > 890 || initValuesw1 < 10 || initValuesw2 < 10)//if (initValue > 190 && initValue < 220)
                        break;//Thread.Sleep(500);
                    else
                    {
                        Thread.Sleep(200);
                    }
                    i++;
                } while (i < 15);
                setCommandOFF(relayName.role5);
                setCommandOFF(relayName.role6);
                //Commons.logforApplication.Info("relay 5 6 kapatildi. relay 5=>" + initValuesw1
                 //  +"   relay 6=>"+ initValuesw2);
            });
            t1.Start();

            Thread t2 = new Thread(() =>
            {
                int i = 0;
                int initValuesw1, initValuesw2, currentValue; ;
                Thread.Sleep(1500);
                do
                {
                    currentValue = Int32.Parse(boardAPI.getCurrentStatusCustom(".1.3.6.1.4.1.19865.1.2.3.4.0").GetVariable(0).NumericValueAsString);
                    //Commons.logforApplication.Debug("currentValue =>" + currentValue);
                    if (currentValue < rejectCurrent - 4)
                    {
                        //Commons.logforApplication.Debug("KAPANIRKEN ZORLAMA rejectCurrent " + (rejectCurrent) + "  altında=>" + currentValue);
                        shutterStuck("reject");
                        i -= 5;
                    }
                    else if (currentValue > rejectCurrent + 4)
                    {
                        //Commons.logforApplication.Debug("AÇILIRKEN ZORLAMA rejectCurrent " + (rejectCurrent) + " üstünde=>" + currentValue);
                    }
                    initValuesw1 = Int32.Parse(boardAPI.getCurrentStatusCustom(".1.3.6.1.4.1.19865.1.2.3.7.0").GetVariable(0).NumericValueAsString);
                    initValuesw2 = Int32.Parse(boardAPI.getCurrentStatusCustom(".1.3.6.1.4.1.19865.1.2.3.8.0").GetVariable(0).NumericValueAsString);
                    if (initValuesw1 > 890 || initValuesw2 > 890 || initValuesw1 < 10 || initValuesw2 < 10)//if (initValue > 190 && initValue < 220)
                        break;//Thread.Sleep(500);
                    else
                    {
                        Thread.Sleep(200);
                    }
                    i++;
                } while (i < 15);
                setCommandOFF(relayName.role7);
                setCommandOFF(relayName.role8);
                //Commons.logforApplication.Info("relay 7 8 kapatildi. relay 7=>" + initValuesw1
                //    + "   relay 8=>" + initValuesw2);
            });
            t2.Start();
            t1.Join();
            t2.Join();
            //if (boardAPI.getCurrentStatusCustom(".1.3.6.1.4.1.19865.1.2.3.2.0").GetVariable(0).NumericValueAsString == "1023")
            //    devStatus.Add("iadegozu", "OK");
            //else
            //    devStatus.Add("iadegozu", "KAPAK ACIK");

            //String logText = String.Join(", ", devStatus.ToArray());
        }
        private void shutterStuck(string shutter)
        {
            throw new Exception("Sıkışma oldu kapak=>"+ shutter);
            //relayName relayClose, relayOpen;
            //if (shutter == "hopper")
            //{
            //    relayOpen = relayName.role6;
            //    relayClose = relayName.role5;

            //}
            //else/* if (shutter == "reject")*/
            //{
            //    relayOpen = relayName.role8;
            //    relayClose = relayName.role7;
            //}
            //setCommandOFF(relayClose);
            //setCommandOFF(relayOpen);
            //boardAPI.sendCommand(relayOpen.GetHashCode().ToString(), "1");
            //Thread.Sleep(1000);
            //boardAPI.sendCommand(relayOpen.GetHashCode().ToString(), "0");
            //Thread.Sleep(2000);
            //boardAPI.sendCommand(relayClose.GetHashCode().ToString(), "1");
        }
        public void closeALLrelays()
        {
            boardAPI.sendCommand(relayName.role1.GetHashCode().ToString(), "0");
            boardAPI.sendCommand(relayName.role2.GetHashCode().ToString(), "0");
            boardAPI.sendCommand(relayName.role3.GetHashCode().ToString(), "0");
            boardAPI.sendCommand(relayName.role4.GetHashCode().ToString(), "0");
            boardAPI.sendCommand(relayName.role5.GetHashCode().ToString(), "0");
            boardAPI.sendCommand(relayName.role6.GetHashCode().ToString(), "0");
            boardAPI.sendCommand(relayName.role7.GetHashCode().ToString(), "0");
            boardAPI.sendCommand(relayName.role8.GetHashCode().ToString(), "0");
        }
    }
}
