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
    public class CriarAutorizacaoTests : TestBase
    {
        [Test]
        public void CriaValidaAutorizacao()
        {

            #region Parameters
            string scopes = "public_repo";
            string note = "test2";
            #endregion

            #region Expected Result      
            string statusCodeEsperado = "Created";
            string token = " ";
            #endregion

            CriarAutorizacaoRequest criarAutorizacaoGitRequest  = new CriarAutorizacaoRequest();
            criarAutorizacaoGitRequest.setJsonBody(scopes, note);
                       
            IRestResponse<dynamic> response = criarAutorizacaoGitRequest.ExecuteRequest();

            Assert.Multiple(() =>
            {
                Assert.AreEqual(statusCodeEsperado, response.StatusCode.ToString());
                Assert.AreNotEqual(token, response.Data.ToString(" "));
                Console.WriteLine(token);

            });
        }

    }
}