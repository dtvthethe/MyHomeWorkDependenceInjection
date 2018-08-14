using System;

namespace MyHomeWork.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        MyHomeWorkDBContext Init();
    }
}