using System.ComponentModel.DataAnnotations;


namespace FirstWebAPI.Models
{
    public class NatureTrail
    {
        public int TrailNumber { get; set; }
        public string TrailName { get; set; } = string.Empty;
        public double TrailLength { get; set; }
        public string DifficultyLevel { get; set; } = string.Empty;
        public string WildLifeSightings { get; set; } = string.Empty;
        public NatureTrail() { }
        public NatureTrail(int trailNumber, string trailName, double trailLength, string difficultyLevel, string wildLifeSightings)
        {
            TrailNumber = trailNumber;
            TrailName = trailName;
            TrailLength = trailLength;
            DifficultyLevel = difficultyLevel;
            WildLifeSightings = wildLifeSightings;
        }
    }
}
