using System;

namespace ns0
{
	// Token: 0x020001DA RID: 474
	internal sealed class Delegate390 : MulticastDelegate
	{
		// Token: 0x06000801 RID: 2049
		public extern Delegate390(object object_0, IntPtr intptr_0);

		// Token: 0x06000802 RID: 2050 RVA: 0x00005DB0 File Offset: 0x00003FB0
		static Delegate390()
		{
			Class24.smethod_0(33554963, 100663664, 16777215);
		}

		// Token: 0x06000803 RID: 2051
		public extern void Invoke(object object_0, string value);

		// Token: 0x06000804 RID: 2052 RVA: 0x00005DC6 File Offset: 0x00003FC6
		public static void smethod_0(object object_0, string string_0)
		{
			Delegate390.delegate390_0(object_0, string_0);
		}

		// Token: 0x04000364 RID: 868
		protected internal static readonly Delegate390 delegate390_0;
	}
}
