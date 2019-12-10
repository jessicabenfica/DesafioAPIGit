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
    public class DeletarRepositoriosTests : TestBase
    {
        [Test]
        public void DeletarRepositorio()
        {

            #region Parameters
            string username = "jessicabenfica";
            string repo = "Teste-Delete-Repo";
            #endregion

            #region Expected Result      
            string statusCodeEsperado = "Forbidden";  //  statusCodeEsperado = "No Content"/ "Forbidden"(https://developer.github.com/v3/repos/#delete-a-repository) Verificar permissão no token gerado;
            #endregion

            DeletarRepositorioRequest deletarRepositorioRequest  = new DeletarRepositorioRequest(username,repo);                     
            IRestResponse<dynamic> response = deletarRepositorioRequest.ExecuteRequest();

            Assert.Multiple(() =>
            {
                Assert.AreEqual(statusCodeEsperado, response.StatusCode.ToString());
            });
        }

    }
}