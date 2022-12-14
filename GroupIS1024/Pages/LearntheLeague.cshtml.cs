using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

using System.Net;

namespace GroupIS1024.Pages
{
    public class LearntheLeagueModel : PageModel
    {
        static readonly HttpClient client = new HttpClient();
        public void OnGet()
        {

         
                var task = client.GetAsync("https://www.balldontlie.io/api/v1/teams");
                HttpResponseMessage result = task.Result;
                List<Franchise> franchises = new List<Franchise>();
                if (result.IsSuccessStatusCode)
                {
                    Task<string> readString = result.Content.ReadAsStringAsync();
                    string jsonString = readString.Result;
                FranchiseList franchiseList = Franchise.FromJson(jsonString);
                franchises = franchiseList.Data;

            }

                ViewData["Franchises"] = franchises;
            }
        }
    }
