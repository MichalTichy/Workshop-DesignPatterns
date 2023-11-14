package AbstractFactory;

import java.util.Iterator;
import java.util.Random;

public class Main {
    public static void main(String[] args) {
        // All currently supported animals are from America, add support to specify other continents during AnimalsCreator initialization. Use abstract factory.
        AnimalsCreator animalCreator = new AnimalsCreator();
        Iterator<IAnimal> animals = animalCreator.createAnimals();
        for (int i = 0; i < 10; i++) {
            IAnimal animal = animals.next();
            System.out.println(animal.getClass().getSimpleName() + " - " + animal.getFood());
        }
    }
}

