using BenchmarkDotNet.Attributes;

namespace PaginationPerformance
{
    public class LoadAllData
    {
        [Params(0, 1, 2, 3, 4, 5, 6, 7, 8, 9)]
        public int skipPages;
        public PersonDbContext context;

        [GlobalSetup]
        public void Setup() => context = new PersonDbContext();

        [Benchmark]
        public List<Person> SkipTakePagination()
            => context.Persons
            .OrderBy(p => p.Id)
            .AsEnumerable()
            .Skip(skipPages * 10_000)
            .Take(10_000)
            .ToList();
    }
}
