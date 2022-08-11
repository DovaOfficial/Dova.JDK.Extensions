using Dova.JDK.java.lang;
using Dova.JDK.java.util;

namespace Dova.JDK.Extensions;

public static class IterableExtensions
{
    /// <summary>
    /// Converts current Java <see cref="Iterable"/> to C# <see cref="IEnumerable{T}"/>
    /// </summary>
    /// <param name="collection"><see cref="Iterable"/> to convert</param>
    /// <returns><see cref="IEnumerable{T}"/></returns>
    public static IEnumerable<java.lang.Object> AsEnumerable(this Iterable collection)
    {
        var iterator = collection.iterator();

        while (iterator.hasNext())
        {
            yield return iterator.next();
        }
    }

    /// <summary>
    /// Converts current C# <see cref="IEnumerable{T}"/> to Java <see cref="Iterable"/>.
    /// </summary>
    /// <param name="collection"><see cref="IEnumerable{T}"/> to convert</param>
    /// <param name="callback">Callback which will convert each element into <see cref="java.lang.Object"/></param>
    /// <typeparam name="TElement"><see cref="Iterable"/></typeparam>
    /// <returns></returns>
    public static Iterable AsIterable<TElement>(this IEnumerable<TElement> collection, Func<TElement, java.lang.Object> callback)
    {
        var list = new ArrayList();

        foreach (var element in collection)
        {
            list.add(callback.Invoke(element));
        }

        return list;
    }
}