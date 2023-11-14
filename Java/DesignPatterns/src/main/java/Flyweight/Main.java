package Flyweight;

import java.util.UUID;

public class Main {
    public static void main(String[] args) {
        // Each instance with identical name should be the same
        for (int i = 0; i < 10; i++) {
            String instanceName = getInstanceName();
            Flyweight instance = new Flyweight(instanceName);
            System.out.println("Name: " + instance.getInstanceName() + " - " + instance.getId());
        }
    }

    private static String getInstanceName() {
        return Math.random() < 0.5 ? "Instance 1" : "Instance 2";
    }
}

