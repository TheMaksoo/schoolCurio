<!doctype html>
<html lang="nl">

<head>
    <title>StoringApp / Meldingen / Nieuw</title>
    <?php require_once '../head.php';?>
</head>

<body>

    <?php require_once '../header.php';
    if(!isset($_SESSION['user_id']))
    {
        $msg = "Je moet eerst inloggen!";
        header("Location: $base_url/login.php?msg=$msg");
        exit;
    }
    ?>
    
    <div class="container">
        <h1>Nieuwe melding</h1>

        <form action="../backend/meldingenController.php" method="POST">
            <input type="hidden" name="action" value="create">
            <div class="form-group">
                <label for="attractie">Naam attractie:</label>
                <input type="text" name="attractie" id="attractie" class="form-input">
            </div>
            <div class="form-group">
                <label for="type">Type</label>
                <select name="type" id= "type">
                    <option value=""> - Kies attractie type - </option>
                    <option value="Water"> - Water - </option>
                    <option value="Achtbaan"> - Achtbaan - </option>
                    <option value="Anders"> - Anders - </option>
                </select>
            </div>
            <div class="form-group">
                <label for="capaciteit">Capaciteit p/uur:</label>
                <input type="number" min="0" name="capaciteit" id="capaciteit" class="form-input">
            </div>
            <div  class="form-group">
                <label for="newsletter">Prio:</label>
                <input type="checkbox" name="prioriteit" id="prioriteit">
                <label for="newsletter">Melding met prioriteit!</label>
            </div>
            <div class="form-group">
                <label for="melder">Naam melder:</label>
                <input type="text" name="melder" id="melder" class="form-input">
            </div>
            <div  class="form-group">
                <label for="overige_info">Overige info:</label>
                <textarea name="overige_info" id="overige_info" class="form-input" rows="4"></textarea>
            </div>
            <input type="submit" value="Verstuur melding">

        </form>
    </div>  

</body>

</html>
