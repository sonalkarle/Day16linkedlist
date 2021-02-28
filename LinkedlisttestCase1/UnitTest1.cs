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

        /// <summary>
        /// TC-2 Test Linked List for Add method
        /// </summary>
        [Test]
        public void Given3Number_WhenAddedToLinkedList_ShouldBeAddedToTop_By_checking_Headposition()
        {
            
            LinkedList List = new LinkedList();
            List.AddNodeAtStart(70);
            List.AddNodeAtStart(30);
            List.AddNodeAtStart(56);
            List.Display();
            int head = 56;
            
            Assert.AreEqual(head, List.head.data);
            
           
        }

        /// <summary>
        /// TC-3 Test Linked List for append method
        /// </summary>
        [Test]
        public void Given3Number_WhenAddedToLinkedList_ShouldBeAddedToEnd()
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