namespace Planify.Models
{
    internal class RandomPicture
    {
        public required RandomUser[] results { get; set; } // Users array
    }

    internal class RandomUser
    {
        public required Picture picture { get; set; } // User Object
    }

    internal class Picture
    {
        public required string large { get; set; }
        public required string medium { get; set; }
        public required string thumbnail { get; set; }
    }
}
