<?php
// Dit blok NIET aanpassen:
        //
        //Gegevens medewerker - NIET AANPASSEN:
        $voornamen = ["jan", "piet", "klaas", "hans", "roel", "ben", "job"];
        $achternamen = ["Jansen", "Klaassen", "Hansen", "Roelsen", "Jobema"];
        $medewerker['voornaam'] = $voornamen[rand(0, count($voornamen)-1)];
        $medewerker['achternaam'] = $achternamen[rand(0, count($achternamen)-1)];
        $medewerker['bedrijf'] = "acme nv";
        $medewerker['email'] = substr($medewerker['voornaam'], 0, 1) . "." . strtolower($medewerker['achternaam']) . "@acme.nv";
        $medewerker['opbrengst'] = rand(10000,999999);
        $medewerker['gewerkte_dagen'] = rand(10,99);
        $medewerker['foto'] = "https://avatars.dicebear.com/api/human/".uniqid().".svg";
        //
        //Gegevens auto's - NIET AANPASSEN:
        $merken = ["toyota", "hyundai", "lexus"];
        for($i = 0; $i < 10; $i++)
        {
            $autos[$i]['teller'] = rand(1000, 9999);
            $autos[$i]['merk'] = $merken[rand(0, count($merken)-1)];
        }
        //
// Tot hier niet aanpassen
?>


<!-- Maak hier opdracht 5.2: -->
<h1><?php echo ucfirst($medewerker['voornaam']); ?></h1>
<p><em><?php echo strtoupper($medewerker['bedrijf']); ?></em></p>
<p>Gemiddelde opbrengst: &euro;<?php echo round(($medewerker['opbrengst'] / $medewerker['gewerkte_dagen']), 2);?></p>
<hr>

<!-- Maak hier opdracht 5.3 (tussen de foreach): -->
<?php foreach($autos as $auto):?> 
<p><?php echo ucfirst($auto['merk']); ?>, <?php echo $auto['teller']; ?>KM</p>    

    

<?php endforeach; ?>
</hr>

<!-- Maak hier opdracht 5.4: -->
<style>
	.persoon{
		font-family: Arial;
		border: 4px dashed gray;
        display: flex;
	}
</style>

<div class="persoon">
    <img src="<?php echo $medewerker['foto'];?>" alt="medewerker"  height="100">
        
    <p><strong><?php echo ucfirst($medewerker['voornaam']); ?> <?php echo ucfirst($medewerker['achternaam']); ?></strong><br><br><em><?php echo strtoupper($medewerker['bedrijf']); ?><br><br><?php echo strtoupper($medewerker['email']); ?></em></p>

</div>
