const fs = require('fs');
const https = require('https');
const WebSocket = require('ws');

const server = https.createServer({
  cert: fs.readFileSync(__dirname + '/ssl/private.key'),
  key: fs.readFileSync(__dirname + '/ssl/certificate.crt')
});
const wss = new WebSocket.Server({ server });

wss.on('connection', function connection(ws) {
  ws.on('message', function incoming(message) {
    console.log('received: %s', message);
  });

  ws.send('something');
});

server.listen(8080, () => console.log("Listen on 8080 Port"));