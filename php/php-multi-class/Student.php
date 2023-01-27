<?php
include_once('Person.php');

class Student extends Person
{
    public function __construct($age, $name)
    {
        $this->age = $age;
        $this->name = $name;
    }
}
