using System;
using System.Net;
using System.Net.Http;
using System.IO;
using System.Collections.Generic;

namespace HowToGetAPI
{
    //국토교통부_열차정보 관련 클래스
    class Train_Citycode // 기차의 도시코드를 얻는 클래스
    {
        public string Code { get; set; }
        public string Name { get; set; }

        public Train_Citycode(string code, string name)
        {
            this.Code = code;
            this.Name = name;
        }
        public void print()
        {
            Console.WriteLine("{0}: {1}", this.Name, this.Code);
        }
    }
    class Train_Stationcode // 기차의 역 코드를 얻는 클래스
    {
        public string Code { get; set; }
        public string Name { get; set; }

        public Train_Stationcode(string code, string name)
        {
            this.Code = code;
            this.Name = name;
        }
        public void print()
        {
            Console.WriteLine("{0}: {1}", this.Name, this.Code);
        }
    }
    class Train_Trainkinds // 기차의 종류를 얻는 클래스
    {
        public string Vehiclekndid { get; set; }
        public string Vehiclekndnm { get; set; }

        public Train_Trainkinds(string vehiclekndid, string vehiclekndnm)
        {
            this.Vehiclekndid = vehiclekndid;
            this.Vehiclekndnm = vehiclekndnm;
        }
        public void print()
        {
            Console.WriteLine("{0}: {1}", this.Vehiclekndid, this.Vehiclekndnm);
        }
    }
    class TrainList // 기차의 운행정보를 담는 클래스
    {
        public string Charge { get; set; }
        public string ArrName { get; set; }
        public string ArrTime { get; set; }
        public string DepName { get; set; }
        public string DepTime { get; set; }
        public string Grade { get; set; }
        public string Number { get; set; }

        public TrainList(string charge, string arrname, string arrtime, string depname, string deptime, string grade, string number)
        {
            this.Charge = charge;
            this.ArrName = arrname;
            this.ArrTime = arrtime;
            this.DepName = depname;
            this.DepTime = deptime;
            this.Grade = grade;
            this.Number = number;
        }
        public void print()
        {
            Console.WriteLine("비용    : {0}", this.Charge);
            Console.WriteLine("도착역  : {0}", this.ArrName);
            Console.WriteLine("도착시각: {0}", this.ArrTime);
            Console.WriteLine("출발역  : {0}", this.DepName);
            Console.WriteLine("출발시각: {0}", this.DepTime);
            Console.WriteLine("등급    : {0}", this.Grade);
            Console.WriteLine("열차번호: {0}", this.Number);
            Console.WriteLine();
        }
    }
    
    //국토교통부_국내항공운항정보 관련 클래스
    class Airport_AirportCode // 공항 코드를 얻는 클래스
    {
        public string AirportId { get; set; }
        public string AirportNm { get; set; }
        public Airport_AirportCode(string airportid, string airportnm)
        {
            this.AirportId = airportid;
            this.AirportNm = airportnm;
        }
        public void print()
        {
            Console.WriteLine("{0}: {1}", this.AirportId, this.AirportNm);
        }
    }
    class Airport_AirlineID // 항공사 코드를 얻는 클래스
    {
        public string AirlineId { get; set; }
        public string AirlineNm { get; set; }
        public Airport_AirlineID(string airlineid, string airlinenm)
        {
            this.AirlineId = airlineid;
            this.AirlineNm = airlinenm;
        }
        public void print()
        {
            Console.WriteLine("{0}: {1}", this.AirlineId, this.AirlineNm);
        }
    }
    class AirplaneList // 비행 운항 정보를 얻는 클래스
    {
        public string VihicleId { get; set; }
        public string AirlineNm { get; set; }
        public string DepPlandTime { get; set; }
        public string ArrPlandTime { get; set; }
        public string EconomyCharge { get; set; }
        public string PrestigeCharge { get; set; }
        public string DepAirportNm { get; set; }
        public string ArrAirportNm { get; set; }
        public AirplaneList( string airlinenm, string arrairportnm, string arrplandtime, string depairportnm, string depplandtime, string economycharge, string prestigecharge, string vihicleid)
        {
            this.AirlineNm = airlinenm;
            this.ArrAirportNm = arrairportnm;
            this.ArrPlandTime = arrplandtime;
            this.DepAirportNm = depairportnm;
            this.DepPlandTime = depplandtime;
            this.EconomyCharge = economycharge;
            this.PrestigeCharge = prestigecharge;
            this.VihicleId = vihicleid;
        }
        public void print()
        {
            Console.WriteLine("항공사명      : {0}", this.AirlineNm);
            Console.WriteLine("도착공항      : {0}", this.ArrAirportNm);
            Console.WriteLine("도착시각      : {0}", this.ArrPlandTime);
            Console.WriteLine("출발공항      : {0}", this.DepAirportNm);
            Console.WriteLine("출발시각      : {0}", this.DepPlandTime);
            Console.WriteLine("일반석운임    : {0}", this.EconomyCharge);
            Console.WriteLine("비즈니스석운임: {0}", this.PrestigeCharge);
            Console.WriteLine("항공편명      : {0}", this.VihicleId);
            Console.WriteLine();
        }
    }

    //국토교통부_고속버스정보 서비스
    class ExpressBus_Terminalcode // 고속버스의 터미널 코드를 얻는 클래스
    {
        public string terminalId { get; set; }
        public string terminalNm { get; set; }

        public ExpressBus_Terminalcode(string terminalid, string terminalnm)
        {
            this.terminalId = terminalid;
            this.terminalNm = terminalnm;
        }
        public void print()
        {
            Console.WriteLine("{0}: {1}", this.terminalId, this.terminalNm);
        }
    }
    class ExPressBus_BusGrade // 고속버스 등급을 얻는 클래스
    {
        public string GradeId { get; set; }
        public string GradeNm { get; set; }

