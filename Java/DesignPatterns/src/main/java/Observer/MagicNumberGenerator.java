package Observer;

import java.util.ArrayList;
import java.util.List;
import java.util.Random;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;

public class MagicNumberGenerator {
    public MagicNumberGenerator() {
        ExecutorService executor = Executors.newSingleThreadExecutor();
        executor.submit(() -> {
            while (true) {
                performDifficultCalculation();
            }
        });
    }

    private void performDifficultCalculation() {
        try {
            Thread.sleep(1000);
            // I have result, but I don't wanna share it!
            int result = new Random().nextInt();
        } catch (InterruptedException e) {
            Thread.currentThread().interrupt();
        }
    }
}
