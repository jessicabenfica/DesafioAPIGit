using RestSharp;
using DesafioAPIGit.Bases;
using DesafioAPIGit.Helpers;
using System.IO;
using System.Text;

namespace DesafioAPIGit.Requests
{
    public class ListarFollowersRequest : RequestBase
    {
        public ListarFollowersRequest(string username)
        {
            requestService = "/users/{username}/followers";
            method = Method.GET;
            parameters.Add("username", username);
        }
    }

}
