namespace NgRockServer
{
    public class AppleDeepLink
    {
        public AppLinks applinks { get; set; }

    }
    public class AppLinks
    {
        public string[] apps { get; set; }
        public AppDetails details { get; set; }
    }
    public class AppDetails
    {
        public string appID { get; set; }
        public string[] paths { get; set; }
    }

}
