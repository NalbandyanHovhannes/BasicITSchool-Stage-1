using System;

namespace Classes
{
    public class BMW : CarParts, IProperty
    {
        public string Brand { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int HorsePower { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Color { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        private int myVar;

        public int MyProperty
        {
             get { return myVar; }
            set { myVar = 10; }
        }
        public int rrr { get; private set; }
        public BMW(int t)
        {
            myVar= t;   
        }
        public BMW() { }

    }
}
