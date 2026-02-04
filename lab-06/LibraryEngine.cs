using System;
using System.Collections.Generic;
using System.Text;

namespace lab_06
{

    internal delegate string BookDelegate(Book B);

    internal class LibraryEngine
    {
        public static void ProcessBooks(List<Book> bList
  , BookDelegate fPtr)
        {
            foreach (Book B in bList)
            {
                Console.WriteLine(fPtr(B));
            }
        }

 //       public static void ProcessBooks(List<Book> bList
 //, Func<Book,String> fPtr)
 //       {
 //           foreach (Book B in bList)
 //           {
 //               Console.WriteLine(fPtr(B));
 //           }
 //       }
    }
}
