const process = require('process');

process.on('beforeExit',(code)=>{
    console.log('2. �̺�Ʈ ������ ��ϵ� �۾��� ��� ����� �� ��� ���μ����� �����ϱ� ���� :',code);
});

process.on('exit',(code)=>{
    console.log('3.��� ���μ����� ����� �� : ',code);
});

console.log('1. printing message on console to first');

console.log(process.env);

const {nextTick} = require('process');

console.log('start');

setTimeout(()=>{
    console.log("timeout callback");
},0);

nextTick(()=>{
    console.log('nextTick callback');
});
console.log('end');