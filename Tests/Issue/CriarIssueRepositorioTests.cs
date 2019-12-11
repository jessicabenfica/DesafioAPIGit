using DesafioAPIGit.Requests;
using FluentAssertions;
using NUnit.Framework;
using RestSharp;
using DesafioAPIGit.Bases;
using DesafioAPIGit.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioAPIGit.Tests
{
    [TestFixture]
    public class CriarIssueRepositorioTests : TestBase
    {
        [Test]
        public void CriaIssueRepositorio()
        {

            #region Parameters
            string username = "jessicabenfica";
            string repo = "Hello-World";

            string title = "Found a bug";
            string body = "I'm having a problem with this.";
            string assignees = "jessicabenfica";
            string milestone = "1";
            string labels = "bug";

            #endregion

            #region Expected Result      
            string statusCodeEsperado = "Created";
            string location = " ";

            #endregion

            CriarIssueRepositorioGitRequest criarIssueRepositorioGitRequest  = new CriarIssueRepositorioGitRequest(username,repo);
            criarIssueRepositorioGitRequest.setJsonBody(title, body, assignees, milestone, labels);
                       
            IRestResponse<dynamic> response = criarIssueRepositorioGitRequest.ExecuteRequest();

            Assert.Multiple(() =>
            {
                Assert.AreEqual(statusCodeEsperado, response.StatusCode.ToString());
                Assert.AreNotEqual(location, response.Data.ToString());
            //  Assert.AreNotEqual(node_id, response.Data.ToString());

            });
        }

    }
}