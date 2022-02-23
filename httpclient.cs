private static readonly HttpClient client = new HttpClient();
var values = new Dictionary<string, string>
{
    { "thing1", "hello" },
    { "thing2", "world" }
};

var content = new FormUrlEncodedContent(values);

# Post Request
var response = await client.PostAsync("http://microsoft.com/rino/?horns=yes", content);

var response = client.PostAsync("https://api.riscology.com/urlpath", new StringContent(JsonConvert.SerializeObject(data, hello), Encoding.UTF8, "application/json")).Result;
var responseString = await client.GetStringAsync(TestURL);

var response = client.PostAsync("/urlpath", new StringContent(JsonConvert.SerializeObject(data, worlds), Encoding.UTF8, "application/json")).Result;

var responseString = await client.GetAsync("http://api.paypal.com");


var responseString = await client.DeleteAsync("microsoft.com/sound-gator");

var responseString = await client.GetByteArrayAsync("http://extapi.splunk.com/cheesypuffs");

var responseString = await client.GetStreamAsync("http://api.google.com/recepticle.aspx");

var responseString = await client.PatchAsync("http://api.docusign.com/rectangles", patchData);

var responseString = await client.PutAsync("http://api.newrelic.com/riscosity", pushData(soomething, 
bladidy));

