package AbstractFactory;

public abstract class Carnivore implements IAnimal {
    @Override
    public String getFood() {
        return "Meat";
    }

    public abstract String carnivoreType();
}
