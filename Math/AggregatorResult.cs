using System.Data.Entity;

namespace Math
{
    public class Result : AggregatorResult
    {
        public DbSet<AggregatorResult> AggregatorResult { get; set; }
    }

    public class AggregatorResult
    {
        public double Value { get; set; }
        public List<int> FoundInRows { get; set; }
        public List<int> BrokenRows { get; set; }
    }
}
