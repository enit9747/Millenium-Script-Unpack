using System;
using System.IO;
using System.Windows.Forms;
using MILLENIUMV2._1;
using Newtonsoft.Json;

// Token: 0x02000004 RID: 4
internal class Class0
{
	// Token: 0x06000007 RID: 7 RVA: 0x00002710 File Offset: 0x00000910
	public static void smethod_0(int int_0, int int_1, int int_2, int int_3, string string_0)
	{
		using (StreamWriter streamWriter = File.CreateText(AppContext.BaseDirectory + "\\Configs\\" + string_0 + ".json"))
		{
			RecoilConfig value = new RecoilConfig
			{
				verticalstrength = int_0,
				horizontalstrength = int_1,
				verticalslow = int_2,
				horizontalslow = int_3
			};
			JsonSerializer jsonSerializer = new JsonSerializer();
			jsonSerializer.Serialize(streamWriter, value);
			MessageBox.Show("Created Config " + string_0 + " Successfully!");
		}
	}
}
