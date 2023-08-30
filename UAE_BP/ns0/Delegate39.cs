using System;
using System.Windows.Media;

namespace ns0
{
	// Token: 0x0200006B RID: 107
	internal sealed class Delegate39 : MulticastDelegate
	{
		// Token: 0x06000275 RID: 629
		public extern Delegate39(object object_0, IntPtr intptr_0);

		// Token: 0x06000276 RID: 630 RVA: 0x00002D47 File Offset: 0x00000F47
		static Delegate39()
		{
			Class24.smethod_0(33554540, 167772199, 16777215);
		}

		// Token: 0x06000277 RID: 631
		public extern void Invoke(object object_0, Brush brush_0);

		// Token: 0x06000278 RID: 632 RVA: 0x00002D5D File Offset: 0x00000F5D
		public static void smethod_0(object object_0, Brush brush_0)
		{
			Delegate39.delegate39_0(object_0, brush_0);
		}

		// Token: 0x040001F5 RID: 501
		protected internal static readonly Delegate39 delegate39_0;
	}
}
