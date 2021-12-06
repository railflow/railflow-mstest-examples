using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Railflow.MSTest.TestRail.Reporter.Example
{
    [RailflowTestClass(Title = "class-title", CaseFields = new[] { "class-field-1=value1", "class-field-2=value2" })]
    public class RailflowAttributesExample
    {
        [RailflowTestMethod(CaseFields = new[] { "func-field-1=value1", "func-field-2=value2" })]
        public void TestMethod1()
        {
        }

        [RailflowTestMethod(TestRailIds = new[] { 1, 2, 3 })]
        public void TestMethod2()
        {
        }

        [TestMethod]
        public void TestMethod3()
        {
        }
    }
}
