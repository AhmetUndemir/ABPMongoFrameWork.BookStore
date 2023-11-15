using Volo.Abp.Modularity;

namespace ABPMongoFrameWork.BookStore;

[DependsOn(
    typeof(BookStoreApplicationModule),
    typeof(BookStoreDomainTestModule)
    )]
public class BookStoreApplicationTestModule : AbpModule
{

}
