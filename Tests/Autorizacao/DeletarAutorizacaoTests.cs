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
    public class DeletarAutorizacaoTests : TestBase
    {
        [Test]
        public void DeletarAutenticacao()
        {

            #region Parameters
            string authorization_id = "";
            #endregion



            #region Expected Result     
            string statusCodeEsperado = "No Content";
            #endregion


            DeletarAutorizacaoRequest deletarAutorizacaoRequest = new DeletarAutorizacaoRequest(authorization_id);
            IRestResponse<dynamic> response = deletarAutorizacaoRequest.ExecuteRequest();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(statusCodeEsperado, response.StatusCode.ToString());


            });
        }
    }

}