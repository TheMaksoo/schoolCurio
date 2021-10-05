<?php
	session_start();
?>

<!DOCTYPE html>
<html>
	<head>
		<title>My Portfolio</title>
		<meta charset="UTF-8">
		<link rel="icon" type="image/png" href="/myportfolio/img/icon.png"/>
		<link rel="stylesheet" type="text/css" href="/myportfolio/css/styles.css">
		<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
	</head>
	<body class="background">
		<main>
			<div class="global">
				<div class="logo">
					<a href="/myportfolio/index.html"><img src="/myportfolio/img/Maxpfp.jpg"  alt="Max pfp" style="border-radius: 20px;  padding: 10px 10px 10px; margin-bottom: 5px;	width:40px; height:40px; background-color: #303136;"></a>
				</div>
				<div class="topnav">
					<?php
					if (isset($_SESSION["useruid"])) {
						echo "<a href='index.php'>My Portfolio</a>";
						echo "<a href='hobbies.php'>Hobbies</a>";
						echo "<a href='projects.php'>Projects</a>";
						echo "<a href='aboutme.php'>About me</a>";
						echo "<a href='playlist.php'>Playlist</a>";
						echo "<a href='groceries.php'>Groceries</a>";
						echo "<a href='logout.php'>Logout</a>";
					}
					else { 
						echo "<a href='index.php'>My Portfolio</a>";
						echo "<a href='aboutme.php'>About me</a>";
						echo "<a href='loginpage.php'>Login</a>";
					}
					?>
				</div>	
			</div>
		</main>	
	</body>
</html>	