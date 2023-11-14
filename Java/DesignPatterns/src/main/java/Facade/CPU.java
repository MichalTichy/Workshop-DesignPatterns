package Facade;

class CPU {
    private boolean isInitialized = false;

    public void init() {
        System.out.println("CPU is initialized");
        isInitialized = true;
    }

    public void processData(byte[] data) {
        if (!isInitialized) {
            return;
        }

        System.out.println("Processing data:");
        for (byte b : data) {
            System.out.printf("%02X%n", b);
        }
    }
}
