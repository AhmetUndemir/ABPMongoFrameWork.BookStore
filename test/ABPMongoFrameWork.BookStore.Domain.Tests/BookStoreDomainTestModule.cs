using ABPMongoFrameWork.BookStore.MongoDB;
using Volo.Abp.Modularity;

namespace ABPMongoFrameWork.BookStore;

[DependsOn(
    typeof(BookStoreMongoDbTestModule)
    )]
public class BookStoreDomainTestModule : AbpModule
{

}
