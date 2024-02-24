namespace EFC_Ex1.DAL.Moduls
{
    public class Games
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public string Developer { get; set; }
        public string Gener { get; set; }

        public string? Modes { get; set; }

        public int? SoldCopies { get; set; }
        public DateTime? Release {  get; set; }
    }
}
