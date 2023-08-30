using System;

namespace ns0
{
	// Token: 0x02000186 RID: 390
	internal sealed class Delegate311 : MulticastDelegate
	{
		// Token: 0x060006C0 RID: 1728
		public extern Delegate311(object object_0, IntPtr intptr_0);

		// Token: 0x060006C1 RID: 1729 RVA: 0x000052CC File Offset: 0x000034CC
		static Delegate311()
		{
			Class24.smethod_0(33554860, 167772435, 16777215);
		}

		// Token: 0x060006C2 RID: 1730
		public extern bool Invoke(object object_0, Type type_0, bool bool_0);

		// Token: 0x060006C3 RID: 1731 RVA: 0x000052E2 File Offset: 0x000034E2
		public static bool smethod_0(object object_0, Type type_0, bool bool_0)
		{
			return Delegate311.delegate311_0(object_0, type_0, bool_0);
		}

		// Token: 0x04000310 RID: 784
		protected internal static readonly Delegate311 delegate311_0;
	}
}
