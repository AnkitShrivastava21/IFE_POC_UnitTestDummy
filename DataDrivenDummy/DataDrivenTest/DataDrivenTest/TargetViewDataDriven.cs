using System;
using System.Data;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataDrivenTest
{
    [TestClass]
    public class TargetViewDataDriven
    {
        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

        [DeploymentItem("TestData.csv")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\TestData.csv", "TestData#csv",
         DataAccessMethod.Sequential)]

        [TestMethod]
        public void DataDrive()
        {
            string CorpID = Convert.ToString(TestContext.DataRow[0].ToString());
            string Name = Convert.ToString(TestContext.DataRow[1].ToString());
            Console.WriteLine("Datasource Corp ID "  + CorpID);
            Console.WriteLine("Datasource Name " + Name);

            Trace.WriteLine("Input Corp ID " + CorpID);
            Trace.WriteLine("Input Name " + Name);
        }
    }
}
