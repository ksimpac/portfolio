const fs = require('fs');
const https = require('https');
const express = require('express');
const app = express();
const SocketServer = require('ws').Server
var privateKey  = fs.readFileSync(__dirname + '/ssl/private.key');
var certificate = fs.readFileSync(__dirname + '/ssl/certificate.crt');
var credentials = { key: privateKey, cert: certificate };

var httpsServer = https.createServer(credentials, app).listen(3000, () => console.log('Listen Port on 3000'));

const wss = new SocketServer({ server: httpsServer })

//當 WebSocket 從外部連結時執行
wss.on('connection', ws => {

    //連結時執行此 console 提示
    console.log('Client connected')

    //當 WebSocket 的連線關閉時執行
    ws.on('close', () => {
        console.log('Close connected')
    })
})