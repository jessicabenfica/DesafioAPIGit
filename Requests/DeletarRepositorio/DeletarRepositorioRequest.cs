using RestSharp;
using DesafioAPIGit.Bases;
using DesafioAPIGit.Helpers;
using System.IO;
using System.Text;

namespace DesafioAPIGit.Requests
{
    public class DeletarRepositorioRequest : RequestBase
    {
        public DeletarRepositorioRequest(string username, string repo)
        {
            requestService = "/repos/{username}/{repo}";
            method = Method.DELETE;
            parameters.Add("username", username);
            parameters.Add("repo", repo);

        }
    }

}
