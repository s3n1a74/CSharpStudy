using System.Security.Cryptography;

namespace SerializePractice
{
    internal interface IObjectSerialize
    {
        public string Path { get; set; }
        public object[] Objects { get; set; }

        public void ObjectSerialize() { }
    }
}
