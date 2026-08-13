namespace eraasoftTask10.ViewModels
{
    public class HomeFormViewModel
    {
        public string Username { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;

        public string Phone { get; set; } = string.Empty;

        public string Message { get; set; } = string.Empty;

        public bool SubscribeNews { get; set; }

        public bool SubscribeOffers { get; set; }

        public string PreferredLanguage { get; set; } = "English";

        public int Rating { get; set; }
    }
}