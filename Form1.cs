using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using MILLENIUMV2._1.Properties;

// Token: 0x02000010 RID: 16
public partial class Form1 : Form
{
	// Token: 0x0600003F RID: 63 RVA: 0x0001A84C File Offset: 0x00018A4C
	public Form1()
	{
		this.InitializeComponent();
		base.StartPosition = FormStartPosition.CenterScreen;
	}

	// Token: 0x17000001 RID: 1
	// (get) Token: 0x06000040 RID: 64 RVA: 0x0001A874 File Offset: 0x00018A74
	// (set) Token: 0x06000041 RID: 65 RVA: 0x0001A888 File Offset: 0x00018A88
	public object Object_0 { get; set; }

	// Token: 0x06000042 RID: 66
	[DllImport("user32.dll")]
	public static extern int SendMessage(IntPtr intptr_1, int int_6, int int_7, int int_8);

	// Token: 0x06000043 RID: 67
	[DllImport("user32.dll")]
	public static extern bool ReleaseCapture();

	// Token: 0x06000044 RID: 68 RVA: 0x0001A89C File Offset: 0x00018A9C
	private void Form1_Load(object sender, EventArgs e)
	{
		this.label10.Text = Settings.Default.keybind;
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
		this.thread_0 = new Thread(new ThreadStart(this.method_1));
		this.thread_0.Start();
		this.timer_0.Start();
		this.timer_1.Start();
		this.timer_2.Start();
		this.timer_3.Start();
		this.timer_5.Start();
		Settings.Default.Upgrade();
	}

	// Token: 0x06000045 RID: 69 RVA: 0x0001B008 File Offset: 0x00019208
	private void method_0()
	{
		int value = this.trackBar2.Value;
		int value2 = this.trackBar1.Value;
		int value3 = this.trackBar4.Value;
		int value4 = this.trackBar3.Value;
		Form1.int_2 = value;
		Form1.int_3 = value2;
		Form1.int_4 = value3;
		Form1.int_5 = value4;
	}

	// Token: 0x06000046 RID: 70 RVA: 0x0001B060 File Offset: 0x00019260
	public void method_1()
	{
		for (;;)
		{
			Thread.Sleep(1);
			Control.CheckForIllegalCrossThreadCalls = false;
			if (((int)Class7.GetKeyState(Form1.uint_0) & 32768) > 0)
			{
				Form1.bool_0 = !Form1.bool_0;
				if (Form1.bool_0)
				{
					Class7.Beep(800U, 500U);
				}
				else
				{
					Class7.Beep(300U, 500U);
				}
			}
			if (Form1.bool_0)
			{
				if (!this.checkBox3.Checked)
				{
					Form1.uint_1 = 1U;
				}
				else
				{
					Form1.uint_1 = 2U;
				}
				if (this.checkBox2.Checked)
				{
					if (((int)Class7.GetKeyState(Form1.uint_1) & 32768) > 0 && ((int)Class7.GetKeyState(1U) & 32768) > 0 && (this.string_3 == this.string_1 || this.string_3 == this.string_2))
					{
						Class7.smethod_1(0, Form1.int_3);
						Thread.Sleep(Form1.int_2);
						Class7.smethod_1(Form1.int_5, 0);
						Thread.Sleep(Form1.int_4);
					}
				}
				else if (((int)Class7.GetKeyState(Form1.uint_1) & 32768) > 0 && ((int)Class7.GetKeyState(1U) & 32768) > 0)
				{
					Thread.Sleep(Form1.int_2);
					Class7.smethod_1(0, Form1.int_3);
					Thread.Sleep(Form1.int_4);
					Class7.smethod_1(Form1.int_5, 0);
				}
				Thread.Sleep(1);
			}
		}
	}

	// Token: 0x06000047 RID: 71 RVA: 0x0001B1DC File Offset: 0x000193DC
	public void method_2()
	{
		for (;;)
		{
			if (((int)Class7.GetKeyState(161U) & 32768) > 0)
			{
				base.Location = new Point(0, 0);
			}
		}
	}

	// Token: 0x06000048 RID: 72 RVA: 0x0001B214 File Offset: 0x00019414
	private void label14_Click(object sender, EventArgs e)
	{
		base.WindowState = FormWindowState.Minimized;
	}

	// Token: 0x06000049 RID: 73 RVA: 0x0001B228 File Offset: 0x00019428
	private void label13_Click(object sender, EventArgs e)
	{
		Settings.Default.Save();
		Application.Exit();
		Environment.Exit(0);
	}

	// Token: 0x0600004A RID: 74 RVA: 0x0001B24C File Offset: 0x0001944C
	private void method_3(object sender, EventArgs e)
	{
		this.label3.Text = "STRENGHT: " + this.trackBar1.Value.ToString();
	}

	// Token: 0x0600004B RID: 75 RVA: 0x0001B284 File Offset: 0x00019484
	private void trackBar2_ValueChanged(object sender, EventArgs e)
	{
		this.label4.Text = "SLOWNESS: " + this.trackBar2.Value.ToString();
	}

	// Token: 0x0600004C RID: 76 RVA: 0x0001B2BC File Offset: 0x000194BC
	private void trackBar3_ValueChanged(object sender, EventArgs e)
	{
		string str;
		if (this.trackBar3.Value < 0)
		{
			str = "LEFT";
		}
		else
		{
			str = "RIGHT";
		}
		this.label5.Text = "STRENGHT: " + this.trackBar3.Value.ToString() + " " + str;
	}

	// Token: 0x0600004D RID: 77 RVA: 0x0001B31C File Offset: 0x0001951C
	private void trackBar4_ValueChanged(object sender, EventArgs e)
	{
		this.label6.Text = "SLOWNESS: " + this.trackBar4.Value.ToString();
	}

	// Token: 0x0600004E RID: 78 RVA: 0x0001B354 File Offset: 0x00019554
	private void button5_Click(object sender, EventArgs e)
	{
		Settings.Default.keybind = this.comboBox1.SelectedItem.ToString();
		Settings.Default.Save();
	}

