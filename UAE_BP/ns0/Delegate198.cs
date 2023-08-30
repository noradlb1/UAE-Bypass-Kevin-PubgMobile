using System;
using System.Diagnostics;

namespace ns0
{
	// Token: 0x02000112 RID: 274
	internal sealed class Delegate198 : MulticastDelegate
	{
		// Token: 0x060004F9 RID: 1273
		public extern Delegate198(object object_0, IntPtr intptr_0);

		// Token: 0x060004FA RID: 1274 RVA: 0x0000432D File Offset: 0x0000252D
		static Delegate198()
		{
			Class24.smethod_0(33554730, 167772343, 16777215);
		}

		// Token: 0x060004FB RID: 1275
		public extern void Invoke(object object_0, ProcessStartInfo processStartInfo_0);

		// Token: 0x060004FC RID: 1276 RVA: 0x00004343 File Offset: 0x00002543
		public static void smethod_0(object object_0, ProcessStartInfo processStartInfo_0)
		{
			Delegate198.delegate198_0(object_0, processStartInfo_0);
		}

		// Token: 0x0400029C RID: 668
		protected internal static readonly Delegate198 delegate198_0;
	}
}
