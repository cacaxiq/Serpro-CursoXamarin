using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace ListViewExample.Infra
{
    public class DataAzure<TEntity> : AzureServiceBase<TEntity>, IDataAzure<TEntity>
    {
        public async Task<ObservableCollection<TEntity>> Get()
        {
            IEnumerable<TEntity> lista = await _table.ToListAsync();

            return new ObservableCollection<TEntity>(lista);
        }

        public async Task<TEntity> Insert(TEntity entity)
        {
            await _table.InsertAsync(entity);

            return entity;
        }

        public async Task<TEntity> Update(TEntity entity)
        {
            await _table.UpdateAsync(entity);

            return entity;
        }

        public async Task<TEntity> Delete(TEntity entity)
        {
            await _table.DeleteAsync(entity);

            return entity;
        }
    }
}
