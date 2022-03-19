<!doctype html>
<html lang="nl">

<head>
    <title>Prikbord / Aanpassen</title>
    <?php require_once '../head.php'; ?>
</head>

<body>

    <?php require_once '../header.php'; ?>

    <div class="container">
        <h1>Aanpassen bericht</h1>

        <?php
        require_once '../backend/conn.php';
        //Haal id uit de URL
        $id = $_GET['id'];
        $query = "SELECT * FROM berichten WHERE id = :id";
        $statement = $conn->prepare($query);
        $statement->execute([":id" => $id]);
        $berichten = $statement->fetch(PDO::FETCH_ASSOC);

        ?>

        <!-- Formulier voor edit: -->
        <form action="../backend/berichtenController.php" method="POST">
            <input type="hidden" name="action" value="edit">
            <input type="hidden" name="id" value="<?php echo $id; ?>">
            
            <!-- Voeg hier de andere velden toe -->
            <div class="form-group">
                <label for="title">Title:</label>
                <?php echo "<input type='text' name='title' id='title' class='form-input' value='{$berichten['title']}'>" ?>
            </div>
            <div class="form-group">
                <label for="content">Overige info:</label>
                <textarea name='content' id='content' class='form-input' rows='4'><?php echo "{$berichten['content']}"?></textarea>
            </div>
            <input type="submit" value="Edit bericht">
        </form>

        <!-- Formulier voor delete: -->
        <form action="../backend/berichtenController.php" method="POST">
            <input type="hidden" name="action" value="...">
            <!-- Voeg hier nog een veld toe -->
            <input type="submit" value="Verwijder bericht">
        </form>

    </div>  

</body>

</html>
