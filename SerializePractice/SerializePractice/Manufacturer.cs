namespace SerializePractice
{
    public class Manufacturer
    {
        private string _title;

        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new ArgumentNullException("title is null");
                _title = value;
            }
        }

        public Manufacturer() { }

        public Manufacturer(string title)
        {
            Title = title;
        }
    }
}
