package Composite;

import java.util.ArrayList;
import java.util.Collection;

class ContactDatabase {
    private Collection<Contact> contacts;

    public ContactDatabase() {
        contacts = new ArrayList<>();
        // Populate the contact list
        contacts.add(new Contact("john.doe@company1.com", "Company1"));
        // ... Add other contacts
        contacts.add(new Contact("mark.harris@none.com", null));
    }

    public Collection<Contact> getContacts() {
        return contacts;
    }
}
