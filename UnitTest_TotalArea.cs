using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;

namespace UnitTestProject1
{
    /// <summary>
    /// UnitTest_TotalArea 的摘要描述
    /// </summary>
    [TestClass]
    public class UnitTest_TotalArea
    {
        [TestMethod]
        public void TestFalseType()
        {
            //Arrange 事情準備

            var TestTotalArea = new TestTotalArea();
            //Act 執行呼叫被測試程式
            var actual = TestTotalArea.output("XXX", 1, 1, 1, 1, 1);
            //Assert驗證結課
            Assert.AreEqual("錯誤圖型", actual);
        }

        [TestMethod]
        public void TestFalseSquare()
        {
            //Arrange 事情準備

            var TestTotalArea = new TestTotalArea();
            //Act 執行呼叫被測試程式
            var actual = TestTotalArea.output("Square", 0, 1, 1,1,1);
            //Assert驗證結課
            Assert.AreEqual("資料錯誤，無法計算面積", actual);
        }

        [TestMethod]
        public void TestTrueSquare()
        {
            //Arrange 事情準備

            var TestTotalArea = new TestTotalArea();
            //Act 執行呼叫被測試程式
            var actual = TestTotalArea.output("Square", 2, 1, 1, 1, 1);
            //Assert驗證結課
            Assert.AreEqual("4", actual);
        }


        [TestMethod]
        public void TestFalseRectangle()
        {
            //Arrange 事情準備

            var TestTotalArea = new TestTotalArea();
            //Act 執行呼叫被測試程式
            var actual = TestTotalArea.output("Rectangle", 0, 0, 1, 1, 1);
            //Assert驗證結課
            Assert.AreEqual("資料錯誤，無法計算面積", actual);
        }

        [TestMethod]
        public void TestTrueRectangle()
        {
            //Arrange 事情準備

            var TestTotalArea = new TestTotalArea();
            //Act 執行呼叫被測試程式
            var actual = TestTotalArea.output("Rectangle", 2, 3, 1, 1, 1);
            //Assert驗證結課
            Assert.AreEqual("6", actual);
        }


        [TestMethod]
        public void TestFalseCircle()
        {
            //Arrange 事情準備

            var TestTotalArea = new TestTotalArea();
            //Act 執行呼叫被測試程式
            var actual = TestTotalArea.output("Circle", 0, 0, 0, 0, 1);
            //Assert驗證結課
            Assert.AreEqual("資料錯誤，無法計算面積", actual);
        }

        [TestMethod]
        public void TestTrueCircle()
        {
            //Arrange 事情準備

            var TestTotalArea = new TestTotalArea();
            //Act 執行呼叫被測試程式
            var actual = TestTotalArea.output("Circle", 0, 0, 3, 1, 1);
            //Assert驗證結課
            Assert.AreEqual("3.14", actual);
        }


        [TestMethod]
        public void TestFalseTriangle()
        {
            //Arrange 事情準備

            var TestTotalArea = new TestTotalArea();
            //Act 執行呼叫被測試程式
            var actual = TestTotalArea.output("Triangle", 0, 0, 0, 1, 0);
            //Assert驗證結課
            Assert.AreEqual("資料錯誤，無法計算面積", actual);
        }

        [TestMethod]
        public void TestTrueTriangle()
        {
            //Arrange 事情準備

            var TestTotalArea = new TestTotalArea();
            //Act 執行呼叫被測試程式
            var actual = TestTotalArea.output("Triangle", 1, 0, 0, 1, 2);
            //Assert驗證結課
            Assert.AreEqual("1", actual);
        }

        private TestContext testContextInstance;

        /// <summary>
        ///取得或設定提供目前測試回合
        ///的相關資訊與功能的測試內容。
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region 其他測試屬性
        //
        // 您可以使用下列其他屬性撰寫您的測試: 
        //
        // 執行該類別中第一項測試前，使用 ClassInitialize 執行程式碼
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // 在類別中的所有測試執行後，使用 ClassCleanup 執行程式碼
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // 在執行每一項測試之前，先使用 TestInitialize 執行程式碼 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // 在執行每一項測試之後，使用 TestCleanup 執行程式碼
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestMethod1()
        {
            //
            // TODO:  在此加入測試邏輯
            //
        }
    }
}
