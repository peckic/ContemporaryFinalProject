using System.ComponentModel.DataAnnotations;


namespace FinalProjectIzzy.Models
{
    public class DanceMoves
    {
        public string MoveNameId { get; set; }
        public string Style { get; set; }
        public int Difficulty { get; set; }
        public string MusicType { get; set; }
        public int IdealTempo { get; set; }
        public DanceMoves() { }
        public DanceMoves(string moveNameId, string style, int difficulty, string musicType, int idealTempo)
        {
            MoveNameId = moveNameId;
            Style = style;
            Difficulty = difficulty;
            MusicType = musicType;
            IdealTempo = idealTempo;
        }
    }
}
