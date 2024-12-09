const express =require('express');
const session = require('express-session');
const app = express();

app.use(session({
    secret:'secret key', //��ȣȭ�ϴ� �� ���� Ű
    resave: false, //���ǿ� ���� ������ ��� �׻� �ٽ� �������� ����
    saveUninitialized: true, //�ʱ�ȭ���� ���� ������ ���� ������ �������� ����
    cookie:{//���� ���� ��Ű
        httpOnly:true, //true�� Ŭ���̾�Ʈ �ڹ� ��ũ��Ʈ���� document.cookie�� ��Ű ������ �� �� ����
        secure:true, //true�� https������ ��Ű ������ �ְ� �޵��� ó��
        maxAge:60000 //��Ű�� �����Ǵ� �ð� (�и������� ����)
    }
}));

app.get('/',function(req,res){
    res.send("default session use");
})

app.listen(3000,()=>{
    console.log("3000�� ��Ʈ�� �����߽��ϴ�.");
});