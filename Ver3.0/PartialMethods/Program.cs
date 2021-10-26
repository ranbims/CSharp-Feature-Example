using System;

/// <summary>
/// A partial method has its signature defined in one part of a partial type, 
/// and its implementation defined in another part of the type. 
/// 
/// Partial methods enable class designers to provide method hooks, 
/// similar to event handlers, that developers may decide to implement or not. 
/// 
/// If the developer does not supply an implementation, the compiler removes the signature at compile time.
/// </summary>
namespace PartialMethods
{
    partial class Program
    {
        partial void OnSomethingHappened(String s);

        static void Main(string[] args)
        {
            Program p = new Program();
            p.OnSomethingHappened("What happend?");
        }
    }
}
