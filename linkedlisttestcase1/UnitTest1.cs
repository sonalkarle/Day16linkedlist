using Linkedlist;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace linkedlisttestcase1
{
    public class Tests
    {

        [SetUp]
        public void Setup()
        {
        }

      
        /// <summary>
        /// TC-2 Test Linked List
        /// </summary>
        [Test]
        public void Given3Number_WhenAddedToLinkedList_ShouldBeAddedToTop()
        {
           
            LinkedList list = new LinkedList();
            list.AddNodeAtStart(70);
            list.AddNodeAtStart(30);
            list.AddNodeAtStart(56);
            list.Display();
            bool result = list.head.Equals(56) &&
                             list.head.getNext().Equals(30) &&
                             list.tail.Equals(70);
            Assert.True(result);
        }

    }
}