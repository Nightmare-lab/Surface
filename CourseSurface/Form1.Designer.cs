namespace CourseSurface
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.XStartTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.XEndTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.YStartTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.YEndTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.chartThreads = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Result = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.chartThreads)).BeginInit();
            this.SuspendLayout();
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Enabled = false;
            this.materialSingleLineTextField1.Hint = "";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(12, 91);
            this.materialSingleLineTextField1.MaxLength = 32767;
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(291, 23);
            this.materialSingleLineTextField1.TabIndex = 0;
            this.materialSingleLineTextField1.TabStop = false;
            this.materialSingleLineTextField1.Text = "2*x*x+2*y*y+3*E^(-x)+3*E^(y)";
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            this.materialSingleLineTextField1.Click += new System.EventHandler(this.materialSingleLineTextField1_Click);
            // 
            // XStartTextBox
            // 
            this.XStartTextBox.Depth = 0;
            this.XStartTextBox.Hint = "";
            this.XStartTextBox.Location = new System.Drawing.Point(12, 157);
            this.XStartTextBox.MaxLength = 32767;
            this.XStartTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.XStartTextBox.Name = "XStartTextBox";
            this.XStartTextBox.PasswordChar = '\0';
            this.XStartTextBox.SelectedText = "";
            this.XStartTextBox.SelectionLength = 0;
            this.XStartTextBox.SelectionStart = 0;
            this.XStartTextBox.Size = new System.Drawing.Size(142, 23);
            this.XStartTextBox.TabIndex = 1;
            this.XStartTextBox.TabStop = false;
            this.XStartTextBox.Text = "-10";
            this.XStartTextBox.UseSystemPasswordChar = false;
            // 
            // XEndTextBox
            // 
            this.XEndTextBox.Depth = 0;
            this.XEndTextBox.Hint = "";
            this.XEndTextBox.Location = new System.Drawing.Point(245, 157);
            this.XEndTextBox.MaxLength = 32767;
            this.XEndTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.XEndTextBox.Name = "XEndTextBox";
            this.XEndTextBox.PasswordChar = '\0';
            this.XEndTextBox.SelectedText = "";
            this.XEndTextBox.SelectionLength = 0;
            this.XEndTextBox.SelectionStart = 0;
            this.XEndTextBox.Size = new System.Drawing.Size(142, 23);
            this.XEndTextBox.TabIndex = 2;
            this.XEndTextBox.TabStop = false;
            this.XEndTextBox.Text = "10";
            this.XEndTextBox.UseSystemPasswordChar = false;
            this.XEndTextBox.Click += new System.EventHandler(this.materialSingleLineTextField3_Click);
            // 
            // YStartTextBox
            // 
            this.YStartTextBox.Depth = 0;
            this.YStartTextBox.Hint = "";
            this.YStartTextBox.Location = new System.Drawing.Point(12, 237);
            this.YStartTextBox.MaxLength = 32767;
            this.YStartTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.YStartTextBox.Name = "YStartTextBox";
            this.YStartTextBox.PasswordChar = '\0';
            this.YStartTextBox.SelectedText = "";
            this.YStartTextBox.SelectionLength = 0;
            this.YStartTextBox.SelectionStart = 0;
            this.YStartTextBox.Size = new System.Drawing.Size(142, 23);
            this.YStartTextBox.TabIndex = 3;
            this.YStartTextBox.TabStop = false;
            this.YStartTextBox.Text = "-20";
            this.YStartTextBox.UseSystemPasswordChar = false;
            // 
            // YEndTextBox
            // 
            this.YEndTextBox.Depth = 0;
            this.YEndTextBox.Hint = "";
            this.YEndTextBox.Location = new System.Drawing.Point(245, 237);
            this.YEndTextBox.MaxLength = 32767;
            this.YEndTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.YEndTextBox.Name = "YEndTextBox";
            this.YEndTextBox.PasswordChar = '\0';
            this.YEndTextBox.SelectedText = "";
            this.YEndTextBox.SelectionLength = 0;
            this.YEndTextBox.SelectionStart = 0;
            this.YEndTextBox.Size = new System.Drawing.Size(142, 23);
            this.YEndTextBox.TabIndex = 4;
            this.YEndTextBox.TabStop = false;
            this.YEndTextBox.Text = "20";
            this.YEndTextBox.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(8, 126);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(54, 19);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "X Start";
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(241, 126);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(47, 19);
            this.materialLabel2.TabIndex = 6;
            this.materialLabel2.Text = "X End";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(8, 210);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(54, 19);
            this.materialLabel3.TabIndex = 7;
            this.materialLabel3.Text = "Y Start";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(241, 210);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(47, 19);
            this.materialLabel4.TabIndex = 8;
            this.materialLabel4.Text = "Y End";
            // 
            // chartThreads
            // 
            this.chartThreads.BackColor = System.Drawing.Color.DimGray;
            chartArea4.Name = "ChartArea1";
            this.chartThreads.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartThreads.Legends.Add(legend4);
            this.chartThreads.Location = new System.Drawing.Point(393, 91);
            this.chartThreads.Name = "chartThreads";
            this.chartThreads.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartThreads.Series.Add(series4);
            this.chartThreads.Size = new System.Drawing.Size(589, 413);
            this.chartThreads.TabIndex = 10;
            this.chartThreads.Text = "chart1";
            // 
            // Result
            // 
            this.Result.Depth = 0;
            this.Result.Hint = "";
            this.Result.Location = new System.Drawing.Point(13, 287);
            this.Result.MaxLength = 32767;
            this.Result.MouseState = MaterialSkin.MouseState.HOVER;
            this.Result.Name = "Result";
            this.Result.PasswordChar = '\0';
            this.Result.SelectedText = "";
            this.Result.SelectionLength = 0;
            this.Result.SelectionStart = 0;
            this.Result.Size = new System.Drawing.Size(374, 23);
            this.Result.TabIndex = 11;
            this.Result.TabStop = false;
            this.Result.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(12, 265);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(51, 19);
            this.materialLabel5.TabIndex = 12;
            this.materialLabel5.Text = "Result";
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Icon = null;
            this.materialFlatButton1.Location = new System.Drawing.Point(16, 465);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(75, 36);
            this.materialFlatButton1.TabIndex = 13;
            this.materialFlatButton1.Text = "Python";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Icon = null;
            this.materialFlatButton2.Location = new System.Drawing.Point(12, 328);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(97, 36);
            this.materialFlatButton2.TabIndex = 14;
            this.materialFlatButton2.Text = "Calculate";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            this.materialFlatButton2.Click += new System.EventHandler(this.materialFlatButton2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 516);
            this.Controls.Add(this.materialFlatButton2);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.chartThreads);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.YEndTextBox);
            this.Controls.Add(this.YStartTextBox);
            this.Controls.Add(this.XEndTextBox);
            this.Controls.Add(this.XStartTextBox);
            this.Controls.Add(this.materialSingleLineTextField1);
            this.Name = "Form1";
            this.Text = "SurfaceApplication";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartThreads)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private MaterialSkin.Controls.MaterialSingleLineTextField XStartTextBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField XEndTextBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField YStartTextBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField YEndTextBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartThreads;
        private MaterialSkin.Controls.MaterialSingleLineTextField Result;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
    }
}

