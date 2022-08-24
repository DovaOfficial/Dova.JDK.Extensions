using Dova.Common;

namespace Dova.JDK.Extensions;

public static class TypeExtensions
{
    public static string ToJavaClassName(this Type type)
    {
        var signatureAttribute = type
            .GetCustomAttributes(typeof(JniSignatureAttribute), true)
            .FirstOrDefault() as JniSignatureAttribute;

        if (signatureAttribute == null)
        {
            throw new ArgumentException($"Cannot find {nameof(JniSignatureAttribute)} on a specified type: {type}");
        }

        var sig = signatureAttribute.Signature;

        var cleanedSig = sig
            .Substring(1, sig.Length - 2) // remove 'L' on front and ';' at the end
            .Replace("/", ".");

        return cleanedSig;
    }
}