using System;
using System.Collections.Generic;

namespace ns0
{
	// Token: 0x020000A2 RID: 162
	internal sealed class Delegate91 : MulticastDelegate
	{
		// Token: 0x06000348 RID: 840
		public extern Delegate91(object object_0, IntPtr intptr_0);

		// Token: 0x06000349 RID: 841 RVA: 0x00003479 File Offset: 0x00001679
		static Delegate91()
		{
			Class24.smethod_0(33554602, 167772245, 452984840);
		}

		// Token: 0x0600034A RID: 842
		public extern string Invoke(ref List<string>.Enumerator enumerator_0);

		// Token: 0x0600034B RID: 843 RVA: 0x0000348F File Offset: 0x0000168F
		public static string smethod_0(ref List<string>.Enumerator enumerator_0)
		{
			return Delegate91.delegate91_0(ref enumerator_0);
		}

		// Token: 0x0400022C RID: 556
		internal static readonly Delegate91 delegate91_0;
	}
}
