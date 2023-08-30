using System;

namespace ns0
{
	// Token: 0x02000105 RID: 261
	internal sealed class Delegate186 : MulticastDelegate
	{
		// Token: 0x060004C8 RID: 1224
		public extern Delegate186(object object_0, IntPtr intptr_0);

		// Token: 0x060004C9 RID: 1225 RVA: 0x00004186 File Offset: 0x00002386
		static Delegate186()
		{
			Class25.smethod_0(33554713, 167772333, 16777215);
		}

		// Token: 0x060004CA RID: 1226
		public extern Uri Invoke(string string_0, UriKind uriKind_0);

		// Token: 0x060004CB RID: 1227 RVA: 0x0000419C File Offset: 0x0000239C
		public static Uri smethod_0(string string_0, UriKind uriKind_0)
		{
			return Delegate186.delegate186_0(string_0, uriKind_0);
		}

		// Token: 0x0400028F RID: 655
		internal static readonly Delegate186 delegate186_0;
	}
}
