package javabook.chapter4;
import java.util.Scanner;

public class Exercise07 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int s,n,money=0;

        off:while(true){
            System.out.println("----------------");
            System.out.println("1.���� | 2.��� | 3.�ܰ� | 4.����");
            System.out.println("----------------");
            System.out.print("����>");

            s=scanner.nextInt();
            switch(s){
                case 1:
                System.out.print("���ݾ�>");
                n=scanner.nextInt();
                money+=n;
                break;
                case 2:
                System.out.print("��ݾ�>");
                n=scanner.nextInt();
                money-=n;
                break;
                case 3:
                System.out.println("�ܰ�>"+money);
                break;
                default:
                System.out.println("���α׷� ����");
                break off;
            }
            scanner.close();
        }
    }
}
