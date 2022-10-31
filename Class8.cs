using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

// Token: 0x02000016 RID: 22
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
[DebuggerNonUserCode]
[CompilerGenerated]
internal class Class8
{
	// Token: 0x0600009D RID: 157 RVA: 0x000199BC File Offset: 0x00017BBC
	internal Class8()
	{
	}

	// Token: 0x17000003 RID: 3
	// (get) Token: 0x0600009E RID: 158 RVA: 0x0002B400 File Offset: 0x00029600
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager_0
	{
		get
		{
			if (Class8.resourceManager_0 == null)
			{
				ResourceManager resourceManager = new ResourceManager("e/}!wPfa^oag4=t{;0\\,Ra48(-", typeof(Class8).Assembly);
				Class8.resourceManager_0 = resourceManager;
			}
			return Class8.resourceManager_0;
		}
	}

	// Token: 0x17000004 RID: 4
	// (get) Token: 0x0600009F RID: 159 RVA: 0x0002B440 File Offset: 0x00029640
	// (set) Token: 0x060000A0 RID: 160 RVA: 0x0002B454 File Offset: 0x00029654
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo CultureInfo_0
	{
		get
		{
			return Class8.cultureInfo_0;
		}
		set
		{
			Class8.cultureInfo_0 = value;
		}
	}

	// Token: 0x040000D6 RID: 214
	private static ResourceManager resourceManager_0;

	// Token: 0x040000D7 RID: 215
	private static CultureInfo cultureInfo_0;
}
