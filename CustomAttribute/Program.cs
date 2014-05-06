/*
 * Example of modifying C# attributes at runtime
 */
using System;

namespace CustomAttribute
{
    class Program
    {
        static void Main(string[] args)
        {
            /* instantiate object with original attribute index=55 */
            var p = new SampleClass();
            Console.WriteLine("p Attr: " + p.getAttribute());
            /* change attribute value */
            p.setSpecialAttribute(10);
            Console.WriteLine("p Attr: " + p.getAttribute());

            /* instantiate a new object, attribute value remains changed */
            var q = new SampleClass();
            Console.WriteLine("q Attr: " + q.getAttribute());

            Console.ReadLine();
        }
    }
}
