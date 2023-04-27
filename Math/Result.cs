using System.Data.Entity;

namespace Math
{
    public class Result : AggregatorResult
    {
        public DbSet<AggregatorResult> AggregatorResult { get; set; }
    }
}

