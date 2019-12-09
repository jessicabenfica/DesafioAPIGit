using RestSharp;
using DesafioAPIGit.Bases;
using DesafioAPIGit.Helpers;
using System.IO;
using System.Text;

namespace DesafioAPIGit.Requests
{
    public class CriarIssueRepositorioGitRequest : RequestBase
    {
        public CriarIssueRepositorioGitRequest(string username, string repo)
        {
            requestService = "/repos/{username}/{repo}/issues";
            method = Method.POST;
            parameters.Add("username", username);
            parameters.Add("repo", repo);
        }

        public void setJsonBody(string title, string body, string assignees, string milestone, string labels)
        {
           jsonBody = File.ReadAllText(GeneralHelpers.ReturnProjectPath() + "Jsons/CriarIssueRepositorio/CriarIssueRepositorioGitJson.json", Encoding.UTF8);
           jsonBody = jsonBody.Replace("$title", title).Replace("$body", body).Replace("$assignees", assignees).Replace("$milestone", milestone).Replace("$labels", labels);
    }
    }
}
