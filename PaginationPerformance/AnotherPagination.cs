using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaginationPerformance
{
    public class AnotherPagination
    {
        public PersonDbContext context;

        [GlobalSetup]
        public void Setup() => context = new PersonDbContext();

        [Benchmark]
        public List<Person> SkipTakePagination()
            => throw new NotImplementedException();
    }
}
