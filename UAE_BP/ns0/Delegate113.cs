using System;
using System.Runtime.CompilerServices;

namespace ns0
{
	// Token: 0x020000BA RID: 186
	internal sealed class Delegate113 : MulticastDelegate
	{
		// Token: 0x060003A2 RID: 930
		public extern Delegate113(object object_0, IntPtr intptr_0);

		// Token: 0x060003A3 RID: 931 RVA: 0x00003783 File Offset: 0x00001983
		static Delegate113()
		{
			Class24.smethod_0(33554629, 167772265, 452984842);
		}

		// Token: 0x060003A4 RID: 932
		public extern AsyncTaskMethodBuilder<bool> Invoke();

		// Token: 0x060003A5 RID: 933 RVA: 0x00003799 File Offset: 0x00001999
		public static AsyncTaskMethodBuilder<bool> smethod_0()
		{
			return Delegate113.delegate113_0();
		}

		// Token: 0x04000244 RID: 580
		internal static readonly Delegate113 delegate113_0;
	}
}
