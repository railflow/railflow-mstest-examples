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

Here is an example showcasing markers propagation logic:

```c#
TBD
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
TBD
```
