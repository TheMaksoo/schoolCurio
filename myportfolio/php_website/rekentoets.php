<?php
    include_once 'header.php';
    ?> 
<!DOCTYPE html>
<html>
    <body>
        <div class="global">
            <section class="rekentoets-section">
                <div class="rekentoets">
                    <form action="rekentoetscheck.php" method="POST" class="rekentoets-wrapper" id="rekentoets-form">
                        <div class="test-number">
                            <p>Vraag 1:</p>
                            <label for="vraag1">18 + 12 =</label>
                            <input class="number-input" type="name" name="vraag1">
                        </div>
                        <div class="test-number">
                            <p>Vraag 2:</p>
                            <label for="vraag2">100 : 5 =</label>
                            <input class="number-input" type="name" name="vraag2">
                        </div>  
                        <div class="test-number">
                            <p>Vraag 3:</p>
                            <label for="vraag3">1/5 van 500 =</label>
                            <input class="number-input" type="name" name="vraag3">
                        </div>
                        <div class="test-number">
                            <p>Vraag 4:</p>
                            <label for="vraag4">oppervlakte van 2 meter bij 2 meter is.</label>
                            <input class="number-input" type="name" name="vraag4">
                        </div>  
                        <div class="test-number">
                            <p>Vraag 5:</p>
                            <label for="vraag5">10Km is hoeveel meter?</label>
                            <input class="number-input" type="name" name="vraag5">
                        </div>
                        <div class="test-number">
                            <p>Vraag 6:</p>
                            <label for="vraag6">5x7 =</label>
                            <input class="number-input" type="name" name="vraag6">
                        </div>  
                        <div class="test-number">
                            <p>Vraag 7:</p>
                            <label for="vraag7">1/2 van (6x5) =</label>
                            <input class="number-input" type="name" name="vraag7">
                        </div>
                        <div class="test-number">
                            <p>Vraag 8:</p>
                            <label for="vraag8">5% van 100 = </label>
                            <input class="number-input" type="name" name="vraag8">
                        </div>  
                        <div class="test-number">
                            <p>Vraag 9:</p>
                            <label for="vraag9">50 + 150%</label>
                            <input class="number-input" type="name" name="vraag9">
                        </div>
                        <div class="test-number">
                            <p>Vraag 10:</p>
                            <label for="vraag10">wortel van 30</label>
                            <input class="number-input" type="name" name="vraag10">
                        </div>  
                        <Input type="submit" name="submit" value="Submit" class="button"/>
                    </form>
                </div>
            </section> 
        </div>
    </body>
</html>
<?php
    include_once 'footer.php';
    ?>