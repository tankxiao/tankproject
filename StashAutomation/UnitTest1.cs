using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using System.Threading;
using System.Net;

namespace StashAutomation
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        public UnitTest1()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
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

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestMethod1()
        {


           // string stashPath = @"C:\Users\xiaoj\Stash\StashBuild\mozy-stash_0.13.2241.exe";
           // Process p = Process.Start(stashPath);


            //Thread.Sleep(20000);

            StashInstallUI install = new StashInstallUI();

            //AutomationBuild.ClickButton(install.NextButton);


            //AutomationBuild.Check(install.AcceptChb);

            //Thread.Sleep(2000);

            //AutomationBuild.ClickButton(install.NextButton);


            //AutomationBuild.ClickButton(install.NextButton);
            //AutomationBuild.ClickButton(install.InstallButton);

            //Thread.Sleep(15000);

            AutomationBuild.ClickButton(install.FinishButton);

        }


        [TestMethod]
        public void TestMethod2()
        {

            NetworkCredential nc = new NetworkCredential("xiaoj@vmware.com", "test1234");

            Helper.HttpHelper.networkCredential = nc;
 
            string url = "http://10.29.110.181/namedObjects/5192?includeObjectId=1&ExcludeDeletedFiles=1";
            string response =  Helper.HttpHelper.GetResponse(url, "GET", null);


           // Helper.HttpHelper.xTritonObjectCredential = "Qn1K+7qwc5oDgvnkYK1v3yQpP1Jssl8HIg==";

            //string objectID = "http://10.29.110.181/objects/5192/a4a37fd7b55d642561a6a81f9d0954f57c38b02f";

           // string objects = Helper.HttpHelper.GetResponseFile(objectID, "GET", null);
        
        }

        [TestMethod]
        public void ProductionTest()
        {
            NetworkCredential nc = new NetworkCredential("huoli_28@hotmail.com", "xiaojia0818");

            Helper.HttpHelper.networkCredential = nc;

            string url = "https://ut3.triton.mozy.com/namedObjects/5043455?includeObjectId=1&ExcludeDeletedFiles=1";
            string response = Helper.HttpHelper.GetResponse(url, "GET", null);


            Thread.Sleep(50000);
        }

    }
}
