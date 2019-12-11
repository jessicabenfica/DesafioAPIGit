using RestSharp;
using DesafioAPIGit.Bases;
using DesafioAPIGit.Helpers;
using System.IO;
using System.Text;

namespace DesafioAPIGit.Requests
{
    public class DeletarAutorizacaoRequest : RequestBase
    {
        public DeletarAutorizacaoRequest(string authorization_id)
        {
            requestService = "/authorizations/{authorization_id}";
            method = Method.DELETE;
            parameters.Add("authorization_id", authorization_id);
        }
    }

}
