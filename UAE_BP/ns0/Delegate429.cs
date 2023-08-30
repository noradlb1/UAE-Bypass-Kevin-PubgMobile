using System;
using System.Runtime.CompilerServices;

namespace ns0
{
	// Token: 0x02000203 RID: 515
	internal sealed class Delegate429 : MulticastDelegate
	{
		// Token: 0x0600089F RID: 2207
		public extern Delegate429(object object_0, IntPtr intptr_0);

		// Token: 0x060008A0 RID: 2208 RVA: 0x00006314 File Offset: 0x00004514
		static Delegate429()
		{
			Class24.smethod_0(33555008, 167772535, 16777215);
		}

		// Token: 0x060008A1 RID: 2209
		public extern void Invoke(ref AsyncTaskMethodBuilder asyncTaskMethodBuilder_0);

		// Token: 0x060008A2 RID: 2210 RVA: 0x0000632A File Offset: 0x0000452A
		public static void smethod_0(ref AsyncTaskMethodBuilder asyncTaskMethodBuilder_0)
		{
			Delegate429.delegate429_0(ref asyncTaskMethodBuilder_0);
		}

		// Token: 0x0400038D RID: 909
		internal static readonly Delegate429 delegate429_0;
	}
}
