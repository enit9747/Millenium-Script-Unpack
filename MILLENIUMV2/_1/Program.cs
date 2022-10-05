using System;
using System.Windows.Forms;

namespace MILLENIUMV2._1
{
	// Token: 0x02000005 RID: 5
	internal static class Program
	{
		// Token: 0x06000041 RID: 65 RVA: 0x00012EE6 File Offset: 0x00012EE6
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new login());
		}
	}
}
