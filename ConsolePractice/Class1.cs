using RestSharp;

namespace ConsolePractice
{
    public class Class1
    {
        public void get()
        {
            var client = new RestClient("https://www.yangming.com");
            var request = new RestRequest("/e-service/Track_Trace/blconnect.aspx?BLADG=W120448198&rdolType=BK&BKADG=YCH652341", Method.GET);
            var  response = client.Execute(request);
        }
    }
}
