package Adapter;

public class WeatherReporter {
    private final ICelsiusTemperatureProvider temperatureProvider;

    public WeatherReporter(ICelsiusTemperatureProvider temperatureProvider) {
        this.temperatureProvider = temperatureProvider;
    }

    public void reportTemperature() {
        double temp = temperatureProvider.getTemperatureInCelsius();

        if (temp < -10) {
            System.out.println("It's so cold, polar bears are wearing scarves!");
        } else if (temp < 0) {
            System.out.println("It's chilly out there, time to slide on ice!");
        } else if (temp < 20) {
            System.out.println("You might want a jacket, it's sweater weather!");
        } else if (temp < 30) {
            System.out.println("Perfect weather for a stroll, unless you’re a snowman!");
        } else {
            System.out.println("It's hotter than a dragon's breath out there, perfect for a barbecue... unless the barbecue is you!");
        }
    }
}
