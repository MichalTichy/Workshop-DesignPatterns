package Decorator;
public class Main {
    public static void main(String[] args) {
        Coffee myCoffee1 = new Espresso();
        Coffee myCoffee2 = new HouseBlend();

        // People are weird, some even like to put milk and sugar to their coffee!
        // We need to support everybody. Add support for adding milk (+10CZK) and sugar (price * 2) to coffee.

        System.out.println(myCoffee1.getCost() + " - " + myCoffee1.getDescription());
        System.out.println(myCoffee2.getCost() + " - " + myCoffee2.getDescription());
        System.out.println("Total Cost in CZK: " + (myCoffee1.getCost() + myCoffee2.getCost()));
    }
}

