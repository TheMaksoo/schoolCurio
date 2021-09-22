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
                    <a href="index.php">My portfolio</a>
                    <p>Website als navigator voor websites /  Opdrachten.</p>
                    <a href="/myportfolio/smartcafe/index.html">Smartcafe</a>
                    <p>Opdracht 1 restuarant menu maken.</p>
                    <a href="/myportfolio/microbit/index.html">Micro:Bit</a>
                    <p>Alle codes gemaakt met / voor de micro bit.</p>
                    
                    <button class="dropbutton"  id="buttonA" onclick="dropdown()"><span>See more </span></button>
                    <button class="dropbutton"  id="buttonB" onclick="dropdown()"><span>See less </span></button>
                    <div id="dropdown-content">
                        <div id="dropdown_content">
                            <a href="hobbies.php">Hobbies</a>
                            <p>Webpagina voor mijn hobbies.</p>
                            <a href="projects.php">Projects</a>
                            <p>Webpagina waar ik al mijn projecten in heb.</p>
                            <a href="aboutme.php">About me</a>
                            <p>Webpagine met uitleg en info over mij.</p>
                            <a href="playlist.php">Playlist</a>
                            <p>Webpagina met nu mijn meest geluisterde nummers.</p>
                            <a href="groceries.php">Groceries</a>
                            <p>Webpagina met mijn boodshappen...</p>
                            <a href="/myportfolio/song/bungee_gum.html">Favorite song</a>
                            <p>Webpagine / medial speler met een nummer.</p>
                        </div>
                    </div>
                </div>
            </div>
        </div>

    <script>
        var x = document.getElementById("dropdown_content");
        x.style.display = "none";
        var x = document.getElementById("buttonB");
        x.style.display = "none";
        function dropdown() {
        var x = document.getElementById("dropdown_content");
        if (x.style.display === "none") 
        {
            x.style.display = "block";
        } 
        else 
        {
            x.style.display = "none";
        }
        var x = document.getElementById("buttonA");
        if (x.style.display === "none") 
        {
            x.style.display = "inline-block";
        } 
        else 
        {
            x.style.display = "none";
        }
        var x = document.getElementById("buttonB");
        if (x.style.display === "none") 
        {
            x.style.display = "inline-block";
        } 
        else 
        {
            x.style.display = "none";
        }
        }
    </script>


    </body>
</html>
<?php
    include_once 'footer.php';
    ?>