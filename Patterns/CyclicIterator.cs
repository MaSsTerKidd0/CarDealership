namespace DesignPatterns.IteratorExample
{
    public class CircularIterator<T>
    {
        private List<T> items;
        private int currentIndex = 0;

        public CircularIterator(IEnumerable<T> collection)
        {
            if (collection == null)
                throw new ArgumentNullException(nameof(collection));

            items = new List<T>(collection);
        }

        public T Current => items[currentIndex];

        public void Next()
        {
            currentIndex = (currentIndex + 1) % items.Count;
        }

        public void Previous()
        {
            currentIndex = (currentIndex - 1 + items.Count) % items.Count;
        }
    }
}
