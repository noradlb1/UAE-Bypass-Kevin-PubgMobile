using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x02000030 RID: 48
	public sealed class GControl5 : UserControl, IComponentConnector
	{
		// Token: 0x06000165 RID: 357 RVA: 0x00002632 File Offset: 0x00000832
		public GControl5()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00002640 File Offset: 0x00000840
		public void method_0(int int_0, bool bool_1 = true)
		{
			this.textBlock_0.Text = int_0.ToString();
		}

		// Token: 0x06000167 RID: 359 RVA: 0x0000DF28 File Offset: 0x0000C128
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (!this.bool_0)
			{
				this.bool_0 = true;
				Uri resourceLocator = new Uri("/UAE_BP;component/usertest.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		// Token: 0x06000168 RID: 360 RVA: 0x0000DF58 File Offset: 0x0000C158
		[DebuggerNonUserCode]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.textBlock_0 = (TextBlock)target;
				break;
			case 2:
				this.textBlock_1 = (TextBlock)target;
				break;
			case 3:
				this.textBlock_2 = (TextBlock)target;
				break;
			default:
				this.bool_0 = true;
				break;
			}
		}

		// Token: 0x04000143 RID: 323
		internal TextBlock textBlock_0;

		// Token: 0x04000144 RID: 324
		internal TextBlock textBlock_1;

		// Token: 0x04000145 RID: 325
		internal TextBlock textBlock_2;

		// Token: 0x04000146 RID: 326
		private bool bool_0;
	}
}
