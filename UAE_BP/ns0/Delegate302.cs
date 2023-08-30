using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace ns0
{
	// Token: 0x0200017C RID: 380
	internal sealed class Delegate302 : MulticastDelegate
	{
		// Token: 0x0600069B RID: 1691
		public extern Delegate302(object object_0, IntPtr intptr_0);

		// Token: 0x0600069C RID: 1692 RVA: 0x0000518E File Offset: 0x0000338E
		static Delegate302()
		{
			Class24.smethod_0(33554848, 167772427, 452984837);
		}

		// Token: 0x0600069D RID: 1693
		public extern Task<long> Invoke(ref AsyncTaskMethodBuilder<long> asyncTaskMethodBuilder_0);

		// Token: 0x0600069E RID: 1694 RVA: 0x000051A4 File Offset: 0x000033A4
		public static Task<long> smethod_0(ref AsyncTaskMethodBuilder<long> asyncTaskMethodBuilder_0)
		{
			return Delegate302.delegate302_0(ref asyncTaskMethodBuilder_0);
		}

		// Token: 0x04000306 RID: 774
		internal static readonly Delegate302 delegate302_0;
	}
}
