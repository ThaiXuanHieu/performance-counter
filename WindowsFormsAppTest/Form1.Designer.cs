
namespace WindowsFormsAppTest
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gunaCircleProgressBarSec = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.gunaCircleProgressBarMinute = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.gunaCircleProgressBarHour = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.guna2CircleProgressBar3 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.guna2CircleProgressBar4 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.guna2CircleProgressBar8 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.gunaCircleProgressBarCPU = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.gunaCircleProgressBarRAM = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.lblRAM = new System.Windows.Forms.Label();
            this.lblRAMP = new System.Windows.Forms.Label();
            this.lblCPUP = new System.Windows.Forms.Label();
            this.lblCPU = new System.Windows.Forms.Label();
            this.pRAM = new System.Diagnostics.PerformanceCounter();
            this.pCPU = new System.Diagnostics.PerformanceCounter();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblHour = new System.Windows.Forms.Label();
            this.gunaCircleProgressBarSec.SuspendLayout();
            this.gunaCircleProgressBarMinute.SuspendLayout();
            this.guna2CircleProgressBar3.SuspendLayout();
            this.guna2CircleProgressBar4.SuspendLayout();
            this.guna2CircleProgressBar8.SuspendLayout();
            this.gunaCircleProgressBarCPU.SuspendLayout();
            this.gunaCircleProgressBarRAM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaCircleProgressBarSec
            // 
            this.gunaCircleProgressBarSec.BackColor = System.Drawing.Color.Transparent;
            this.gunaCircleProgressBarSec.Controls.Add(this.gunaCircleProgressBarMinute);
            this.gunaCircleProgressBarSec.FillColor = System.Drawing.Color.DarkOrchid;
            this.gunaCircleProgressBarSec.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gunaCircleProgressBarSec.ForeColor = System.Drawing.Color.White;
            this.gunaCircleProgressBarSec.InnerColor = System.Drawing.Color.Transparent;
            this.gunaCircleProgressBarSec.Location = new System.Drawing.Point(35, 32);
            this.gunaCircleProgressBarSec.Maximum = 60;
            this.gunaCircleProgressBarSec.Minimum = 0;
            this.gunaCircleProgressBarSec.Name = "gunaCircleProgressBarSec";
            this.gunaCircleProgressBarSec.ProgressColor = System.Drawing.Color.DeepPink;
            this.gunaCircleProgressBarSec.ProgressColor2 = System.Drawing.Color.Crimson;
            this.gunaCircleProgressBarSec.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round;
            this.gunaCircleProgressBarSec.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round;
            this.gunaCircleProgressBarSec.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.gunaCircleProgressBarSec.ShadowDecoration.Parent = this.gunaCircleProgressBarSec;
            this.gunaCircleProgressBarSec.Size = new System.Drawing.Size(211, 211);
            this.gunaCircleProgressBarSec.TabIndex = 5;
            this.gunaCircleProgressBarSec.Text = "gunaCircleProgressBarSec";
            this.gunaCircleProgressBarSec.Value = 10;
            // 
            // gunaCircleProgressBarMinute
            // 
            this.gunaCircleProgressBarMinute.BackColor = System.Drawing.Color.Transparent;
            this.gunaCircleProgressBarMinute.Controls.Add(this.gunaCircleProgressBarHour);
            this.gunaCircleProgressBarMinute.FillColor = System.Drawing.Color.ForestGreen;
            this.gunaCircleProgressBarMinute.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gunaCircleProgressBarMinute.InnerColor = System.Drawing.Color.Transparent;
            this.gunaCircleProgressBarMinute.Location = new System.Drawing.Point(34, 33);
            this.gunaCircleProgressBarMinute.Maximum = 60;
            this.gunaCircleProgressBarMinute.Minimum = 0;
            this.gunaCircleProgressBarMinute.Name = "gunaCircleProgressBarMinute";
            this.gunaCircleProgressBarMinute.ProgressColor = System.Drawing.Color.Chartreuse;
            this.gunaCircleProgressBarMinute.ProgressColor2 = System.Drawing.Color.Chartreuse;
            this.gunaCircleProgressBarMinute.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round;
            this.gunaCircleProgressBarMinute.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round;
            this.gunaCircleProgressBarMinute.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.gunaCircleProgressBarMinute.ShadowDecoration.Parent = this.gunaCircleProgressBarMinute;
            this.gunaCircleProgressBarMinute.Size = new System.Drawing.Size(144, 144);
            this.gunaCircleProgressBarMinute.TabIndex = 0;
            this.gunaCircleProgressBarMinute.Text = "gunaCircleProgressBarMinute";
            this.gunaCircleProgressBarMinute.Value = 15;
            // 
            // gunaCircleProgressBarHour
            // 
            this.gunaCircleProgressBarHour.FillColor = System.Drawing.Color.LightSeaGreen;
            this.gunaCircleProgressBarHour.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gunaCircleProgressBarHour.ForeColor = System.Drawing.Color.White;
            this.gunaCircleProgressBarHour.InnerColor = System.Drawing.Color.Transparent;
            this.gunaCircleProgressBarHour.Location = new System.Drawing.Point(35, 32);
            this.gunaCircleProgressBarHour.Maximum = 24;
            this.gunaCircleProgressBarHour.Minimum = 0;
            this.gunaCircleProgressBarHour.Name = "gunaCircleProgressBarHour";
            this.gunaCircleProgressBarHour.ProgressColor = System.Drawing.Color.MediumTurquoise;
            this.gunaCircleProgressBarHour.ProgressColor2 = System.Drawing.Color.Turquoise;
            this.gunaCircleProgressBarHour.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round;
            this.gunaCircleProgressBarHour.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round;
            this.gunaCircleProgressBarHour.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.gunaCircleProgressBarHour.ShadowDecoration.Parent = this.gunaCircleProgressBarHour;
            this.gunaCircleProgressBarHour.Size = new System.Drawing.Size(80, 80);
            this.gunaCircleProgressBarHour.TabIndex = 0;
            this.gunaCircleProgressBarHour.Text = "gunaCircleProgressBarHour";
            this.gunaCircleProgressBarHour.Value = 10;
            // 
            // guna2CircleProgressBar3
            // 
            this.guna2CircleProgressBar3.BackColor = System.Drawing.Color.Transparent;
            this.guna2CircleProgressBar3.Controls.Add(this.gunaCircleProgressBarSec);
            this.guna2CircleProgressBar3.FillColor = System.Drawing.SystemColors.ButtonFace;
            this.guna2CircleProgressBar3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2CircleProgressBar3.ForeColor = System.Drawing.Color.White;
            this.guna2CircleProgressBar3.InnerColor = System.Drawing.Color.Transparent;
            this.guna2CircleProgressBar3.Location = new System.Drawing.Point(428, 21);
            this.guna2CircleProgressBar3.Minimum = 0;
            this.guna2CircleProgressBar3.Name = "guna2CircleProgressBar3";
            this.guna2CircleProgressBar3.ProgressColor = System.Drawing.SystemColors.ButtonFace;
            this.guna2CircleProgressBar3.ProgressColor2 = System.Drawing.SystemColors.ButtonFace;
            this.guna2CircleProgressBar3.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round;
            this.guna2CircleProgressBar3.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round;
            this.guna2CircleProgressBar3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleProgressBar3.ShadowDecoration.Parent = this.guna2CircleProgressBar3;
            this.guna2CircleProgressBar3.Size = new System.Drawing.Size(273, 273);
            this.guna2CircleProgressBar3.TabIndex = 6;
            this.guna2CircleProgressBar3.Text = "gunaCircleProgressBarHour";
            this.guna2CircleProgressBar3.Value = 25;
            // 
            // guna2CircleProgressBar4
            // 
            this.guna2CircleProgressBar4.BackColor = System.Drawing.Color.Transparent;
            this.guna2CircleProgressBar4.Controls.Add(this.gunaCircleProgressBarRAM);
            this.guna2CircleProgressBar4.FillColor = System.Drawing.SystemColors.ButtonFace;
            this.guna2CircleProgressBar4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2CircleProgressBar4.ForeColor = System.Drawing.Color.White;
            this.guna2CircleProgressBar4.InnerColor = System.Drawing.Color.Transparent;
            this.guna2CircleProgressBar4.Location = new System.Drawing.Point(88, 250);
            this.guna2CircleProgressBar4.Minimum = 0;
            this.guna2CircleProgressBar4.Name = "guna2CircleProgressBar4";
            this.guna2CircleProgressBar4.ProgressColor = System.Drawing.SystemColors.ActiveBorder;
            this.guna2CircleProgressBar4.ProgressColor2 = System.Drawing.SystemColors.ActiveBorder;
            this.guna2CircleProgressBar4.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round;
            this.guna2CircleProgressBar4.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round;
            this.guna2CircleProgressBar4.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleProgressBar4.ShadowDecoration.Parent = this.guna2CircleProgressBar4;
            this.guna2CircleProgressBar4.Size = new System.Drawing.Size(273, 273);
            this.guna2CircleProgressBar4.TabIndex = 7;
            this.guna2CircleProgressBar4.Text = "guna2CircleProgressBar1";
            // 
            // guna2CircleProgressBar8
            // 
            this.guna2CircleProgressBar8.BackColor = System.Drawing.Color.Transparent;
            this.guna2CircleProgressBar8.Controls.Add(this.gunaCircleProgressBarCPU);
            this.guna2CircleProgressBar8.FillColor = System.Drawing.SystemColors.ButtonFace;
            this.guna2CircleProgressBar8.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2CircleProgressBar8.ForeColor = System.Drawing.Color.White;
            this.guna2CircleProgressBar8.InnerColor = System.Drawing.Color.Transparent;
            this.guna2CircleProgressBar8.Location = new System.Drawing.Point(765, 250);
            this.guna2CircleProgressBar8.Minimum = 0;
            this.guna2CircleProgressBar8.Name = "guna2CircleProgressBar8";
            this.guna2CircleProgressBar8.ProgressColor = System.Drawing.SystemColors.ActiveBorder;
            this.guna2CircleProgressBar8.ProgressColor2 = System.Drawing.SystemColors.ActiveBorder;
            this.guna2CircleProgressBar8.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round;
            this.guna2CircleProgressBar8.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round;
            this.guna2CircleProgressBar8.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleProgressBar8.ShadowDecoration.Parent = this.guna2CircleProgressBar8;
            this.guna2CircleProgressBar8.Size = new System.Drawing.Size(273, 273);
            this.guna2CircleProgressBar8.TabIndex = 8;
            this.guna2CircleProgressBar8.Text = "guna2CircleProgressBar1";
            // 
            // gunaCircleProgressBarCPU
            // 
            this.gunaCircleProgressBarCPU.BackColor = System.Drawing.Color.Transparent;
            this.gunaCircleProgressBarCPU.Controls.Add(this.lblCPUP);
            this.gunaCircleProgressBarCPU.Controls.Add(this.lblCPU);
            this.gunaCircleProgressBarCPU.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gunaCircleProgressBarCPU.ForeColor = System.Drawing.Color.White;
            this.gunaCircleProgressBarCPU.InnerColor = System.Drawing.Color.Transparent;
            this.gunaCircleProgressBarCPU.Location = new System.Drawing.Point(33, 32);
            this.gunaCircleProgressBarCPU.Minimum = 0;
            this.gunaCircleProgressBarCPU.Name = "gunaCircleProgressBarCPU";
            this.gunaCircleProgressBarCPU.ProgressColor = System.Drawing.SystemColors.AppWorkspace;
            this.gunaCircleProgressBarCPU.ProgressColor2 = System.Drawing.SystemColors.AppWorkspace;
            this.gunaCircleProgressBarCPU.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.gunaCircleProgressBarCPU.ShadowDecoration.Parent = this.gunaCircleProgressBarCPU;
            this.gunaCircleProgressBarCPU.Size = new System.Drawing.Size(211, 211);
            this.gunaCircleProgressBarCPU.TabIndex = 5;
            this.gunaCircleProgressBarCPU.Text = "gunaCircleProgressBarCPU";
            this.gunaCircleProgressBarCPU.Value = 5;
            // 
            // gunaCircleProgressBarRAM
            // 
            this.gunaCircleProgressBarRAM.BackColor = System.Drawing.Color.Transparent;
            this.gunaCircleProgressBarRAM.Controls.Add(this.lblRAMP);
            this.gunaCircleProgressBarRAM.Controls.Add(this.lblRAM);
            this.gunaCircleProgressBarRAM.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gunaCircleProgressBarRAM.ForeColor = System.Drawing.Color.White;
            this.gunaCircleProgressBarRAM.InnerColor = System.Drawing.Color.Transparent;
            this.gunaCircleProgressBarRAM.Location = new System.Drawing.Point(33, 32);
            this.gunaCircleProgressBarRAM.Minimum = 0;
            this.gunaCircleProgressBarRAM.Name = "gunaCircleProgressBarRAM";
            this.gunaCircleProgressBarRAM.ProgressColor = System.Drawing.SystemColors.AppWorkspace;
            this.gunaCircleProgressBarRAM.ProgressColor2 = System.Drawing.SystemColors.AppWorkspace;
            this.gunaCircleProgressBarRAM.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.gunaCircleProgressBarRAM.ShadowDecoration.Parent = this.gunaCircleProgressBarRAM;
            this.gunaCircleProgressBarRAM.Size = new System.Drawing.Size(211, 211);
            this.gunaCircleProgressBarRAM.TabIndex = 5;
            this.gunaCircleProgressBarRAM.Text = "gunaCircleProgressBarRAM";
            this.gunaCircleProgressBarRAM.Value = 48;
            // 
            // lblRAM
            // 
            this.lblRAM.AutoSize = true;
            this.lblRAM.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRAM.Location = new System.Drawing.Point(66, 68);
            this.lblRAM.Name = "lblRAM";
            this.lblRAM.Size = new System.Drawing.Size(82, 38);
            this.lblRAM.TabIndex = 0;
            this.lblRAM.Text = "RAM";
            // 
            // lblRAMP
            // 
            this.lblRAMP.AutoSize = true;
            this.lblRAMP.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRAMP.Location = new System.Drawing.Point(66, 106);
            this.lblRAMP.Name = "lblRAMP";
            this.lblRAMP.Size = new System.Drawing.Size(0, 38);
            this.lblRAMP.TabIndex = 1;
            // 
            // lblCPUP
            // 
            this.lblCPUP.AutoSize = true;
            this.lblCPUP.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPUP.Location = new System.Drawing.Point(64, 105);
            this.lblCPUP.Name = "lblCPUP";
            this.lblCPUP.Size = new System.Drawing.Size(0, 38);
            this.lblCPUP.TabIndex = 3;
            // 
            // lblCPU
            // 
            this.lblCPU.AutoSize = true;
            this.lblCPU.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPU.Location = new System.Drawing.Point(64, 67);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(71, 38);
            this.lblCPU.TabIndex = 2;
            this.lblCPU.Text = "CPU";
            // 
            // pRAM
            // 
            this.pRAM.CategoryName = "Memory";
            this.pRAM.CounterName = "% Committed Bytes In Use";
            // 
            // pCPU
            // 
            this.pCPU.CategoryName = "Processor";
            this.pCPU.CounterName = "% Processor TIme";
            this.pCPU.InstanceName = "_Total";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.BackColor = System.Drawing.Color.Transparent;
            this.lblHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHour.ForeColor = System.Drawing.Color.White;
            this.lblHour.Location = new System.Drawing.Point(759, 118);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(32, 32);
            this.lblHour.TabIndex = 0;
            this.lblHour.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1093, 688);
            this.Controls.Add(this.lblHour);
            this.Controls.Add(this.guna2CircleProgressBar8);
            this.Controls.Add(this.guna2CircleProgressBar4);
            this.Controls.Add(this.guna2CircleProgressBar3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gunaCircleProgressBarSec.ResumeLayout(false);
            this.gunaCircleProgressBarMinute.ResumeLayout(false);
            this.guna2CircleProgressBar3.ResumeLayout(false);
            this.guna2CircleProgressBar4.ResumeLayout(false);
            this.guna2CircleProgressBar8.ResumeLayout(false);
            this.gunaCircleProgressBarCPU.ResumeLayout(false);
            this.gunaCircleProgressBarCPU.PerformLayout();
            this.gunaCircleProgressBarRAM.ResumeLayout(false);
            this.gunaCircleProgressBarRAM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleProgressBar gunaCircleProgressBarSec;
        private Guna.UI2.WinForms.Guna2CircleProgressBar gunaCircleProgressBarMinute;
        private Guna.UI2.WinForms.Guna2CircleProgressBar gunaCircleProgressBarHour;
        private Guna.UI2.WinForms.Guna2CircleProgressBar guna2CircleProgressBar3;
        private Guna.UI2.WinForms.Guna2CircleProgressBar guna2CircleProgressBar4;
        private Guna.UI2.WinForms.Guna2CircleProgressBar gunaCircleProgressBarRAM;
        private Guna.UI2.WinForms.Guna2CircleProgressBar guna2CircleProgressBar8;
        private Guna.UI2.WinForms.Guna2CircleProgressBar gunaCircleProgressBarCPU;
        private System.Windows.Forms.Label lblRAMP;
        private System.Windows.Forms.Label lblRAM;
        private System.Windows.Forms.Label lblCPUP;
        private System.Windows.Forms.Label lblCPU;
        private System.Diagnostics.PerformanceCounter pRAM;
        private System.Diagnostics.PerformanceCounter pCPU;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblHour;
    }
}

