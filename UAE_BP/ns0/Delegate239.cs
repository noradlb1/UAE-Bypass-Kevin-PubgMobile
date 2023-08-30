using System;
using System.Threading.Tasks;

namespace ns0
{
	// Token: 0x0200013C RID: 316
	internal sealed class Delegate239 : MulticastDelegate
	{
		// Token: 0x0600059E RID: 1438
		public extern Delegate239(object object_0, IntPtr intptr_0);

		// Token: 0x0600059F RID: 1439 RVA: 0x000048DE File Offset: 0x00002ADE
		static Delegate239()
		{
			Class24.smethod_0(33554776, 167772379, 16777215);
		}

		// Token: 0x060005A0 RID: 1440
		public extern Task Invoke(Func<Task> func_0);

		// Token: 0x060005A1 RID: 1441 RVA: 0x000048F4 File Offset: 0x00002AF4
		public static Task smethod_0(Func<Task> func_0)
		{
			return Delegate239.delegate239_0(func_0);
		}

		// Token: 0x040002C6 RID: 710
		internal static readonly Delegate239 delegate239_0;
	}
}