        public ExPressBus_BusGrade(string gradeid, string gradenm)
        {
            this.GradeId = gradeid;
            this.GradeNm = gradenm;
        }
        public void print()
        {
            Console.WriteLine("{0}: {1}", this.GradeId, this.GradeNm);
        }
    }
    class ExpressBusList // 고속버스 운행정보를 얻는 클래스
    {
        public string RouteId { get; set; }
        public string GradeNm { get; set; }
        public string DepPlandTime { get; set; }
        public string ArrPlandTime { get; set; }
        public string DepPlaceNm { get; set; }
        public string ArrPlaceNm { get; set; }
        public string Charge { get; set; }
        public ExpressBusList(string routeid, string gradenm, string depplandtime, string arrplandtime, string depplacenm, string arrplacenm, string charge)
        {
            this.RouteId = routeid;
            this.GradeNm = gradenm;
            this.DepPlandTime = depplandtime;
            this.ArrPlandTime = arrplandtime;
            this.DepPlaceNm = depplacenm;
            this.ArrPlaceNm = arrplacenm;
            this.Charge = charge;
        }
        public void print()
        {
            Console.WriteLine("노선ID    : {0}", this.RouteId);
            Console.WriteLine("버스등급명: {0}", this.GradeNm);
            Console.WriteLine("출발시각  : {0}", this.DepPlandTime);
            Console.WriteLine("도착시각  : {0}", this.ArrPlandTime);
            Console.WriteLine("출발터미널: {0}", this.DepPlaceNm);
            Console.WriteLine("도착터미널: {0}", this.ArrPlaceNm);
            Console.WriteLine("운임      : {0}", this.Charge);
            Console.WriteLine();
        }
    }

    //국토교통부_시외버스




    class Class1
    {
        static HttpClient client = new HttpClient();

        static void Main(string[] args)
        {
            while (true)
            {
                string num;
                Console.WriteLine("이동수단을 입력해주세요.");
                Console.WriteLine("1: 기차");
                Console.WriteLine("2: 비행기");
                Console.WriteLine("3: 고속버스");
                Console.WriteLine("4: 시외버스");
                Console.WriteLine("5: 통합경로테스트");
                num = Console.ReadLine();
                if (num == "1")
                {
                    GB_Train();
                }
                else if (num == "2")
                {
                    GB_Airplane();
                }
                else if (num == "3")
                {
                    GB_ExpressBus();
                }
                else if (num == "4")
                {
                    GB_IntercityBus();
                }
                else if (num == "5")
                {
                    GB_GlobalPath();
                }
            }
        }
        static void GB_Train()
        {
            string Dep = string.Empty;
            string Arr = string.Empty;
            string Date = string.Empty;
            string Train = string.Empty;

            Console.WriteLine("첫번째 역 코드 입력.");
            Dep = Train_GetRegionCode();
            Console.WriteLine("출발역: {0}", Dep);

            Console.WriteLine("두번째 역 코드 입력.");
            Arr = Train_GetRegionCode();
            Console.WriteLine("도착역: {0}", Arr);

            Console.WriteLine("출발날짜 입력. EX) 20210419");
            Date = Console.ReadLine();

            Console.WriteLine("열차 종류 입력.");
            Train=Train_GetTrainCode();

            Train_GetStartToEnd(Dep, Arr, Date, Train);
        }
        static void GB_Airplane()
        {
            string Dep = string.Empty;
            string Arr = string.Empty;
            string Date = string.Empty;
            string Airlines = string.Empty;

            Console.WriteLine("첫번째 공항 코드 입력.");
            Dep = Airport_GetAirportCode();
            Console.WriteLine("출발공항: {0}", Dep);

            Console.WriteLine("두번째 공항 코드 입력.");
            Arr = Airport_GetAirportCode();
            Console.WriteLine("도착공항: {0}", Arr);

            Console.WriteLine("출발날짜 입력. EX) 20210419");
            Date = Console.ReadLine();

            Console.WriteLine("항공사 ID 입력.");
            Airlines = Airport_GetAirlinesID();
            Console.WriteLine("항공사: {0}", Airlines);

            Airport_GetStartToEnd(Dep, Arr, Date, Airlines);
        }
        static void GB_ExpressBus()
        {
            string Dep = string.Empty;
            string Arr = string.Empty;
            string Date = string.Empty;
            string ExBus = string.Empty;

            Console.WriteLine("첫번째 터미널 지역 입력.");
            Dep = ExpressBus_GetTerminalID();
            Console.WriteLine("출발터미널: {0}", Dep);

            Console.WriteLine("두번째 터미널 지역 입력.");
            Arr = ExpressBus_GetTerminalID();
            Console.WriteLine("도착터미널: {0}", Arr);

            Console.WriteLine("출발날짜 입력. EX) 20210419");
            Date = Console.ReadLine();

            Console.WriteLine("버스 등급 입력.");
            ExBus = ExpressBus_GetExpressBusGrade();

            ExpressBus_GetStartToEnd(Dep, Arr, Date, ExBus);
        }
        static void GB_IntercityBus()
        {

        }

