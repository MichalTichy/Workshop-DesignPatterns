package Singleton;

import java.util.UUID;

public class Main {
    public static void main(String[] args) {
        // Todo: Each singleton instance should be the same
        for (int i = 0; i < 10; i++) {
            Singleton instance = new Singleton();
            System.out.println(instance.getId());
        }
    }
}

