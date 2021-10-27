namespace CovarianceAndContravariance
{
    // Ref: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/covariance-contravariance/
    class Program
    {
        static void SetObject(object o) { }

        static void Main(string[] args)
        {
            // Assignment compatibility.
            string str = "test";
            // An object of a more derived type is assigned to an object of a less derived type.
            object obj = str;

            // this will meet a compile error.
            //acceptString(obj);
        }

        static void acceptString(string str) { }
    }
}
