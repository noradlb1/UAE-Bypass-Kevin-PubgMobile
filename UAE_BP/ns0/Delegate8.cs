using System;

namespace ns0
{
	// Token: 0x0200004C RID: 76
	internal sealed class Delegate8 : MulticastDelegate
	{
		// Token: 0x060001F9 RID: 505
		public extern Delegate8(object object_0, IntPtr intptr_0);

		// Token: 0x060001FA RID: 506 RVA: 0x00002900 File Offset: 0x00000B00
		static Delegate8()
		{
			Class24.smethod_0(33554508, 100663626, 16777215);
		}

		// Token: 0x060001FB RID: 507
		public extern string Invoke(object object_0);

		// Token: 0x060001FC RID: 508 RVA: 0x00002916 File Offset: 0x00000B16
		public static string smethod_0(object object_0)
		{
			return Delegate8.delegate8_0(object_0);
		}

		// Token: 0x040001D6 RID: 470
		protected internal static readonly Delegate8 delegate8_0;
	}
}
