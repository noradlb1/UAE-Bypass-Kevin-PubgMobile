using System;
using System.Text;

namespace ns0
{
	// Token: 0x020000D9 RID: 217
	internal sealed class Delegate144 : MulticastDelegate
	{
		// Token: 0x0600041E RID: 1054
		public extern Delegate144(object object_0, IntPtr intptr_0);

		// Token: 0x0600041F RID: 1055 RVA: 0x00003BC4 File Offset: 0x00001DC4
		static Delegate144()
		{
			Class24.smethod_0(33554664, 167772294, 16777215);
		}

		// Token: 0x06000420 RID: 1056
		public extern StringBuilder Invoke(object object_0, char char_0);

		// Token: 0x06000421 RID: 1057 RVA: 0x00003BDA File Offset: 0x00001DDA
		public static StringBuilder smethod_0(object object_0, char char_0)
		{
			return Delegate144.delegate144_0(object_0, char_0);
		}

		// Token: 0x04000263 RID: 611
		protected internal static readonly Delegate144 delegate144_0;
	}
}
