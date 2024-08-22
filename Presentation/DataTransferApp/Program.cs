// See https://aka.ms/new-console-template for more information

using Business.Context;
using Domain.Entities;
using Newtonsoft.Json;

string localdata = File.ReadAllText("data.json");
var jsondata = JsonConvert.DeserializeObject<List<Device>>(localdata);

foreach (var data in jsondata)
{
    var context = new AppDBContext();
    context.Device.Add(data);
    context.SaveChanges(); //commitlemek için
}