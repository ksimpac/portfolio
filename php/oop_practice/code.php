<?php
include_once('User.php');
include_once('MySqliDriver.php');

User::setDb(new MysqliDriver());

$user1 = new User([
    'firstname' => 'John',
    'lastname' => 'Doe',
    'email' => 'john@example.com',
]);

$user1->save();
