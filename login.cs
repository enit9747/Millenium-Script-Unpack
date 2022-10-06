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
	// Token: 0x02000004 RID: 4
	public partial class login : Form
	{
		// Token: 0x0600002E RID: 46 RVA: 0x00010DFE File Offset: 0x00010DFE
		public login()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00010FE1 File Offset: 0x00010FE1
		private void login_Load(object sender, EventArgs e)
		{

		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000036 RID: 54 RVA: 0x00011010 File Offset: 0x00011010
		// (set) Token: 0x06000037 RID: 55 RVA: 0x00011018 File Offset: 0x00011018
		public object SelectedItem { get; set; }

		// Token: 0x06000038 RID: 56
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x06000039 RID: 57
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		// Token: 0x0600003D RID: 61 RVA: 0x00011063 File Offset: 0x00011063
		private void login_MouseDown(object sender, MouseEventArgs e)
		{
			login.ReleaseCapture();
			login.SendMessage(base.Handle, 161, 2, 0);
		}

		// Token: 0x04000046 RID: 70
		public static string usernamee = "";

		// Token: 0x04000047 RID: 71
		public static string passwordd = "";

		// Token: 0x04000049 RID: 73
		public const int WM_NCLBUTTONDOWN = 161;

		// Token: 0x0400004A RID: 74
		public const int HT_CAPTION = 2;

        private void button2_Click(object sender, EventArgs e)
        {
			Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
			this.Hide();
            Form1 form1 = new Form1();
			form1.Show();
        }
    }
}
