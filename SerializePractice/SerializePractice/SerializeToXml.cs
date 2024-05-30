using System.Xml.Serialization;

namespace SerializePractice
{
    internal class SerializeToXml : IObjectSerialize
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

        public SerializeToXml(string _path, object[] _objects)
        {
            Path = _path;
            Objects = _objects;
        }

        public void ObjectSerialize()
        {
            if (_objects == null || _objects.Length == 0) throw new ArgumentNullException("objects are null");
            Type[] objectTypes = new Type[_objects.Length];
            for (int i = 0; i < _objects.Length; i++)
            {
                objectTypes[i] = _objects[i].GetType();
            }

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(object[]), objectTypes);

            using (FileStream fs = new FileStream(_path, FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fs, _objects);
            }
            Console.WriteLine("сериализация в хмл доне");
        }
    }
}
