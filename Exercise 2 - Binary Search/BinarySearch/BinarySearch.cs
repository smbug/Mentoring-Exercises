namespace BinarySearch
{
    public class BinarySearch
    {
        public int? Find( int[] a, int v )
        {
            var x = 0;
            var y = a.Length;

            while (x != y)
            {
                var m = (x + y) / 2;
                var n = a[m];

                if (n < v)
                    x = m;
                else
                    y = m;
            }

            return a[x] == v ? x : (int?)null;
        }
    }
}
