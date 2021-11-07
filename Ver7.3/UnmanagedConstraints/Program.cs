using System;

/// <summary>
/// Ref: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/unmanaged-types
/// A type is an unmanaged type if it's any of the following types:
/// - sbyte, byte, short, ushort, int, uint, long, ulong, char, float, double, decimal, or bool
/// - Any enum type
/// - Any pointer type
/// - Any user-defined struct type that contains fields of unmanaged types only and, in C# 7.3 and earlier, is not a constructed type (a type that includes at least one type argument)
/// 
/// Beginning with C# 7.3, you can use the unmanaged constraint to specify that a type parameter is a non-pointer, non-nullable unmanaged type.
/// </summary>
/// <typeparam name="T"></typeparam>
public struct Coords<T>
{
    public T X;
    public T Y;
}

public class UnmanagedTypes
{
    public static void Main()
    {
        DisplaySize<Coords<int>>();
        DisplaySize<Coords<double>>();
    }

    private unsafe static void DisplaySize<T>() where T : unmanaged
    {
        Console.WriteLine($"{typeof(T)} is unmanaged and its size is {sizeof(T)} bytes");
    }
}
// Output:
// Coords`1[System.Int32] is unmanaged and its size is 8 bytes
// Coords`1[System.Double] is unmanaged and its size is 16 bytes
