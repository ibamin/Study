package javabook.chapter6;

public class calculatorExample {
    public static void main(String[] args) {
        calculator mycalcu=new calculator();

        double result = mycalcu.areaRectangle(10);
        double result2 = mycalcu.areaRectangele(10,20);

        System.out.println("���谢�� ���� = "+result);
        System.out.println("���簢�� ���� = "+result2);
    }
}
