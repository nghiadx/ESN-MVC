using CapstoneProject.ESN.EntityFrameworkCore;

namespace CapstoneProject.ESN.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly ESNDbContext _context;

        public TestDataBuilder(ESNDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            //create test data here...
        }
    }
}