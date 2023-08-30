using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x02000024 RID: 36
	public sealed class GControl0 : UserControl, IComponentConnector
	{
		// Token: 0x06000124 RID: 292 RVA: 0x0000250E File Offset: 0x0000070E
		public GControl0()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000125 RID: 293 RVA: 0x0000D3D0 File Offset: 0x0000B5D0
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (!this.bool_0)
			{
				this.bool_0 = true;
				Uri resourceLocator = new Uri("/UAE_BP;component/userabout.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		// Token: 0x06000126 RID: 294 RVA: 0x0000251C File Offset: 0x0000071C
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerNonUserCode]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			this.bool_0 = true;
		}

		// Token: 0x04000113 RID: 275
		private bool bool_0;
	}
}
