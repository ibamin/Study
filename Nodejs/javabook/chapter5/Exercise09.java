package javabook.chapter5;
import java.util.Scanner;

public class Exercise09 {
    public static void main(String[] args) {
        boolean run=true;
        int studentNum=0;
        int [] scores=null;
        Scanner scanner = new Scanner(System.in);

        while(run){
            System.out.println("----------------------");
            System.out.println("1.�л��� | 2.�����Է� | 3.��������Ʈ | 4.�м� | 5.����");
            System.out.println("----------------------");
            System.out.println("����>");

            int selectNo = scanner.nextInt();

            if(selectNo==1){
                System.out.println("�л� ���� �Է����ּ���.");
                System.out.print(">>");
                studentNum = scanner.nextInt();
                scores = new int[studentNum];
                System.out.println(studentNum+"�� �Խ�");
            }
            else if(selectNo==2){
                int n;
                for(int i=0;i<studentNum;i++){
                    System.out.println((i+1)+"���� �л��� ����");
                    System.out.print(">>");
                    n=scanner.nextInt();
                    scores[i] = n;
                }
            }
            else if(selectNo==3){
                int cnt=0;
                for(int n:scores){
                    System.out.println(cnt+"��° �л��� ���� : "+n);
                }
            }
            else if(selectNo==4){
                int max=0,sum=0,cnt=0;
                double avg=0;
                for(int n:scores){
                    if(max<n) max=n;
                    sum+=n;
                    cnt++;
                 }
                avg = (double)sum/cnt;
                System.out.println("���� : "+sum);
                System.out.println("��� : "+avg);
            }
            else if(selectNo==5){
                run=false;
            }
        }
        scanner.close();
    }
}
