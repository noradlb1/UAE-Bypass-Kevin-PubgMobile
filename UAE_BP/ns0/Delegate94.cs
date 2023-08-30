using System;

namespace ns0
{
	// Token: 0x020000A5 RID: 165
	internal sealed class Delegate94 : MulticastDelegate
	{
		// Token: 0x06000354 RID: 852
		public extern Delegate94(object object_0, IntPtr intptr_0);

		// Token: 0x06000355 RID: 853 RVA: 0x000034E3 File Offset: 0x000016E3
		static Delegate94()
		{
			Class24.smethod_0(33554605, 167772247, 16777215);
		}

		// Token: 0x06000356 RID: 854
		public extern void Invoke(object object_0, string string_0, string string_1);

		// Token: 0x06000357 RID: 855 RVA: 0x000034F9 File Offset: 0x000016F9
		public static void smethod_0(object object_0, string string_0, string string_1)
		{
			Delegate94.delegate94_0(object_0, string_0, string_1);
		}

		// Token: 0x0400022F RID: 559
		protected internal static readonly Delegate94 delegate94_0;
	}
}
