package Stragegy;

public class Student {
    private String firstName;
    private String lastName;
    private double average;

    public Student(String firstName, String lastName, double average) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.average = average;
    }

    // Getters
    public String getFirstName() {
        return firstName;
    }

    public String getLastName() {
        return lastName;
    }

    public double getAverage() {
        return average;
    }
}
