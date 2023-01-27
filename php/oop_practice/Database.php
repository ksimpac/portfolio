<?php
abstract class Database
{
    public function __construct()
    {
        $this->connect();
    }

    abstract public function connect();

    abstract public function query($sql, $values);

    public function quoteIdentifier($col)
    {
        return $col;
    }

    public function insert($table, array $bind)
    {
        $cols = [];
        $vals = [];
        foreach ($bind as $col => $val) {
            $cols[] = $this->quoteIdentifier($col);
            $vals[] = '?';
        }

        $sql = "INSERT INTO"
            . $this->quoteIdentifier($table)
            . ' (' . implode(', ', $cols) . ') '
            . 'VALUES (' . implode(', ', $vals) . ')';

        return $this->query($sql, $bind);
    }
}
