const timeout = setTimeout(()=>{
    console.log("1�� �Ŀ� ����˴ϴ�");
},1000);

const interval = setInterval(() => {
   console.log("1�� ���� ����˴ϴ�"); 
}, 1000);

const immediate = setImmediate(()=>{
    console.log('setImmediate() �Լ� ȣ�� �ڿ� ���� ��� �ڵ带 ���� �����ϰ� �ٷ� ������ �����մϴ�')
});

console.log('setImmediate ���� ���� ����˴ϴ�.');

setTimeout(()=>{
    clearInterval(interval);
},3000);