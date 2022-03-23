<?php

session_start();
$username = $_POST['username'];
$pass = $_POST['password'];

//Check of iemand níet is ingelogd
/// TODO: start sessie
if(isset($_SESSION['user_id']))
{
    die("Kan niet registreren je bent al ingelogd");
}
$email = $_POST['email'];
if(filter_var ($email, FILTER_VALIDATE_EMAIL) == false)
{
    die('Email is ongeldig!');
}
//Kernbegrip 17, stap 2b:
$password = $_POST['password'];
$passwordrepeat = $_POST['passwordrepeat'];
if( $password != $passwordrepeat)
{
    die("Wachtwoorden zijn niet gelijk!");
}
//Kernbegrip 17, stap 2c:
require_once 'conn.php';
$query = "SELECT * FROM users WHERE username = :email";
$statement = $conn->prepare($query);
$statement->execute([":email" => $email]);
$emailinfo = $statement->fetch(PDO::FETCH_ASSOC);

if($statement->rowCount() > 0)
{
    die("Email is al in gebruikt.");
}
//Kernbegrip 17, stap 3a:
if(empty($_POST['password']))
{
    die("Wachtwoord mag niet leeg zijn!");
}
$hashed_password = password_hash($password, PASSWORD_DEFAULT);
//Kernbegrip 17, stap 3b:
$query = "INSERT INTO users (username, password, Email, name) VALUES (:username, :hashed_password, :email, :name)";
$statement = $conn->prepare($query);
$statement->execute([
    ":username" => $_POST["username"],
    ":hashed_password" => $hashed_password,
    ":email" => $_POST["email"],
    ":name" => $_POST["name"]
]);
//Stuur naar login:
header("Location:../login.php");
exit;
