package javabook.chapter7;

public class KumhoTire extends Tire{

    public KumhoTire(String location, int maxRotation) {
        super(location, maxRotation);
        //TODO Auto-generated constructor stub
    }
    
    @Override
    public boolean roll(){
        ++accumulatedRotation;
        if(accumulatedRotation<maxRotation){
            System.out.println(location+"KumhoTire ���� : "+(maxRotation-accumulatedRotation)+"ȸ");
            return true;
        }else{
            System.out.println("*** "+location+"KumhoTire ��ũ ***");
            return false;
        }
    }
}
