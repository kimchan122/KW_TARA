using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Xml;

namespace Project.Forms.Plane {
	public class PlaneAPI : FlightInfo {
		
		private const string URL = "http://openapi.tago.go.kr/openapi/service/DmstcFlightNvgInfoService/";
		private const string numOfRows = "&numOfRows=50";//한 페이지 결과 수
		private const string pageNo = "&pageNo=1";//페이지 번호
		public string depAirportId { get; set; }//출발공항 ID
		public string arrAirportId { get; set; }//도착공항 ID
		public string depPlandTime { get; set; }//출발일
		public string airlineId { get; set; }//항공사 ID

		public Flight[] getFlightInfo() {
			if(string.Equals(depAirportId, "&depAirportId="))	return null; 
			if(string.Equals(arrAirportId, "&arrAirportId="))	return null; 
			if(string.Equals(depPlandTime, "&depPlandTime="))	return null; 
			if(string.Equals(airlineId, "&airlineId="))	return null;
			//RESTful Server에 전송할 Request 제작
			string request = URL + "getFlightOpratInfoList" +
				"?ServiceKey=" + this.getServiceKey() + numOfRows + pageNo +
				"&depAirportId=" + this.depAirportId +
				"&arrAirportId=" + this.arrAirportId +
				"&depPlandTime=" + this.depPlandTime +
				"&airlineId=" + this.airlineId;

			XmlNode xn;

				string responseXml = getResponse(request);
				xn = getXmlNodes(responseXml);


			Flight[] flightList = new Flight[xn.ChildNodes.Count];
			for (int i = 0; i < xn.ChildNodes.Count; i++) {
				Flight f = new Flight();

				//Xml 내용 채우기
				if (xn.ChildNodes[i]["depAirportNm"] != null)
					f.출발공항 = xn.ChildNodes[i]["depAirportNm"].InnerText;
				if (xn.ChildNodes[i]["depPlandTime"] != null)
					f.출발시각 = stringToDate(xn.ChildNodes[i]["depPlandTime"].InnerText);
				if (xn.ChildNodes[i]["arrAirportNm"] != null)
					f.도착공항 = xn.ChildNodes[i]["arrAirportNm"].InnerText;
				if (xn.ChildNodes[i]["arrPlandTime"] != null)
					f.도착시각 = stringToDate(xn.ChildNodes[i]["arrPlandTime"].InnerText);
				if(xn.ChildNodes[i]["airlineNm"] != null)
					f.항공사 = xn.ChildNodes[i]["airlineNm"].InnerText;
				if (xn.ChildNodes[i]["economyCharge"] != null)
					f.요금[0] = xn.ChildNodes[i]["economyCharge"].InnerText;
				else
					f.요금[0] = "    -    ";
				if (xn.ChildNodes[i]["prestigeCharge"] != null)
					f.요금[1] = xn.ChildNodes[i]["prestigeCharge"].InnerText;
				else
					f.요금[1] = "    -    ";
				if (xn.ChildNodes[i]["vihicleId"] != null)
					f.노선코드 = xn.ChildNodes[i]["vihicleId"].InnerText;

				flightList[i] = f;
			}
			return flightList;
		}

		public List<Airport> getAirportList() {
			string request = URL + "getArprtList" + "?ServiceKey=" + this.getServiceKey();

			string responseXml = getResponse(request);
			XmlNode xn = getXmlNodes(responseXml);

			List<Airport> airportList = new List<Airport>();
			for (int i = 0; i < xn.ChildNodes.Count; i++) {
				Airport ap = new Airport();
				ap.공항ID = xn.ChildNodes[i]["airportId"].InnerText;
				ap.공항이름 = xn.ChildNodes[i]["airportNm"].InnerText;
				airportList.Add(ap);
			}
			Airport.AirportComparer ac = new Airport.AirportComparer();
			airportList.Sort(ac);
			return airportList;
		}

		public List<Airline> getAirlineList() {
			string request = URL + "getAirmanList" + "?ServiceKey=" + this.getServiceKey();

			string responseXml = getResponse(request);
			XmlNode xn = getXmlNodes(responseXml);

			List<Airline> airlineList = new List<Airline>();
			for (int i = 0; i < xn.ChildNodes.Count; i++) {
				Airline al = new Airline();
				al.항공사ID = xn.ChildNodes[i]["airlineId"].InnerText;
				al.항공사명 = xn.ChildNodes[i]["airlineNm"].InnerText;
				airlineList.Add(al);
			}
			Airline.AirlineComparer ac = new Airline.AirlineComparer();
			airlineList.Sort(ac);
			return airlineList;
		}

		//request에 대한 Server의 response data를 반환하는 함수
		private string getResponse(string request) {
			try {
				WebRequest wrq = WebRequest.Create(request);  //WebRequest 객체 생성
				wrq.Method = "GET";

				WebResponse wrs = wrq.GetResponse(); //WebResponse 객체 생성
				Stream s = wrs.GetResponseStream();
				StreamReader sr = new StreamReader(s);
				string response = sr.ReadToEnd();
				return response;
			} 
			catch (Exception e) {
				System.Windows.Forms.MessageBox.Show(e.Message);
				return null;
			}
		}
		//response(Xml문서)를 XML Parser를 사용해 필요한 정보만 XmlNode에 담아 반환하는 함수
		private XmlNode getXmlNodes(string response) {
			XmlDocument xd = new XmlDocument(); //API로부터 날아온 XML 형식 데이터
			XmlNode xn; //XML의 <items>태그 안의 내용(실제 필요한 데이터)
			xd.LoadXml(response); //XML document 로드
			xn = xd["response"]["body"]["items"]; //XML문서 내의 items 노드 저장 
			return xn;
		}

		//API로 넘어온 시간정보문자열(ex.202012011430)을 DateTime객체로 변환하여 반환하는 함수
		private DateTime stringToDate(string time) {
			int Y, M, D, h, m;  //년,월,일,시,분
			Y = int.Parse(time.Substring(0, 4));
			M = int.Parse(time.Substring(4, 2));
			D = int.Parse(time.Substring(6, 2));
			h = int.Parse(time.Substring(8, 2));
			m = int.Parse(time.Substring(10));
			DateTime dt = new DateTime(Y, M, D, h, m, 0);
			return dt;
		}

		//로컬 파일에서 공공API 서비스키를 받아오는 함수(bin 파일은 업로드하지 않음)
		private string getServiceKey() {
			//로컬파일 열기
			FileStream fs = new FileStream(Environment.CurrentDirectory + "\\ServiceKey.bin", FileMode.Open, FileAccess.Read);
			BinaryReader br = new BinaryReader(fs);

			//key값을 읽고 저장
			StreamReader sr = new StreamReader(fs);
			string key = sr.ReadLine();
			br.Close();
			fs.Close();
			return key;
		}

		//request문 Error Handler(미구현)
		private bool isRequestOK() {
			return true;
		}
	}
}
