using System.Collections;

namespace CSharpAlgorithms
{
    public class HashMap
    {
        public HashMap()
        {
            Console.WriteLine("\n\n\nHashMap");
            Console.WriteLine("Hashtable");
            hashTable();
            Console.WriteLine("Dictionary");
            dictionary();
            Console.WriteLine("HashSet");
            hashSet();
        }

        public void hashTable()
        {
            Hashtable hashTable = new Hashtable();
            hashTable.Add("Key1", "Value1");
            hashTable.Add("Key2", "Value2");

            foreach (DictionaryEntry entry in hashTable)
            {
                Console.WriteLine($"{entry.Key} {entry.Value}");
            }
            hashTable.ContainsKey("Key1");
            String value = hashTable["Key1"].ToString();
        }

        public void dictionary()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("Key1", "Value1");
            dict.Add("Key2", "Value2");

            foreach (KeyValuePair<string, string> entry in dict)
            {
                Console.WriteLine($"{entry.Key} {entry.Value}");
            }

            String value = dict.GetValueOrDefault("Key1", String.Empty);
            Console.WriteLine(value);
            Console.WriteLine(dict.ContainsKey("Key1"));
        }

        public void hashSet()
        {
            HashSet<String> hashSet = new HashSet<String>();
            hashSet.Add("Value1");

            Console.WriteLine(hashSet.Contains("Value1"));
        }
    }
}