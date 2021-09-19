using JsonToYaml;
using System;

namespace ConsoleSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //for replacing appsetting json, replace "" with '.

            var json = @"{
                'Name':'Omid',
                'Age':29,
                'Project':{
                        'ProjectName':'JsonToYaml Nuget Package',
                        'ProjectDescription':'This a library for converting json to yaml in .NET',
                        },
                'Languages':['C#','Binary']
                }";

            var yaml = JsonToYamlConvert.ConvertJsonToYaml(json);

            Console.WriteLine(yaml);
            Console.ReadLine();
        }
    }
}
