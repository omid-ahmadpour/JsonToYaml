using JsonToYaml;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JsonYaml.AspNetCore.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public string YamlCode { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public IActionResult OnGet()
        {
            var json = @"{
                'Name':'Omid',
                'Age':29,
                'Project':{
                        'ProjectName':'JsonToYaml Nuget Package',
                        'ProjectDescription':'This a library for converting json to yaml in .NET',
                        },
                'Languages':['C#','Binary']
                }";

            YamlCode = JsonToYamlConvert.ConvertJsonToYaml(json);

            return Page();
        }
    }
}
