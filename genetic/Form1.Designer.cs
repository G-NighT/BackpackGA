namespace genetic
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button_go = new System.Windows.Forms.Button();
            this.listViewItems = new System.Windows.Forms.ListView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label5 = new System.Windows.Forms.Label();
            this.label_best = new System.Windows.Forms.Label();
            this.nudWeight = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudParent = new System.Windows.Forms.NumericUpDown();
            this.nudP = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nudChild = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label_cennost = new System.Windows.Forms.Label();
            this.label_ves = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudParent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChild)).BeginInit();
            this.SuspendLayout();
            // 
            // button_go
            // 
            this.button_go.Font = new System.Drawing.Font("Panton", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_go.Location = new System.Drawing.Point(172, 142);
            this.button_go.Name = "button_go";
            this.button_go.Size = new System.Drawing.Size(213, 28);
            this.button_go.TabIndex = 0;
            this.button_go.Text = "Выполнить";
            this.button_go.UseVisualStyleBackColor = true;
            this.button_go.Click += new System.EventHandler(this.button_go_Click);
            // 
            // listViewItems
            // 
            this.listViewItems.Location = new System.Drawing.Point(16, 31);
            this.listViewItems.Name = "listViewItems";
            this.listViewItems.Size = new System.Drawing.Size(146, 161);
            this.listViewItems.TabIndex = 1;
            this.listViewItems.UseCompatibleStateImageBehavior = false;
            this.listViewItems.View = System.Windows.Forms.View.Details;
            // 
            // chart1
            // 
            chartArea5.AxisX.Title = "Поколение";
            chartArea5.AxisY.Title = "Цена";
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(-29, 244);
            this.chart1.Name = "chart1";
            series9.BorderWidth = 3;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Color = System.Drawing.Color.Green;
            series9.Legend = "Legend1";
            series9.LegendText = "Лучшая особь";
            series9.MarkerSize = 3;
            series9.Name = "Series1";
            series10.BorderWidth = 2;
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            series10.Color = System.Drawing.Color.Red;
            series10.Legend = "Legend1";
            series10.LegendText = "Родители";
            series10.Name = "Series2";
            series10.YValuesPerPoint = 2;
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series11.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            series11.LabelForeColor = System.Drawing.Color.BlanchedAlmond;
            series11.Legend = "Legend1";
            series11.LegendText = "Поколение";
            series11.MarkerSize = 4;
            series11.Name = "Series3";
            this.chart1.Series.Add(series9);
            this.chart1.Series.Add(series10);
            this.chart1.Series.Add(series11);
            this.chart1.Size = new System.Drawing.Size(1126, 343);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea6.AxisX.Title = "Поколение";
            chartArea6.AxisY.Title = "Вес";
            chartArea6.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea6);
            this.chart2.Location = new System.Drawing.Point(375, 31);
            this.chart2.Name = "chart2";
            series12.BorderWidth = 3;
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series12.Color = System.Drawing.Color.Green;
            series12.Name = "Series4";
            this.chart2.Series.Add(series12);
            this.chart2.Size = new System.Drawing.Size(722, 207);
            this.chart2.TabIndex = 10;
            this.chart2.Text = "chart2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Panton", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(219, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ответ:";
            // 
            // label_best
            // 
            this.label_best.AutoSize = true;
            this.label_best.Font = new System.Drawing.Font("Panton Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_best.ForeColor = System.Drawing.Color.Green;
            this.label_best.Location = new System.Drawing.Point(273, 186);
            this.label_best.Name = "label_best";
            this.label_best.Size = new System.Drawing.Size(132, 19);
            this.label_best.TabIndex = 12;
            this.label_best.Text = "Лучший потомок";
            // 
            // nudWeight
            // 
            this.nudWeight.Font = new System.Drawing.Font("Panton", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudWeight.Location = new System.Drawing.Point(277, 109);
            this.nudWeight.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudWeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudWeight.Name = "nudWeight";
            this.nudWeight.Size = new System.Drawing.Size(108, 27);
            this.nudWeight.TabIndex = 19;
            this.nudWeight.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Panton", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(168, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "Вместимость";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Panton", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(168, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "Родители";
            // 
            // nudParent
            // 
            this.nudParent.Font = new System.Drawing.Font("Panton", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudParent.Location = new System.Drawing.Point(277, 31);
            this.nudParent.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudParent.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudParent.Name = "nudParent";
            this.nudParent.Size = new System.Drawing.Size(108, 27);
            this.nudParent.TabIndex = 18;
            this.nudParent.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // nudP
            // 
            this.nudP.Font = new System.Drawing.Font("Panton", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudP.Location = new System.Drawing.Point(277, 83);
            this.nudP.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudP.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudP.Name = "nudP";
            this.nudP.Size = new System.Drawing.Size(108, 27);
            this.nudP.TabIndex = 13;
            this.nudP.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Panton", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(168, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Поколения";
            // 
            // nudChild
            // 
            this.nudChild.Font = new System.Drawing.Font("Panton", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudChild.Location = new System.Drawing.Point(277, 57);
            this.nudChild.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudChild.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudChild.Name = "nudChild";
            this.nudChild.Size = new System.Drawing.Size(108, 27);
            this.nudChild.TabIndex = 16;
            this.nudChild.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Panton", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(168, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "Потомки";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Panton", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 19);
            this.label6.TabIndex = 21;
            this.label6.Text = "Наши вещи";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Panton", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 19);
            this.label7.TabIndex = 25;
            this.label7.Text = "Вес";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Panton", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(12, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 19);
            this.label8.TabIndex = 23;
            this.label8.Text = "Цена";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Panton", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(124, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 27);
            this.button1.TabIndex = 22;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Panton", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(55, 198);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(63, 27);
            this.textBox1.TabIndex = 26;
            this.textBox1.Text = "16,6";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Panton", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(55, 222);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(63, 27);
            this.textBox2.TabIndex = 27;
            this.textBox2.Text = "1435,8";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Panton", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(124, 222);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 27);
            this.button2.TabIndex = 28;
            this.button2.Text = "?";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Panton", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(235, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 19);
            this.label9.TabIndex = 29;
            this.label9.Text = "Вес:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Panton", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(225, 205);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 19);
            this.label10.TabIndex = 30;
            this.label10.Text = "Цена:";
            // 
            // label_cennost
            // 
            this.label_cennost.AutoSize = true;
            this.label_cennost.Font = new System.Drawing.Font("Panton Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_cennost.ForeColor = System.Drawing.Color.Green;
            this.label_cennost.Location = new System.Drawing.Point(273, 205);
            this.label_cennost.Name = "label_cennost";
            this.label_cennost.Size = new System.Drawing.Size(106, 19);
            this.label_cennost.TabIndex = 31;
            this.label_cennost.Text = "Его ценность";
            // 
            // label_ves
            // 
            this.label_ves.AutoSize = true;
            this.label_ves.Font = new System.Drawing.Font("Panton Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_ves.ForeColor = System.Drawing.Color.Green;
            this.label_ves.Location = new System.Drawing.Point(273, 224);
            this.label_ves.Name = "label_ves";
            this.label_ves.Size = new System.Drawing.Size(64, 19);
            this.label_ves.TabIndex = 32;
            this.label_ves.Text = "Его вес";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1095, 587);
            this.Controls.Add(this.label_ves);
            this.Controls.Add(this.label_cennost);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_go);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nudWeight);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudParent);
            this.Controls.Add(this.nudP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudChild);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_best);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.listViewItems);
            this.Name = "Form1";
            this.Text = "Задача о загрузке рюкзака";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudParent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChild)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_go;
        private System.Windows.Forms.ListView listViewItems;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_best;
        private System.Windows.Forms.NumericUpDown nudWeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudParent;
        private System.Windows.Forms.NumericUpDown nudP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudChild;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label_cennost;
        private System.Windows.Forms.Label label_ves;
    }
}

