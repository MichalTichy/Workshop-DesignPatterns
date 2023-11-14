package AbstractFactory;

public abstract class Herbivore implements IAnimal {
    @Override
    public String getFood() {
        return "Plants";
    }

    public abstract String herbivoreType();
}
