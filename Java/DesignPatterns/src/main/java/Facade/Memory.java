package Facade;

import java.util.HashMap;
import java.util.Map;

class Memory {
    private Map<Long, byte[]> memory = new HashMap<>();

    public void load(long position, byte[] data) {
        System.out.println("Memory starts loading at position " + position + " with data length of " + data.length + ".");
        memory.put(position, data);
    }

    public byte[] getData(long position) {
        byte[] data = memory.get(position);
        if (data != null) {
            System.out.println("Data retrieved from memory at position " + position + ".");
            return data;
        }

        System.out.println("No data available in memory at position " + position + ".");
        return null;
    }

    public void clear() {
        memory.clear();
    }
}
