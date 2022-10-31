using System;
using System.Runtime.InteropServices;

// Token: 0x0200000D RID: 13
public class GClass0 : IDisposable
{
	// Token: 0x06000037 RID: 55 RVA: 0x0001A70C File Offset: 0x0001890C
	public GClass0(IntPtr intptr_1, IntPtr intptr_2)
	{
		GClass0.VirtualProtect(intptr_1, 5U, GClass0.GEnum0.PAGE_EXECUTE_READWRITE, out this.genum0_0);
		Marshal.Copy(intptr_1, this.byte_0, 0, 5);
		this.byte_1[0] = 233;
		byte[] bytes = BitConverter.GetBytes((int)intptr_2 - (int)intptr_1 - 5);
		Array.Copy(bytes, 0, this.byte_1, 1, 4);
		this.intptr_0 = intptr_1;
	}

	// Token: 0x06000038 RID: 56 RVA: 0x0001A790 File Offset: 0x00018990
	public GClass0(IntPtr intptr_1, Delegate delegate_0) : this(intptr_1, Marshal.GetFunctionPointerForDelegate(delegate_0))
	{
	}

	// Token: 0x06000039 RID: 57 RVA: 0x0001A7AC File Offset: 0x000189AC
	public void method_0()
	{
		Marshal.Copy(this.byte_1, 0, this.intptr_0, 5);
	}

	// Token: 0x0600003A RID: 58 RVA: 0x0001A7CC File Offset: 0x000189CC
	public void method_1()
	{
		Marshal.Copy(this.byte_0, 0, this.intptr_0, 5);
	}

	// Token: 0x0600003B RID: 59 RVA: 0x0001A7EC File Offset: 0x000189EC
	public void Dispose()
	{
		this.method_1();
		GClass0.GEnum0 genum;
		GClass0.VirtualProtect(this.intptr_0, 5U, this.genum0_0, out genum);
	}

	// Token: 0x0600003C RID: 60
	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool VirtualProtect(IntPtr intptr_1, uint uint_0, GClass0.GEnum0 genum0_1, out GClass0.GEnum0 genum0_2);

	// Token: 0x0400002E RID: 46
	private const int int_0 = 5;

	// Token: 0x0400002F RID: 47
	private IntPtr intptr_0;

	// Token: 0x04000030 RID: 48
	private GClass0.GEnum0 genum0_0;

	// Token: 0x04000031 RID: 49
	private byte[] byte_0 = new byte[5];

	// Token: 0x04000032 RID: 50
	private byte[] byte_1 = new byte[5];

	// Token: 0x0200000E RID: 14
	public enum GEnum0
	{
		// Token: 0x04000034 RID: 52
		PAGE_NOACCESS = 1,
		// Token: 0x04000035 RID: 53
		PAGE_READONLY,
		// Token: 0x04000036 RID: 54
		PAGE_READWRITE = 4,
		// Token: 0x04000037 RID: 55
		PAGE_WRITECOPY = 8,
		// Token: 0x04000038 RID: 56
		PAGE_EXECUTE = 16,
		// Token: 0x04000039 RID: 57
		PAGE_EXECUTE_READ = 32,
		// Token: 0x0400003A RID: 58
		PAGE_EXECUTE_READWRITE = 64,
		// Token: 0x0400003B RID: 59
		PAGE_EXECUTE_WRITECOPY = 128,
		// Token: 0x0400003C RID: 60
		PAGE_GUARD = 256,
		// Token: 0x0400003D RID: 61
		PAGE_NOCACHE = 512,
		// Token: 0x0400003E RID: 62
		PAGE_WRITECOMBINE = 1024
	}
}
