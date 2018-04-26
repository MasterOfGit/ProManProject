<!--
Ersteller : Markus Kessler	
MatrNr 	  : 894361
Presentation: 28.04.2018
Theam : ProMan
-->
<?php
//echo "PHP Datenabfrage<br>";
$q = $_REQUEST["q"];
//echo "Anfrage : "  . $q . "<br>";
//$q= 0;
/* $ch1 = curl_init();



//curl_setopt($ch1, CURLOPT_URL, "http://zoomnation.selfhost.eu/jsonData/bauteile/bauteile.json");
curl_setopt($ch1, CURLOPT_URL, "http://zoomnation.selfhost.eu:8080/ProManAPI/api/bauteil");
//curl_setopt($ch1, CURLOPT_URL, "http://localhost/api/bauteil");

curl_setopt($ch1, CURLOPT_HEADER, 0);
curl_setopt($ch1,CURLOPT_RETURNTRANSFER,true);
$registrierung=curl_exec($ch1);
curl_close($ch1);

// Testausgabe
//echo($bauteil);

// Unwandlung von json in Array	
$jsonregistrierungl = json_decode($registrierung, TRUE);
 */
echo <<<HEADER

<script>
function createData()
{
		var givenId = 0;
		var data = JSON.stringify(
		{
		
			"userID"		:	$("#userID").val(),

		 	"userAnrede"	:	$("#userAnrede").val(),

		 	"userVorname"	:	$("#userVorname").val(),

		 	"userNachname"	:	$("#userNachname").val(),

		 	"userPosition"	: 	$("#userPosition").val(),

		 	"userBild"		: 	$("#userBild").val(),

		 	"userLand"		: 	$("#userLand").val(),

		 	"userWerk"		: 	$("#userWerk").val(),

		 	"userAbteilung"	:	$("#userAbteilung").val(),

		 	"userEmail"		:	$("#userEmail").val(),

		 	"userFestnetzNr":	$("#userFestnetzNr").val(),

		 	"userMobilNr"	:	$("#userMobilNr").val(),

		 	"userBemerkung"	:	$("#userBemerkung").val()

	
		}
    );
    		
		if(givenId==0)		{		
			createRegistierung(data);
		}
		else{
			updateregistrierungl(data,givenId);
			
		}
		
};
</script>


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
      <div class="col-md-6 col-md-offset-3">
        <h1 class="text-center">Willkommen bei ProMan</h1>
      </div>
    </div>
    <div class="row">
      <div class="col-md-12">
        <div id="daten">
          <div class="jumbotron">

            <h3>Bitte geben sie ihre Daten ein !!</h3>
            <div class="form-group">
HEADER;


				
			  echo("<label for='userID'>UserID (falls bekannt)</label>");
              echo("<input type='text' class='form-control' id='userID' aria-describedby='userID' placeholder='UserID' value='0'>");
              
			  echo("<label for='userAnrede'>Anrede</label>");
              echo("<select class='form-control' id='userAnrede'>
                <option>Herr</option>
                <option>Frau</option>
                <option>Dr.</option>
                <option>Prof.</option>
                <option>Prof.Dr.</option>
              </select>");

		      echo("<label for='userVorname'>Vorname</label>");
              echo("<input type='text' class='form-control' id='userVorname' aria-describedby='userVorname' placeholder='Vorname'>");

	          echo("<label for='userNachname'>Nachname</label>");
              echo("<input type='text' class='form-control' id='userNachname' aria-describedby='userNachname' placeholder='Nachname'>");

              echo("<label for='userPosition'>Position</label>");
              echo("<select class='form-control' id='userPosition'>
                <option>Administrator</option>
                <option>Maschinenführer</option>
                <option>Instandhalter</option>
                <option>Gruppensprecher</option>
                <option>Meister</option>
                <option>Sachbearbeiter</option>
              </select>");

              echo("<br>");

			  echo("<img id='Bild' src='http://via.placeholder.com/150x150' width='150' height='150' class='img-rounded img-responsive' alt='Placeholder image'>");
              echo("<label for='userBild'>Bilddatei auswählen</label>");
              echo("<input type='file' id='userBild' name='bilddatei' multiple>");
              
			
              echo("<label for='userLand'>Land</label>");
              echo("<input type='text' class='form-control' id='userLand' aria-describedby='userLand' placeholder='Land'>");
 			  
			  echo("<label for='userWerk'>Werk</label>");
              echo("<input type='text' class='form-control' id='userWerk' aria-describedby='userWerk' placeholder='Werk'>");

              echo("<label for='userAbteilung'>Abteilung</label>");
              echo("<input type='text' class='form-control' id='userAbteilung' aria-describedby='userAbteilung' placeholder='Abteilung'>");

              echo("<label for='userEmail'>eMail</label>");
              echo("<input type='email' class='form-control' id='userEmail' aria-describedby='userEmail' placeholder='eMail'>");

              echo("<label for='userFestnetzNr'>Festnetz</label>");
              echo("<input type='tel' class='form-control' id='userFestnetzNr' aria-describedby='userFestnetzNr' placeholder='Festnetz'>");

              echo("<label for='userMobilNr'>Mobil</label>");
              echo("<input type='tel' class='form-control' id='userMobilNr' aria-describedby='userMobilNr' placeholder='Mobil'>");

              echo("<label for='userBemerkung'>Bemerkung</label>");
              echo("<input type='text' class='form-control' id='userBemerkung' aria-describedby='userBemerkung' placeholder='Bemerkung'>");

            echo("</div>");
            echo("<button type='button' 
					class='btn btn-primary' 
				    onclick='createData();'>Senden Login</button>");
             echo("<button type='reset class='btn btn-primary'>Reset</button>");
echo <<<FOOTER
			</div>
        </div>
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
          <li ><a href="login.html">Login</a></li>
          <li class="active">Registieren</li>
        </ol>
      </div>
      <!-- Collect the nav links, forms, and other content for toggling --> 
      
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
<script src="lib/js/connectDB.js"></script> 
<script src="lib/js/dbbuttonaction.js"> </script>
</body>
</html>
FOOTER;
?>