namespace Laboratorium_3.Models.Memory
{
    public class CurrentDateTimeProvider : IDateTimeProvider
    {
        public DateTime DateNow()
        {
            return DateTime.Now;
        }
    }
}
