using System;

namespace ns0
{
	// Token: 0x02000086 RID: 134
	internal sealed class Delegate64 : MulticastDelegate
	{
		// Token: 0x060002DB RID: 731
		public extern Delegate64(object object_0, IntPtr intptr_0);

		// Token: 0x060002DC RID: 732 RVA: 0x000030C3 File Offset: 0x000012C3
		static Delegate64()
		{
			Class24.smethod_0(33554569, 167772220, 16777215);
		}

		// Token: 0x060002DD RID: 733
		public extern ulong Invoke(long long_0);

		// Token: 0x060002DE RID: 734 RVA: 0x000030D9 File Offset: 0x000012D9
		public static ulong smethod_0(long long_0)
		{
			return Delegate64.delegate64_0(long_0);
		}

		// Token: 0x04000210 RID: 528
		internal static readonly Delegate64 delegate64_0;
	}
}
