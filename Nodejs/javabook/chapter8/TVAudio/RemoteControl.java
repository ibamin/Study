package javabook.chapter8.TVAudio;

public interface RemoteControl {
    //��� �ʵ� : ��Ÿ�� �� �����͸� ������ �� �ִ� �ʵ带 ������ �� ����.
    //�׷��� ��� �ʵ�� ������ �����ϴ� ����� �������̽��� ������ ������ ��Ÿ�� �ÿ� �����͸� �ٲ� ������
    //static final int ����
    int MAX_VOLUME =10;
    int MIN_VOLUME=0;

    //�߻� �޼ҵ� : ��ü�� ������ �ִ� �޼ҵ� ���� ȣ��� �ʿ��� �Ű��� ����Ÿ�Ը� ���� ���� ����δ� ��ü�� ������ �ִ�
    void turnOn();
    void turnOff();
    void setVolume(int volume);

    //����Ʈ �޼ҵ� : �������̽��� ��������� ��� ��ü�� ������ �ִ� �ν��Ͻ� �޼ҵ�
    default void setMute(boolean mute){
        if(mute){
            System.out.println("���� ó���մϴ�.");
        }else{
            System.out.println("���� �����մϴ�.");
        }
    }

    //���� �޼ҵ� : ��ü�� ��� �������̽������� ȣ�Ⱑ��
    static void changeBettey(){
        System.out.println("�������� ��ȯ�մϴ�.");
    }
}
