using System;
using System.Windows.Forms;
using MILLENIUMV2._1;

// Token: 0x02000008 RID: 8
internal static class Program
{
	// Token: 0x06000071 RID: 113 RVA: 0x000152CC File Offset: 0x000134CC
	[STAThread]
	private static void Main()
	{
		//Class8.smethod_0("Millenium", "163912", "xgkf9EIV5shWi6Yk5DCz1CkOFj13YCk5RbJ", "2.3.1");
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run(new login());
	}
}
