using System;
using System.Threading.Tasks;
using Abp.TestBase;
using CapstoneProject.ESN.EntityFrameworkCore;
using CapstoneProject.ESN.Tests.TestDatas;

namespace CapstoneProject.ESN.Tests
{
    public class ESNTestBase : AbpIntegratedTestBase<ESNTestModule>
    {
        public ESNTestBase()
        {
            UsingDbContext(context => new TestDataBuilder(context).Build());
        }

        protected virtual void UsingDbContext(Action<ESNDbContext> action)
        {
            using (var context = LocalIocManager.Resolve<ESNDbContext>())
            {
                action(context);
                context.SaveChanges();
            }
        }

        protected virtual T UsingDbContext<T>(Func<ESNDbContext, T> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<ESNDbContext>())
            {
                result = func(context);
                context.SaveChanges();
            }

            return result;
        }

        protected virtual async Task UsingDbContextAsync(Func<ESNDbContext, Task> action)
        {
            using (var context = LocalIocManager.Resolve<ESNDbContext>())
            {
                await action(context);
                await context.SaveChangesAsync(true);
            }
        }

        protected virtual async Task<T> UsingDbContextAsync<T>(Func<ESNDbContext, Task<T>> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<ESNDbContext>())
            {
                result = await func(context);
                context.SaveChanges();
            }

            return result;
        }
    }
}
