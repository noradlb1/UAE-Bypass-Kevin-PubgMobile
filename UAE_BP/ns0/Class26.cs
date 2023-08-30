using System;
using System.Reflection;
using System.Reflection.Emit;

namespace ns0
{
	// Token: 0x02000048 RID: 72
	internal sealed class Class26
	{
		// Token: 0x060001E2 RID: 482 RVA: 0x0000285A File Offset: 0x00000A5A
		static Class26()
		{
			if (typeof(MulticastDelegate) != null)
			{
				Class26.moduleHandle_0 = Assembly.GetExecutingAssembly().GetModules()[0].ModuleHandle;
			}
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x0000F854 File Offset: 0x0000DA54
		public static void smethod_0(int int_22, int int_23, int int_24)
		{
			Type typeFromHandle;
			ConstructorInfo constructorInfo;
			try
			{
				typeFromHandle = Type.GetTypeFromHandle(Class26.moduleHandle_0.ResolveTypeHandle(int_22));
				object methodFromHandle;
				if (int_24 == 16777215)
				{
					methodFromHandle = MethodBase.GetMethodFromHandle(Class26.moduleHandle_0.ResolveMethodHandle(int_23));
				}
				else
				{
					methodFromHandle = MethodBase.GetMethodFromHandle(Class26.moduleHandle_0.ResolveMethodHandle(int_23), Class26.moduleHandle_0.ResolveTypeHandle(int_24));
				}
				constructorInfo = (ConstructorInfo)methodFromHandle;
			}
			catch (Exception)
			{
				throw;
			}
			foreach (FieldInfo fieldInfo in typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField))
			{
				try
				{
					ParameterInfo[] parameters = constructorInfo.GetParameters();
					int num = parameters.Length + 1;
					Type[] array = new Type[num];
					array[0] = constructorInfo.DeclaringType.MakeByRefType();
					for (int j = 1; j < num; j++)
					{
						array[j] = parameters[j - 1].ParameterType;
					}
					DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, null, array, typeFromHandle, true);
					ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
					if (num > 0)
					{
						ilgenerator.Emit(OpCodes.Ldarg_0);
					}
					if (num > 1)
					{
						ilgenerator.Emit(OpCodes.Ldarg_1);
					}
					if (num > 2)
					{
						ilgenerator.Emit(OpCodes.Ldarg_2);
					}
					if (num > 3)
					{
						ilgenerator.Emit(OpCodes.Ldarg_3);
					}
					if (num > 4)
					{
						for (int k = 4; k < num; k++)
						{
							ilgenerator.Emit(OpCodes.Ldarg_S, k);
						}
					}
					ilgenerator.Emit(OpCodes.Call, constructorInfo);
					ilgenerator.Emit(OpCodes.Ret);
					Delegate value = dynamicMethod.CreateDelegate(typeFromHandle);
					fieldInfo.SetValue(null, value);
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x040001B2 RID: 434
		private static readonly int int_0;

		// Token: 0x040001B3 RID: 435
		private static readonly int int_1;

		// Token: 0x040001B4 RID: 436
		private static readonly int int_2;

		// Token: 0x040001B5 RID: 437
		private static readonly int int_3;

		// Token: 0x040001B6 RID: 438
		private static readonly int int_4;

		// Token: 0x040001B7 RID: 439
		private static readonly int int_5;

		// Token: 0x040001B8 RID: 440
		private static readonly int int_6;

		// Token: 0x040001B9 RID: 441
		private static readonly int int_7;

		// Token: 0x040001BA RID: 442
		private static readonly int int_8;

		// Token: 0x040001BB RID: 443
		private static readonly int int_9;

		// Token: 0x040001BC RID: 444
		private static readonly int int_10;

		// Token: 0x040001BD RID: 445
		private static readonly int int_11;

		// Token: 0x040001BE RID: 446
		private static readonly int int_12;

		// Token: 0x040001BF RID: 447
		private static readonly int int_13;

		// Token: 0x040001C0 RID: 448
		private static readonly int int_14;

		// Token: 0x040001C1 RID: 449
		private static readonly int int_15;

		// Token: 0x040001C2 RID: 450
		private static readonly int int_16;

		// Token: 0x040001C3 RID: 451
		private static readonly int int_17;

		// Token: 0x040001C4 RID: 452
		private static readonly int int_18;

		// Token: 0x040001C5 RID: 453
		private static readonly int int_19;

		// Token: 0x040001C6 RID: 454
		private static readonly int int_20;

		// Token: 0x040001C7 RID: 455
		private static readonly int int_21;

		// Token: 0x040001C8 RID: 456
		private static readonly ModuleHandle moduleHandle_0;
	}
}
