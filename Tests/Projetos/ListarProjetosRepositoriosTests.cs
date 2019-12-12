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
    public class ListarProjetosRepositoriosTests : TestBase
    {
        [Test]
        public void ListarProjetos()
        {

            #region Parameters
            string username = "jessicabenfica";
            #endregion

            #region Expected Result      
            string statusCodeEsperado = "OK";
            string name = "Teste-Projeto";

            #endregion

            ListarProjetosRepositorioRequest listarProjetosRepositorioRequest  = new ListarProjetosRepositorioRequest(username);                     
            IRestResponse<dynamic> response = listarProjetosRepositorioRequest.ExecuteRequest();

            Assert.Multiple(() =>
            {
                Assert.AreEqual(statusCodeEsperado, response.StatusCode.ToString());
                Assert.AreEqual(name, response.Data.name.ToString());
                Console.WriteLine(name);
            });
        }

    }
}