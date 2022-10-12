﻿using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using MILLENIUMV2._1.Properties;
using Newtonsoft.Json;

namespace MILLENIUMV2._1
{
	// Token: 0x02000006 RID: 6
	public partial class Form1 : Form
	{
		// Token: 0x06000012 RID: 18 RVA: 0x000027F4 File Offset: 0x000009F4
		public Form1()
		{
			this.InitializeComponent();
			base.StartPosition = FormStartPosition.CenterScreen;
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000013 RID: 19 RVA: 0x0000225C File Offset: 0x0000045C
		// (set) Token: 0x06000014 RID: 20 RVA: 0x00002820 File Offset: 0x00000A20
		public object SelectedItem { get; set; }

		// Token: 0x06000015 RID: 21
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x06000016 RID: 22
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		// Token: 0x06000017 RID: 23 RVA: 0x00002834 File Offset: 0x00000A34
		private void Form1_Load(object sender, EventArgs e)
		{
			string redsaved = Settings.Default.redsaved;
			int num = int.Parse(redsaved);
			string greensaved = Settings.Default.greensaved;
			int num2 = int.Parse(greensaved);
			string bluesaved = Settings.Default.bluesaved;
			int num3 = int.Parse(bluesaved);
			this.label2.BackColor = Color.FromArgb(num, num2, num3);
			this.panel1.BackColor = Color.FromArgb(num, num2, num3);
			this.label13.BackColor = Color.FromArgb(num, num2, num3);
			this.label14.BackColor = Color.FromArgb(num, num2, num3);
			this.label7.ForeColor = Color.FromArgb(num, num2, num3);
			this.label11.ForeColor = Color.FromArgb(num, num2, num3);
			this.button5.BackColor = Color.FromArgb(num, num2, num3);
			this.button9.BackColor = Color.FromArgb(num, num2, num3);
			this.button6.BackColor = Color.FromArgb(num, num2, num3);
			this.button3.BackColor = Color.FromArgb(num, num2, num3);
			this.button11.BackColor = Color.FromArgb(num, num2, num3);
			this.button13.BackColor = Color.FromArgb(num, num2, num3);
			this.button14.BackColor = Color.FromArgb(num, num2, num3);
			this.button10.BackColor = Color.FromArgb(num, num2, num3);
			this.button7.BackColor = Color.FromArgb(num, num2, num3);
			this.button4.BackColor = Color.FromArgb(num, num2, num3);
			this.label12.ForeColor = Color.FromArgb(num, num2, num3);
			this.label18.ForeColor = Color.FromArgb(num, num2, num3);
			this.panel8.BackColor = Color.FromArgb(num, num2, num3);
			this.RED.Value = num;
			this.GREEN.Value = num2;
			this.BLUE.Value = num3;
			this.textBox1.Text = this.trackBar1.Maximum.ToString();
			this.textBox2.Text = this.oaHgbMrnne.Maximum.ToString();
			this.label10.Text = Settings.Default.keybind;
			this.comboBox1.SelectedItem = this.label10.Text;
			this.string_3 = Settings.Default.custompid;
			if (this.label10.Text == "Num Lock")
			{
				Form1.uint_0 = 144U;
			}
			if (this.label10.Text == "Caps Lock")
			{
				Form1.uint_0 = 20U;
			}
			if (this.label10.Text == "Insert")
			{
				Form1.uint_0 = 45U;
			}
			if (this.label10.Text == "Tab")
			{
				Form1.uint_0 = 9U;
			}
			if (this.label10.Text == "Delete")
			{
				Form1.uint_0 = 46U;
			}
			if (this.label10.Text == "F1")
			{
				Form1.uint_0 = 112U;
			}
			if (this.label10.Text == "F2")
			{
				Form1.uint_0 = 113U;
			}
			if (this.label10.Text == "F3")
			{
				Form1.uint_0 = 114U;
			}
			if (this.label10.Text == "F4")
			{
				Form1.uint_0 = 115U;
			}
			if (this.label10.Text == "F5")
			{
				Form1.uint_0 = 116U;
			}
			if (this.label10.Text == "F6")
			{
				Form1.uint_0 = 117U;
			}
			if (this.label10.Text == "F7")
			{
				Form1.uint_0 = 118U;
			}
			if (this.label10.Text == "F8")
			{
				Form1.uint_0 = 119U;
			}
			if (this.label10.Text == "F9")
			{
				Form1.uint_0 = 120U;
			}
			if (this.label10.Text == "F10")
			{
				Form1.uint_0 = 121U;
			}
			if (this.label10.Text == "F11")
			{
				Form1.uint_0 = 122U;
			}
			if (this.label10.Text == "F12")
			{
				Form1.uint_0 = 123U;
			}
			if (this.label10.Text == "0")
			{
				Form1.uint_0 = 48U;
			}
			if (this.label10.Text == "1")
			{
				Form1.uint_0 = 49U;
			}
			if (this.label10.Text == "2")
			{
				Form1.uint_0 = 50U;
			}
			if (this.label10.Text == "3")
			{
				Form1.uint_0 = 51U;
			}
			if (this.label10.Text == "4")
			{
				Form1.uint_0 = 52U;
			}
			if (this.label10.Text == "5")
			{
				Form1.uint_0 = 53U;
			}
			if (this.label10.Text == "6")
			{
				Form1.uint_0 = 54U;
			}
			if (this.label10.Text == "7")
			{
				Form1.uint_0 = 55U;
			}
			if (this.label10.Text == "8")
			{
				Form1.uint_0 = 56U;
			}
			if (this.label10.Text == "9")
			{
				Form1.uint_0 = 57U;
			}
			if (this.label10.Text == "Home")
			{
				Form1.uint_0 = 36U;
			}
			if (this.label10.Text == "A")
			{
				Form1.uint_0 = 65U;
			}
			if (this.label10.Text == "B")
			{
				Form1.uint_0 = 66U;
			}
			if (this.label10.Text == "C")
			{
				Form1.uint_0 = 67U;
			}
			if (this.label10.Text == "D")
			{
				Form1.uint_0 = 68U;
			}
			if (this.label10.Text == "E")
			{
				Form1.uint_0 = 69U;
			}
			if (this.label10.Text == "F")
			{
				Form1.uint_0 = 70U;
			}
			if (this.label10.Text == "G")
			{
				Form1.uint_0 = 71U;
			}
			if (this.label10.Text == "H")
			{
				Form1.uint_0 = 72U;
			}
			if (this.label10.Text == "I")
			{
				Form1.uint_0 = 73U;
			}
			if (this.label10.Text == "J")
			{
				Form1.uint_0 = 74U;
			}
			if (this.label10.Text == "K")
			{
				Form1.uint_0 = 75U;
			}
			if (this.label10.Text == "L")
			{
				Form1.uint_0 = 76U;
			}
			if (this.label10.Text == "M")
			{
				Form1.uint_0 = 77U;
			}
			if (this.label10.Text == "N")
			{
				Form1.uint_0 = 78U;
			}
			if (this.label10.Text == "O")
			{
				Form1.uint_0 = 79U;
			}
			if (this.label10.Text == "P")
			{
				Form1.uint_0 = 80U;
			}
			if (this.label10.Text == "Q")
			{
				Form1.uint_0 = 81U;
			}
			if (this.label10.Text == "R")
			{
				Form1.uint_0 = 82U;
			}
			if (this.label10.Text == "S")
			{
				Form1.uint_0 = 83U;
			}
			if (this.label10.Text == "T")
			{
				Form1.uint_0 = 84U;
			}
			if (this.label10.Text == "U")
			{
				Form1.uint_0 = 85U;
			}
			if (this.label10.Text == "V")
			{
				Form1.uint_0 = 86U;
			}
			if (this.label10.Text == "W")
			{
				Form1.uint_0 = 87U;
			}
			if (this.label10.Text == "X")
			{
				Form1.uint_0 = 88U;
			}
			if (this.label10.Text == "Y")
			{
				Form1.uint_0 = 89U;
			}
			if (this.label10.Text == "Z")
			{
				Form1.uint_0 = 90U;
			}
			if (this.label10.Text == "Up Key")
			{
				Form1.uint_0 = 38U;
			}
			if (this.label10.Text == "Down Key")
			{
				Form1.uint_0 = 40U;
			}
			if (this.label10.Text == "Left Key")
			{
				Form1.uint_0 = 37U;
			}
			if (this.label10.Text == "Right Key")
			{
				Form1.uint_0 = 39U;
			}
			this.checkBox2.Checked = true;
			this.checkBox3.Checked = true;
			this.thread_0 = new Thread(new ThreadStart(this.Loop));
			this.thread_0.Start();
			this.timer_0.Start();
			this.timer_1.Start();
			this.timer_2.Start();
			this.timer_3.Start();
			this.timer_5.Start();
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00003204 File Offset: 0x00001404
		private void method_0()
		{
			int value = this.oaHgbMrnne.Value;
			int value2 = this.trackBar1.Value;
			int value3 = this.trackBar4.Value;
			int value4 = this.trackBar3.Value;
			Form1.sleeptime = value;
			Form1.strength = value2;
			Form1.sleeptime2 = value3;
			Form1.strength2 = value4;
		}

		// Token: 0x06000019 RID: 25
		[DllImport("user32")]
		public static extern int SetCursorPos(int x, int y);

		// Token: 0x0600001A RID: 26
		[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
		public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

		// Token: 0x0600001B RID: 27
		[DllImport("user32.dll", SetLastError = true)]
		public static extern bool PostMessage(int hWnd, uint Msg, int wParam, int lParam);

		// Token: 0x0600001C RID: 28 RVA: 0x00003264 File Offset: 0x00001464
		public void Loop()
		{
			for (;;)
			{
				Control.CheckForIllegalCrossThreadCalls = false;
				if (((int)Class3.GetKeyState(Form1.uint_0) & 32768) > 0)
				{
					Form1.Enabled = !Form1.Enabled;
					if (Form1.Enabled)
					{
						Class3.Beep(800U, 500U);
					}
					else
					{
						Class3.Beep(300U, 500U);
					}
				}
				Thread.Sleep(1);
				if (Form1.Enabled)
				{
					if (this.checkBox3.Checked)
					{
						Form1.uint_1 = 2U;
					}
					else
					{
						Form1.uint_1 = 1U;
					}
					if (!this.checkBox2.Checked)
					{
						if (((int)Class3.GetKeyState(Form1.uint_1) & 32768) > 0 && ((int)Class3.GetKeyState(1U) & 32768) > 0)
						{
							if (this.checkBox4.Checked)
							{
								if (this.string_2 == this.string_4)
								{
									Thread.Sleep(Form1.sleeptime);
									Class3.smethod_1(0, Form1.strength);
									Thread.Sleep(Form1.sleeptime2);
									Class3.smethod_1(Form1.strength2, 0);
								}
							}
							else
							{
								Thread.Sleep(Form1.sleeptime);
								Class3.smethod_1(0, Form1.strength);
								Thread.Sleep(Form1.sleeptime2);
								Class3.smethod_1(Form1.strength2, 0);
							}
						}
					}
					else if (((int)Class3.GetKeyState(Form1.uint_1) & 32768) > 0 && ((int)Class3.GetKeyState(1U) & 32768) > 0 && (this.string_2 == this.string_0 || this.string_2 == this.string_1))
					{
						Class3.smethod_1(0, Form1.strength);
						Thread.Sleep(Form1.sleeptime);
						Class3.smethod_1(Form1.strength2, 0);
						Thread.Sleep(Form1.sleeptime2);
					}
				}
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00003434 File Offset: 0x00001634
		private void label14_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00003448 File Offset: 0x00001648
		private void FlsUleWse(object sender, EventArgs e)
		{
			Settings.Default.Save();
			this.thread_0.Abort();
			Application.Exit();
			Environment.Exit(0);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00003478 File Offset: 0x00001678
		private void method_1(object sender, EventArgs e)
		{
			this.sDpgjoebc9.Text = "STRENGHT: " + this.trackBar1.Value.ToString();
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000034B0 File Offset: 0x000016B0
		private void oaHgbMrnne_ValueChanged(object sender, EventArgs e)
		{
			this.label4.Text = "SLOWNESS: " + this.oaHgbMrnne.Value.ToString();
			Form1.int_1 = this.oaHgbMrnne.Value;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000034F8 File Offset: 0x000016F8
		private void trackBar3_ValueChanged(object sender, EventArgs e)
		{
			string str;
			if (this.trackBar3.Value >= 0)
			{
				str = "RIGHT";
			}
			else
			{
				str = "LEFT";
			}
			this.label5.Text = "STRENGHT: " + this.trackBar3.Value.ToString() + " " + str;
			Form1.int_2 = this.trackBar3.Value;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x0000356C File Offset: 0x0000176C
		private void trackBar4_ValueChanged(object sender, EventArgs e)
		{
			this.label6.Text = "SLOWNESS: " + this.trackBar4.Value.ToString();
			Form1.int_0 = this.trackBar4.Value;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000035B4 File Offset: 0x000017B4
		private void button5_Click(object sender, EventArgs e)
		{
			Settings.Default.keybind = this.comboBox1.SelectedItem.ToString();
			Settings.Default.Save();
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000035E8 File Offset: 0x000017E8
		private void button9_Click(object sender, EventArgs e)
		{
			this.button8.FlatAppearance.BorderColor = Color.Red;
			this.button9.FlatAppearance.BorderColor = Color.Lime;
			if (this.comboBox2.SelectedIndex != -1)
			{
				this.opoutput.Text = this.comboBox2.SelectedItem.ToString();
				if (this.comboBox2.SelectedItem.ToString() == "ACE")
				{
					this.Valuesetter.Text = Settings.Default.ACEstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.ACEsleep;
					this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.ACEstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.ACEsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				if (this.comboBox2.SelectedItem.ToString() == "AMARU")
				{
					this.Valuesetter.Text = Settings.Default.AMARUstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.AMARUsleep;
					this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.AMARUstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.AMARUsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				if (this.comboBox2.SelectedItem.ToString() == "ASH")
				{
					this.Valuesetter.Text = Settings.Default.ASHstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.ASHsleep;
					this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.ASHstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.ASHsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				if (this.comboBox2.SelectedItem.ToString() == "BLACKBEARD")
				{
					this.Valuesetter.Text = Settings.Default.BLACKBEARDstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.BLACKBEARDsleep;
					this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.BLACKBEARDstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.BLACKBEARDsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				if (this.comboBox2.SelectedItem.ToString() == "BLITZ")
				{
					this.Valuesetter.Text = Settings.Default.BLITZstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.BLITZsleep;
					this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.BLITZstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.BLITZsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				if (this.comboBox2.SelectedItem.ToString() == "BUCK")
				{
					this.Valuesetter.Text = Settings.Default.BUCKstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.BUCKsleep;
					this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.BUCKstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.BUCKsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				if (this.comboBox2.SelectedItem.ToString() == "CAPITÃO")
				{
					this.Valuesetter.Text = Settings.Default.CAPITÃOstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.CAPITÃOsleep;
					this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.CAPITÃOstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.CAPITÃOsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				if (this.comboBox2.SelectedItem.ToString() == "DOKKAEBI")
				{
					this.Valuesetter.Text = Settings.Default.DOKKAEBIstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.DOKKAEBIsleep;
					this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.DOKKAEBIstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.DOKKAEBIsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				if (this.comboBox2.SelectedItem.ToString() == "FINKA")
				{
					this.Valuesetter.Text = Settings.Default.FINKAstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.FINKAsleep;
					this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.FINKAstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.FINKAsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				if (this.comboBox2.SelectedItem.ToString() == "FLORES")
				{
					this.Valuesetter.Text = Settings.Default.FLORESstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.FLORESsleep;
					this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.FLORESstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.FLORESsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				if (this.comboBox2.SelectedItem.ToString() == "FUZE")
				{
					this.Valuesetter.Text = Settings.Default.FUZEstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.FUZEsleep;
					this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.FUZEstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.FUZEsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				if (this.comboBox2.SelectedItem.ToString() == "GLAZ")
				{
					this.Valuesetter.Text = Settings.Default.GLAZstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.GLAZsleep;
					this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.GLAZstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.GLAZsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				if (this.comboBox2.SelectedItem.ToString() == "GRIDLOCK")
				{
					this.Valuesetter.Text = Settings.Default.GRIDLOCKstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.GRIDLOCKsleep;
					this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.GRIDLOCKstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.GRIDLOCKsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				if (this.comboBox2.SelectedItem.ToString() == "HIBANA")
				{
					this.Valuesetter.Text = Settings.Default.HIBANAstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.HIBANAsleep;
					this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.HIBANAstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.HIBANAsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				if (this.comboBox2.SelectedItem.ToString() == "IANA")
				{
					this.Valuesetter.Text = Settings.Default.IANAstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.IANAsleep;
					this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.IANAstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.IANAsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				if (this.comboBox2.SelectedItem.ToString() == "IQ")
				{
					this.Valuesetter.Text = Settings.Default.IQstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.IQsleep;
					this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.IQstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.IQsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				if (this.comboBox2.SelectedItem.ToString() == "JACKAL")
				{
					this.Valuesetter.Text = Settings.Default.JACKALstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.JACKALsleep;
					this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.JACKALstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.JACKALsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				if (this.comboBox2.SelectedItem.ToString() == "KALI")
				{
					this.Valuesetter.Text = Settings.Default.KALIstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.KALIsleep;
					this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.KALIstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.KALIsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				if (this.comboBox2.SelectedItem.ToString() == "LION")
				{
					this.Valuesetter.Text = Settings.Default.LIONstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.LIONsleep;
					this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.LIONstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.LIONsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				if (this.comboBox2.SelectedItem.ToString() == "MAVERICK")
				{
					this.Valuesetter.Text = Settings.Default.MAVERICKstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.MAVERICKsleep;
					this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.MAVERICKstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.MAVERICKsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				if (this.comboBox2.SelectedItem.ToString() == "MONTAGNE")
				{
					this.Valuesetter.Text = Settings.Default.MONTAGNEstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.MONTAGNEsleep;
					this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.MONTAGNEstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.MONTAGNEsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				if (this.comboBox2.SelectedItem.ToString() == "NOMAD")
				{
					this.Valuesetter.Text = Settings.Default.NOMADstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.NOMADsleep;
					this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.NOMADstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.NOMADsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				if (this.comboBox2.SelectedItem.ToString() == "NØKK")
				{
					this.Valuesetter.Text = Settings.Default.NØKKstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.NØKKsleep;
					this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.NØKKstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.NØKKsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				if (this.comboBox2.SelectedItem.ToString() == "OSA")
				{
					this.Valuesetter.Text = Settings.Default.OSAstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.OSAsleep;
					this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.OSAstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.OSAsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				if (this.comboBox2.SelectedItem.ToString() == "SENS")
				{
					this.Valuesetter.Text = Settings.Default.SENSstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.SENSsleep;
					this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.SENSstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.SENSsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				if (this.comboBox2.SelectedItem.ToString() == "SLEDGE")
				{
					this.Valuesetter.Text = Settings.Default.SLEDGEstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.SLEDGEsleep;
					this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.SLEDGEstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.SLEDGEsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				if (this.comboBox2.SelectedItem.ToString() == "THATCHER")
				{
					this.Valuesetter.Text = Settings.Default.THATCHERstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.THATCHERsleep;
					this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.THATCHERstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.THATCHERsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				if (this.comboBox2.SelectedItem.ToString() == "THERMITE")
				{
					this.Valuesetter.Text = Settings.Default.THERMITEstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.THERMITEsleep;
					this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.THERMITEstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.THERMITEsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				if (this.comboBox2.SelectedItem.ToString() == "TWITCH")
				{
					this.Valuesetter.Text = Settings.Default.TWITCHstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.TWITCHsleep;
					this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.TWITCHstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.TWITCHsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				if (this.comboBox2.SelectedItem.ToString() == "YING")
				{
					this.Valuesetter.Text = Settings.Default.YINGstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.YINGsleep;
					this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.YINGstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.YINGsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				if (this.comboBox2.SelectedItem.ToString() == "ZERO")
				{
					this.Valuesetter.Text = Settings.Default.ZEROstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.ZEROsleep;
					this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.ZEROstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.ZEROsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				if (this.comboBox2.SelectedItem.ToString() == "ZOFIA")
				{
					this.Valuesetter.Text = Settings.Default.ZOFIAstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.ZOFIAsleep;
					this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.ZOFIAstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.ZOFIAsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00005230 File Offset: 0x00003430
		private void button8_Click(object sender, EventArgs e)
		{
			this.button8.FlatAppearance.BorderColor = Color.Lime;
			this.button9.FlatAppearance.BorderColor = Color.Red;
			if (this.comboBox3.SelectedIndex != -1)
			{
				this.opoutput.Text = this.comboBox3.SelectedItem.ToString();
				if (this.comboBox3.SelectedItem.ToString() == "ALIBI")
				{
					this.Valuesetter.Text = Settings.Default.ALIBIstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.ALIBIsleep;
					this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.ALIBIstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.ALIBIsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				if (this.comboBox3.SelectedItem.ToString() == "ARUNI")
				{
					this.Valuesetter.Text = Settings.Default.ARUNIstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.ARUNIsleep;
					this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.ARUNIstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.ARUNIsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				if (this.comboBox3.SelectedItem.ToString() == "AZAMI")
				{
					this.Valuesetter.Text = Settings.Default.AZAMIstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.AZAMIsleep;
					this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.AZAMIstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.AZAMIsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				if (this.comboBox3.SelectedItem.ToString() == "BANDIT")
				{
					this.Valuesetter.Text = Settings.Default.BANDITstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.BANDITsleep;
					this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.BANDITstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.BANDITsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				if (this.comboBox3.SelectedItem.ToString() == "CASTLE")
				{
					this.Valuesetter.Text = Settings.Default.CASTLEstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.CASTLEsleep;
					this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.CASTLEstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.CASTLEsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				if (this.comboBox3.SelectedItem.ToString() == "CAVEIRA")
				{
					this.Valuesetter.Text = Settings.Default.CAVEIRAstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.CAVEIRAsleep;
					this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.CAVEIRAstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.CAVEIRAsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				if (this.comboBox3.SelectedItem.ToString() == "CLASH")
				{
					this.Valuesetter.Text = Settings.Default.CLASHstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.CLASHsleep;
					this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.CLASHstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.CLASHsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				if (this.comboBox3.SelectedItem.ToString() == "DOC")
				{
					this.Valuesetter.Text = Settings.Default.DOCstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.DOCsleep;
					this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.DOCstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.DOCsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				if (this.comboBox3.SelectedItem.ToString() == "ECHO")
				{
					this.Valuesetter.Text = Settings.Default.ECHOstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.ECHOsleep;
					this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.ECHOstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.ECHOsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				if (this.comboBox3.SelectedItem.ToString() == "ELA")
				{
					this.Valuesetter.Text = Settings.Default.ELAstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.ELAsleep;
					this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.ELAstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.ELAsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				if (this.comboBox3.SelectedItem.ToString() == "FROST")
				{
					this.Valuesetter.Text = Settings.Default.FROSTstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.FROSTsleep;
					this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.FROSTstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.FROSTsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				if (this.comboBox3.SelectedItem.ToString() == "GOYO")
				{
					this.Valuesetter.Text = Settings.Default.GOYOstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.GOYOsleep;
					this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.GOYOstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.GOYOsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				if (this.comboBox3.SelectedItem.ToString() == "JÄGER")
				{
					this.Valuesetter.Text = Settings.Default.JÄGERstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.JÄGERsleep;
					this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.JÄGERstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.JÄGERsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				if (this.comboBox3.SelectedItem.ToString() == "KAID")
				{
					this.Valuesetter.Text = Settings.Default.KAIDstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.KAIDsleep;
					this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.KAIDstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.KAIDsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				if (this.comboBox3.SelectedItem.ToString() == "KAPKAN")
				{
					this.Valuesetter.Text = Settings.Default.KAPKANstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.KAPKANsleep;
					this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.KAPKANstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.KAPKANsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				if (this.comboBox3.SelectedItem.ToString() == "LESION")
				{
					this.Valuesetter.Text = Settings.Default.LESIONstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.LESIONsleep;
					this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.LESIONstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.LESIONsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				if (this.comboBox3.SelectedItem.ToString() == "MAESTRO")
				{
					this.Valuesetter.Text = Settings.Default.MAESTROstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.MAESTROsleep;
					this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.MAESTROstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.MAESTROsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				if (this.comboBox3.SelectedItem.ToString() == "MELUSI")
				{
					this.Valuesetter.Text = Settings.Default.MELUSIstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.MELUSIsleep;
					this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.MELUSIstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.MELUSIsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				if (this.comboBox3.SelectedItem.ToString() == "MIRA")
				{
					this.Valuesetter.Text = Settings.Default.MIRAstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.MIRAsleep;
					this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.MIRAstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.MIRAsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				if (this.comboBox3.SelectedItem.ToString() == "MOZZIE")
				{
					this.Valuesetter.Text = Settings.Default.MOZZIEstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.MOZZIEsleep;
					this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.MOZZIEstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.MOZZIEsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				if (this.comboBox3.SelectedItem.ToString() == "MUTE")
				{
					this.Valuesetter.Text = Settings.Default.MUTEstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.MUTEsleep;
					this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.MUTEstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.MUTEsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				if (this.comboBox3.SelectedItem.ToString() == "ORYX")
				{
					this.Valuesetter.Text = Settings.Default.ORYXstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.ORYXsleep;
					this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.ORYXstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.ORYXsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				if (this.comboBox3.SelectedItem.ToString() == "PULSE")
				{
					this.Valuesetter.Text = Settings.Default.PULSEstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.PULSEsleep;
					this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.PULSEstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.PULSEsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				if (this.comboBox3.SelectedItem.ToString() == "ROOK")
				{
					this.Valuesetter.Text = Settings.Default.ROOKstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.ROOKsleep;
					this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.ROOKstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.ROOKsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				if (this.comboBox3.SelectedItem.ToString() == "SMOKE")
				{
					this.Valuesetter.Text = Settings.Default.SMOKEstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.SMOKEsleep;
					this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.SMOKEstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.SMOKEsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				if (this.comboBox3.SelectedItem.ToString() == "TACHANKA")
				{
					this.Valuesetter.Text = Settings.Default.TACHANKAstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.TACHANKAsleep;
					this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.TACHANKAstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.TACHANKAsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				if (this.comboBox3.SelectedItem.ToString() == "THORN")
				{
					this.Valuesetter.Text = Settings.Default.THORNstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.THORNsleep;
					this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.THORNstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.THORNsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				if (this.comboBox3.SelectedItem.ToString() == "THUNDERBIRD")
				{
					this.Valuesetter.Text = Settings.Default.THUNDERBIRDstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.THUNDERBIRDsleep;
					this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.THUNDERBIRDstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.THUNDERBIRDsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				if (this.comboBox3.SelectedItem.ToString() == "VALKYRIE")
				{
					this.Valuesetter.Text = Settings.Default.VALKYRIEstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.VALKYRIEsleep;
					this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.VALKYRIEstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.VALKYRIEsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				if (this.comboBox3.SelectedItem.ToString() == "VIGIL")
				{
					this.Valuesetter.Text = Settings.Default.VIGILstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.VIGILsleep;
					this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.VIGILstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.VIGILsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				if (this.comboBox3.SelectedItem.ToString() == "WAMAI")
				{
					this.Valuesetter.Text = Settings.Default.WAMAIstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.WAMAIsleep;
					this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.WAMAIstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.WAMAIsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				if (this.comboBox3.SelectedItem.ToString() == "WARDEN")
				{
					this.Valuesetter.Text = Settings.Default.WARDENstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.WARDENsleep;
					this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.WARDENstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.WARDENsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00006E78 File Offset: 0x00005078
		private void button6_Click(object sender, EventArgs e)
		{
			if (this.comboBox2.SelectedIndex != -1)
			{
				if (this.comboBox2.SelectedItem.ToString() == "ACE")
				{
					Settings.Default.ACEstrenght = this.trackBar1.Value.ToString();
					Settings.Default.ACEstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.ACEsleep = this.oaHgbMrnne.Value.ToString();
					Settings.Default.ACEsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				if (this.comboBox2.SelectedItem.ToString() == "AMARU")
				{
					Settings.Default.AMARUstrenght = this.trackBar1.Value.ToString();
					Settings.Default.AMARUstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.AMARUsleep = this.oaHgbMrnne.Value.ToString();
					Settings.Default.AMARUsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				if (this.comboBox2.SelectedItem.ToString() == "ASH")
				{
					Settings.Default.ASHstrenght = this.trackBar1.Value.ToString();
					Settings.Default.ASHsleep = this.oaHgbMrnne.Value.ToString();
					Settings.Default.ASHstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.ASHsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				if (this.comboBox2.SelectedItem.ToString() == "BLACKBEARD")
				{
					Settings.Default.BLACKBEARDstrenght = this.trackBar1.Value.ToString();
					Settings.Default.BLACKBEARDsleep = this.oaHgbMrnne.Value.ToString();
					Settings.Default.BLACKBEARDstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.BLACKBEARDsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				if (this.comboBox2.SelectedItem.ToString() == "BLITZ")
				{
					Settings.Default.BLITZstrenght = this.trackBar1.Value.ToString();
					Settings.Default.BLITZsleep = this.oaHgbMrnne.Value.ToString();
					Settings.Default.BLITZstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.BLITZsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				if (this.comboBox2.SelectedItem.ToString() == "BUCK")
				{
					Settings.Default.BUCKstrenght = this.trackBar1.Value.ToString();
					Settings.Default.BUCKsleep = this.oaHgbMrnne.Value.ToString();
					Settings.Default.BUCKstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.BUCKsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				if (this.comboBox2.SelectedItem.ToString() == "CAPITÃO")
				{
					Settings.Default.CAPITÃOstrenght = this.trackBar1.Value.ToString();
					Settings.Default.CAPITÃOsleep = this.oaHgbMrnne.Value.ToString();
					Settings.Default.CAPITÃOstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.CAPITÃOsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				if (this.comboBox2.SelectedItem.ToString() == "DOKKAEBI")
				{
					Settings.Default.DOKKAEBIstrenght = this.trackBar1.Value.ToString();
					Settings.Default.DOKKAEBIsleep = this.oaHgbMrnne.Value.ToString();
					Settings.Default.DOKKAEBIstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.DOKKAEBIsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				if (this.comboBox2.SelectedItem.ToString() == "FINKA")
				{
					Settings.Default.FINKAstrenght = this.trackBar1.Value.ToString();
					Settings.Default.FINKAsleep = this.oaHgbMrnne.Value.ToString();
					Settings.Default.FINKAstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.FINKAsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				if (this.comboBox2.SelectedItem.ToString() == "FLORES")
				{
					Settings.Default.FLORESstrenght = this.trackBar1.Value.ToString();
					Settings.Default.FLORESsleep = this.oaHgbMrnne.Value.ToString();
					Settings.Default.FLORESstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.FLORESsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				if (this.comboBox2.SelectedItem.ToString() == "FUZE")
				{
					Settings.Default.FUZEstrenght = this.trackBar1.Value.ToString();
					Settings.Default.FUZEsleep = this.oaHgbMrnne.Value.ToString();
					Settings.Default.FUZEstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.FUZEsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				if (this.comboBox2.SelectedItem.ToString() == "GLAZ")
				{
					Settings.Default.GLAZstrenght = this.trackBar1.Value.ToString();
					Settings.Default.GLAZsleep = this.oaHgbMrnne.Value.ToString();
					Settings.Default.GLAZstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.GLAZsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				if (this.comboBox2.SelectedItem.ToString() == "GRIDLOCK")
				{
					Settings.Default.GRIDLOCKstrenght = this.trackBar1.Value.ToString();
					Settings.Default.GRIDLOCKsleep = this.oaHgbMrnne.Value.ToString();
					Settings.Default.GRIDLOCKstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.GRIDLOCKsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				if (this.comboBox2.SelectedItem.ToString() == "HIBANA")
				{
					Settings.Default.HIBANAstrenght = this.trackBar1.Value.ToString();
					Settings.Default.HIBANAsleep = this.oaHgbMrnne.Value.ToString();
					Settings.Default.HIBANAstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.HIBANAsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				if (this.comboBox2.SelectedItem.ToString() == "IANA")
				{
					Settings.Default.IANAstrenght = this.trackBar1.Value.ToString();
					Settings.Default.IANAsleep = this.oaHgbMrnne.Value.ToString();
					Settings.Default.IANAstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.IANAsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				if (this.comboBox2.SelectedItem.ToString() == "IQ")
				{
					Settings.Default.IQstrenght = this.trackBar1.Value.ToString();
					Settings.Default.IQsleep = this.oaHgbMrnne.Value.ToString();
					Settings.Default.IQstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.IQsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				if (this.comboBox2.SelectedItem.ToString() == "JACKAL")
				{
					Settings.Default.JACKALstrenght = this.trackBar1.Value.ToString();
					Settings.Default.JACKALsleep = this.oaHgbMrnne.Value.ToString();
					Settings.Default.JACKALstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.JACKALsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				if (this.comboBox2.SelectedItem.ToString() == "KALI")
				{
					Settings.Default.KALIstrenght = this.trackBar1.Value.ToString();
					Settings.Default.KALIsleep = this.oaHgbMrnne.Value.ToString();
					Settings.Default.KALIstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.KALIsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				if (this.comboBox2.SelectedItem.ToString() == "LION")
				{
					Settings.Default.LIONstrenght = this.trackBar1.Value.ToString();
					Settings.Default.LIONsleep = this.oaHgbMrnne.Value.ToString();
					Settings.Default.LIONstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.LIONsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				if (this.comboBox2.SelectedItem.ToString() == "MAVERICK")
				{
					Settings.Default.MAVERICKstrenght = this.trackBar1.Value.ToString();
					Settings.Default.MAVERICKsleep = this.oaHgbMrnne.Value.ToString();
					Settings.Default.MAVERICKstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.MAVERICKsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				if (this.comboBox2.SelectedItem.ToString() == "MONTAGNE")
				{
					Settings.Default.MONTAGNEstrenght = this.trackBar1.Value.ToString();
					Settings.Default.MONTAGNEsleep = this.oaHgbMrnne.Value.ToString();
					Settings.Default.MONTAGNEstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.MONTAGNEsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				if (this.comboBox2.SelectedItem.ToString() == "NOMAD")
				{
					Settings.Default.NOMADstrenght = this.trackBar1.Value.ToString();
					Settings.Default.NOMADsleep = this.oaHgbMrnne.Value.ToString();
					Settings.Default.NOMADstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.NOMADsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				if (this.comboBox2.SelectedItem.ToString() == "NØKK")
				{
					Settings.Default.NØKKstrenght = this.trackBar1.Value.ToString();
					Settings.Default.NØKKsleep = this.oaHgbMrnne.Value.ToString();
					Settings.Default.NØKKstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.NØKKsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				if (this.comboBox2.SelectedItem.ToString() == "OSA")
				{
					Settings.Default.OSAstrenght = this.trackBar1.Value.ToString();
					Settings.Default.OSAsleep = this.oaHgbMrnne.Value.ToString();
					Settings.Default.OSAstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.OSAsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				if (this.comboBox2.SelectedItem.ToString() == "SENS")
				{
					Settings.Default.SENSstrenght = this.trackBar1.Value.ToString();
					Settings.Default.SENSsleep = this.oaHgbMrnne.Value.ToString();
					Settings.Default.SENSstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.SENSsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				if (this.comboBox2.SelectedItem.ToString() == "SLEDGE")
				{
					Settings.Default.SLEDGEstrenght = this.trackBar1.Value.ToString();
					Settings.Default.SLEDGEsleep = this.oaHgbMrnne.Value.ToString();
					Settings.Default.SLEDGEstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.SLEDGEsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				if (this.comboBox2.SelectedItem.ToString() == "THATCHER")
				{
					Settings.Default.THATCHERstrenght = this.trackBar1.Value.ToString();
					Settings.Default.THATCHERsleep = this.oaHgbMrnne.Value.ToString();
					Settings.Default.THATCHERstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.THATCHERsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				if (this.comboBox2.SelectedItem.ToString() == "THERMITE")
				{
					Settings.Default.THERMITEstrenght = this.trackBar1.Value.ToString();
					Settings.Default.THERMITEsleep = this.oaHgbMrnne.Value.ToString();
					Settings.Default.THERMITEstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.THERMITEsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				if (this.comboBox2.SelectedItem.ToString() == "TWITCH")
				{
					Settings.Default.TWITCHstrenght = this.trackBar1.Value.ToString();
					Settings.Default.TWITCHsleep = this.oaHgbMrnne.Value.ToString();
					Settings.Default.TWITCHstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.TWITCHsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				if (this.comboBox2.SelectedItem.ToString() == "YING")
				{
					Settings.Default.YINGstrenght = this.trackBar1.Value.ToString();
					Settings.Default.YINGsleep = this.oaHgbMrnne.Value.ToString();
					Settings.Default.YINGstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.YINGsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				if (this.comboBox2.SelectedItem.ToString() == "ZERO")
				{
					Settings.Default.ZEROstrenght = this.trackBar1.Value.ToString();
					Settings.Default.ZEROsleep = this.oaHgbMrnne.Value.ToString();
					Settings.Default.ZEROstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.ZEROsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				if (this.comboBox2.SelectedItem.ToString() == "ZOFIA")
				{
					Settings.Default.ZOFIAstrenght = this.trackBar1.Value.ToString();
					Settings.Default.ZOFIAsleep = this.oaHgbMrnne.Value.ToString();
					Settings.Default.ZOFIAstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.ZOFIAsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000082B8 File Offset: 0x000064B8
		private void button3_Click(object sender, EventArgs e)
		{
			if (this.comboBox2.SelectedIndex != -1)
			{
				if (this.comboBox3.SelectedItem.ToString() == "ALIBI")
				{
					Settings.Default.ALIBIstrenght = this.trackBar1.Value.ToString();
					Settings.Default.ALIBIsleep = this.oaHgbMrnne.Value.ToString();
					Settings.Default.ALIBIstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.ALIBIsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				if (this.comboBox3.SelectedItem.ToString() == "ARUNI")
				{
					Settings.Default.ARUNIstrenght = this.trackBar1.Value.ToString();
					Settings.Default.ARUNIsleep = this.oaHgbMrnne.Value.ToString();
					Settings.Default.ARUNIstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.ARUNIsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				if (this.comboBox3.SelectedItem.ToString() == "AZAMI")
				{
					Settings.Default.AZAMIstrenght = this.trackBar1.Value.ToString();
					Settings.Default.AZAMIsleep = this.oaHgbMrnne.Value.ToString();
					Settings.Default.AZAMIstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.AZAMIsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				if (this.comboBox3.SelectedItem.ToString() == "BANDIT")
				{
					Settings.Default.BANDITstrenght = this.trackBar1.Value.ToString();
					Settings.Default.BANDITsleep = this.oaHgbMrnne.Value.ToString();
					Settings.Default.BANDITstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.BANDITsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				if (this.comboBox3.SelectedItem.ToString() == "CASTLE")
				{
					Settings.Default.CASTLEstrenght = this.trackBar1.Value.ToString();
					Settings.Default.CASTLEsleep = this.oaHgbMrnne.Value.ToString();
					Settings.Default.CASTLEstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.CASTLEsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				if (this.comboBox3.SelectedItem.ToString() == "CAVEIRA")
				{
					Settings.Default.CAVEIRAstrenght = this.trackBar1.Value.ToString();
					Settings.Default.CAVEIRAsleep = this.oaHgbMrnne.Value.ToString();
					Settings.Default.CAVEIRAstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.CAVEIRAsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				if (this.comboBox3.SelectedItem.ToString() == "CLASH")
				{
					Settings.Default.CLASHstrenght = this.trackBar1.Value.ToString();
					Settings.Default.CLASHsleep = this.oaHgbMrnne.Value.ToString();
					Settings.Default.CLASHstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.CLASHsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				if (this.comboBox3.SelectedItem.ToString() == "DOC")
				{
					Settings.Default.DOCstrenght = this.trackBar1.Value.ToString();
					Settings.Default.DOCsleep = this.oaHgbMrnne.Value.ToString();
					Settings.Default.DOCstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.DOCsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				if (this.comboBox3.SelectedItem.ToString() == "ECHO")
				{
					Settings.Default.ECHOstrenght = this.trackBar1.Value.ToString();
					Settings.Default.ECHOsleep = this.oaHgbMrnne.Value.ToString();
					Settings.Default.ECHOstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.ECHOsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				if (this.comboBox3.SelectedItem.ToString() == "ELA")
				{
					Settings.Default.ELAstrenght = this.trackBar1.Value.ToString();
					Settings.Default.ELAsleep = this.oaHgbMrnne.Value.ToString();
					Settings.Default.ELAstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.ELAsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				if (this.comboBox3.SelectedItem.ToString() == "FROST")
				{
					Settings.Default.FROSTstrenght = this.trackBar1.Value.ToString();
					Settings.Default.FROSTsleep = this.oaHgbMrnne.Value.ToString();
					Settings.Default.FROSTstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.FROSTsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				if (this.comboBox3.SelectedItem.ToString() == "GOYO")
				{
					Settings.Default.GOYOstrenght = this.trackBar1.Value.ToString();
					Settings.Default.GOYOsleep = this.oaHgbMrnne.Value.ToString();
					Settings.Default.GOYOstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.GOYOsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				if (this.comboBox3.SelectedItem.ToString() == "JÄGER")
				{
					Settings.Default.JÄGERstrenght = this.trackBar1.Value.ToString();
					Settings.Default.JÄGERsleep = this.oaHgbMrnne.Value.ToString();
					Settings.Default.JÄGERstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.JÄGERsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				if (this.comboBox3.SelectedItem.ToString() == "KAID")
				{
					Settings.Default.KAIDstrenght = this.trackBar1.Value.ToString();
					Settings.Default.KAIDsleep = this.oaHgbMrnne.Value.ToString();
					Settings.Default.KAIDstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.KAIDsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				if (this.comboBox3.SelectedItem.ToString() == "KAPKAN")
				{
					Settings.Default.KAPKANstrenght = this.trackBar1.Value.ToString();
					Settings.Default.KAPKANsleep = this.oaHgbMrnne.Value.ToString();
					Settings.Default.KAPKANstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.KAPKANsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				if (this.comboBox3.SelectedItem.ToString() == "LESION")
				{
					Settings.Default.LESIONstrenght = this.trackBar1.Value.ToString();
					Settings.Default.LESIONsleep = this.oaHgbMrnne.Value.ToString();
					Settings.Default.LESIONstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.LESIONsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				if (this.comboBox3.SelectedItem.ToString() == "MAESTRO")
				{
					Settings.Default.MAESTROstrenght = this.trackBar1.Value.ToString();
					Settings.Default.MAESTROsleep = this.oaHgbMrnne.Value.ToString();
					Settings.Default.MAESTROstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.MAESTROsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				if (this.comboBox3.SelectedItem.ToString() == "MELUSI")
				{
					Settings.Default.MELUSIstrenght = this.trackBar1.Value.ToString();
					Settings.Default.MELUSIsleep = this.oaHgbMrnne.Value.ToString();
					Settings.Default.MELUSIstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.MELUSIsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				if (this.comboBox3.SelectedItem.ToString() == "MIRA")
				{
					Settings.Default.MIRAstrenght = this.trackBar1.Value.ToString();
					Settings.Default.MIRAsleep = this.oaHgbMrnne.Value.ToString();
					Settings.Default.MIRAstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.MIRAsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				if (this.comboBox3.SelectedItem.ToString() == "MOZZIE")
				{
					Settings.Default.MOZZIEstrenght = this.trackBar1.Value.ToString();
					Settings.Default.MOZZIEsleep = this.oaHgbMrnne.Value.ToString();
					Settings.Default.MOZZIEstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.MOZZIEsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				if (this.comboBox3.SelectedItem.ToString() == "MUTE")
				{
					Settings.Default.MUTEstrenght = this.trackBar1.Value.ToString();
					Settings.Default.MUTEsleep = this.oaHgbMrnne.Value.ToString();
					Settings.Default.MUTEstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.MUTEsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				if (this.comboBox3.SelectedItem.ToString() == "ORYX")
				{
					Settings.Default.ORYXstrenght = this.trackBar1.Value.ToString();
					Settings.Default.ORYXsleep = this.oaHgbMrnne.Value.ToString();
					Settings.Default.ORYXstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.ORYXsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				if (this.comboBox3.SelectedItem.ToString() == "PULSE")
				{
					Settings.Default.PULSEstrenght = this.trackBar1.Value.ToString();
					Settings.Default.PULSEsleep = this.oaHgbMrnne.Value.ToString();
					Settings.Default.PULSEstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.PULSEsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				if (this.comboBox3.SelectedItem.ToString() == "ROOK")
				{
					Settings.Default.ROOKstrenght = this.trackBar1.Value.ToString();
					Settings.Default.ROOKsleep = this.oaHgbMrnne.Value.ToString();
					Settings.Default.ROOKstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.ROOKsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				if (this.comboBox3.SelectedItem.ToString() == "SMOKE")
				{
					Settings.Default.SMOKEstrenght = this.trackBar1.Value.ToString();
					Settings.Default.SMOKEsleep = this.oaHgbMrnne.Value.ToString();
					Settings.Default.SMOKEstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.SMOKEsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				if (this.comboBox3.SelectedItem.ToString() == "TACHANKA")
				{
					Settings.Default.TACHANKAstrenght = this.trackBar1.Value.ToString();
					Settings.Default.TACHANKAsleep = this.oaHgbMrnne.Value.ToString();
					Settings.Default.TACHANKAstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.TACHANKAsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				if (this.comboBox3.SelectedItem.ToString() == "THORN")
				{
					Settings.Default.THORNstrenght = this.trackBar1.Value.ToString();
					Settings.Default.THORNsleep = this.oaHgbMrnne.Value.ToString();
					Settings.Default.THORNstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.THORNsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				if (this.comboBox3.SelectedItem.ToString() == "THUNDERBIRD")
				{
					Settings.Default.THUNDERBIRDstrenght = this.trackBar1.Value.ToString();
					Settings.Default.THUNDERBIRDsleep = this.oaHgbMrnne.Value.ToString();
					Settings.Default.THUNDERBIRDstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.THUNDERBIRDsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				if (this.comboBox3.SelectedItem.ToString() == "VALKYRIE")
				{
					Settings.Default.VALKYRIEstrenght = this.trackBar1.Value.ToString();
					Settings.Default.VALKYRIEsleep = this.oaHgbMrnne.Value.ToString();
					Settings.Default.VALKYRIEstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.VALKYRIEsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				if (this.comboBox3.SelectedItem.ToString() == "VIGIL")
				{
					Settings.Default.VIGILstrenght = this.trackBar1.Value.ToString();
					Settings.Default.VIGILsleep = this.oaHgbMrnne.Value.ToString();
					Settings.Default.VIGILstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.VIGILsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				if (this.comboBox3.SelectedItem.ToString() == "WAMAI")
				{
					Settings.Default.WAMAIstrenght = this.trackBar1.Value.ToString();
					Settings.Default.WAMAIsleep = this.oaHgbMrnne.Value.ToString();
					Settings.Default.WAMAIstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.WAMAIsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				if (this.comboBox3.SelectedItem.ToString() == "WARDEN")
				{
					Settings.Default.WARDENstrenght = this.trackBar1.Value.ToString();
					Settings.Default.WARDENsleep = this.oaHgbMrnne.Value.ToString();
					Settings.Default.WARDENstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.WARDENsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000096F8 File Offset: 0x000078F8
		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.comboBox1.SelectedIndex != -1)
			{
				this.label10.Text = this.comboBox1.SelectedItem.ToString();
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00009730 File Offset: 0x00007930
		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.button9.FlatAppearance.BorderColor = Color.Lime;
			this.button8.FlatAppearance.BorderColor = Color.Red;
			if (this.comboBox2.SelectedItem.ToString() == "ACE")
			{
				this.Valuesetter.Text = Settings.Default.ACEstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.ACEsleep;
				this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.ACEstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.ACEsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox2.SelectedItem.ToString();
			}
			if (this.comboBox2.SelectedItem.ToString() == "AMARU")
			{
				this.Valuesetter.Text = Settings.Default.AMARUstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.AMARUsleep;
				this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.AMARUstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.AMARUsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox2.SelectedItem.ToString();
			}
			if (this.comboBox2.SelectedItem.ToString() == "ASH")
			{
				this.Valuesetter.Text = Settings.Default.ASHstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.ASHsleep;
				this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.ASHstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.ASHsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox2.SelectedItem.ToString();
			}
			if (this.comboBox2.SelectedItem.ToString() == "BLACKBEARD")
			{
				this.Valuesetter.Text = Settings.Default.BLACKBEARDstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.BLACKBEARDsleep;
				this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.BLACKBEARDstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.BLACKBEARDsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox2.SelectedItem.ToString();
			}
			if (this.comboBox2.SelectedItem.ToString() == "BLITZ")
			{
				this.Valuesetter.Text = Settings.Default.BLITZstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.BLITZsleep;
				this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.BLITZstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.BLITZsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox2.SelectedItem.ToString();
			}
			if (this.comboBox2.SelectedItem.ToString() == "BUCK")
			{
				this.Valuesetter.Text = Settings.Default.BUCKstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.BUCKsleep;
				this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.BUCKstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.BUCKsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox2.SelectedItem.ToString();
			}
			if (this.comboBox2.SelectedItem.ToString() == "CAPITÃO")
			{
				this.Valuesetter.Text = Settings.Default.CAPITÃOstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.CAPITÃOsleep;
				this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.CAPITÃOstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.CAPITÃOsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox2.SelectedItem.ToString();
			}
			if (this.comboBox2.SelectedItem.ToString() == "DOKKAEBI")
			{
				this.Valuesetter.Text = Settings.Default.DOKKAEBIstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.DOKKAEBIsleep;
				this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.DOKKAEBIstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.DOKKAEBIsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox2.SelectedItem.ToString();
			}
			if (this.comboBox2.SelectedItem.ToString() == "FINKA")
			{
				this.Valuesetter.Text = Settings.Default.FINKAstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.FINKAsleep;
				this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.FINKAstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.FINKAsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox2.SelectedItem.ToString();
			}
			if (this.comboBox2.SelectedItem.ToString() == "FLORES")
			{
				this.Valuesetter.Text = Settings.Default.FLORESstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.FLORESsleep;
				this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.FLORESstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.FLORESsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox2.SelectedItem.ToString();
			}
			if (this.comboBox2.SelectedItem.ToString() == "FUZE")
			{
				this.Valuesetter.Text = Settings.Default.FUZEstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.FUZEsleep;
				this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.FUZEstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.FUZEsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox2.SelectedItem.ToString();
			}
			if (this.comboBox2.SelectedItem.ToString() == "GLAZ")
			{
				this.Valuesetter.Text = Settings.Default.GLAZstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.GLAZsleep;
				this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.GLAZstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.GLAZsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox2.SelectedItem.ToString();
			}
			if (this.comboBox2.SelectedItem.ToString() == "GRIDLOCK")
			{
				this.Valuesetter.Text = Settings.Default.GRIDLOCKstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.GRIDLOCKsleep;
				this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.GRIDLOCKstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.GRIDLOCKsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox2.SelectedItem.ToString();
			}
			if (this.comboBox2.SelectedItem.ToString() == "HIBANA")
			{
				this.Valuesetter.Text = Settings.Default.HIBANAstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.HIBANAsleep;
				this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.HIBANAstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.HIBANAsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox2.SelectedItem.ToString();
			}
			if (this.comboBox2.SelectedItem.ToString() == "IANA")
			{
				this.Valuesetter.Text = Settings.Default.IANAstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.IANAsleep;
				this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.IANAstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.IANAsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox2.SelectedItem.ToString();
			}
			if (this.comboBox2.SelectedItem.ToString() == "IQ")
			{
				this.Valuesetter.Text = Settings.Default.IQstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.IQsleep;
				this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.IQstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.IQsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox2.SelectedItem.ToString();
			}
			if (this.comboBox2.SelectedItem.ToString() == "JACKAL")
			{
				this.Valuesetter.Text = Settings.Default.JACKALstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.JACKALsleep;
				this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.JACKALstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.JACKALsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox2.SelectedItem.ToString();
			}
			if (this.comboBox2.SelectedItem.ToString() == "KALI")
			{
				this.Valuesetter.Text = Settings.Default.KALIstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.KALIsleep;
				this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.KALIstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.KALIsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox2.SelectedItem.ToString();
			}
			if (this.comboBox2.SelectedItem.ToString() == "LION")
			{
				this.Valuesetter.Text = Settings.Default.LIONstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.LIONsleep;
				this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.LIONstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.LIONsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox2.SelectedItem.ToString();
			}
			if (this.comboBox2.SelectedItem.ToString() == "MAVERICK")
			{
				this.Valuesetter.Text = Settings.Default.MAVERICKstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.MAVERICKsleep;
				this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.MAVERICKstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.MAVERICKsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox2.SelectedItem.ToString();
			}
			if (this.comboBox2.SelectedItem.ToString() == "MONTAGNE")
			{
				this.Valuesetter.Text = Settings.Default.MONTAGNEstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.MONTAGNEsleep;
				this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.MONTAGNEstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.MONTAGNEsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox2.SelectedItem.ToString();
			}
			if (this.comboBox2.SelectedItem.ToString() == "NOMAD")
			{
				this.Valuesetter.Text = Settings.Default.NOMADstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.NOMADsleep;
				this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.NOMADstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.NOMADsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox2.SelectedItem.ToString();
			}
			if (this.comboBox2.SelectedItem.ToString() == "NØKK")
			{
				this.Valuesetter.Text = Settings.Default.NØKKstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.NØKKsleep;
				this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.NØKKstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.NØKKsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox2.SelectedItem.ToString();
			}
			if (this.comboBox2.SelectedItem.ToString() == "OSA")
			{
				this.Valuesetter.Text = Settings.Default.OSAstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.OSAsleep;
				this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.OSAstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.OSAsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox2.SelectedItem.ToString();
			}
			if (this.comboBox2.SelectedItem.ToString() == "SENS")
			{
				this.Valuesetter.Text = Settings.Default.SENSstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.SENSsleep;
				this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.SENSstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.SENSsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox2.SelectedItem.ToString();
			}
			if (this.comboBox2.SelectedItem.ToString() == "SLEDGE")
			{
				this.Valuesetter.Text = Settings.Default.SLEDGEstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.SLEDGEsleep;
				this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.SLEDGEstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.SLEDGEsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox2.SelectedItem.ToString();
			}
			if (this.comboBox2.SelectedItem.ToString() == "THATCHER")
			{
				this.Valuesetter.Text = Settings.Default.THATCHERstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.THATCHERsleep;
				this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.THATCHERstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.THATCHERsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox2.SelectedItem.ToString();
			}
			if (this.comboBox2.SelectedItem.ToString() == "THERMITE")
			{
				this.Valuesetter.Text = Settings.Default.THERMITEstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.THERMITEsleep;
				this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.THERMITEstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.THERMITEsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox2.SelectedItem.ToString();
			}
			if (this.comboBox2.SelectedItem.ToString() == "TWITCH")
			{
				this.Valuesetter.Text = Settings.Default.TWITCHstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.TWITCHsleep;
				this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.TWITCHstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.TWITCHsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox2.SelectedItem.ToString();
			}
			if (this.comboBox2.SelectedItem.ToString() == "YING")
			{
				this.Valuesetter.Text = Settings.Default.YINGstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.YINGsleep;
				this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.YINGstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.YINGsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox2.SelectedItem.ToString();
			}
			if (this.comboBox2.SelectedItem.ToString() == "ZERO")
			{
				this.Valuesetter.Text = Settings.Default.ZEROstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.ZEROsleep;
				this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.ZEROstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.ZEROsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox2.SelectedItem.ToString();
			}
			if (this.comboBox2.SelectedItem.ToString() == "ZOFIA")
			{
				this.Valuesetter.Text = Settings.Default.ZOFIAstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.ZOFIAsleep;
				this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.ZOFIAstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.ZOFIAsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox2.SelectedItem.ToString();
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x0000B6A8 File Offset: 0x000098A8
		private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.button9.FlatAppearance.BorderColor = Color.Red;
			this.button8.FlatAppearance.BorderColor = Color.Lime;
			if (this.comboBox3.SelectedItem.ToString() == "ALIBI")
			{
				this.Valuesetter.Text = Settings.Default.ALIBIstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.ALIBIsleep;
				this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.ALIBIstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.ALIBIsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox3.SelectedItem.ToString();
			}
			if (this.comboBox3.SelectedItem.ToString() == "ARUNI")
			{
				this.Valuesetter.Text = Settings.Default.ARUNIstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.ARUNIsleep;
				this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.ARUNIstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.ARUNIsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox3.SelectedItem.ToString();
			}
			if (this.comboBox3.SelectedItem.ToString() == "AZAMI")
			{
				this.Valuesetter.Text = Settings.Default.AZAMIstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.AZAMIsleep;
				this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.AZAMIstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.AZAMIsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox3.SelectedItem.ToString();
			}
			if (this.comboBox3.SelectedItem.ToString() == "BANDIT")
			{
				this.Valuesetter.Text = Settings.Default.BANDITstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.BANDITsleep;
				this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.BANDITstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.BANDITsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox3.SelectedItem.ToString();
			}
			if (this.comboBox3.SelectedItem.ToString() == "CASTLE")
			{
				this.Valuesetter.Text = Settings.Default.CASTLEstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.CASTLEsleep;
				this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.CASTLEstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.CASTLEsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox3.SelectedItem.ToString();
			}
			if (this.comboBox3.SelectedItem.ToString() == "CAVEIRA")
			{
				this.Valuesetter.Text = Settings.Default.CAVEIRAstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.CAVEIRAsleep;
				this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.CAVEIRAstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.CAVEIRAsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox3.SelectedItem.ToString();
			}
			if (this.comboBox3.SelectedItem.ToString() == "CLASH")
			{
				this.Valuesetter.Text = Settings.Default.CLASHstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.CLASHsleep;
				this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.CLASHstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.CLASHsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox3.SelectedItem.ToString();
			}
			if (this.comboBox3.SelectedItem.ToString() == "DOC")
			{
				this.Valuesetter.Text = Settings.Default.DOCstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.DOCsleep;
				this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.DOCstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.DOCsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox3.SelectedItem.ToString();
			}
			if (this.comboBox3.SelectedItem.ToString() == "ECHO")
			{
				this.Valuesetter.Text = Settings.Default.ECHOstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.ECHOsleep;
				this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.ECHOstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.ECHOsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox3.SelectedItem.ToString();
			}
			if (this.comboBox3.SelectedItem.ToString() == "ELA")
			{
				this.Valuesetter.Text = Settings.Default.ELAstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.ELAsleep;
				this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.ELAstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.ELAsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox3.SelectedItem.ToString();
			}
			if (this.comboBox3.SelectedItem.ToString() == "FROST")
			{
				this.Valuesetter.Text = Settings.Default.FROSTstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.FROSTsleep;
				this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.FROSTstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.FROSTsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox3.SelectedItem.ToString();
			}
			if (this.comboBox3.SelectedItem.ToString() == "GOYO")
			{
				this.Valuesetter.Text = Settings.Default.GOYOstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.GOYOsleep;
				this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.GOYOstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.GOYOsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox3.SelectedItem.ToString();
			}
			if (this.comboBox3.SelectedItem.ToString() == "JÄGER")
			{
				this.Valuesetter.Text = Settings.Default.JÄGERstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.JÄGERsleep;
				this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.JÄGERstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.JÄGERsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox3.SelectedItem.ToString();
			}
			if (this.comboBox3.SelectedItem.ToString() == "KAID")
			{
				this.Valuesetter.Text = Settings.Default.KAIDstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.KAIDsleep;
				this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.KAIDstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.KAIDsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox3.SelectedItem.ToString();
			}
			if (this.comboBox3.SelectedItem.ToString() == "KAPKAN")
			{
				this.Valuesetter.Text = Settings.Default.KAPKANstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.KAPKANsleep;
				this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.KAPKANstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.KAPKANsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox3.SelectedItem.ToString();
			}
			if (this.comboBox3.SelectedItem.ToString() == "LESION")
			{
				this.Valuesetter.Text = Settings.Default.LESIONstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.LESIONsleep;
				this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.LESIONstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.LESIONsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox3.SelectedItem.ToString();
			}
			if (this.comboBox3.SelectedItem.ToString() == "MAESTRO")
			{
				this.Valuesetter.Text = Settings.Default.MAESTROstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.MAESTROsleep;
				this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.MAESTROstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.MAESTROsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox3.SelectedItem.ToString();
			}
			if (this.comboBox3.SelectedItem.ToString() == "MELUSI")
			{
				this.Valuesetter.Text = Settings.Default.MELUSIstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.MELUSIsleep;
				this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.MELUSIstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.MELUSIsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox3.SelectedItem.ToString();
			}
			if (this.comboBox3.SelectedItem.ToString() == "MIRA")
			{
				this.Valuesetter.Text = Settings.Default.MIRAstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.MIRAsleep;
				this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.MIRAstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.MIRAsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox3.SelectedItem.ToString();
			}
			if (this.comboBox3.SelectedItem.ToString() == "MOZZIE")
			{
				this.Valuesetter.Text = Settings.Default.MOZZIEstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.MOZZIEsleep;
				this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.MOZZIEstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.MOZZIEsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox3.SelectedItem.ToString();
			}
			if (this.comboBox3.SelectedItem.ToString() == "MUTE")
			{
				this.Valuesetter.Text = Settings.Default.MUTEstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.MUTEsleep;
				this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.MUTEstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.MUTEsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox3.SelectedItem.ToString();
			}
			if (this.comboBox3.SelectedItem.ToString() == "ORYX")
			{
				this.Valuesetter.Text = Settings.Default.ORYXstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.ORYXsleep;
				this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.ORYXstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.ORYXsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox3.SelectedItem.ToString();
			}
			if (this.comboBox3.SelectedItem.ToString() == "PULSE")
			{
				this.Valuesetter.Text = Settings.Default.PULSEstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.PULSEsleep;
				this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.PULSEstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.PULSEsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox3.SelectedItem.ToString();
			}
			if (this.comboBox3.SelectedItem.ToString() == "ROOK")
			{
				this.Valuesetter.Text = Settings.Default.ROOKstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.ROOKsleep;
				this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.ROOKstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.ROOKsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox3.SelectedItem.ToString();
			}
			if (this.comboBox3.SelectedItem.ToString() == "SMOKE")
			{
				this.Valuesetter.Text = Settings.Default.SMOKEstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.SMOKEsleep;
				this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.SMOKEstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.SMOKEsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox3.SelectedItem.ToString();
			}
			if (this.comboBox3.SelectedItem.ToString() == "TACHANKA")
			{
				this.Valuesetter.Text = Settings.Default.TACHANKAstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.TACHANKAsleep;
				this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.TACHANKAstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.TACHANKAsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox3.SelectedItem.ToString();
			}
			if (this.comboBox3.SelectedItem.ToString() == "THORN")
			{
				this.Valuesetter.Text = Settings.Default.THORNstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.THORNsleep;
				this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.THORNstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.THORNsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox3.SelectedItem.ToString();
			}
			if (this.comboBox3.SelectedItem.ToString() == "THUNDERBIRD")
			{
				this.Valuesetter.Text = Settings.Default.THUNDERBIRDstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.THUNDERBIRDsleep;
				this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.THUNDERBIRDstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.THUNDERBIRDsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox3.SelectedItem.ToString();
			}
			if (this.comboBox3.SelectedItem.ToString() == "VALKYRIE")
			{
				this.Valuesetter.Text = Settings.Default.VALKYRIEstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.VALKYRIEsleep;
				this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.VALKYRIEstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.VALKYRIEsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox3.SelectedItem.ToString();
			}
			if (this.comboBox3.SelectedItem.ToString() == "VIGIL")
			{
				this.Valuesetter.Text = Settings.Default.VIGILstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.VIGILsleep;
				this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.VIGILstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.VIGILsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox3.SelectedItem.ToString();
			}
			if (this.comboBox3.SelectedItem.ToString() == "WAMAI")
			{
				this.Valuesetter.Text = Settings.Default.WAMAIstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.WAMAIsleep;
				this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.WAMAIstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.WAMAIsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox3.SelectedItem.ToString();
			}
			if (this.comboBox3.SelectedItem.ToString() == "WARDEN")
			{
				this.Valuesetter.Text = Settings.Default.WARDENstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.WARDENsleep;
				this.oaHgbMrnne.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.WARDENstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.WARDENsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox3.SelectedItem.ToString();
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x0000D620 File Offset: 0x0000B820
		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (base.TopMost)
			{
				base.TopMost = false;
			}
			else
			{
				base.TopMost = true;
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x0000D648 File Offset: 0x0000B848
		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{
			if (!this.checkBox2.Checked)
			{
				if (this.checkBox2.Checked)
				{
				}
			}
			else
			{
				this.checkBox4.Checked = false;
			}
		}

		// Token: 0x0600002D RID: 45 RVA: 0x0000D684 File Offset: 0x0000B884
		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			Form1.ReleaseCapture();
			Form1.SendMessage(base.Handle, 161, 2, 0);
		}

		// Token: 0x0600002E RID: 46
		[DllImport("user32.dll")]
		private static extern IntPtr GetForegroundWindow();

		// Token: 0x0600002F RID: 47
		[DllImport("user32.dll")]
		private static extern int GetWindowThreadProcessId(IntPtr intptr_1, out uint uint_2);

		// Token: 0x06000030 RID: 48 RVA: 0x0000D6AC File Offset: 0x0000B8AC
		private string method_2()
		{
			IntPtr foregroundWindow = Form1.GetForegroundWindow();
			uint num;
			Form1.GetWindowThreadProcessId(foregroundWindow, out num);
			foreach (Process process in Process.GetProcesses())
			{
				if ((long)process.Id == (long)((ulong)num))
				{
					return process.ProcessName;
				}
				this.label19.Text = (num.ToString() ?? "");
				this.string_2 = num.ToString();
			}
			return "Unknown";
		}

		// Token: 0x06000031 RID: 49
		[DllImport("user32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

		// Token: 0x06000032 RID: 50 RVA: 0x0000D73C File Offset: 0x0000B93C
		private void timer_0_Tick(object sender, EventArgs e)
		{
			if (!Form1.Enabled)
			{
				this.label8.Text = "DISABLED";
				this.label8.ForeColor = Color.Red;
			}
			else
			{
				this.label8.Text = "ENABLED";
				this.label8.ForeColor = Color.Green;
				this.method_0();
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x0000D798 File Offset: 0x0000B998
		private void timer_1_Tick(object sender, EventArgs e)
		{
			this.method_2();
			if (this.comboBox2.SelectedItem != null)
			{
				this.button6.Text = "SAVE AS " + this.comboBox2.SelectedItem.ToString();
			}
			if (this.comboBox3.SelectedItem != null)
			{
				this.button3.Text = "SAVE AS " + this.comboBox3.SelectedItem.ToString();
			}
			if (this.label10.Text == "Num Lock")
			{
				Form1.uint_0 = 144U;
			}
			if (this.label10.Text == "Caps Lock")
			{
				Form1.uint_0 = 20U;
			}
			if (this.label10.Text == "Insert")
			{
				Form1.uint_0 = 45U;
			}
			if (this.label10.Text == "Tab")
			{
				Form1.uint_0 = 9U;
			}
			if (this.label10.Text == "Delete")
			{
				Form1.uint_0 = 46U;
			}
			if (this.label10.Text == "F1")
			{
				Form1.uint_0 = 112U;
			}
			if (this.label10.Text == "F2")
			{
				Form1.uint_0 = 113U;
			}
			if (this.label10.Text == "F3")
			{
				Form1.uint_0 = 114U;
			}
			if (this.label10.Text == "F4")
			{
				Form1.uint_0 = 115U;
			}
			if (this.label10.Text == "F5")
			{
				Form1.uint_0 = 116U;
			}
			if (this.label10.Text == "F6")
			{
				Form1.uint_0 = 117U;
			}
			if (this.label10.Text == "F7")
			{
				Form1.uint_0 = 118U;
			}
			if (this.label10.Text == "F8")
			{
				Form1.uint_0 = 119U;
			}
			if (this.label10.Text == "F9")
			{
				Form1.uint_0 = 120U;
			}
			if (this.label10.Text == "F10")
			{
				Form1.uint_0 = 121U;
			}
			if (this.label10.Text == "F11")
			{
				Form1.uint_0 = 122U;
			}
			if (this.label10.Text == "F12")
			{
				Form1.uint_0 = 123U;
			}
			if (this.label10.Text == "0")
			{
				Form1.uint_0 = 48U;
			}
			if (this.label10.Text == "1")
			{
				Form1.uint_0 = 49U;
			}
			if (this.label10.Text == "2")
			{
				Form1.uint_0 = 50U;
			}
			if (this.label10.Text == "3")
			{
				Form1.uint_0 = 51U;
			}
			if (this.label10.Text == "4")
			{
				Form1.uint_0 = 52U;
			}
			if (this.label10.Text == "5")
			{
				Form1.uint_0 = 53U;
			}
			if (this.label10.Text == "6")
			{
				Form1.uint_0 = 54U;
			}
			if (this.label10.Text == "7")
			{
				Form1.uint_0 = 55U;
			}
			if (this.label10.Text == "8")
			{
				Form1.uint_0 = 56U;
			}
			if (this.label10.Text == "9")
			{
				Form1.uint_0 = 57U;
			}
			if (this.label10.Text == "Home")
			{
				Form1.uint_0 = 36U;
			}
			if (this.label10.Text == "A")
			{
				Form1.uint_0 = 65U;
			}
			if (this.label10.Text == "B")
			{
				Form1.uint_0 = 66U;
			}
			if (this.label10.Text == "C")
			{
				Form1.uint_0 = 67U;
			}
			if (this.label10.Text == "D")
			{
				Form1.uint_0 = 68U;
			}
			if (this.label10.Text == "E")
			{
				Form1.uint_0 = 69U;
			}
			if (this.label10.Text == "F")
			{
				Form1.uint_0 = 70U;
			}
			if (this.label10.Text == "G")
			{
				Form1.uint_0 = 71U;
			}
			if (this.label10.Text == "H")
			{
				Form1.uint_0 = 72U;
			}
			if (this.label10.Text == "I")
			{
				Form1.uint_0 = 73U;
			}
			if (this.label10.Text == "J")
			{
				Form1.uint_0 = 74U;
			}
			if (this.label10.Text == "K")
			{
				Form1.uint_0 = 75U;
			}
			if (this.label10.Text == "L")
			{
				Form1.uint_0 = 76U;
			}
			if (this.label10.Text == "M")
			{
				Form1.uint_0 = 77U;
			}
			if (this.label10.Text == "N")
			{
				Form1.uint_0 = 78U;
			}
			if (this.label10.Text == "O")
			{
				Form1.uint_0 = 79U;
			}
			if (this.label10.Text == "P")
			{
				Form1.uint_0 = 80U;
			}
			if (this.label10.Text == "Q")
			{
				Form1.uint_0 = 81U;
			}
			if (this.label10.Text == "R")
			{
				Form1.uint_0 = 82U;
			}
			if (this.label10.Text == "S")
			{
				Form1.uint_0 = 83U;
			}
			if (this.label10.Text == "T")
			{
				Form1.uint_0 = 84U;
			}
			if (this.label10.Text == "U")
			{
				Form1.uint_0 = 85U;
			}
			if (this.label10.Text == "V")
			{
				Form1.uint_0 = 86U;
			}
			if (this.label10.Text == "W")
			{
				Form1.uint_0 = 87U;
			}
			if (this.label10.Text == "X")
			{
				Form1.uint_0 = 88U;
			}
			if (this.label10.Text == "Y")
			{
				Form1.uint_0 = 89U;
			}
			if (this.label10.Text == "Z")
			{
				Form1.uint_0 = 90U;
			}
			if (this.label10.Text == "Up Key")
			{
				Form1.uint_0 = 38U;
			}
			if (this.label10.Text == "Down Key")
			{
				Form1.uint_0 = 40U;
			}
			if (this.label10.Text == "Left Key")
			{
				Form1.uint_0 = 37U;
			}
			if (this.label10.Text == "Right Key")
			{
				Form1.uint_0 = 39U;
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x0000DEE8 File Offset: 0x0000C0E8
		private void timer_2_Tick(object sender, EventArgs e)
		{
			Process[] processesByName = Process.GetProcessesByName("RainbowSix");
			foreach (Process process in processesByName)
			{
				this.string_0 = process.Id.ToString();
				this.label20.Text = this.string_0;
			}
			Process[] processesByName2 = Process.GetProcessesByName("RainbowSix_Vulkan");
			foreach (Process process2 in processesByName2)
			{
				this.string_1 = process2.Id.ToString();
				this.label17.Text = this.string_0;
			}
			Process[] processesByName3 = Process.GetProcessesByName(this.string_3);
			foreach (Process process3 in processesByName3)
			{
				this.string_4 = process3.Id.ToString();
				this.label23.Text = this.string_0;
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x0000DFEC File Offset: 0x0000C1EC
		private void button7_Click(object sender, EventArgs e)
		{
			Process.Start("explorer.exe", "/open," + Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));
			MessageBox.Show("Default location is AppData\\Local\\MILLENIUMV2\\EXE_NAME ");
		}

		// Token: 0x06000036 RID: 54 RVA: 0x0000E020 File Offset: 0x0000C220
		private void button4_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("This will reset all the configs for all operators to default value , Your password and username will be forgotten. the next login you need to enter your credentials again. Are you sure you want to reset?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				Settings.Default.Reset();
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x0000E04C File Offset: 0x0000C24C
		private void trackBar1_ValueChanged(object sender, EventArgs e)
		{
			this.sDpgjoebc9.Text = "STRENGHT: " + this.trackBar1.Value.ToString();
			Form1.int_3 = this.trackBar1.Value;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x0000E094 File Offset: 0x0000C294
		private void button1_Click(object sender, EventArgs e)
		{
			if (!this.panel3.Visible)
			{
				this.panel4.Visible = false;
				this.panel3.Visible = true;
			}
			else
			{
				this.panel3.Visible = false;
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x0000E0D4 File Offset: 0x0000C2D4
		private void button2_Click(object sender, EventArgs e)
		{
			if (!this.panel4.Visible)
			{
				this.panel3.Visible = false;
				this.panel4.Visible = true;
			}
			else
			{
				this.panel4.Visible = false;
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x0000D684 File Offset: 0x0000B884
		private void Form1_MouseDown(object sender, MouseEventArgs e)
		{
			Form1.ReleaseCapture();
			Form1.SendMessage(base.Handle, 161, 2, 0);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x0000D684 File Offset: 0x0000B884
		private void panel4_MouseDown(object sender, MouseEventArgs e)
		{
			Form1.ReleaseCapture();
			Form1.SendMessage(base.Handle, 161, 2, 0);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x0000D684 File Offset: 0x0000B884
		private void panel3_MouseDown(object sender, MouseEventArgs e)
		{
			Form1.ReleaseCapture();
			Form1.SendMessage(base.Handle, 161, 2, 0);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x0000E114 File Offset: 0x0000C314
		private void timer_5_Tick(object sender, EventArgs e)
		{
			string text = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
			char[] array = new char[8];
			Random random = new Random();
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = text[random.Next(text.Length)];
			}
			string text2 = new string(array);
			this.Text = text2;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002264 File Offset: 0x00000464
		private void timer_4_Tick(object sender, EventArgs e)
		{
		}

		// Token: 0x0600003F RID: 63 RVA: 0x0000E178 File Offset: 0x0000C378
		private void timer_6_Tick(object sender, EventArgs e)
		{
			base.TopMost = true;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002264 File Offset: 0x00000464
		private void method_3(object sender, EventArgs e)
		{
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002264 File Offset: 0x00000464
		private void method_4(object sender, EventArgs e)
		{
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002264 File Offset: 0x00000464
		private void method_5(object sender, EventArgs e)
		{
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002264 File Offset: 0x00000464
		private void trackBar1_KeyPress(object sender, KeyPressEventArgs e)
		{
		}

		// Token: 0x06000044 RID: 68 RVA: 0x0000E18C File Offset: 0x0000C38C
		private void method_6(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("explorer", "https://auth.gg/portal/Millenium");
		}

		// Token: 0x06000045 RID: 69 RVA: 0x0000E1AC File Offset: 0x0000C3AC
		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("explorer", "https://discord.gg/V3nrJCEkP2");
		}

		// Token: 0x06000046 RID: 70 RVA: 0x0000E18C File Offset: 0x0000C38C
		private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("explorer", "https://auth.gg/portal/Millenium");
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002264 File Offset: 0x00000464
		private void method_7(object sender, EventArgs e)
		{
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002264 File Offset: 0x00000464
		private void method_8(object sender, EventArgs e)
		{
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002264 File Offset: 0x00000464
		private void method_9(object sender, EventArgs e)
		{
		}

		// Token: 0x0600004A RID: 74 RVA: 0x0000E1CC File Offset: 0x0000C3CC
		private void tjdcdyIsV(object sender, EventArgs e)
		{
			Settings.Default.override1 = this.textBox1.Text;
			Settings.Default.override2 = this.textBox2.Text;
			this.trackBar1.Maximum = int.Parse(Settings.Default.override1);
			this.oaHgbMrnne.Maximum = int.Parse(Settings.Default.override2);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x0000E238 File Offset: 0x0000C438
		private void button11_Click(object sender, EventArgs e)
		{
			Class0.smethod_0(Form1.int_3, Form1.int_2, Form1.int_1, Form1.int_0, this.recoilConfigName.Text);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x0000E26C File Offset: 0x0000C46C
		private void button13_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.InitialDirectory = AppContext.BaseDirectory + "\\Configs\\";
			openFileDialog.Filter = "Json files (*.json)|*.json";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				string fileName = openFileDialog.FileName;
				using (StreamReader streamReader = File.OpenText(fileName))
				{
					JsonSerializer jsonSerializer = new JsonSerializer();
					RecoilConfig recoilConfig = (RecoilConfig)jsonSerializer.Deserialize(streamReader, typeof(RecoilConfig));
					Form1.int_3 = recoilConfig.verticalstrength;
					this.trackBar1.Value = recoilConfig.verticalstrength;
					Form1.int_1 = recoilConfig.verticalslow;
					this.oaHgbMrnne.Value = recoilConfig.verticalslow;
					Form1.int_2 = recoilConfig.horizontalstrength;
					this.trackBar3.Value = recoilConfig.horizontalstrength;
					Form1.int_0 = recoilConfig.horizontalslow;
					this.trackBar4.Value = recoilConfig.horizontalslow;
				}
				string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fileName);
				this.opoutput.Text = fileNameWithoutExtension;
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002264 File Offset: 0x00000464
		private void YfChtMyne(object sender, CancelEventArgs e)
		{
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00003448 File Offset: 0x00001648
		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			Settings.Default.Save();
			this.thread_0.Abort();
			Application.Exit();
			Environment.Exit(0);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002264 File Offset: 0x00000464
		private void recoilConfigName_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000050 RID: 80 RVA: 0x0000E390 File Offset: 0x0000C590
		private void button14_Click(object sender, EventArgs e)
		{
			Settings.Default.custompid = this.textBox4.Text;
			this.string_3 = Settings.Default.custompid;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x0000E3C4 File Offset: 0x0000C5C4
		private void checkBox4_CheckedChanged(object sender, EventArgs e)
		{
			if (this.checkBox4.Checked)
			{
				this.checkBox2.Checked = false;
			}
			else if (this.checkBox4.Checked)
			{
			}
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002264 File Offset: 0x00000464
		private void BLUE_Scroll(object sender, EventArgs e)
		{
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002264 File Offset: 0x00000464
		private void timer_7_Tick(object sender, EventArgs e)
		{
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002264 File Offset: 0x00000464
		private void button12_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002264 File Offset: 0x00000464
		private void method_10(object sender, EventArgs e)
		{
		}

		// Token: 0x06000056 RID: 86 RVA: 0x0000E3FC File Offset: 0x0000C5FC
		private void RED_ValueChanged(object sender, EventArgs e)
		{
			Settings.Default.redsaved = this.RED.Value.ToString();
			this.RED.Value = int.Parse(Settings.Default.redsaved);
			this.label30.Text = this.RED.Value.ToString();
			this.label31.Text = string.Concat(new string[]
			{
				"RGB(",
				this.RED.Value.ToString(),
				",",
				this.GREEN.Value.ToString(),
				",",
				this.BLUE.Value.ToString(),
				")"
			});
			string redsaved = Settings.Default.redsaved;
			int red = int.Parse(redsaved);
			string greensaved = Settings.Default.greensaved;
			int green = int.Parse(greensaved);
			string bluesaved = Settings.Default.bluesaved;
			int blue = int.Parse(bluesaved);
			this.label2.BackColor = Color.FromArgb(red, green, blue);
			this.panel1.BackColor = Color.FromArgb(red, green, blue);
			this.label13.BackColor = Color.FromArgb(red, green, blue);
			this.label14.BackColor = Color.FromArgb(red, green, blue);
			this.label7.ForeColor = Color.FromArgb(red, green, blue);
			this.label11.ForeColor = Color.FromArgb(red, green, blue);
			this.button5.BackColor = Color.FromArgb(red, green, blue);
			this.button9.BackColor = Color.FromArgb(red, green, blue);
			this.button8.BackColor = Color.FromArgb(red, green, blue);
			this.button6.BackColor = Color.FromArgb(red, green, blue);
			this.button3.BackColor = Color.FromArgb(red, green, blue);
			this.button11.BackColor = Color.FromArgb(red, green, blue);
			this.button13.BackColor = Color.FromArgb(red, green, blue);
			this.button14.BackColor = Color.FromArgb(red, green, blue);
			this.button10.BackColor = Color.FromArgb(red, green, blue);
			this.button7.BackColor = Color.FromArgb(red, green, blue);
			this.button4.BackColor = Color.FromArgb(red, green, blue);
			this.label12.ForeColor = Color.FromArgb(red, green, blue);
			this.label18.ForeColor = Color.FromArgb(red, green, blue);
			this.panel8.BackColor = Color.FromArgb(red, green, blue);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x0000E6D4 File Offset: 0x0000C8D4
		private void GREEN_ValueChanged(object sender, EventArgs e)
		{
			Settings.Default.greensaved = this.GREEN.Value.ToString();
			this.GREEN.Value = int.Parse(Settings.Default.greensaved);
			this.label28.Text = this.GREEN.Value.ToString();
			this.label31.Text = string.Concat(new string[]
			{
				"RGB(",
				this.RED.Value.ToString(),
				",",
				this.GREEN.Value.ToString(),
				",",
				this.BLUE.Value.ToString(),
				")"
			});
			string redsaved = Settings.Default.redsaved;
			int red = int.Parse(redsaved);
			string greensaved = Settings.Default.greensaved;
			int green = int.Parse(greensaved);
			string bluesaved = Settings.Default.bluesaved;
			int blue = int.Parse(bluesaved);
			this.label2.BackColor = Color.FromArgb(red, green, blue);
			this.panel1.BackColor = Color.FromArgb(red, green, blue);
			this.label13.BackColor = Color.FromArgb(red, green, blue);
			this.label14.BackColor = Color.FromArgb(red, green, blue);
			this.label7.ForeColor = Color.FromArgb(red, green, blue);
			this.label11.ForeColor = Color.FromArgb(red, green, blue);
			this.button5.BackColor = Color.FromArgb(red, green, blue);
			this.button9.BackColor = Color.FromArgb(red, green, blue);
			this.button8.BackColor = Color.FromArgb(red, green, blue);
			this.button6.BackColor = Color.FromArgb(red, green, blue);
			this.button3.BackColor = Color.FromArgb(red, green, blue);
			this.button11.BackColor = Color.FromArgb(red, green, blue);
			this.button13.BackColor = Color.FromArgb(red, green, blue);
			this.button14.BackColor = Color.FromArgb(red, green, blue);
			this.button10.BackColor = Color.FromArgb(red, green, blue);
			this.button7.BackColor = Color.FromArgb(red, green, blue);
			this.button4.BackColor = Color.FromArgb(red, green, blue);
			this.label12.ForeColor = Color.FromArgb(red, green, blue);
			this.label18.ForeColor = Color.FromArgb(red, green, blue);
			this.panel8.BackColor = Color.FromArgb(red, green, blue);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x0000E9AC File Offset: 0x0000CBAC
		private void BLUE_ValueChanged(object sender, EventArgs e)
		{
			Settings.Default.bluesaved = this.BLUE.Value.ToString();
			this.BLUE.Value = int.Parse(Settings.Default.bluesaved);
			this.label30.Text = this.RED.Value.ToString();
			this.label31.Text = string.Concat(new string[]
			{
				"RGB(",
				this.RED.Value.ToString(),
				",",
				this.GREEN.Value.ToString(),
				",",
				this.BLUE.Value.ToString(),
				")"
			});
			string redsaved = Settings.Default.redsaved;
			int red = int.Parse(redsaved);
			string greensaved = Settings.Default.greensaved;
			int green = int.Parse(greensaved);
			string bluesaved = Settings.Default.bluesaved;
			int blue = int.Parse(bluesaved);
			this.label2.BackColor = Color.FromArgb(red, green, blue);
			this.panel1.BackColor = Color.FromArgb(red, green, blue);
			this.label13.BackColor = Color.FromArgb(red, green, blue);
			this.label14.BackColor = Color.FromArgb(red, green, blue);
			this.label7.ForeColor = Color.FromArgb(red, green, blue);
			this.label11.ForeColor = Color.FromArgb(red, green, blue);
			this.button5.BackColor = Color.FromArgb(red, green, blue);
			this.button9.BackColor = Color.FromArgb(red, green, blue);
			this.button8.BackColor = Color.FromArgb(red, green, blue);
			this.button6.BackColor = Color.FromArgb(red, green, blue);
			this.button3.BackColor = Color.FromArgb(red, green, blue);
			this.button11.BackColor = Color.FromArgb(red, green, blue);
			this.button13.BackColor = Color.FromArgb(red, green, blue);
			this.button14.BackColor = Color.FromArgb(red, green, blue);
			this.button10.BackColor = Color.FromArgb(red, green, blue);
			this.button7.BackColor = Color.FromArgb(red, green, blue);
			this.button4.BackColor = Color.FromArgb(red, green, blue);
			this.label12.ForeColor = Color.FromArgb(red, green, blue);
			this.label18.ForeColor = Color.FromArgb(red, green, blue);
			this.panel8.BackColor = Color.FromArgb(red, green, blue);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002264 File Offset: 0x00000464
		private void timer_3_Tick(object sender, EventArgs e)
		{
		}

		// Token: 0x04000007 RID: 7
		private Thread thread_0;

		// Token: 0x04000008 RID: 8
		public const string WINDOW_NAME = "RainbowSix";

		// Token: 0x0400000A RID: 10
		public const int WM_NCLBUTTONDOWN = 161;

		// Token: 0x0400000B RID: 11
		public const int HT_CAPTION = 2;

		// Token: 0x0400000C RID: 12
		public new static bool Enabled = true;

		// Token: 0x0400000D RID: 13
		public static bool Enabled1 = true;

		// Token: 0x0400000E RID: 14
		public static int sleeptime = 1;

		// Token: 0x0400000F RID: 15
		public static int strength = 1;

		// Token: 0x04000010 RID: 16
		public static int sleeptime2 = 1;

		// Token: 0x04000011 RID: 17
		public static int strength2 = 0;

		// Token: 0x04000012 RID: 18
		private static uint uint_0 = 144U;

		// Token: 0x04000013 RID: 19
		private static uint uint_1 = 1U;

		// Token: 0x04000014 RID: 20
		private string string_0;

		// Token: 0x04000015 RID: 21
		private string string_1;

		// Token: 0x04000016 RID: 22
		private string string_2;

		// Token: 0x04000017 RID: 23
		private string string_3;

		// Token: 0x04000018 RID: 24
		private string string_4;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr intptr_0 = new IntPtr(-1);

		// Token: 0x0400001A RID: 26
		private static int int_0;

		// Token: 0x0400001B RID: 27
		private static int int_1;

		// Token: 0x0400001C RID: 28
		private static int int_2;

		// Token: 0x0400001D RID: 29
		private static int int_3;
	}
}
