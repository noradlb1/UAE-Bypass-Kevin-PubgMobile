using System;

namespace ns0
{
	// Token: 0x020000C1 RID: 193
	internal sealed class Delegate120 : MulticastDelegate
	{
		// Token: 0x060003BE RID: 958
		public extern Delegate120(object object_0, IntPtr intptr_0);

		// Token: 0x060003BF RID: 959 RVA: 0x00003876 File Offset: 0x00001A76
		static Delegate120()
		{
			Class24.smethod_0(33554637, 167772272, 16777215);
		}

		// Token: 0x060003C0 RID: 960
		public extern string Invoke(string string_0, object object_0);

		// Token: 0x060003C1 RID: 961 RVA: 0x0000388C File Offset: 0x00001A8C
		public static string smethod_0(string string_0, object object_0)
		{
			return Delegate120.delegate120_0(string_0, object_0);
		}

		// Token: 0x0400024B RID: 587
		internal static readonly Delegate120 delegate120_0;
	}
}
