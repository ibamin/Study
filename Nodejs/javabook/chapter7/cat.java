package javabook.chapter7;

public class cat extends Animal{
    public cat(){
        this.kind = "������";
    }

    @Override
    public void sound() {
        System.out.println("�߿�");
    }
    
}
