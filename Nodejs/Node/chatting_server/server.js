const express = require('express');
const { response } =require('express');
const path = require('path');
const fs = require('fs');
const nunjucks =require('nunjucks');   //������ �ʼ� ��Ű��
const app = express();
const http = require('http').Server(app);
const  io = require('socket.io')(http);

app.set("view engine","html")

nunjucks.configure("./views",{
    express: app
});

app.use('/',express.static("./public"));                  

app.get('/',(req,res)=>{
    res.render("main.html");
});

var people_cnt = 0;                                   
io.on('connection',function(socket){                             //http�� node js�� �������ִ� �ڵ鷯�� socket���� �̰�
    console.log('user connected : ',socket.id);   
    people_cnt++;

    socket.on('disconnect',function(){                          //���� ����
        console.log('user disconnected : ',socket.id);
    });

    socket.on('send message',function(text){                     //�޽��� ����
        var date = new Date;
        var message =  text + '\n' + date;
        console.log(message);
        io.emit('receive message',message);                    //receive message�̺�Ʈ���� Ŭ���̾�Ʈ���� message�� �Բ� ����
    });
});

http.listen(3000,function(req,res){                           //������ ����
    console.log('server running~~ port : 3000');
});