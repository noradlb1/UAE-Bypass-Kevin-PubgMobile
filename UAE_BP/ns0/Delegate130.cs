using System;
using System.Diagnostics;

namespace ns0
{
	// Token: 0x020000CB RID: 203
	internal sealed class Delegate130 : MulticastDelegate
	{
		// Token: 0x060003E6 RID: 998
		public extern Delegate130(object object_0, IntPtr intptr_0);

		// Token: 0x060003E7 RID: 999 RVA: 0x000039D5 File Offset: 0x00001BD5
		static Delegate130()
		{
			Class24.smethod_0(33554648, 167772280, 16777215);
		}

		// Token: 0x060003E8 RID: 1000
		public extern ProcessModule Invoke(object object_0);

		// Token: 0x060003E9 RID: 1001 RVA: 0x000039EB File Offset: 0x00001BEB
		public static ProcessModule smethod_0(object object_0)
		{
			return Delegate130.delegate130_0(object_0);
		}

		// Token: 0x04000255 RID: 597
		protected internal static readonly Delegate130 delegate130_0;
	}
}
