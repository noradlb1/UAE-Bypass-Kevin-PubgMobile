using System;

namespace ns0
{
	// Token: 0x020000B5 RID: 181
	internal sealed class Delegate108 : MulticastDelegate
	{
		// Token: 0x0600038E RID: 910
		public extern Delegate108(object object_0, IntPtr intptr_0);

		// Token: 0x0600038F RID: 911 RVA: 0x000036D2 File Offset: 0x000018D2
		static Delegate108()
		{
			Class24.smethod_0(33554623, 167772260, 452984836);
		}

		// Token: 0x06000390 RID: 912
		public extern bool Invoke(object object_0, string string_0);

		// Token: 0x06000391 RID: 913 RVA: 0x000036E8 File Offset: 0x000018E8
		public static bool smethod_0(object object_0, string string_0)
		{
			return Delegate108.delegate108_0(object_0, string_0);
		}

		// Token: 0x0400023F RID: 575
		protected internal static readonly Delegate108 delegate108_0;
	}
}
