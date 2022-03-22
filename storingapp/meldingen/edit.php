<!doctype html>
<html lang="nl">

<head>
    <title>StoringApp / Meldingen / Aanpassen</title>
    <?php require_once '../head.php';?>
</head>

<body>

    <?php 
    require_once '../header.php'; 
    if(!isset($_SESSION['user_id']))
    {
        $msg = "Je moet eerst inloggen!";
        header("Location: $base_url/login.php?msg=$msg");
        exit;
    }
    
    require_once '../backend/conn.php';
    $id = $_GET['id'];
    $query = "SELECT * FROM meldingen WHERE id = :id";
    $statement = $conn->prepare($query);
    $statement->execute([":id" => $id]);
    $meldingen = $statement->fetchAll(PDO::FETCH_ASSOC);

    ?>

    <div class="container">
        <h1>Melding Aanpassen</h1>

        <form action="../backend/meldingenController.php" method="POST">
            <input type="hidden" name="action" value="edit">
            <input type="hidden" name="id" value="<?php echo $id; ?>">
            <div class="form-group">
                <label for="attractie">Naam attractie:</label>
                <?php echo "<input type='text' name='attractie' id='attractie' class='form-input' value='{$meldingen[0]['attractie']}'>" ?>
            </div>
            <div class="form-group">
                <label for="type">Type</label>
                <select name="type" id= "type">
                    <option value=""> - Kies attractie type - </option>
                    <option value="Water" <?= ($meldingen[0]['type']== "Water")? "selected":"";?>> - Water - </option>
                    <option value="Achtbaan" <?= ($meldingen[0]['type']== "Achtbaan")? "selected":"";?>> - Achtbaan - </option>
                    <option value="Anders" <?= ($meldingen[0]['type']== "Anders")? "selected":"";?>> - Anders - </option>
                </select>
            </div>
            <div class="form-group">
                <label for="capaciteit">Capaciteit p/uur:</label>
                <?php echo "<input type='number' min='0' name='capaciteit' id='capaciteit' class='form-input' value='{$meldingen[0]['capaciteit']}'>" ?>
            </div>
            <div  class="form-group">
                <label for="newsletter">Prio:</label>
                <input type="checkbox" name="prioriteit" id="prioriteit" <?= ($meldingen[0]['prioriteit']== 1)? "checked":"";?>>
                <label for="newsletter">Melding met prioriteit!</label>
            </div>
            <div class="form-group">
                <label for="melder">Naam melder:</label>
                <?php echo "<input type='text' name='melder' id='melder' class='form-input' value='{$meldingen[0]['melder']}'>" ?>
            </div>
            <div  class="form-group">
                <label for="overige_info">Overige info:</label>
                <textarea name='overige_info' id='overige_info' class='form-input' rows='4'><?php echo "{$meldingen[0]['overige_info']}"?></textarea>
            </div>
            <input type="submit" value="Update melding">
        </form>
        <form action="../backend/meldingenController.php" method="POST">
            <input type="hidden" name="action" value="remove">
            <input type="hidden" name="id" value="<?php echo $id; ?>">
            <input type="submit" value="Verwijder melding">
        </form>
    </div>  

</body>

</html>
