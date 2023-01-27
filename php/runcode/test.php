<?php
class Alpha 
{
    public static function getClassname() 
    {
        echo __CLASS__;
    }

    public static function printClass() 
    {
        self::getClassname();
    }
}

class Beta extends Alpha 
{
    public static function getClassname() 
    {
        echo __CLASS__;
    }
}

Beta::printClass();