using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Forms {
	public partial class FormTrain : Form {
		public FormTrain() {
			InitializeComponent();
		}

		private void FormTrain_Load(object sender, EventArgs e) {
			LoadTheme();//테마 적용함수 로드
		}

		//부모 Form의 색상테마를 적용하는 함수	
		private void LoadTheme() {
			foreach (Control ctrls in this.Controls) {		//콘트롤 객체 탐색
				if (ctrls.GetType() == typeof(Button)) {		//버튼일 경우
					Button btn = (Button)ctrls;
					btn.BackColor = ThemeColor.PrimaryColor;
					btn.ForeColor = Color.Gainsboro;
					btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
				}
				else if(ctrls.GetType() == typeof(Label)) {	//라벨일 경우
					Label lbl = (Label)ctrls;
					lbl.ForeColor = ThemeColor.SecondaryColor;
				}
				/*
				 * 다른 컨트롤 객체들도 테마 적용하시려면 여기에 조건문을 추가하시면 됩니다.
				 *	ctrls.GetType()이 typeof(아이템 이름(ex.Panel, Textbox,...))과 일치하면
				 *	해당 아이템 객체 선언하시고
				 *	PrimaryColor나 SecondaryColor로 컬러 속성 변경하는 식입니다.
				 */
			}
		}
	}
}
