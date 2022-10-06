using System;
using System.Runtime.InteropServices;

// Token: 0x02000015 RID: 21
internal class Class7
{
	// Token: 0x06000096 RID: 150
	[DllImport("user32.dll")]
	private static extern void mouse_event(uint uint_12, int int_0, int int_1, uint uint_13, UIntPtr uintptr_0);

	// Token: 0x06000097 RID: 151
	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool Beep(uint uint_12, uint uint_13);

	// Token: 0x06000098 RID: 152
	[DllImport("user32.Dll")]
	public static extern short GetKeyState(uint uint_12);

	// Token: 0x06000099 RID: 153 RVA: 0x0002B3D0 File Offset: 0x000295D0
	internal static int smethod_0(string string_0)
	{
		throw new NotImplementedException();
	}

	// Token: 0x0600009A RID: 154
	[DllImport("User32.dll")]
	private static extern short GetAsyncKeyState(int int_0);

	// Token: 0x0600009B RID: 155 RVA: 0x0002B3E4 File Offset: 0x000295E4
	public static void smethod_1(int int_0, int int_1)
	{
		Class7.mouse_event(1U, int_0, int_1, 0U, UIntPtr.Zero);
	}

	// Token: 0x040000CA RID: 202
	private const uint uint_0 = 32768U;

	// Token: 0x040000CB RID: 203
	private const uint uint_1 = 2U;

	// Token: 0x040000CC RID: 204
	private const uint uint_2 = 4U;

	// Token: 0x040000CD RID: 205
	private const uint uint_3 = 32U;

	// Token: 0x040000CE RID: 206
	private const uint uint_4 = 64U;

	// Token: 0x040000CF RID: 207
	private const uint uint_5 = 1U;

	// Token: 0x040000D0 RID: 208
	private const uint uint_6 = 8U;

	// Token: 0x040000D1 RID: 209
	private const uint uint_7 = 16U;

	// Token: 0x040000D2 RID: 210
	private const uint uint_8 = 128U;

	// Token: 0x040000D3 RID: 211
	private const uint uint_9 = 256U;

	// Token: 0x040000D4 RID: 212
	private const uint uint_10 = 2048U;

	// Token: 0x040000D5 RID: 213
	private const uint uint_11 = 4096U;
}
