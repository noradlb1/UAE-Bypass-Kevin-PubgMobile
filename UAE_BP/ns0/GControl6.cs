using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x02000031 RID: 49
	public sealed class GControl6 : UserControl, IComponentConnector
	{
		// Token: 0x06000169 RID: 361 RVA: 0x00002654 File Offset: 0x00000854
		public GControl6()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00002662 File Offset: 0x00000862
		private void Button_Click(object sender, RoutedEventArgs e)
		{
			Task.Run(new Action(GControl6.<>c.<>c_0.method_0));
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00002689 File Offset: 0x00000889
		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			Task.Run(new Action(GControl6.<>c.<>c_0.method_1));
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00002050 File Offset: 0x00000250
		private void Button_Click_2(object sender, RoutedEventArgs e)
		{
		}

		// Token: 0x0600016D RID: 365 RVA: 0x000026B0 File Offset: 0x000008B0
		private void Hyperlink_Click(object sender, RoutedEventArgs e)
		{
			Process.Start("http://gameloop.com");
		}

		// Token: 0x0600016E RID: 366 RVA: 0x0000DFB0 File Offset: 0x0000C1B0
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void InitializeComponent()
		{
			if (!this.bool_0)
			{
				this.bool_0 = true;
				Uri resourceLocator = new Uri("/UAE_BP;component/usertools.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		// Token: 0x0600016F RID: 367 RVA: 0x0000DFE0 File Offset: 0x0000C1E0
		[EditorBrowsable(EditorBrowsableState.Never)]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[DebuggerNonUserCode]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				((Button)target).Click += this.Button_Click_1;
				break;
			case 2:
				((Button)target).Click += this.Button_Click;
				break;
			case 3:
				((Button)target).Click += this.Button_Click_2;
				break;
			case 4:
				((Hyperlink)target).Click += this.Hyperlink_Click;
				break;
			default:
				this.bool_0 = true;
				break;
			}
		}

		// Token: 0x04000147 RID: 327
		private bool bool_0;
	}
}
