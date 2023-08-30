using System;
using System.Configuration;

namespace ns0
{
	// Token: 0x0200005F RID: 95
	internal sealed class Delegate27 : MulticastDelegate
	{
		// Token: 0x06000245 RID: 581
		public extern Delegate27(object object_0, IntPtr intptr_0);

		// Token: 0x06000246 RID: 582 RVA: 0x00002B9F File Offset: 0x00000D9F
		static Delegate27()
		{
			Class24.smethod_0(33554528, 167772189, 16777215);
		}

		// Token: 0x06000247 RID: 583
		public extern SettingsBase Invoke(SettingsBase settingsBase_0);

		// Token: 0x06000248 RID: 584 RVA: 0x00002BB5 File Offset: 0x00000DB5
		public static SettingsBase smethod_0(SettingsBase settingsBase_0)
		{
			return Delegate27.delegate27_0(settingsBase_0);
		}

		// Token: 0x040001E9 RID: 489
		internal static readonly Delegate27 delegate27_0;
	}
}
