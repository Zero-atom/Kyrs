namespace Kyrs
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.построитьГрафикToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьГрафикToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox_b = new System.Windows.Forms.CheckBox();
            this.checkBox_e = new System.Windows.Forms.CheckBox();
            this.checkBox_x2 = new System.Windows.Forms.CheckBox();
            this.checkBox_x = new System.Windows.Forms.CheckBox();
            this.checkBox_x3 = new System.Windows.Forms.CheckBox();
            this.checkBox_yx = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            legend1.Title = "Цвет графиков";
            legend1.TitleSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.Line;
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(6, 21);
            this.chart.Name = "chart";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Color = System.Drawing.Color.Blue;
            series1.Legend = "Legend1";
            series1.LegendText = "Таблично заданная функция";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 2;
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Cyan;
            series2.Legend = "Legend1";
            series2.LegendText = "Линейная функция ";
            series2.Name = "Series2";
            series3.BorderWidth = 5;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = System.Drawing.Color.Red;
            series3.Legend = "Legend1";
            series3.LegendText = "Многочлен второй степени";
            series3.Name = "Series3";
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Color = System.Drawing.Color.Black;
            series4.LabelForeColor = System.Drawing.Color.Bisque;
            series4.Legend = "Legend1";
            series4.LegendText = "Многочлен третьей степени";
            series4.MarkerSize = 100;
            series4.Name = "Series4";
            series5.BorderWidth = 2;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Color = System.Drawing.Color.Lime;
            series5.Legend = "Legend1";
            series5.LegendText = "Показательная функция";
            series5.Name = "Series5";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            series6.Legend = "Legend1";
            series6.LegendText = "Гипербола";
            series6.Name = "Series6";
            this.chart.Series.Add(series1);
            this.chart.Series.Add(series2);
            this.chart.Series.Add(series3);
            this.chart.Series.Add(series4);
            this.chart.Series.Add(series5);
            this.chart.Series.Add(series6);
            this.chart.Size = new System.Drawing.Size(760, 502);
            this.chart.TabIndex = 1;
            this.chart.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.Name = "Title1";
            title1.Text = "График функции";
            this.chart.Titles.Add(title1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.менюToolStripMenuItem, this.выходToolStripMenuItem });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1096, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.построитьГрафикToolStripMenuItem, this.очиститьГрафикToolStripMenuItem });
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // построитьГрафикToolStripMenuItem
            // 
            this.построитьГрафикToolStripMenuItem.Name = "построитьГрафикToolStripMenuItem";
            this.построитьГрафикToolStripMenuItem.Size = new System.Drawing.Size(205, 24);
            this.построитьГрафикToolStripMenuItem.Text = "Построить график";
            this.построитьГрафикToolStripMenuItem.Click += new System.EventHandler(this.построитьГрафикToolStripMenuItem_Click);
            // 
            // очиститьГрафикToolStripMenuItem
            // 
            this.очиститьГрафикToolStripMenuItem.Name = "очиститьГрафикToolStripMenuItem";
            this.очиститьГрафикToolStripMenuItem.Size = new System.Drawing.Size(205, 24);
            this.очиститьГрафикToolStripMenuItem.Text = "Очистить график";
            this.очиститьГрафикToolStripMenuItem.Click += new System.EventHandler(this.очиститьГрафикToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chart);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(766, 523);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "График";
            // 
            // checkBox1
            // 
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location = new System.Drawing.Point(601, 248);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(159, 30);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "все";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(784, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 210);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Параметры";
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox.Location = new System.Drawing.Point(132, 43);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(92, 30);
            this.textBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(17, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вариант:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.checkBox_b);
            this.groupBox3.Controls.Add(this.checkBox_e);
            this.groupBox3.Controls.Add(this.checkBox_x2);
            this.groupBox3.Controls.Add(this.checkBox_x);
            this.groupBox3.Controls.Add(this.checkBox_x3);
            this.groupBox3.Controls.Add(this.checkBox_yx);
            this.groupBox3.Location = new System.Drawing.Point(784, 247);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(300, 307);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Графики";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kyrs.Properties.Resources.png_transparent_check_mark_symbol_symbol_miscellaneous_angle_text;
            this.pictureBox1.Location = new System.Drawing.Point(79, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // checkBox_b
            // 
            this.checkBox_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_b.Location = new System.Drawing.Point(6, 266);
            this.checkBox_b.Name = "checkBox_b";
            this.checkBox_b.Size = new System.Drawing.Size(295, 35);
            this.checkBox_b.TabIndex = 5;
            this.checkBox_b.Text = "g(x)=a₀·a₁/x";
            this.checkBox_b.UseVisualStyleBackColor = true;
            // 
            // checkBox_e
            // 
            this.checkBox_e.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_e.Location = new System.Drawing.Point(6, 225);
            this.checkBox_e.Name = "checkBox_e";
            this.checkBox_e.Size = new System.Drawing.Size(295, 35);
            this.checkBox_e.TabIndex = 4;
            this.checkBox_e.Text = "g(x)=a₀·eᵇᵡ";
            this.checkBox_e.UseVisualStyleBackColor = true;
            // 
            // checkBox_x2
            // 
            this.checkBox_x2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_x2.Location = new System.Drawing.Point(5, 127);
            this.checkBox_x2.Name = "checkBox_x2";
            this.checkBox_x2.Size = new System.Drawing.Size(295, 35);
            this.checkBox_x2.TabIndex = 3;
            this.checkBox_x2.Text = "g(x)=a₀+a₁·x+a₂·x²";
            this.checkBox_x2.UseVisualStyleBackColor = true;
            // 
            // checkBox_x
            // 
            this.checkBox_x.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_x.Location = new System.Drawing.Point(6, 85);
            this.checkBox_x.Name = "checkBox_x";
            this.checkBox_x.Size = new System.Drawing.Size(174, 47);
            this.checkBox_x.TabIndex = 2;
            this.checkBox_x.Text = "g(x)=a₀+a₁∙x";
            this.checkBox_x.UseVisualStyleBackColor = true;
            // 
            // checkBox_x3
            // 
            this.checkBox_x3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_x3.Location = new System.Drawing.Point(5, 168);
            this.checkBox_x3.Name = "checkBox_x3";
            this.checkBox_x3.Size = new System.Drawing.Size(256, 51);
            this.checkBox_x3.TabIndex = 1;
            this.checkBox_x3.Text = "g(x)=a₀+a₁·x+a₂·x²+a₃·x³";
            this.checkBox_x3.UseVisualStyleBackColor = true;
            // 
            // checkBox_yx
            // 
            this.checkBox_yx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_yx.Location = new System.Drawing.Point(6, 48);
            this.checkBox_yx.Name = "checkBox_yx";
            this.checkBox_yx.Size = new System.Drawing.Size(159, 44);
            this.checkBox_yx.TabIndex = 0;
            this.checkBox_yx.Text = "y(x)";
            this.checkBox_yx.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 566);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "График (chart)";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.CheckBox checkBox1;

        private System.Windows.Forms.CheckBox checkBox_b;

        private System.Windows.Forms.CheckBox checkBox_x2;
        private System.Windows.Forms.CheckBox checkBox_x3;

        private System.Windows.Forms.CheckBox checkBox_x;

        private System.Windows.Forms.CheckBox checkBox_e;

        private System.Windows.Forms.CheckBox checkBox_yx;

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox;

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem построитьГрафикToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьГрафикToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;

        #endregion
    }
}