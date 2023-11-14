package Flyweight;

import java.util.UUID;

public class Flyweight {
    private final String instanceName;
    private final UUID id = UUID.randomUUID();

    public Flyweight(String instanceName) {
        this.instanceName = instanceName;
    }

    public String getInstanceName() {
        return instanceName;
    }

    public UUID getId() {
        return id;
    }
}
