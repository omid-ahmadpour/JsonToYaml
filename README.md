# JsonToYaml
This is a library for converting json to yaml in .NET.

## For convert json to yaml

```ruby
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
```
