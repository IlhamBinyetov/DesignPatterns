
#region Explanation
//Plus//
// - Ensure single instance
// - Globally access
// - Created only when requested


//Minus//
// - Difficult to UnitTest
// - In multithread word, threads cannot crate its own instance

#endregion


using SingletonDesignPattern.Models;
Console.WriteLine(DateTime.Now.ToLongTimeString());
var countries = await CountryProvider.Instance.GetCountries();

foreach (var country in countries)
{
    Console.WriteLine(country.Name);
}

var countries1 =  await CountryProvider.Instance.GetCountries();
Console.WriteLine(DateTime.Now.ToLongTimeString());