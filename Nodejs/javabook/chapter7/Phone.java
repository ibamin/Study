package javabook.chapter7;

public class Phone {
    public String owner;

    public Phone(String owner){
        this.owner=owner;
    }

    public void turnOn(){
        System.out.println("�� ������ �մϴ�.");
    }
    public void turnoff(){
        System.out.println("�� ������ ���ϴ�.");
    }
}
