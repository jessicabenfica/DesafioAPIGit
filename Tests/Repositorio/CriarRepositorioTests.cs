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
    public class CriarRepositorioTests : TestBase
    {
        [Test]
        public void CriaRepositorio()
        {

            #region Parameters
            string name = "Hello-World-1";
            string description = "This is your first repository";
            string homepage = "https://github.com";
            string axprivate = "false";
            string has_issues = "true";
            string has_projects = "true";
            string has_wiki = "true";

            #endregion

            #region Expected Result      
            string statusCodeEsperado = "Created";
            string name_id = "Hello-World-1";
            string node_id = " ";

            #endregion

            CriarRepositorioGitRequest criarRepositorioGitRequest  = new CriarRepositorioGitRequest();
            criarRepositorioGitRequest.setJsonBody(name, description, homepage, axprivate, has_issues, has_projects, has_wiki);
                       
            IRestResponse<dynamic> response = criarRepositorioGitRequest.ExecuteRequest();

            Assert.Multiple(() =>
            {
                Assert.AreEqual(statusCodeEsperado, response.StatusCode.ToString());
                Assert.AreEqual(name_id, response.Data.name.ToString());
                Assert.AreNotEqual(node_id, response.Data.ToString());
            });
        }

    }
}