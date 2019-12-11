using RestSharp;
using DesafioAPIGit.Bases;
using DesafioAPIGit.Helpers;
using System.IO;
using System.Text;

namespace DesafioAPIGit.Requests
{
    public class ListarProjetosRepositorioRequest : RequestBase
    {
        public ListarProjetosRepositorioRequest(string username)
        {
            requestService = "/users/{username}/projects";
            method = Method.GET;
            parameters.Add("username", username);

        }
    }

}
