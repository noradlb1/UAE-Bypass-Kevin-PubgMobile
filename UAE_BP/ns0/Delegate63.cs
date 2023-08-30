using System;

namespace ns0
{
	// Token: 0x02000085 RID: 133
	internal sealed class Delegate63 : MulticastDelegate
	{
		// Token: 0x060002D7 RID: 727
		public extern Delegate63(object object_0, IntPtr intptr_0);

		// Token: 0x060002D8 RID: 728 RVA: 0x0000309D File Offset: 0x0000129D
		static Delegate63()
		{
			Class24.smethod_0(33554568, 167772219, 16777215);
		}

		// Token: 0x060002D9 RID: 729
		public extern int Invoke(object object_0, byte[] byte_0, int int_0, int int_1);

		// Token: 0x060002DA RID: 730 RVA: 0x000030B3 File Offset: 0x000012B3
		public static int smethod_0(object object_0, byte[] byte_0, int int_0, int int_1)
		{
			return Delegate63.delegate63_0(object_0, byte_0, int_0, int_1);
		}

		// Token: 0x0400020F RID: 527
		protected internal static readonly Delegate63 delegate63_0;
	}
}
