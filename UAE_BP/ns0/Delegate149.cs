using System;

namespace ns0
{
	// Token: 0x020000DF RID: 223
	internal sealed class Delegate149 : MulticastDelegate
	{
		// Token: 0x06000433 RID: 1075
		public extern Delegate149(object object_0, IntPtr intptr_0);

		// Token: 0x06000434 RID: 1076 RVA: 0x00003C73 File Offset: 0x00001E73
		static Delegate149()
		{
			Class24.smethod_0(33554672, 167772299, 16777215);
		}

		// Token: 0x06000435 RID: 1077
		public extern string Invoke(object object_0, byte[] byte_0);

		// Token: 0x06000436 RID: 1078 RVA: 0x00003C89 File Offset: 0x00001E89
		public static string smethod_0(object object_0, byte[] byte_0)
		{
			return Delegate149.delegate149_0(object_0, byte_0);
		}

		// Token: 0x04000269 RID: 617
		protected internal static readonly Delegate149 delegate149_0;
	}
}