	// Token: 0x0600004F RID: 79 RVA: 0x0001B388 File Offset: 0x00019588
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
				this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
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
				this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
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
				this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
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
				this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
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
				this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
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
				this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.BUCKstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.BUCKsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
			}
			if (this.comboBox2.SelectedItem.ToString() == "CAPITÃO")
			{
				this.Valuesetter.Text = Settings.Default.String_0;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.String_2;
				this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.String_4;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.String_6;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
			}
			if (this.comboBox2.SelectedItem.ToString() == "DOKKAEBI")
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
			if (this.comboBox2.SelectedItem.ToString() == "FINKA")
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
			if (this.comboBox2.SelectedItem.ToString() == "FLORES")
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
			if (this.comboBox2.SelectedItem.ToString() == "FUZE")
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
			if (this.comboBox2.SelectedItem.ToString() == "GLAZ")
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
			if (this.comboBox2.SelectedItem.ToString() == "GRIDLOCK")
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
			if (this.comboBox2.SelectedItem.ToString() == "HIBANA")
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
			if (this.comboBox2.SelectedItem.ToString() == "IANA")
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
			if (this.comboBox2.SelectedItem.ToString() == "IQ")
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
			if (this.comboBox2.SelectedItem.ToString() == "JACKAL")
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
			if (this.comboBox2.SelectedItem.ToString() == "KALI")
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
			if (this.comboBox2.SelectedItem.ToString() == "LION")
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
			if (this.comboBox2.SelectedItem.ToString() == "MAVERICK")
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
			if (this.comboBox2.SelectedItem.ToString() == "MONTAGNE")
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
			if (this.comboBox2.SelectedItem.ToString() == "NOMAD")
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
			if (this.comboBox2.SelectedItem.ToString() == "NØKK")
			{
				this.Valuesetter.Text = Settings.Default.String_1;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.String_3;
				this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.String_5;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.String_7;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
			}
			if (this.comboBox2.SelectedItem.ToString() == "OSA")
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
			if (this.comboBox2.SelectedItem.ToString() == "SENS")
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
			if (this.comboBox2.SelectedItem.ToString() == "SLEDGE")
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
			if (this.comboBox2.SelectedItem.ToString() == "THATCHER")
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
			if (this.comboBox2.SelectedItem.ToString() == "THERMITE")
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
			if (this.comboBox2.SelectedItem.ToString() == "TWITCH")
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
			if (this.comboBox2.SelectedItem.ToString() == "YING")
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
			if (this.comboBox2.SelectedItem.ToString() == "ZERO")
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
			if (this.comboBox2.SelectedItem.ToString() == "ZOFIA")
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

	// Token: 0x06000050 RID: 80 RVA: 0x0001CFD0 File Offset: 0x0001B1D0
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
				this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
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
				this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
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
				this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
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
				this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
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
				this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
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
				this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
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
				this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
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
				this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
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
				this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
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
				this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
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
				this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
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
				this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.GOYOstrenght2;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.GOYOsleep2;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
			}
			if (this.comboBox3.SelectedItem.ToString() == "JÄGER")
			{
				this.Valuesetter.Text = Settings.Default.String_8;
				this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.String_9;
				this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.String_10;
				this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
				this.Valuesetter.Text = Settings.Default.String_12;
				this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
			}
			if (this.comboBox3.SelectedItem.ToString() == "KAID")
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
			if (this.comboBox3.SelectedItem.ToString() == "KAPKAN")
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
			if (this.comboBox3.SelectedItem.ToString() == "LESION")
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
			if (this.comboBox3.SelectedItem.ToString() == "MAESTRO")
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
			if (this.comboBox3.SelectedItem.ToString() == "MELUSI")
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
			if (this.comboBox3.SelectedItem.ToString() == "MIRA")
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
			if (this.comboBox3.SelectedItem.ToString() == "MOZZIE")
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
			if (this.comboBox3.SelectedItem.ToString() == "MUTE")
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
			if (this.comboBox3.SelectedItem.ToString() == "ORYX")
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
			if (this.comboBox3.SelectedItem.ToString() == "PULSE")
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
			if (this.comboBox3.SelectedItem.ToString() == "ROOK")
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
			if (this.comboBox3.SelectedItem.ToString() == "SMOKE")
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
			if (this.comboBox3.SelectedItem.ToString() == "TACHANKA")
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
			if (this.comboBox3.SelectedItem.ToString() == "THORN")
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
			if (this.comboBox3.SelectedItem.ToString() == "THUNDERBIRD")
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
			if (this.comboBox3.SelectedItem.ToString() == "VALKYRIE")
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
			if (this.comboBox3.SelectedItem.ToString() == "VIGIL")
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
			if (this.comboBox3.SelectedItem.ToString() == "WAMAI")
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
			if (this.comboBox3.SelectedItem.ToString() == "WARDEN")
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

	// Token: 0x06000051 RID: 81 RVA: 0x0001EC18 File Offset: 0x0001CE18
	private void button6_Click(object sender, EventArgs e)
	{
		if (this.comboBox2.SelectedIndex != -1)
		{
			if (this.comboBox2.SelectedItem.ToString() == "ACE")
			{
				Settings.Default.ACEstrenght = this.trackBar1.Value.ToString();
				Settings.Default.ACEstrenght2 = this.trackBar3.Value.ToString();
				Settings.Default.ACEsleep = this.trackBar2.Value.ToString();
				Settings.Default.ACEsleep2 = this.trackBar4.Value.ToString();
				Settings.Default.Save();
			}
			if (this.comboBox2.SelectedItem.ToString() == "AMARU")
			{
				Settings.Default.AMARUstrenght = this.trackBar1.Value.ToString();
				Settings.Default.AMARUstrenght2 = this.trackBar3.Value.ToString();
				Settings.Default.AMARUsleep = this.trackBar2.Value.ToString();
				Settings.Default.AMARUsleep2 = this.trackBar4.Value.ToString();
				Settings.Default.Save();
			}
			if (this.comboBox2.SelectedItem.ToString() == "ASH")
			{
				Settings.Default.ASHstrenght = this.trackBar1.Value.ToString();
				Settings.Default.ASHsleep = this.trackBar2.Value.ToString();
				Settings.Default.ASHstrenght2 = this.trackBar3.Value.ToString();
				Settings.Default.ASHsleep2 = this.trackBar4.Value.ToString();
				Settings.Default.Save();
			}
			if (this.comboBox2.SelectedItem.ToString() == "BLACKBEARD")
			{
				Settings.Default.BLACKBEARDstrenght = this.trackBar1.Value.ToString();
				Settings.Default.BLACKBEARDsleep = this.trackBar2.Value.ToString();
				Settings.Default.BLACKBEARDstrenght2 = this.trackBar3.Value.ToString();
				Settings.Default.BLACKBEARDsleep2 = this.trackBar4.Value.ToString();
				Settings.Default.Save();
			}
			if (this.comboBox2.SelectedItem.ToString() == "BLITZ")
			{
				Settings.Default.BLITZstrenght = this.trackBar1.Value.ToString();
				Settings.Default.BLITZsleep = this.trackBar2.Value.ToString();
				Settings.Default.BLITZstrenght2 = this.trackBar3.Value.ToString();
				Settings.Default.BLITZsleep2 = this.trackBar4.Value.ToString();
				Settings.Default.Save();
			}
			if (this.comboBox2.SelectedItem.ToString() == "BUCK")
			{
				Settings.Default.BUCKstrenght = this.trackBar1.Value.ToString();
				Settings.Default.BUCKsleep = this.trackBar2.Value.ToString();
				Settings.Default.BUCKstrenght2 = this.trackBar3.Value.ToString();
				Settings.Default.BUCKsleep2 = this.trackBar4.Value.ToString();
				Settings.Default.Save();
			}
			if (this.comboBox2.SelectedItem.ToString() == "CAPITÃO")
			{
				Settings.Default.String_0 = this.trackBar1.Value.ToString();
				Settings.Default.String_2 = this.trackBar2.Value.ToString();
				Settings.Default.String_4 = this.trackBar3.Value.ToString();
				Settings.Default.String_6 = this.trackBar4.Value.ToString();
				Settings.Default.Save();
			}
			if (this.comboBox2.SelectedItem.ToString() == "DOKKAEBI")
			{
				Settings.Default.DOKKAEBIstrenght = this.trackBar1.Value.ToString();
				Settings.Default.DOKKAEBIsleep = this.trackBar2.Value.ToString();
				Settings.Default.DOKKAEBIstrenght2 = this.trackBar3.Value.ToString();
				Settings.Default.DOKKAEBIsleep2 = this.trackBar4.Value.ToString();
				Settings.Default.Save();
			}
			if (this.comboBox2.SelectedItem.ToString() == "FINKA")
			{
				Settings.Default.FINKAstrenght = this.trackBar1.Value.ToString();
				Settings.Default.FINKAsleep = this.trackBar2.Value.ToString();
				Settings.Default.FINKAstrenght2 = this.trackBar3.Value.ToString();
				Settings.Default.FINKAsleep2 = this.trackBar4.Value.ToString();
				Settings.Default.Save();
			}
			if (this.comboBox2.SelectedItem.ToString() == "FLORES")
			{
				Settings.Default.FLORESstrenght = this.trackBar1.Value.ToString();
				Settings.Default.FLORESsleep = this.trackBar2.Value.ToString();
				Settings.Default.FLORESstrenght2 = this.trackBar3.Value.ToString();
				Settings.Default.FLORESsleep2 = this.trackBar4.Value.ToString();
				Settings.Default.Save();
			}
			if (this.comboBox2.SelectedItem.ToString() == "FUZE")
			{
				Settings.Default.FUZEstrenght = this.trackBar1.Value.ToString();
				Settings.Default.FUZEsleep = this.trackBar2.Value.ToString();
				Settings.Default.FUZEstrenght2 = this.trackBar3.Value.ToString();
				Settings.Default.FUZEsleep2 = this.trackBar4.Value.ToString();
				Settings.Default.Save();
			}
			if (this.comboBox2.SelectedItem.ToString() == "GLAZ")
			{
				Settings.Default.GLAZstrenght = this.trackBar1.Value.ToString();
				Settings.Default.GLAZsleep = this.trackBar2.Value.ToString();
				Settings.Default.GLAZstrenght2 = this.trackBar3.Value.ToString();
				Settings.Default.GLAZsleep2 = this.trackBar4.Value.ToString();
				Settings.Default.Save();
			}
			if (this.comboBox2.SelectedItem.ToString() == "GRIDLOCK")
			{
				Settings.Default.GRIDLOCKstrenght = this.trackBar1.Value.ToString();
				Settings.Default.GRIDLOCKsleep = this.trackBar2.Value.ToString();
				Settings.Default.GRIDLOCKstrenght2 = this.trackBar3.Value.ToString();
				Settings.Default.GRIDLOCKsleep2 = this.trackBar4.Value.ToString();
				Settings.Default.Save();
			}
			if (this.comboBox2.SelectedItem.ToString() == "HIBANA")
			{
				Settings.Default.HIBANAstrenght = this.trackBar1.Value.ToString();
				Settings.Default.HIBANAsleep = this.trackBar2.Value.ToString();
				Settings.Default.HIBANAstrenght2 = this.trackBar3.Value.ToString();
				Settings.Default.HIBANAsleep2 = this.trackBar4.Value.ToString();
				Settings.Default.Save();
			}
			if (this.comboBox2.SelectedItem.ToString() == "IANA")
			{
				Settings.Default.IANAstrenght = this.trackBar1.Value.ToString();
				Settings.Default.IANAsleep = this.trackBar2.Value.ToString();
				Settings.Default.IANAstrenght2 = this.trackBar3.Value.ToString();
				Settings.Default.IANAsleep2 = this.trackBar4.Value.ToString();
				Settings.Default.Save();
			}
			if (this.comboBox2.SelectedItem.ToString() == "IQ")
			{
				Settings.Default.IQstrenght = this.trackBar1.Value.ToString();
				Settings.Default.IQsleep = this.trackBar2.Value.ToString();
				Settings.Default.IQstrenght2 = this.trackBar3.Value.ToString();
				Settings.Default.IQsleep2 = this.trackBar4.Value.ToString();
				Settings.Default.Save();
			}
			if (this.comboBox2.SelectedItem.ToString() == "JACKAL")
			{
				Settings.Default.JACKALstrenght = this.trackBar1.Value.ToString();
				Settings.Default.JACKALsleep = this.trackBar2.Value.ToString();
				Settings.Default.JACKALstrenght2 = this.trackBar3.Value.ToString();
				Settings.Default.JACKALsleep2 = this.trackBar4.Value.ToString();
				Settings.Default.Save();
			}
			if (this.comboBox2.SelectedItem.ToString() == "KALI")
			{
				Settings.Default.KALIstrenght = this.trackBar1.Value.ToString();
				Settings.Default.KALIsleep = this.trackBar2.Value.ToString();
				Settings.Default.KALIstrenght2 = this.trackBar3.Value.ToString();
				Settings.Default.KALIsleep2 = this.trackBar4.Value.ToString();
				Settings.Default.Save();
			}
			if (this.comboBox2.SelectedItem.ToString() == "LION")
			{
				Settings.Default.LIONstrenght = this.trackBar1.Value.ToString();
				Settings.Default.LIONsleep = this.trackBar2.Value.ToString();
				Settings.Default.LIONstrenght2 = this.trackBar3.Value.ToString();
				Settings.Default.LIONsleep2 = this.trackBar4.Value.ToString();
				Settings.Default.Save();
			}
			if (this.comboBox2.SelectedItem.ToString() == "MAVERICK")
			{
				Settings.Default.MAVERICKstrenght = this.trackBar1.Value.ToString();
				Settings.Default.MAVERICKsleep = this.trackBar2.Value.ToString();
				Settings.Default.MAVERICKstrenght2 = this.trackBar3.Value.ToString();
				Settings.Default.MAVERICKsleep2 = this.trackBar4.Value.ToString();
				Settings.Default.Save();
			}
			if (this.comboBox2.SelectedItem.ToString() == "MONTAGNE")
			{
				Settings.Default.MONTAGNEstrenght = this.trackBar1.Value.ToString();
				Settings.Default.MONTAGNEsleep = this.trackBar2.Value.ToString();
				Settings.Default.MONTAGNEstrenght2 = this.trackBar3.Value.ToString();
				Settings.Default.MONTAGNEsleep2 = this.trackBar4.Value.ToString();
				Settings.Default.Save();
			}
			if (this.comboBox2.SelectedItem.ToString() == "NOMAD")
			{
				Settings.Default.NOMADstrenght = this.trackBar1.Value.ToString();
				Settings.Default.NOMADsleep = this.trackBar2.Value.ToString();
				Settings.Default.NOMADstrenght2 = this.trackBar3.Value.ToString();
				Settings.Default.NOMADsleep2 = this.trackBar4.Value.ToString();
				Settings.Default.Save();
			}
			if (this.comboBox2.SelectedItem.ToString() == "NØKK")
			{
				Settings.Default.String_1 = this.trackBar1.Value.ToString();
				Settings.Default.String_3 = this.trackBar2.Value.ToString();
				Settings.Default.String_5 = this.trackBar3.Value.ToString();
				Settings.Default.String_7 = this.trackBar4.Value.ToString();
				Settings.Default.Save();
			}
			if (this.comboBox2.SelectedItem.ToString() == "OSA")
			{
				Settings.Default.OSAstrenght = this.trackBar1.Value.ToString();
				Settings.Default.OSAsleep = this.trackBar2.Value.ToString();
				Settings.Default.OSAstrenght2 = this.trackBar3.Value.ToString();
				Settings.Default.OSAsleep2 = this.trackBar4.Value.ToString();
				Settings.Default.Save();
			}
			if (this.comboBox2.SelectedItem.ToString() == "SENS")
			{
				Settings.Default.SENSstrenght = this.trackBar1.Value.ToString();
				Settings.Default.SENSsleep = this.trackBar2.Value.ToString();
				Settings.Default.SENSstrenght2 = this.trackBar3.Value.ToString();
				Settings.Default.SENSsleep2 = this.trackBar4.Value.ToString();
				Settings.Default.Save();
			}
			if (this.comboBox2.SelectedItem.ToString() == "SLEDGE")
			{
				Settings.Default.SLEDGEstrenght = this.trackBar1.Value.ToString();
				Settings.Default.SLEDGEsleep = this.trackBar2.Value.ToString();
				Settings.Default.SLEDGEstrenght2 = this.trackBar3.Value.ToString();
				Settings.Default.SLEDGEsleep2 = this.trackBar4.Value.ToString();
				Settings.Default.Save();
			}
			if (this.comboBox2.SelectedItem.ToString() == "THATCHER")
			{
				Settings.Default.THATCHERstrenght = this.trackBar1.Value.ToString();
				Settings.Default.THATCHERsleep = this.trackBar2.Value.ToString();
				Settings.Default.THATCHERstrenght2 = this.trackBar3.Value.ToString();
				Settings.Default.THATCHERsleep2 = this.trackBar4.Value.ToString();
				Settings.Default.Save();
			}
			if (this.comboBox2.SelectedItem.ToString() == "THERMITE")
			{
				Settings.Default.THERMITEstrenght = this.trackBar1.Value.ToString();
				Settings.Default.THERMITEsleep = this.trackBar2.Value.ToString();
				Settings.Default.THERMITEstrenght2 = this.trackBar3.Value.ToString();
				Settings.Default.THERMITEsleep2 = this.trackBar4.Value.ToString();
				Settings.Default.Save();
			}
			if (this.comboBox2.SelectedItem.ToString() == "TWITCH")
			{
				Settings.Default.TWITCHstrenght = this.trackBar1.Value.ToString();
				Settings.Default.TWITCHsleep = this.trackBar2.Value.ToString();
				Settings.Default.TWITCHstrenght2 = this.trackBar3.Value.ToString();
				Settings.Default.TWITCHsleep2 = this.trackBar4.Value.ToString();
				Settings.Default.Save();
			}
			if (this.comboBox2.SelectedItem.ToString() == "YING")
			{
				Settings.Default.YINGstrenght = this.trackBar1.Value.ToString();
				Settings.Default.YINGsleep = this.trackBar2.Value.ToString();
				Settings.Default.YINGstrenght2 = this.trackBar3.Value.ToString();
				Settings.Default.YINGsleep2 = this.trackBar4.Value.ToString();
				Settings.Default.Save();
			}
			if (this.comboBox2.SelectedItem.ToString() == "ZERO")
			{
				Settings.Default.ZEROstrenght = this.trackBar1.Value.ToString();
				Settings.Default.ZEROsleep = this.trackBar2.Value.ToString();
				Settings.Default.ZEROstrenght2 = this.trackBar3.Value.ToString();
				Settings.Default.ZEROsleep2 = this.trackBar4.Value.ToString();
				Settings.Default.Save();
			}
			if (this.comboBox2.SelectedItem.ToString() == "ZOFIA")
			{
				Settings.Default.ZOFIAstrenght = this.trackBar1.Value.ToString();
				Settings.Default.ZOFIAsleep = this.trackBar2.Value.ToString();
				Settings.Default.ZOFIAstrenght2 = this.trackBar3.Value.ToString();
				Settings.Default.ZOFIAsleep2 = this.trackBar4.Value.ToString();
				Settings.Default.Save();
			}
		}
	}

	// Token: 0x06000052 RID: 82 RVA: 0x0001FF78 File Offset: 0x0001E178
	private void button3_Click(object sender, EventArgs e)
	{
		if (this.comboBox2.SelectedIndex != -1)
		{
			if (this.comboBox3.SelectedItem.ToString() == "ALIBI")
			{
				Settings.Default.ALIBIstrenght = this.trackBar1.Value.ToString();
				Settings.Default.ALIBIsleep = this.trackBar2.Value.ToString();
				Settings.Default.ALIBIstrenght2 = this.trackBar3.Value.ToString();
				Settings.Default.ALIBIsleep2 = this.trackBar4.Value.ToString();
				Settings.Default.Save();
			}
			if (this.comboBox3.SelectedItem.ToString() == "ARUNI")
			{
				Settings.Default.ARUNIstrenght = this.trackBar1.Value.ToString();
				Settings.Default.ARUNIsleep = this.trackBar2.Value.ToString();
				Settings.Default.ARUNIstrenght2 = this.trackBar3.Value.ToString();
				Settings.Default.ARUNIsleep2 = this.trackBar4.Value.ToString();
				Settings.Default.Save();
			}
			if (this.comboBox3.SelectedItem.ToString() == "AZAMI")
			{
				Settings.Default.AZAMIstrenght = this.trackBar1.Value.ToString();
				Settings.Default.AZAMIsleep = this.trackBar2.Value.ToString();
				Settings.Default.AZAMIstrenght2 = this.trackBar3.Value.ToString();
				Settings.Default.AZAMIsleep2 = this.trackBar4.Value.ToString();
				Settings.Default.Save();
			}
			if (this.comboBox3.SelectedItem.ToString() == "BANDIT")
			{
				Settings.Default.BANDITstrenght = this.trackBar1.Value.ToString();
				Settings.Default.BANDITsleep = this.trackBar2.Value.ToString();
				Settings.Default.BANDITstrenght2 = this.trackBar3.Value.ToString();
				Settings.Default.BANDITsleep2 = this.trackBar4.Value.ToString();
				Settings.Default.Save();
			}
			if (this.comboBox3.SelectedItem.ToString() == "CASTLE")
			{
				Settings.Default.CASTLEstrenght = this.trackBar1.Value.ToString();
				Settings.Default.CASTLEsleep = this.trackBar2.Value.ToString();
				Settings.Default.CASTLEstrenght2 = this.trackBar3.Value.ToString();
				Settings.Default.CASTLEsleep2 = this.trackBar4.Value.ToString();
				Settings.Default.Save();
			}
			if (this.comboBox3.SelectedItem.ToString() == "CAVEIRA")
			{
				Settings.Default.CAVEIRAstrenght = this.trackBar1.Value.ToString();
				Settings.Default.CAVEIRAsleep = this.trackBar2.Value.ToString();
				Settings.Default.CAVEIRAstrenght2 = this.trackBar3.Value.ToString();
				Settings.Default.CAVEIRAsleep2 = this.trackBar4.Value.ToString();
				Settings.Default.Save();
			}
			if (this.comboBox3.SelectedItem.ToString() == "CLASH")
			{
				Settings.Default.CLASHstrenght = this.trackBar1.Value.ToString();
				Settings.Default.CLASHsleep = this.trackBar2.Value.ToString();
				Settings.Default.CLASHstrenght2 = this.trackBar3.Value.ToString();
				Settings.Default.CLASHsleep2 = this.trackBar4.Value.ToString();
				Settings.Default.Save();
			}
			if (this.comboBox3.SelectedItem.ToString() == "DOC")
			{
				Settings.Default.DOCstrenght = this.trackBar1.Value.ToString();
				Settings.Default.DOCsleep = this.trackBar2.Value.ToString();
				Settings.Default.DOCstrenght2 = this.trackBar3.Value.ToString();
				Settings.Default.DOCsleep2 = this.trackBar4.Value.ToString();
				Settings.Default.Save();
			}
			if (this.comboBox3.SelectedItem.ToString() == "ECHO")
			{
				Settings.Default.ECHOstrenght = this.trackBar1.Value.ToString();
				Settings.Default.ECHOsleep = this.trackBar2.Value.ToString();
				Settings.Default.ECHOstrenght2 = this.trackBar3.Value.ToString();
				Settings.Default.ECHOsleep2 = this.trackBar4.Value.ToString();
				Settings.Default.Save();
			}
			if (this.comboBox3.SelectedItem.ToString() == "ELA")
			{
				Settings.Default.ELAstrenght = this.trackBar1.Value.ToString();
				Settings.Default.ELAsleep = this.trackBar2.Value.ToString();
				Settings.Default.ELAstrenght2 = this.trackBar3.Value.ToString();
				Settings.Default.ELAsleep2 = this.trackBar4.Value.ToString();
				Settings.Default.Save();
			}
			if (this.comboBox3.SelectedItem.ToString() == "FROST")
			{
				Settings.Default.FROSTstrenght = this.trackBar1.Value.ToString();
				Settings.Default.FROSTsleep = this.trackBar2.Value.ToString();
				Settings.Default.FROSTstrenght2 = this.trackBar3.Value.ToString();
				Settings.Default.FROSTsleep2 = this.trackBar4.Value.ToString();
				Settings.Default.Save();
			}
			if (this.comboBox3.SelectedItem.ToString() == "GOYO")
			{
				Settings.Default.GOYOstrenght = this.trackBar1.Value.ToString();
				Settings.Default.GOYOsleep = this.trackBar2.Value.ToString();
				Settings.Default.GOYOstrenght2 = this.trackBar3.Value.ToString();
				Settings.Default.GOYOsleep2 = this.trackBar4.Value.ToString();
				Settings.Default.Save();
			}
			if (this.comboBox3.SelectedItem.ToString() == "JÄGER")
			{
				Settings.Default.String_8 = this.trackBar1.Value.ToString();
				Settings.Default.String_9 = this.trackBar2.Value.ToString();
				Settings.Default.String_10 = this.trackBar3.Value.ToString();
				Settings.Default.String_12 = this.trackBar4.Value.ToString();
				Settings.Default.Save();
			}
			if (this.comboBox3.SelectedItem.ToString() == "KAID")
			{
				Settings.Default.KAIDstrenght = this.trackBar1.Value.ToString();
				Settings.Default.KAIDsleep = this.trackBar2.Value.ToString();
				Settings.Default.KAIDstrenght2 = this.trackBar3.Value.ToString();
				Settings.Default.KAIDsleep2 = this.trackBar4.Value.ToString();
				Settings.Default.Save();
			}
			if (this.comboBox3.SelectedItem.ToString() == "KAPKAN")
			{
				Settings.Default.KAPKANstrenght = this.trackBar1.Value.ToString();
				Settings.Default.KAPKANsleep = this.trackBar2.Value.ToString();
				Settings.Default.KAPKANstrenght2 = this.trackBar3.Value.ToString();
				Settings.Default.KAPKANsleep2 = this.trackBar4.Value.ToString();
				Settings.Default.Save();
			}
			if (this.comboBox3.SelectedItem.ToString() == "LESION")
			{
				Settings.Default.LESIONstrenght = this.trackBar1.Value.ToString();
				Settings.Default.LESIONsleep = this.trackBar2.Value.ToString();
				Settings.Default.LESIONstrenght2 = this.trackBar3.Value.ToString();
				Settings.Default.LESIONsleep2 = this.trackBar4.Value.ToString();
				Settings.Default.Save();
			}
			if (this.comboBox3.SelectedItem.ToString() == "MAESTRO")
			{
				Settings.Default.MAESTROstrenght = this.trackBar1.Value.ToString();
				Settings.Default.MAESTROsleep = this.trackBar2.Value.ToString();
				Settings.Default.MAESTROstrenght2 = this.trackBar3.Value.ToString();
				Settings.Default.MAESTROsleep2 = this.trackBar4.Value.ToString();
				Settings.Default.Save();
			}
			if (this.comboBox3.SelectedItem.ToString() == "MELUSI")
			{
				Settings.Default.MELUSIstrenght = this.trackBar1.Value.ToString();
				Settings.Default.MELUSIsleep = this.trackBar2.Value.ToString();
				Settings.Default.MELUSIstrenght2 = this.trackBar3.Value.ToString();
				Settings.Default.MELUSIsleep2 = this.trackBar4.Value.ToString();
				Settings.Default.Save();
			}
			if (this.comboBox3.SelectedItem.ToString() == "MIRA")
			{
				Settings.Default.MIRAstrenght = this.trackBar1.Value.ToString();
				Settings.Default.MIRAsleep = this.trackBar2.Value.ToString();
				Settings.Default.MIRAstrenght2 = this.trackBar3.Value.ToString();
				Settings.Default.MIRAsleep2 = this.trackBar4.Value.ToString();
				Settings.Default.Save();
			}
			if (this.comboBox3.SelectedItem.ToString() == "MOZZIE")
			{
				Settings.Default.MOZZIEstrenght = this.trackBar1.Value.ToString();
				Settings.Default.MOZZIEsleep = this.trackBar2.Value.ToString();
				Settings.Default.MOZZIEstrenght2 = this.trackBar3.Value.ToString();
				Settings.Default.MOZZIEsleep2 = this.trackBar4.Value.ToString();
				Settings.Default.Save();
			}
			if (this.comboBox3.SelectedItem.ToString() == "MUTE")
			{
				Settings.Default.MUTEstrenght = this.trackBar1.Value.ToString();
				Settings.Default.MUTEsleep = this.trackBar2.Value.ToString();
				Settings.Default.MUTEstrenght2 = this.trackBar3.Value.ToString();
				Settings.Default.MUTEsleep2 = this.trackBar4.Value.ToString();
				Settings.Default.Save();
			}
			if (this.comboBox3.SelectedItem.ToString() == "ORYX")
			{
				Settings.Default.ORYXstrenght = this.trackBar1.Value.ToString();
				Settings.Default.ORYXsleep = this.trackBar2.Value.ToString();
				Settings.Default.ORYXstrenght2 = this.trackBar3.Value.ToString();
				Settings.Default.ORYXsleep2 = this.trackBar4.Value.ToString();
				Settings.Default.Save();
			}
			if (this.comboBox3.SelectedItem.ToString() == "PULSE")
			{
				Settings.Default.PULSEstrenght = this.trackBar1.Value.ToString();
				Settings.Default.PULSEsleep = this.trackBar2.Value.ToString();
				Settings.Default.PULSEstrenght2 = this.trackBar3.Value.ToString();
				Settings.Default.PULSEsleep2 = this.trackBar4.Value.ToString();
				Settings.Default.Save();
			}
			if (this.comboBox3.SelectedItem.ToString() == "ROOK")
			{
				Settings.Default.ROOKstrenght = this.trackBar1.Value.ToString();
				Settings.Default.ROOKsleep = this.trackBar2.Value.ToString();
				Settings.Default.ROOKstrenght2 = this.trackBar3.Value.ToString();
				Settings.Default.ROOKsleep2 = this.trackBar4.Value.ToString();
				Settings.Default.Save();
			}
			if (this.comboBox3.SelectedItem.ToString() == "SMOKE")
			{
				Settings.Default.SMOKEstrenght = this.trackBar1.Value.ToString();
				Settings.Default.SMOKEsleep = this.trackBar2.Value.ToString();
				Settings.Default.SMOKEstrenght2 = this.trackBar3.Value.ToString();
				Settings.Default.SMOKEsleep2 = this.trackBar4.Value.ToString();
				Settings.Default.Save();
			}
			if (this.comboBox3.SelectedItem.ToString() == "TACHANKA")
			{
				Settings.Default.TACHANKAstrenght = this.trackBar1.Value.ToString();
				Settings.Default.TACHANKAsleep = this.trackBar2.Value.ToString();
				Settings.Default.TACHANKAstrenght2 = this.trackBar3.Value.ToString();
				Settings.Default.TACHANKAsleep2 = this.trackBar4.Value.ToString();
				Settings.Default.Save();
			}
			if (this.comboBox3.SelectedItem.ToString() == "THORN")
			{
				Settings.Default.THORNstrenght = this.trackBar1.Value.ToString();
				Settings.Default.THORNsleep = this.trackBar2.Value.ToString();
				Settings.Default.THORNstrenght2 = this.trackBar3.Value.ToString();
				Settings.Default.THORNsleep2 = this.trackBar4.Value.ToString();
				Settings.Default.Save();
			}
			if (this.comboBox3.SelectedItem.ToString() == "THUNDERBIRD")
			{
				Settings.Default.THUNDERBIRDstrenght = this.trackBar1.Value.ToString();
				Settings.Default.THUNDERBIRDsleep = this.trackBar2.Value.ToString();
				Settings.Default.THUNDERBIRDstrenght2 = this.trackBar3.Value.ToString();
				Settings.Default.THUNDERBIRDsleep2 = this.trackBar4.Value.ToString();
				Settings.Default.Save();
			}
			if (this.comboBox3.SelectedItem.ToString() == "VALKYRIE")
			{
				Settings.Default.VALKYRIEstrenght = this.trackBar1.Value.ToString();
				Settings.Default.VALKYRIEsleep = this.trackBar2.Value.ToString();
				Settings.Default.VALKYRIEstrenght2 = this.trackBar3.Value.ToString();
				Settings.Default.VALKYRIEsleep2 = this.trackBar4.Value.ToString();
				Settings.Default.Save();
			}
			if (this.comboBox3.SelectedItem.ToString() == "VIGIL")
			{
				Settings.Default.VIGILstrenght = this.trackBar1.Value.ToString();
				Settings.Default.VIGILsleep = this.trackBar2.Value.ToString();
				Settings.Default.VIGILstrenght2 = this.trackBar3.Value.ToString();
				Settings.Default.VIGILsleep2 = this.trackBar4.Value.ToString();
				Settings.Default.Save();
			}
			if (this.comboBox3.SelectedItem.ToString() == "WAMAI")
			{
				Settings.Default.WAMAIstrenght = this.trackBar1.Value.ToString();
				Settings.Default.WAMAIsleep = this.trackBar2.Value.ToString();
				Settings.Default.WAMAIstrenght2 = this.trackBar3.Value.ToString();
				Settings.Default.WAMAIsleep2 = this.trackBar4.Value.ToString();
				Settings.Default.Save();
			}
			if (this.comboBox3.SelectedItem.ToString() == "WARDEN")
			{
				Settings.Default.WARDENstrenght = this.trackBar1.Value.ToString();
				Settings.Default.WARDENsleep = this.trackBar2.Value.ToString();
				Settings.Default.WARDENstrenght2 = this.trackBar3.Value.ToString();
				Settings.Default.WARDENsleep2 = this.trackBar4.Value.ToString();
				Settings.Default.Save();
			}
		}
	}

	// Token: 0x06000053 RID: 83 RVA: 0x000212D8 File Offset: 0x0001F4D8
	private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (this.comboBox1.SelectedIndex != -1)
		{
			this.label10.Text = this.comboBox1.SelectedItem.ToString();
		}
	}

	// Token: 0x06000054 RID: 84 RVA: 0x00021310 File Offset: 0x0001F510
	private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
	{
		this.button9.FlatAppearance.BorderColor = Color.Lime;
		this.button8.FlatAppearance.BorderColor = Color.Red;
		if (this.comboBox2.SelectedItem.ToString() == "ACE")
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
		if (this.comboBox2.SelectedItem.ToString() == "AMARU")
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
		if (this.comboBox2.SelectedItem.ToString() == "ASH")
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
		if (this.comboBox2.SelectedItem.ToString() == "BLACKBEARD")
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
		if (this.comboBox2.SelectedItem.ToString() == "BLITZ")
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
		if (this.comboBox2.SelectedItem.ToString() == "BUCK")
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
		if (this.comboBox2.SelectedItem.ToString() == "CAPITÃO")
		{
			this.Valuesetter.Text = Settings.Default.String_0;
			this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
			this.Valuesetter.Text = Settings.Default.String_2;
			this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
			this.Valuesetter.Text = Settings.Default.String_4;
			this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
			this.Valuesetter.Text = Settings.Default.String_6;
			this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
			this.opoutput.Text = this.comboBox2.SelectedItem.ToString();
		}
		if (this.comboBox2.SelectedItem.ToString() == "DOKKAEBI")
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
		if (this.comboBox2.SelectedItem.ToString() == "FINKA")
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
		if (this.comboBox2.SelectedItem.ToString() == "FLORES")
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
		if (this.comboBox2.SelectedItem.ToString() == "FUZE")
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
		if (this.comboBox2.SelectedItem.ToString() == "GLAZ")
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
		if (this.comboBox2.SelectedItem.ToString() == "GRIDLOCK")
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
		if (this.comboBox2.SelectedItem.ToString() == "HIBANA")
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
		if (this.comboBox2.SelectedItem.ToString() == "IANA")
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
		if (this.comboBox2.SelectedItem.ToString() == "IQ")
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
		if (this.comboBox2.SelectedItem.ToString() == "JACKAL")
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
		if (this.comboBox2.SelectedItem.ToString() == "KALI")
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
		if (this.comboBox2.SelectedItem.ToString() == "LION")
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
		if (this.comboBox2.SelectedItem.ToString() == "MAVERICK")
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
		if (this.comboBox2.SelectedItem.ToString() == "MONTAGNE")
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
		if (this.comboBox2.SelectedItem.ToString() == "NOMAD")
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
		if (this.comboBox2.SelectedItem.ToString() == "NØKK")
		{
			this.Valuesetter.Text = Settings.Default.String_1;
			this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
			this.Valuesetter.Text = Settings.Default.String_3;
			this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
			this.Valuesetter.Text = Settings.Default.String_5;
			this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
			this.Valuesetter.Text = Settings.Default.String_7;
			this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
			this.opoutput.Text = this.comboBox2.SelectedItem.ToString();
		}
		if (this.comboBox2.SelectedItem.ToString() == "OSA")
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
		if (this.comboBox2.SelectedItem.ToString() == "SENS")
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
		if (this.comboBox2.SelectedItem.ToString() == "SLEDGE")
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
		if (this.comboBox2.SelectedItem.ToString() == "THATCHER")
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
		if (this.comboBox2.SelectedItem.ToString() == "THERMITE")
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
		if (this.comboBox2.SelectedItem.ToString() == "TWITCH")
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
		if (this.comboBox2.SelectedItem.ToString() == "YING")
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
		if (this.comboBox2.SelectedItem.ToString() == "ZERO")
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
		if (this.comboBox2.SelectedItem.ToString() == "ZOFIA")
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

	// Token: 0x06000055 RID: 85 RVA: 0x00023288 File Offset: 0x00021488
	private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
	{
		this.button9.FlatAppearance.BorderColor = Color.Red;
		this.button8.FlatAppearance.BorderColor = Color.Lime;
		if (this.comboBox3.SelectedItem.ToString() == "ALIBI")
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
		if (this.comboBox3.SelectedItem.ToString() == "ARUNI")
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
		if (this.comboBox3.SelectedItem.ToString() == "AZAMI")
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
		if (this.comboBox3.SelectedItem.ToString() == "BANDIT")
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
		if (this.comboBox3.SelectedItem.ToString() == "CASTLE")
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
		if (this.comboBox3.SelectedItem.ToString() == "CAVEIRA")
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
		if (this.comboBox3.SelectedItem.ToString() == "CLASH")
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
		if (this.comboBox3.SelectedItem.ToString() == "DOC")
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
		if (this.comboBox3.SelectedItem.ToString() == "ECHO")
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
		if (this.comboBox3.SelectedItem.ToString() == "ELA")
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
		if (this.comboBox3.SelectedItem.ToString() == "FROST")
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
		if (this.comboBox3.SelectedItem.ToString() == "GOYO")
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
		if (this.comboBox3.SelectedItem.ToString() == "JÄGER")
		{
			this.Valuesetter.Text = Settings.Default.String_8;
			this.trackBar1.Value = int.Parse(this.Valuesetter.Text);
			this.Valuesetter.Text = Settings.Default.String_9;
			this.trackBar2.Value = int.Parse(this.Valuesetter.Text);
			this.Valuesetter.Text = Settings.Default.String_10;
			this.trackBar3.Value = int.Parse(this.Valuesetter.Text);
			this.Valuesetter.Text = Settings.Default.String_12;
			this.trackBar4.Value = int.Parse(this.Valuesetter.Text);
			this.opoutput.Text = this.comboBox3.SelectedItem.ToString();
		}
		if (this.comboBox3.SelectedItem.ToString() == "KAID")
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
		if (this.comboBox3.SelectedItem.ToString() == "KAPKAN")
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
		if (this.comboBox3.SelectedItem.ToString() == "LESION")
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
		if (this.comboBox3.SelectedItem.ToString() == "MAESTRO")
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
		if (this.comboBox3.SelectedItem.ToString() == "MELUSI")
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
		if (this.comboBox3.SelectedItem.ToString() == "MIRA")
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
		if (this.comboBox3.SelectedItem.ToString() == "MOZZIE")
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
		if (this.comboBox3.SelectedItem.ToString() == "MUTE")
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
		if (this.comboBox3.SelectedItem.ToString() == "ORYX")
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
		if (this.comboBox3.SelectedItem.ToString() == "PULSE")
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
		if (this.comboBox3.SelectedItem.ToString() == "ROOK")
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
		if (this.comboBox3.SelectedItem.ToString() == "SMOKE")
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
		if (this.comboBox3.SelectedItem.ToString() == "TACHANKA")
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
		if (this.comboBox3.SelectedItem.ToString() == "THORN")
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
		if (this.comboBox3.SelectedItem.ToString() == "THUNDERBIRD")
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
		if (this.comboBox3.SelectedItem.ToString() == "VALKYRIE")
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
		if (this.comboBox3.SelectedItem.ToString() == "VIGIL")
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
		if (this.comboBox3.SelectedItem.ToString() == "WAMAI")
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
		if (this.comboBox3.SelectedItem.ToString() == "WARDEN")
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

	// Token: 0x06000056 RID: 86 RVA: 0x00025200 File Offset: 0x00023400
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

	// Token: 0x06000057 RID: 87 RVA: 0x00019290 File Offset: 0x00017490
	private void checkBox2_CheckedChanged(object sender, EventArgs e)
	{
	}

	// Token: 0x06000058 RID: 88 RVA: 0x00025228 File Offset: 0x00023428
	private void panel1_MouseDown(object sender, MouseEventArgs e)
	{
		Form1.ReleaseCapture();
		Form1.SendMessage(this.method_5(), 161, 2, 0);
	}

	// Token: 0x06000059 RID: 89
	[DllImport("user32.dll")]
	private static extern IntPtr GetForegroundWindow();

	// Token: 0x0600005A RID: 90
	[DllImport("user32.dll")]
	private static extern int GetWindowThreadProcessId(IntPtr intptr_1, out uint uint_5);

	// Token: 0x0600005B RID: 91 RVA: 0x00025250 File Offset: 0x00023450
	private string method_4()
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
			this.string_3 = num.ToString();
		}
		return "Unknown";
	}

	// Token: 0x0600005C RID: 92
	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool SetWindowPos(IntPtr intptr_1, IntPtr intptr_2, int int_6, int int_7, int int_8, int int_9, uint uint_5);

	// Token: 0x0600005D RID: 93 RVA: 0x000252D4 File Offset: 0x000234D4
	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (Form1.bool_0)
		{
			this.label8.Text = "ENABLED";
			this.label8.ForeColor = Color.Green;
			this.method_0();
		}
		else
		{
			this.label8.Text = "DISABLED";
			this.label8.ForeColor = Color.Red;
		}
	}

	// Token: 0x0600005E RID: 94 RVA: 0x00025330 File Offset: 0x00023530
	private void timer_1_Tick(object sender, EventArgs e)
	{
		this.method_4();
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
		if (this.comboBox2.SelectedIndex != -1)
		{
			this.trackBar1.Enabled = true;
			this.trackBar2.Enabled = true;
			this.trackBar3.Enabled = true;
			this.trackBar4.Enabled = true;
		}
		else
		{
			this.trackBar1.Enabled = false;
			this.trackBar2.Enabled = false;
			this.trackBar3.Enabled = false;
			this.trackBar4.Enabled = false;
		}
	}

	// Token: 0x0600005F RID: 95 RVA: 0x00025AF0 File Offset: 0x00023CF0
	private void timer_2_Tick(object sender, EventArgs e)
	{
		Process[] processesByName = Process.GetProcessesByName("RainbowSix");
		foreach (Process process in processesByName)
		{
			this.string_1 = process.Id.ToString();
			this.label20.Text = (this.string_1 ?? "");
		}
		Process[] processesByName2 = Process.GetProcessesByName("RainbowSix_Vulkan");
		foreach (Process process2 in processesByName2)
		{
			this.string_2 = process2.Id.ToString();
			this.label17.Text = (this.string_1 ?? "");
		}
	}

	// Token: 0x06000060 RID: 96 RVA: 0x00025BA8 File Offset: 0x00023DA8
	private void button7_Click(object sender, EventArgs e)
	{
		Process.Start("explorer.exe", "/open," + Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));
		MessageBox.Show("Default location is AppData\\Local\\MILLENIUM..\\EXE_NAME ");
	}

	// Token: 0x06000061 RID: 97 RVA: 0x00025BDC File Offset: 0x00023DDC
	private void button4_Click(object sender, EventArgs e)
	{
		if (MessageBox.Show("This will reset all the configs for all operators to default value , Your password and username will be forgotten. the next login you need to enter your credentials again. Are you sure you want to reset?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
		{
			Settings.Default.Reset();
		}
	}

	// Token: 0x06000062 RID: 98 RVA: 0x0001B24C File Offset: 0x0001944C
	private void trackBar1_ValueChanged(object sender, EventArgs e)
	{
		this.label3.Text = "STRENGHT: " + this.trackBar1.Value.ToString();
	}

	// Token: 0x06000063 RID: 99 RVA: 0x00025C08 File Offset: 0x00023E08
	private void button1_Click(object sender, EventArgs e)
	{
		if (this.panel3.Visible)
		{
			this.panel3.Visible = false;
		}
		else
		{
			this.panel4.Visible = false;
			this.panel3.Visible = true;
		}
	}

	// Token: 0x06000064 RID: 100 RVA: 0x00025C48 File Offset: 0x00023E48
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

	// Token: 0x06000065 RID: 101 RVA: 0x00025228 File Offset: 0x00023428
	private void Form1_MouseDown(object sender, MouseEventArgs e)
	{
		Form1.ReleaseCapture();
		Form1.SendMessage(this.method_5(), 161, 2, 0);
	}

	// Token: 0x06000066 RID: 102 RVA: 0x00025228 File Offset: 0x00023428
	private void panel4_MouseDown(object sender, MouseEventArgs e)
	{
		Form1.ReleaseCapture();
		Form1.SendMessage(this.method_5(), 161, 2, 0);
	}

	// Token: 0x06000067 RID: 103 RVA: 0x00025228 File Offset: 0x00023428
	private void panel3_MouseDown(object sender, MouseEventArgs e)
	{
		Form1.ReleaseCapture();
		Form1.SendMessage(this.method_5(), 161, 2, 0);
	}

	// Token: 0x06000068 RID: 104 RVA: 0x00025C88 File Offset: 0x00023E88
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

	// Token: 0x06000069 RID: 105 RVA: 0x00019290 File Offset: 0x00017490
	private void timer_4_Tick(object sender, EventArgs e)
	{
	}

	// Token: 0x0600006A RID: 106 RVA: 0x00025CE0 File Offset: 0x00023EE0
	private void trackBar5_ValueChanged(object sender, EventArgs e)
	{
		this.label16.Text = this.trackBar5.Value.ToString();
	}

	// Token: 0x0600006B RID: 107 RVA: 0x00025D0C File Offset: 0x00023F0C
	private void trackBar6_ValueChanged(object sender, EventArgs e)
	{
		this.label18.Text = this.trackBar6.Value.ToString();
	}

	// Token: 0x0600006C RID: 108 RVA: 0x00025D38 File Offset: 0x00023F38
	private void trackBar7_ValueChanged(object sender, EventArgs e)
	{
		this.label22.Text = this.trackBar7.Value.ToString();
	}

	// Token: 0x0600006D RID: 109 RVA: 0x00025D64 File Offset: 0x00023F64
	private void timer_6_Tick(object sender, EventArgs e)
	{
		base.TopMost = true;
	}

	// Token: 0x0600006E RID: 110 RVA: 0x00019290 File Offset: 0x00017490
	private void label18_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x0600006F RID: 111 RVA: 0x00019290 File Offset: 0x00017490
	private void label16_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x06000070 RID: 112 RVA: 0x00019290 File Offset: 0x00017490
	private void label22_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x06000071 RID: 113 RVA: 0x00025D78 File Offset: 0x00023F78
	private void trackBar1_KeyPress(object sender, KeyPressEventArgs e)
	{
		MessageBox.Show("lol");
	}

	// Token: 0x06000072 RID: 114 RVA: 0x00025D90 File Offset: 0x00023F90
	private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		MessageBox.Show("Removed auth, theres nothing to be seen.");
		//Process.Start("explorer", "https://auth.gg/portal/Millenium");
	}

	// Token: 0x06000073 RID: 115 RVA: 0x00025DB0 File Offset: 0x00023FB0
	private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		MessageBox.Show("You don't want to join their discord server.");
		//Process.Start("explorer", "https://discord.gg/V3nrJCEkP2");
	}

	// Token: 0x06000074 RID: 116 RVA: 0x00025D90 File Offset: 0x00023F90
	private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		MessageBox.Show("Removed auth, theres nothing to be seen.");
		//Process.Start("explorer", "https://auth.gg/portal/Millenium");
	}

	// Token: 0x06000075 RID: 117 RVA: 0x00025DD0 File Offset: 0x00023FD0
	protected virtual void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x06000078 RID: 120 RVA: 0x0002935C File Offset: 0x0002755C
	IntPtr method_5()
	{
		return base.Handle;
	}

	// Token: 0x0400003F RID: 63
	private Thread thread_0;

	// Token: 0x04000040 RID: 64
	public const string string_0 = "RainbowSix";

	// Token: 0x04000041 RID: 65
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private object object_0;

	// Token: 0x04000042 RID: 66
	public const int int_0 = 161;

	// Token: 0x04000043 RID: 67
	public const int int_1 = 2;

	// Token: 0x04000044 RID: 68
	public static bool bool_0 = true;

	// Token: 0x04000045 RID: 69
	public static bool bool_1 = true;

	// Token: 0x04000046 RID: 70
	public static int int_2 = 1;

	// Token: 0x04000047 RID: 71
	public static int int_3 = 1;

	// Token: 0x04000048 RID: 72
	public static int int_4 = 1;

	// Token: 0x04000049 RID: 73
	public static int int_5 = 0;

	// Token: 0x0400004A RID: 74
	private static uint uint_0 = 144U;

	// Token: 0x0400004B RID: 75
	private static uint uint_1 = 1U;

	// Token: 0x0400004C RID: 76
	private string string_1;

	// Token: 0x0400004D RID: 77
	private string string_2;

	// Token: 0x0400004E RID: 78
	private string string_3;

	// Token: 0x0400004F RID: 79
	private static readonly IntPtr intptr_0 = new IntPtr(-1);

	// Token: 0x04000050 RID: 80
	private const uint uint_2 = 1U;

	// Token: 0x04000051 RID: 81
	private const uint uint_3 = 2U;

	// Token: 0x04000052 RID: 82
	private const uint uint_4 = 3U;
}
