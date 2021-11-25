<?php 
if(isset($_POST['submit'])){
    $username = $_POST['name'];
    $password = $_POST['password'];
    $tel = $_POST['tel'];
    $time = $_POST['time'];
    $date = $_POST['date'];
    $url = $_POST['url'];
    $color = $_POST['color'];
    $img = $_POST['img'];
    $email = $_POST['email'];
    $message = $_POST['message'];
    
    echo "Enquete recieved at ". $time . " " . $date . "Thank you " . $username . ", we will contact you shortly on ". $tel . " or " . $email;
    file_put_contents('questionaire.txt', "Username: ". $username . " | Phonenumber: " . $tel . " | time and date: " . $time . " ". $date . " | Personal Website: " . $url . " | Favorite color: " . $color . " | email: " . $email . " | Text:" . $message, FILE_APPEND);
    }
?>