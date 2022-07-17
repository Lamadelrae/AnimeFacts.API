namespace AnimeFacts.API.SharedKernel.Extensions;

public static class GenericExtensions
{
    public static bool In<T>(this T o, T[] arr) => arr.Contains(o);
}
