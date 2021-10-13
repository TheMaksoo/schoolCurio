<?php
    include_once 'header.php';
    ?>
<!DOCTYPE html>
<html>
    <body>
        <div class="global">
            <div class="container">
                <h1>Portfolio of Max van Lierop</h1>
            </div>
            <div class="container">
                <div class="container3">
                    <h2>Welkom</h2>
                    <h3>Websites tot nu.</h3>
                    <a href='../borg-consulting/index.html'>Borg Consulting</a>
                    <p>Website voor Borg Consulting gemaakt voor stage.</p>
                    <a href="calculator.php">Calculator</a>
                    <p>Website voor het calculeren van breuken en normaal rekenen.</p>
                    <a href="index.php">My portfolio</a>
                    <p>Website als navigator voor websites / Opdrachten.</p>
                    <a href="smartcafe/index.html">Smartcafe</a>
                    <p>Opdracht 1 restuarant menu maken.</p>
                    <button class="accordion" onclick="dropdown()"><span>Extra</span></button>
                    <div class="panel">
                        <a href="microbit/index.html">Micro:Bit</a>
                        <p>Alle codes gemaakt met / voor de micro bit.</p>
                        <a href="hobbies.php">Hobbies</a>
                        <p>Webpagina voor mijn hobbies.</p>
                        <a href="projects.php">Projects</a>
                        <p>Webpagina waar ik al mijn projecten in heb.</p>
                        <a href="aboutme.php">About me</a>
                        <p>Webpagina met uitleg en info over mij.</p>
                        <a href="playlist.php">Playlist</a>
                        <p>Webpagina met nu mijn meest geluisterde nummers.</p>
                        <a href="groceries.php">Groceries</a>
                        <p>Webpagina met mijn boodshappen...</p>
                        <a href="song/bungee_gum.html">Favorite song</a>
                        <p>Webpagina / medial speler met een nummer.</p>
                    </div>
                </div>
            </div>
        </div>

    <script>
        var acc = document.getElementsByClassName("accordion");
        var i;

        for (i = 0; i < acc.length; i++) {
        acc[i].addEventListener("click", function() {
            this.classList.toggle("active");
            var panel = this.nextElementSibling;
            if (panel.style.maxHeight) {
            panel.style.maxHeight = null;
            } else {
            panel.style.maxHeight = panel.scrollHeight + "px";
            } 
        });
        }
    </script>


    </body>
</html>
<?php
    include_once 'footer.php';
    ?>