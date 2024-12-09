const express = require('express');
const app = express();
const port = 3000;

app.listen(port,()=>{
    console.log(`Server started port ${port}`);
});

app.get('/',function(req,res){
    res.send('root');
});

app.get('/customer',function(req,res){
    res.send("get ��û�� ���� ����");
});

app.post('/customer',function(req,res){
    res.send("post ��û�� ���� ����");
});

app.all('/customer',function(req,res){
    res.send("http ��û �޼ҵ� ������ ������� ����");
});