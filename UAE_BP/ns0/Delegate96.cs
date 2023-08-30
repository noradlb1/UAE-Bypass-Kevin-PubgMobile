using System;

namespace ns0
{
	// Token: 0x020000A7 RID: 167
	internal sealed class Delegate96 : MulticastDelegate
	{
		// Token: 0x0600035C RID: 860
		public extern Delegate96(object object_0, IntPtr intptr_0);

		// Token: 0x0600035D RID: 861 RVA: 0x0000352D File Offset: 0x0000172D
		static Delegate96()
		{
			Class24.smethod_0(33554608, 167772249, 16777215);
		}

		// Token: 0x0600035E RID: 862
		public extern object Invoke(object object_0);

		// Token: 0x0600035F RID: 863 RVA: 0x00003543 File Offset: 0x00001743
		public static object smethod_0(object object_0)
		{
			return Delegate96.delegate96_0(object_0);
		}

		// Token: 0x04000231 RID: 561
		protected internal static readonly Delegate96 delegate96_0;
	}
}
