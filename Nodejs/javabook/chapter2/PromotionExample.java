package javabook.chapter2;

public class PromotionExample {
    public static void main(String[] args) {
        byte bytevalue =10;
        int intvalue=bytevalue;
        System.out.println(intvalue);

        char charvalue='��';
        intvalue=charvalue;
        System.out.println("���� �����ڵ�="+intvalue);

        intvalue=500;
        long longvalue=intvalue;
        System.out.println(longvalue);

        intvalue=200;
        double doublevalue=intvalue;
        System.out.println(doublevalue);
    }
}
