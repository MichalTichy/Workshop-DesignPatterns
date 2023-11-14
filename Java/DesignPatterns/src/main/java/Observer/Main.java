package Observer;
import java.util.Random;
import java.util.concurrent.Executors;
import java.util.concurrent.ExecutorService;

public class Main {
    public static void main(String[] args) {
        MagicNumberGenerator generator = new MagicNumberGenerator();

        // Magic number Believer and Denier would like to comment on each magic number generated. Use observer pattern
            while (true) {
                try {
                    Thread.sleep(100);
                } catch (InterruptedException e) {
                    Thread.currentThread().interrupt();
                }
            }
    }
}

