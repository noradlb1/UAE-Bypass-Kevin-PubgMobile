using System;
using System.Windows.Media;

namespace ns0
{
	// Token: 0x02000170 RID: 368
	internal sealed class Delegate291 : MulticastDelegate
	{
		// Token: 0x0600066E RID: 1646
		public extern Delegate291(object object_0, IntPtr intptr_0);

		// Token: 0x0600066F RID: 1647 RVA: 0x00005003 File Offset: 0x00003203
		static Delegate291()
		{
			Class25.smethod_0(33554830, 167772418, 16777215);
		}

		// Token: 0x06000670 RID: 1648
		public extern SolidColorBrush Invoke(Color color_0);

		// Token: 0x06000671 RID: 1649 RVA: 0x00005019 File Offset: 0x00003219
		public static SolidColorBrush smethod_0(Color color_0)
		{
			return Delegate291.delegate291_0(color_0);
		}

		// Token: 0x040002FA RID: 762
		internal static readonly Delegate291 delegate291_0;
	}
}
