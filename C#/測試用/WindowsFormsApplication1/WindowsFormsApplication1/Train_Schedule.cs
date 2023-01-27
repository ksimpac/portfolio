using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Collections;

namespace WindowsFormsApplication1
{
    public struct Train
    {
        public string TrainType; //車中
        public string TrainNum;  //車次
        public string Line; //經山或海線
        public string Departure; //發車站
        public string Destination; //終點站
        public string DepTime; //開車時間
        public string ArrTime; //抵達時間
        public string Note; //備註
    }

    class Train_Schedule
    {

        private static XmlDocument doc = new XmlDocument(); //讀取XML
        private string start_station; //起程站
        private string end_station; //到達站
        private static Hashtable Station_number = new Hashtable(); //儲存各車站代碼
        private static string[] number = new string[2]; //儲存起程站跟到達站的車站代碼
        public static List<Train> Train_data_list = new List<Train>();
        private static Train Train_data;

        public Train_Schedule(string a,string b)
        {
            doc.Load("./20180521.xml");
            start_station = a;
            end_station = b;

            //車站代碼跟車站名稱對應
            StreamReader file = new StreamReader("./車站代碼.txt", Encoding.UTF8);
            string line = "";

            while ((line = file.ReadLine()) != null)
            {
                Char delimiter = '-';
                string[] data = line.Split(delimiter);
                Station_number.Add(data[0], data[1]);
            }

            number[0] = return_key(Station_number, start_station);
            number[1] = return_key(Station_number, end_station);
            searchXml();
        }

        private static void Input_Train_Data_list()
        {
            Train_data_list.Add(Train_data);
        }

        private static void searchXml()
        {
            bool start_flag = false, end_flag = false;

            XmlNode Node = doc.SelectSingleNode("TaiTrainList");
            XmlNodeList TrainInfo = Node.ChildNodes;

            foreach (XmlNode TrainInfoNode in TrainInfo)
            {
                XmlElement TrainInfoAtt = (XmlElement)TrainInfoNode;
                XmlNodeList TimeInfoNode = TrainInfoAtt.ChildNodes;

                foreach (XmlNode TimeInfoData in TimeInfoNode)
                {
                    XmlElement TimeInfoAtt = (XmlElement)TimeInfoData;

                    if (TimeInfoAtt.GetAttribute("Order") == "1")
                    {
                        start_flag = false;
                        end_flag = false;
                        Train_data.Departure = return_station(Station_number, TimeInfoAtt.GetAttribute("Station"));
                    }

                    if (TimeInfoAtt.GetAttribute("Station") == number[1] && start_flag == false)
                    {
                        break;
                    }
                    else if (TimeInfoAtt.GetAttribute("Station") == number[0])
                    {
                        start_flag = true;
                        Train_data.DepTime = TimeInfoAtt.GetAttribute("DEPTime");
                    }
                    else if (TimeInfoAtt.GetAttribute("Station") == number[1] && start_flag == true && end_flag == false)
                    {
                        Train_data.ArrTime = TimeInfoAtt.GetAttribute("ARRTime");

                        Train_data.TrainNum = TrainInfoAtt.GetAttribute("Train");

                        switch (TrainInfoAtt.GetAttribute("Line"))
                        {
                            case "1":
                                Train_data.Line = "山";
                                break;
                            case "2":
                                Train_data.Line = "海";
                                break;
                            default:
                                Train_data.Line = "";
                                break;
                        }
                        end_flag = true;
                    }
                    Train_data.Destination = return_station(Station_number, TimeInfoAtt.GetAttribute("Station"));
                }

                if (start_flag == true && end_flag == true)
                {
                    Train_data.TrainType = TrainType(TrainInfoAtt.GetAttribute("CarClass"));
                    Train_data.Note = TrainInfoAtt.GetAttribute("Note");
                    Input_Train_Data_list();
                }

            }

        }

        private static string TrainType(string Search)
        {
            string result = "";

            switch (Search)
            {
                case "1100":
                    result = "自強(DR2800、2900、3000型柴聯車及自強號電聯車)";
                    break;
                case "1101":
                    result = "自強(推拉式自強號[PP])";
                    break;
                case "1102":
                    result = "自強(太魯閣[TEMU1000])";
                    break;
                case "1103":
                    result = "自強(DMU3100型柴聯自強號) ";
                    break;
                case "1107":
                    result = "自強(普悠瑪[TEMU2000]) ";
                    break;
                case "1108":
                    result = "自強(推拉式自強號[PP]、第12節無自行車車廂) ";
                    break;
                case "1109":
                    result = "自強(推拉式自強號[PP]、第12節為親子車廂)";
                    break;
                case "110A":
                    result = "自強(推拉式自強號[PP]、第12節為無障礙車廂)";
                    break;
                case "110B":
                    result = "自強(EMU1200電聯車)";
                    break;
                case "110C":
                    result = "自強(EMU300電聯車)";
                    break;
                case "110D":
                    result = "自強(DR2800柴聯車)";
                    break;
                case "110E":
                    result = "自強(DR2900柴聯車)";
                    break;
                case "110F":
                    result = "自強(DR3100柴聯車)";
                    break;
                case "1110":
                    result = "莒光(無身障座位)";
                    break;
                case "1111":
                    result = "莒光(有身障座位)";
                    break;
                case "1114":
                    result = "莒光(無身障座位 ,有自行車車廂)";
                    break;
                case "1115":
                    result = "莒光(有身障座位 ,有自行車車廂)";
                    break;
                case "1120":
                    result = "復興";
                    break;
                case "1131":
                    result = "區間車";
                    break;
                case "1132":
                    result = "區間快";
                    break;
                case "1140":
                    result = "普快車";
                    break;
            }

            return result;
        }

        private static string return_key(Hashtable temp, string station)
        {
            string result = "";

            foreach (DictionaryEntry search in temp)
            {

                if (search.Value.ToString() == station)
                {
                    result = search.Key.ToString();
                    break;
                }
            }

            return result;
        }

        private static string return_station(Hashtable temp, string key)
        {
            string result = "";

            foreach (DictionaryEntry search in temp)
            {

                if (search.Key.ToString() == key)
                {
                    result = search.Value.ToString();
                    break;
                }
            }

            return result;
        }
    }
}
