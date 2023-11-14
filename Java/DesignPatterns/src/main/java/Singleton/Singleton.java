package Singleton;

import java.util.UUID;

public class Singleton {
    // Using UUID in place of Guid
    private final UUID id = UUID.randomUUID();

    public UUID getId() {
        return id;
    }
}
