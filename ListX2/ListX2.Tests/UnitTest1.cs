using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitListX;

namespace ListX2.Tests
{
    [TestClass]
    public class UnitListX
    {

        [TestMethod]
        public void AddNormalFirst()
        {

            ListX mylist = new ListX();
            mylist.Add("Object 1");
            mylist.Add("Object 2");
            mylist.Add("Object 3");


            object y = mylist.Get(0);
            Assert.AreEqual("Object 1", y);
        }

        [TestMethod]
        public void AddNormalMiddle()
        {

            ListX mylist = new ListX();
            mylist.Add("Object 1");
            mylist.Add("Object 2");
            mylist.Add("Object 3");
            mylist.Add("Object 4");


            object y = mylist.Get(2);
            Assert.AreEqual("Object 3", y);
        }

        [TestMethod]
        public void AddNormalLast()
        {

            ListX mylist = new ListX();
            mylist.Add("Object 1");
            mylist.Add("Object 2");
            mylist.Add("Object 3");
            mylist.Add("Object 4");


            object y = mylist.Get(3);
            Assert.AreEqual("Object 4", y);
        }



        [TestMethod]
        public void TestLength()
        {
            ListX mylist = new ListX();
            mylist.Add(0, "Object 1");
            mylist.Add(1, "Object 2");
            mylist.Add(2, "Object 3");
            mylist.Add(8, "Object 4");
            mylist.Add(11, "Object 5");

            object x = mylist.Length();
            Assert.AreEqual(5, x);
        }

        [TestMethod]
        public void TestAddWithIndexFirst()
        {
            ListX mylist = new ListX();
            mylist.Add(0, "Object 1");
            mylist.Add(1, "Object 2");
            mylist.Add(2, "Object 3");
            mylist.Add(3, "Object 4");
            mylist.Add(4, "Object 5");

            object y = mylist.Get(0);
            Assert.AreEqual("Object 1", y);
        }

        [TestMethod]
        public void TestAddWithIndexMiddle()
        {
            ListX mylist = new ListX();
            mylist.Add(0, "Object 1");
            mylist.Add(1, "Object 2");
            mylist.Add(2, "Object 3");
            mylist.Add(3, "Object 4");
            mylist.Add(4, "Object 5");

            object y = mylist.Get(2);
            Assert.AreEqual("Object 3", y);
        }

        [TestMethod]
        public void TestAddWithIndexLast()
        {
            ListX mylist = new ListX();
            mylist.Add(0, "Object 1");
            mylist.Add(1, "Object 2");
            mylist.Add(2, "Object 3");
            mylist.Add(3, "Object 4");
            mylist.Add(4, "Object 5");

            object y = mylist.Get(4);  
            Assert.AreEqual("Object 5", y);
        }


        [TestMethod]
        public void TestGetFirst()
        {
            ListX mylist = new ListX();
            mylist.Add("Object 1");
            mylist.Add("Object 2");
            mylist.Add("Object 3");
            mylist.Add("Object 4");

            object x = mylist.Get(0);

            Assert.AreEqual("Object 1", x);
        }

        [TestMethod]
        public void TestGetMiddle()
        {
            ListX mylist = new ListX();
            mylist.Add("Object 1");
            mylist.Add("Object 2");
            mylist.Add("Object 3");

            object x = mylist.Get(1);

            Assert.AreEqual("Object 2", x);
        }

        [TestMethod]
        public void TestGetLast()
        {
            ListX mylist = new ListX();
            mylist.Add("Object 1");
            mylist.Add("Object 2");
            mylist.Add("Object 3");
            mylist.Add("Object 4");
            mylist.Add("Object 5");

            object x = mylist.Get(4);

            Assert.AreEqual("Object 5", x);
        }

        [TestMethod]
        public void TestRemoveNodeFirst()
        {
            ListX mylist = new ListX();
            mylist.Add("Object 1");
            mylist.Add("Object 2");
            mylist.Add("Object 3");
            mylist.Add("Object 4");

            object x = mylist.Remove(0);
            object z = mylist.Length(mylist);

            Assert.AreEqual("Object 1", x);
            Assert.AreEqual(3, z);

        }

        [TestMethod]
        public void TestRemoveNodeMiddle()
        {
            ListX mylist = new ListX();
            mylist.Add("Object 1");
            mylist.Add("Object 2");
            mylist.Add("Object 3");
            mylist.Add("Object 4");

            object x = mylist.Remove(2);
            object z = mylist.Length(mylist);

            Assert.AreEqual("Object 3", x);
            Assert.AreEqual(3, z);
        }

        [TestMethod]
        public void TestRemoveNodeLast()
        {
            ListX mylist = new ListX();
            mylist.Add("Object 1");
            mylist.Add("Object 2");
            mylist.Add("Object 3");
            mylist.Add("Object 4");

            object x = mylist.Remove(3);
            object z = mylist.Length(mylist);

            Assert.AreEqual("Object 4", x);
            Assert.AreEqual(3, z);

        }

    }
}
