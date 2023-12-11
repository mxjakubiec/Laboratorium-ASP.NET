namespace Laboratorium_2.Models
{
    public class Birth
    {
        public string Imie { get; set; }
        public DateTime Data { get; set; }

        public bool IsValid()
        {
            return Imie != null && Imie != "" && Data < DateTime.Now;
        }

        public int CalculateAge()
        {
            return DateTime.Now.Year - Data.Year;
        }
    }
}
