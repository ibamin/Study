package javabook.chapter7;

public class cellphone {
    String model;
    String color;

    void poweron(){System.out.println("������ �մϴ�");}
    void poweroff(){System.out.println("������ ���ϴ�");}
    void bell(){System.out.println("���� �︳�ϴ�");}
    void sendVoice(String message){System.out.println("�� : "+message);}
    void receiveVoice(String message){System.out.println("���� : "+message);}
    void hangUp() { System.out.println("��ȭ�� �����ϴ�");}
}
