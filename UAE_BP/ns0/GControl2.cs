using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media.Animation;

namespace ns0
{
	// Token: 0x02000029 RID: 41
	public sealed class GControl2 : UserControl, IComponentConnector
	{
		// Token: 0x06000146 RID: 326 RVA: 0x00002599 File Offset: 0x00000799
		public GControl2()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00002050 File Offset: 0x00000250
		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
		}

		// Token: 0x06000148 RID: 328 RVA: 0x000025A7 File Offset: 0x000007A7
		private void Animation4Completed(object sender, EventArgs e)
		{
			this.storyboard_0.Begin();
			this.storyboard_1.Begin();
			this.storyboard_2.Begin();
			this.storyboard_3.Begin();
		}

		// Token: 0x06000149 RID: 329 RVA: 0x0000D874 File Offset: 0x0000BA74
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (!this.bool_0)
			{
				this.bool_0 = true;
				Uri resourceLocator = new Uri("/UAE_BP;component/userloading.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		// Token: 0x0600014A RID: 330 RVA: 0x0000D8A4 File Offset: 0x0000BAA4
		[DebuggerNonUserCode]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				((GControl2)target).Loaded += this.Window_Loaded;
				break;
			case 2:
				this.border_0 = (Border)target;
				break;
			case 3:
				this.storyboard_0 = (Storyboard)target;
				break;
			case 4:
				this.doubleAnimation_0 = (DoubleAnimation)target;
				break;
			case 5:
				this.border_1 = (Border)target;
				break;
			case 6:
				this.storyboard_1 = (Storyboard)target;
				break;
			case 7:
				this.doubleAnimation_1 = (DoubleAnimation)target;
				break;
			case 8:
				this.border_2 = (Border)target;
				break;
			case 9:
				this.storyboard_2 = (Storyboard)target;
				break;
			case 10:
				this.doubleAnimation_2 = (DoubleAnimation)target;
				break;
			case 11:
				this.border_3 = (Border)target;
				break;
			case 12:
				this.storyboard_3 = (Storyboard)target;
				this.storyboard_3.Completed += this.Animation4Completed;
				break;
			case 13:
				this.doubleAnimation_3 = (DoubleAnimation)target;
				break;
			default:
				this.bool_0 = true;
				break;
			}
		}

		// Token: 0x04000121 RID: 289
		internal Border border_0;

		// Token: 0x04000122 RID: 290
		internal Storyboard storyboard_0;

		// Token: 0x04000123 RID: 291
		internal DoubleAnimation doubleAnimation_0;

		// Token: 0x04000124 RID: 292
		internal Border border_1;

		// Token: 0x04000125 RID: 293
		internal Storyboard storyboard_1;

		// Token: 0x04000126 RID: 294
		internal DoubleAnimation doubleAnimation_1;

		// Token: 0x04000127 RID: 295
		internal Border border_2;

		// Token: 0x04000128 RID: 296
		internal Storyboard storyboard_2;

		// Token: 0x04000129 RID: 297
		internal DoubleAnimation doubleAnimation_2;

		// Token: 0x0400012A RID: 298
		internal Border border_3;

		// Token: 0x0400012B RID: 299
		internal Storyboard storyboard_3;

		// Token: 0x0400012C RID: 300
		internal DoubleAnimation doubleAnimation_3;

		// Token: 0x0400012D RID: 301
		private bool bool_0;
	}
}
