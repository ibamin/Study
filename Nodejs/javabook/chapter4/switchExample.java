package javabook.chapter4;

public class switchExample {
    public static void main(String[] args) {
        int num = (int)(Math.random()*6)+1;

        switch(num){
            case 1:
            System.out.println(num+"���� ���Խ��ϴ�");
            break;
            case 2:
            System.out.println(num+"���� ���Խ��ϴ�");
            break;
            case 3:
            System.out.println(num+"���� ���Խ��ϴ�");
            break;
            case 4:
            System.out.println(num+"���� ���Խ��ϴ�");
            break;
            case 5:
            System.out.println(num+"���� ���Խ��ϴ�");
            break;
            default:
            System.out.println(num+"���� ���Խ��ϴ�");
        }
    }
}
