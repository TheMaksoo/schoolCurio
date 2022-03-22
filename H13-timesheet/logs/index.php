<!doctype html>
<html lang="nl">

<head>
    <title>TimeSheet / Logs</title>
    <?php require_once '../head.php'; ?>
</head>

<body>

    <?php require_once '../header.php'; ?>
    <div class="container">

        <h1>TimeSheet / Logs</h1>
        <a href="create.php">Nieuwe log maken &gt;</a>

        <?php
        require_once '../backend/conn.php';
        $filter = "";
        if (isset($_GET['status']))
        {
            $filter = $_GET['status'];  
            $query = "SELECT * FROM logs WHERE department = :department ORDER BY date DESC";
            $statement = $conn->prepare($query);
            $statement->execute([
                ":department" => $_GET['status']
                ]);
        }
        else{
            $query = "SELECT * FROM logs ORDER BY date DESC";
            $statement = $conn->prepare($query);
            $statement->execute();
        }
        
        
        $logs = $statement->fetchAll(PDO::FETCH_ASSOC);
       
         
        
        ?>
        <div class="extrainfo"> 
            <p>Aantal logs:<strong><?php echo count($logs); ?></strong></p>

            <form action="" method="GET">
                <select name="status">
                    <option value=""> - kies afdeling om te filteren - </option>
                    <option value="attracties"<?= ($filter == "attracties")? "selected":"attracties";?>>Attracties</option>
                    <option value="horeca"<?= ($filter == "horeca")? "selected":"horeca";?>>Horeca</option>
                    <option value="techniek"<?= ($filter == "techniek")? "selected":"techniek";?>>Techniek</option>
                    <option value="groen"<?= ($filter == "groen")? "selected":"groen";?>>Groen</option>
                    <option value="klantenservice"<?= ($filter == "klantenservice")? "selected":"klantenservice";?>>Klantenservice</option>
                    <option value="personeel"<?= ($filter == "personeel")? "selected":"personeel";?>>Personeel</option>
                    <option value="inkoop"<?= ($filter == "inkoop")? "selected":"inkoop";?>>Inkoop</option>
                    
                </select>
                <input type="submit" value="filter">
            </form>
        </div>
        <table>
            <tr>
                <th>Duur</th>
                <th>Afdeling</th>
                <th>Datum &downarrow;</th>
                <th>Gebruikers-id</th>
                <th>Aanpassen</th>
            </tr>
            <?php foreach($logs as $log): ?>
                <tr>
                    <td><?php echo $log['duration']; ?>u</td>
                    <td><?php echo ucfirst($log['department']); ?></td>
                    <td><?php echo $log['date']; ?></td>
                    <td>#<?php echo $log['user']; ?></td>
                    <td><?php echo "<a href='edit.php?id={$log['id']}'>Aanpassen</a>"; ?></td>
                </tr>
            <?php endforeach; ?>
        </table>


    </div>

</body>

</html>
