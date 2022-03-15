<!doctype html>
<html lang="nl">

<head>
    <title>Klassenlijst / Studenten / Nieuw</title>
    <?php require_once '../head.php'; ?>
</head>

<body>

    <?php require_once '../header.php'; ?>

    <div class="container">
        <h1>Nieuwe student</h1>

        <form action="../backend/studentenController.php" method="POST">
        
            <div class="form-group">
                <label for="naam">Naam:</label>
                <input type="text" name="naam" id="naam" class="form-input">
            </div>
            <div class="form-group">
                <label for="leeftijd">Leeftijd:</label>
                <input type="number" min="0" value="18" name="leeftijd" id="leeftijd" class="form-input">
            </div>
            <div class="form-group">
                <label for="type">Woonplaats:</label>
                <input type="text" name="woonplaats" id="woonplaats" class="form-input">
            </div>
            <div class="form-group">
                <label for="niveau">Niveau</label>
                <select name="niveau" id= "niveau">
                    <option value=""> - Kies je niveau - </option>
                    <option value="niveau 1"> - 1 - </option>
                    <option value="niveau 2"> - 2 - </option>
                    <option value="niveau 3"> - 3 - </option>
                    <option value="niveau 4"> - 4 - </option>
                </select>
            </div>
            <div  class="form-group">
                <label for="ingeschreven">Ingeschreven:</label>
                <input type="checkbox" name="ingeschreven" id="ingeschreven">
                <label for="ingeschreven">Student is ingeschreven</label>
            </div>
            <div class="form-group">
                <label for="geboortedatum">Geboortedatum:</label>
                <input type="date" name="geboortedatum" id="geboortedatum" class="form-input">
            </div>
            
            <input type="submit" value="Student opslaan">

        </form>
    </div>  

</body>

</html>
