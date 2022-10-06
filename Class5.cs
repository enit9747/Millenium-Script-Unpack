using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

// Token: 0x02000011 RID: 17
internal class Class5
{
	// Token: 0x06000079 RID: 121
	[DllImport("user32.dll")]
	public static extern short GetAsyncKeyState(Keys keys_0);

	// Token: 0x0600007A RID: 122
	[DllImport("user32.dll")]
	public static extern IntPtr FindWindow(string string_0, string string_1);

	// Token: 0x0600007B RID: 123
	[DllImport("user32.dll")]
	public static extern int SetWindowLong(IntPtr intptr_1, int int_0, int int_1);

	// Token: 0x0600007C RID: 124
	[DllImport("user32.dll", SetLastError = true)]
	public static extern int GetWindowLong(IntPtr intptr_1, int int_0);

	// Token: 0x0600007D RID: 125
	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GetWindowRect(IntPtr intptr_1, out Class5.Struct6 struct6_1);

	// Token: 0x04000097 RID: 151
	public static IntPtr intptr_0 = Class5.FindWindow(null, "RainbowSix");

	// Token: 0x04000098 RID: 152
	public static Class5.Struct6 struct6_0;

	// Token: 0x02000012 RID: 18
	public struct Struct6
	{
		// Token: 0x04000099 RID: 153
		public int int_0;

		// Token: 0x0400009A RID: 154
		public int int_1;

		// Token: 0x0400009B RID: 155
		public int int_2;

		// Token: 0x0400009C RID: 156
		public int int_3;
	}
}
