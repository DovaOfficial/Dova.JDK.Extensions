using Dova.Core;
using Dova.Core.Runtime;

namespace Dova.JDK.Extensions;

public static class ToCSharpExtensions
{
    public static bool ToCSharp(this java.lang.Boolean value) => value.value_Property;
    public static byte ToCSharp(this java.lang.Byte value) => value.value_Property;
    public static char ToCSharp(this java.lang.Character value) => value.value_Property;
    public static double ToCSharp(this java.lang.Double value) => value.value_Property;
    public static float ToCSharp(this java.lang.Float value) => value.value_Property;
    public static int ToCSharp(this java.lang.Integer value) => value.value_Property;
    public static long ToCSharp(this java.lang.Long value) => value.value_Property;
    public static short ToCSharp(this java.lang.Short value) => value.value_Property;
    public static string ToCSharp(this java.lang.String value) => DovaVM.Runtime.GetString(value.CurrentRefPtr);
}