using System.Data.Entity;

namespace Math
{
    public class AggregationResults : AggregatorResult
    {
        public DbSet<AggregatorResult> AggregatorResult { get; set; }
    }
}

