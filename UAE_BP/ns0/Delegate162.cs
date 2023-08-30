using System;

namespace ns0
{
	// Token: 0x020000EC RID: 236
	internal sealed class Delegate162 : MulticastDelegate
	{
		// Token: 0x06000467 RID: 1127
		public extern Delegate162(object object_0, IntPtr intptr_0);

		// Token: 0x06000468 RID: 1128 RVA: 0x00003E41 File Offset: 0x00002041
		static Delegate162()
		{
			Class24.smethod_0(33554685, 167772312, 16777215);
		}

		// Token: 0x06000469 RID: 1129
		public extern long Invoke(object object_0);

		// Token: 0x0600046A RID: 1130 RVA: 0x00003E57 File Offset: 0x00002057
		public static long smethod_0(object object_0)
		{
			return Delegate162.delegate162_0(object_0);
		}

		// Token: 0x04000276 RID: 630
		protected internal static readonly Delegate162 delegate162_0;
	}
}
