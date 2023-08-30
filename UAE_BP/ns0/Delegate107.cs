using System;

namespace ns0
{
	// Token: 0x020000B4 RID: 180
	internal sealed class Delegate107 : MulticastDelegate
	{
		// Token: 0x0600038A RID: 906
		public extern Delegate107(object object_0, IntPtr intptr_0);

		// Token: 0x0600038B RID: 907 RVA: 0x000036AE File Offset: 0x000018AE
		static Delegate107()
		{
			Class24.smethod_0(33554621, 167772259, 16777215);
		}

		// Token: 0x0600038C RID: 908
		public extern ulong Invoke(byte[] byte_0, int int_0);

		// Token: 0x0600038D RID: 909 RVA: 0x000036C4 File Offset: 0x000018C4
		public static ulong smethod_0(byte[] byte_0, int int_0)
		{
			return Delegate107.delegate107_0(byte_0, int_0);
		}

		// Token: 0x0400023E RID: 574
		internal static readonly Delegate107 delegate107_0;
	}
}
