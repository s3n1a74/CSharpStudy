using System.Text.Json;

namespace SerializePractice
{
    public class SerializeToJson : IObjectSerialize
    {
        private string _path;
        private object[] _objects;

        public string Path
        {
            get { return Path; }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new ArgumentNullException("null path value");
                _path = value;
            }
        }

        public object[] Objects
        {
            get { return Objects; }
            set
            {
                if (value == null) throw new ArgumentNullException("invalid obj");
                _objects = value;
            }
        }

        public SerializeToJson(string _path, object[] _objects)
        {
            Path = _path;
            Objects = _objects;
        }

        public void ObjectSerialize()
        {
            if (_objects == null || _objects.Length == 0) throw new ArgumentNullException("objects are null");

            using (FileStream fs = new FileStream(_path, FileMode.OpenOrCreate))
            {
                JsonSerializer.Serialize(fs, _objects);
                Console.WriteLine("сериализация в джейсона завершена");
            }
        }
    }
}
