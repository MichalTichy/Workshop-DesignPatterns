package Builder;

public class Room {
    private String type;
    private int size;

    public Room(String type, int size) {
        this.type = type;
        this.size = size;
    }

    @Override
    public String toString() {
        return "Type: " + type + ", Size: " + size + " square meters";
    }
}
