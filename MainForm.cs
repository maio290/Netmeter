using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;

namespace Netmeter_Win_App
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
			bool start = true;
			int min_i1 = 1000;
			int max_i1 = 0;
			int min_i2 = 1000;
			int max_i2 = 0;
			int min_e1 = 1000;
			int max_e1 = 0;
			int min_e2 = 1000;
			int max_e2 = 0;
			
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		}
		
			

			
			
		System.Threading.Thread net;
		void startup(object sender, EventArgs e)
		{

			net = new System.Threading.Thread(ping_loop);
			net.Start();
				
		}
		
		public void ping_loop()
			
		{
			Ping pingSender = new Ping();
			PingOptions options = new PingOptions();
			options.DontFragment = true;
			
			//TODO: Make IPs changeable from MainForm
			string ip_internal = "127.0.0.1";
			string ip_internal2 = "192.168.178.1";
			string ip_external = "88.198.33.89";
			string ip_external2 = "173.194.44.47";
			string tp_text = "";
			string fb_text = "";
			string rt_text = "";
			string g_text = "";
			string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            byte[] buffer = Encoding.ASCII.GetBytes (data);
            int timeout = 1000;
            to_msec_tb.Text = Convert.ToString(timeout);
            ip1_tb.Text = ip_internal;
            ip2_tb.Text = ip_internal2;
            ip3_tb.Text = ip_external;
            ip4_tb.Text = ip_external2;
            int timeout_i1 = 0;
            int timeout_i2 = 0;
            int timeout_e1 = 0;
            int timeout_e2 = 0;
			int tickcounter = 0;
			int s = 0;
			int m = 0;
			int h = 0;
			
	
            
            
			while (start == true)
			{
				// Ping-Commands
				PingReply internal_1 = pingSender.Send (ip_internal, timeout, buffer, options);
           		PingReply internal_2 = pingSender.Send (ip_internal2, timeout, buffer, options);
           		PingReply external_1 = pingSender.Send (ip_external, timeout, buffer, options);
           		PingReply external_2 = pingSender.Send (ip_external2, timeout, buffer, options);
           		
           		// Input_Definer
           		
           		// TP-LINK
				 if (internal_1.Status == IPStatus.Success)
				 {
				 	if(internal_1.RoundtripTime >= max_i1) 
				 	{max_i1 = Convert.ToInt32(internal_1.RoundtripTime);}
					if(internal_1.RoundtripTime <= min_i1) 
					{min_i1 = Convert.ToInt32(internal_1.RoundtripTime);}
					
					TP_PB.Value = 100;
					if (internal_1.RoundtripTime <= 60)
					{TP_PB.ForeColor = Color.Green;}
					else if (internal_1.RoundtripTime <= 80)
					{TP_PB.ForeColor = Color.Yellow;}
					else if (internal_1.RoundtripTime <=100)
					{TP_PB.ForeColor = Color.Orange;}
					else {TP_PB.ForeColor = Color.Red;}
					
				 	tp_text = internal_1.RoundtripTime + " ms";
				 	
				 }
		
				 else
				 {
				 	tp_text = "TIMEOUT";
				 	timeout_i1++;
				 }
				 
				  // Fritz-Box
				 if (internal_2.Status == IPStatus.Success)
				 {
				 	if(internal_2.RoundtripTime >= max_i2) 
				 	{max_i2 = Convert.ToInt32(internal_2.RoundtripTime);}
					if(internal_2.RoundtripTime <= min_i2) 
					{min_i2 = Convert.ToInt32(internal_2.RoundtripTime);}
					
					FB_PB.Value = 100;
					if (internal_2.RoundtripTime <= 60)
					{FB_PB.ForeColor = Color.Green;}
					else if (internal_2.RoundtripTime <= 80)
					{FB_PB.ForeColor = Color.Yellow;}
					else if (internal_2.RoundtripTime <=100)
					{FB_PB.ForeColor = Color.Orange;}
					else {FB_PB.ForeColor = Color.Red;}
					
				 	fb_text = internal_2.RoundtripTime + " ms"; 	
				 }
				 else
				 {
				 	fb_text = "TIMEOUT";	
				 	timeout_i2++;
				 }
				  // Root
				 if (external_1.Status == IPStatus.Success)
				 {
				 	if(external_1.RoundtripTime >= max_e1) 
				 	{max_e1 = Convert.ToInt32(external_1.RoundtripTime);}
					if(external_1.RoundtripTime <= min_e1) 
					{min_e1 = Convert.ToInt32(external_1.RoundtripTime);}
					
					RT_PB.Value = 100;
					if (external_1.RoundtripTime <= 60)
					{RT_PB.ForeColor = Color.Green;}
					else if (external_1.RoundtripTime <= 80)
					{RT_PB.ForeColor = Color.Yellow;}
					else if (external_1.RoundtripTime <=100)
					{RT_PB.ForeColor = Color.Orange;}
					else {RT_PB.ForeColor = Color.Red;}
					
				 	rt_text = external_1.RoundtripTime + " ms";
				 }
				 else
				 {
				 	rt_text = "TIMEOUT";
				 	timeout_e1++;
				 }
				 
				 // Google
				 if (external_2.Status == IPStatus.Success)
				 {
				 	if(external_2.RoundtripTime >= max_e2) 
				 	{max_e2 = Convert.ToInt32(external_2.RoundtripTime);}
					if(external_2.RoundtripTime <= min_e2) 
					{min_e2 = Convert.ToInt32(external_2.RoundtripTime);}
					
					GO_PB.Value = 100;
					if (external_2.RoundtripTime <= 60)
					{GO_PB.ForeColor = Color.Green;}
					else if (external_2.RoundtripTime <= 80)
					{GO_PB.ForeColor = Color.Yellow;}
					else if (external_2.RoundtripTime <=100)
					{GO_PB.ForeColor = Color.Orange;}
					else {GO_PB.ForeColor = Color.Red;}
					
				 	g_text = external_2.RoundtripTime + " ms";
				 }
				 else
				 {
				 	g_text = "TIMEOUT";
				 	timeout_e2++;
				 }
				 
				 // Tickcounter
				 // TODO: Using time method instead of ticks due to timeout risk.
				 
				 tickcounter++;
				 
				 if(tickcounter >= 60)
				 {
				 	if(tickcounter >= 3600)
				 	{
						h = tickcounter/3600;
				 		m = (tickcounter - h*3600)/60;
				 		s = tickcounter - (h*3600) - (m*60);
				 	}
				 	else
				 	{
				 		m = tickcounter/60;
				 		s = tickcounter - m*60;
				 		
				 	}
				 }
				 else
				 {
				 	s = tickcounter;
				 }
				 
				 
				 
				
				 
				 // MI
				 
				 MethodInvoker mi = delegate()
				 	
				 {
				 	runtime_label.Text = "["+h.ToString("00")+":"+m.ToString("00")+":"+s.ToString("00")+"]";
				 	timeoutcounter.Text = timeout_i1 + timeout_i2 + timeout_e1 + timeout_e2 + "x";
				 	tp_ping.Text = tp_text;
				 	fritz_ping.Text = fb_text;
				 	root_ping.Text = rt_text;
				 	google_ping.Text = g_text;
				 	
				 	tp_timeout.Text = timeout_i1.ToString() + "x";
				 	fritz_timeout.Text = timeout_i2.ToString() + "x";
				 	root_timeout.Text = timeout_e1.ToString() + "x";
				 	google_timeout.Text = timeout_e2.ToString() + "x";
				 	

				 };
				 this.Invoke(mi);
				 
				 // Sleep
				 System.Threading.Thread.Sleep(1000);
			}
		}


		
		void Label3Click(object sender, EventArgs e)
		{
			MessageBox.Show(Convert.ToString("Minimum: " + min_i1 + " ms - Maximum: " + max_i1 + " ms"),"Ping: TP-Link Router", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
		}
		
		void Label4Click(object sender, EventArgs e)
		{
			MessageBox.Show(Convert.ToString("Minimum: " + min_i2 + " ms - Maximum: " + max_i2 + " ms"),"Ping: Fritz Box", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
		}
		
		void Label5Click(object sender, EventArgs e)
		{
			MessageBox.Show(Convert.ToString("Minimum: " + min_e1 + " ms - Maximum: " + max_e1 + " ms"),"Ping: Root", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
		}
		
		void Label6Click(object sender, EventArgs e)
		{
			MessageBox.Show(Convert.ToString("Minimum: " + min_e2 + " ms - Maximum: " + max_e2 + " ms"),"Ping: Google (DE)", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
		}
		
		void killswitch(object sender, FormClosingEventArgs e)
		{
			start = false;
			System.Threading.Thread.Sleep(10);
			net.Abort();
		}
			}
		}

		
		

