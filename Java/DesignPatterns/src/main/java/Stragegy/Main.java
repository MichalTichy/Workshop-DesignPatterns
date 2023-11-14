package Stragegy;
import java.util.ArrayList;
import java.util.Comparator;
import java.util.List;

public class Main {
    public static void main(String[] args) {
        // add different sorts (by average, last name and then first name,....)
        StudentList studentRecords = new StudentList();

        studentRecords.add(new Student("Samuel", "Lorenc", 2.4));
        studentRecords.add(new Student("Jimmy", "Adams", 1.2));
        studentRecords.add(new Student("Sandra", "Smith", 4.2));
        studentRecords.add(new Student("Vivek", "Franc", 2.8));
        studentRecords.add(new Student("Anna", "Ohm", 1.4));

        studentRecords.outputAll();
    }
}

