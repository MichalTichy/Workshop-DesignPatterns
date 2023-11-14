package Composite;

import java.util.*;

public class Main {
    public static void main(String[] args) {
        //Todo: Group contacts by company using composite pattern
        ContactDatabase contactDatabase = new ContactDatabase();
        for (Contact contact : contactDatabase.getContacts()) {
            contact.sendEmail("We have scraped your info from the web. Have fun with the spam!");
        }
    }
}

