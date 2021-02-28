using NUnit.Framework;
using Linkedlist;

namespace NUnitTestProject
{

    public class Tests
    {
        ///<summary>
        ///TC1: Test link list method
        ///</summary>
        [Test]
        public void Create_simplelinkedlist_Checkthe_headiscorrectposition()
        {
            LinkedList List = new LinkedList();
            List.Append(56);
            List.Append(30);
            List.Append(70);
            List.Display();
            int head = 56;

            Assert.AreEqual(head, List.head.data);

        }

       
        


    }
}