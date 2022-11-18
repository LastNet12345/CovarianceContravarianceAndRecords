namespace CovarianceContravarianceAndRecords
{
    internal class TestComparer<T> : IComparer<T>
    {
        public int Compare(T? x, T? y)
        {
            return 1;
        }
    }
}