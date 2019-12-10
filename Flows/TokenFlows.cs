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
            string note = "test1";
         // string note = "test1" + GeneralHelpers.ReturnStringWithRandomNumbers(3); -> Substituir todos os campos para vir automaticamente (ir gerando token em ordem).
            string token = string.Empty;
            #endregion

            #region Expected Result      
            string statusCodeEsperado = "Created";

            #endregion

            CriarAutorizacaoRequest criarAutorizacaoGitRequest = new CriarAutorizacaoRequest();
            criarAutorizacaoGitRequest.setJsonBody(scopes, note);

            IRestResponse<dynamic> response = criarAutorizacaoGitRequest.ExecuteRequest();

            Assert.AreEqual(statusCodeEsperado, response.StatusCode.ToString());

            Assert.Multiple(() =>
            {
                token = response.Data.token.ToString();
           //   GeneralHelpers.AtualizaVariavelToken(token);
                Console.WriteLine(token);
            });
        }

    }
}
