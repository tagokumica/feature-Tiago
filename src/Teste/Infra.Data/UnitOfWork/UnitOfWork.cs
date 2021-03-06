using Infra.Data.Context;

namespace Infra.Data.UnitOfWork
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly TesteContext _context;

        public UnitOfWork(TesteContext context)
        {
            _context = context;
        }

        public bool Commit()
        {
             return _context.SaveChanges() > 0;
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}