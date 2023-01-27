var https=require('https');
var ws=require('ws');
var fs=require('fs');
var keypath=process.cwd()+'/ssl/private.key';
var certpath=process.cwd()+'/ssl/certificate.crt';
  
var options = {
 key: fs.readFileSync(keypath),
 cert: fs.readFileSync(certpath),
};
  
var server=https.createServer(options, function (req, res) {//要是单纯的https连接的话就会返回这个东西
 res.writeHead(403);//403即可
 res.end("This is a WebSockets server!\n");
}).listen(3000, () => console.log('Listen Port on 3000'));
  
  
var wss = new ws.Server( { server: server } );//把创建好的https服务器丢进websocket的创建函数里，ws会用这个服务器来创建wss服务
//同样，如果丢进去的是个http服务的话那么创建出来的还是无加密的ws服务
wss.on( 'connection', ws => {

    //連結時執行此 console 提示
    console.log('Client connected')

    //當 WebSocket 的連線關閉時執行
    ws.on('close', () => {
        console.log('Close connected')
    })
});