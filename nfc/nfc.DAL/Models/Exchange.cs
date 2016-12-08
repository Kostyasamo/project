namespace nfc.DAL.Models
{
    public class Exchange
    {
        public int Id  { get; set; }
        [Required]
        public int User1_id { get; set; }
        public int User2_id { get; set; }
        public int Tag_Id { get; set; }
    }
}
