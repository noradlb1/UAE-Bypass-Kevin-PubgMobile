using System;

namespace ns0
{
	// Token: 0x0200016B RID: 363
	internal sealed class Delegate286 : MulticastDelegate
	{
		// Token: 0x0600065A RID: 1626
		public extern Delegate286(object object_0, IntPtr intptr_0);

		// Token: 0x0600065B RID: 1627 RVA: 0x00004F54 File Offset: 0x00003154
		static Delegate286()
		{
			Class24.smethod_0(33554825, 167772415, 16777215);
		}

		// Token: 0x0600065C RID: 1628
		public extern float Invoke(byte[] byte_0, int int_0);

		// Token: 0x0600065D RID: 1629 RVA: 0x00004F6A File Offset: 0x0000316A
		public static float smethod_0(byte[] byte_0, int int_0)
		{
			return Delegate286.delegate286_0(byte_0, int_0);
		}

		// Token: 0x040002F5 RID: 757
		internal static readonly Delegate286 delegate286_0;
	}
}
