<?php
class Person
{
    public $name;
    protected $age;

    public function selfIntroduction()
    {
        return 'Hello, My name is ' . $this->name;
    }
}
