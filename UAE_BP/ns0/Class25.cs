using System;
using System.Reflection;
using System.Reflection.Emit;

namespace ns0
{
	// Token: 0x02000047 RID: 71
	internal sealed class Class25
	{
		// Token: 0x060001DF RID: 479 RVA: 0x00002836 File Offset: 0x00000A36
		static Class25()
		{
			if (typeof(MulticastDelegate) != null)
			{
				Class25.moduleHandle_0 = Assembly.GetExecutingAssembly().GetModules()[0].ModuleHandle;
			}
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x0000F6A4 File Offset: 0x0000D8A4
		public static void smethod_0(int int_22, int int_23, int int_24)
		{
			Type typeFromHandle;
			ConstructorInfo constructorInfo;
			try
			{
				typeFromHandle = Type.GetTypeFromHandle(Class25.moduleHandle_0.ResolveTypeHandle(int_22));
				object methodFromHandle;
				if (int_24 == 16777215)
				{
					methodFromHandle = MethodBase.GetMethodFromHandle(Class25.moduleHandle_0.ResolveMethodHandle(int_23));
				}
				else
				{
					methodFromHandle = MethodBase.GetMethodFromHandle(Class25.moduleHandle_0.ResolveMethodHandle(int_23), Class25.moduleHandle_0.ResolveTypeHandle(int_24));
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
					int num = parameters.Length;
					Type[] array = new Type[num];
					for (int j = 0; j < num; j++)
					{
						array[j] = parameters[j].ParameterType;
					}
					DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, constructorInfo.DeclaringType, array, typeFromHandle, true);
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
					ilgenerator.Emit(OpCodes.Newobj, constructorInfo);
					ilgenerator.Emit(OpCodes.Ret);
					Delegate value = dynamicMethod.CreateDelegate(typeFromHandle);
					fieldInfo.SetValue(null, value);
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x0400019B RID: 411
		private static readonly int int_0;

		// Token: 0x0400019C RID: 412
		private static readonly int int_1;

		// Token: 0x0400019D RID: 413
		private static readonly int int_2;

		// Token: 0x0400019E RID: 414
		private static readonly int int_3;

		// Token: 0x0400019F RID: 415
		private static readonly int int_4;

		// Token: 0x040001A0 RID: 416
		private static readonly int int_5;

		// Token: 0x040001A1 RID: 417
		private static readonly int int_6;

		// Token: 0x040001A2 RID: 418
		private static readonly int int_7;

		// Token: 0x040001A3 RID: 419
		private static readonly int int_8;

		// Token: 0x040001A4 RID: 420
		private static readonly int int_9;

		// Token: 0x040001A5 RID: 421
		private static readonly int int_10;

		// Token: 0x040001A6 RID: 422
		private static readonly int int_11;

		// Token: 0x040001A7 RID: 423
		private static readonly int int_12;

		// Token: 0x040001A8 RID: 424
		private static readonly int int_13;

		// Token: 0x040001A9 RID: 425
		private static readonly int int_14;

		// Token: 0x040001AA RID: 426
		private static readonly int int_15;

		// Token: 0x040001AB RID: 427
		private static readonly int int_16;

		// Token: 0x040001AC RID: 428
		private static readonly int int_17;

		// Token: 0x040001AD RID: 429
		private static readonly int int_18;

		// Token: 0x040001AE RID: 430
		private static readonly int int_19;

		// Token: 0x040001AF RID: 431
		private static readonly int int_20;

		// Token: 0x040001B0 RID: 432
		private static readonly int int_21;

		// Token: 0x040001B1 RID: 433
		private static readonly ModuleHandle moduleHandle_0;
	}
}
