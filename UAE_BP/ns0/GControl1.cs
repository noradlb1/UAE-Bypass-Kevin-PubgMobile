using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Threading;

namespace ns0
{
	// Token: 0x02000025 RID: 37
	public sealed class GControl1 : UserControl, IComponentConnector
	{
		// Token: 0x06000127 RID: 295 RVA: 0x00002525 File Offset: 0x00000725
		public GControl1()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00002050 File Offset: 0x00000250
		private void Close_Submenu_Click(object sender, RoutedEventArgs e)
		{
		}

		// Token: 0x06000129 RID: 297 RVA: 0x0000D400 File Offset: 0x0000B600
		private void account_btn_Selected(object sender, RoutedEventArgs e)
		{
			Storyboard storyboard = base.FindResource("SubmenuTwo_Enter") as Storyboard;
			storyboard.Begin();
		}

		// Token: 0x0600012A RID: 298 RVA: 0x0000D424 File Offset: 0x0000B624
		private void account_btn_Unselected(object sender, RoutedEventArgs e)
		{
			Storyboard storyboard = base.FindResource("SubmenuTwo_Exit") as Storyboard;
			storyboard.Begin();
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00002050 File Offset: 0x00000250
		private void Gl_btn_Selected(object sender, RoutedEventArgs e)
		{
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00002050 File Offset: 0x00000250
		private void kr_btn_Selected(object sender, RoutedEventArgs e)
		{
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00002050 File Offset: 0x00000250
		private void vn_btn_Selected(object sender, RoutedEventArgs e)
		{
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00002050 File Offset: 0x00000250
		private void tw_btn_Selected(object sender, RoutedEventArgs e)
		{
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00002050 File Offset: 0x00000250
		private void in_btn_Selected(object sender, RoutedEventArgs e)
		{
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00002533 File Offset: 0x00000733
		private void RadioButton_Checked(object sender, RoutedEventArgs e)
		{
			GClass8.string_0 = "com.tencent.ig";
		}

		// Token: 0x06000131 RID: 305 RVA: 0x0000253F File Offset: 0x0000073F
		private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
		{
			GClass8.string_0 = "com.pubg.krmobile";
		}

		// Token: 0x06000132 RID: 306 RVA: 0x0000254B File Offset: 0x0000074B
		private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
		{
			GClass8.string_0 = "com.vng.pubgmobile";
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00002557 File Offset: 0x00000757
		private void RadioButton_Checked_3(object sender, RoutedEventArgs e)
		{
			GClass8.string_0 = "com.rekoo.pubgm";
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00002563 File Offset: 0x00000763
		private void Button_Click(object sender, RoutedEventArgs e)
		{
			this.method_0(this.button_0.Content.ToString());
		}

		// Token: 0x06000135 RID: 309 RVA: 0x0000D448 File Offset: 0x0000B648
		private void method_0(string string_0)
		{
			if (!(string_0 == "START"))
			{
				this.method_2();
			}
			else
			{
				this.method_1();
			}
		}

		// Token: 0x06000136 RID: 310 RVA: 0x0000D474 File Offset: 0x0000B674
		private void method_1()
		{
			this.button_0.Content = "STOP";
			this.button_0.Background = Brushes.Crimson;
			base.Dispatcher.Invoke(DispatcherPriority.Normal, new Action(GControl1.<>c.<>c_0.method_0));
			GClass11 gclass = Application.Current.MainWindow as GClass11;
			if (gclass != Class31.gclass11_0)
			{
				gclass.gcontrol5_0.Visibility = Visibility.Visible;
				gclass.gcontrol0_0.Visibility = Visibility.Collapsed;
			}
		}

		// Token: 0x06000137 RID: 311 RVA: 0x0000D500 File Offset: 0x0000B700
		private void method_2()
		{
			this.button_0.Content = "START";
			this.button_0.Background = Brushes.Gold;
			base.Dispatcher.Invoke(DispatcherPriority.Normal, new Action(GControl1.<>c.<>c_0.method_1));
		}

		// Token: 0x06000138 RID: 312 RVA: 0x0000257B File Offset: 0x0000077B
		private void radiu64(object sender, RoutedEventArgs e)
		{
			GClass8.int_0 = 64;
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00002584 File Offset: 0x00000784
		private void radiu32(object sender, RoutedEventArgs e)
		{
			GClass8.int_0 = 32;
		}

		// Token: 0x0600013A RID: 314 RVA: 0x0000D55C File Offset: 0x0000B75C
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (!this.bool_0)
			{
				this.bool_0 = true;
				Uri resourceLocator = new Uri("/UAE_BP;component/usergame.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		// Token: 0x0600013B RID: 315 RVA: 0x0000D58C File Offset: 0x0000B78C
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[DebuggerNonUserCode]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				((RadioButton)target).Checked += this.radiu64;
				break;
			case 2:
				((RadioButton)target).Checked += this.radiu32;
				break;
			case 3:
				((RadioButton)target).Checked += this.RadioButton_Checked;
				break;
			case 4:
				((RadioButton)target).Checked += this.RadioButton_Checked_1;
				break;
			case 5:
				((RadioButton)target).Checked += this.RadioButton_Checked_2;
				break;
			case 6:
				((RadioButton)target).Checked += this.RadioButton_Checked_3;
				break;
			case 7:
				this.button_0 = (Button)target;
				this.button_0.Click += this.Button_Click;
				break;
			default:
				this.bool_0 = true;
				break;
			}
		}

		// Token: 0x04000114 RID: 276
		internal Button button_0;

		// Token: 0x04000115 RID: 277
		private bool bool_0;
	}
}
