package Stragegy;

import java.util.ArrayList;
import java.util.Comparator;
import java.util.List;

class StudentList {
    private List<Student> list = new ArrayList<>();

    public void add(Student student) {
        list.add(student);
    }

    public void outputAll(){
        for (var student : list) {
            System.out.println(student.getFirstName() + " " + student.getLastName());
        }
    }
}
