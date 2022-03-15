<!DOCTYPE html>
<html lang="nl">

    <head>
        <title>Curio Software Developers</title>

        <meta charset="utf-8">
        <meta name="viewport" content="width=device-width, initial-scale=1">

        <link rel="apple-touch-icon" sizes="180x180" href="apple-touch-icon.png">
        <link rel="icon" type="image/png" sizes="32x32" href="favicon-32x32.png">
        <link rel="icon" type="image/png" sizes="16x16" href="favicon-16x16.png">
        <link rel="manifest" href="site.webmanifest">
        <link rel="mask-icon" href="safari-pinned-tab.svg" color="#004c35">
        <meta name="msapplication-TileColor" content="#ebf2f0">
        <meta name="theme-color" content="#ebf2f0">

        <link rel="stylesheet" href="css/normalize.css">
        <link rel="stylesheet" href="css/main.css">
        <link rel="preconnect" href="https://fonts.gstatic.com">
        <link href="https://fonts.googleapis.com/css2?family=Big+Shoulders+Stencil+Display:wght@700&family=Inconsolata&display=swap" rel="stylesheet">

        <script src="https://kit.fontawesome.com/43363efb2f.js" crossorigin="anonymous"></script>
    </head>

    <body>

        <?php 
        require_once ('includes/header.php');
        require_once ('includes/banner.php');
        require_once ('includes/pra.php');
        require_once ('includes/windev.php');
        require_once ('includes/webdev.php');
        require_once ('includes/pro.php');
        require_once ('includes/digit.php');
        require_once ('includes/footer.php');
        ?>
        
        <script type="text/javascript">
            document.getElementById('readmore-link').addEventListener('click', function () {
                document.getElementById('readmore-text').style.display = "inline";
                document.getElementById('readmore-link').style.display = "none";
            });
        </script>

    </body>

</html>
