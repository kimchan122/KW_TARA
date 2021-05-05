using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//고속버스
//성인: 100%
//소아(6세~초등학교 재학생): 50%
//유아: 0%(좌석배정X, 영유아 수가 나머지 인원수보다 많을 경우, 해당 유아는 소아 요금을 지불하여 별도의 좌석 배정.)

//비행기(국내선, 국제선)(저가항공사 제외)
//성인: 100%, 100%
//소아(24개월~만12세 미만): 75%, 75%
//유아(생후7일~24개월 미만, 별도 좌석 제공 안됨, 유아 수가 나머지 인원수보다 많을 경우, 해당 유아는 소아 요금을 지불하여 별도의 좌석 배정.): 무료, 10%

//지하철

//택시

//자가용

//톨게이트(경차~승용차)

namespace Project.Forms {
	public partial class FormRouteSearch : Form {
		public FormRouteSearch() {
			InitializeComponent();
            string url = "https://kimchan122.github.io/nvmaptest1/test.html";
            webBrowser1.Navigate(url);
		}

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            string msg = e.Url + " 로딩 완료!";
            //MessageBox.Show(msg);
        }
    }
}
