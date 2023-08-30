using System;
using System.Diagnostics;

namespace ns0
{
	// Token: 0x020000AD RID: 173
	internal sealed class Delegate102 : MulticastDelegate
	{
		// Token: 0x06000374 RID: 884
		public extern Delegate102(object object_0, IntPtr intptr_0);

		// Token: 0x06000375 RID: 885 RVA: 0x000035FF File Offset: 0x000017FF
		static Delegate102()
		{
			Class24.smethod_0(33554614, 167772254, 16777215);
		}

		// Token: 0x06000376 RID: 886
		public extern ProcessThreadCollection Invoke(object object_0);

		// Token: 0x06000377 RID: 887 RVA: 0x00003615 File Offset: 0x00001815
		public static ProcessThreadCollection smethod_0(object object_0)
		{
			return Delegate102.delegate102_0(object_0);
		}

		// Token: 0x04000237 RID: 567
		protected internal static readonly Delegate102 delegate102_0;
	}
}
