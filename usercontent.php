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
<script src="http://use.edgefonts.net/architects-daughter:n4:default;alegreya:n4:default.js" type="text/javascript"></script>

</head>

<body style="padding-top: 70px; padding-bottom: 70px;">
<header >
  <nav class="navbar navbar-default navbar-fixed-top headnav">
    <div class="container-fluid"> 
      <!-- Brand and toggle get grouped for better mobile display -->
      <div class="navbar-header">
        <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#topFixedNavbar1" aria-expanded="false"><span class="sr-only">Toggle navigation</span><span class="icon-bar"></span><span class="icon-bar"></span><span class="icon-bar"></span></button>
<img src="images/png/logo.png" width="150" height="50" alt=""/></div>
      
      <!-- Collect the nav links, forms, and other content for toggling -->
      <div class="collapse navbar-collapse main" id="topFixedNavbar1">
        <ul class="nav navbar-nav navbar-right">
          <li> <a id="datekw">none</a> </li>
          <li class="dropdown headBereich"><a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false">Bereiche<span class="caret"></span></a>
            <ul class="dropdown-menu">
			
			  <li> <a href="#" onclick="loadData('lib/php/admin/User/adminCRUser.php?q=222',FunctionUser)">User</a> </li>
					
              <li> <a href="#" onclick="loadData('lib/php/admin/Abteilung/adminCRAbteilung.php?q=2222',FunctionAbteilung)">Abteilung</a> </li>
				
              <li> <a href="#" onclick="loadData('lib/php/admin/Fertigung/adminCRFertigung.php?q=2222',FunctionFertigung)">Fertigung</a> </li>
				
              <li> <a href="#" onclick="loadData('lib/php/admin/Fertigungslinie/adminCRFertigungslinie.php?q=2222',FunctionFertigungslinie)">Fertigungslinie</a> </li>
				
              <li> <a href="#" onclick="loadData('lib/php/admin/Maschine/adminCRMaschinen.php?q=2222',FunctionMaschine)">Maschinen</a> </li>
              <li> <a href="#" onclick="loadData('lib/php/admin/Bauteil/adminCRBauteil.php?q=2222',FunctionBauteil)">Bauteile</a> </li>
              <li role="separator" class="divider"></li>
              <li> <a href="#" onclick="loadData('lib/php/admin/AbteilungsStatus/abteilungsStatusGesammt.php?q=1111',FunctionAbtStatus)">Abteilungsstatus</a></li>
              <li> <a href="#" onclick="loadData('lib/php/admin/AbteilungsStatus/fertigungStatusDetail.php?q=1111',FunctionLinienStatus)">Fertigungslinienstatus</a></li>
              <li role="separator" class="divider"></li>
				
              <li> <a href="#" onclick="loadData('lib/php/admin/Instandhaltung/adminCRAuftrag.php?q=2222',FunctionInstandhaltung)">Instandhaltung</a></li>
              <li role="separator" class="divider"></li>
				
              <li> <a href="#" onclick="loadData('lib/php/admin/Produktionsplanung/userCRProduktionsplanung.php?q=2222',FunctionProduktionsplanung)">Produktionsplanung</a></li>
				
              <li role="separator" class="divider"></li>
              <li> <a href="#" onclick="loadData('lib/php/admin/Sonderaufgaben/userCRSonderaufgaben.php?q=2222',FunctionSonderaufgaben)">Sonderaufgaben</a></li>
              <li role="separator" class="divider"></li>
              <li> <a href="logout.php">Logout</a> </li>
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
  <div id="daten" >Bitte wählen sie unter Bereich einen Anzeige aus !!</div>
</main>
<footer>
  <nav class="navbar navbar-default navbar-fixed-bottom">
    <div class="container-fluid"> 
      <!-- Brand and toggle get grouped for better mobile display -->
      <div class="navbar-header">
        <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#bottomFixedNavbar1" aria-expanded="false"><span class="sr-only">Toggle navigation</span><span class="icon-bar"></span><span class="icon-bar"></span><span class="icon-bar"></span></button>
        <ol class="breadcrumb navbar-brand">
          <li><a href="index.html">Home</a></li>
          <li><a href="start.php">Login</a></li>
          <li class="active">Administrator</li>
        </ol>
      </div>
      <!-- Collect the nav links, forms, and other content for toggling -->
      <div class="collapse navbar-collapse head " id="bottomFixedNavbar1">
        <ul class="nav navbar-nav navbar-right">
          <li> <a id="systemstatus">Systemstatus : OK</a> </li>
          <li class="dropdown"><a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false">Kommunikation<span class="caret"></span></a>
            <ul class="dropdown-menu">
              <li><a href="#">eMail</a></li>
              <li><a href="#">Anrufe</a></li>
              <li><a href="#">Kurznachichten</a></li>
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
	
<script src="lib/js/connectDB.js"></script>

<script src="lib/js/dbbuttonaction.js"></script>
<script> 
    currentDate();   
</script>
</body>
</html>
