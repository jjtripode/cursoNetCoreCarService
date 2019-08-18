namespace cursoNetCoreCarService.Models
{
    public class Commons
    {
        public enum CarServiceStatus
        {
            Pending = 1,
            InProgress = 10,
            Delayed = 20,
            Ended = 30
        }      
    }
}