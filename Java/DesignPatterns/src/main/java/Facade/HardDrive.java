package Facade;

import java.util.Random;

class HardDrive {
    public byte[] read(long position) {
        // Generate random data
        byte[] data = new byte[10];
        new Random().nextBytes(data);
        return data;
    }
}
