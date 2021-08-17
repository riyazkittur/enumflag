using System;

namespace EnumFlags
{
    class Account
    {
        
        static void Main(string[] args)
        {

            Console.WriteLine(Access.Editor.HasFlag(Access.Delete));
                 Console.ReadKey();
            
          
           
           
        }
    }
}
