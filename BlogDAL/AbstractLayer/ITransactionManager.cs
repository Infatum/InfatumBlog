using System;

namespace DataAccessLayer.AbstractLayer
{
    public interface ITransactionManager : IDisposable
    {
        IDisposable Begin();
        void Commit();
        void RollBack();
    }
}