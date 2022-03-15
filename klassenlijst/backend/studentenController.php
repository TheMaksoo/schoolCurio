<?php

//Variabelen vullen
$naam = $_POST['naam'];
if(empty($naam))
{
   $errors[] = "Vul een naam in.\n";
}
$leeftijd = $_POST['leeftijd'];
if(!is_numeric($leeftijd))
{
   $errors[] = "Vul een getal in.\n";
}
$geboortedatum = $_POST['geboortedatum'];
if(empty($geboortedatum))
{
   $errors[] = "Vul een geboorte datum in.\n";
}
$woonplaats = $_POST['woonplaats'];
$ingeschreven = $_POST['ingeschreven'];

if(isset ($errors))
{
    var_dump($errors);
    die();
}

//1. Verbinding
require_once 'conn.php';

//2. Query
$query = "INSERT INTO meldingen(naam, leeftijd, geboortedatum, woonplaats, ingeschreven)
VALUES (:naam, :leeftijd, :geboortedatum, :woonplaats, :ingeschreven)";

//3. Prepare
$statement = $conn->prepare($query);

//4. Execute    
$statement->execute([
    ":naam" => $naam,
    ":leeftijd" => $leeftijd,
    ":geboortedatum" => $geboortedatum,
    ":woonplaats" => $woonplaats,
    ":ingeschreven" => $ingeschreven,
]);
