package Composite;

class Contact {
    private String email;
    private String company;

    public Contact(String email, String company) {
        this.email = email;
        this.company = company;
    }

    public void sendEmail(String message) {
        System.out.println("Sending Email to single recipient: " + email + ", Message: " + message);
    }
}
