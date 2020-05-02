using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseSurface.RightRectangleMethodLogic;
using CourseSurface.RightRectangleMethodLogic.Model;
using MaterialSkin;
using MaterialSkin.Controls;

namespace CourseSurface
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Green900, Primary.Green600,
                Primary.Green900, Accent.Green100,
                TextShade.WHITE
            );
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField3_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RightRectangleMethod rectangleMethod = new RightRectangleMethod();
            Integral integral = new Integral()
                                {
                                    XEnd = int.Parse(XEndTextBox.Text),
                                    XStart = int.Parse(XStartTextBox.Text),
                                    YEnd = int.Parse(YEndTextBox.Text),
                                    YStart = int.Parse(YStartTextBox.Text)
                                };
            var result = rectangleMethod.CalculateSurface(integral);

            Result.Text = result.Last().Result.ToString(CultureInfo.InvariantCulture);

            chartThreads.Series[0].Points.DataBind(result,"NumberOfThreads","Time","");
        }
    }
}
