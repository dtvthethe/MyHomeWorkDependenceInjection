namespace MyHomeWork.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private MyHomeWorkDBContext dbContext;

        public MyHomeWorkDBContext Init()
        {
            return dbContext ?? (dbContext = new MyHomeWorkDBContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}