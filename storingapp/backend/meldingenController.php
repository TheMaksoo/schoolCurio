<?php
session_start();
if(!isset($_SESSION['user_id']))
{
    $msg = "Je moet eerst inloggen!";
    header("Location: $base_url/login.php?msg=$msg");
    exit;
}
//Variabelen vullen
$actie = $_POST['action'];

if($actie != "remove")
{
   $attractie = $_POST['attractie'];
   if(empty($attractie))
   {
      $errors[] = "Vul de attractie-naam in.\n";
   }
   
   $type = $_POST['type'];
   if(empty($type))
   {
      $errors[] = "Selecteer een type.\n";
   }
   
   $capaciteit = $_POST['capaciteit'];
   if(!is_numeric($capaciteit))
   {
      $errors[] = "Vul voor capaciteit een geldig getal in.\n";
   }
   
   $melder = $_POST['melder'];
   if(empty($melder))
   {
      $errors[] = "Geef een naam op.\n";
   }
   
   $overige_info = $_POST['overige_info'];
   
   if(!empty($_POST['id']))
   {
      $id = $_POST['id'];
   }
   
   if(isset ($errors))
   {
       var_dump($errors);
       die();
   }
   
   echo $attractie . " / " . $type . " / " . $capaciteit . " / " . $melder . " / " . $overige_info ;
   if ($_POST["prioriteit"] == true)
   {
      $prioriteit = 1;
   }
   else 
   {
      $prioriteit = 0;
   }
}
//1. Verbinding
require_once 'conn.php';

if ($actie == "create")
{
   //2. Query
   $query = "INSERT INTO meldingen(attractie, type, capaciteit, prioriteit, melder, overige_info)
   VALUES (:attractie, :type, :capaciteit, :prioriteit, :melder, :overige_info)";
   
   //3. Prepare
   $statement = $conn->prepare($query);
   
   //4. Execute
   $statement->execute([
       ":attractie" => $attractie,
       ":type" => $type,
       ":capaciteit" => $capaciteit,
       ":prioriteit" => $prioriteit,
       ":melder" => $melder,
       ":overige_info" => $overige_info
   ]);
   header("Location:../meldingen/index.php?msg=Melding Aangemaakt");
}

if ($actie == "edit")
{
   
   //2. Query
   $query = "UPDATE meldingen SET attractie = :attractie, type = :type, capaciteit = :capaciteit, prioriteit = :prioriteit, melder = :melder, overige_info = :overige_info WHERE id = :id";

   //3. Prepare
   $statement = $conn->prepare($query);

   //4. Execute
   $statement->execute([
      ":attractie" => $attractie,
      ":type" => $type,
      ":capaciteit" => $capaciteit,
      ":prioriteit" => $prioriteit,
      ":melder" => $melder,
      ":overige_info" => $overige_info,
      ":id" => $_POST['id']
   ]);
   header("Location:../meldingen/index.php?msg=Melding Aangepast");
}

if ( $actie == "remove")
{
    //2. Query
    $query = "DELETE FROM meldingen WHERE id = :id";

    //3. Prepare
    $statement = $conn->prepare($query);
 
    //4. Execute
    $statement->execute([
       ":id" => $_POST['id']
    ]);
    header("Location:../meldingen/index.php?msg=Melding Verwijderd");
}


