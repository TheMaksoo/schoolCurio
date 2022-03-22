<?php

session_start();
$username = $_POST['username'];
$pass = $_POST['password'];

//1. Haal gegevens van gebruiker op, aan de hand van email/username
//   Vijfstappenplan:
//      1. Haal de verbinding erbij
require_once 'conn.php';
//      2. Schrijf de query met placeholders (SELECT * FROM users WHERE .......)
$query = "SELECT * FROM users WHERE username = :user";
//      3. Zet om naar een prepared-statement
$statement = $conn->prepare($query);
//      4. Voer het statement uit
$statement->execute([
    ":user" => $username,
]);
//      5. Haal de gegevens op (tip: je verwacht één resultaat, niet een lijst)
$userinfo = $statement->fetch(PDO::FETCH_ASSOC);


//2. Check of je een resultaat krijgt (anders: account bestaat niet)
//   If-statement, check of "$statement->rowCount()" kleiner is dan 1
if($statement->rowCount() < 1)
{
    $msg = "Account bestaat niet.";
    header("Location:../login.php?msg=$msg");
    exit;
}

//3. Check of het ingevulde wachtwoord klopt met die uit de DB
//   Gebruik hiervoor password_verify(), zie evt. http://php.net/password_verify
if(password_verify($pass, $userinfo["password"]))
{
    $_SESSION['user_id'] = $userinfo["id"];
    $_SESSION["user_name"] = $userinfo["username"];
    header("Location:../meldingen/index.php");
}
//4. Alles alles klopt: stop gebruikersgegevens in de session
//   $_SESSION['user_id'] = ............
//   $_SESSION['user_name'] = ..........


