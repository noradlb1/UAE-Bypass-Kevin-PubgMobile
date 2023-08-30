using System;

namespace ns0
{
	// Token: 0x020000AA RID: 170
	internal sealed class Delegate99 : MulticastDelegate
	{
		// Token: 0x06000368 RID: 872
		public extern Delegate99(object object_0, IntPtr intptr_0);

		// Token: 0x06000369 RID: 873 RVA: 0x00003596 File Offset: 0x00001796
		static Delegate99()
		{
			Class24.smethod_0(33554611, 167772251, 16777215);
		}

		// Token: 0x0600036A RID: 874
		public extern bool Invoke(IntPtr intptr_0, IntPtr intptr_1);

		// Token: 0x0600036B RID: 875 RVA: 0x000035AC File Offset: 0x000017AC
		public static bool smethod_0(IntPtr intptr_0, IntPtr intptr_1)
		{
			return Delegate99.delegate99_0(intptr_0, intptr_1);
		}

		// Token: 0x04000234 RID: 564
		internal static readonly Delegate99 delegate99_0;
	}
}
