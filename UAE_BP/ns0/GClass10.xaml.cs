using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Windows;

namespace ns0
{
	// Token: 0x02000034 RID: 52
	public sealed partial class GClass10 : Application
	{
		// Token: 0x06000178 RID: 376 RVA: 0x0000E188 File Offset: 0x0000C388
		private void Application_Startup(object sender, StartupEventArgs e)
		{
			string name = Assembly.GetExecutingAssembly().GetName().Name;
			Process[] processesByName = Process.GetProcessesByName(name);
			if (processesByName.Length > 1)
			{
				Application.Current.Shutdown();
			}
		}

		// Token: 0x06000179 RID: 377 RVA: 0x0000E1C0 File Offset: 0x0000C3C0
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_0()
		{
			if (!this.bool_0)
			{
				this.bool_0 = true;
				base.Startup += this.Application_Startup;
				base.StartupUri = new Uri("MainWindow.xaml", UriKind.Relative);
				Uri resourceLocator = new Uri("/UAE_BP;component/app.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		// Token: 0x0400014D RID: 333
		private bool bool_0;
	}
}
