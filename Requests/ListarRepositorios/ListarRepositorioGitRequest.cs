using RestSharp;
using DesafioAPIGit.Bases;
using DesafioAPIGit.Helpers;
using System.IO;
using System.Text;

namespace DesafioAPIGit.Requests
{
    public class ListarRepositorioGitRequest : RequestBase
    {
        public ListarRepositorioGitRequest(string username)
        {
            requestService = "users/{username}/repos";
            method = Method.GET;
            parameters.Add("username", username);
        }
}

}
