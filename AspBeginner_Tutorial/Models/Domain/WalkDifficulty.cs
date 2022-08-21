namespace AspBeginner_Tutorial.Models.Domain
{
    public class WalkDifficulty
    {
        public Guid Id { get; set; }
        public string Code { get; set; } = string.Empty;

        // Navigation Property

        public Walk Walk { get; set; }
    }
}
