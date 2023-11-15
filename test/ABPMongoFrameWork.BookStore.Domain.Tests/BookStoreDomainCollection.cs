using ABPMongoFrameWork.BookStore.MongoDB;
using Xunit;

namespace ABPMongoFrameWork.BookStore;

[CollectionDefinition(BookStoreTestConsts.CollectionDefinitionName)]
public class BookStoreDomainCollection : BookStoreMongoDbCollectionFixtureBase
{

}
