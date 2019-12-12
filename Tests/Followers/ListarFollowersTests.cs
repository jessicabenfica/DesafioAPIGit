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
    public class ListarFollowersTests : TestBase
    {
        [Test]
        public void ListarSeguidores()
        {

            #region Parameters
            string username = "jessicabenfica";
            #endregion

            #region Expected Result      
            string statusCodeEsperado = "OK";
            string followers_url = "https://api.github.com/users/lucasssartori";
            string login = " ";
            #endregion

            ListarFollowersRequest listarFollowersRequest  = new ListarFollowersRequest(username);                     
            IRestResponse<dynamic> response = listarFollowersRequest.ExecuteRequest();

            Assert.Multiple(() =>
            {
                Assert.AreEqual(statusCodeEsperado, response.StatusCode.ToString());
                Assert.AreNotEqual(login, response.Data.ToString());
                Console.WriteLine(followers_url);
                Console.WriteLine(login);

            });
        }

    }
}