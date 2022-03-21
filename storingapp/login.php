<!doctype html>
<html lang="nl">

<head>
    <title>login</title>
    <?php require_once 'backend/config.php'; ?>
   
</head>

<body>
    <?php require_once 'head.php'; ?>
    <div class="container home">
        <?php if(isset($_GET['msg']))
            {
                echo "<div class='msg'>" . $_GET['msg'] . "</div>";
            } ?>
        <form action="backend/loginController.php" method="POST">
            <input type="text" name="username" placeholder="user">
            <input type="password" name="password" placeholder="pass">
            <input type="submit" name="Log in">
        </form>
    </div>

</body>
</html>
