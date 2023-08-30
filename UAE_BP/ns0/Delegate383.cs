using System;
using System.Windows.Media;

namespace ns0
{
	// Token: 0x020001D3 RID: 467
	internal sealed class Delegate383 : MulticastDelegate
	{
		// Token: 0x060007E5 RID: 2021
		public extern Delegate383(object object_0, IntPtr intptr_0);

		// Token: 0x060007E6 RID: 2022 RVA: 0x00005CBA File Offset: 0x00003EBA
		static Delegate383()
		{
			Class24.smethod_0(33554953, 167772498, 16777215);
		}

		// Token: 0x060007E7 RID: 2023
		public extern void Invoke(object object_0, Brush brush_0);

		// Token: 0x060007E8 RID: 2024 RVA: 0x00005CD0 File Offset: 0x00003ED0
		public static void smethod_0(object object_0, Brush brush_0)
		{
			Delegate383.delegate383_0(object_0, brush_0);
		}

		// Token: 0x0400035D RID: 861
		protected internal static readonly Delegate383 delegate383_0;
	}
}
