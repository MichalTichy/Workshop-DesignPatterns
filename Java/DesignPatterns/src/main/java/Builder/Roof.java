package Builder;

public class Roof {
    private String material;
    private String color;

    public Roof(String material, String color) {
        this.material = material;
        this.color = color;
    }

    @Override
    public String toString() {
        return "Material: " + material + ", Color: " + color;
    }
}
