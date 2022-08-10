using Dova.Core;
using Dova.Core.Runtime;

namespace Dova.JDK.Extensions;

public static class ToJavaExtensions
{
    public static java.lang.Boolean ToJava(this bool value) => new(value);
    public static java.lang.Byte ToJava(this byte value) => new(value);
    public static java.lang.Character ToJava(this char value) => new(value);
    public static java.lang.Double ToJava(this double value) => new(value);
    public static java.lang.Float ToJava(this float value) => new(value);
    public static java.lang.Integer ToJava(this int value) => new(value);
    public static java.lang.Long ToJava(this long value) => new(value);
    public static java.lang.Short ToJava(this short value) => new(value);
    public static java.lang.String ToJava(this string value) => new(DovaVM.Runtime.GetString(value));
}