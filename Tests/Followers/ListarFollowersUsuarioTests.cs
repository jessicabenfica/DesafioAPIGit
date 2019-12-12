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
    public class ListarFollowersUsuarioTests : TestBase
    {
        [Test]
        public void ListarSeguidoresUsuario()
        {

            #region Parameters
            string username = "lucasssartori";
            #endregion

            #region Expected Result      
            string statusCodeEsperado = "OK";
            string followers_url = "https://api.github.com/users/jessicabenfica/followers";
            string login = " ";
            #endregion

            ListarFollowersUsuarioRequest listarFollowersUsuarioRequest  = new ListarFollowersUsuarioRequest(username);                     
            IRestResponse<dynamic> response = listarFollowersUsuarioRequest.ExecuteRequest();

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