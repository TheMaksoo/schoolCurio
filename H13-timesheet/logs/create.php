<!doctype html>
<html lang="nl">

<head>
    <title>TimeSheet / Logs / Nieuw</title>
    <?php require_once '../head.php'; ?>
</head>

<body>

    <?php require_once '../header.php'; ?>
    <div class="container">

        <h1>TimeSheet / Logs / Nieuw</h1>

        <form action="../backend/logsController.php" method="POST">
            <input type="hidden" name="action" value="create">
        
            <div class="form-group">
                <label for="date">Datum:</label>
                <input type="date" name="date" id="date" class="form-input" value="<?php echo date("Y-m-d"); ?>">
            </div>
            <div class="form-group">
                <label for="duration">Duur (uren):</label>
                <input type="number" name="duration" id="duration" class="form-input">
            </div>
            <div class="form-group">
                <label for="department">Afdeling:</label>
                <!-- Voeg hier nog een select toe, met deze opties:
                    personeel, horeca, techniek, inkoop, klantenservice, groen, attracties
                -->
            </div>

            <input type="submit" value="Log opslaan">


    </div>

</body>

</html>
