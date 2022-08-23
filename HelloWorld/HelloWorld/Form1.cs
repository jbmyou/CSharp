using System;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //this.btnClickThis.Click += new System.EventHandler(this.btnClickThis_Click);
            //위 코드를 여기나 Form1.Designer.cs 의 InitializeComponent()로직에 추가해야
            //########################################################
            //Form1.cs[디자인]에서 버튼(포함 모든 도구)을 더블클릭하면 Form1.cs에 알아서 button에 어울리는 메소드가 생기고
            //                                           ##########
            //Form1.Designer.cs에 알아서 EventHandler 인스턴스가 생성된다!
        }
        private void btnClickThis_Click(object sender, EventArgs e)
        {
            label1.Text = "Hello World!";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        //이건 내가 form자체를 더블클릭했기 때문에 생긴 것
        }

    }
}
