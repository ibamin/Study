package javabook.chapter5;

public class StringequalExample {
    public static void main(String[] args) {
        String strver1="�Ź�ö";
        String strver2="�Ź�ö";

        if(strver1==strver2){
            System.out.println("strver1�� strver2�� ���� ��ü�� ����");
        }else{
            System.out.println("strver1�� strver2�� �ٸ� ��ü�� ����");
        }
        
        if(strver1.equals(strver2)){
            System.out.println("strver1�� strver2�� ���ڿ��� ����" + strver1 + " " +strver2);
        }

        String strver3 = new String("�Ź�ö");
        String strver4= new String ("�Ź�ö");

        if(strver3==strver4){
            System.out.println("strver3�� strver4�� ���� ��ü�� ����");
        }else{
            System.out.println("strver3�� strver4�� �ٸ� ��ü�� ����");
        }

        if(strver3.equals(strver4)){
            System.out.println("strver3�� strver4�� ���ڿ��� ����");
        }
    }
}