        static string Train_GetRegionCode()
        { // 지역 코드를 얻는 함수
            List<Train_Citycode> cities = new List<Train_Citycode>(); // 지역코드 저장
                                                          //Queue<Citycode> cities = new Queue<Citycode>();
                                                          //Citycode city = new Citycode

            string url = "http://openapi.tago.go.kr/openapi/service/TrainInfoService/getCtyCodeList"; // URL
            url += "?ServiceKey=" + "MYFMxLc4kHFtLGMFgXDn3EnezpmlYYDTjebarh6bvwc4x1B2ePwhjl52FeUi9FAYNOzVmnQn%2BhmZTGTleodsfQ%3D%3D"; // Service Key


            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            string results = string.Empty;
            HttpWebResponse response;
            using (response = request.GetResponse() as HttpWebResponse)
            {
                StreamReader reader = new StreamReader(response.GetResponseStream());
                results = reader.ReadToEnd();
            }

            string Real_results = string.Empty;

            int sw = 0;
            string str = string.Empty;
            string text = string.Empty;
            string c_code = string.Empty;
            string c_name = string.Empty;
            for (int i = 0; i < results.Length; i++)
            {
                if (sw == 1 && results[i] != '<' && results[i] != '>')
                {
                    str += results[i];
                }
                else if (results[i] == '>')
                {
                    switch (str)
                    {
                        case "resultMsg":
                            sw = 2;
                            break;
                        case "citycode":
                            sw = 3;
                            break;
                        case "cityname":
                            sw = 4;
                            break;
                        default:
                            sw = 0;
                            break;
                    }
                }

                if (results[i] != '<' && results[i] != '>')
                {
                    switch (sw)
                    {
                        case 2:
                            text += results[i];
                            break;
                        case 3:
                            c_code += results[i];
                            break;
                        case 4:
                            c_name += results[i];
                            break;
                    }
                    text += results[i];
                }
                else if (results[i] == '<')
                {
                    switch (sw)
                    {
                        case 4:
                            if (str.Length > 0 && c_name.Length > 0)
                            {
                                cities.Add(new Train_Citycode(c_code, c_name));
                                c_code = string.Empty;
                                c_name = string.Empty;
                            }
                            break;
                    }
                    sw = 0;
                    str = string.Empty;
                    text = string.Empty;
                }
                if (sw == 0 && results[i] == '<' && results[i + 1] != '/')
                {
                    sw = 1;
                }
            }

            int sww = 0;
            while (true) // 코드 받아서 역 리스트 받는 부분으로 넘김
            {
                foreach (var c in cities)
                {
                    Console.WriteLine("{0}: {1}", c.Name, c.Code);
                }
                Console.WriteLine();
                string input_code = string.Empty; // 입력받은 코드를 저장할 문자열 변수
                Console.Write("Give me a Region Code: "); // 코드를 입력하세요!
                input_code = Console.ReadLine(); // 입력
                sww = 0;
                foreach (var c in cities)
                {
                    if (c.Code == input_code) // 지역코드 중에 맞는 코드가 있는지 확인
                    {
                        sww = 1;
                        string res = Train_GetStationCode(input_code); // 역 데이터를 받아오는 함수 실행
                        if (res != "-1")
                        {
                            return res;
                        }
                        break;
                    }
                }
                if (sww == 0)
                {
                    Console.WriteLine("지역 코드를 다시 입력해 주세요!\n"); // 일치하는 코드가 없을 시 메시지
                    Console.WriteLine("{0}", cities.Count);
                }
            }
            return null;
        }
        public static string Train_GetStationCode(string code)
        {
            List<Train_Stationcode> Station = new List<Train_Stationcode>(); // 지역코드를 받은 후, 역 코드 저장
            string url = "http://openapi.tago.go.kr/openapi/service/TrainInfoService/getCtyAcctoTrainSttnList"; // URL
            url += "?ServiceKey=" + "MYFMxLc4kHFtLGMFgXDn3EnezpmlYYDTjebarh6bvwc4x1B2ePwhjl52FeUi9FAYNOzVmnQn%2BhmZTGTleodsfQ%3D%3D"; // Service Key
            url += "&numOfRows=100";
            url += "&pageNo=1";
            url += "&cityCode=";
            url += code;

            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            string results = string.Empty;
            HttpWebResponse response;
            using (response = request.GetResponse() as HttpWebResponse)
            {
                StreamReader reader = new StreamReader(response.GetResponseStream());
                results = reader.ReadToEnd();
            }

            int sw = 0;
            string str = string.Empty;
            string text = string.Empty;
            string c_code = string.Empty;
            string c_name = string.Empty;
            for (int i = 0; i < results.Length; i++)
            {
                if (sw == 1 && results[i] != '<' && results[i] != '>')
                {
                    str += results[i];
                }
                else if (results[i] == '>')
                {
                    switch (str)
                    {
                        case "resultMsg":
                            sw = 2;
                            break;
                        case "nodeid":
                            sw = 3;
                            break;
                        case "nodename":
                            sw = 4;
                            break;
                        default:
                            sw = 0;
                            break;
                    }
                }

                if (results[i] != '<' && results[i] != '>')
                {
                    switch (sw)
                    {
                        case 2:
                            text += results[i];
                            break;
                        case 3:
                            c_code += results[i];
                            break;
                        case 4:
                            c_name += results[i];
                            break;
                    }
                    text += results[i];
                }
                else if (results[i] == '<')
                {
                    switch (sw)
                    {
                        case 2:
                            if (str.Length > 0 && text.Length > 0)
                            {
                            }
                            break;
                        case 3:
                            if (str.Length > 0 && c_code.Length > 0)
                            {
                            }
                            break;
                        case 4:
                            if (str.Length > 0 && c_name.Length > 0)
                            {
                                Station.Add(new Train_Stationcode(c_code, c_name));
                                c_code = string.Empty;
                                c_name = string.Empty;
                            }
                            break;
                    }
                    sw = 0;
                    str = string.Empty;
                    text = string.Empty;
                }
                if (sw == 0 && results[i] == '<' && results[i + 1] != '/')
                {
                    sw = 1;
                }
            }

            int sww = 0;
            while (true) // 코드 받아서 역 리스트 받는 부분으로 넘김
            {
                foreach (var c in Station)
                {
                    Console.WriteLine("{0}: {1}", c.Name, c.Code);
                }
                Console.WriteLine();
                string input_code = string.Empty; // 입력받은 코드를 저장할 문자열 변수
                Console.Write("Give me a Station Code: EX) NAT000000   "); // 코드를 입력하세요!
                input_code = Console.ReadLine(); // 입력
                if (input_code == "-1") return "-1";
                sww = 0;
                foreach (var c in Station)
                {
                    if (c.Code == input_code) // 역코드 중에 맞는 코드가 있는지 확인
                    {
                        sww = 1;
                        return input_code;
                        break;
                    }
                }
                if (sww == 0)
                {
                    Console.WriteLine("역 코드를 다시 입력해 주세요!\n"); // 일치하는 코드가 없을 시 메시지
                }
            }
            Console.WriteLine();
            return null;
        }

