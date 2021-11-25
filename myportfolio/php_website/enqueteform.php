<?php
    include_once 'header.php';
    ?> 
<!DOCTYPE html>
<html>
    <body>
        <div class="global">
            <div class="container">
                <h2>Register Form</h2>
            </div>
            <div class="container">
            <section class="enquete-section">
                <div class="enquete">
                    <form action="questController.php" method="POST" class="enquete-wrapper" id="enquete-form">
                        <a id="enquete" class="enquete-anchor">enquete.</a> 

                        <div class="input-grid">
                            <div class="enquete-name">
                                <p>Username</p>
                                <input class="name-input" type="name" name="name">
                            </div>
                            <div class="enquete-password">
                                <p>Password</p>
                                <input class="password-input" type="password" name="password">
                            </div>  
                        </div>
                        <div class="input-grid">
                            <div class="enquete-tel">
                                <p>Phonenumber</p>
                                <input class="tel-input" type="tel" name="tel">
                            </div>
                            <div class="enquete-time">
                                <p>Current time</p>
                                <input class="time-input" type="time" name="time">
                            </div>  
                        </div>
                        <div class="input-grid">
                            <div class="enquete-date">
                                <p>Current Date</p>
                                <input class="date-input" type="date" name="date">
                            </div>
                            <div class="enquete-url">
                                <p>Personal website</p>
                                <input class="url-input" type="url" name="url">
                            </div>  
                        </div>
                        <div class="input-grid">
                            <div class="enquete-color">
                                <p>Favorite color</p>
                                <input class="color-input" type="color" name="color">
                            </div>
                            <div class="enquete-img">
                                <p>Favorite img</p>
                                <input class="img-input" type="image" name="img">
                            </div>  
                        </div>
                        <div class="enquete-email">
                                <p>Email</p>
                                <input class="email-input" type="email" name="email">
                            </div> 
                        <div class="enquete-message">
                            <p>Message</p>
                            <textarea rows="5" class="message-input" name="message" cols="30"></textarea>
                        </div>
                        <Input type="submit" name="submit" value="Submit" class="button"/>
                    </form>
                </div>
            </section>
            </div>
        </div>
    </body>
</html>
<?php
    include_once 'footer.php';
    ?>