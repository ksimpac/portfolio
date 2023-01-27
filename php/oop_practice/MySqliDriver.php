<?php
include_once('Database.php');

class MysqliDriver extends Database
{
    private $conn = null;

    public function connect()
    {
        $this->conn = new mysqli('localhost', 'root', '', 'test');
    }

    public function quoteIdentifier($col)
    {
        return '`' . $col . '`';
    }

    public function query($sql, $values)
    {
        $binds = [];
        $types = str_pad('', count($values), 's');
        $binds[] = &$types;
        foreach ($values as $key => $value) {
            $binds[] = &$value[$key];
        }

        $stmt = $this->conn->prepare($sql);
        call_user_func_array([$stmt, 'bind_param'], $binds);
        $stmt->execute();
        $stmt->close();
    }
}
