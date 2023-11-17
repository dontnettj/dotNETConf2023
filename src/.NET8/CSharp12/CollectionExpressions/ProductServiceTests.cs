namespace CollectionExpressions
{
    public class ProductServiceTests
    {
        [Test]
        public void ProductService_GetListOfIdTest()
        {
            var ids = ProductService.GetIds(1, 5);

            IEnumerable<int> expected = [1, 2, 3, 4, 5];
            CollectionAssert.AreEqual(expected, ids);
        }
    }

    #region Mocked service

    static class ProductService
    {
        public static IEnumerable<int> GetIds(int startPage, int maxPage)
        {
            List<int> ids = [];
            for (int i = startPage; i <= maxPage; i++)
            {
                ids.Add(i);
            }
            return ids;
        }
    }

    #endregion
}
