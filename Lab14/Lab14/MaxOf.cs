namespace Lab14
{
    internal class MaxOf
    {
        private int _maxValue = 0;

        public int GetMaxOf(int a, int b, int c)
        {
            int[] ints = [a, b, c];
            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] > _maxValue) _maxValue = ints[i];
            }
            return _maxValue;
        }
    }
}
