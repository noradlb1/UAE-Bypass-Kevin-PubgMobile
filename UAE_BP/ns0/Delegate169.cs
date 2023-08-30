using System;
using System.Globalization;

namespace ns0
{
	// Token: 0x020000F4 RID: 244
	internal sealed class Delegate169 : MulticastDelegate
	{
		// Token: 0x06000484 RID: 1156
		public extern Delegate169(object object_0, IntPtr intptr_0);

		// Token: 0x06000485 RID: 1157 RVA: 0x00003F29 File Offset: 0x00002129
		static Delegate169()
		{
			Class24.smethod_0(33554694, 167772318, 16777215);
		}

		// Token: 0x06000486 RID: 1158
		public extern long Invoke(string string_0, NumberStyles numberStyles_0);

		// Token: 0x06000487 RID: 1159 RVA: 0x00003F3F File Offset: 0x0000213F
		public static long smethod_0(string string_0, NumberStyles numberStyles_0)
		{
			return Delegate169.delegate169_0(string_0, numberStyles_0);
		}

		// Token: 0x0400027E RID: 638
		internal static readonly Delegate169 delegate169_0;
	}
}
