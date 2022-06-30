using System;
using Microsoft.Maui.Controls;
using System.Reflection;

namespace Drastic.ImageLoading.Maui.Helpers
{
	internal static class Dependency
	{
		public static void Register(Type type, Type renderer)
		{
			var assembly = typeof(Image).GetTypeInfo().Assembly;
			var registrarType = assembly.GetType("Microsoft.Maui.Controls.Internals.Registrar") ?? assembly.GetType("Microsoft.Maui.Controls.Registrar");
			var registrarProperty = registrarType.GetRuntimeProperty("Registered");

			var registrar = registrarProperty.GetValue(registrarType, null);
			var registerMethod = registrar.GetType().GetRuntimeMethod("Register", new[] { typeof(Type), typeof(Type) });
			registerMethod.Invoke(registrar, new[] { type, renderer });
		}
	}
}
