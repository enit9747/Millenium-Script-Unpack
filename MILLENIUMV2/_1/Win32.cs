using System;
using System.Runtime.InteropServices;

namespace MILLENIUMV2._1
{
	// Token: 0x02000006 RID: 6
	internal class Win32
	{
		// Token: 0x06000042 RID: 66
		[DllImport("user32.dll")]
		private static extern void mouse_event(uint dwFlags, int dx, int dy, uint dwData, UIntPtr dwExtraInfo);

		// Token: 0x06000043 RID: 67
		[DllImport("kernel32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool Beep(uint dwFreq, uint dwDuration);

		// Token: 0x06000044 RID: 68
		[DllImport("user32.Dll")]
		public static extern short GetKeyState(uint nVirtKey);

		// Token: 0x06000045 RID: 69 RVA: 0x00012F1B File Offset: 0x00012F1B
		internal static int GetKeyState(string v)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000046 RID: 70
		[DllImport("User32.dll")]
		private static extern short GetAsyncKeyState(int vKey);

		// Token: 0x06000047 RID: 71 RVA: 0x00012F23 File Offset: 0x00012F23
		public static void Move(int x, int y)
		{
			Win32.mouse_event(1U, x, y, 0U, UIntPtr.Zero);
		}

		// Token: 0x04000072 RID: 114
		private const uint MOUSEEVENTF_ABSOLUTE = 32768U;

		// Token: 0x04000073 RID: 115
		private const uint MOUSEEVENTF_LEFTDOWN = 2U;

		// Token: 0x04000074 RID: 116
		private const uint MOUSEEVENTF_LEFTUP = 4U;

		// Token: 0x04000075 RID: 117
		private const uint MOUSEEVENTF_MIDDLEDOWN = 32U;

		// Token: 0x04000076 RID: 118
		private const uint MOUSEEVENTF_MIDDLEUP = 64U;

		// Token: 0x04000077 RID: 119
		private const uint MOUSEEVENTF_MOVE = 1U;

		// Token: 0x04000078 RID: 120
		private const uint MOUSEEVENTF_RIGHTDOWN = 8U;

		// Token: 0x04000079 RID: 121
		private const uint MOUSEEVENTF_RIGHTUP = 16U;

		// Token: 0x0400007A RID: 122
		private const uint MOUSEEVENTF_XDOWN = 128U;

		// Token: 0x0400007B RID: 123
		private const uint MOUSEEVENTF_XUP = 256U;

		// Token: 0x0400007C RID: 124
		private const uint MOUSEEVENTF_WHEEL = 2048U;

		// Token: 0x0400007D RID: 125
		private const uint MOUSEEVENTF_HWHEEL = 4096U;
	}
}
