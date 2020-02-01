<?php

$host = "localhost";
$dbname = "loader";
$username = "yume";
$password = "g15021373";

try{
    $db = new PDO("mysql:host=$host;dbname=$dbname", $username, $password);
}catch(Exception $e){
    die("Fatal error: ".$e->getMessage());
}
