﻿namespace ChartingProto
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

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
      this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
      this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
      this.toolStripContainer1.ContentPanel.SuspendLayout();
      this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
      this.toolStripContainer1.SuspendLayout();
      this.statusStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // toolStripContainer1
      // 
      // 
      // toolStripContainer1.BottomToolStripPanel
      // 
      this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.statusStrip1);
      // 
      // toolStripContainer1.ContentPanel
      // 
      this.toolStripContainer1.ContentPanel.Controls.Add(this.chart1);
      this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(486, 216);
      this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
      this.toolStripContainer1.Name = "toolStripContainer1";
      this.toolStripContainer1.Size = new System.Drawing.Size(486, 262);
      this.toolStripContainer1.TabIndex = 0;
      this.toolStripContainer1.Text = "toolStripContainer1";
      // 
      // toolStripContainer1.TopToolStripPanel
      // 
      this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
      // 
      // statusStrip1
      // 
      this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
      this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
      this.statusStrip1.Location = new System.Drawing.Point(0, 0);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(486, 22);
      this.statusStrip1.TabIndex = 0;
      // 
      // toolStripStatusLabel1
      // 
      this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
      this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
      this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
      // 
      // chart1
      // 
      chartArea1.AxisX.IsMarginVisible = false;
      chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
      chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
      chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
      chartArea1.Name = "ChartArea1";
      this.chart1.ChartAreas.Add(chartArea1);
      this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
      legend1.DockedToChartArea = "ChartArea1";
      legend1.Name = "Legend1";
      this.chart1.Legends.Add(legend1);
      this.chart1.Location = new System.Drawing.Point(0, 0);
      this.chart1.Name = "chart1";
      series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      series1.ChartArea = "ChartArea1";
      series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
      series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
      series1.Legend = "Legend1";
      series1.Name = "Series1";
      series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
      this.chart1.Series.Add(series1);
      this.chart1.Size = new System.Drawing.Size(486, 216);
      this.chart1.TabIndex = 0;
      this.chart1.Text = "chart1";
      // 
      // menuStrip1
      // 
      this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(486, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // menuToolStripMenuItem
      // 
      this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem});
      this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
      this.menuToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
      this.menuToolStripMenuItem.Text = "Data";
      // 
      // startToolStripMenuItem
      // 
      this.startToolStripMenuItem.Name = "startToolStripMenuItem";
      this.startToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
      this.startToolStripMenuItem.Text = "Start";
      this.startToolStripMenuItem.Click += new System.EventHandler(this.goToolStripMenuItem_Click);
      // 
      // stopToolStripMenuItem
      // 
      this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
      this.stopToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
      this.stopToolStripMenuItem.Text = "Stop";
      this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(486, 262);
      this.Controls.Add(this.toolStripContainer1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
      this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
      this.toolStripContainer1.ContentPanel.ResumeLayout(false);
      this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
      this.toolStripContainer1.TopToolStripPanel.PerformLayout();
      this.toolStripContainer1.ResumeLayout(false);
      this.toolStripContainer1.PerformLayout();
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ToolStripContainer toolStripContainer1;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;

  }
}
