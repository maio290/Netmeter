namespace Netmeter_Win_App
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.tp_ping = new System.Windows.Forms.TextBox();
			this.tp_timeout = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.fritz_ping = new System.Windows.Forms.TextBox();
			this.fritz_timeout = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.root_ping = new System.Windows.Forms.TextBox();
			this.root_timeout = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.google_ping = new System.Windows.Forms.TextBox();
			this.google_timeout = new System.Windows.Forms.TextBox();
			this.status_bar = new System.Windows.Forms.StatusStrip();
			this.runtime_label = new System.Windows.Forms.ToolStripStatusLabel();
			this.timeoutcounter = new System.Windows.Forms.ToolStripStatusLabel();
			this.TP_PB = new System.Windows.Forms.ProgressBar();
			this.FB_PB = new System.Windows.Forms.ProgressBar();
			this.RT_PB = new System.Windows.Forms.ProgressBar();
			this.GO_PB = new System.Windows.Forms.ProgressBar();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.IP = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.to_msec_tb = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.IPs = new System.Windows.Forms.GroupBox();
			this.ip4_tb = new System.Windows.Forms.TextBox();
			this.ip1_tb = new System.Windows.Forms.TextBox();
			this.ip2_tb = new System.Windows.Forms.TextBox();
			this.ip3_tb = new System.Windows.Forms.TextBox();
			this.status_bar.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.IP.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.IPs.SuspendLayout();
			this.SuspendLayout();
			// 
			// tp_ping
			// 
			this.tp_ping.BackColor = System.Drawing.Color.White;
			this.tp_ping.Enabled = false;
			this.tp_ping.Location = new System.Drawing.Point(33, 19);
			this.tp_ping.Name = "tp_ping";
			this.tp_ping.ReadOnly = true;
			this.tp_ping.Size = new System.Drawing.Size(78, 20);
			this.tp_ping.TabIndex = 2;
			this.tp_ping.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tp_timeout
			// 
			this.tp_timeout.BackColor = System.Drawing.Color.White;
			this.tp_timeout.Enabled = false;
			this.tp_timeout.ForeColor = System.Drawing.Color.Red;
			this.tp_timeout.Location = new System.Drawing.Point(6, 19);
			this.tp_timeout.Name = "tp_timeout";
			this.tp_timeout.Size = new System.Drawing.Size(75, 20);
			this.tp_timeout.TabIndex = 5;
			this.tp_timeout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label3
			// 
			this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
			this.label3.Location = new System.Drawing.Point(12, 26);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 32);
			this.label3.TabIndex = 6;
			this.label3.Click += new System.EventHandler(this.Label3Click);
			// 
			// label4
			// 
			this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
			this.label4.Location = new System.Drawing.Point(12, 71);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(32, 32);
			this.label4.TabIndex = 7;
			this.label4.Click += new System.EventHandler(this.Label4Click);
			// 
			// fritz_ping
			// 
			this.fritz_ping.BackColor = System.Drawing.Color.White;
			this.fritz_ping.Enabled = false;
			this.fritz_ping.Location = new System.Drawing.Point(33, 73);
			this.fritz_ping.Name = "fritz_ping";
			this.fritz_ping.Size = new System.Drawing.Size(78, 20);
			this.fritz_ping.TabIndex = 8;
			this.fritz_ping.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// fritz_timeout
			// 
			this.fritz_timeout.BackColor = System.Drawing.Color.White;
			this.fritz_timeout.Enabled = false;
			this.fritz_timeout.ForeColor = System.Drawing.Color.Red;
			this.fritz_timeout.Location = new System.Drawing.Point(6, 73);
			this.fritz_timeout.Name = "fritz_timeout";
			this.fritz_timeout.Size = new System.Drawing.Size(75, 20);
			this.fritz_timeout.TabIndex = 9;
			this.fritz_timeout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label5
			// 
			this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
			this.label5.Location = new System.Drawing.Point(12, 128);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(32, 32);
			this.label5.TabIndex = 10;
			this.label5.Click += new System.EventHandler(this.Label5Click);
			// 
			// root_ping
			// 
			this.root_ping.BackColor = System.Drawing.Color.White;
			this.root_ping.Enabled = false;
			this.root_ping.Location = new System.Drawing.Point(33, 130);
			this.root_ping.Name = "root_ping";
			this.root_ping.Size = new System.Drawing.Size(78, 20);
			this.root_ping.TabIndex = 11;
			this.root_ping.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// root_timeout
			// 
			this.root_timeout.BackColor = System.Drawing.Color.White;
			this.root_timeout.Enabled = false;
			this.root_timeout.ForeColor = System.Drawing.Color.Red;
			this.root_timeout.Location = new System.Drawing.Point(6, 130);
			this.root_timeout.Name = "root_timeout";
			this.root_timeout.Size = new System.Drawing.Size(75, 20);
			this.root_timeout.TabIndex = 12;
			this.root_timeout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label6
			// 
			this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
			this.label6.Location = new System.Drawing.Point(12, 190);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(32, 32);
			this.label6.TabIndex = 13;
			this.label6.Click += new System.EventHandler(this.Label6Click);
			// 
			// google_ping
			// 
			this.google_ping.BackColor = System.Drawing.Color.White;
			this.google_ping.Enabled = false;
			this.google_ping.Location = new System.Drawing.Point(33, 192);
			this.google_ping.Name = "google_ping";
			this.google_ping.Size = new System.Drawing.Size(78, 20);
			this.google_ping.TabIndex = 14;
			this.google_ping.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// google_timeout
			// 
			this.google_timeout.BackColor = System.Drawing.Color.White;
			this.google_timeout.Enabled = false;
			this.google_timeout.ForeColor = System.Drawing.Color.Red;
			this.google_timeout.Location = new System.Drawing.Point(6, 192);
			this.google_timeout.Name = "google_timeout";
			this.google_timeout.Size = new System.Drawing.Size(75, 20);
			this.google_timeout.TabIndex = 15;
			this.google_timeout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// status_bar
			// 
			this.status_bar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.runtime_label,
									this.timeoutcounter});
			this.status_bar.Location = new System.Drawing.Point(0, 466);
			this.status_bar.Name = "status_bar";
			this.status_bar.Size = new System.Drawing.Size(268, 22);
			this.status_bar.SizingGrip = false;
			this.status_bar.Stretch = false;
			this.status_bar.TabIndex = 17;
			// 
			// runtime_label
			// 
			this.runtime_label.Name = "runtime_label";
			this.runtime_label.Size = new System.Drawing.Size(57, 17);
			this.runtime_label.Text = "[00:00:00]";
			// 
			// timeoutcounter
			// 
			this.timeoutcounter.Name = "timeoutcounter";
			this.timeoutcounter.Size = new System.Drawing.Size(18, 17);
			this.timeoutcounter.Text = "0x";
			// 
			// TP_PB
			// 
			this.TP_PB.Location = new System.Drawing.Point(6, 19);
			this.TP_PB.Name = "TP_PB";
			this.TP_PB.Size = new System.Drawing.Size(23, 18);
			this.TP_PB.TabIndex = 18;
			// 
			// FB_PB
			// 
			this.FB_PB.Location = new System.Drawing.Point(4, 73);
			this.FB_PB.Name = "FB_PB";
			this.FB_PB.Size = new System.Drawing.Size(23, 18);
			this.FB_PB.TabIndex = 19;
			// 
			// RT_PB
			// 
			this.RT_PB.Location = new System.Drawing.Point(6, 130);
			this.RT_PB.Name = "RT_PB";
			this.RT_PB.Size = new System.Drawing.Size(23, 18);
			this.RT_PB.TabIndex = 20;
			// 
			// GO_PB
			// 
			this.GO_PB.Location = new System.Drawing.Point(6, 192);
			this.GO_PB.Name = "GO_PB";
			this.GO_PB.Size = new System.Drawing.Size(23, 18);
			this.GO_PB.TabIndex = 21;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.TP_PB);
			this.groupBox1.Controls.Add(this.GO_PB);
			this.groupBox1.Controls.Add(this.FB_PB);
			this.groupBox1.Controls.Add(this.google_ping);
			this.groupBox1.Controls.Add(this.RT_PB);
			this.groupBox1.Controls.Add(this.tp_ping);
			this.groupBox1.Controls.Add(this.fritz_ping);
			this.groupBox1.Controls.Add(this.root_ping);
			this.groupBox1.Location = new System.Drawing.Point(50, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(117, 220);
			this.groupBox1.TabIndex = 22;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Ping";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.tp_timeout);
			this.groupBox2.Controls.Add(this.fritz_timeout);
			this.groupBox2.Controls.Add(this.root_timeout);
			this.groupBox2.Controls.Add(this.google_timeout);
			this.groupBox2.Location = new System.Drawing.Point(173, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(90, 220);
			this.groupBox2.TabIndex = 23;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Timeouts";
			// 
			// IP
			// 
			this.IP.Controls.Add(this.groupBox3);
			this.IP.Controls.Add(this.IPs);
			this.IP.Location = new System.Drawing.Point(12, 249);
			this.IP.Name = "IP";
			this.IP.Size = new System.Drawing.Size(251, 215);
			this.IP.TabIndex = 24;
			this.IP.TabStop = false;
			this.IP.Text = "Config";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.to_msec_tb);
			this.groupBox3.Controls.Add(this.label1);
			this.groupBox3.Location = new System.Drawing.Point(6, 152);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(239, 49);
			this.groupBox3.TabIndex = 1;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Ping-Config";
			// 
			// to_msec_tb
			// 
			this.to_msec_tb.Enabled = false;
			this.to_msec_tb.Location = new System.Drawing.Point(110, 19);
			this.to_msec_tb.Name = "to_msec_tb";
			this.to_msec_tb.Size = new System.Drawing.Size(100, 20);
			this.to_msec_tb.TabIndex = 25;
			this.to_msec_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(6, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Timeout in msec";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// IPs
			// 
			this.IPs.Controls.Add(this.ip4_tb);
			this.IPs.Controls.Add(this.ip1_tb);
			this.IPs.Controls.Add(this.ip2_tb);
			this.IPs.Controls.Add(this.ip3_tb);
			this.IPs.Location = new System.Drawing.Point(6, 19);
			this.IPs.Name = "IPs";
			this.IPs.Size = new System.Drawing.Size(239, 127);
			this.IPs.TabIndex = 0;
			this.IPs.TabStop = false;
			this.IPs.Text = "IPs";
			// 
			// ip4_tb
			// 
			this.ip4_tb.Enabled = false;
			this.ip4_tb.Location = new System.Drawing.Point(6, 97);
			this.ip4_tb.Name = "ip4_tb";
			this.ip4_tb.Size = new System.Drawing.Size(204, 20);
			this.ip4_tb.TabIndex = 3;
			this.ip4_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ip1_tb
			// 
			this.ip1_tb.Enabled = false;
			this.ip1_tb.Location = new System.Drawing.Point(6, 19);
			this.ip1_tb.Name = "ip1_tb";
			this.ip1_tb.Size = new System.Drawing.Size(204, 20);
			this.ip1_tb.TabIndex = 0;
			this.ip1_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ip2_tb
			// 
			this.ip2_tb.Enabled = false;
			this.ip2_tb.Location = new System.Drawing.Point(6, 45);
			this.ip2_tb.Name = "ip2_tb";
			this.ip2_tb.Size = new System.Drawing.Size(204, 20);
			this.ip2_tb.TabIndex = 1;
			this.ip2_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ip3_tb
			// 
			this.ip3_tb.Enabled = false;
			this.ip3_tb.Location = new System.Drawing.Point(6, 71);
			this.ip3_tb.Name = "ip3_tb";
			this.ip3_tb.Size = new System.Drawing.Size(204, 20);
			this.ip3_tb.TabIndex = 2;
			this.ip3_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(268, 488);
			this.Controls.Add(this.IP);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.status_bar);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "Netmeter";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.killswitch);
			this.Load += new System.EventHandler(this.startup);
			this.status_bar.ResumeLayout(false);
			this.status_bar.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.IP.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.IPs.ResumeLayout(false);
			this.IPs.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox ip3_tb;
		private System.Windows.Forms.TextBox ip2_tb;
		private System.Windows.Forms.TextBox ip1_tb;
		private System.Windows.Forms.TextBox ip4_tb;
		private System.Windows.Forms.GroupBox IPs;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox to_msec_tb;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox IP;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ProgressBar GO_PB;
		private System.Windows.Forms.ProgressBar RT_PB;
		private System.Windows.Forms.ProgressBar FB_PB;
		private System.Windows.Forms.ProgressBar TP_PB;
		private System.Windows.Forms.ToolStripStatusLabel timeoutcounter;
		private System.Windows.Forms.ToolStripStatusLabel runtime_label;
		private System.Windows.Forms.StatusStrip status_bar;
		private System.Windows.Forms.TextBox google_timeout;
		private System.Windows.Forms.TextBox google_ping;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox root_timeout;
		private System.Windows.Forms.TextBox root_ping;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox fritz_timeout;
		private System.Windows.Forms.TextBox fritz_ping;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tp_timeout;
		private System.Windows.Forms.TextBox tp_ping;
	}
}
