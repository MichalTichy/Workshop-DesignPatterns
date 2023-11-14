package AbstractFactory;

import java.util.Iterator;
import java.util.Random;

public class AnimalsCreator {
    public Iterator<IAnimal> createAnimals() {
        return new Iterator<IAnimal>() {
            private Random random = new Random();

            @Override
            public boolean hasNext() {
                return true; // Infinite iterator
            }

            @Override
            public IAnimal next() {
                boolean isCarnivore = random.nextInt(5) == 0;
                if (isCarnivore) {
                    return new Wolf();
                } else {
                    return new Bison();
                }
            }
        };
    }
}
