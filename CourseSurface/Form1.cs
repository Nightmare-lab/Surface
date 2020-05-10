using System;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
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

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            var python = new Process {StartInfo = {FileName = @"C:\Users\Beallador\Documents\Surface\PythonSurface\dist\PythonSurface.exe" } };
            python.Start();
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            var rectangleMethod = new RightRectangleMethod();
            var integral = new Integral()
            {
                XEnd = int.Parse(XEndTextBox.Text),
                XStart = int.Parse(XStartTextBox.Text),
                YEnd = int.Parse(YEndTextBox.Text),
                YStart = int.Parse(YStartTextBox.Text)
            };
            var result = rectangleMethod.CalculateSurface(integral);

            var writer = new ExcelWriter();

            writer.WriteThreadsDataToExcel(result);

            Result.Text = result.Last().Result.ToString(CultureInfo.InvariantCulture);

            chartThreads.Series[0].Points.DataBind(result, "NumberOfThreads", "Time", "");
        }
    }
}
