<!doctype html>
<html lang="nl">

<head>
    <title>Klassenlijst / Studenten</title>
    <?php require_once '../head.php'; ?>
</head>

<body>

    <?php require_once '../header.php'; ?>
    
    <div class="container">
        <h1>Studenten</h1>
        <a href="create.php">Nieuwe student &gt;</a>

        <?php if(isset($_GET['msg']))
        {
            echo "<div class='msg'>" . $_GET['msg'] . "</div>";
        } ?>

        <div style="height: 300px; background: #ededed; display: flex; justify-content: center; align-items: center; color: #666666;">(hier komt de lijst met studenten)</div>
    </div>  

</body>

</html>
