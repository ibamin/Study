package javabook.chapter7;

public class DmbCellPhone extends cellphone{
    int channel;
    DmbCellPhone(String model,String color,int channel){
        this.model=model;
        this.color=color;
        this.channel=channel;
    }

    void turnOnDum(){
        System.out.println("ä�� "+channel+"�� DMB ��� ������ �����մϴ�.");
    }
    void changeChannelDmb(int channel){
        this.channel=channel;
        System.out.println("ä�� "+channel+"������ �ٲߴϴ�");
    }
    void turnoffDmb(){
        System.out.println("DMB��� ������ ����ϴ�");
    }
}
