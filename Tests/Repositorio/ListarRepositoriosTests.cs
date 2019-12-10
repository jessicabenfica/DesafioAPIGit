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
    public class ListarRepositoriosTests : TestBase
    {
        [Test]
        public void ListarRepositorios()
        {

            #region Parameters
            string username = "jessicabenfica";
            #endregion

            #region Expected Result      
            string statusCodeEsperado = "OK";
         // string type = "all";
         // string sort = "full_name";
         // string direction = "full_name";
            #endregion

            ListarRepositorioGitRequest listarRepositorioGitRequest  = new ListarRepositorioGitRequest(username);                     
            IRestResponse<dynamic> response = listarRepositorioGitRequest.ExecuteRequest();

            Assert.Multiple(() =>
            {
                Assert.AreEqual(statusCodeEsperado, response.StatusCode.ToString());
          //    Assert.AreEqual(type, response.Data.type.ToString());
          //    Assert.AreEqual(sort, response.Data.sort.ToString());
          //    Assert.AreEqual(direction, response.Data.direction.ToString());
            });
        }

    }
}