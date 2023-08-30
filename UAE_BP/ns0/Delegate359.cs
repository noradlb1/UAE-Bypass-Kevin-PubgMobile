using System;

namespace ns0
{
	// Token: 0x020001BB RID: 443
	internal sealed class Delegate359 : MulticastDelegate
	{
		// Token: 0x06000785 RID: 1925
		public extern Delegate359(object object_0, IntPtr intptr_0);

		// Token: 0x06000786 RID: 1926 RVA: 0x00005969 File Offset: 0x00003B69
		static Delegate359()
		{
			Class24.smethod_0(33554926, 167772479, 16777215);
		}

		// Token: 0x06000787 RID: 1927
		public extern uint Invoke(string string_0, int int_0);

		// Token: 0x06000788 RID: 1928 RVA: 0x0000597F File Offset: 0x00003B7F
		public static uint smethod_0(string string_0, int int_0)
		{
			return Delegate359.delegate359_0(string_0, int_0);
		}

		// Token: 0x04000345 RID: 837
		internal static readonly Delegate359 delegate359_0;
	}
}
