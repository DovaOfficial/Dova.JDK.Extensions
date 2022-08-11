using Dova.JDK.java.lang;

namespace Dova.JDK.Extensions;

public static class IterableExtensions
{
    /// <summary>
    /// Converts current Java <see cref="Iterable"/> to C# <see cref="IEnumerable{T}"/>
    /// </summary>
    /// <param name="iter"><see cref="Iterable"/> to convert</param>
    /// <returns><see cref="IEnumerable{T}"/></returns>
    public static IEnumerable<java.lang.Object> AsEnumerable(this Iterable collection)
    {
        var iterator = collection.iterator();

        while (iterator.hasNext())
        {
            yield return iterator.next();
        }
    }
}