using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestSharp;

namespace ItsUmbria2020.WebApp.FrontEnd.Controllers
{
    public class ParserController : Controller
    {
        private readonly string baseUrl = "http://www.programmiamo.altervista.org/";
        private readonly string htmlPath = "HTML/";
        private readonly string htmlPage = "html.html";
        private readonly string jsPath = "js/";
        private readonly string jsPage = "js.html";
        private readonly string path = @"C:\Users\a.albini\Documents\Github\ItsUmbria2020\ItsUmbria2020.WebApp.FrontEnd\Views\Articles\";

        public IActionResult Index()
        {
            // html e css
            GroupCollection groups;
            string data = DoGetRequst(baseUrl + htmlPath + htmlPage);
            Regex regex = new Regex("href\\s*=\\s*\"(.*?)\"");
            MatchCollection matches = regex.Matches(data);
            List<string> totalLinks = new List<string>();
            foreach (Match match in matches)
            {
                groups = match.Groups;
                totalLinks.Add(groups[1].Value);
            }
            List<string> toDeleteLinks = totalLinks.Where(x => x.StartsWith("../") || x.StartsWith("#") || x.StartsWith("http")).ToList();
            totalLinks = totalLinks.Except(toDeleteLinks).ToList();
            foreach (string page in totalLinks)
            {
                data = DoGetRequst(baseUrl + htmlPath + page);
                Directory.CreateDirectory(path + page.Split('/')[0]);
                System.IO.File.WriteAllText(path + page.Replace(".html", ".cshtml"), data);
            }

            // javascript e jquery
            data = DoGetRequst(baseUrl + jsPath + jsPage);
            matches = regex.Matches(data);
            totalLinks = new List<string>();
            foreach (Match match in matches)
            {
                groups = match.Groups;
                totalLinks.Add(groups[1].Value);
            }
            toDeleteLinks = totalLinks.Where(x => x.StartsWith("../") || x.StartsWith("#") || x.StartsWith("http")).ToList();
            totalLinks = totalLinks.Except(toDeleteLinks).ToList();
            foreach (string page in totalLinks)
            {
                data = DoGetRequst(baseUrl + jsPath + page);
                Directory.CreateDirectory(path + page.Split('/')[0]);
                System.IO.File.WriteAllText(path + page.Replace(".html", ".cshtml"), data);
            }

            return Ok();
        }

        private string DoGetRequst(string url)
        {
            var client = new RestClient(url);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            return response.Content;
        }
    }
}