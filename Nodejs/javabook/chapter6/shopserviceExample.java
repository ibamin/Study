package javabook.chapter6;

public class shopserviceExample {
    public static void main(String[] args) {
        shopservice obj1 = shopservice.getInstance();
        shopservice obj2 = shopservice.getInstance();

        if(obj1==obj2) System.out.println("���� shopservice ��ü �Դϴ�");
        else System.out.println("�ٸ� shopservice ��ü �Դϴ�.");
    }
}
