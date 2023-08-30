using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace ns0
{
	// Token: 0x0200003A RID: 58
	[DebuggerNonUserCode]
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
	[CompilerGenerated]
	internal sealed class Class20
	{
		// Token: 0x06000199 RID: 409 RVA: 0x00002076 File Offset: 0x00000276
		internal Class20()
		{
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600019A RID: 410 RVA: 0x0000EC74 File Offset: 0x0000CE74
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (Class20.resourceManager_0 == Class38.resourceManager_0)
				{
					ResourceManager resourceManager = new ResourceManager("ns0.Class20", typeof(Class20).Assembly);
					Class20.resourceManager_0 = resourceManager;
				}
				return Class20.resourceManager_0;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600019B RID: 411 RVA: 0x0000ECB8 File Offset: 0x0000CEB8
		// (set) Token: 0x0600019C RID: 412 RVA: 0x000027E9 File Offset: 0x000009E9
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Class20.cultureInfo_0;
			}
			set
			{
				Class20.cultureInfo_0 = value;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600019D RID: 413 RVA: 0x0000ECCC File Offset: 0x0000CECC
		internal static byte[] adb_exe
		{
			get
			{
				object @object = Class20.ResourceManager.GetObject("adb_exe", Class20.cultureInfo_0);
				return (byte[])@object;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600019E RID: 414 RVA: 0x0000ECF8 File Offset: 0x0000CEF8
		internal static byte[] AdbWinApi
		{
			get
			{
				object @object = Class20.ResourceManager.GetObject("AdbWinApi", Class20.cultureInfo_0);
				return (byte[])@object;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600019F RID: 415 RVA: 0x0000ED24 File Offset: 0x0000CF24
		internal static byte[] bp
		{
			get
			{
				object @object = Class20.ResourceManager.GetObject("bp", Class20.cultureInfo_0);
				return (byte[])@object;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060001A0 RID: 416 RVA: 0x0000ED50 File Offset: 0x0000CF50
		internal static byte[] param
		{
			get
			{
				object @object = Class20.ResourceManager.GetObject("param", Class20.cultureInfo_0);
				return (byte[])@object;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060001A1 RID: 417 RVA: 0x0000ED7C File Offset: 0x0000CF7C
		internal static byte[] param2
		{
			get
			{
				object @object = Class20.ResourceManager.GetObject("param2", Class20.cultureInfo_0);
				return (byte[])@object;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060001A2 RID: 418 RVA: 0x0000EDA8 File Offset: 0x0000CFA8
		internal static byte[] WpfAnimatedGif
		{
			get
			{
				object @object = Class20.ResourceManager.GetObject("WpfAnimatedGif", Class20.cultureInfo_0);
				return (byte[])@object;
			}
		}

		// Token: 0x04000171 RID: 369
		private static ResourceManager resourceManager_0;

		// Token: 0x04000172 RID: 370
		private static CultureInfo cultureInfo_0;
	}
}
