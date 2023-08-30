using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace UAE_BP.Properties
{
	// Token: 0x0200003C RID: 60
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
	[CompilerGenerated]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060001AC RID: 428 RVA: 0x0000F238 File Offset: 0x0000D438
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x04000179 RID: 377
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
