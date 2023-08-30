using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Shapes;

namespace ns0
{
	// Token: 0x02000035 RID: 53
	public sealed class GClass11 : Window, IComponentConnector
	{
		// Token: 0x0600017B RID: 379 RVA: 0x0000E23C File Offset: 0x0000C43C
		public GClass11()
		{
			AppDomain.CurrentDomain.AssemblyResolve += GClass11.ResolveAssemblies;
			this.InitializeComponent();
			Task.Run(new Func<Task>(this.method_5));
		}

		// Token: 0x0600017D RID: 381 RVA: 0x0000E2E4 File Offset: 0x0000C4E4
		public static Assembly ResolveAssemblies(object sender, ResolveEventArgs e)
		{
			AssemblyName assemblyName = new AssemblyName(e.Name);
			byte[] array = Class43.byte_0;
			string name = assemblyName.Name;
			string text = name;
			if (text != null && assemblyName.Name == "WpfAnimatedGif")
			{
				array = Class20.WpfAnimatedGif;
			}
			Assembly result;
			if (array != Class43.byte_0)
			{
				result = Assembly.Load(array);
			}
			else
			{
				result = Class37.assembly_0;
			}
			return result;
		}

		// Token: 0x0600017E RID: 382 RVA: 0x0000E344 File Offset: 0x0000C544
		private static DateTime smethod_0(long long_0)
		{
			DateTime result = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local);
			result = result.AddSeconds((double)long_0).ToLocalTime();
			return result;
		}

