package javabook.chapter3;

public class StringEqualsExample {
    public static void main(String[] args) {
        String strvar1 ="�Ź�ö";
        String strvar2 = "�Ź�ö";
        String strvar3 = new String("�Ź�ö");

        System.out.println(strvar1==strvar2);
        System.out.println(strvar1==strvar3);
        System.out.println();
        System.out.println(strvar1.equals(strvar2));
        System.out.println(strvar1.equals(strvar3));
    }
}
