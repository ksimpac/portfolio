<?php
class Model
{
    protected static $db;
    protected $table = 'table';
    protected $data = [];

    public static function setDb(Database $db)
    {
        self::$db = $db;
    }

    public function __construct($data)
    {
        $this->data = $data;
    }

    public function save()
    {
        self::$db->insert($this->table, $this->data);
    }
}
