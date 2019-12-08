using RestSharp;
using DesafioAPIGit.Bases;
using DesafioAPIGit.Helpers;
using System.IO;
using System.Text;
using System;

namespace DesafioAPIGit.Requests
{
    public class CriarAutorizacaoRequest : RequestBase
    {
        public CriarAutorizacaoRequest()
        {
            requestService = "/authorizations";
            method = Method.POST;
            httpBasicAuthenticator = true;
        }

        public void setJsonBody(string scopes, string note)
        {
            jsonBody = File.ReadAllText(GeneralHelpers.ReturnProjectPath() + "Jsons/CriarAutorizacao/CriarAutorizacaoGitJson.json", Encoding.UTF8);
            jsonBody = jsonBody.Replace("$scopes", scopes).Replace("$note", note);                                                                                     

        }

    }
}
