package Adapter;

import java.util.Random;

class FahrenheitTemperatureProvider implements ITemperatureProvider {
    private final Random random = new Random();

    public double getTemperature() {
        return random.nextDouble() * 108 - 4; // Returns a temperature in Fahrenheit
    }
}
