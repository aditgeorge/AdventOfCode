using System.Collections;
using System.Diagnostics.CodeAnalysis;

namespace MagicTools.DataStructures
{
    public class ReversibleDictionary<T, V>: IDictionary<T, V>
    {
        private IDictionary<T, V> dictionary1;
        private IDictionary<V, T> dictionary2;

        public ICollection<T> Keys { get { return dictionary1.Keys; } }

        public ICollection<V> Values { get { return dictionary1.Values; } }

        public int Count { get { return dictionary1.Count; } }

        public bool IsReadOnly {get { return false;}}
        public ReversibleDictionary()
        {
            dictionary1 = new Dictionary<T, V>();
            dictionary2 = new Dictionary<V, T>();
        }
        public ReversibleDictionary(IDictionary<T, V> inputDictionary) : this()
        {
            foreach (var key in inputDictionary.Keys)
            {
                dictionary1.Add(key, inputDictionary[key]);
                dictionary2.Add(inputDictionary[key], key);
            }
        }

        public V this[T key] { get { return dictionary1[key]; } set { dictionary1[key] = value; } }

        public T this[V val] { get { return dictionary2[val]; } set { dictionary2[val] = value; } }
        public bool TryGetValue(T key, [MaybeNullWhen(false)] out V value)
        {
            if (dictionary1.TryGetValue(key, out value))
                return true;
            else
                return false;
        }
        public void Add(T key, V value)
        {
            dictionary1.Add(key, value);
            dictionary2.Add(value, key);
        }
        public void Add(KeyValuePair<T, V> item)
        {
            dictionary1.Add(item.Key, item.Value);
            dictionary2.Add(item.Value, item.Key);
        }
        public bool Remove(T key)
        {
            V value = dictionary1[key];
            if (dictionary1.ContainsKey(key) && dictionary2.ContainsKey(value))
                return dictionary1.Remove(key) && dictionary2.Remove(value);
            else
                return false;
        }
        public bool Remove(KeyValuePair<T, V> item)
        {
            if(dictionary1.Contains(item))
                return dictionary1.Remove(item) && dictionary2.Remove(new KeyValuePair<V,T>(item.Value, item.Key));
            else
                return false;
        }
        public bool ContainsKey(T key)
        {
            return dictionary1.ContainsKey(key);
        }
        public bool ContainsValue(V value)
        {
            return dictionary2.ContainsKey(value);
        }
        public void Clear()
        {
            dictionary1.Clear();
            dictionary2.Clear();
        }
        public bool Contains(KeyValuePair<T, V> item)
        {
            return dictionary1.Contains(item);
        }
        public bool Contains(KeyValuePair<V, T> item)
        {
            return dictionary2.Contains(item);
        }
        public IEnumerator<KeyValuePair<T, V>> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void CopyTo(KeyValuePair<T, V>[] array, int arrayIndex)
        {
            if (array.Length - arrayIndex - 1 < dictionary1.Count)
                throw new Exception("Array length less than dictionary length.");
            dictionary1.CopyTo(array, arrayIndex);
        }
    }
}
