using System.Xml.Linq;

namespace ASS2
{
    internal class person
    {
        private string[] name;
        private int[] age;
        private int size;
        public int max;
        public string maxname;

        public person(int maxSize)
        {
            name = new string[maxSize];
            age = new int[maxSize];
            size = maxSize;
        }

        public void addperson(string Name, int Age, int index)
        {
            if (index >= 0 && index < size)
            {
                name[index] = Name;
                age[index] = Age;
            }
            else
            {
                Console.WriteLine("Index out of bounds.");
            }
        }
        public void getmax()
        {

            for (int i = 0; i < name.Length; i++)
            {
                if (age[i] > max)
                {
                    max = age[i];
                    maxname= name[i];
                }
            }
            Console.WriteLine($"oldest age is {max}");
            Console.WriteLine($"his name {maxname}");

        }
        public int this[string Name1]
        {
            get
            {
                for (int i = 0; i < name.Length; i++)
                {
                    if (name[i] == Name1)
                    {
                        return age[i];
                    }
                }
                return -1;
            }
            set
            {
                for (int i = 0; i < name.Length; i++)
                {
                    if (name[i] == Name1)
                    {
                        age[i] = value;
                        break;
                    }
                }
            }
        }
    }
}