        public static string Train_GetTrainCode()
        {
            List<Train_Trainkinds> trainkinds = new List<Train_Trainkinds>();

            string url = "http://openapi.tago.go.kr/openapi/service/TrainInfoService/getVhcleKndList"; // URL
            url += "?ServiceKey=" + "MYFMxLc4kHFtLGMFgXDn3EnezpmlYYDTjebarh6bvwc4x1B2ePwhjl52FeUi9FAYNOzVmnQn%2BhmZTGTleodsfQ%3D%3D"; // Service Key

            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            string results = string.Empty;
            HttpWebResponse response;
            using (response = request.GetResponse() as HttpWebResponse)
            {
                StreamReader reader = new StreamReader(response.GetResponseStream());
                results = reader.ReadToEnd();
            }

            string Real_results = string.Empty;
            int sw = 0;
            string str = string.Empty;
            string text = string.Empty;
            string vehiclekndid = string.Empty;
            string vehiclekndnm = string.Empty;

            for (int i = 0; i < results.Length; i++)
            {
                if (sw == 1 && results[i] != '<' && results[i] != '>')
                {
                    str += results[i];
                }
                else if (results[i] == '>')
                {
                    switch (str)
                    {
                        case "resultMsg":
                            sw = 2;
                            break;
                        case "vehiclekndid":
                            sw = 3;
                            break;
                        case "vehiclekndnm":
                            sw = 4;
                            break;
                        default:
                            sw = 0;
                            break;
                    }
                }

                if (results[i] != '<' && results[i] != '>')
                {
                    switch (sw)
                    {
                        case 2:
                            text += results[i];
                            break;
                        case 3:
                            vehiclekndid += results[i];
                            break;
                        case 4:
                            vehiclekndnm += results[i];
                            break;
                    }
                    text += results[i];
                }
                else if (results[i] == '<')
                {
                    switch (sw)
                    {
                        case 4:
                            if (str.Length > 0 && vehiclekndnm.Length > 0)
                            {
                                trainkinds.Add(new Train_Trainkinds(vehiclekndid, vehiclekndnm));
                                vehiclekndid = string.Empty;
                                vehiclekndnm = string.Empty;
                            }
                            break;
                    }
                    sw = 0;
                    str = string.Empty;
                    text = string.Empty;
                }
                if (sw == 0 && results[i] == '<' && results[i + 1] != '/')
                {
                    sw = 1;
                }
            }

            int sww = 0;
            while (true) // 코드 받아서 역 리스트 받는 부분으로 넘김
            {
                foreach (var c in trainkinds)
                {
                    Console.WriteLine("{0}: {1}", c.Vehiclekndid, c.Vehiclekndnm);
                }
                Console.WriteLine();
                string input_code = string.Empty; // 입력받은 코드를 저장할 문자열 변수
                Console.Write("Give me a Train Grade Code: "); // 코드를 입력하세요!
                input_code = Console.ReadLine(); // 입력
                sww = 0;
                foreach (var c in trainkinds)
                {
                    if (c.Vehiclekndid == input_code) // 지역코드 중에 맞는 코드가 있는지 확인
                    {
                        sww = 1;
                        return input_code;
                        break;
                    }
                }
                if (sww == 0)
                {
                    Console.WriteLine("열차 코드를 다시 입력해 주세요!\n"); // 일치하는 코드가 없을 시 메시지
                    Console.WriteLine("{0}", trainkinds.Count);
                }
            }
            return null;
        }
        public static void Train_GetStartToEnd(string start, string end, string deptime, string train)
        {
            Console.WriteLine("출발지  :{0}", start);
            Console.WriteLine("도착지  :{0}", end);
            Console.WriteLine("출발시각:{0}", deptime);
            Console.WriteLine("등급    :{0}",train);
            List<TrainList> trainlist = new List<TrainList>();
            string url = "http://openapi.tago.go.kr/openapi/service/TrainInfoService/getStrtpntAlocFndTrainInfo"; // URL
            url += "?ServiceKey=" + "MYFMxLc4kHFtLGMFgXDn3EnezpmlYYDTjebarh6bvwc4x1B2ePwhjl52FeUi9FAYNOzVmnQn%2BhmZTGTleodsfQ%3D%3D"; // Service Key
            url += "&numOfRows=100";
            url += "&pageNo=1";
            url += "&depPlaceId=";
            url += start;
            url += "&arrPlaceId=";
            url += end;
            url += "&depPlandTime=";
            url += deptime;
            url += "&trainGradeCode=";
            url += train;

            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            string results = string.Empty;
            HttpWebResponse response;
            using (response = request.GetResponse() as HttpWebResponse)
            {
                StreamReader reader = new StreamReader(response.GetResponseStream());
                results = reader.ReadToEnd();
            }
            //Console.WriteLine(results);

            //string Real_results = string.Empty;
            //Console.WriteLine(results);
            int sw = 0;
            string str = string.Empty;
            string text = string.Empty;

            string c_charge = string.Empty;
            string c_arrname = string.Empty;
            string c_arrtime = string.Empty;
            string c_depname = string.Empty;
            string c_deptime = string.Empty;
            string c_grade = string.Empty;
            string c_number = string.Empty;

            for (int i = 0; i < results.Length; i++)
            {
                if (sw == 1 && results[i] != '<' && results[i] != '>')
                {
                    str += results[i];
                }
                else if (results[i] == '>')
                {
                    switch (str)
                    {
                        case "resultMsg":
                            sw = 2;
                            break;
                        case "adultcharge": // 비용
                            sw = 3;
                            break;
                        case "arrplacename": // 출발역
                            sw = 4;
                            break;
                        case "arrplandtime":
                            sw = 5;
                            break;
                        case "depplacename":
                            sw = 6;
                            break;
                        case "depplandtime":
                            sw = 7;
                            break;
                        case "traingradename":
                            sw = 8;
                            break;
                        case "trainno":
                            sw = 9;
                            break;
                        default:
                            sw = 0;
                            break;
                    }
                }

                if (results[i] != '<' && results[i] != '>')
                {
                    switch (sw)
                    {
                        case 2:
                            text += results[i];
                            break;
                        case 3:
                            c_charge += results[i];
                            break;
                        case 4:
                            c_arrname += results[i];
                            break;
                        case 5:
                            c_arrtime += results[i];
                            break;
                        case 6:
                            c_depname += results[i];
                            break;
                        case 7:
                            c_deptime += results[i];
                            break;
                        case 8:
                            c_grade += results[i];
                            break;
                        case 9:
                            c_number += results[i];
                            break;
                    }
                    text += results[i];
                }
                else if (results[i] == '<')
                {
                    switch (sw)
                    {
                        case 9:
                            if (str.Length > 0 && c_number.Length > 0)
                            {
                                //Citycode css = new Citycode(c_code, c_name);
                                //css.print();
                                //cities.Add(new Citycode(c_code, c_name));
                                trainlist.Add(new TrainList(c_charge, c_arrname, c_arrtime, c_depname, c_deptime, c_grade, c_number));
                                c_charge = string.Empty;
                                c_arrname = string.Empty;
                                c_arrtime = string.Empty;
                                c_depname = string.Empty;
                                c_deptime = string.Empty;
                                c_grade = string.Empty;
                                c_number = string.Empty;
                            }
                            break;
                    }
                    sw = 0;
                    str = string.Empty;
                    text = string.Empty;
                }
                if (sw == 0 && results[i] == '<' && results[i + 1] != '/')
                {
                    sw = 1;
                }
            }
            foreach (var c in trainlist)
            {
                c.print();
                //Console.WriteLine("{0}: {1}", c.Name, c.Code);
            }
        }
        
