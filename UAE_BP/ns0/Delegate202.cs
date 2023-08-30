using System;
using System.Windows.Media;

namespace ns0
{
	// Token: 0x02000116 RID: 278
	internal sealed class Delegate202 : MulticastDelegate
	{
		// Token: 0x06000509 RID: 1289
		public extern Delegate202(object object_0, IntPtr intptr_0);

		// Token: 0x0600050A RID: 1290 RVA: 0x000043B9 File Offset: 0x000025B9
		static Delegate202()
		{
			Class24.smethod_0(33554734, 167772346, 16777215);
		}

		// Token: 0x0600050B RID: 1291
		public extern void Invoke(object object_0, Brush brush_0);

		// Token: 0x0600050C RID: 1292 RVA: 0x000043CF File Offset: 0x000025CF
		public static void smethod_0(object object_0, Brush brush_0)
		{
			Delegate202.delegate202_0(object_0, brush_0);
		}

		// Token: 0x040002A0 RID: 672
		protected internal static readonly Delegate202 delegate202_0;
	}
}
