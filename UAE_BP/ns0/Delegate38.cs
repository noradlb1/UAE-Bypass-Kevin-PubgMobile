using System;
using System.Diagnostics;

namespace ns0
{
	// Token: 0x0200006A RID: 106
	internal sealed class Delegate38 : MulticastDelegate
	{
		// Token: 0x06000271 RID: 625
		public extern Delegate38(object object_0, IntPtr intptr_0);

		// Token: 0x06000272 RID: 626 RVA: 0x00002D24 File Offset: 0x00000F24
		static Delegate38()
		{
			Class24.smethod_0(33554539, 167772198, 16777215);
		}

		// Token: 0x06000273 RID: 627
		public extern ProcessModuleCollection Invoke(object object_0);

		// Token: 0x06000274 RID: 628 RVA: 0x00002D3A File Offset: 0x00000F3A
		public static ProcessModuleCollection smethod_0(object object_0)
		{
			return Delegate38.delegate38_0(object_0);
		}

		// Token: 0x040001F4 RID: 500
		protected internal static readonly Delegate38 delegate38_0;
	}
}
