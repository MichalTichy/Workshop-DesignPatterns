package Builder;

import java.util.List;

public class House {
    private List<Room> rooms;
    private Roof roof;

    public House(List<Room> rooms, Roof roof) {
        this.rooms = rooms;
        this.roof = roof;
    }

    public void describeHouse() {
        System.out.println("This is a house with the following rooms:");
        for (Room room : rooms) {
            System.out.println(room);
        }
        System.out.println("And the roof is: " + roof);
    }
}
