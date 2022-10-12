using System;
using System.Runtime.InteropServices;

internal class Class3
{
	// Token: 0x06000072 RID: 114
	[DllImport("user32.dll")]
	private static extern void mouse_event(uint uint_0, int int_0, int int_1, uint uint_1, UIntPtr uintptr_0);

	// Token: 0x06000073 RID: 115
	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool Beep(uint uint_0, uint uint_1);

	// Token: 0x06000074 RID: 116
	[DllImport("user32.dll")]
	public static extern short GetKeyState(uint uint_0);

	// Token: 0x06000075 RID: 117 RVA: 0x0000226E File Offset: 0x0000046E
	internal static int smethod_0(object object_0)
	{
		throw new NotImplementedException();
	}

	// Token: 0x06000076 RID: 118
	[DllImport("user32.dll")]
	private static extern short GetAsyncKeyState(int int_0);

	// Token: 0x06000077 RID: 119 RVA: 0x00015308 File Offset: 0x00013508
	public static void smethod_1(int int_0, int int_1)
	{
		Class3.mouse_event(1U, int_0, int_1, 0U, UIntPtr.Zero);
	}
}
