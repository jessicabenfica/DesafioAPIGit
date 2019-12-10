using RestSharp;
using DesafioAPIGit.Bases;
using DesafioAPIGit.Helpers;
using System.IO;
using System.Text;

namespace DesafioAPIGit.Requests
{
    public class CriarRepositorioGitRequest : RequestBase
    {
        public CriarRepositorioGitRequest()
        {
            requestService = "/user/repos";
            method = Method.POST;
            headers.Add("Authorization", "Bearer " + Properties.Settings.Default.TOKEN);
        }

        public void setJsonBody(string name, string description, string homepage, string axprivate, string has_issues, string has_projects, string has_wiki)
        {
           jsonBody = File.ReadAllText(GeneralHelpers.ReturnProjectPath() + "Jsons/Repositorio/CriarRepositorioGitJson.json", Encoding.UTF8);
           jsonBody = jsonBody.Replace("$name", name).Replace("$description", description).Replace("$homepage", homepage).Replace("$private", axprivate);
           jsonBody = jsonBody.Replace("$has_issues", has_issues).Replace("$has_projects", has_projects).Replace("$has_wiki", has_wiki);

    }
}
}
