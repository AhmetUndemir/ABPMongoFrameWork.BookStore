using System.Threading.Tasks;

namespace ABPMongoFrameWork.BookStore.Data;

public interface IBookStoreDbSchemaMigrator
{
    Task MigrateAsync();
}
