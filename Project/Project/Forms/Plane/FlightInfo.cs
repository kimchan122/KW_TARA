using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Forms.Plane {
	public class FlightInfo {
		public enum TicketCharge {
			economyCharge = 0,
			prestigeCharge
		}

		public class Flight {
			public string 출발공항 { get; set; }
			public DateTime 출발시각 { get; set; }
			public string 도착공항 { get; set; }
			public DateTime 도착시각 { get; set; }
			public string[] 요금 = new string[2]; //0 : 일반좌석요금, 1 : 비즈니스좌석요금
			public string 항공사 { get; set; }
			public string 노선코드 { get; set; }
		}

		public class Airport {
			public string 공항ID { get; set; }
			public string 공항이름 { get; set; }

			public class AirportComparer : IComparer<Airport> {
				public int Compare(Airport x, Airport y) {
					return x.공항이름.CompareTo(y.공항이름);
				}
			}
		}

		public class Airline {
			public string 항공사ID { get; set; }
			public string 항공사명 { get; set; }

			public class AirlineComparer : IComparer<Airline> {
				public int Compare(Airline x, Airline y) {
					return x.항공사명.CompareTo(y.항공사명);
				}
			}
		}
	}
}
