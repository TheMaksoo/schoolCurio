<?php
    include_once 'header.php';
    ?> 
<!DOCTYPE html>
<html>
    <body>
        <div class="global">
            <div class="container">
                <h1>Calculator</h1>
            </div>
            <div class="container">
                <p class="box">Fraction Calculator</p>
                <input class="calc-input"type="number" id="n1">
                <select class="selector" id="operation">
                    <option value="1">X</option>
                    <option value="2">/</option>
                    <option value="3">+</option>
                    <option value="4">-</option>
                </select>
                <input class="calc-input" type="number" id="n2">
                <br>
                <input class="calc-input"type="number" id="n3">
                <input class="calc-input"type="number" id="n4" style="margin-left:37px">
                <br>
                <button style="margin-left:130px" ; onClick="document.getElementById('fraction').innerHTML=option()">Go!</button>
                <p id="fraction"></p>
            </div>
        </div>
    </body>
    <script>
        function option() {
        selection = document.getElementById('operation').value;


        if (selection == "1") {

            a = multiply();
            return a
        } else if (selection == "2") {
            b = division();
            return b
        } else if (selection == "3") {
            c = addition();
            return c
        } else {
            d = subtraction();
            return d
        }
        }


        function multiply() {
        Number1 = parseInt(document.getElementById("n1").value);
        Number2 = parseInt(document.getElementById("n2").value);
        Number3 = parseInt(document.getElementById("n3").value);
        Number4 = parseInt(document.getElementById("n4").value);


        var topm = Number1 * Number2;
        var botm = Number3 * Number4;

        return topm + "/" + botm;
        }

        function division() {
        Number1 = parseInt(document.getElementById("n1").value);
        Number2 = parseInt(document.getElementById("n2").value);
        Number3 = parseInt(document.getElementById("n3").value);
        Number4 = parseInt(document.getElementById("n4").value);

        var topm2 = Number1 * Number4
        var botm2 = Number2 * Number3
            //return [topm2, botm2]
        return topm2 + "/" + botm2
        }

        function addition() {
        Number1 = parseInt(document.getElementById("n1").value);
        Number2 = parseInt(document.getElementById("n2").value);
        Number3 = parseInt(document.getElementById("n3").value);
        Number4 = parseInt(document.getElementById("n4").value);

        var topm3 = Number1 * Number4 + Number2 * Number3
        var botm3 = Number3 * Number4
            //return [topm3, botm3]
        return topm3 + "/" + botm3
        }

        function subtraction() {
        Number1 = parseInt(document.getElementById("n1").value);
        Number2 = parseInt(document.getElementById("n2").value);
        Number3 = parseInt(document.getElementById("n3").value);
        Number4 = parseInt(document.getElementById("n4").value);

        var topm4 = Number1 * Number4 - Number2 * Number3
        var botm4 = Number3 * Number4
            //return [topm4, botm4]
        return topm4 + "/" + botm4
        }
    </script>
</html>
<?php
    include_once 'footer.php';
    ?>