namespace ConferencePlanner.GraphQL.Speakers
{
    public class AddSpeakerInput
    {
        public string Name { get; set; } = default!;
        public string? Bio { get; set; }
        public string? WebSite { get; set; }
    }
}