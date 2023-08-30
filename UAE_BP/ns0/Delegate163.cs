using System;

namespace ns0
{
	// Token: 0x020000ED RID: 237
	internal sealed class Delegate163 : MulticastDelegate
	{
		// Token: 0x0600046B RID: 1131
		public extern Delegate163(object object_0, IntPtr intptr_0);

		// Token: 0x0600046C RID: 1132 RVA: 0x00003E64 File Offset: 0x00002064
		static Delegate163()
		{
			Class26.smethod_0(33554687, 167772313, 16777215);
		}

		// Token: 0x0600046D RID: 1133
		public extern void Invoke(ref DateTime dateTime_0, int int_0, int int_1, int int_2, int int_3, int int_4, int int_5, int int_6, DateTimeKind dateTimeKind_0);

		// Token: 0x0600046E RID: 1134 RVA: 0x00010388 File Offset: 0x0000E588
		public static void smethod_0(ref DateTime dateTime_0, int int_0, int int_1, int int_2, int int_3, int int_4, int int_5, int int_6, DateTimeKind dateTimeKind_0)
		{
			Delegate163.delegate163_0(ref dateTime_0, int_0, int_1, int_2, int_3, int_4, int_5, int_6, dateTimeKind_0);
		}

		// Token: 0x04000277 RID: 631
		internal static readonly Delegate163 delegate163_0;
	}
}
