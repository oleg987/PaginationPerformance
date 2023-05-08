using BenchmarkDotNet.Running;

namespace PaginationPerformance;

internal class Program
{
    // Курим SQL. Сильно прям курим. С душой.
    // Цель: Добиться чтобы время выполнения запроса не зависело от номера страницы.
    // Ответ: Результат бенчмарка AnotherPagination.
    static void Main(string[] args)
    {
        /*
         * Db: Postgres 14
         * Tables: Persons
         * Rows: 100_000
         * 
         * DataSet: Persons.sql
         * 
         * Instruction:
         * 1) Create db in DataGrip.
         * 2) Run SQL Script "Persons.sql"
         * 3) In PersonDbContext.OnConfiguring() set your connection string.
         */

        var summary = BenchmarkRunner.Run<Pagination>();
        // var summary = BenchmarkRunner.Run<LoadAllData>();

        // var summary = BenchmarkRunner.Run<AnotherPagination>();
    }
}