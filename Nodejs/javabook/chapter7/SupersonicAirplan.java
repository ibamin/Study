package javabook.chapter7;

public class SupersonicAirplan extends Airplan{
    public static final int NORMAL =1;
    public static final int SUPERSONIC =2;

    public int flyMode = NORMAL;

    @Override
    public void fly(){
        if(flyMode==SUPERSONIC){
            System.out.println("�����Ӻ����մϴ�");
        }else{
            super.fly();
        }
    }
}
