<!DOCTYPE html>

<html lang="de">
<head>
<meta charset="utf-8">
<meta http-equiv="X-UA-Compatible" content="IE=edge">
<meta name="viewport" content="width=device-width, initial-scale=1">
<title>ProMan</title>

<!-- Bootstrap -->
<link href="lib/css/bootstrap.css" rel="stylesheet">

<!-- Design -->
<link href="lib/css/masterdesign.css" rel="stylesheet">


<!--The following script tag downloads a font from the Adobe Edge Web Fonts server for use within the web page. We recommend that you do not modify it.-->
<script>var __adobewebfontsappname__="dreamweaver"</script>
<script src="http://use.edgefonts.net/alegreya:n4:default.js" type="text/javascript"></script>
</head>

<body style="padding-top: 70px; padding-bottom: 70px;">
<header >
  <nav class="navbar navbar-default navbar-fixed-top">
    <div class="container-fluid"> 
      <!-- Brand and toggle get grouped for better mobile display -->
       <div class="navbar-header">
        <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#topFixedNavbar1" aria-expanded="false"><span class="sr-only">Toggle navigation</span><span class="icon-bar"></span><span class="icon-bar"></span><span class="icon-bar"></span></button>
<img src="images/png/logo.png" width="150" height="50" alt=""/></div>
      
      <!-- Collect the nav links, forms, and other content for toggling -->
      <div class="collapse navbar-collapse" id="topFixedNavbar1">
        <ul class="nav navbar-nav navbar-right">
          <li> <a id="datekw">none</a> </li>
          <li class="dropdown"><a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false">Kontakt<span class="caret"></span></a>
            <ul class="dropdown-menu">
			  <li><a href="index.html">Home</a></li>
              <li><a href="adminkontakt.html">Admin Kontaktieren</a></li>
              <li><a href="impressum.html">Impressum</a></li>
            </ul>
          </li>
        </ul>
      </div>
      <!-- /.navbar-collapse --> 
    </div>
    <!-- /.container-fluid --> 
  </nav>
</header>
<main>
  <div class="container-fluid">
    <div class="row">
      <div class="col-md-5 col-md-offset-3">
        <h1 class="text-center">Willkommen bei ProMan</h1>
      </div>
    </div>
    <div class="row">
      <div class="col-md-12">
        
		  <div class="row">
            <h1 class="col-md-offset-4 col-md-4">Login</h1>
           
		  </div>
		  <div class="row">
		    <h4 class="col-md-offset-4 col-md-4">Bitte geben sie bitte ihre Daten ein !!</h4>
              
		  </div> 
<?php
if (isset($_GET['f'])) {
    echo "<p class='fehler'>Login-Daten nicht korrekt</p>";
}
?>         
  <form method="post" action="login.php">
	  <div class="form-group">
			<label for="userid">UserID:</label>
			<input  type="text" class="form-control" name="userid" id="userid">
	  </div>
	  <div class="form-group">
			<label for="pwd">Password:</label>
			<input type="password" class="form-control" name="pwd" id="pwd">
	  </div>
	  <div class="form-check">
			<label class="form-check-label">
    	    <input class="form-check-input" type="checkbox"> Remember me
			</label>
	  </div>
		  <button type="submit" class="btn btn-primary btn"  >Login</button>
		  <button type="button" class="btn btn-success btn" onclick="window.open('registrieren.html')" >Registieren</button>	   
</form> 
		  
        
      </div>
    </div>
    <hr>
  </div>
</main>
<footer>
  <nav class="navbar navbar-default navbar-fixed-bottom">
    <div class="container-fluid">
      <!-- Brand and toggle get grouped for better mobile display -->
     <div class="navbar-header">
        <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#bottomFixedNavbar1" aria-expanded="false"><span class="sr-only">Toggle navigation</span><span class="icon-bar"></span><span class="icon-bar"></span><span class="icon-bar"></span></button>
        <ol class="breadcrumb navbar-brand">
          <li><a href="index.html">Home</a></li>
          <li class="active">Login</li>
        </ol>

	 </div>
      <!-- Collect the nav links, forms, and other content for toggling -->
      <div class="collapse navbar-collapse" id="bottomFixedNavbar1">
        
        <ul class="nav navbar-nav navbar-right">
          <li><a href="#">Statusmeldung</a></li>
          <li class="dropdown"><a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false">Information<span class="caret"></span></a>
            <ul class="dropdown-menu">
              <li><a href="#">info1</a></li>
              <li><a href="#">info2</a></li>
              <li role="separator" class="divider"></li>
              <li><a href="#">info3</a></li>
            </ul>
          </li>
        </ul>
      </div>
      <!-- /.navbar-collapse -->
    </div>
    <!-- /.container-fluid -->
  </nav>
</footer>
<!-- jQuery (necessary for Bootstrap's JavaScript plugins) --> 
<script src="lib/js/jquery-1.11.3.min.js"></script> 

<!-- Include all compiled plugins (below), or include individual files as needed --> 
<script src="lib/js/bootstrap.js"></script> 
<script src="lib/js/helpers.js"></script> 
<script> 
    currentDate();   
</script>
</body>
</html>
