using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_Assignment
{
    class program1
    {
        public static void Main(string[] args)
        {
            #region UC2
            uc2_AddingElementToLinkList list = new uc2_AddingElementToLinkList();
            list.AddToFront(70);
            list.AddToFront(30);
            list.AddToFront(56);
            list.PrintList();
            #endregion

            Console.WriteLine("---------------------------------------------------------------------");

            #region UC3
            uc3_AppendingElementToLinkList Append = new uc3_AppendingElementToLinkList();
            Append.AddToEnd(56);
            Append.AddToEnd(30);
            Append.AddToEnd(70);
            Append.PrintList();
            #endregion

            Console.WriteLine("---------------------------------------------------------------------");

            #region UC4
            uc4_AddEleINBetween Betwn = new uc4_AddEleINBetween();
            Betwn.AddToEnd(56);
            Betwn.AddToEnd(70);
            Betwn.AddInBet(2, 30);
            Betwn.PrintList();
            #endregion

            Console.WriteLine("---------------------------------------------------------------------");

            #region UC5
            uc5_DeleteEleFromLinkList Del = new uc5_DeleteEleFromLinkList();
            Del.AddToEnd(56);
            Del.AddToEnd(30);
            Del.AddToEnd(70);
            Del.PopFirst();
            Del.PrintList();
            #endregion

            Console.WriteLine("---------------------------------------------------------------------");

            #region UC6
            uc6_DeleteLastElement DelLast = new uc6_DeleteLastElement();
            DelLast.AddToEnd(56);
            DelLast.AddToEnd(30);
            DelLast.AddToEnd(70);
            DelLast.PopLast();
            DelLast.PrintList();
            #endregion

            Console.ReadLine();
            
        }
    }
}