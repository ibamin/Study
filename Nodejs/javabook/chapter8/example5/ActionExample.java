package javabook.chapter8.example5;

public class ActionExample {
    public static void main(String[] args) {
        Action action  = new Action(){
            public void work(){
                System.out.println("���縦 �մϴ�.");
            }
        };

        action.work();
    }
}
