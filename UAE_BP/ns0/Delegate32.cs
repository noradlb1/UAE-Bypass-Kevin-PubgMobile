using System;
using System.Windows.Media;

namespace ns0
{
	// Token: 0x02000064 RID: 100
	internal sealed class Delegate32 : MulticastDelegate
	{
		// Token: 0x06000259 RID: 601
		public extern Delegate32(object object_0, IntPtr intptr_0);

		// Token: 0x0600025A RID: 602 RVA: 0x00002C51 File Offset: 0x00000E51
		static Delegate32()
		{
			Class24.smethod_0(33554533, 167772193, 16777215);
		}

		// Token: 0x0600025B RID: 603
		public extern Color Invoke();

		// Token: 0x0600025C RID: 604 RVA: 0x00002C67 File Offset: 0x00000E67
		public static Color smethod_0()
		{
			return Delegate32.delegate32_0();
		}

		// Token: 0x040001EE RID: 494
		internal static readonly Delegate32 delegate32_0;
	}
}
