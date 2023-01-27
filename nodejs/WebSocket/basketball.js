//import express 和 ws 套件
const express = require('express')
const SocketServer = require('ws').Server
const fs = require('fs');
const https = require('https');
const app = express();
let onlineCount = 0;
let onlineid = 0;
//指定開啟的 port
const PORT = 3000;


//創建 express 的物件，並綁定及監聽 3000 port ，且設定開啟後在 console 中提示
var privateKey  = fs.readFileSync(__dirname + '/ssl/private.key');
var certificate = fs.readFileSync(__dirname + '/ssl/certificate.crt');
var credentials = { key: privateKey, cert: certificate };
//const server = express().listen(PORT, () => console.log(`Listening on test ${PORT}`))
var httpsServer = https.createServer(credentials, app).listen(PORT, () => console.log('Listen Port on 3000'));

//將 express 交給 SocketServer 開啟 WebSocket 的服務
const wss = new SocketServer({ server: httpsServer })
wss.getUniqueID = function () {
    function s4() {
        return Math.floor((1 + Math.random()) * 0x10000).toString(16).substring(1);
    }
	onlineid++;
	return onlineid;
    //return s4() + s4() + '-' + s4();
   
};
//-------------
var x,dir_x,dir_y;
var dir=Math.floor(Math.random()*8);  //方向參數	
var center_x=200;   //中心座標
var center_y=200;
var ball_data_buf="";
var start_flg="f"
//--------------
//當 WebSocket 從外部連結時執行
wss.on('connection', ws => {
    //連結時執行此 console 提示
    console.log('Client connected')
	
    ws.id = wss.getUniqueID();
	onlineCount++;
    wss.clients.forEach(function each(client) {
        console.log('Client.ID: ' + client.id+"選球隊及隊員狀態:"+start_flg);
});
    //當 WebSocket 的連線關閉時執行
ws.on('close', () => {
	console.log('Close connected')
	onlineCount--;
	if (onlineCount==0)
	{
		start_flg="f";
		ball_data_buf="";
	}
})
	//對 message 設定監聽，接收從 Client 發送的訊息 再傳給所有連線
    ws.on('message', receive_data => {
		//準備給前台的資料
		//console.log('this Client.ID: ' + ws.id);
		data = JSON.parse(receive_data);
		var out=data.out;
		state=data.state;
		//console.log(out+"ttt");
		switch(out)
		{
		case "取得連線數"	 :			  
			  jsonData=JSON.stringify({
				'out':'取得連線數',
				'connect_cnt':onlineCount,
				'client_id':ws.id,
				'start_flg': start_flg,
				'state': state
				});	
				console.log("連線數"+onlineCount);
			break;	
		case "設備借還"	 :

			  change_flg=data.change_flg;		
			  jsonData=JSON.stringify({
				'out':'設備借還',
				'client_id':ws.id,
				'change_flg':change_flg,
				'start_flg': start_flg,
				'state': state
				});
			break;	
		case "籃球紀錄專利_偕同" :
			change_flg=data.change_flg;
			if (ball_data_buf!="")
			{
			   ball_data_j=JSON.parse(ball_data_buf);
			   main_number_j=ball_data_j.main_number;
			   console.log("2偕同"+main_number_j);
			   state=4;
			   jsonData=JSON.stringify({
				'out':'籃球紀錄專利',
				'client_id':ws.id,
				'change_flg':change_flg,
				'ball_data': ball_data_buf,
				'start_flg': start_flg,
				'state': state
				});
			}
			else
			{
			  	console.log("2偕同 err");
				/*jsonData=JSON.stringify({
				'out':'籃球紀錄專利_err',
				'client_id':ws.id,
				'change_flg':change_flg,
				'ball_data': ball_data_buf,
				'state': state
				});
				*/
			}	
			
			break;
		case "籃球紀錄專利_啟動" :
			start_flg=data.start_flg;
			console.log("啟動:"+start_flg);
			jsonData=JSON.stringify({
				'out':'籃球紀錄專利_啟動',
				'onlineCount':onlineCount,
				'client_id':ws.id,
				'start_flg': start_flg
				});
			break;
		case "籃球紀錄專利" :
		     change_flg=data.change_flg;
			 ball_data=data.ball_data;
			 state=data.state;
			//console.log("1偕同"+main_number);			
			if (ball_data_buf=="")
			{
				ball_data_buf=ball_data;
				state=4;
			}
			switch (state)
			{
			case 5:
			//    console.log("draw");
				ball_data_j0=JSON.parse(ball_data_buf);				
				ball_data_j=JSON.parse(ball_data);
				ball_data_j0.record_a=ball_data_j.record_a;
				ball_data_j0.guest_record_a=ball_data_j.guest_record_a;
				ball_data_j0.sec_record_a=ball_data_j.sec_record_a;
				ball_data_j0.sec_guest_record_a=ball_data_j.sec_guest_record_a;
				ball_data_j0.main_score=ball_data_j.main_score;
				ball_data_j0.guest_score=ball_data_j.guest_score;
				ball_data_j0.main_pnt  =ball_data_j.main_pnt;
				ball_data_j0.guest_pnt =ball_data_j.guest_pnt;
				ball_data_j0.player_no=ball_data_j.player_no;
				ball_data_buf=JSON.stringify(ball_data_j0);
			//	console.log(ball_data_j0);
			break;
			case 6:
				ball_data_j0=JSON.parse(ball_data_buf);				
				ball_data_j=JSON.parse(ball_data);				
				ball_data_j0.quick_a        =ball_data_j.quick_a;
				ball_data_j0.guest_quick_a  =ball_data_j.guest_quick_a;
				ball_data_j0.quick_pnt      =ball_data_j.quick_pnt;
				ball_data_j0.guest_quick_pnt=ball_data_j.guest_quick_pnt;		
				ball_data_buf=JSON.stringify(ball_data_j0);
				break;
			}
			
			  jsonData=JSON.stringify({
				'out':'籃球紀錄專利',
				'onlineCount':onlineCount,
				'client_id':ws.id,
				'change_flg':change_flg,
				'ball_data': ball_data,
				'start_flg': start_flg,
				'state': state
				});
			break;
		case "籃球紀錄專利_renew" :
		     ball_data=data.ball_data;
			 ball_data_buf=ball_data;
			  jsonData=JSON.stringify({
				'out':'籃球紀錄專利',
				'onlineCount':onlineCount,
				'client_id':ws.id,
				'change_flg':change_flg,
				'ball_data': ball_data,
				'start_flg': start_flg,
				'state': state
				});
			break;
		case "亂跑的球"	 :
		    ball_data=data.ball_data;
			dir=data.dir;
			step=10;
			switch (dir)
			{
				case 0:
					dir_x=0;
					dir_y=-step;
					break;
				case 1:
					dir_x=step;
					dir_y=-step;
					break;
				case 2:
					dir_x=step;
					dir_y=0;
					break;
				case 3:
					dir_x=step;
					dir_y=step;
					break;	
				case 4:
					dir_x=0;
					dir_y=step;
					break;
				case 5:
					dir_x=-step;
					dir_y=step;
					break;
				case 6:
					dir_x=-step;
					dir_y=0;
					break;	
				case 7:
					dir_x=-step;
					dir_y=-step;
					break;	
			  }
			  
			  center_x+=dir_x;
			  center_y+=dir_y;
			// 決定是否改變方向
			
			  if (center_x>350)
			  {
				dir=Math.floor(Math.random()*3)+5;		 
			  }
			  if (center_x<50)
			  {
				 dir=Math.floor(Math.random()*3)+1;
			  }
			  if (center_y>390)
			  {
			 
				 dir=Math.floor(Math.random()*3);
				
				 if (dir==2)
				 {
					dir=7;
				 }
				 
			  }
			  if (center_y<50)
			  {
				 dir=Math.floor(Math.random()*3)+3;
			  }
			  /*
			  var jsonData = {};               
			  jsonData["x"] = center_x;
			  jsonData["y"] = center_y;
			  jsonData["speed"] =receive_data["speed"];
			  jsonData["dir"]   =receive_data["dir"];
			  
			  */
			  
			  speed=data.speed;			 
			  jsonData=JSON.stringify({				
				'out':'亂跑的球',
				'client_id':ws.id,
				'change_flg':change_flg,
				'state': state,
				'ball_data': ball_data,
				'x': center_x,
				'y': center_y,
				'speed': speed,
				'start_flg': start_flg,
				'dir': dir
				});
			break;
		}
		//取得所有連接中的 client
		//做迴圈，發送訊息至每個 client
		let clients = wss.clients;
		clients.forEach(client => {
			client.send(jsonData)
		})
	})
/*
     //固定送最新時間給 Client
    const sendNowTime = setInterval(()=>{
        ws.send(String(new Date()))
    },1000)	
*/	
})
