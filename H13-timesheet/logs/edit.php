<!doctype html>
<html lang="nl">

<head>
    <title>TimeSheet / Logs / Nieuw</title>
    <?php require_once '../head.php'; ?>
</head>

<body>

    <?php require_once '../header.php'; 
    if(!isset($_SESSION['user_id']))
    {
        $msg = "Je moet eerst inloggen!";
        header("Location: $base_url/login.php?msg=$msg");
        exit;
    }
    require_once '../backend/conn.php';
    $id = $_GET['id'];
    $query = "SELECT * FROM logs WHERE id = :id";
    $statement = $conn->prepare($query);
    $statement->execute([":id" => $id]);
    $log = $statement->fetch(PDO::FETCH_ASSOC);

    if($_SESSION['user_id'] != $log["user"])
    {
        $msg = "Je moet eerst met correcte gebruiker inloggen!";
        header("Location: $base_url/login.php?msg=$msg");
        exit;
    }
     ?>
    <div class="container">

        <h1>TimeSheet / Logs / Nieuw</h1>

        <form action="../backend/logsController.php" method="POST">
            <input type="hidden" name="action" value="update">
            <input type="hidden" name="id" value="<?php echo $id; ?>">
        
            <div class="form-group">
                <label for="date">Datum:</label>
                <?php echo "<input type='date' name='date' id='date' class='form-input' value='{$log['date']}'>"?>
            </div>
            <div class="form-group">
                <label for="duration">Duur (uren):</label>
                <?php echo "<input type='number' name='duration' id='duration' class='form-input' value='{$log['duration']}'>"?>
            </div>
            <div class="form-group">
                <label for="department">Afdeling:</label>
                <select name="department" id= "department">
                    <option value="" > - Kies afdeling - </option>
                    <option value="personeel" <?= ($log['department']== "personeel")? "selected":"personeel";?>> - personeel - </option>
                    <option value="horeca" <?= ($log['department']== "horeca")? "selected":"horeca";?>> - horeca - </option>
                    <option value="techniek" <?= ($log['department']== "techniek")? "selected":"techniek";?>> - techniek - </option>
                    <option value="inkoop" <?= ($log['department']== "inkoop")? "selected":"inkoop";?>> - inkoop - </option>
                    <option value="klantenservice" <?= ($log['department']== "klantenservice")? "selected":"klantenservice";?>> - klantenservice - </option>
                    <option value="groen" <?= ($log['department']== "groen")? "selected":"groen";?>> - groen - </option>
                    <option value="attacties" <?= ($log['department']== "attacties")? "selected":"attacties";?>> - attracties - </option>
                </select>
            </div>


            <input type="submit" value="Log opslaan">


    </div>

</body>

</html>