        //비행기
        //public static void
        public static string Airport_GetAirportCode()
        { // 지역 코드를 얻는 함수
            List<Airport_AirportCode> airports = new List<Airport_AirportCode>(); // 지역코드 저장
                                                                                  //Queue<Citycode> cities = new Queue<Citycode>();
                                                                                  //Citycode city = new Citycode

            string url = "http://openapi.tago.go.kr/openapi/service/DmstcFlightNvgInfoService/getArprtList"; // URL
            url += "?ServiceKey=" + "MYFMxLc4kHFtLGMFgXDn3EnezpmlYYDTjebarh6bvwc4x1B2ePwhjl52FeUi9FAYNOzVmnQn%2BhmZTGTleodsfQ%3D%3D"; // Service Key


            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            string results = string.Empty;
            HttpWebResponse response;
            using (response = request.GetResponse() as HttpWebResponse)
            {
                StreamReader reader = new StreamReader(response.GetResponseStream());
                results = reader.ReadToEnd();
            }

            string Real_results = string.Empty;

            int sw = 0;
            string str = string.Empty;
            string text = string.Empty;
            string airportId = string.Empty;
            string airportNm = string.Empty;
            for (int i = 0; i < results.Length; i++)
            {
                if (sw == 1 && results[i] != '<' && results[i] != '>')
                {
                    str += results[i];
                }
                else if (results[i] == '>')
                {
                    switch (str)
                    {
                        case "resultMsg":
                            sw = 2;
                            break;
                        case "airportId":
                            sw = 3;
                            break;
                        case "airportNm":
                            sw = 4;
                            break;
                        default:
                            sw = 0;
                            break;
                    }
                }

                if (results[i] != '<' && results[i] != '>')
                {
                    switch (sw)
                    {
                        case 2:
                            text += results[i];
                            break;
                        case 3:
                            airportId += results[i];
                            break;
                        case 4:
                            airportNm += results[i];
                            break;
                    }
                    text += results[i];
                }
                else if (results[i] == '<')
                {
                    switch (sw)
                    {
                        case 4:
                            if (str.Length > 0 && airportNm.Length > 0)
                            {
                                airports.Add(new Airport_AirportCode(airportId, airportNm));
                                airportId = string.Empty;
                                airportNm = string.Empty;
                            }
                            break;
                    }
                    sw = 0;
                    str = string.Empty;
                    text = string.Empty;
                }
                if (sw == 0 && results[i] == '<' && results[i + 1] != '/')
                {
                    sw = 1;
                }
            }

            int sww = 0;
            while (true) // 코드 받아서 공항 리스트 받는 부분으로 넘김
            {
                foreach (var c in airports)
                {
                    Console.WriteLine("{0}: {1}", c.AirportNm, c.AirportId);
                }
                Console.WriteLine();
                string input_code = string.Empty; // 입력받은 코드를 저장할 문자열 변수
                Console.Write("Give me a Airport Code: "); // 코드를 입력하세요!
                input_code = Console.ReadLine(); // 입력
                sww = 0;
                foreach (var c in airports)
                {
                    if (c.AirportId == input_code) // 공항코드 중에 맞는 코드가 있는지 확인
                    {
                        sww = 1;
                        return input_code;
                        break;
                    }
                }
                if (sww == 0)
                {
                    Console.WriteLine("공항 코드를 다시 입력해 주세요!\n"); // 일치하는 코드가 없을 시 메시지
                    Console.WriteLine("{0}", airports.Count);
                }
            }
            return null;
        }
        public static string Airport_GetAirlinesID()
        { // 항공사 코드를 얻는 함수
            List<Airport_AirlineID> airlines = new List<Airport_AirlineID>(); // 지역코드 저장
                                                                              //Queue<Citycode> cities = new Queue<Citycode>();
                                                                              //Citycode city = new Citycode

            string url = "http://openapi.tago.go.kr/openapi/service/DmstcFlightNvgInfoService/getAirmanList"; // URL
            url += "?ServiceKey=" + "MYFMxLc4kHFtLGMFgXDn3EnezpmlYYDTjebarh6bvwc4x1B2ePwhjl52FeUi9FAYNOzVmnQn%2BhmZTGTleodsfQ%3D%3D"; // Service Key


            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            string results = string.Empty;
            HttpWebResponse response;
            using (response = request.GetResponse() as HttpWebResponse)
            {
                StreamReader reader = new StreamReader(response.GetResponseStream());
                results = reader.ReadToEnd();
            }

            string Real_results = string.Empty;

            int sw = 0;
            string str = string.Empty;
            string text = string.Empty;
            string airlineId = string.Empty;
            string airlineNm = string.Empty;
            for (int i = 0; i < results.Length; i++)
            {
                if (sw == 1 && results[i] != '<' && results[i] != '>')
                {
                    str += results[i];
                }
                else if (results[i] == '>')
                {
                    switch (str)
                    {
                        case "resultMsg":
                            sw = 2;
                            break;
                        case "airlineId":
                            sw = 3;
                            break;
                        case "airlineNm":
                            sw = 4;
                            break;
                        default:
                            sw = 0;
                            break;
                    }
                }

                if (results[i] != '<' && results[i] != '>')
                {
                    switch (sw)
                    {
                        case 2:
                            text += results[i];
                            break;
                        case 3:
                            airlineId += results[i];
                            break;
                        case 4:
                            airlineNm += results[i];
                            break;
                    }
                    text += results[i];
                }
                else if (results[i] == '<')
                {
                    switch (sw)
                    {
                        case 4:
                            if (str.Length > 0 && airlineNm.Length > 0)
                            {
                                airlines.Add(new Airport_AirlineID(airlineId, airlineNm));
                                airlineId = string.Empty;
                                airlineNm = string.Empty;
                            }
                            break;
                    }
                    sw = 0;
                    str = string.Empty;
                    text = string.Empty;
                }
                if (sw == 0 && results[i] == '<' && results[i + 1] != '/')
                {
                    sw = 1;
                }
            }

            int sww = 0;
            while (true) // 코드 받아서 항공사 리스트 받는 부분으로 넘김
            {
                foreach (var c in airlines)
                {
                    Console.WriteLine("{0}: {1}", c.AirlineNm, c.AirlineId);
                }
                Console.WriteLine();
                string input_code = string.Empty; // 입력받은 코드를 저장할 문자열 변수
                Console.Write("Give me a Airline Code: "); // 코드를 입력하세요!
                input_code = Console.ReadLine(); // 입력
                sww = 0;
                foreach (var c in airlines)
                {
                    if (c.AirlineId == input_code) // 항공사 코드 중에 맞는 코드가 있는지 확인
                    {
                        sww = 1;
                        return input_code;
                        break;
                    }
                }
                if (sww == 0)
                {
                    Console.WriteLine("항공사 코드를 다시 입력해 주세요!\n"); // 일치하는 코드가 없을 시 메시지
                    Console.WriteLine("{0}", airlines.Count);
                }
            }
            return null;
        }
        public static void Airport_GetStartToEnd(string start, string end, string deptime, string airline)
        {
            Console.WriteLine("출발공항: {0}", start);
            Console.WriteLine("도착공항: {0}", end);
            Console.WriteLine("출발시각: {0}", deptime);
            Console.WriteLine("항공사명: {0}", airline);
            List<AirplaneList> airplanelist = new List<AirplaneList>();
            string url = "http://openapi.tago.go.kr/openapi/service/DmstcFlightNvgInfoService/getFlightOpratInfoList"; // URL
            url += "?ServiceKey=" + "MYFMxLc4kHFtLGMFgXDn3EnezpmlYYDTjebarh6bvwc4x1B2ePwhjl52FeUi9FAYNOzVmnQn%2BhmZTGTleodsfQ%3D%3D"; // Service Key
            url += "&numOfRows=100";
            url += "&pageNo=1";
            url += "&depAirportId=";
            url += start;
            url += "&arrAirportId=";
            url += end;
            url += "&depPlandTime=";
            url += deptime;
            url += "&airlineId=";
            url += airline;

            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            string results = string.Empty;
            HttpWebResponse response;
            using (response = request.GetResponse() as HttpWebResponse)
            {
                StreamReader reader = new StreamReader(response.GetResponseStream());
                results = reader.ReadToEnd();
            }

            //string Real_results = string.Empty;
            //Console.WriteLine(results);
            int sw = 0;
            string str = string.Empty;
            string text = string.Empty;

            string airlinenm = string.Empty;
            string arrairportnm = string.Empty;
            string arrplandtime = string.Empty;
            string depairportnm = string.Empty;
            string depplandtime = string.Empty;
            string economycharge = string.Empty;
            string prestigecharge = string.Empty;
            string vihicleid = string.Empty;

            for (int i = 0; i < results.Length; i++)
            {
                if (sw == 1 && results[i] != '<' && results[i] != '>')
                {
                    str += results[i];
                }
                else if (results[i] == '>')
                {
                    switch (str)
                    {
                        case "resultMsg":
                            sw = 2;
                            break;
                        case "airlineNm": // 항공사명
                            sw = 3;
                            break;
                        case "arrAirportNm": // 도착공항
                            sw = 4;
                            break;
                        case "arrPlandTime": // 도착예정시각
                            sw = 5;
                            break;
                        case "depAirportNm": // 출발공항
                            sw = 6;
                            break;
                        case "depPlandTime": // 출발예정시각
                            sw = 7;
                            break;
                        case "economyCharge": // 일반석운임
                            sw = 8;
                            break;
                        case "prestigeChgarge": // 비즈니스석운임
                            sw = 9;
                            break;
                        case "vihicleId": // 항공편명
                            sw = 10;
                            break;
                        default:
                            sw = 0;
                            break;
                    }
                }

                if (results[i] != '<' && results[i] != '>')
                {
                    switch (sw)
                    {
                        case 2:
                            text += results[i];
                            break;
                        case 3:
                            airlinenm += results[i];
                            break;
                        case 4:
                             arrairportnm += results[i];
                            break;
                        case 5:
                            arrplandtime += results[i];
                            break;
                        case 6:
                            depairportnm += results[i];
                            break;
                        case 7:
                            depplandtime += results[i];
                            break;
                        case 8:
                            economycharge += results[i];
                            break;
                        case 9:
                            prestigecharge += results[i];
                            break;
                        case 10:
                            vihicleid += results[i];
                            break;
                    }
                    text += results[i];
                }
                else if (results[i] == '<')
                {
                    switch (sw)
                    {
                        case 10:
                            if (str.Length > 0 && airlinenm.Length > 0)
                            {
                                //Citycode css = new Citycode(c_code, c_name);
                                //css.print();
                                //cities.Add(new Citycode(c_code, c_name));
                                airplanelist.Add(new AirplaneList(airlinenm, arrairportnm,arrplandtime,depairportnm,depplandtime,economycharge,prestigecharge,vihicleid));
                                airlinenm = string.Empty;
                                arrairportnm = string.Empty;
                                arrplandtime = string.Empty;
                                depairportnm = string.Empty;
                                depplandtime = string.Empty;
                                economycharge = string.Empty;
                                prestigecharge = string.Empty;
                                vihicleid = string.Empty;
                            }
                            break;
                    }
                    sw = 0;
                    str = string.Empty;
                    text = string.Empty;
                }
                if (sw == 0 && results[i] == '<' && results[i + 1] != '/')
                {
                    sw = 1;
                }
            }
            foreach (var c in airplanelist)
            {
                c.print();
                //Console.WriteLine("{0}: {1}", c.Name, c.Code);
            }
        }
        public static string ExpressBus_GetTerminalID()
        { // 고속버스 터미널 코드를 얻는 함수
            List<ExpressBus_Terminalcode> expressbus = new List<ExpressBus_Terminalcode>(); // 지역코드 저장
                                                                                            //Queue<Citycode> cities = new Queue<Citycode>();
                                                                                            //Citycode city = new Citycode

            string city = string.Empty;
            city = Console.ReadLine();
            string url = "http://openapi.tago.go.kr/openapi/service/ExpBusInfoService/getExpBusTrminlList"; // URL
            url += "?ServiceKey=" + "MYFMxLc4kHFtLGMFgXDn3EnezpmlYYDTjebarh6bvwc4x1B2ePwhjl52FeUi9FAYNOzVmnQn%2BhmZTGTleodsfQ%3D%3D"; // Service Key
            url += "&numOfRows=10";
            url += "&pageNo=1";
            url += "&terminalNm=";
            url += city;

            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            string results = string.Empty;
            HttpWebResponse response;
            using (response = request.GetResponse() as HttpWebResponse)
            {
                StreamReader reader = new StreamReader(response.GetResponseStream());
                results = reader.ReadToEnd();
            }
            string Real_results = string.Empty;

            int sw = 0;
            string str = string.Empty;
            string text = string.Empty;
            string terminalId = string.Empty;
            string terminalNm = string.Empty;
            for (int i = 0; i < results.Length; i++)
            {
                if (sw == 1 && results[i] != '<' && results[i] != '>')
                {
                    str += results[i];
                }
                else if (results[i] == '>')
                {
                    switch (str)
                    {
                        case "resultMsg":
                            sw = 2;
                            break;
                        case "terminalId":
                            sw = 3;
                            break;
                        case "terminalNm":
                            sw = 4;
                            break;
                        default:
                            sw = 0;
                            break;
                    }
                }

                if (results[i] != '<' && results[i] != '>')
                {
                    switch (sw)
                    {
                        case 2:
                            text += results[i];
                            break;
                        case 3:
                            terminalId += results[i];
                            break;
                        case 4:
                            terminalNm += results[i];
                            break;
                    }
                    text += results[i];
                }
                else if (results[i] == '<')
                {
                    switch (sw)
                    {
                        case 4:
                            if (str.Length > 0 && terminalNm.Length > 0)
                            {
                                expressbus.Add(new ExpressBus_Terminalcode(terminalId, terminalNm));
                                terminalId = string.Empty;
                                terminalNm = string.Empty;
                            }
                            break;
                    }
                    sw = 0;
                    str = string.Empty;
                    text = string.Empty;
                }
                if (sw == 0 && results[i] == '<' && results[i + 1] != '/')
                {
                    sw = 1;
                }
            }

            int sww = 0;
            while (true) // 코드 받아서 역 리스트 받는 부분으로 넘김
            {
                foreach (var c in expressbus)
                {
                    Console.WriteLine("{0}: {1}", c.terminalNm, c.terminalId);
                }
                Console.WriteLine();
                string input_code = string.Empty; // 입력받은 코드를 저장할 문자열 변수
                input_code = Console.ReadLine(); // 입력
                sww = 0;
                foreach (var c in expressbus)
                {
                    if (c.terminalId == input_code) // 지역코드 중에 맞는 코드가 있는지 확인
                    {
                        sww = 1;
                        return input_code;
                        break;
                    }
                }
                if (sww == 0)
                {
                    Console.WriteLine("지역 이름을 다시 입력해 주세요!\n"); // 일치하는 코드가 없을 시 메시지
                    Console.WriteLine("{0}", expressbus.Count);
                }
            }
            return null;
        }
        public static string ExpressBus_GetExpressBusGrade() // 버스의 등급을 얻는 함수
        {
            List<ExPressBus_BusGrade> exbuskinds = new List<ExPressBus_BusGrade>();

            string url = "http://openapi.tago.go.kr/openapi/service/ExpBusInfoService/getExpBusGradList"; // URL
            url += "?ServiceKey=" + "MYFMxLc4kHFtLGMFgXDn3EnezpmlYYDTjebarh6bvwc4x1B2ePwhjl52FeUi9FAYNOzVmnQn%2BhmZTGTleodsfQ%3D%3D"; // Service Key

            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            string results = string.Empty;
            HttpWebResponse response;
            using (response = request.GetResponse() as HttpWebResponse)
            {
                StreamReader reader = new StreamReader(response.GetResponseStream());
                results = reader.ReadToEnd();
            }

            string Real_results = string.Empty;
            int sw = 0;
            string str = string.Empty;
            string text = string.Empty;
            string gradeId = string.Empty;
            string gradeNm = string.Empty;

            for (int i = 0; i < results.Length; i++)
            {
                if (sw == 1 && results[i] != '<' && results[i] != '>')
                {
                    str += results[i];
                }
                else if (results[i] == '>')
                {
                    switch (str)
                    {
                        case "resultMsg":
                            sw = 2;
                            break;
                        case "gradeId":
                            sw = 3;
                            break;
                        case "gradeNm":
                            sw = 4;
                            break;
                        default:
                            sw = 0;
                            break;
                    }
                }

                if (results[i] != '<' && results[i] != '>')
                {
                    switch (sw)
                    {
                        case 2:
                            text += results[i];
                            break;
                        case 3:
                            gradeId += results[i];
                            break;
                        case 4:
                            gradeNm += results[i];
                            break;
                    }
                    text += results[i];
                }
                else if (results[i] == '<')
                {
                    switch (sw)
                    {
                        case 4:
                            if (str.Length > 0 && gradeNm.Length > 0)
                            {
                                exbuskinds.Add(new ExPressBus_BusGrade(gradeId, gradeNm));
                                gradeId = string.Empty;
                                gradeNm = string.Empty;
                            }
                            break;
                    }
                    sw = 0;
                    str = string.Empty;
                    text = string.Empty;
                }
                if (sw == 0 && results[i] == '<' && results[i + 1] != '/')
                {
                    sw = 1;
                }
            }

            int sww = 0;
            while (true) // 코드 받아서 버스 등급 리스트 받는 부분으로 넘김
            {
                foreach (var c in exbuskinds)
                {
                    Console.WriteLine("{0}: {1}", c.GradeId, c.GradeNm);
                }
                Console.WriteLine();
                string input_code = string.Empty; // 입력받은 코드를 저장할 문자열 변수
                Console.Write("Give me a Bus Grade Code: "); // 코드를 입력하세요!
                input_code = Console.ReadLine(); // 입력
                sww = 0;
                foreach (var c in exbuskinds)
                {
                    if (c.GradeId == input_code) // 고속버스 등급 코드 중에 맞는 코드가 있는지 확인
                    {
                        sww = 1;
                        return input_code;
                        break;
                    }
                }
                if (sww == 0)
                {
                    Console.WriteLine("고속버스 등급 코드를 다시 입력해 주세요!\n"); // 일치하는 코드가 없을 시 메시지
                    Console.WriteLine("{0}", exbuskinds.Count);
                }
            }
            return null;
        }
        public static void ExpressBus_GetStartToEnd(string start, string end, string deptime, string exbus) // 인자를 통해 버스의 노선을 검색하는 함수
        {
            Console.WriteLine("출발지  :{0}", start);
            Console.WriteLine("도착지  :{0}", end);
            Console.WriteLine("출발시각:{0}", deptime);
            Console.WriteLine("등급    :{0}", exbus);

            List<ExpressBusList> exbuslist = new List<ExpressBusList>();
            string url = "http://openapi.tago.go.kr/openapi/service/ExpBusInfoService/getStrtpntAlocFndExpbusInfo"; // URL
            url += "?ServiceKey=" + "MYFMxLc4kHFtLGMFgXDn3EnezpmlYYDTjebarh6bvwc4x1B2ePwhjl52FeUi9FAYNOzVmnQn%2BhmZTGTleodsfQ%3D%3D"; // Service Key
            url += "&numOfRows=100";
            url += "&pageNo=1";
            url += "&depTerminalId=";
            url += start;
            url += "&arrTerminalId=";
            url += end;
            url += "&depPlandTime=";
            url += deptime;
            url += "&busGradeId=";
            url += exbus;

            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            string results = string.Empty;
            HttpWebResponse response;
            using (response = request.GetResponse() as HttpWebResponse)
            {
                StreamReader reader = new StreamReader(response.GetResponseStream());
                results = reader.ReadToEnd();
            }
            Console.WriteLine(results);

            int sw = 0;
            string str = string.Empty;
            string text = string.Empty;

            string routeid = string.Empty;
            string gradeNm = string.Empty;
            string depPlandTime = string.Empty;
            string arrPlandTime = string.Empty;
            string depPlaceNm = string.Empty;
            string arrplaceNm = string.Empty;
            string charge = string.Empty;

            for (int i = 0; i < results.Length; i++)
            {
                if (sw == 1 && results[i] != '<' && results[i] != '>')
                {
                    str += results[i];
                }
                else if (results[i] == '>')
                {
                    switch (str)
                    {
                        case "resultMsg":
                            sw = 2;
                            break;
                        case "arrPlaceNm":
                            sw = 3;
                            break;
                        case "arrPlandTime":
                            sw = 4;
                            break;
                        case "charge":
                            sw = 5;
                            break;
                        case "depPlaceNm":
                            sw = 6;
                            break;
                        case "depPlandTime": // 출발역
                            sw = 7;
                            break;
                        case "gradeNm": // 등급
                            sw = 8;
                            break;
                        case "routeId": // 비용
                            sw = 9;
                            break;
                        default:
                            sw = 0;
                            break;
                    }
                }

                if (results[i] != '<' && results[i] != '>')
                {
                    switch (sw)
                    {
                        case 2:
                            text += results[i];
                            break;
                        case 3:
                            arrplaceNm += results[i];
                            break;
                        case 4:
                            arrPlandTime += results[i];
                            break;
                        case 5:
                            charge += results[i];
                            break;
                        case 6:
                            depPlaceNm += results[i];
                            break;
                        case 7:
                            depPlandTime += results[i];
                            break;
                        case 8:
                            gradeNm += results[i];
                            break;
                        case 9:
                            routeid += results[i];
                            break;
                    }
                    text += results[i];
                }
                else if (results[i] == '<')
                {
                    switch (sw)
                    {
                        case 9:
                            if (str.Length > 0 && charge.Length > 0)
                            {
                                exbuslist.Add(new ExpressBusList(routeid, gradeNm, depPlandTime, arrPlandTime, depPlaceNm, arrplaceNm, charge));
                                routeid = string.Empty;
                                gradeNm = string.Empty;
                                depPlandTime = string.Empty;
                                arrPlandTime = string.Empty;
                                depPlaceNm = string.Empty;
                                arrplaceNm = string.Empty;
                                charge = string.Empty;
                            }
                            break;
                    }
                    sw = 0;
                    str = string.Empty;
                    text = string.Empty;
                }
                if (sw == 0 && results[i] == '<' && results[i + 1] != '/')
                {
                    sw = 1;
                }
            }
            foreach (var c in exbuslist)
            {
                c.print();
            }
        }
        public static void GB_GlobalPath()
        {
            Console.WriteLine("경로추천 테스트");
            // 출발지를 입력받는다.
            // 도착지를 입력받는다.
            // 출발날짜를 입력받는다.

            // result
            // 기차, 비행기, 고속버스의 직통 경로를 얻는다.

            // additional
            // 직통, 환승여부

        }
    }

}
