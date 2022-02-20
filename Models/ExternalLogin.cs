namespace placeMarket.api.Models
{
    public class ExternalLogin
    {
        public int Id { get; set; }
        public string RegisterOption { get; set; }
        public string AccessToken { get; set; }
        public string UserID { get; set; }
        public string ExpiresIn { get; set; }
        public string ReauthorizeRequiredIn { get; set; }
        public string SignedRequest { get; set; }

    }
}