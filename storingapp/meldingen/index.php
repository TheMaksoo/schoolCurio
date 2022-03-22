<!doctype html>
<html lang="nl">

<head>
    <title>StoringApp / Meldingen</title>
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
    ?>
    <div class="container">
        <h1>Meldingen</h1>
        <a href="create.php">Nieuwe melding &gt;</a>

        <?php 
        require_once '../backend/conn.php';

        if(isset($_GET['msg']))
        {
            echo "<div class='msg'>" . $_GET['msg'] . "</div>";
        } 

        if(empty($_GET['status']))
        {
            $query = "SELECT * FROM meldingen";
            $statement = $conn->prepare($query);
            $statement->execute();
            $_GET ['status'] = "";
        }
        else 
        {
            if($_GET ['status'] == 2)
            {
                $_GET ['status'] = 0;
            }
            $query = "SELECT * FROM meldingen WHERE prioriteit = :prioriteit";
            $statement = $conn->prepare($query);
            $statement->execute([
            ":prioriteit" => $_GET['status']
            ]);
        }
        $meldingen = $statement->fetchAll(PDO::FETCH_ASSOC);
            
        ?>
        <div class="extrainfo"> 
            <p>Aantal meldingen:<strong><?php echo count($meldingen); ?></strong></p>

            <form action="" method="GET">
                <select name="status">
                    <option value="" <?= ($_GET['status'] == "")? "selected":"";?>> - kies prioriteit om te filteren - </option>
                    <option value="1"<?= ($_GET['status'] == "1")? "selected":"1";?>>Prioriteit</option>
                    <option value="2"<?= ($_GET['status'] == "0")? "selected":"2";?>>Geen Prioriteit</option>
                </select>
                <input type="submit" value="filter">
            </form>
        </div>
        
        <div style="height: 400px; background: #ededed; display: flex; justify-content: start; align-items: start; color: #666666;">
        <table>
            <tr>
                <th>Attractie</th>
                <th>Prioriteit</th>
                <th>Type</th>
                <th>Capaciteit</th>
                <th>Melder</th>
                <th>Gemeld op</th>
                <th>Overige info</th>
                <th>Aanpassen</th>
            </tr>
            <?php foreach($meldingen as $melding): ?>
                <tr>
                    <td><?php echo ucfirst($melding['attractie']); ?></td>

                    <td><?php 
                    if ($melding['prioriteit'] == 1)
                    {
                        echo "Ja";
                    }
                    else 
                    {
                        echo "Nee";
                    }
                     ?></td>
                    <td><?php echo ucfirst($melding['type']); ?></td>
                    <td><?php echo $melding['capaciteit']; ?></td>
                    <td><?php echo ucfirst($melding['melder']); ?></td>
                    <td><?php echo $melding['gemeld_op']; ?></td>
                    <td><?php echo ucfirst($melding['overige_info']); ?></td>
                    <td><?php echo "<a href='edit.php?id={$melding['id']}'>Aanpassen</a>"; ?></td>
                </tr>
            <?php endforeach; ?>
        </table>
    
        </div>
    </div>  

</body>

</html>
