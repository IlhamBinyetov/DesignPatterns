

var eb = new EndPointBuilder("https://localhost/");

eb.Append("api").Append("v1").Append("user").AppendParams("id","5");

var url = eb.Build();

Console.WriteLine(url);


