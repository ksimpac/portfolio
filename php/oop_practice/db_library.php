<?php

	class db_connection
	{	
		private $dsn = ''; //參數設定
		private $db_username = ''; //登入資料庫的帳號
		private $db_password = ''; //登入資料庫的密碼

		function __construct($db_name,$db_username,$db_password) //建構式
		{
			$this->dsn = 'mysql:host=localhost;dbname='.$db_name.';charset=utf8'; //資料庫連線字串參數
			$this->db_username = $db_username;
			$this->db_password = $db_password;
		}
		
		public function connect() //確認是否連線成功
		{
			$connection = new PDO($this->dsn,$this->db_username,$this->db_password); //跟資料庫連線
			
			
			if(!$connection) //如果連不到資料庫
			{
				return NULL; //回傳NULL
			}
			else
			{
				$connection->exec("set names utf8");
				return $connection; //回傳變數
			}
		}
		
		function __destruct() //結束時自動執行跟資料庫斷線(disconnect)
		{
			$this->connection = null;
		}
		
	}
?>
