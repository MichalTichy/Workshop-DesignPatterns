package Decorator;

class HouseBlend extends Coffee {
    @Override
    public String getDescription() {
        return "House Blend Coffee";
    }

    @Override
    public double getCost() {
        return 30;
    }
}
