using NUnit.Framework;
using DesafioAPIGit.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesafioAPIGit.Flows;

namespace DesafioAPIGit.Bases
{
    public class TestBase
    {
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            TokenFlows.GerarTokenGitHub();
            ExtentReportHelpers.CreateReport();                 
        }

        [SetUp]
        public void SetUp()
        {
            ExtentReportHelpers.AddTest();
        //  TokenFlows.GerarTokenGitHub();
        }

        [TearDown]
        public void TearDown()
        {
            ExtentReportHelpers.AddTestResult();
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
       //   TokenFlows.DeletaTokenGitHub();
            ExtentReportHelpers.GenerateReport();
        }
    }
}
