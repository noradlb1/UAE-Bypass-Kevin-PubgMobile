using System;
using System.IO;

namespace ns0
{
	// Token: 0x020000F2 RID: 242
	internal sealed class Delegate168 : MulticastDelegate
	{
		// Token: 0x0600047F RID: 1151
		public extern Delegate168(object object_0, IntPtr intptr_0);

		// Token: 0x06000480 RID: 1152 RVA: 0x00003F06 File Offset: 0x00002106
		static Delegate168()
		{
			Class24.smethod_0(33554692, 167772317, 16777215);
		}

		// Token: 0x06000481 RID: 1153
		public extern FileStream Invoke(string string_0);

		// Token: 0x06000482 RID: 1154 RVA: 0x00003F1C File Offset: 0x0000211C
		public static FileStream smethod_0(string string_0)
		{
			return Delegate168.delegate168_0(string_0);
		}

		// Token: 0x0400027C RID: 636
		internal static readonly Delegate168 delegate168_0;
	}
}
