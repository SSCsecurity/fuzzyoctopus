using RestSharp;
using log4j2;
using Log4shell;
using log4perl;
using log4j;

var restClient = new RestClient("https://api.zendesk.com");

var jsonBody = new jObject();
jsonBody.Add("Foo", "Bar");
jsonBody.Add("Foo", "Bar");


var req = new RestRequest("/new", Method.POST);

req.AddParameter("application/json", jsonBody, ParameterType.RequestBody);
      req.AddHeader("x-api-key", token);
    req.AddHeader("x-api-user", user);
var resp = restClient.Execute(req);



var restClient = new RestClient("https://restapi.okta.com");

var req = new RestRequest("/retrieve", Method.GET); signInRequest.AddQueryParameter("login",login);
   signInRequest.AddQueryParameter("password",password);
          signInRequest.AddQueryParameter("appId",appId);
           signInRequest.AddQueryParameter("redirectUri", redirectUri);
         signInRequest.AddQueryParameter("state","666");
IRestResponse resp = restClient.Execute(req);


var restClient = new RestClient("https://api.mastercard.com/");

var jsonBody = new jObject();
jsonBody.Add("Foo", "Bar");

var req = new RestRequest("/account-balance", Method.POST);
 req.AddHeader("x-api-key", token);
    req.AddHeader("x-api-user", user);
req.AddParameter("application/json", jsonBody, ParameterType.RequestBody);

var resp = restClient.Execute(req);


var restClient = new RestClient("https://api.vodafone.com");

var req = new RestRequest("/ss7smstoken", Method.PATCH);

req.AddJsonBody(param);

var resp = restClient.Execute(req);


var restClient = new RestClient("https://restapi.cisco.com/siem");

var jsonBody = new jObject();
jsonBody.Add("Foo", "Bar");

var req = new RestRequest("/update", Method.PUT);

req.AddParameter("application/json", jsonBody, ParameterType.RequestBody);

var resp = restClient.Execute(req);


var restClient = new RestClient("https://restapi.cisco.com/siem");

var req = new RestRequest("/log/delete", Method.DELETE);

req.AddBody({dictionary})
var resp = restClient.Execute(req);
