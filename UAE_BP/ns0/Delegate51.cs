using System;

namespace ns0
{
	// Token: 0x02000077 RID: 119
	internal sealed class Delegate51 : MulticastDelegate
	{
		// Token: 0x060002A5 RID: 677
		public extern Delegate51(object object_0, IntPtr intptr_0);

		// Token: 0x060002A6 RID: 678 RVA: 0x00002EF1 File Offset: 0x000010F1
		static Delegate51()
		{
			Class24.smethod_0(33554553, 167772209, 16777215);
		}

		// Token: 0x060002A7 RID: 679
		public extern int Invoke(object object_0, char char_0);

		// Token: 0x060002A8 RID: 680 RVA: 0x00002F07 File Offset: 0x00001107
		public static int smethod_0(object object_0, char char_0)
		{
			return Delegate51.delegate51_0(object_0, char_0);
		}

		// Token: 0x04000201 RID: 513
		protected internal static readonly Delegate51 delegate51_0;
	}
}
