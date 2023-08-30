using System;
using System.Collections;

namespace ns0
{
	// Token: 0x02000107 RID: 263
	internal sealed class Delegate188 : MulticastDelegate
	{
		// Token: 0x060004D0 RID: 1232
		public extern Delegate188(object object_0, IntPtr intptr_0);

		// Token: 0x060004D1 RID: 1233 RVA: 0x000041CD File Offset: 0x000023CD
		static Delegate188()
		{
			Class24.smethod_0(33554715, 167772335, 16777215);
		}

		// Token: 0x060004D2 RID: 1234
		public extern IEnumerator Invoke(object object_0);

		// Token: 0x060004D3 RID: 1235 RVA: 0x000041E3 File Offset: 0x000023E3
		public static IEnumerator smethod_0(object object_0)
		{
			return Delegate188.delegate188_0(object_0);
		}

		// Token: 0x04000291 RID: 657
		protected internal static readonly Delegate188 delegate188_0;
	}
}
