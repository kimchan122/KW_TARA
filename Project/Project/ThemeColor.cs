using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project {
	public static class ThemeColor {
		
		public static Color PrimaryColor { get; set; }		//1차 색상
		public static Color SecondaryColor { get; set; }	//2차 색상(1차 색상에서 밝기 보정됨) - ChangeColorBrightness() 사용
		//
		//색상 리스트(HTML color)
		//	pnlMenu에 있는 버튼 클릭 시 여기 있는 색들 중 랜덤으로 색이 설정된다.
		public static List<string> ColorList = new List<string>() { "#3F51B5",
																																"#009688",
																																"#FF5722",
																																"#FF9800",
																																"#9C27B0",
																																"#2196F3",
																																"#EA676C",
																																"#E41A4A",
																																"#018790",
																																"#00B0AD",
																																"#721D47",
																																"#EA4833",
																																"#A12059",
																																"#0094BC",
																																"#E4126B",
																																"#43B76E",
																																"#B71C46"};

		//	
		//	색상의 밝기를 바꾸는 함수
		//		color = 입력 색상
		//		correctionFactor = 밝기 조절 강도(double)
		//
		public static Color ChangeColorBrightness(Color color, double correctionFactor) {
			//RGB값
			double red = color.R;
			double green = color.G;
			double blue = color.B;

			//If correction factor is less than 0, darken color.
			if (correctionFactor < 0) {
				correctionFactor = 1 + correctionFactor;
				red *= correctionFactor;
				green *= correctionFactor;
				blue *= correctionFactor;

			}
			else {  //if correction factor is greater than zero, lighten color.
				red = (255 - red) * correctionFactor + red;
				green = (255 - green) * correctionFactor + green;
				blue = (255 - blue) * correctionFactor + blue;
			}

			return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
		}
	}
}
