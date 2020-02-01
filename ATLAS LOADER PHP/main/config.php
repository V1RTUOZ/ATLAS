<?php

$host = "YOUR HOST, EX: LOCALHOST";
$dbname = "YOUR DB NAME";
$username = "YOUR DB USERNAME";
$password = "YOUR DB PASSWORD";

try{
    $db = new PDO("mysql:host=$host;dbname=$dbname", $username, $password);
}catch(Exception $e){
    die("Fatal error: ".$e->getMessage());
}
