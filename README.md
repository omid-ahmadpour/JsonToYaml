# JsonToYaml
This is a library for converting json to yaml in .NET.

## Give a Star! ⭐
If you like or are using this project to learn or using JsonToYaml package, please give it a star. Thanks!

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
