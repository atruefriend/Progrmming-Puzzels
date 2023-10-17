namespace OwnHashTable
{
    public class Map
    {
        private object[] array;
        public Map(int size)
        {
            array = new object[size];
        }

        public int Hash(string key)
        {
            int hash = 0;
            for (int i = 0; i < key.Length; i++)
            {
                hash = (hash + key[i].GetHashCode() * i) % array.Length;
            }
            return hash;
        }

        public void set(string key, object value)
        {
            int address = Hash(key);
            if (array[address] == null)
            {
                array[address] = new List<object>();
            }
            ((List<object>)array[address]).Add(new object[] { key, value });
        }

        public object get(string key)
        {
            int address = Hash(key);
            if (array[address] != null)
            {
                List<object> currentBucket = (List<object>)array[address];
                for (int i = 0; i < currentBucket.Count; i++)
                {
                    var value = (object[])currentBucket[i];
                    if (value[0].ToString() == key)
                    {
                        return value[1];
                    }
                }
            }
            return "Not found!";
        }
    }
}