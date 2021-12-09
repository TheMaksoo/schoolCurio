<?php 
if(isset($_POST['submit'])){
    $vraag1 = $_POST['vraag1'];
    $vraag2 = $_POST['vraag2'];
    $vraag3 = $_POST['vraag3'];
    $vraag4 = $_POST['vraag4'];
    $vraag5 = $_POST['vraag5'];
    $vraag6 = $_POST['vraag6'];
    $vraag7 = $_POST['vraag7'];
    $vraag8 = $_POST['vraag8'];
    $vraag9 = $_POST['vraag9'];
    $vraag10 = $_POST['vraag10'];
    $score = 0;
    
    if ($vraag1 == 30)
    {
        $score += 1;
    }
    else 
    {
        echo nl2br("\nVraag 1: Juiste antwoord is 30. Jij had " . $vraag1);
    }
    if ($vraag2 == 20)
    {
        $score += 1;
    }
    else 
    {
        echo nl2br("\nVraag 2:Juiste antwoord is 20. Jij had " . $vraag2);
    }
    if ($vraag3 == 100)
    {
        $score += 1;
    }
    else 
    {
        echo nl2br("\nVraag 3: Juiste antwoord is 100. Jij had " . $vraag3);
    }
    if ($vraag4 == 4)
    {
        $score += 1;
    }
    else 
    {
        echo nl2br("\nVraag 4: Juiste antwoord is 4. Jij had " . $vraag4);
    }
    if ($vraag5 == 10000)
    {
        $score += 1;
    }
    else 
    {
        echo nl2br("\nVraag 5: Juiste antwoord is 10000. Jij had " . $vraag5);
    }
    if ($vraag6 == 35)
    {
        $score += 1;
    }
    else 
    {
        echo nl2br("\nVraag 6: Juiste antwoord is 35. Jij had " . $vraag6);
    }
    if ($vraag7 == 15)
    {
        $score += 1;
    }
    else 
    {
        echo nl2br("\nVraag 7: Juiste antwoord is 15. Jij had " . $vraag7);
    }
    if ($vraag8 == 5)
    {
        $score += 1;
    }
    else 
    {
        echo nl2br("\nVraag 8: Juiste antwoord is 5. Jij had " . $vraag8);
    }
    if ($vraag9 == 75)
    {
        $score += 1;
    }
    else 
    {
        echo nl2br("\nVraag 9: Juiste antwoord is 75. Jij had " . $vraag9);
    }
    if ($vraag10 == 6)
    {
        $score += 1;
    }
    else 
    {
        echo nl2br("\nVraag 10: Juiste antwoord is 6. Jij had " . $vraag10);
    }

    
    echo nl2br("\n". $score . "/10");
    }
?>