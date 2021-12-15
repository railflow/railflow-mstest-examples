# Railflow.MSTest.TestRail.Reporter Examples

Examples on how to use [Railflow.MSTest.TestRail.Reporter](https://www.nuget.org/packages/Railflow.MSTest.TestRail.Reporter/) package with MSTest tests for TestRail integration.



Installing (NuGet)
============

Use this command to add the package to your test project.

```powershell
Install-Package Railflow.MSTest.TestRail.Reporter
```



Writing tests
=============



## Using RailflowTestClassAttribute / RailflowTestMethodAttribute

Apply custom attributes to test methods/classes to mark them with TestRail metadata. See [railflow-mstest](https://github.com/railflow/railflow-mstest#railflowmstesttestrailreporter)  for more info.

Here is an example test:

```c#
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
```



# Running tests

Use [dotnet CLI](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-test) to run your tests and generate output XML.

E.g.

```powershell
dotnet test --logger "trx;LogFileName=TestResults.xml"
```



XML output
===========

Here is the output of tests from examples above (<u>non-relevant pieces are skipped</u>).

```xml
<Results>
  <UnitTestResult testName="TestMethod1">
    <Output>
      <StdOut>railflow-markers:{"ClassMarkers":{"Title":"class-title","CaseFields":["class-field-1=value1","class-field-2=value2"]},"MethodMarkers":{"CaseFields":["func-field-1=value1","func-field-2=value2"]}}</StdOut>
    </Output>
  </UnitTestResult>
  <UnitTestResult testName="TestMethod2">
    <Output>
      <StdOut>railflow-markers:{"ClassMarkers":{"Title":"class-title","CaseFields":["class-field-1=value1","class-field-2=value2"]},"MethodMarkers":{"TestRailIds":[1,2,3]}}</StdOut>
    </Output>
  </UnitTestResult>
  <UnitTestResult testName="TestMethod3">
    <Output>
      <StdOut>railflow-markers:{"ClassMarkers":{"Title":"class-title","CaseFields":["class-field-1=value1","class-field-2=value2"]},"MethodMarkers":{}}</StdOut>
    </Output>
  </UnitTestResult>
</Results>
```
