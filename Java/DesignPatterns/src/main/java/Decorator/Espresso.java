package Decorator;

class Espresso extends Coffee {
    @Override
    public String getDescription() {
        return "Espresso";
    }

    @Override
    public double getCost() {
        return 40;
    }
}
