package Facade;

import java.util.HashMap;
import java.util.Map;
import java.util.Random;

public class Main {
    public static void main(String[] args) {
        // Facade pattern implementation is left for the students

        CPU cpu = new CPU();
        Memory memory = new Memory();
        HardDrive hdd = new HardDrive();

        // PC START
        cpu.init();
        memory.clear();

        // PC WORKING
        byte[] data = memory.getData(0);
        if (data == null) {
            byte[] dataFromHdd = hdd.read(0);
            memory.load(0, dataFromHdd);
            data = memory.getData(0);
        }

        cpu.processData(data);

        // PC SHUTDOWN
        memory.clear();
    }
}

