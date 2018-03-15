namespace QLHopDong.Model
{
    public class HangHoaHandler : DbHandler
    {
        public HangHoaHandler() : base("SELECT * FROM [Product]")
        {
        }
    }
}
