using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Collections;
namespace ConsoleApplication1
{
    class Program
    {

        static void Main(string[] args)
        {
            // 載入XML
            XmlDocument doc = new XmlDocument();
            doc.Load("./20180521.xml");
            
            //車站代碼跟車站名稱對應
            StreamReader file = new StreamReader("./車站代碼.txt",Encoding.UTF8);
            Hashtable Station_number = new Hashtable();
            string line = "";

            while ((line = file.ReadLine()) != null)
            {
                Char delimiter = '-';
                string[] data = line.Split(delimiter);
                Station_number.Add(data[0], data[1]);
            }

            // 搜尋符合條件的列車
            string start_station = "后里";
            string end_station = "潮州";
            string [] number = new string[2];

            number[0] = return_key(Station_number, start_station);
            number[1] = return_key(Station_number, end_station);

            XmlNode Node = doc.SelectSingleNode("TaiTrainList");
            XmlNodeList TrainInfo = Node.ChildNodes;

            bool start_flag = false, end_flag = false; //起始站跟終點站找到的旗標

            FileStream result = new FileStream("結果.txt", FileMode.Truncate);
            StreamWriter writer = new StreamWriter(result);

            foreach (XmlNode TrainInfoNode in TrainInfo)
            {
                XmlElement TrainInfoAtt = (XmlElement)TrainInfoNode;
                XmlNodeList TimeInfoNode = TrainInfoAtt.ChildNodes;

                string start = "", end = "", Empty = "  ", ArrTime = "", DepTime = "";

                foreach (XmlNode TimeInfoData in TimeInfoNode)
                {
                    XmlElement TimeInfoAtt = (XmlElement)TimeInfoData;

                    if (TimeInfoAtt.GetAttribute("Order") == "1")
                    {
                        start_flag = false;
                        end_flag = false;
                        start = return_station(Station_number, TimeInfoAtt.GetAttribute("Station"));
                    }

                    if (TimeInfoAtt.GetAttribute("Station") == number[1] && start_flag == false)
                    {
                        break;
                    }
                    else if (TimeInfoAtt.GetAttribute("Station") == number[0])
                    {
                        start_flag = true;
                        DepTime = TimeInfoAtt.GetAttribute("DEPTime");
                    }
                    else if (TimeInfoAtt.GetAttribute("Station") == number[1] && start_flag == true && end_flag == false)
                    {
                        ArrTime = TimeInfoAtt.GetAttribute("ARRTime");

                        writer.Write(TrainInfoAtt.GetAttribute("Train") + "次" + Empty);
                        writer.Write(start + Empty);

                        switch (TimeInfoAtt.GetAttribute("Line"))
                        {
                            case "1":
                                writer.Write("經山線" + Empty);
                                break;
                            case "2":
                                writer.Write("經海線" + Empty);
                                break;
                        }
                        end_flag = true;
                    }
                    end = return_station(Station_number, TimeInfoAtt.GetAttribute("Station"));

                }

                if (start_flag == true && end_flag == true)
                {
                    writer.Write("往" + Empty + end + Empty);
                    writer.Write(start_station + Empty + DepTime + Empty + "發車" + Empty + ArrTime + Empty + "抵達" + Empty + end_station + Empty);
                    writer.WriteLine("車種:" + TrainType(TrainInfoAtt.GetAttribute("CarClass")));
                }
                
            }

            writer.Close();
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
        private static string return_key(Hashtable temp,string station)
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