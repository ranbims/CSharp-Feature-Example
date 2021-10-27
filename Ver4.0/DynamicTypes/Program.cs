using System;

namespace DynamicTypes
{

    /// <summary>
    /// Ref: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/reference-types#the-dynamic-type
    /// 
    /// The dynamic type indicates that use of the variable and references to its members bypass 
    /// compile-time type checking. Instead, these operations are resolved at run time. The dynamic 
    /// type simplifies access to COM APIs such as the Office Automation APIs, to dynamic APIs such 
    /// as IronPython libraries, and to the HTML Document Object Model (DOM).
    /// 
    /// Type dynamic behaves like type object in most circumstances.In particular, any non-null 
    /// expression can be converted to the dynamic type. The dynamic type differs from object in 
    /// that operations that contain expressions of type dynamic are not resolved or type checked
    /// by the compiler.The compiler packages together information about the operation, and that 
    /// information is later used to evaluate the operation at run time.As part of the process,
    /// variables of type dynamic are compiled into variables of type object. Therefore, type 
    /// dynamic exists only at compile time, not at run time.
    /// </summary>
    class ExampleClass
    {
        static dynamic field;
        dynamic prop { get; set; }

        public dynamic exampleMethod(dynamic d)
        {
            dynamic local = "Local variable";
            int two = 2;

            if (d is int)
            {
                return local;
            }
            else
            {
                return two;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ExampleClass ec = new ExampleClass();
            Console.WriteLine(ec.exampleMethod(10));
            Console.WriteLine(ec.exampleMethod("value"));

            dynamic dynamic_ec = new ExampleClass();
            Console.WriteLine(dynamic_ec.exampleMethod(10));

            // Because dynamic_ec is dynamic, the following call to exampleMethod
            // with two arguments does not produce an error at compile time.
            // However, it does cause a run-time error.
            //Console.WriteLine(dynamic_ec.exampleMethod(10, 4));
        }
    }
}
