<?php
$serverName = "localhost";
$dBUsername = "maxvlpqk_Max";
$dBPassword = "AdminTest1!";
$dBName = "maxvlpqk_portfolio";

$conn = mysqli_connect($serverName, $dBUsername, $dBPassword, $dBName);

if (!$conn) { 
    die("Connection Failed:" . mysqli_connect_error());
}