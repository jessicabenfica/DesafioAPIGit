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
    public class ListarIssueRepositoriosTests : TestBase
    {
        [Test]
        public void ListarIssueRepositorios()
        {

            #region Parameters
            string username = "jessicabenfica";
            string repo = "Teste-Delete-Repo";
            #endregion

            #region Expected Result      
            string statusCodeEsperado = "OK";
            #endregion

            ListarIssueRepositorioRequest listarIssueRepositorioRequest  = new ListarIssueRepositorioRequest(username,repo);                     
            IRestResponse<dynamic> response = listarIssueRepositorioRequest.ExecuteRequest();

            Assert.Multiple(() =>
            {
                Assert.AreEqual(statusCodeEsperado, response.StatusCode.ToString());
        //      Assert.AreEqual(link, response.Data.link.ToString());
            });
        }

    }
}