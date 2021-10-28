using DE_F21.NumericalMethods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace DE_F21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea13 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend13 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series41 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series42 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series43 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series44 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea14 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend14 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series45 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series46 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series47 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea15 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend15 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series48 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series49 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series50 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_n0 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_x0 = new System.Windows.Forms.TextBox();
            this.label_x0 = new System.Windows.Forms.Label();
            this.button_plot = new System.Windows.Forms.Button();
            this.textBox_y0 = new System.Windows.Forms.TextBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.textBox_X = new System.Windows.Forms.TextBox();
            this.label_X = new System.Windows.Forms.Label();
            this.textBox_N = new System.Windows.Forms.TextBox();
            this.label_N = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chart_methods = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chart_lte = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.chart_gte = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_methods)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_lte)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_gte)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.textBox_n0);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox_x0);
            this.panel1.Controls.Add(this.label_x0);
            this.panel1.Controls.Add(this.button_plot);
            this.panel1.Controls.Add(this.textBox_y0);
            this.panel1.Controls.Add(this.checkBox3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.textBox_X);
            this.panel1.Controls.Add(this.label_X);
            this.panel1.Controls.Add(this.textBox_N);
            this.panel1.Controls.Add(this.label_N);
            this.panel1.Location = new System.Drawing.Point(784, 38);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 479);
            this.panel1.TabIndex = 18;
            // 
            // textBox_n0
            // 
            this.textBox_n0.Location = new System.Drawing.Point(60, 199);
            this.textBox_n0.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_n0.Name = "textBox_n0";
            this.textBox_n0.Size = new System.Drawing.Size(132, 22);
            this.textBox_n0.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 194);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 31);
            this.label2.TabIndex = 17;
            this.label2.Text = "n₀";
            // 
            // textBox_x0
            // 
            this.textBox_x0.Location = new System.Drawing.Point(60, 36);
            this.textBox_x0.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_x0.Name = "textBox_x0";
            this.textBox_x0.Size = new System.Drawing.Size(132, 22);
            this.textBox_x0.TabIndex = 12;
            // 
            // label_x0
            // 
            this.label_x0.AutoSize = true;
            this.label_x0.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_x0.Location = new System.Drawing.Point(25, 32);
            this.label_x0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_x0.Name = "label_x0";
            this.label_x0.Size = new System.Drawing.Size(35, 31);
            this.label_x0.TabIndex = 9;
            this.label_x0.Text = "x₀";
            // 
            // button_plot
            // 
            this.button_plot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_plot.Location = new System.Drawing.Point(60, 416);
            this.button_plot.Margin = new System.Windows.Forms.Padding(4);
            this.button_plot.Name = "button_plot";
            this.button_plot.Size = new System.Drawing.Size(133, 42);
            this.button_plot.TabIndex = 5;
            this.button_plot.Text = "Plot";
            this.button_plot.UseVisualStyleBackColor = true;
            this.button_plot.Click += new System.EventHandler(this.button_plot_Click);
            // 
            // textBox_y0
            // 
            this.textBox_y0.Location = new System.Drawing.Point(60, 87);
            this.textBox_y0.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_y0.Name = "textBox_y0";
            this.textBox_y0.Size = new System.Drawing.Size(132, 22);
            this.textBox_y0.TabIndex = 16;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Location = new System.Drawing.Point(47, 375);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(109, 21);
            this.checkBox3.TabIndex = 8;
            this.checkBox3.Text = "Runge Kutta";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 31);
            this.label1.TabIndex = 15;
            this.label1.Text = "y₀";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(47, 319);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(63, 21);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Euler";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(47, 347);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(125, 21);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "Improved Euler";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // textBox_X
            // 
            this.textBox_X.Location = new System.Drawing.Point(60, 144);
            this.textBox_X.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_X.Name = "textBox_X";
            this.textBox_X.Size = new System.Drawing.Size(132, 22);
            this.textBox_X.TabIndex = 13;
            // 
            // label_X
            // 
            this.label_X.AutoSize = true;
            this.label_X.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_X.Location = new System.Drawing.Point(25, 145);
            this.label_X.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_X.Name = "label_X";
            this.label_X.Size = new System.Drawing.Size(24, 22);
            this.label_X.TabIndex = 10;
            this.label_X.Text = "X";
            // 
            // textBox_N
            // 
            this.textBox_N.Location = new System.Drawing.Point(60, 256);
            this.textBox_N.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_N.Name = "textBox_N";
            this.textBox_N.Size = new System.Drawing.Size(132, 22);
            this.textBox_N.TabIndex = 14;
            // 
            // label_N
            // 
            this.label_N.AutoSize = true;
            this.label_N.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_N.Location = new System.Drawing.Point(25, 255);
            this.label_N.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_N.Name = "label_N";
            this.label_N.Size = new System.Drawing.Size(24, 22);
            this.label_N.TabIndex = 11;
            this.label_N.Text = "N";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(763, 511);
            this.tabControl1.TabIndex = 19;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chart_methods);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(755, 482);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Methods";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chart_methods
            // 
            chartArea13.Name = "ChartArea1";
            this.chart_methods.ChartAreas.Add(chartArea13);
            legend13.Name = "Legend1";
            this.chart_methods.Legends.Add(legend13);
            this.chart_methods.Location = new System.Drawing.Point(3, 7);
            this.chart_methods.Margin = new System.Windows.Forms.Padding(4);
            this.chart_methods.Name = "chart_methods";
            series41.BorderWidth = 2;
            series41.ChartArea = "ChartArea1";
            series41.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series41.Legend = "Legend1";
            series41.LegendText = "Euler";
            series41.Name = "Series1";
            series42.BorderWidth = 2;
            series42.ChartArea = "ChartArea1";
            series42.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series42.Legend = "Legend1";
            series42.LegendText = "Improved Euler";
            series42.Name = "Series2";
            series43.BorderWidth = 2;
            series43.ChartArea = "ChartArea1";
            series43.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series43.Legend = "Legend1";
            series43.LegendText = "Runge Kutta";
            series43.Name = "Series3";
            series44.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            series44.BorderWidth = 2;
            series44.ChartArea = "ChartArea1";
            series44.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series44.Color = System.Drawing.Color.Lime;
            series44.Legend = "Legend1";
            series44.LegendText = "Exact";
            series44.Name = "Series4";
            this.chart_methods.Series.Add(series41);
            this.chart_methods.Series.Add(series42);
            this.chart_methods.Series.Add(series43);
            this.chart_methods.Series.Add(series44);
            this.chart_methods.Size = new System.Drawing.Size(743, 464);
            this.chart_methods.TabIndex = 0;
            this.chart_methods.Text = "chart1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chart_lte);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(755, 482);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Local Errors";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chart_lte
            // 
            chartArea14.Name = "ChartArea1";
            this.chart_lte.ChartAreas.Add(chartArea14);
            legend14.Name = "Legend1";
            this.chart_lte.Legends.Add(legend14);
            this.chart_lte.Location = new System.Drawing.Point(8, 7);
            this.chart_lte.Margin = new System.Windows.Forms.Padding(4);
            this.chart_lte.Name = "chart_lte";
            series45.BorderWidth = 2;
            series45.ChartArea = "ChartArea1";
            series45.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series45.Legend = "Legend1";
            series45.LegendText = "Euler";
            series45.Name = "Series1";
            series46.BorderWidth = 2;
            series46.ChartArea = "ChartArea1";
            series46.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series46.Legend = "Legend1";
            series46.LegendText = "Improved Euler";
            series46.Name = "Series2";
            series47.BorderWidth = 2;
            series47.ChartArea = "ChartArea1";
            series47.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series47.Legend = "Legend1";
            series47.LegendText = "Runge Kutta";
            series47.Name = "Series3";
            this.chart_lte.Series.Add(series45);
            this.chart_lte.Series.Add(series46);
            this.chart_lte.Series.Add(series47);
            this.chart_lte.Size = new System.Drawing.Size(736, 468);
            this.chart_lte.TabIndex = 24;
            this.chart_lte.Text = "chart_lte";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.chart_gte);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(755, 482);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Global Errors";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // chart_gte
            // 
            chartArea15.Name = "ChartArea1";
            this.chart_gte.ChartAreas.Add(chartArea15);
            legend15.Name = "Legend1";
            this.chart_gte.Legends.Add(legend15);
            this.chart_gte.Location = new System.Drawing.Point(4, 4);
            this.chart_gte.Margin = new System.Windows.Forms.Padding(4);
            this.chart_gte.Name = "chart_gte";
            series48.BorderWidth = 2;
            series48.ChartArea = "ChartArea1";
            series48.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series48.Legend = "Legend1";
            series48.LegendText = "Euler";
            series48.Name = "Series1";
            series49.BorderWidth = 2;
            series49.ChartArea = "ChartArea1";
            series49.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series49.Legend = "Legend1";
            series49.LegendText = "Improved Euler";
            series49.Name = "Series2";
            series50.BorderWidth = 2;
            series50.ChartArea = "ChartArea1";
            series50.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series50.Legend = "Legend1";
            series50.LegendText = "Runge Kutta";
            series50.Name = "Series3";
            this.chart_gte.Series.Add(series48);
            this.chart_gte.Series.Add(series49);
            this.chart_gte.Series.Add(series50);
            this.chart_gte.Size = new System.Drawing.Size(740, 468);
            this.chart_gte.TabIndex = 25;
            this.chart_gte.Text = "chart_gte";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1131, 593);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_methods)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_lte)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_gte)).EndInit();
            this.ResumeLayout(false);

        }

        private void button_plot_Click(object sender, EventArgs e)
        {
            MaximizeBox = false;

            // Initial textboxes data.
            textBox_x0.Text = "1";
            textBox_y0.Text = "2";
            textBox_X.Text = "10";
            textBox_n0.Text = "3";
            textBox_N.Text = "10";
            Plot_click(sender, e);
        }

        // Plot button clicked
        private void Plot_click(object sender, EventArgs e)
        {
            double x0 = 0, y0 = 0, X = 0;
            int n0 = 0, N = 0;
            try
            {
                x0 = double.Parse(textBox_x0.Text);
                y0 = double.Parse(textBox_y0.Text);
                X = double.Parse(textBox_X.Text);
                n0 = int.Parse(textBox_n0.Text);
                N = int.Parse(textBox_N.Text);
                if (n0 <= 0 || N <= 0 || n0 >= N || x0 >= X) throw new Exception();
            }
            catch
            {
                MessageBox.Show("Invalid input\n");
                Application.Exit();
            }


            int[] cnt = new int[N - n0 + 1];
            double[] EE = new double[N - n0 + 1], IEE = new double[N - n0 + 1], RKE = new double[N - n0 + 1];
            for (int i = n0; i <= N; i++)
            {
                cnt[i - n0] = i;
                EulerMethod tmp1 = new EulerMethod(i, x0, y0, X);
                ImprovedEulerMethod tmp2 = new ImprovedEulerMethod(i, x0, y0, X);
                RungeKutta tmp3 = new RungeKutta(i, x0, y0, X);

                EE[i - n0] = tmp1.Calculate();
                IEE[i - n0] = tmp2.Calculate();
                RKE[i - n0] = tmp3.Calculate();
            }


            NumericalMethod exact = new NumericalMethod(N, x0, y0, X);
            exact.Calculate();
            chart_methods.Series[3].Points.DataBindXY(exact.x, exact.y);

            if (checkBox1.Checked)
            {
                EulerMethod m1 = new EulerMethod(N, x0, y0, X);
                m1.Calculate();
                chart_methods.Series[0].Points.DataBindXY(m1.x, m1.y);
                chart_lte.Series[0].Points.DataBindXY(m1.x, m1.error);
                chart_gte.Series[0].Points.DataBindXY(cnt, EE);
            }
            if (checkBox2.Checked)
            {
                ImprovedEulerMethod m2 = new ImprovedEulerMethod(N, x0, y0, X);
                m2.Calculate();
                chart_methods.Series[1].Points.DataBindXY(m2.x, m2.y);
                chart_lte.Series[1].Points.DataBindXY(m2.x, m2.e);
                chart_gte.Series[1].Points.DataBindXY(cnt, IEE);
            }
            if (checkBox3.Checked)
            {
                RungeKutta m3 = new RungeKutta(N, x0, y0, X);
                m3.Calculate();
                chart_methods.Series[2].Points.DataBindXY(m3.x, m3.y);
                chart_lte.Series[2].Points.DataBindXY(m3.x, m3.e);
                chart_gte.Series[2].Points.DataBindXY(cnt, RKE);
            }

            chart_methods.ChartAreas[0].AxisX.Minimum = x0;
            chart_methods.ChartAreas[0].AxisX.Maximum = X;
            chart_lte.ChartAreas[0].AxisX.Minimum = x0;
            chart_lte.ChartAreas[0].AxisX.Maximum = X;
            chart_gte.ChartAreas[0].AxisX.Minimum = n0;
            chart_gte.ChartAreas[0].AxisX.Maximum = N;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            chart_methods.Series[0].Enabled = checkBox1.Checked;
            chart_lte.Series[0].Enabled = checkBox1.Checked;
            chart_gte.Series[0].Enabled = checkBox1.Checked;
            Plot_click(sender, e);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            chart_methods.Series[1].Enabled = checkBox2.Checked;
            chart_lte.Series[1].Enabled = checkBox2.Checked;
            chart_gte.Series[1].Enabled = checkBox2.Checked;
            Plot_click(sender, e);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            chart_methods.Series[2].Enabled = checkBox3.Checked;
            chart_lte.Series[2].Enabled = checkBox3.Checked;
            chart_gte.Series[2].Enabled = checkBox3.Checked;
            Plot_click(sender, e);
        }
    }
}
