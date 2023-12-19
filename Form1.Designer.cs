namespace SystemMonitorByFobox
{
    partial class SystemMonitorWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.LabelCPU = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.ProgressBarCPU = new MetroFramework.Controls.MetroProgressBar();
            this.ProgressBarRAM = new MetroFramework.Controls.MetroProgressBar();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.LabelRAM = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.CounterUsingMemory = new MetroFramework.Controls.MetroLabel();
            this.CounterAvailableMemory = new MetroFramework.Controls.MetroLabel();
            this.CounterInstalledMemory = new MetroFramework.Controls.MetroLabel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LabelProcessorName = new MetroFramework.Controls.MetroLabel();
            this.ProgressBarGPU = new MetroFramework.Controls.MetroProgressBar();
            this.LabelGPU = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.CounterProcessorTemperature = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.CounterProcessorTemperatureMax = new MetroFramework.Controls.MetroLabel();
            this.LabelCPUTemperature = new MetroFramework.Controls.MetroLabel();
            this.CounterProcessorTemperatureMin = new MetroFramework.Controls.MetroLabel();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel19 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel20 = new MetroFramework.Controls.MetroLabel();
            this.LabelGPUTemperature = new MetroFramework.Controls.MetroLabel();
            this.CounterGPUTemperatureMax = new MetroFramework.Controls.MetroLabel();
            this.CounterGPUTemperatureMin = new MetroFramework.Controls.MetroLabel();
            this.CounterGPUTemperature = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelCPU
            // 
            this.LabelCPU.AutoSize = true;
            this.LabelCPU.Location = new System.Drawing.Point(25, 65);
            this.LabelCPU.Name = "LabelCPU";
            this.LabelCPU.Size = new System.Drawing.Size(35, 19);
            this.LabelCPU.TabIndex = 0;
            this.LabelCPU.Text = "CPU";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(598, 65);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(20, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "%";
            // 
            // ProgressBarCPU
            // 
            this.ProgressBarCPU.Location = new System.Drawing.Point(89, 54);
            this.ProgressBarCPU.Name = "ProgressBarCPU";
            this.ProgressBarCPU.Size = new System.Drawing.Size(488, 44);
            this.ProgressBarCPU.Style = MetroFramework.MetroColorStyle.Red;
            this.ProgressBarCPU.TabIndex = 2;
            this.ProgressBarCPU.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // ProgressBarRAM
            // 
            this.ProgressBarRAM.Location = new System.Drawing.Point(89, 126);
            this.ProgressBarRAM.Name = "ProgressBarRAM";
            this.ProgressBarRAM.Size = new System.Drawing.Size(488, 44);
            this.ProgressBarRAM.TabIndex = 5;
            this.ProgressBarRAM.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(598, 139);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(20, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "%";
            // 
            // LabelRAM
            // 
            this.LabelRAM.AutoSize = true;
            this.LabelRAM.Location = new System.Drawing.Point(25, 138);
            this.LabelRAM.Name = "LabelRAM";
            this.LabelRAM.Size = new System.Drawing.Size(38, 19);
            this.LabelRAM.TabIndex = 3;
            this.LabelRAM.Text = "RAM";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(647, 126);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(44, 19);
            this.metroLabel5.TabIndex = 6;
            this.metroLabel5.Text = "Using:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(730, 126);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(62, 19);
            this.metroLabel6.TabIndex = 7;
            this.metroLabel6.Text = "Available";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(647, 151);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(107, 19);
            this.metroLabel7.TabIndex = 8;
            this.metroLabel7.Text = "InstalledMemory";
            // 
            // CounterUsingMemory
            // 
            this.CounterUsingMemory.AutoSize = true;
            this.CounterUsingMemory.Location = new System.Drawing.Point(694, 126);
            this.CounterUsingMemory.Name = "CounterUsingMemory";
            this.CounterUsingMemory.Size = new System.Drawing.Size(30, 19);
            this.CounterUsingMemory.TabIndex = 9;
            this.CounterUsingMemory.Text = "000";
            // 
            // CounterAvailableMemory
            // 
            this.CounterAvailableMemory.AutoSize = true;
            this.CounterAvailableMemory.Location = new System.Drawing.Point(798, 126);
            this.CounterAvailableMemory.Name = "CounterAvailableMemory";
            this.CounterAvailableMemory.Size = new System.Drawing.Size(30, 19);
            this.CounterAvailableMemory.TabIndex = 10;
            this.CounterAvailableMemory.Text = "000";
            // 
            // CounterInstalledMemory
            // 
            this.CounterInstalledMemory.AutoSize = true;
            this.CounterInstalledMemory.Location = new System.Drawing.Point(794, 151);
            this.CounterInstalledMemory.Name = "CounterInstalledMemory";
            this.CounterInstalledMemory.Size = new System.Drawing.Size(34, 19);
            this.CounterInstalledMemory.TabIndex = 11;
            this.CounterInstalledMemory.Text = " 000";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(57, 281);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "CPU";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "RAM";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "GPU";
            series6.YValuesPerPoint = 2;
            this.chart1.Series.Add(series4);
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(725, 274);
            this.chart1.TabIndex = 12;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LabelProcessorName
            // 
            this.LabelProcessorName.AutoSize = true;
            this.LabelProcessorName.Location = new System.Drawing.Point(276, 21);
            this.LabelProcessorName.Name = "LabelProcessorName";
            this.LabelProcessorName.Size = new System.Drawing.Size(117, 19);
            this.LabelProcessorName.TabIndex = 13;
            this.LabelProcessorName.Text = "NameOfProcessor";
            // 
            // ProgressBarGPU
            // 
            this.ProgressBarGPU.Location = new System.Drawing.Point(89, 218);
            this.ProgressBarGPU.Name = "ProgressBarGPU";
            this.ProgressBarGPU.Size = new System.Drawing.Size(488, 44);
            this.ProgressBarGPU.Style = MetroFramework.MetroColorStyle.Lime;
            this.ProgressBarGPU.TabIndex = 14;
            this.ProgressBarGPU.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // LabelGPU
            // 
            this.LabelGPU.AutoSize = true;
            this.LabelGPU.Location = new System.Drawing.Point(25, 231);
            this.LabelGPU.Name = "LabelGPU";
            this.LabelGPU.Size = new System.Drawing.Size(35, 19);
            this.LabelGPU.TabIndex = 15;
            this.LabelGPU.Text = "GPU";
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(598, 231);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(20, 19);
            this.metroLabel13.TabIndex = 16;
            this.metroLabel13.Text = "%";
            // 
            // CounterProcessorTemperature
            // 
            this.CounterProcessorTemperature.AutoSize = true;
            this.CounterProcessorTemperature.Location = new System.Drawing.Point(798, 54);
            this.CounterProcessorTemperature.Name = "CounterProcessorTemperature";
            this.CounterProcessorTemperature.Size = new System.Drawing.Size(30, 19);
            this.CounterProcessorTemperature.TabIndex = 17;
            this.CounterProcessorTemperature.Text = "000";
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(694, 79);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(30, 19);
            this.metroLabel14.TabIndex = 18;
            this.metroLabel14.Text = "000";
            // 
            // CounterProcessorTemperatureMax
            // 
            this.CounterProcessorTemperatureMax.AutoSize = true;
            this.CounterProcessorTemperatureMax.Location = new System.Drawing.Point(798, 79);
            this.CounterProcessorTemperatureMax.Name = "CounterProcessorTemperatureMax";
            this.CounterProcessorTemperatureMax.Size = new System.Drawing.Size(30, 19);
            this.CounterProcessorTemperatureMax.TabIndex = 19;
            this.CounterProcessorTemperatureMax.Text = "000";
            // 
            // LabelCPUTemperature
            // 
            this.LabelCPUTemperature.AutoSize = true;
            this.LabelCPUTemperature.Location = new System.Drawing.Point(647, 54);
            this.LabelCPUTemperature.Name = "LabelCPUTemperature";
            this.LabelCPUTemperature.Size = new System.Drawing.Size(117, 19);
            this.LabelCPUTemperature.TabIndex = 20;
            this.LabelCPUTemperature.Text = "CPU Temperature ";
            // 
            // CounterProcessorTemperatureMin
            // 
            this.CounterProcessorTemperatureMin.AutoSize = true;
            this.CounterProcessorTemperatureMin.Location = new System.Drawing.Point(647, 79);
            this.CounterProcessorTemperatureMin.Name = "CounterProcessorTemperatureMin";
            this.CounterProcessorTemperatureMin.Size = new System.Drawing.Size(31, 19);
            this.CounterProcessorTemperatureMin.TabIndex = 21;
            this.CounterProcessorTemperatureMin.Text = "Min";
            // 
            // metroLabel18
            // 
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.Location = new System.Drawing.Point(748, 79);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(34, 19);
            this.metroLabel18.TabIndex = 22;
            this.metroLabel18.Text = "Max";
            // 
            // metroLabel19
            // 
            this.metroLabel19.AutoSize = true;
            this.metroLabel19.Location = new System.Drawing.Point(748, 243);
            this.metroLabel19.Name = "metroLabel19";
            this.metroLabel19.Size = new System.Drawing.Size(34, 19);
            this.metroLabel19.TabIndex = 28;
            this.metroLabel19.Text = "Max";
            // 
            // metroLabel20
            // 
            this.metroLabel20.AutoSize = true;
            this.metroLabel20.Location = new System.Drawing.Point(647, 243);
            this.metroLabel20.Name = "metroLabel20";
            this.metroLabel20.Size = new System.Drawing.Size(31, 19);
            this.metroLabel20.TabIndex = 27;
            this.metroLabel20.Text = "Min";
            // 
            // LabelGPUTemperature
            // 
            this.LabelGPUTemperature.AutoSize = true;
            this.LabelGPUTemperature.Location = new System.Drawing.Point(647, 218);
            this.LabelGPUTemperature.Name = "LabelGPUTemperature";
            this.LabelGPUTemperature.Size = new System.Drawing.Size(117, 19);
            this.LabelGPUTemperature.TabIndex = 26;
            this.LabelGPUTemperature.Text = "GPU Temperature ";
            // 
            // CounterGPUTemperatureMax
            // 
            this.CounterGPUTemperatureMax.AutoSize = true;
            this.CounterGPUTemperatureMax.Location = new System.Drawing.Point(798, 243);
            this.CounterGPUTemperatureMax.Name = "CounterGPUTemperatureMax";
            this.CounterGPUTemperatureMax.Size = new System.Drawing.Size(30, 19);
            this.CounterGPUTemperatureMax.TabIndex = 25;
            this.CounterGPUTemperatureMax.Text = "000";
            // 
            // CounterGPUTemperatureMin
            // 
            this.CounterGPUTemperatureMin.AutoSize = true;
            this.CounterGPUTemperatureMin.Location = new System.Drawing.Point(694, 243);
            this.CounterGPUTemperatureMin.Name = "CounterGPUTemperatureMin";
            this.CounterGPUTemperatureMin.Size = new System.Drawing.Size(30, 19);
            this.CounterGPUTemperatureMin.TabIndex = 24;
            this.CounterGPUTemperatureMin.Text = "000";
            // 
            // CounterGPUTemperature
            // 
            this.CounterGPUTemperature.AutoSize = true;
            this.CounterGPUTemperature.Location = new System.Drawing.Point(798, 218);
            this.CounterGPUTemperature.Name = "CounterGPUTemperature";
            this.CounterGPUTemperature.Size = new System.Drawing.Size(30, 19);
            this.CounterGPUTemperature.TabIndex = 23;
            this.CounterGPUTemperature.Text = "000";
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(0, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(866, 657);
            this.metroTabControl1.TabIndex = 29;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroLabel19);
            this.metroTabPage1.Controls.Add(this.metroLabel20);
            this.metroTabPage1.Controls.Add(this.ProgressBarCPU);
            this.metroTabPage1.Controls.Add(this.LabelGPUTemperature);
            this.metroTabPage1.Controls.Add(this.LabelCPU);
            this.metroTabPage1.Controls.Add(this.CounterGPUTemperatureMax);
            this.metroTabPage1.Controls.Add(this.metroLabel2);
            this.metroTabPage1.Controls.Add(this.CounterGPUTemperatureMin);
            this.metroTabPage1.Controls.Add(this.LabelRAM);
            this.metroTabPage1.Controls.Add(this.CounterGPUTemperature);
            this.metroTabPage1.Controls.Add(this.metroLabel3);
            this.metroTabPage1.Controls.Add(this.metroLabel18);
            this.metroTabPage1.Controls.Add(this.ProgressBarRAM);
            this.metroTabPage1.Controls.Add(this.CounterProcessorTemperatureMin);
            this.metroTabPage1.Controls.Add(this.metroLabel5);
            this.metroTabPage1.Controls.Add(this.LabelCPUTemperature);
            this.metroTabPage1.Controls.Add(this.metroLabel6);
            this.metroTabPage1.Controls.Add(this.CounterProcessorTemperatureMax);
            this.metroTabPage1.Controls.Add(this.metroLabel7);
            this.metroTabPage1.Controls.Add(this.metroLabel14);
            this.metroTabPage1.Controls.Add(this.CounterUsingMemory);
            this.metroTabPage1.Controls.Add(this.CounterProcessorTemperature);
            this.metroTabPage1.Controls.Add(this.CounterAvailableMemory);
            this.metroTabPage1.Controls.Add(this.metroLabel13);
            this.metroTabPage1.Controls.Add(this.CounterInstalledMemory);
            this.metroTabPage1.Controls.Add(this.LabelGPU);
            this.metroTabPage1.Controls.Add(this.chart1);
            this.metroTabPage1.Controls.Add(this.ProgressBarGPU);
            this.metroTabPage1.Controls.Add(this.LabelProcessorName);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(858, 615);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Base information";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(858, 615);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "metroTabPage2";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // SystemMonitorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 740);
            this.Controls.Add(this.metroTabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SystemMonitorWindow";
            this.Text = "System Monitor";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel LabelCPU;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroProgressBar ProgressBarCPU;
        private MetroFramework.Controls.MetroProgressBar ProgressBarRAM;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel LabelRAM;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel CounterUsingMemory;
        private MetroFramework.Controls.MetroLabel CounterAvailableMemory;
        private MetroFramework.Controls.MetroLabel CounterInstalledMemory;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroLabel LabelProcessorName;
        private MetroFramework.Controls.MetroProgressBar ProgressBarGPU;
        private MetroFramework.Controls.MetroLabel LabelGPU;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel CounterProcessorTemperature;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel CounterProcessorTemperatureMax;
        private MetroFramework.Controls.MetroLabel LabelCPUTemperature;
        private MetroFramework.Controls.MetroLabel CounterProcessorTemperatureMin;
        private MetroFramework.Controls.MetroLabel metroLabel18;
        private MetroFramework.Controls.MetroLabel metroLabel19;
        private MetroFramework.Controls.MetroLabel metroLabel20;
        private MetroFramework.Controls.MetroLabel LabelGPUTemperature;
        private MetroFramework.Controls.MetroLabel CounterGPUTemperatureMax;
        private MetroFramework.Controls.MetroLabel CounterGPUTemperatureMin;
        private MetroFramework.Controls.MetroLabel CounterGPUTemperature;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
    }
}

