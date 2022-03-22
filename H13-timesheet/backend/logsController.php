<?php
session_start();
$action = $_POST['action'];

if($action == 'create')
{
    //Validatie
    $date = $_POST['date'];
    if(empty($date))
    {
        $errors[] = "Vul een datum in!";
    }

    $duration = $_POST['duration'];
    if(empty($duration))
    {
        $errors[] = "Vul een duur in!";
    }

    $department = $_POST['department'];
    if(empty($department))
    {
        $errors[] = "Vul een afdeling in!";
    }

    //Evt. errors dumpen
    if(isset($errors))
    {
        var_dump($errors);
        die();
    }

    $user = $_SESSION['user_id'];

    //Query
    //TODO: vijfstappenplan met INSERT-query

    header("Location: ../logs/index.php");
    exit;
}

if($action == "update")
{

}

if($action == "delete")
{

}
