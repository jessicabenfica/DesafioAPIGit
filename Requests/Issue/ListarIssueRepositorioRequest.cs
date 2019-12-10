using RestSharp;
using DesafioAPIGit.Bases;
using DesafioAPIGit.Helpers;
using System.IO;
using System.Text;

namespace DesafioAPIGit.Requests
{
    public class ListarIssueRepositorioRequest : RequestBase
    {
        public ListarIssueRepositorioRequest(string username, string repo)
        {
            requestService = "repos/{username}/{repo}/issues";
            method = Method.GET;
            parameters.Add("username", username);
            parameters.Add("repo", repo);

        }
    }

}
