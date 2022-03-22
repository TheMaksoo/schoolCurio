<?php
session_start();
$action = $_POST['action'];

if(!isset($_SESSION['user_id']))
{
    $msg = "Je moet eerst inloggen!";
    header("Location: $base_url/login.php?msg=$msg");
    exit;
}
$id = $_POST['id'];
$date = $_POST['date'];
$duration = $_POST['duration'];
$department = $_POST['department'];
$user = $_SESSION['user_id'];
if($action == 'create')
{  
    if(empty($date))
    {
        $errors[] = "Vul een datum in!";
    }
    if(empty($duration))
    {
        $errors[] = "Vul een duur in!";
    }  
    if(empty($department))
    {
        $errors[] = "Vul een afdeling in!";
    }
    if(isset($errors))
    {
        var_dump($errors);
        die();
    }
    require_once 'conn.php';

    $query = "INSERT INTO logs(user, date, duration, department)
    VALUES (:user, :date, :duration, :department)";

    $statement = $conn->prepare($query);

    $statement->execute([
        ":user" => $user,
        ":date" => $date,
        ":duration" => $duration,
        ":department" => $department,
    ]);

    header("Location: ../logs/index.php");
    exit;
}

if($action == "update")
{
    require_once 'conn.php';

    $query = "UPDATE logs SET date = :date, duration = :duration, department = :department, user = :user WHERE id = :id";

    $statement = $conn->prepare($query);

    $statement->execute([
        ":id" => $id,
        ":user" => $user,
        ":date" => $date,
        ":duration" => $duration,
        ":department" => $department,
    ]);
}

if($action == "delete")
{
    require_once 'conn.php';

    $query = "DELETE FROM logs WHERE id = :id";

    $statement = $conn->prepare($query);

    $statement->execute([
    ":id" => $id
    ]);
}
