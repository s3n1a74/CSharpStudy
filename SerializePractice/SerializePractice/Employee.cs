namespace SerializePractice
{
    public class Employee
    {
        private string _name;
        private int _age;
        private List<GasAppliance> _gas;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new ArgumentException("invalid emp name");
                _name = value;
            }
        }
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value < 18 || value > 70) throw new ArgumentOutOfRangeException("invalid value of emp age");
                _age = value;
            }
        }
        public List<GasAppliance> Gas
        {
            get
            {
                return _gas;
            }
            set
            {
                if (value == null) throw new ArgumentNullException("null gas list");
                _gas = value;
            }
        }

        public Employee() { }

        public Employee(string name, int age, List<GasAppliance> gas)
        {
            Name = name;
            Age = age;
            Gas = gas;
        }
    }
}
