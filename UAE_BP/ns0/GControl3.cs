using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x0200002A RID: 42
	public sealed class GControl3 : UserControl, IComponentConnector
	{
		// Token: 0x0600014B RID: 331 RVA: 0x000025D5 File Offset: 0x000007D5
		public GControl3()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600014C RID: 332 RVA: 0x0000D9E4 File Offset: 0x0000BBE4
		private void Button_Click(object sender, RoutedEventArgs e)
		{
			if (this.button_0.Content == "Login")
			{
				GClass8.key = this.textBox_0.Text;
			}
			else
			{
				GClass11 gclass = Application.Current.MainWindow as GClass11;
				if (gclass != Class31.gclass11_0)
				{
					gclass.method_3();
				}
			}
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00002050 File Offset: 0x00000250
		private void Hyperlink_Click(object sender, RoutedEventArgs e)
		{
		}

		// Token: 0x0600014E RID: 334 RVA: 0x000025E3 File Offset: 0x000007E3
		private void btnBUY(object sender, RoutedEventArgs e)
		{
			Process.Start("https://api.whatsapp.com/message/RXCI3IC46N5YM1");
		}

		// Token: 0x0600014F RID: 335 RVA: 0x0000DA38 File Offset: 0x0000BC38
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void InitializeComponent()
		{
			if (!this.bool_0)
			{
				this.bool_0 = true;
				Uri resourceLocator = new Uri("/UAE_BP;component/userlogin.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		// Token: 0x06000150 RID: 336 RVA: 0x0000DA68 File Offset: 0x0000BC68
		[EditorBrowsable(EditorBrowsableState.Never)]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[DebuggerNonUserCode]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.textBox_0 = (TextBox)target;
				break;
			case 2:
				((Hyperlink)target).Click += this.btnBUY;
				break;
			case 3:
				this.button_0 = (Button)target;
				this.button_0.Click += this.Button_Click;
				break;
			default:
				this.bool_0 = true;
				break;
			}
		}

		// Token: 0x0400012E RID: 302
		internal TextBox textBox_0;

		// Token: 0x0400012F RID: 303
		internal Button button_0;

		// Token: 0x04000130 RID: 304
		private bool bool_0;
	}
}
