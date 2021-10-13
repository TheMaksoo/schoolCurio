<?php
	session_start();
?>

<!DOCTYPE html>
<html>
	<head>
		<title>My Portfolio</title>
		<meta charset="UTF-8">
		<link rel="icon" type="image/png" href="../img/icon.png"/>
		<link rel="stylesheet" type="text/css" href="../css/styles.css">
		<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
	</head>
	<body class="background">
		<main>
			<div class="global">
				<div class="logo">
					<a href="../index.html"><img src="../img/Maxpfp.jpg"  alt="Max pfp" style="border-radius: 20px;  padding: 10px 10px 10px; margin-bottom: 5px;	width:60px; height:60px;"></a>
				</div>
				<div class="topnav">
					<?php
					if (isset($_SESSION["useruid"])) {
						echo "<a href='index.php'>My Portfolio</a>";
						echo "<a href='calculator.php'>calculator</a>";
						echo "<a href='../borg-consulting/index.html'>Borg Consulting</a>";
						echo "<a href='logout.php'>Logout</a>";
					}
					else { 
						echo "<a href='index.php'>My Portfolio</a>";
						echo "<a href='loginpage.php'>Login</a>";
					}
					?>
				</div>	
			</div>
		</main>	
	</body>
</html>	