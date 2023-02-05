import java.util.HashMap;
import java.util.HashSet;
import java.util.Map;

class HashMapExamples {
    public HashMapExamples() {
        System.out.println("\n\n\nHashMapExamples");
        System.out.println("HashMap");
        hashMap();
        hashSet();
    }

    public void hashMap() {
        HashMap<String, String> hashMap = new HashMap<>();
        hashMap.put("Key1", "Value1");
        hashMap.put("Key2", "Value2");

        for (Map.Entry<String, String> entry : hashMap.entrySet()) {
            System.out.println(String.format("Key: %s, Value: %s",
                    entry.getKey(),
                    hashMap.getOrDefault(entry.getKey(), "")
                ));
        }
        System.out.println(hashMap.containsKey("Key1"));
    }

    public void hashSet() {
        HashSet<String> hashSet = new HashSet<>();
        hashSet.add("Value1");
        boolean containsKey = hashSet.contains("Value1");
        System.out.println(containsKey);
    }

    /** SUGAR */
    public void initializeHashMap() {
        HashMap<String, String> hashMap = new HashMap<>() {{
            put("Key1", "Value1");
            put("Key2", "Value2");
        }};
    }
}