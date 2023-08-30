using System;
using System.Diagnostics;

namespace ns0
{
	// Token: 0x020000E9 RID: 233
	internal sealed class Delegate159 : MulticastDelegate
	{
		// Token: 0x0600045B RID: 1115
		public extern Delegate159(object object_0, IntPtr intptr_0);

		// Token: 0x0600045C RID: 1116 RVA: 0x00003DD5 File Offset: 0x00001FD5
		static Delegate159()
		{
			Class24.smethod_0(33554682, 167772309, 16777215);
		}

		// Token: 0x0600045D RID: 1117
		public extern Process Invoke(string string_0);

		// Token: 0x0600045E RID: 1118 RVA: 0x00003DEB File Offset: 0x00001FEB
		public static Process smethod_0(string string_0)
		{
			return Delegate159.delegate159_0(string_0);
		}

		// Token: 0x04000273 RID: 627
		internal static readonly Delegate159 delegate159_0;
	}
}