		// Token: 0x0600017F RID: 383 RVA: 0x0000E380 File Offset: 0x0000C580
		[DebuggerStepThrough]
		public Task method_0()
		{
			GClass11.Class18 @class = new GClass11.Class18();
			@class.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@class.gclass11_0 = this;
			@class.int_0 = -1;
			@class.asyncTaskMethodBuilder_0.Start<GClass11.Class18>(ref @class);
			return @class.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x06000180 RID: 384 RVA: 0x000026DF File Offset: 0x000008DF
		private void Button_Click(object sender, RoutedEventArgs e)
		{
			Process.GetCurrentProcess().Close();
			Environment.Exit(0);
		}

		// Token: 0x06000181 RID: 385 RVA: 0x000026F1 File Offset: 0x000008F1
		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			if (base.WindowState != WindowState.Minimized)
			{
				base.WindowState = WindowState.Minimized;
			}
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00002050 File Offset: 0x00000250
		private void Hyperlink_Click(object sender, RoutedEventArgs e)
		{
		}

		// Token: 0x06000183 RID: 387 RVA: 0x0000E3C8 File Offset: 0x0000C5C8
		private void method_1()
		{
			this.gcontrol3_0.Visibility = Visibility.Collapsed;
			this.gcontrol1_0.Visibility = Visibility.Collapsed;
			this.gcontrol6_0.Visibility = Visibility.Collapsed;
			this.ellipse_0.Fill = Brushes.Gray;
			this.ellipse_1.Fill = Brushes.Gray;
			this.ellipse_2.Fill = Brushes.Gray;
			this.hyperlink_1.Foreground = Brushes.Gray;
			this.hyperlink_0.Foreground = Brushes.Gray;
			this.hyperlink_2.Foreground = Brushes.Gray;
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00002708 File Offset: 0x00000908
		private void btnLoginForm(object sender, RoutedEventArgs e)
		{
			this.method_1();
			this.gcontrol3_0.Visibility = Visibility.Visible;
			this.ellipse_0.Fill = Brushes.Gold;
			this.hyperlink_0.Foreground = Brushes.Gold;
		}

		// Token: 0x06000185 RID: 389 RVA: 0x0000273C File Offset: 0x0000093C
		private void btnGameForm(object sender, RoutedEventArgs e)
		{
			this.method_1();
			this.gcontrol1_0.Visibility = Visibility.Visible;
			this.ellipse_1.Fill = Brushes.Gold;
			this.hyperlink_1.Foreground = Brushes.Gold;
		}

		// Token: 0x06000186 RID: 390 RVA: 0x0000E45C File Offset: 0x0000C65C
		public void method_2()
		{
			this.method_1();
			this.gcontrol1_0.Visibility = Visibility.Visible;
			this.ellipse_1.Fill = Brushes.Gold;
			this.hyperlink_1.Foreground = Brushes.Gold;
			this.gcontrol3_0.button_0.Background = Brushes.Crimson;
			this.gcontrol3_0.button_0.Content = "Logout";
			this.hyperlink_0.IsEnabled = true;
			this.hyperlink_2.IsEnabled = true;
			this.gcontrol2_0.Visibility = Visibility.Collapsed;
		}

		// Token: 0x06000187 RID: 391 RVA: 0x0000E4EC File Offset: 0x0000C6EC
		public void method_3()
		{
			this.method_1();
			this.gcontrol3_0.Visibility = Visibility.Visible;
			this.ellipse_0.Fill = Brushes.Gold;
			this.hyperlink_0.Foreground = Brushes.Gold;
			this.gcontrol3_0.button_0.Background = Brushes.YellowGreen;
			this.gcontrol3_0.button_0.Content = "Login";
			this.hyperlink_2.IsEnabled = false;
			this.hyperlink_1.IsEnabled = false;
			this.gcontrol4_0.method_0("Logout..", false);
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00002770 File Offset: 0x00000970
		private void btnToolsForm(object sender, RoutedEventArgs e)
		{
			this.method_1();
			this.gcontrol6_0.Visibility = Visibility.Visible;
			this.ellipse_2.Fill = Brushes.Gold;
			this.hyperlink_2.Foreground = Brushes.Gold;
		}

		// Token: 0x06000189 RID: 393 RVA: 0x000027A4 File Offset: 0x000009A4
		private void Button_Click_2(object sender, RoutedEventArgs e)
		{
			this.gcontrol5_0.Visibility = Visibility.Collapsed;
			this.gcontrol0_0.Visibility = Visibility.Visible;
		}

		// Token: 0x0600018A RID: 394 RVA: 0x000027BE File Offset: 0x000009BE
		private void Window_MouseDown(object sender, MouseButtonEventArgs e)
		{
			if (e.ChangedButton == MouseButton.Left)
			{
				base.DragMove();
			}
		}

		// Token: 0x0600018B RID: 395 RVA: 0x0000E580 File Offset: 0x0000C780
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (!this.bool_0)
			{
				this.bool_0 = true;
				Uri resourceLocator = new Uri("/UAE_BP;component/mainwindow.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		// Token: 0x0600018C RID: 396 RVA: 0x0000E5B0 File Offset: 0x0000C7B0
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal Delegate method_4(Type type_0, string string_1)
		{
			return Delegate.CreateDelegate(type_0, this, string_1);
		}

		// Token: 0x0600018D RID: 397 RVA: 0x0000E5C8 File Offset: 0x0000C7C8
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				((GClass11)target).MouseDown += this.Window_MouseDown;
				break;
			case 2:
				((Button)target).Click += this.Button_Click;
				break;
			case 3:
				((Button)target).Click += this.Button_Click_1;
				break;
			case 4:
				this.gcontrol4_0 = (GControl4)target;
				break;
			case 5:
				this.image_0 = (Image)target;
				break;
			case 6:
				this.gcontrol0_0 = (GControl0)target;
				break;
			case 7:
				this.gcontrol5_0 = (GControl5)target;
				break;
			case 8:
				this.gcontrol2_0 = (GControl2)target;
				break;
			case 9:
				((Button)target).Click += this.Button_Click_2;
				break;
			case 10:
				this.textBlock_0 = (TextBlock)target;
				break;
			case 11:
				this.hyperlink_0 = (Hyperlink)target;
				this.hyperlink_0.Click += this.btnLoginForm;
				break;
			case 12:
				this.hyperlink_1 = (Hyperlink)target;
				this.hyperlink_1.Click += this.btnGameForm;
				break;
			case 13:
				this.hyperlink_2 = (Hyperlink)target;
				this.hyperlink_2.Click += this.btnToolsForm;
				break;
			case 14:
				this.ellipse_0 = (Ellipse)target;
				break;
			case 15:
				this.ellipse_1 = (Ellipse)target;
				break;
			case 16:
				this.ellipse_2 = (Ellipse)target;
				break;
			case 17:
				this.gcontrol3_0 = (GControl3)target;
				break;
			case 18:
				this.gcontrol1_0 = (GControl1)target;
				break;
			case 19:
				this.gcontrol6_0 = (GControl6)target;
				break;
			default:
				this.bool_0 = true;
				break;
			}
		}

		// Token: 0x0600018E RID: 398 RVA: 0x0000E7D4 File Offset: 0x0000C9D4
		[DebuggerStepThrough]
		[CompilerGenerated]
		private Task method_5()
		{
			GClass11.Class19 @class = new GClass11.Class19();
			@class.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@class.gclass11_0 = this;
			@class.int_0 = -1;
			@class.asyncTaskMethodBuilder_0.Start<GClass11.Class19>(ref @class);
			return @class.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x0400014E RID: 334
		private string string_0 = "UaE-K.ini";

		// Token: 0x0400014F RID: 335
		private static Mutex mutex = new Mutex(true, "{8F6ffACd-B921-45fd-A8CF-72F33E6BDE8F}");

		// Token: 0x04000150 RID: 336
		public static GClass0 kevinauth = new GClass0("UAE", "VGyBDlImF5", "6ea08456f36c59896cc260d09a16be45989b5156c18f390686b11e3b901cb7d9", Assembly.GetExecutingAssembly().GetName().Version.ToString().Replace(".0.0", ""));

		// Token: 0x04000151 RID: 337
		internal GControl4 gcontrol4_0;

		// Token: 0x04000152 RID: 338
		internal Image image_0;

		// Token: 0x04000153 RID: 339
		internal GControl0 gcontrol0_0;

		// Token: 0x04000154 RID: 340
		internal GControl5 gcontrol5_0;

		// Token: 0x04000155 RID: 341
		internal GControl2 gcontrol2_0;

		// Token: 0x04000156 RID: 342
		internal TextBlock textBlock_0;

		// Token: 0x04000157 RID: 343
		internal Hyperlink hyperlink_0;

		// Token: 0x04000158 RID: 344
		internal Hyperlink hyperlink_1;

		// Token: 0x04000159 RID: 345
		internal Hyperlink hyperlink_2;

		// Token: 0x0400015A RID: 346
		internal Ellipse ellipse_0;

		// Token: 0x0400015B RID: 347
		internal Ellipse ellipse_1;

		// Token: 0x0400015C RID: 348
		internal Ellipse ellipse_2;

		// Token: 0x0400015D RID: 349
		internal GControl3 gcontrol3_0;

		// Token: 0x0400015E RID: 350
		internal GControl1 gcontrol1_0;

		// Token: 0x0400015F RID: 351
		internal GControl6 gcontrol6_0;

		// Token: 0x04000160 RID: 352
		private bool bool_0;

		// Token: 0x02000036 RID: 54
		[CompilerGenerated]
		private sealed class Class16
		{
			// Token: 0x06000190 RID: 400 RVA: 0x000027D1 File Offset: 0x000009D1
			internal void method_0()
			{
				this.gclass11_0.gcontrol4_0.method_0("Key invalid Try Again..", false);
			}

			// Token: 0x04000161 RID: 353
			public GClass11 gclass11_0;

			// Token: 0x04000162 RID: 354
			public int int_0;

			// Token: 0x04000163 RID: 355
			public string string_0;
		}

		// Token: 0x02000037 RID: 55
		[CompilerGenerated]
		private sealed class Class17
		{
			// Token: 0x06000192 RID: 402 RVA: 0x0000E81C File Offset: 0x0000CA1C
			internal void method_0()
			{
				this.class16_0.gclass11_0.textBlock_0.Text = this.dateTime_0.ToString("f");
				this.class16_0.gclass11_0.hyperlink_1.IsEnabled = true;
				this.class16_0.gclass11_0.hyperlink_2.IsEnabled = true;
				File.WriteAllText("UaE-K.ini", GClass8.key);
				this.class16_0.gclass11_0.method_2();
				this.class16_0.gclass11_0.gcontrol3_0.textBox_0.Text = GClass8.key;
				this.class16_0.gclass11_0.gcontrol4_0.method_0("Welcome Login Has bin Successfuly..", true);
				this.class16_0.int_0 = 0;
				GClass8.key = Class40.string_0;
				this.class16_0.string_0 = Class40.string_0;
			}

			// Token: 0x04000164 RID: 356
			public DateTime dateTime_0;

			// Token: 0x04000165 RID: 357
			public GClass11.Class16 class16_0;
		}
	}
}
