const compression=require('compression');
const express = require('express');

const app = express();

app.use(compression());
//Ư���� path�� �����Ҷ�
app.use('/api/getMap',compression())