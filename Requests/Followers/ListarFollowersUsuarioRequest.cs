using RestSharp;
using DesafioAPIGit.Bases;
using DesafioAPIGit.Helpers;
using System.IO;
using System.Text;

namespace DesafioAPIGit.Requests
{
    public class ListarFollowersUsuarioRequest : RequestBase
    {
        public ListarFollowersUsuarioRequest(string username)
        {
            requestService = "/users/{username}/following";
            method = Method.GET;
            parameters.Add("username", username);
        }
    }

}
