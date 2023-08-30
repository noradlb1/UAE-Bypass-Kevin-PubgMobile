using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Threading;

namespace ns0
{
	// Token: 0x0200002B RID: 43
	public sealed class GControl4 : UserControl, IComponentConnector
	{
		// Token: 0x06000151 RID: 337 RVA: 0x000025F0 File Offset: 0x000007F0
		public GControl4()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000152 RID: 338 RVA: 0x0000DAE0 File Offset: 0x0000BCE0
		public void method_0(string string_0, bool bool_1)
		{
			GControl4.Class11 @class = new GControl4.Class11();
			@class.gcontrol4_0 = this;
			@class.bool_0 = bool_1;
			@class.string_0 = string_0;
			Task.Run(new Func<Task>(@class.method_0));
		}

		// Token: 0x06000153 RID: 339 RVA: 0x0000DB1C File Offset: 0x0000BD1C
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (!this.bool_0)
			{
				this.bool_0 = true;
				Uri resourceLocator = new Uri("/UAE_BP;component/usermessage.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		// Token: 0x06000154 RID: 340 RVA: 0x0000DB4C File Offset: 0x0000BD4C
		[DebuggerNonUserCode]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			if (connectionId != 1)
			{
				if (connectionId != 2)
				{
					this.bool_0 = true;
				}
				else
				{
					this.run_0 = (Run)target;
				}
			}
			else
			{
				this.border_0 = (Border)target;
			}
		}

		// Token: 0x04000131 RID: 305
		internal Border border_0;

		// Token: 0x04000132 RID: 306
		internal Run run_0;

		// Token: 0x04000133 RID: 307
		private bool bool_0;

		// Token: 0x0200002C RID: 44
		[CompilerGenerated]
		private sealed class Class11
		{
			// Token: 0x06000156 RID: 342 RVA: 0x0000DB88 File Offset: 0x0000BD88
			[DebuggerStepThrough]
			internal Task method_0()
			{
				GControl4.Class11.Class13 @class = new GControl4.Class11.Class13();
				@class.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
				@class.class11_0 = this;
				@class.int_0 = -1;
				@class.asyncTaskMethodBuilder_0.Start<GControl4.Class11.Class13>(ref @class);
				return @class.asyncTaskMethodBuilder_0.Task;
			}

			// Token: 0x06000157 RID: 343 RVA: 0x0000DBD0 File Offset: 0x0000BDD0
			[DebuggerStepThrough]
			internal void method_1()
			{
				GControl4.Class11.Class12 @class = new GControl4.Class11.Class12();
				@class.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
				@class.class11_0 = this;
				@class.int_0 = -1;
				@class.asyncVoidMethodBuilder_0.Start<GControl4.Class11.Class12>(ref @class);
			}

			// Token: 0x04000134 RID: 308
			public GControl4 gcontrol4_0;

			// Token: 0x04000135 RID: 309
			public bool bool_0;

			// Token: 0x04000136 RID: 310
			public string string_0;

			// Token: 0x04000137 RID: 311
			public Action action_0;

			// Token: 0x0200002D RID: 45
			private sealed class Class12 : IAsyncStateMachine
			{
				// Token: 0x06000159 RID: 345 RVA: 0x0000DC0C File Offset: 0x0000BE0C
				void IAsyncStateMachine.MoveNext()
				{
					int num = this.int_0;
					try
					{
						TaskAwaiter awaiter;
						if (num != 0)
						{
							this.class11_0.gcontrol4_0.border_0.Visibility = Visibility.Visible;
							this.solidColorBrush_0 = new SolidColorBrush(Colors.Crimson);
							if (!this.class11_0.bool_0)
							{
								this.solidColorBrush_0 = new SolidColorBrush(Colors.Crimson);
							}
							else
							{
								this.solidColorBrush_0 = new SolidColorBrush(Colors.YellowGreen);
							}
							this.class11_0.gcontrol4_0.run_0.Text = this.class11_0.string_0;
							this.class11_0.gcontrol4_0.border_0.Background = this.solidColorBrush_0;
							awaiter = Task.Delay(6000).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.int_0 = 0;
								this.taskAwaiter_0 = awaiter;
								GControl4.Class11.Class12 @class = this;
								this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GControl4.Class11.Class12>(ref awaiter, ref @class);
								return;
							}
						}
						else
						{
							awaiter = this.taskAwaiter_0;
							this.taskAwaiter_0 = default(TaskAwaiter);
							this.int_0 = -1;
						}
						awaiter.GetResult();
						this.class11_0.gcontrol4_0.border_0.Visibility = Visibility.Collapsed;
					}
					catch (Exception exception)
					{
						this.int_0 = -2;
						this.solidColorBrush_0 = Class35.solidColorBrush_0;
						this.asyncVoidMethodBuilder_0.SetException(exception);
						return;
					}
					this.int_0 = -2;
					this.solidColorBrush_0 = Class35.solidColorBrush_0;
					this.asyncVoidMethodBuilder_0.SetResult();
				}

				// Token: 0x0600015A RID: 346 RVA: 0x00002050 File Offset: 0x00000250
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}

				// Token: 0x04000138 RID: 312
				public int int_0;

				// Token: 0x04000139 RID: 313
				public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

				// Token: 0x0400013A RID: 314
				public GControl4.Class11 class11_0;

				// Token: 0x0400013B RID: 315
				private SolidColorBrush solidColorBrush_0;

				// Token: 0x0400013C RID: 316
				private TaskAwaiter taskAwaiter_0;
			}

			// Token: 0x0200002E RID: 46
			private sealed class Class13 : IAsyncStateMachine
			{
				// Token: 0x0600015C RID: 348 RVA: 0x0000DD94 File Offset: 0x0000BF94
				void IAsyncStateMachine.MoveNext()
				{
					try
					{
						Dispatcher dispatcher = this.class11_0.gcontrol4_0.Dispatcher;
						DispatcherPriority priority = DispatcherPriority.Normal;
						Action method;
						if ((method = this.class11_0.action_0) == null)
						{
							method = (this.class11_0.action_0 = new Action(this.class11_0.method_1));
						}
						dispatcher.Invoke(priority, method);
					}
					catch (Exception exception)
					{
						this.int_0 = -2;
						this.asyncTaskMethodBuilder_0.SetException(exception);
						return;
					}
					this.int_0 = -2;
					this.asyncTaskMethodBuilder_0.SetResult();
				}

				// Token: 0x0600015D RID: 349 RVA: 0x00002050 File Offset: 0x00000250
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}

				// Token: 0x0400013D RID: 317
				public int int_0;

				// Token: 0x0400013E RID: 318
				public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

				// Token: 0x0400013F RID: 319
				public GControl4.Class11 class11_0;
			}
		}
	}
}
