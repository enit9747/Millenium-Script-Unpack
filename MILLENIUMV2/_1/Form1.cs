using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using MILLENIUMV2._1.Properties;

namespace MILLENIUMV2._1
{
	// Token: 0x02000003 RID: 3
	public partial class Form1 : Form
	{
		// Token: 0x06000003 RID: 3 RVA: 0x00002098 File Offset: 0x00002098
		public Form1()
		{
			this.InitializeComponent();
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000004 RID: 4 RVA: 0x000020B0 File Offset: 0x000020B0
		// (set) Token: 0x06000005 RID: 5 RVA: 0x000020B8 File Offset: 0x000020B8
		public object SelectedItem { get; set; }

		// Token: 0x06000006 RID: 6
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x06000007 RID: 7
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		// Token: 0x06000008 RID: 8 RVA: 0x000020C4 File Offset: 0x000020C4
		private void Form1_Load(object sender, EventArgs e)
		{
			this.label10.Text = Settings.Default.keybind;
			bool flag = this.label10.Text == "Num Lock";
			if (flag)
			{
				Form1.x = 144U;
			}
			bool flag2 = this.label10.Text == "Caps Lock";
			if (flag2)
			{
				Form1.x = 20U;
			}
			bool flag3 = this.label10.Text == "Insert";
			if (flag3)
			{
				Form1.x = 45U;
			}
			bool flag4 = this.label10.Text == "Tab";
			if (flag4)
			{
				Form1.x = 9U;
			}
			bool flag5 = this.label10.Text == "Delete";
			if (flag5)
			{
				Form1.x = 46U;
			}
			bool flag6 = this.label10.Text == "F1";
			if (flag6)
			{
				Form1.x = 112U;
			}
			bool flag7 = this.label10.Text == "F2";
			if (flag7)
			{
				Form1.x = 113U;
			}
			bool flag8 = this.label10.Text == "F3";
			if (flag8)
			{
				Form1.x = 114U;
			}
			bool flag9 = this.label10.Text == "F4";
			if (flag9)
			{
				Form1.x = 115U;
			}
			bool flag10 = this.label10.Text == "F5";
			if (flag10)
			{
				Form1.x = 116U;
			}
			bool flag11 = this.label10.Text == "F6";
			if (flag11)
			{
				Form1.x = 117U;
			}
			bool flag12 = this.label10.Text == "F7";
			if (flag12)
			{
				Form1.x = 118U;
			}
			bool flag13 = this.label10.Text == "F8";
			if (flag13)
			{
				Form1.x = 119U;
			}
			bool flag14 = this.label10.Text == "F9";
			if (flag14)
			{
				Form1.x = 120U;
			}
			bool flag15 = this.label10.Text == "F10";
			if (flag15)
			{
				Form1.x = 121U;
			}
			bool flag16 = this.label10.Text == "F11";
			if (flag16)
			{
				Form1.x = 122U;
			}
			bool flag17 = this.label10.Text == "F12";
			if (flag17)
			{
				Form1.x = 123U;
			}
			bool flag18 = this.label10.Text == "0";
			if (flag18)
			{
				Form1.x = 48U;
			}
			bool flag19 = this.label10.Text == "1";
			if (flag19)
			{
				Form1.x = 49U;
			}
			bool flag20 = this.label10.Text == "2";
			if (flag20)
			{
				Form1.x = 50U;
			}
			bool flag21 = this.label10.Text == "3";
			if (flag21)
			{
				Form1.x = 51U;
			}
			bool flag22 = this.label10.Text == "4";
			if (flag22)
			{
				Form1.x = 52U;
			}
			bool flag23 = this.label10.Text == "5";
			if (flag23)
			{
				Form1.x = 53U;
			}
			bool flag24 = this.label10.Text == "6";
			if (flag24)
			{
				Form1.x = 54U;
			}
			bool flag25 = this.label10.Text == "7";
			if (flag25)
			{
				Form1.x = 55U;
			}
			bool flag26 = this.label10.Text == "8";
			if (flag26)
			{
				Form1.x = 56U;
			}
			bool flag27 = this.label10.Text == "9";
			if (flag27)
			{
				Form1.x = 57U;
			}
			bool flag28 = this.label10.Text == "Home";
			if (flag28)
			{
				Form1.x = 36U;
			}
			bool flag29 = this.label10.Text == "A";
			if (flag29)
			{
				Form1.x = 65U;
			}
			bool flag30 = this.label10.Text == "B";
			if (flag30)
			{
				Form1.x = 66U;
			}
			bool flag31 = this.label10.Text == "C";
			if (flag31)
			{
				Form1.x = 67U;
			}
			bool flag32 = this.label10.Text == "D";
			if (flag32)
			{
				Form1.x = 68U;
			}
			bool flag33 = this.label10.Text == "E";
			if (flag33)
			{
				Form1.x = 69U;
			}
			bool flag34 = this.label10.Text == "F";
			if (flag34)
			{
				Form1.x = 70U;
			}
			bool flag35 = this.label10.Text == "G";
			if (flag35)
			{
				Form1.x = 71U;
			}
			bool flag36 = this.label10.Text == "H";
			if (flag36)
			{
				Form1.x = 72U;
			}
			bool flag37 = this.label10.Text == "I";
			if (flag37)
			{
				Form1.x = 73U;
			}
			bool flag38 = this.label10.Text == "J";
			if (flag38)
			{
				Form1.x = 74U;
			}
			bool flag39 = this.label10.Text == "K";
			if (flag39)
			{
				Form1.x = 75U;
			}
			bool flag40 = this.label10.Text == "L";
			if (flag40)
			{
				Form1.x = 76U;
			}
			bool flag41 = this.label10.Text == "M";
			if (flag41)
			{
				Form1.x = 77U;
			}
			bool flag42 = this.label10.Text == "N";
			if (flag42)
			{
				Form1.x = 78U;
			}
			bool flag43 = this.label10.Text == "O";
			if (flag43)
			{
				Form1.x = 79U;
			}
			bool flag44 = this.label10.Text == "P";
			if (flag44)
			{
				Form1.x = 80U;
			}
			bool flag45 = this.label10.Text == "Q";
			if (flag45)
			{
				Form1.x = 81U;
			}
			bool flag46 = this.label10.Text == "R";
			if (flag46)
			{
				Form1.x = 82U;
			}
			bool flag47 = this.label10.Text == "S";
			if (flag47)
			{
				Form1.x = 83U;
			}
			bool flag48 = this.label10.Text == "T";
			if (flag48)
			{
				Form1.x = 84U;
			}
			bool flag49 = this.label10.Text == "U";
			if (flag49)
			{
				Form1.x = 85U;
			}
			bool flag50 = this.label10.Text == "V";
			if (flag50)
			{
				Form1.x = 86U;
			}
			bool flag51 = this.label10.Text == "W";
			if (flag51)
			{
				Form1.x = 87U;
			}
			bool flag52 = this.label10.Text == "X";
			if (flag52)
			{
				Form1.x = 88U;
			}
			bool flag53 = this.label10.Text == "Y";
			if (flag53)
			{
				Form1.x = 89U;
			}
			bool flag54 = this.label10.Text == "Z";
			if (flag54)
			{
				Form1.x = 90U;
			}
			bool flag55 = this.label10.Text == "Up Key";
			if (flag55)
			{
				Form1.x = 38U;
			}
			bool flag56 = this.label10.Text == "Down Key";
			if (flag56)
			{
				Form1.x = 40U;
			}
			bool flag57 = this.label10.Text == "Left Key";
			if (flag57)
			{
				Form1.x = 37U;
			}
			bool flag58 = this.label10.Text == "Right Key";
			if (flag58)
			{
				Form1.x = 39U;
			}
			this.checkBox2.Checked = true;
			this.checkBox3.Checked = true;
			this.t = new Thread(new ThreadStart(this.Loop));
			this.t.Start();
			this.timer1.Start();
			this.ValueUpdater.Start();
			this.rs6checker.Start();
			this.timer2.Start();
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002978 File Offset: 0x00002978
		private void Enable()
		{
			int value = this.trackBar2.Value;
			int value2 = this.trackBar1.Value;
			int value3 = this.trackBar4.Value;
			int value4 = this.trackBar3.Value;
			Form1.sleeptime = value;
			Form1.strength = value2;
			Form1.sleeptime2 = value3;
			Form1.strength2 = value4;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000029D0 File Offset: 0x000029D0
		public void Loop()
		{
			for (;;)
			{
				Thread.Sleep(1);
				bool flag = ((int)Win32.GetKeyState(Form1.x) & 32768) > 0;
				if (flag)
				{
					Form1.Enabled = !Form1.Enabled;
					bool enabled = Form1.Enabled;
					if (enabled)
					{
						Win32.Beep(800U, 500U);
					}
					else
					{
						Win32.Beep(300U, 500U);
					}
				}
				bool flag2 = !Form1.Enabled;
				if (!flag2)
				{
					bool @checked = this.checkBox3.Checked;
					if (@checked)
					{
						Form1.xx = 2U;
					}
					else
					{
						Form1.xx = 1U;
					}
					bool checked2 = this.checkBox2.Checked;
					if (checked2)
					{
						bool flag3 = ((int)Win32.GetKeyState(Form1.xx) & 32768) > 0;
						if (flag3)
						{
							bool flag4 = ((int)Win32.GetKeyState(1U) & 32768) > 0;
							if (flag4)
							{
								bool flag5 = this.activepid == this.r6pid || this.activepid == this.r6pidvulkan;
								if (flag5)
								{
									Win32.Move(0, Form1.strength);
									Thread.Sleep(Form1.sleeptime);
									Win32.Move(Form1.strength2, 0);
									Thread.Sleep(Form1.sleeptime2);
								}
							}
						}
					}
					else
					{
						bool flag6 = ((int)Win32.GetKeyState(Form1.xx) & 32768) > 0;
						if (flag6)
						{
							bool flag7 = ((int)Win32.GetKeyState(1U) & 32768) > 0;
							if (flag7)
							{
								Thread.Sleep(Form1.sleeptime);
								Win32.Move(0, Form1.strength);
								Thread.Sleep(Form1.sleeptime2);
								Win32.Move(Form1.strength2, 0);
							}
						}
					}
				}
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002B7C File Offset: 0x00002B7C
		private void label14_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002B87 File Offset: 0x00002B87
		private void label13_Click(object sender, EventArgs e)
		{
			Settings.Default.Save();
			Application.Exit();
			Environment.Exit(1);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002BA4 File Offset: 0x00002BA4
		private void trackBar1_ValueChanged_1(object sender, EventArgs e)
		{
			this.label3.Text = "STRENGHT: " + this.trackBar1.Value.ToString();
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002BDC File Offset: 0x00002BDC
		private void trackBar2_ValueChanged(object sender, EventArgs e)
		{
			this.label4.Text = "SLOWNESS: " + this.trackBar2.Value.ToString();
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002C14 File Offset: 0x00002C14
		private void trackBar3_ValueChanged(object sender, EventArgs e)
		{
			bool flag = this.trackBar3.Value < 0;
			string str;
			if (flag)
			{
				str = "LEFT";
			}
			else
			{
				str = "RIGHT";
			}
			this.label5.Text = "STRENGHT: " + this.trackBar3.Value.ToString() + " " + str;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002C7C File Offset: 0x00002C7C
		private void trackBar4_ValueChanged(object sender, EventArgs e)
		{
			this.label6.Text = "SLOWNESS: " + this.trackBar4.Value.ToString();
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002CB4 File Offset: 0x00002CB4
		private void button5_Click(object sender, EventArgs e)
		{
			Settings.Default.keybind = this.comboBox1.SelectedItem.ToString();
			Settings.Default.Save();
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002CE0 File Offset: 0x00002CE0
		private void button9_Click(object sender, EventArgs e)
		{
			bool flag = this.comboBox2.SelectedIndex == -1;
			if (!flag)
			{
				this.opoutput.Text = this.comboBox2.SelectedItem.ToString();
				bool flag2 = this.comboBox2.SelectedItem.ToString() == "ACE";
				if (flag2)
				{
					this.Valuesetter.Text = Settings.Default.ACEstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.ACEsleep;
					this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.ACEstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.ACEsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				bool flag3 = this.comboBox2.SelectedItem.ToString() == "AMARU";
				if (flag3)
				{
					this.Valuesetter.Text = Settings.Default.AMARUstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.AMARUsleep;
					this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.AMARUstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.AMARUsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				bool flag4 = this.comboBox2.SelectedItem.ToString() == "ASH";
				if (flag4)
				{
					this.Valuesetter.Text = Settings.Default.ASHstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.ASHsleep;
					this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.ASHstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.ASHsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				bool flag5 = this.comboBox2.SelectedItem.ToString() == "BLACKBEARD";
				if (flag5)
				{
					this.Valuesetter.Text = Settings.Default.BLACKBEARDstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.BLACKBEARDsleep;
					this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.BLACKBEARDstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.BLACKBEARDsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				bool flag6 = this.comboBox2.SelectedItem.ToString() == "BLITZ";
				if (flag6)
				{
					this.Valuesetter.Text = Settings.Default.BLITZstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.BLITZsleep;
					this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.BLITZstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.BLITZsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				bool flag7 = this.comboBox2.SelectedItem.ToString() == "BUCK";
				if (flag7)
				{
					this.Valuesetter.Text = Settings.Default.BUCKstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.BUCKsleep;
					this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.BUCKstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.BUCKsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				bool flag8 = this.comboBox2.SelectedItem.ToString() == "CAPITÃO";
				if (flag8)
				{
					this.Valuesetter.Text = Settings.Default.CAPITÃOstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.CAPITÃOsleep;
					this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.CAPITÃOstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.CAPITÃOsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				bool flag9 = this.comboBox2.SelectedItem.ToString() == "DOKKAEBI";
				if (flag9)
				{
					this.Valuesetter.Text = Settings.Default.DOKKAEBIstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.DOKKAEBIsleep;
					this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.DOKKAEBIstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.DOKKAEBIsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				bool flag10 = this.comboBox2.SelectedItem.ToString() == "FINKA";
				if (flag10)
				{
					this.Valuesetter.Text = Settings.Default.FINKAstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.FINKAsleep;
					this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.FINKAstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.FINKAsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				bool flag11 = this.comboBox2.SelectedItem.ToString() == "FLORES";
				if (flag11)
				{
					this.Valuesetter.Text = Settings.Default.FLORESstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.FLORESsleep;
					this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.FLORESstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.FLORESsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				bool flag12 = this.comboBox2.SelectedItem.ToString() == "FUZE";
				if (flag12)
				{
					this.Valuesetter.Text = Settings.Default.FUZEstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.FUZEsleep;
					this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.FUZEstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.FUZEsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				bool flag13 = this.comboBox2.SelectedItem.ToString() == "GLAZ";
				if (flag13)
				{
					this.Valuesetter.Text = Settings.Default.GLAZstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.GLAZsleep;
					this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.GLAZstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.GLAZsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				bool flag14 = this.comboBox2.SelectedItem.ToString() == "GRIDLOCK";
				if (flag14)
				{
					this.Valuesetter.Text = Settings.Default.GRIDLOCKstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.GRIDLOCKsleep;
					this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.GRIDLOCKstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.GRIDLOCKsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				bool flag15 = this.comboBox2.SelectedItem.ToString() == "HIBANA";
				if (flag15)
				{
					this.Valuesetter.Text = Settings.Default.HIBANAstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.HIBANAsleep;
					this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.HIBANAstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.HIBANAsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				bool flag16 = this.comboBox2.SelectedItem.ToString() == "IANA";
				if (flag16)
				{
					this.Valuesetter.Text = Settings.Default.IANAstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.IANAsleep;
					this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.IANAstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.IANAsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				bool flag17 = this.comboBox2.SelectedItem.ToString() == "IQ";
				if (flag17)
				{
					this.Valuesetter.Text = Settings.Default.IQstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.IQsleep;
					this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.IQstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.IQsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				bool flag18 = this.comboBox2.SelectedItem.ToString() == "JACKAL";
				if (flag18)
				{
					this.Valuesetter.Text = Settings.Default.JACKALstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.JACKALsleep;
					this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.JACKALstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.JACKALsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				bool flag19 = this.comboBox2.SelectedItem.ToString() == "KALI";
				if (flag19)
				{
					this.Valuesetter.Text = Settings.Default.KALIstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.KALIsleep;
					this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.KALIstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.KALIsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				bool flag20 = this.comboBox2.SelectedItem.ToString() == "LION";
				if (flag20)
				{
					this.Valuesetter.Text = Settings.Default.LIONstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.LIONsleep;
					this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.LIONstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.LIONsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				bool flag21 = this.comboBox2.SelectedItem.ToString() == "MAVERICK";
				if (flag21)
				{
					this.Valuesetter.Text = Settings.Default.MAVERICKstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.MAVERICKsleep;
					this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.MAVERICKstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.MAVERICKsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				bool flag22 = this.comboBox2.SelectedItem.ToString() == "MONTAGNE";
				if (flag22)
				{
					this.Valuesetter.Text = Settings.Default.MONTAGNEstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.MONTAGNEsleep;
					this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.MONTAGNEstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.MONTAGNEsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				bool flag23 = this.comboBox2.SelectedItem.ToString() == "NOMAD";
				if (flag23)
				{
					this.Valuesetter.Text = Settings.Default.NOMADstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.NOMADsleep;
					this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.NOMADstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.NOMADsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				bool flag24 = this.comboBox2.SelectedItem.ToString() == "NØKK";
				if (flag24)
				{
					this.Valuesetter.Text = Settings.Default.NØKKstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.NØKKsleep;
					this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.NØKKstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.NØKKsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				bool flag25 = this.comboBox2.SelectedItem.ToString() == "OSA";
				if (flag25)
				{
					this.Valuesetter.Text = Settings.Default.OSAstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.OSAsleep;
					this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.OSAstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.OSAsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				bool flag26 = this.comboBox2.SelectedItem.ToString() == "SENS";
				if (flag26)
				{
					this.Valuesetter.Text = Settings.Default.SENSstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.SENSsleep;
					this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.SENSstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.SENSsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				bool flag27 = this.comboBox2.SelectedItem.ToString() == "SLEDGE";
				if (flag27)
				{
					this.Valuesetter.Text = Settings.Default.SLEDGEstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.SLEDGEsleep;
					this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.SLEDGEstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.SLEDGEsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				bool flag28 = this.comboBox2.SelectedItem.ToString() == "THATCHER";
				if (flag28)
				{
					this.Valuesetter.Text = Settings.Default.THATCHERstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.THATCHERsleep;
					this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.THATCHERstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.THATCHERsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				bool flag29 = this.comboBox2.SelectedItem.ToString() == "THERMITE";
				if (flag29)
				{
					this.Valuesetter.Text = Settings.Default.THERMITEstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.THERMITEsleep;
					this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.THERMITEstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.THERMITEsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				bool flag30 = this.comboBox2.SelectedItem.ToString() == "TWITCH";
				if (flag30)
				{
					this.Valuesetter.Text = Settings.Default.TWITCHstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.TWITCHsleep;
					this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.TWITCHstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.TWITCHsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				bool flag31 = this.comboBox2.SelectedItem.ToString() == "YING";
				if (flag31)
				{
					this.Valuesetter.Text = Settings.Default.YINGstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.YINGsleep;
					this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.YINGstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.YINGsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				bool flag32 = this.comboBox2.SelectedItem.ToString() == "ZERO";
				if (flag32)
				{
					this.Valuesetter.Text = Settings.Default.ZEROstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.ZEROsleep;
					this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.ZEROstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.ZEROsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				bool flag33 = this.comboBox2.SelectedItem.ToString() == "ZOFIA";
				if (flag33)
				{
					this.Valuesetter.Text = Settings.Default.ZOFIAstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.ZOFIAsleep;
					this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.ZOFIAstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.ZOFIAsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
			}
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00004ABC File Offset: 0x00004ABC
		private void button8_Click(object sender, EventArgs e)
		{
			bool flag = this.comboBox3.SelectedIndex == -1;
			if (!flag)
			{
				this.opoutput.Text = this.comboBox3.SelectedItem.ToString();
				bool flag2 = this.comboBox3.SelectedItem.ToString() == "ALIBI";
				if (flag2)
				{
					this.Valuesetter.Text = Settings.Default.ALIBIstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.ALIBIsleep;
					this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.ALIBIstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.ALIBIsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				bool flag3 = this.comboBox3.SelectedItem.ToString() == "ARUNI";
				if (flag3)
				{
					this.Valuesetter.Text = Settings.Default.ARUNIstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.ARUNIsleep;
					this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.ARUNIstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.ARUNIsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				bool flag4 = this.comboBox3.SelectedItem.ToString() == "AZAMI";
				if (flag4)
				{
					this.Valuesetter.Text = Settings.Default.AZAMIstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.AZAMIsleep;
					this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.AZAMIstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.AZAMIsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				bool flag5 = this.comboBox3.SelectedItem.ToString() == "BANDIT";
				if (flag5)
				{
					this.Valuesetter.Text = Settings.Default.BANDITstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.BANDITsleep;
					this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.BANDITstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.BANDITsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				bool flag6 = this.comboBox3.SelectedItem.ToString() == "CASTLE";
				if (flag6)
				{
					this.Valuesetter.Text = Settings.Default.CASTLEstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.CASTLEsleep;
					this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.CASTLEstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.CASTLEsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				bool flag7 = this.comboBox3.SelectedItem.ToString() == "CAVEIRA";
				if (flag7)
				{
					this.Valuesetter.Text = Settings.Default.CAVEIRAstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.CAVEIRAsleep;
					this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.CAVEIRAstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.CAVEIRAsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				bool flag8 = this.comboBox3.SelectedItem.ToString() == "CLASH";
				if (flag8)
				{
					this.Valuesetter.Text = Settings.Default.CLASHstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.CLASHsleep;
					this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.CLASHstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.CLASHsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				bool flag9 = this.comboBox3.SelectedItem.ToString() == "DOC";
				if (flag9)
				{
					this.Valuesetter.Text = Settings.Default.DOCstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.DOCsleep;
					this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.DOCstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.DOCsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				bool flag10 = this.comboBox3.SelectedItem.ToString() == "ECHO";
				if (flag10)
				{
					this.Valuesetter.Text = Settings.Default.ECHOstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.ECHOsleep;
					this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.ECHOstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.ECHOsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				bool flag11 = this.comboBox3.SelectedItem.ToString() == "ELA";
				if (flag11)
				{
					this.Valuesetter.Text = Settings.Default.ELAstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.ELAsleep;
					this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.ELAstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.ELAsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				bool flag12 = this.comboBox3.SelectedItem.ToString() == "FROST";
				if (flag12)
				{
					this.Valuesetter.Text = Settings.Default.FROSTstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.FROSTsleep;
					this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.FROSTstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.FROSTsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				bool flag13 = this.comboBox3.SelectedItem.ToString() == "GOYO";
				if (flag13)
				{
					this.Valuesetter.Text = Settings.Default.GOYOstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.GOYOsleep;
					this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.GOYOstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.GOYOsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				bool flag14 = this.comboBox3.SelectedItem.ToString() == "JÄGER";
				if (flag14)
				{
					this.Valuesetter.Text = Settings.Default.JÄGERstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.JÄGERsleep;
					this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.JÄGERstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.JÄGERsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				bool flag15 = this.comboBox3.SelectedItem.ToString() == "KAID";
				if (flag15)
				{
					this.Valuesetter.Text = Settings.Default.KAIDstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.KAIDsleep;
					this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.KAIDstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.KAIDsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				bool flag16 = this.comboBox3.SelectedItem.ToString() == "KAPKAN";
				if (flag16)
				{
					this.Valuesetter.Text = Settings.Default.KAPKANstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.KAPKANsleep;
					this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.KAPKANstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.KAPKANsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				bool flag17 = this.comboBox3.SelectedItem.ToString() == "LESION";
				if (flag17)
				{
					this.Valuesetter.Text = Settings.Default.LESIONstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.LESIONsleep;
					this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.LESIONstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.LESIONsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				bool flag18 = this.comboBox3.SelectedItem.ToString() == "MAESTRO";
				if (flag18)
				{
					this.Valuesetter.Text = Settings.Default.MAESTROstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.MAESTROsleep;
					this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.MAESTROstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.MAESTROsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				bool flag19 = this.comboBox3.SelectedItem.ToString() == "MELUSI";
				if (flag19)
				{
					this.Valuesetter.Text = Settings.Default.MELUSIstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.MELUSIsleep;
					this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.MELUSIstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.MELUSIsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				bool flag20 = this.comboBox3.SelectedItem.ToString() == "MIRA";
				if (flag20)
				{
					this.Valuesetter.Text = Settings.Default.MIRAstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.MIRAsleep;
					this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.MIRAstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.MIRAsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				bool flag21 = this.comboBox3.SelectedItem.ToString() == "MOZZIE";
				if (flag21)
				{
					this.Valuesetter.Text = Settings.Default.MOZZIEstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.MOZZIEsleep;
					this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.MOZZIEstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.MOZZIEsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				bool flag22 = this.comboBox3.SelectedItem.ToString() == "MUTE";
				if (flag22)
				{
					this.Valuesetter.Text = Settings.Default.MUTEstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.MUTEsleep;
					this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.MUTEstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.MUTEsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				bool flag23 = this.comboBox3.SelectedItem.ToString() == "ORYX";
				if (flag23)
				{
					this.Valuesetter.Text = Settings.Default.ORYXstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.ORYXsleep;
					this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.ORYXstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.ORYXsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				bool flag24 = this.comboBox3.SelectedItem.ToString() == "PULSE";
				if (flag24)
				{
					this.Valuesetter.Text = Settings.Default.PULSEstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.PULSEsleep;
					this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.PULSEstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.PULSEsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				bool flag25 = this.comboBox3.SelectedItem.ToString() == "ROOK";
				if (flag25)
				{
					this.Valuesetter.Text = Settings.Default.ROOKstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.ROOKsleep;
					this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.ROOKstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.ROOKsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				bool flag26 = this.comboBox3.SelectedItem.ToString() == "SMOKE";
				if (flag26)
				{
					this.Valuesetter.Text = Settings.Default.SMOKEstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.SMOKEsleep;
					this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.SMOKEstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.SMOKEsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				bool flag27 = this.comboBox3.SelectedItem.ToString() == "TACHANKA";
				if (flag27)
				{
					this.Valuesetter.Text = Settings.Default.TACHANKAstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.TACHANKAsleep;
					this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.TACHANKAstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.TACHANKAsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				bool flag28 = this.comboBox3.SelectedItem.ToString() == "THORN";
				if (flag28)
				{
					this.Valuesetter.Text = Settings.Default.THORNstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.THORNsleep;
					this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.THORNstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.THORNsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				bool flag29 = this.comboBox3.SelectedItem.ToString() == "THUNDERBIRD";
				if (flag29)
				{
					this.Valuesetter.Text = Settings.Default.THUNDERBIRDstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.THUNDERBIRDsleep;
					this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.THUNDERBIRDstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.THUNDERBIRDsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				bool flag30 = this.comboBox3.SelectedItem.ToString() == "VALKYRIE";
				if (flag30)
				{
					this.Valuesetter.Text = Settings.Default.VALKYRIEstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.VALKYRIEsleep;
					this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.VALKYRIEstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.VALKYRIEsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				bool flag31 = this.comboBox3.SelectedItem.ToString() == "VIGIL";
				if (flag31)
				{
					this.Valuesetter.Text = Settings.Default.VIGILstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.VIGILsleep;
					this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.VIGILstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.VIGILsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				bool flag32 = this.comboBox3.SelectedItem.ToString() == "WAMAI";
				if (flag32)
				{
					this.Valuesetter.Text = Settings.Default.WAMAIstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.WAMAIsleep;
					this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.WAMAIstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.WAMAIsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
				bool flag33 = this.comboBox3.SelectedItem.ToString() == "WARDEN";
				if (flag33)
				{
					this.Valuesetter.Text = Settings.Default.WARDENstrenght;
					this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.WARDENsleep;
					this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.WARDENstrenght2;
					this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
					this.Valuesetter.Text = Settings.Default.WARDENsleep2;
					this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				}
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00006898 File Offset: 0x00006898
		private void button6_Click(object sender, EventArgs e)
		{
			bool flag = this.comboBox2.SelectedIndex == -1;
			if (!flag)
			{
				bool flag2 = this.comboBox2.SelectedItem.ToString() == "ACE";
				if (flag2)
				{
					Settings.Default.ACEstrenght = this.trackBar1.Value.ToString();
					Settings.Default.ACEstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.ACEsleep = this.trackBar2.Value.ToString();
					Settings.Default.ACEsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				bool flag3 = this.comboBox2.SelectedItem.ToString() == "AMARU";
				if (flag3)
				{
					Settings.Default.AMARUstrenght = this.trackBar1.Value.ToString();
					Settings.Default.AMARUstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.AMARUsleep = this.trackBar2.Value.ToString();
					Settings.Default.AMARUsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				bool flag4 = this.comboBox2.SelectedItem.ToString() == "ASH";
				if (flag4)
				{
					Settings.Default.ASHstrenght = this.trackBar1.Value.ToString();
					Settings.Default.ASHsleep = this.trackBar2.Value.ToString();
					Settings.Default.ASHstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.ASHsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				bool flag5 = this.comboBox2.SelectedItem.ToString() == "BLACKBEARD";
				if (flag5)
				{
					Settings.Default.BLACKBEARDstrenght = this.trackBar1.Value.ToString();
					Settings.Default.BLACKBEARDsleep = this.trackBar2.Value.ToString();
					Settings.Default.BLACKBEARDstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.BLACKBEARDsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				bool flag6 = this.comboBox2.SelectedItem.ToString() == "BLITZ";
				if (flag6)
				{
					Settings.Default.BLITZstrenght = this.trackBar1.Value.ToString();
					Settings.Default.BLITZsleep = this.trackBar2.Value.ToString();
					Settings.Default.BLITZstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.BLITZsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				bool flag7 = this.comboBox2.SelectedItem.ToString() == "BUCK";
				if (flag7)
				{
					Settings.Default.BUCKstrenght = this.trackBar1.Value.ToString();
					Settings.Default.BUCKsleep = this.trackBar2.Value.ToString();
					Settings.Default.BUCKstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.BUCKsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				bool flag8 = this.comboBox2.SelectedItem.ToString() == "CAPITÃO";
				if (flag8)
				{
					Settings.Default.CAPITÃOstrenght = this.trackBar1.Value.ToString();
					Settings.Default.CAPITÃOsleep = this.trackBar2.Value.ToString();
					Settings.Default.CAPITÃOstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.CAPITÃOsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				bool flag9 = this.comboBox2.SelectedItem.ToString() == "DOKKAEBI";
				if (flag9)
				{
					Settings.Default.DOKKAEBIstrenght = this.trackBar1.Value.ToString();
					Settings.Default.DOKKAEBIsleep = this.trackBar2.Value.ToString();
					Settings.Default.DOKKAEBIstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.DOKKAEBIsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				bool flag10 = this.comboBox2.SelectedItem.ToString() == "FINKA";
				if (flag10)
				{
					Settings.Default.FINKAstrenght = this.trackBar1.Value.ToString();
					Settings.Default.FINKAsleep = this.trackBar2.Value.ToString();
					Settings.Default.FINKAstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.FINKAsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				bool flag11 = this.comboBox2.SelectedItem.ToString() == "FLORES";
				if (flag11)
				{
					Settings.Default.FLORESstrenght = this.trackBar1.Value.ToString();
					Settings.Default.FLORESsleep = this.trackBar2.Value.ToString();
					Settings.Default.FLORESstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.FLORESsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				bool flag12 = this.comboBox2.SelectedItem.ToString() == "FUZE";
				if (flag12)
				{
					Settings.Default.FUZEstrenght = this.trackBar1.Value.ToString();
					Settings.Default.FUZEsleep = this.trackBar2.Value.ToString();
					Settings.Default.FUZEstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.FUZEsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				bool flag13 = this.comboBox2.SelectedItem.ToString() == "GLAZ";
				if (flag13)
				{
					Settings.Default.GLAZstrenght = this.trackBar1.Value.ToString();
					Settings.Default.GLAZsleep = this.trackBar2.Value.ToString();
					Settings.Default.GLAZstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.GLAZsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				bool flag14 = this.comboBox2.SelectedItem.ToString() == "GRIDLOCK";
				if (flag14)
				{
					Settings.Default.GRIDLOCKstrenght = this.trackBar1.Value.ToString();
					Settings.Default.GRIDLOCKsleep = this.trackBar2.Value.ToString();
					Settings.Default.GRIDLOCKstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.GRIDLOCKsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				bool flag15 = this.comboBox2.SelectedItem.ToString() == "HIBANA";
				if (flag15)
				{
					Settings.Default.HIBANAstrenght = this.trackBar1.Value.ToString();
					Settings.Default.HIBANAsleep = this.trackBar2.Value.ToString();
					Settings.Default.HIBANAstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.HIBANAsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				bool flag16 = this.comboBox2.SelectedItem.ToString() == "IANA";
				if (flag16)
				{
					Settings.Default.IANAstrenght = this.trackBar1.Value.ToString();
					Settings.Default.IANAsleep = this.trackBar2.Value.ToString();
					Settings.Default.IANAstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.IANAsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				bool flag17 = this.comboBox2.SelectedItem.ToString() == "IQ";
				if (flag17)
				{
					Settings.Default.IQstrenght = this.trackBar1.Value.ToString();
					Settings.Default.IQsleep = this.trackBar2.Value.ToString();
					Settings.Default.IQstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.IQsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				bool flag18 = this.comboBox2.SelectedItem.ToString() == "JACKAL";
				if (flag18)
				{
					Settings.Default.JACKALstrenght = this.trackBar1.Value.ToString();
					Settings.Default.JACKALsleep = this.trackBar2.Value.ToString();
					Settings.Default.JACKALstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.JACKALsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				bool flag19 = this.comboBox2.SelectedItem.ToString() == "KALI";
				if (flag19)
				{
					Settings.Default.KALIstrenght = this.trackBar1.Value.ToString();
					Settings.Default.KALIsleep = this.trackBar2.Value.ToString();
					Settings.Default.KALIstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.KALIsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				bool flag20 = this.comboBox2.SelectedItem.ToString() == "LION";
				if (flag20)
				{
					Settings.Default.LIONstrenght = this.trackBar1.Value.ToString();
					Settings.Default.LIONsleep = this.trackBar2.Value.ToString();
					Settings.Default.LIONstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.LIONsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				bool flag21 = this.comboBox2.SelectedItem.ToString() == "MAVERICK";
				if (flag21)
				{
					Settings.Default.MAVERICKstrenght = this.trackBar1.Value.ToString();
					Settings.Default.MAVERICKsleep = this.trackBar2.Value.ToString();
					Settings.Default.MAVERICKstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.MAVERICKsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				bool flag22 = this.comboBox2.SelectedItem.ToString() == "MONTAGNE";
				if (flag22)
				{
					Settings.Default.MONTAGNEstrenght = this.trackBar1.Value.ToString();
					Settings.Default.MONTAGNEsleep = this.trackBar2.Value.ToString();
					Settings.Default.MONTAGNEstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.MONTAGNEsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				bool flag23 = this.comboBox2.SelectedItem.ToString() == "NOMAD";
				if (flag23)
				{
					Settings.Default.NOMADstrenght = this.trackBar1.Value.ToString();
					Settings.Default.NOMADsleep = this.trackBar2.Value.ToString();
					Settings.Default.NOMADstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.NOMADsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				bool flag24 = this.comboBox2.SelectedItem.ToString() == "NØKK";
				if (flag24)
				{
					Settings.Default.NØKKstrenght = this.trackBar1.Value.ToString();
					Settings.Default.NØKKsleep = this.trackBar2.Value.ToString();
					Settings.Default.NØKKstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.NØKKsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				bool flag25 = this.comboBox2.SelectedItem.ToString() == "OSA";
				if (flag25)
				{
					Settings.Default.OSAstrenght = this.trackBar1.Value.ToString();
					Settings.Default.OSAsleep = this.trackBar2.Value.ToString();
					Settings.Default.OSAstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.OSAsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				bool flag26 = this.comboBox2.SelectedItem.ToString() == "SENS";
				if (flag26)
				{
					Settings.Default.SENSstrenght = this.trackBar1.Value.ToString();
					Settings.Default.SENSsleep = this.trackBar2.Value.ToString();
					Settings.Default.SENSstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.SENSsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				bool flag27 = this.comboBox2.SelectedItem.ToString() == "SLEDGE";
				if (flag27)
				{
					Settings.Default.SLEDGEstrenght = this.trackBar1.Value.ToString();
					Settings.Default.SLEDGEsleep = this.trackBar2.Value.ToString();
					Settings.Default.SLEDGEstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.SLEDGEsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				bool flag28 = this.comboBox2.SelectedItem.ToString() == "THATCHER";
				if (flag28)
				{
					Settings.Default.THATCHERstrenght = this.trackBar1.Value.ToString();
					Settings.Default.THATCHERsleep = this.trackBar2.Value.ToString();
					Settings.Default.THATCHERstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.THATCHERsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				bool flag29 = this.comboBox2.SelectedItem.ToString() == "THERMITE";
				if (flag29)
				{
					Settings.Default.THERMITEstrenght = this.trackBar1.Value.ToString();
					Settings.Default.THERMITEsleep = this.trackBar2.Value.ToString();
					Settings.Default.THERMITEstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.THERMITEsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				bool flag30 = this.comboBox2.SelectedItem.ToString() == "TWITCH";
				if (flag30)
				{
					Settings.Default.TWITCHstrenght = this.trackBar1.Value.ToString();
					Settings.Default.TWITCHsleep = this.trackBar2.Value.ToString();
					Settings.Default.TWITCHstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.TWITCHsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				bool flag31 = this.comboBox2.SelectedItem.ToString() == "YING";
				if (flag31)
				{
					Settings.Default.YINGstrenght = this.trackBar1.Value.ToString();
					Settings.Default.YINGsleep = this.trackBar2.Value.ToString();
					Settings.Default.YINGstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.YINGsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				bool flag32 = this.comboBox2.SelectedItem.ToString() == "ZERO";
				if (flag32)
				{
					Settings.Default.ZEROstrenght = this.trackBar1.Value.ToString();
					Settings.Default.ZEROsleep = this.trackBar2.Value.ToString();
					Settings.Default.ZEROstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.ZEROsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				bool flag33 = this.comboBox2.SelectedItem.ToString() == "ZOFIA";
				if (flag33)
				{
					Settings.Default.ZOFIAstrenght = this.trackBar1.Value.ToString();
					Settings.Default.ZOFIAsleep = this.trackBar2.Value.ToString();
					Settings.Default.ZOFIAstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.ZOFIAsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00007DBC File Offset: 0x00007DBC
		private void button3_Click(object sender, EventArgs e)
		{
			bool flag = this.comboBox2.SelectedIndex == -1;
			if (!flag)
			{
				bool flag2 = this.comboBox3.SelectedItem.ToString() == "ALIBI";
				if (flag2)
				{
					Settings.Default.ALIBIstrenght = this.trackBar1.Value.ToString();
					Settings.Default.ALIBIsleep = this.trackBar2.Value.ToString();
					Settings.Default.ALIBIstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.ALIBIsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				bool flag3 = this.comboBox3.SelectedItem.ToString() == "ARUNI";
				if (flag3)
				{
					Settings.Default.ARUNIstrenght = this.trackBar1.Value.ToString();
					Settings.Default.ARUNIsleep = this.trackBar2.Value.ToString();
					Settings.Default.ARUNIstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.ARUNIsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				bool flag4 = this.comboBox3.SelectedItem.ToString() == "AZAMI";
				if (flag4)
				{
					Settings.Default.AZAMIstrenght = this.trackBar1.Value.ToString();
					Settings.Default.AZAMIsleep = this.trackBar2.Value.ToString();
					Settings.Default.AZAMIstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.AZAMIsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				bool flag5 = this.comboBox3.SelectedItem.ToString() == "BANDIT";
				if (flag5)
				{
					Settings.Default.BANDITstrenght = this.trackBar1.Value.ToString();
					Settings.Default.BANDITsleep = this.trackBar2.Value.ToString();
					Settings.Default.BANDITstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.BANDITsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				bool flag6 = this.comboBox3.SelectedItem.ToString() == "CASTLE";
				if (flag6)
				{
					Settings.Default.CASTLEstrenght = this.trackBar1.Value.ToString();
					Settings.Default.CASTLEsleep = this.trackBar2.Value.ToString();
					Settings.Default.CASTLEstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.CASTLEsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				bool flag7 = this.comboBox3.SelectedItem.ToString() == "CAVEIRA";
				if (flag7)
				{
					Settings.Default.CAVEIRAstrenght = this.trackBar1.Value.ToString();
					Settings.Default.CAVEIRAsleep = this.trackBar2.Value.ToString();
					Settings.Default.CAVEIRAstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.CAVEIRAsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				bool flag8 = this.comboBox3.SelectedItem.ToString() == "CLASH";
				if (flag8)
				{
					Settings.Default.CLASHstrenght = this.trackBar1.Value.ToString();
					Settings.Default.CLASHsleep = this.trackBar2.Value.ToString();
					Settings.Default.CLASHstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.CLASHsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				bool flag9 = this.comboBox3.SelectedItem.ToString() == "DOC";
				if (flag9)
				{
					Settings.Default.DOCstrenght = this.trackBar1.Value.ToString();
					Settings.Default.DOCsleep = this.trackBar2.Value.ToString();
					Settings.Default.DOCstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.DOCsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				bool flag10 = this.comboBox3.SelectedItem.ToString() == "ECHO";
				if (flag10)
				{
					Settings.Default.ECHOstrenght = this.trackBar1.Value.ToString();
					Settings.Default.ECHOsleep = this.trackBar2.Value.ToString();
					Settings.Default.ECHOstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.ECHOsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				bool flag11 = this.comboBox3.SelectedItem.ToString() == "ELA";
				if (flag11)
				{
					Settings.Default.ELAstrenght = this.trackBar1.Value.ToString();
					Settings.Default.ELAsleep = this.trackBar2.Value.ToString();
					Settings.Default.ELAstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.ELAsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				bool flag12 = this.comboBox3.SelectedItem.ToString() == "FROST";
				if (flag12)
				{
					Settings.Default.FROSTstrenght = this.trackBar1.Value.ToString();
					Settings.Default.FROSTsleep = this.trackBar2.Value.ToString();
					Settings.Default.FROSTstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.FROSTsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				bool flag13 = this.comboBox3.SelectedItem.ToString() == "GOYO";
				if (flag13)
				{
					Settings.Default.GOYOstrenght = this.trackBar1.Value.ToString();
					Settings.Default.GOYOsleep = this.trackBar2.Value.ToString();
					Settings.Default.GOYOstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.GOYOsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				bool flag14 = this.comboBox3.SelectedItem.ToString() == "JÄGER";
				if (flag14)
				{
					Settings.Default.JÄGERstrenght = this.trackBar1.Value.ToString();
					Settings.Default.JÄGERsleep = this.trackBar2.Value.ToString();
					Settings.Default.JÄGERstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.JÄGERsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				bool flag15 = this.comboBox3.SelectedItem.ToString() == "KAID";
				if (flag15)
				{
					Settings.Default.KAIDstrenght = this.trackBar1.Value.ToString();
					Settings.Default.KAIDsleep = this.trackBar2.Value.ToString();
					Settings.Default.KAIDstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.KAIDsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				bool flag16 = this.comboBox3.SelectedItem.ToString() == "KAPKAN";
				if (flag16)
				{
					Settings.Default.KAPKANstrenght = this.trackBar1.Value.ToString();
					Settings.Default.KAPKANsleep = this.trackBar2.Value.ToString();
					Settings.Default.KAPKANstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.KAPKANsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				bool flag17 = this.comboBox3.SelectedItem.ToString() == "LESION";
				if (flag17)
				{
					Settings.Default.LESIONstrenght = this.trackBar1.Value.ToString();
					Settings.Default.LESIONsleep = this.trackBar2.Value.ToString();
					Settings.Default.LESIONstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.LESIONsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				bool flag18 = this.comboBox3.SelectedItem.ToString() == "MAESTRO";
				if (flag18)
				{
					Settings.Default.MAESTROstrenght = this.trackBar1.Value.ToString();
					Settings.Default.MAESTROsleep = this.trackBar2.Value.ToString();
					Settings.Default.MAESTROstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.MAESTROsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				bool flag19 = this.comboBox3.SelectedItem.ToString() == "MELUSI";
				if (flag19)
				{
					Settings.Default.MELUSIstrenght = this.trackBar1.Value.ToString();
					Settings.Default.MELUSIsleep = this.trackBar2.Value.ToString();
					Settings.Default.MELUSIstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.MELUSIsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				bool flag20 = this.comboBox3.SelectedItem.ToString() == "MIRA";
				if (flag20)
				{
					Settings.Default.MIRAstrenght = this.trackBar1.Value.ToString();
					Settings.Default.MIRAsleep = this.trackBar2.Value.ToString();
					Settings.Default.MIRAstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.MIRAsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				bool flag21 = this.comboBox3.SelectedItem.ToString() == "MOZZIE";
				if (flag21)
				{
					Settings.Default.MOZZIEstrenght = this.trackBar1.Value.ToString();
					Settings.Default.MOZZIEsleep = this.trackBar2.Value.ToString();
					Settings.Default.MOZZIEstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.MOZZIEsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				bool flag22 = this.comboBox3.SelectedItem.ToString() == "MUTE";
				if (flag22)
				{
					Settings.Default.MUTEstrenght = this.trackBar1.Value.ToString();
					Settings.Default.MUTEsleep = this.trackBar2.Value.ToString();
					Settings.Default.MUTEstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.MUTEsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				bool flag23 = this.comboBox3.SelectedItem.ToString() == "ORYX";
				if (flag23)
				{
					Settings.Default.ORYXstrenght = this.trackBar1.Value.ToString();
					Settings.Default.ORYXsleep = this.trackBar2.Value.ToString();
					Settings.Default.ORYXstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.ORYXsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				bool flag24 = this.comboBox3.SelectedItem.ToString() == "PULSE";
				if (flag24)
				{
					Settings.Default.PULSEstrenght = this.trackBar1.Value.ToString();
					Settings.Default.PULSEsleep = this.trackBar2.Value.ToString();
					Settings.Default.PULSEstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.PULSEsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				bool flag25 = this.comboBox3.SelectedItem.ToString() == "ROOK";
				if (flag25)
				{
					Settings.Default.ROOKstrenght = this.trackBar1.Value.ToString();
					Settings.Default.ROOKsleep = this.trackBar2.Value.ToString();
					Settings.Default.ROOKstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.ROOKsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				bool flag26 = this.comboBox3.SelectedItem.ToString() == "SMOKE";
				if (flag26)
				{
					Settings.Default.SMOKEstrenght = this.trackBar1.Value.ToString();
					Settings.Default.SMOKEsleep = this.trackBar2.Value.ToString();
					Settings.Default.SMOKEstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.SMOKEsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				bool flag27 = this.comboBox3.SelectedItem.ToString() == "TACHANKA";
				if (flag27)
				{
					Settings.Default.TACHANKAstrenght = this.trackBar1.Value.ToString();
					Settings.Default.TACHANKAsleep = this.trackBar2.Value.ToString();
					Settings.Default.TACHANKAstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.TACHANKAsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				bool flag28 = this.comboBox3.SelectedItem.ToString() == "THORN";
				if (flag28)
				{
					Settings.Default.THORNstrenght = this.trackBar1.Value.ToString();
					Settings.Default.THORNsleep = this.trackBar2.Value.ToString();
					Settings.Default.THORNstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.THORNsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				bool flag29 = this.comboBox3.SelectedItem.ToString() == "THUNDERBIRD";
				if (flag29)
				{
					Settings.Default.THUNDERBIRDstrenght = this.trackBar1.Value.ToString();
					Settings.Default.THUNDERBIRDsleep = this.trackBar2.Value.ToString();
					Settings.Default.THUNDERBIRDstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.THUNDERBIRDsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				bool flag30 = this.comboBox3.SelectedItem.ToString() == "VALKYRIE";
				if (flag30)
				{
					Settings.Default.VALKYRIEstrenght = this.trackBar1.Value.ToString();
					Settings.Default.VALKYRIEsleep = this.trackBar2.Value.ToString();
					Settings.Default.VALKYRIEstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.VALKYRIEsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				bool flag31 = this.comboBox3.SelectedItem.ToString() == "VIGIL";
				if (flag31)
				{
					Settings.Default.VIGILstrenght = this.trackBar1.Value.ToString();
					Settings.Default.VIGILsleep = this.trackBar2.Value.ToString();
					Settings.Default.VIGILstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.VIGILsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				bool flag32 = this.comboBox3.SelectedItem.ToString() == "WAMAI";
				if (flag32)
				{
					Settings.Default.WAMAIstrenght = this.trackBar1.Value.ToString();
					Settings.Default.WAMAIsleep = this.trackBar2.Value.ToString();
					Settings.Default.WAMAIstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.WAMAIsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
				bool flag33 = this.comboBox3.SelectedItem.ToString() == "WARDEN";
				if (flag33)
				{
					Settings.Default.WARDENstrenght = this.trackBar1.Value.ToString();
					Settings.Default.WARDENsleep = this.trackBar2.Value.ToString();
					Settings.Default.WARDENstrenght2 = this.trackBar3.Value.ToString();
					Settings.Default.WARDENsleep2 = this.trackBar4.Value.ToString();
					Settings.Default.Save();
				}
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000092E0 File Offset: 0x000092E0
		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = this.comboBox1.SelectedIndex == -1;
			if (!flag)
			{
				this.label10.Text = this.comboBox1.SelectedItem.ToString();
			}
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00009320 File Offset: 0x00009320
		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = this.comboBox2.SelectedItem.ToString() == "ACE";
			if (flag)
			{
				this.Valuesetter.Text = Settings.Default.ACEstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.ACEsleep;
				this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.ACEstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.ACEsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox2.SelectedItem.ToString();
			}
			bool flag2 = this.comboBox2.SelectedItem.ToString() == "AMARU";
			if (flag2)
			{
				this.Valuesetter.Text = Settings.Default.AMARUstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.AMARUsleep;
				this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.AMARUstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.AMARUsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox2.SelectedItem.ToString();
			}
			bool flag3 = this.comboBox2.SelectedItem.ToString() == "ASH";
			if (flag3)
			{
				this.Valuesetter.Text = Settings.Default.ASHstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.ASHsleep;
				this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.ASHstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.ASHsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox2.SelectedItem.ToString();
			}
			bool flag4 = this.comboBox2.SelectedItem.ToString() == "BLACKBEARD";
			if (flag4)
			{
				this.Valuesetter.Text = Settings.Default.BLACKBEARDstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.BLACKBEARDsleep;
				this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.BLACKBEARDstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.BLACKBEARDsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox2.SelectedItem.ToString();
			}
			bool flag5 = this.comboBox2.SelectedItem.ToString() == "BLITZ";
			if (flag5)
			{
				this.Valuesetter.Text = Settings.Default.BLITZstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.BLITZsleep;
				this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.BLITZstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.BLITZsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox2.SelectedItem.ToString();
			}
			bool flag6 = this.comboBox2.SelectedItem.ToString() == "BUCK";
			if (flag6)
			{
				this.Valuesetter.Text = Settings.Default.BUCKstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.BUCKsleep;
				this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.BUCKstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.BUCKsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox2.SelectedItem.ToString();
			}
			bool flag7 = this.comboBox2.SelectedItem.ToString() == "CAPITÃO";
			if (flag7)
			{
				this.Valuesetter.Text = Settings.Default.CAPITÃOstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.CAPITÃOsleep;
				this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.CAPITÃOstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.CAPITÃOsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox2.SelectedItem.ToString();
			}
			bool flag8 = this.comboBox2.SelectedItem.ToString() == "DOKKAEBI";
			if (flag8)
			{
				this.Valuesetter.Text = Settings.Default.DOKKAEBIstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.DOKKAEBIsleep;
				this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.DOKKAEBIstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.DOKKAEBIsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox2.SelectedItem.ToString();
			}
			bool flag9 = this.comboBox2.SelectedItem.ToString() == "FINKA";
			if (flag9)
			{
				this.Valuesetter.Text = Settings.Default.FINKAstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.FINKAsleep;
				this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.FINKAstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.FINKAsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox2.SelectedItem.ToString();
			}
			bool flag10 = this.comboBox2.SelectedItem.ToString() == "FLORES";
			if (flag10)
			{
				this.Valuesetter.Text = Settings.Default.FLORESstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.FLORESsleep;
				this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.FLORESstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.FLORESsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox2.SelectedItem.ToString();
			}
			bool flag11 = this.comboBox2.SelectedItem.ToString() == "FUZE";
			if (flag11)
			{
				this.Valuesetter.Text = Settings.Default.FUZEstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.FUZEsleep;
				this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.FUZEstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.FUZEsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox2.SelectedItem.ToString();
			}
			bool flag12 = this.comboBox2.SelectedItem.ToString() == "GLAZ";
			if (flag12)
			{
				this.Valuesetter.Text = Settings.Default.GLAZstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.GLAZsleep;
				this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.GLAZstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.GLAZsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox2.SelectedItem.ToString();
			}
			bool flag13 = this.comboBox2.SelectedItem.ToString() == "GRIDLOCK";
			if (flag13)
			{
				this.Valuesetter.Text = Settings.Default.GRIDLOCKstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.GRIDLOCKsleep;
				this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.GRIDLOCKstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.GRIDLOCKsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox2.SelectedItem.ToString();
			}
			bool flag14 = this.comboBox2.SelectedItem.ToString() == "HIBANA";
			if (flag14)
			{
				this.Valuesetter.Text = Settings.Default.HIBANAstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.HIBANAsleep;
				this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.HIBANAstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.HIBANAsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox2.SelectedItem.ToString();
			}
			bool flag15 = this.comboBox2.SelectedItem.ToString() == "IANA";
			if (flag15)
			{
				this.Valuesetter.Text = Settings.Default.IANAstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.IANAsleep;
				this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.IANAstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.IANAsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox2.SelectedItem.ToString();
			}
			bool flag16 = this.comboBox2.SelectedItem.ToString() == "IQ";
			if (flag16)
			{
				this.Valuesetter.Text = Settings.Default.IQstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.IQsleep;
				this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.IQstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.IQsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox2.SelectedItem.ToString();
			}
			bool flag17 = this.comboBox2.SelectedItem.ToString() == "JACKAL";
			if (flag17)
			{
				this.Valuesetter.Text = Settings.Default.JACKALstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.JACKALsleep;
				this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.JACKALstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.JACKALsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox2.SelectedItem.ToString();
			}
			bool flag18 = this.comboBox2.SelectedItem.ToString() == "KALI";
			if (flag18)
			{
				this.Valuesetter.Text = Settings.Default.KALIstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.KALIsleep;
				this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.KALIstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.KALIsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox2.SelectedItem.ToString();
			}
			bool flag19 = this.comboBox2.SelectedItem.ToString() == "LION";
			if (flag19)
			{
				this.Valuesetter.Text = Settings.Default.LIONstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.LIONsleep;
				this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.LIONstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.LIONsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox2.SelectedItem.ToString();
			}
			bool flag20 = this.comboBox2.SelectedItem.ToString() == "MAVERICK";
			if (flag20)
			{
				this.Valuesetter.Text = Settings.Default.MAVERICKstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.MAVERICKsleep;
				this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.MAVERICKstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.MAVERICKsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox2.SelectedItem.ToString();
			}
			bool flag21 = this.comboBox2.SelectedItem.ToString() == "MONTAGNE";
			if (flag21)
			{
				this.Valuesetter.Text = Settings.Default.MONTAGNEstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.MONTAGNEsleep;
				this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.MONTAGNEstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.MONTAGNEsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox2.SelectedItem.ToString();
			}
			bool flag22 = this.comboBox2.SelectedItem.ToString() == "NOMAD";
			if (flag22)
			{
				this.Valuesetter.Text = Settings.Default.NOMADstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.NOMADsleep;
				this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.NOMADstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.NOMADsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox2.SelectedItem.ToString();
			}
			bool flag23 = this.comboBox2.SelectedItem.ToString() == "NØKK";
			if (flag23)
			{
				this.Valuesetter.Text = Settings.Default.NØKKstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.NØKKsleep;
				this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.NØKKstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.NØKKsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox2.SelectedItem.ToString();
			}
			bool flag24 = this.comboBox2.SelectedItem.ToString() == "OSA";
			if (flag24)
			{
				this.Valuesetter.Text = Settings.Default.OSAstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.OSAsleep;
				this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.OSAstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.OSAsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox2.SelectedItem.ToString();
			}
			bool flag25 = this.comboBox2.SelectedItem.ToString() == "SENS";
			if (flag25)
			{
				this.Valuesetter.Text = Settings.Default.SENSstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.SENSsleep;
				this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.SENSstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.SENSsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox2.SelectedItem.ToString();
			}
			bool flag26 = this.comboBox2.SelectedItem.ToString() == "SLEDGE";
			if (flag26)
			{
				this.Valuesetter.Text = Settings.Default.SLEDGEstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.SLEDGEsleep;
				this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.SLEDGEstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.SLEDGEsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox2.SelectedItem.ToString();
			}
			bool flag27 = this.comboBox2.SelectedItem.ToString() == "THATCHER";
			if (flag27)
			{
				this.Valuesetter.Text = Settings.Default.THATCHERstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.THATCHERsleep;
				this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.THATCHERstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.THATCHERsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox2.SelectedItem.ToString();
			}
			bool flag28 = this.comboBox2.SelectedItem.ToString() == "THERMITE";
			if (flag28)
			{
				this.Valuesetter.Text = Settings.Default.THERMITEstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.THERMITEsleep;
				this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.THERMITEstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.THERMITEsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox2.SelectedItem.ToString();
			}
			bool flag29 = this.comboBox2.SelectedItem.ToString() == "TWITCH";
			if (flag29)
			{
				this.Valuesetter.Text = Settings.Default.TWITCHstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.TWITCHsleep;
				this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.TWITCHstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.TWITCHsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox2.SelectedItem.ToString();
			}
			bool flag30 = this.comboBox2.SelectedItem.ToString() == "YING";
			if (flag30)
			{
				this.Valuesetter.Text = Settings.Default.YINGstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.YINGsleep;
				this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.YINGstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.YINGsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox2.SelectedItem.ToString();
			}
			bool flag31 = this.comboBox2.SelectedItem.ToString() == "ZERO";
			if (flag31)
			{
				this.Valuesetter.Text = Settings.Default.ZEROstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.ZEROsleep;
				this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.ZEROstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.ZEROsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox2.SelectedItem.ToString();
			}
			bool flag32 = this.comboBox2.SelectedItem.ToString() == "ZOFIA";
			if (flag32)
			{
				this.Valuesetter.Text = Settings.Default.ZOFIAstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.ZOFIAsleep;
				this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.ZOFIAstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.ZOFIAsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox2.SelectedItem.ToString();
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x0000B448 File Offset: 0x0000B448
		private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = this.comboBox3.SelectedItem.ToString() == "ALIBI";
			if (flag)
			{
				this.Valuesetter.Text = Settings.Default.ALIBIstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.ALIBIsleep;
				this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.ALIBIstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.ALIBIsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox3.SelectedItem.ToString();
			}
			bool flag2 = this.comboBox3.SelectedItem.ToString() == "ARUNI";
			if (flag2)
			{
				this.Valuesetter.Text = Settings.Default.ARUNIstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.ARUNIsleep;
				this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.ARUNIstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.ARUNIsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox3.SelectedItem.ToString();
			}
			bool flag3 = this.comboBox3.SelectedItem.ToString() == "AZAMI";
			if (flag3)
			{
				this.Valuesetter.Text = Settings.Default.AZAMIstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.AZAMIsleep;
				this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.AZAMIstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.AZAMIsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox3.SelectedItem.ToString();
			}
			bool flag4 = this.comboBox3.SelectedItem.ToString() == "BANDIT";
			if (flag4)
			{
				this.Valuesetter.Text = Settings.Default.BANDITstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.BANDITsleep;
				this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.BANDITstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.BANDITsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox3.SelectedItem.ToString();
			}
			bool flag5 = this.comboBox3.SelectedItem.ToString() == "CASTLE";
			if (flag5)
			{
				this.Valuesetter.Text = Settings.Default.CASTLEstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.CASTLEsleep;
				this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.CASTLEstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.CASTLEsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox3.SelectedItem.ToString();
			}
			bool flag6 = this.comboBox3.SelectedItem.ToString() == "CAVEIRA";
			if (flag6)
			{
				this.Valuesetter.Text = Settings.Default.CAVEIRAstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.CAVEIRAsleep;
				this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.CAVEIRAstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.CAVEIRAsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox3.SelectedItem.ToString();
			}
			bool flag7 = this.comboBox3.SelectedItem.ToString() == "CLASH";
			if (flag7)
			{
				this.Valuesetter.Text = Settings.Default.CLASHstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.CLASHsleep;
				this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.CLASHstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.CLASHsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox3.SelectedItem.ToString();
			}
			bool flag8 = this.comboBox3.SelectedItem.ToString() == "DOC";
			if (flag8)
			{
				this.Valuesetter.Text = Settings.Default.DOCstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.DOCsleep;
				this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.DOCstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.DOCsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox3.SelectedItem.ToString();
			}
			bool flag9 = this.comboBox3.SelectedItem.ToString() == "ECHO";
			if (flag9)
			{
				this.Valuesetter.Text = Settings.Default.ECHOstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.ECHOsleep;
				this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.ECHOstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.ECHOsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox3.SelectedItem.ToString();
			}
			bool flag10 = this.comboBox3.SelectedItem.ToString() == "ELA";
			if (flag10)
			{
				this.Valuesetter.Text = Settings.Default.ELAstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.ELAsleep;
				this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.ELAstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.ELAsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox3.SelectedItem.ToString();
			}
			bool flag11 = this.comboBox3.SelectedItem.ToString() == "FROST";
			if (flag11)
			{
				this.Valuesetter.Text = Settings.Default.FROSTstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.FROSTsleep;
				this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.FROSTstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.FROSTsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox3.SelectedItem.ToString();
			}
			bool flag12 = this.comboBox3.SelectedItem.ToString() == "GOYO";
			if (flag12)
			{
				this.Valuesetter.Text = Settings.Default.GOYOstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.GOYOsleep;
				this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.GOYOstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.GOYOsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox3.SelectedItem.ToString();
			}
			bool flag13 = this.comboBox3.SelectedItem.ToString() == "JÄGER";
			if (flag13)
			{
				this.Valuesetter.Text = Settings.Default.JÄGERstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.JÄGERsleep;
				this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.JÄGERstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.JÄGERsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox3.SelectedItem.ToString();
			}
			bool flag14 = this.comboBox3.SelectedItem.ToString() == "KAID";
			if (flag14)
			{
				this.Valuesetter.Text = Settings.Default.KAIDstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.KAIDsleep;
				this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.KAIDstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.KAIDsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox3.SelectedItem.ToString();
			}
			bool flag15 = this.comboBox3.SelectedItem.ToString() == "KAPKAN";
			if (flag15)
			{
				this.Valuesetter.Text = Settings.Default.KAPKANstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.KAPKANsleep;
				this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.KAPKANstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.KAPKANsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox3.SelectedItem.ToString();
			}
			bool flag16 = this.comboBox3.SelectedItem.ToString() == "LESION";
			if (flag16)
			{
				this.Valuesetter.Text = Settings.Default.LESIONstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.LESIONsleep;
				this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.LESIONstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.LESIONsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox3.SelectedItem.ToString();
			}
			bool flag17 = this.comboBox3.SelectedItem.ToString() == "MAESTRO";
			if (flag17)
			{
				this.Valuesetter.Text = Settings.Default.MAESTROstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.MAESTROsleep;
				this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.MAESTROstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.MAESTROsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox3.SelectedItem.ToString();
			}
			bool flag18 = this.comboBox3.SelectedItem.ToString() == "MELUSI";
			if (flag18)
			{
				this.Valuesetter.Text = Settings.Default.MELUSIstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.MELUSIsleep;
				this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.MELUSIstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.MELUSIsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox3.SelectedItem.ToString();
			}
			bool flag19 = this.comboBox3.SelectedItem.ToString() == "MIRA";
			if (flag19)
			{
				this.Valuesetter.Text = Settings.Default.MIRAstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.MIRAsleep;
				this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.MIRAstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.MIRAsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox3.SelectedItem.ToString();
			}
			bool flag20 = this.comboBox3.SelectedItem.ToString() == "MOZZIE";
			if (flag20)
			{
				this.Valuesetter.Text = Settings.Default.MOZZIEstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.MOZZIEsleep;
				this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.MOZZIEstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.MOZZIEsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox3.SelectedItem.ToString();
			}
			bool flag21 = this.comboBox3.SelectedItem.ToString() == "MUTE";
			if (flag21)
			{
				this.Valuesetter.Text = Settings.Default.MUTEstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.MUTEsleep;
				this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.MUTEstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.MUTEsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox3.SelectedItem.ToString();
			}
			bool flag22 = this.comboBox3.SelectedItem.ToString() == "ORYX";
			if (flag22)
			{
				this.Valuesetter.Text = Settings.Default.ORYXstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.ORYXsleep;
				this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.ORYXstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.ORYXsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox3.SelectedItem.ToString();
			}
			bool flag23 = this.comboBox3.SelectedItem.ToString() == "PULSE";
			if (flag23)
			{
				this.Valuesetter.Text = Settings.Default.PULSEstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.PULSEsleep;
				this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.PULSEstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.PULSEsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox3.SelectedItem.ToString();
			}
			bool flag24 = this.comboBox3.SelectedItem.ToString() == "ROOK";
			if (flag24)
			{
				this.Valuesetter.Text = Settings.Default.ROOKstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.ROOKsleep;
				this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.ROOKstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.ROOKsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox3.SelectedItem.ToString();
			}
			bool flag25 = this.comboBox3.SelectedItem.ToString() == "SMOKE";
			if (flag25)
			{
				this.Valuesetter.Text = Settings.Default.SMOKEstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.SMOKEsleep;
				this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.SMOKEstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.SMOKEsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox3.SelectedItem.ToString();
			}
			bool flag26 = this.comboBox3.SelectedItem.ToString() == "TACHANKA";
			if (flag26)
			{
				this.Valuesetter.Text = Settings.Default.TACHANKAstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.TACHANKAsleep;
				this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.TACHANKAstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.TACHANKAsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox3.SelectedItem.ToString();
			}
			bool flag27 = this.comboBox3.SelectedItem.ToString() == "THORN";
			if (flag27)
			{
				this.Valuesetter.Text = Settings.Default.THORNstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.THORNsleep;
				this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.THORNstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.THORNsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox3.SelectedItem.ToString();
			}
			bool flag28 = this.comboBox3.SelectedItem.ToString() == "THUNDERBIRD";
			if (flag28)
			{
				this.Valuesetter.Text = Settings.Default.THUNDERBIRDstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.THUNDERBIRDsleep;
				this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.THUNDERBIRDstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.THUNDERBIRDsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox3.SelectedItem.ToString();
			}
			bool flag29 = this.comboBox3.SelectedItem.ToString() == "VALKYRIE";
			if (flag29)
			{
				this.Valuesetter.Text = Settings.Default.VALKYRIEstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.VALKYRIEsleep;
				this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.VALKYRIEstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.VALKYRIEsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox3.SelectedItem.ToString();
			}
			bool flag30 = this.comboBox3.SelectedItem.ToString() == "VIGIL";
			if (flag30)
			{
				this.Valuesetter.Text = Settings.Default.VIGILstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.VIGILsleep;
				this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.VIGILstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.VIGILsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox3.SelectedItem.ToString();
			}
			bool flag31 = this.comboBox3.SelectedItem.ToString() == "WAMAI";
			if (flag31)
			{
				this.Valuesetter.Text = Settings.Default.WAMAIstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.WAMAIsleep;
				this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.WAMAIstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.WAMAIsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox3.SelectedItem.ToString();
			}
			bool flag32 = this.comboBox3.SelectedItem.ToString() == "WARDEN";
			if (flag32)
			{
				this.Valuesetter.Text = Settings.Default.WARDENstrenght;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.WARDENsleep;
				this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.WARDENstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.WARDENsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
				this.opoutput.Text = this.comboBox3.SelectedItem.ToString();
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x0000D570 File Offset: 0x0000D570
		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			bool topMost = base.TopMost;
			if (topMost)
			{
				base.TopMost = false;
			}
			else
			{
				base.TopMost = true;
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x0000D59E File Offset: 0x0000D59E
		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600001B RID: 27 RVA: 0x0000D5A1 File Offset: 0x0000D5A1
		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			Form1.ReleaseCapture();
			Form1.SendMessage(base.Handle, 161, 2, 0);
		}

		// Token: 0x0600001C RID: 28
		[DllImport("user32.dll")]
		private static extern IntPtr GetForegroundWindow();

		// Token: 0x0600001D RID: 29
		[DllImport("user32.dll")]
		private static extern int GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

		// Token: 0x0600001E RID: 30 RVA: 0x0000D5C0 File Offset: 0x0000D5C0
		private string GetForegroundProcessName()
		{
			IntPtr foregroundWindow = Form1.GetForegroundWindow();
			uint num;
			Form1.GetWindowThreadProcessId(foregroundWindow, out num);
			foreach (Process process in Process.GetProcesses())
			{
				bool flag = (long)process.Id == (long)((ulong)num);
				if (flag)
				{
					return process.ProcessName;
				}
				this.label19.Text = (num.ToString() ?? "");
				this.activepid = num.ToString();
			}
			return "Unknown";
		}

		// Token: 0x0600001F RID: 31
		[DllImport("user32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

		// Token: 0x06000020 RID: 32 RVA: 0x0000D654 File Offset: 0x0000D654
		private void timer1_Tick(object sender, EventArgs e)
		{
			bool enabled = Form1.Enabled;
			if (enabled)
			{
				this.label8.Text = "ENABLED";
				this.label8.ForeColor = Color.Green;
				this.Enable();
			}
			else
			{
				this.label8.Text = "DISABLED";
				this.label8.ForeColor = Color.Red;
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x0000D6BC File Offset: 0x0000D6BC
		private void ValueUpdater_Tick(object sender, EventArgs e)
		{
			this.GetForegroundProcessName();
			bool flag = this.label10.Text == "Num Lock";
			if (flag)
			{
				Form1.x = 144U;
			}
			bool flag2 = this.label10.Text == "Caps Lock";
			if (flag2)
			{
				Form1.x = 20U;
			}
			bool flag3 = this.label10.Text == "Insert";
			if (flag3)
			{
				Form1.x = 45U;
			}
			bool flag4 = this.label10.Text == "Tab";
			if (flag4)
			{
				Form1.x = 9U;
			}
			bool flag5 = this.label10.Text == "Delete";
			if (flag5)
			{
				Form1.x = 46U;
			}
			bool flag6 = this.label10.Text == "F1";
			if (flag6)
			{
				Form1.x = 112U;
			}
			bool flag7 = this.label10.Text == "F2";
			if (flag7)
			{
				Form1.x = 113U;
			}
			bool flag8 = this.label10.Text == "F3";
			if (flag8)
			{
				Form1.x = 114U;
			}
			bool flag9 = this.label10.Text == "F4";
			if (flag9)
			{
				Form1.x = 115U;
			}
			bool flag10 = this.label10.Text == "F5";
			if (flag10)
			{
				Form1.x = 116U;
			}
			bool flag11 = this.label10.Text == "F6";
			if (flag11)
			{
				Form1.x = 117U;
			}
			bool flag12 = this.label10.Text == "F7";
			if (flag12)
			{
				Form1.x = 118U;
			}
			bool flag13 = this.label10.Text == "F8";
			if (flag13)
			{
				Form1.x = 119U;
			}
			bool flag14 = this.label10.Text == "F9";
			if (flag14)
			{
				Form1.x = 120U;
			}
			bool flag15 = this.label10.Text == "F10";
			if (flag15)
			{
				Form1.x = 121U;
			}
			bool flag16 = this.label10.Text == "F11";
			if (flag16)
			{
				Form1.x = 122U;
			}
			bool flag17 = this.label10.Text == "F12";
			if (flag17)
			{
				Form1.x = 123U;
			}
			bool flag18 = this.label10.Text == "0";
			if (flag18)
			{
				Form1.x = 48U;
			}
			bool flag19 = this.label10.Text == "1";
			if (flag19)
			{
				Form1.x = 49U;
			}
			bool flag20 = this.label10.Text == "2";
			if (flag20)
			{
				Form1.x = 50U;
			}
			bool flag21 = this.label10.Text == "3";
			if (flag21)
			{
				Form1.x = 51U;
			}
			bool flag22 = this.label10.Text == "4";
			if (flag22)
			{
				Form1.x = 52U;
			}
			bool flag23 = this.label10.Text == "5";
			if (flag23)
			{
				Form1.x = 53U;
			}
			bool flag24 = this.label10.Text == "6";
			if (flag24)
			{
				Form1.x = 54U;
			}
			bool flag25 = this.label10.Text == "7";
			if (flag25)
			{
				Form1.x = 55U;
			}
			bool flag26 = this.label10.Text == "8";
			if (flag26)
			{
				Form1.x = 56U;
			}
			bool flag27 = this.label10.Text == "9";
			if (flag27)
			{
				Form1.x = 57U;
			}
			bool flag28 = this.label10.Text == "Home";
			if (flag28)
			{
				Form1.x = 36U;
			}
			bool flag29 = this.label10.Text == "A";
			if (flag29)
			{
				Form1.x = 65U;
			}
			bool flag30 = this.label10.Text == "B";
			if (flag30)
			{
				Form1.x = 66U;
			}
			bool flag31 = this.label10.Text == "C";
			if (flag31)
			{
				Form1.x = 67U;
			}
			bool flag32 = this.label10.Text == "D";
			if (flag32)
			{
				Form1.x = 68U;
			}
			bool flag33 = this.label10.Text == "E";
			if (flag33)
			{
				Form1.x = 69U;
			}
			bool flag34 = this.label10.Text == "F";
			if (flag34)
			{
				Form1.x = 70U;
			}
			bool flag35 = this.label10.Text == "G";
			if (flag35)
			{
				Form1.x = 71U;
			}
			bool flag36 = this.label10.Text == "H";
			if (flag36)
			{
				Form1.x = 72U;
			}
			bool flag37 = this.label10.Text == "I";
			if (flag37)
			{
				Form1.x = 73U;
			}
			bool flag38 = this.label10.Text == "J";
			if (flag38)
			{
				Form1.x = 74U;
			}
			bool flag39 = this.label10.Text == "K";
			if (flag39)
			{
				Form1.x = 75U;
			}
			bool flag40 = this.label10.Text == "L";
			if (flag40)
			{
				Form1.x = 76U;
			}
			bool flag41 = this.label10.Text == "M";
			if (flag41)
			{
				Form1.x = 77U;
			}
			bool flag42 = this.label10.Text == "N";
			if (flag42)
			{
				Form1.x = 78U;
			}
			bool flag43 = this.label10.Text == "O";
			if (flag43)
			{
				Form1.x = 79U;
			}
			bool flag44 = this.label10.Text == "P";
			if (flag44)
			{
				Form1.x = 80U;
			}
			bool flag45 = this.label10.Text == "Q";
			if (flag45)
			{
				Form1.x = 81U;
			}
			bool flag46 = this.label10.Text == "R";
			if (flag46)
			{
				Form1.x = 82U;
			}
			bool flag47 = this.label10.Text == "S";
			if (flag47)
			{
				Form1.x = 83U;
			}
			bool flag48 = this.label10.Text == "T";
			if (flag48)
			{
				Form1.x = 84U;
			}
			bool flag49 = this.label10.Text == "U";
			if (flag49)
			{
				Form1.x = 85U;
			}
			bool flag50 = this.label10.Text == "V";
			if (flag50)
			{
				Form1.x = 86U;
			}
			bool flag51 = this.label10.Text == "W";
			if (flag51)
			{
				Form1.x = 87U;
			}
			bool flag52 = this.label10.Text == "X";
			if (flag52)
			{
				Form1.x = 88U;
			}
			bool flag53 = this.label10.Text == "Y";
			if (flag53)
			{
				Form1.x = 89U;
			}
			bool flag54 = this.label10.Text == "Z";
			if (flag54)
			{
				Form1.x = 90U;
			}
			bool flag55 = this.label10.Text == "Up Key";
			if (flag55)
			{
				Form1.x = 38U;
			}
			bool flag56 = this.label10.Text == "Down Key";
			if (flag56)
			{
				Form1.x = 40U;
			}
			bool flag57 = this.label10.Text == "Left Key";
			if (flag57)
			{
				Form1.x = 37U;
			}
			bool flag58 = this.label10.Text == "Right Key";
			if (flag58)
			{
				Form1.x = 39U;
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x0000DEF4 File Offset: 0x0000DEF4
		private void rs6checker_Tick(object sender, EventArgs e)
		{
			Process[] processesByName = Process.GetProcessesByName("RainbowSix");
			foreach (Process process in processesByName)
			{
				this.r6pid = process.Id.ToString();
				this.label20.Text = (this.r6pid ?? "");
			}
			Process[] processesByName2 = Process.GetProcessesByName("RainbowSix_Vulkan");
			foreach (Process process2 in processesByName2)
			{
				this.r6pidvulkan = process2.Id.ToString();
				this.label17.Text = (this.r6pid ?? "");
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x0000DFB4 File Offset: 0x0000DFB4
		private void button7_Click(object sender, EventArgs e)
		{
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
			Process process = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.FileName = "cmd.exe";
			string arg = folderPath + "\\CentralWare";
			processStartInfo.Arguments = string.Format("/C start {0}", arg);
			process.StartInfo = processStartInfo;
			process.Start();
			string text = "Search for the 'last modified' folder.";
			MessageBox.Show(text);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x0000E028 File Offset: 0x0000E028
		private void button4_Click(object sender, EventArgs e)
		{
			bool flag = MessageBox.Show("This will reset all the configs for all operators to default value (1), Your password and username will be forgotten. the next login you need to enter your credentials again. Are you sure you want to reset?", "", MessageBoxButtons.YesNo) == DialogResult.Yes;
			if (flag)
			{
				Settings.Default.Reset();
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x0000E05C File Offset: 0x0000E05C
		private void trackBar1_ValueChanged(object sender, EventArgs e)
		{
			this.label3.Text = "STRENGHT: " + this.trackBar1.Value.ToString();
		}

		// Token: 0x06000026 RID: 38 RVA: 0x0000E094 File Offset: 0x0000E094
		private void button1_Click(object sender, EventArgs e)
		{
			bool visible = this.panel3.Visible;
			if (visible)
			{
				this.panel3.Visible = false;
			}
			else
			{
				this.panel4.Visible = false;
				this.panel3.Visible = true;
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x0000E0E0 File Offset: 0x0000E0E0
		private void button2_Click(object sender, EventArgs e)
		{
			bool visible = this.panel4.Visible;
			if (visible)
			{
				this.panel4.Visible = false;
			}
			else
			{
				this.panel3.Visible = false;
				this.panel4.Visible = true;
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0000E12A File Offset: 0x0000E12A
		private void Form1_MouseDown(object sender, MouseEventArgs e)
		{
			Form1.ReleaseCapture();
			Form1.SendMessage(base.Handle, 161, 2, 0);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x0000E146 File Offset: 0x0000E146
		private void panel4_MouseDown(object sender, MouseEventArgs e)
		{
			Form1.ReleaseCapture();
			Form1.SendMessage(base.Handle, 161, 2, 0);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x0000E162 File Offset: 0x0000E162
		private void panel3_MouseDown(object sender, MouseEventArgs e)
		{
			Form1.ReleaseCapture();
			Form1.SendMessage(base.Handle, 161, 2, 0);
		}

		// Token: 0x04000001 RID: 1
		private Thread t;

		// Token: 0x04000003 RID: 3
		public const int WM_NCLBUTTONDOWN = 161;

		// Token: 0x04000004 RID: 4
		public const int HT_CAPTION = 2;

		// Token: 0x04000005 RID: 5
		public new static bool Enabled = true;

		// Token: 0x04000006 RID: 6
		public static int sleeptime = 1;

		// Token: 0x04000007 RID: 7
		public static int strength = 1;

		// Token: 0x04000008 RID: 8
		public static int sleeptime2 = 1;

		// Token: 0x04000009 RID: 9
		public static int strength2 = 0;

		// Token: 0x0400000A RID: 10
		private static uint x = 144U;

		// Token: 0x0400000B RID: 11
		private static uint xx = 1U;

		// Token: 0x0400000C RID: 12
		private string r6pid;

		// Token: 0x0400000D RID: 13
		private string r6pidvulkan;

		// Token: 0x0400000E RID: 14
		private string activepid;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);

		// Token: 0x04000010 RID: 16
		private const uint SWP_NOSIZE = 1U;

		// Token: 0x04000011 RID: 17
		private const uint SWP_NOMOVE = 2U;

		// Token: 0x04000012 RID: 18
		private const uint TOPMOST_FLAGS = 3U;
	}
}
