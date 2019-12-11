using DesafioAPIGit.Helpers;
using DesafioAPIGit.Requests;
using NUnit.Framework;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioAPIGit.Flows
{
    public class TokenFlows
    {
        public static void GerarTokenGitHub()
        {

            #region Parameters
            string scopes = "public_repo";
            string note = "test21";

            string token = string.Empty;
            string authorizationId = string.Empty;
            #endregion

            #region Expected Result      
            string statusCodeEsperado = "Created";

            #endregion

            CriarAutorizacaoRequest criarAutorizacaoGitRequest = new CriarAutorizacaoRequest();
            criarAutorizacaoGitRequest.setJsonBody(scopes, note);

            IRestResponse<dynamic> response = criarAutorizacaoGitRequest.ExecuteRequestTest();

            Assert.AreEqual(statusCodeEsperado, response.StatusCode.ToString());

            Assert.Multiple(() =>
            {
                token = response.Data.token.ToString();
                authorizationId = response.Data.id.ToString();
                GeneralHelpers.AtualizaVariavelToken(token);
                GeneralHelpers.AtualizaAuthorizationId(authorizationId);
                Console.WriteLine(token);
            });
        }

        public static void DeletaTokenGitHub()
        {

            #region Parameters
            string authorizationId = Properties.Settings.Default.AUTHORIZATION_ID;
            #endregion

            #region Expected Result      
            string statusCodeEsperado = "NoContent";

            #endregion
            DeletarAutorizacaoRequest deletarAutorizacaoRequest = new DeletarAutorizacaoRequest(authorizationId);

            IRestResponse<dynamic> response = deletarAutorizacaoRequest.ExecuteRequestTest();

            Assert.AreEqual(statusCodeEsperado, response.StatusCode.ToString());
        }
    }
}
