using System;
namespace creas.src
{
    public class PairObject<K, V>
    {
        /**
       * Key of this <code>Pair</code>.
       */
        private K key;

        /**
         * Gets the key for this pair.
         * @return key for this pair
         */
        public K getKey() { return key; }
        private V value;

        /**
          * Gets the value for this pair.
          * @return value for this pair
          */
        public V getValue() { return value; }

        /**
         * Creates a new pair
         * @param key The key for this pair
         * @param value The value to use for this pair
         */
        public PairObject(K key, V value)
        {
            this.key = key;
            this.value = value;
        }

        public String toString()
        {
            return key + "=" + value;
        }


        public int hashCode()
        {
            int hash = 7;
            hash = 31 * hash + (key != null ? key.GetHashCode() : 0);
            hash = 31 * hash + (value != null ? value.GetHashCode() : 0);
            return hash;
        }

        public bool equals(Object o)
        {
            if (this == o) return true;
            if (o is PairObject<K, V>)
            {
                PairObject<K, V> pair = (PairObject<K, V>)o;
                if (key != null ? !key.Equals(pair.key) : pair.key != null) return false;
                if (value != null ? !value.Equals(pair.value) : pair.value != null) return false;
                return true;
            }
            return false;
        }
    }
}
