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
        ///<summary>
        ///TC4: Check wheather element added in middle or not
        /// </summary>
        [Test]
            public void Check_wheather40_isaddedinlistornot ()
        {
            LinkedList newlist = new LinkedList();
            newlist.Append(56);
            newlist.Append(70);
            newlist.AddNodeAfterNode(30, 56);
            bool expected = true;
            bool actual = newlist.Search(30);
            Assert.AreEqual(expected, actual);

        }



        /// <summary>
        /// TC-5:Check first Node is deleted or not
        /// </summary>
        [Test]
        public void Given3numberlist_delete_firstnumber ()
        {
            LinkedList List = new LinkedList();
            List.Append(56);
            List.Append(30);
            List.Append(70);
           
            List.Display();
            List.DeleteNodeAtFirst();
            List.Display();
            int head = 30;
            Assert.AreEqual(head, List.head.data);
        }

        /// <summary>
        /// Tc-6:Check last Node is delete or not
        /// </summary>
        [Test]
        public void Given3numberlist_delete_lastnumber()
        {
            LinkedList List = new LinkedList();
            List.Append(56);
            List.Append(30);
            List.Append(70);
            List.Display();
            List.DeleteNodeAtLast();
            bool expected = false;
            bool actual = List.Search(70);
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// TC7:Search node is present or not
        /// </summary>
        [Test]
        public void Givenlist_finddata30_fromlist()
        {
            LinkedList staticlinkedList = new LinkedList();
            Node node56 = new Node(56);
            Node node30 = new Node(30);
            Node node70 = new Node(70);
            node56.next = node30;
            node30.next = node70;
            staticlinkedList.head = node56;
            bool actual = staticlinkedList.Search(30);
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }
       


    }
}