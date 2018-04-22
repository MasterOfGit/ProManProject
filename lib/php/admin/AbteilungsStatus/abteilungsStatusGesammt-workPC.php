<!--
Ersteller : Markus Kessler	
MatrNr 	  : 894361
Presentation: 28.04.2018
Theam : ProMan
-->
<?php
//echo "PHP Datenabfrage<br>";
//$q = $_REQUEST["q"];
//echo "Abfragenummer : "  . $q . "<br>";
//echo "phpDateiName : "  . __FILE__ . "<br>";
$ch1 = curl_init();


//curl_setopt($ch2, CURLOPT_URL, "http://zoomnation.selfhost.eu:8080/ProManAPI/api/adminPage/?identifier=AdminPageAbteilung");

curl_setopt( $ch1, CURLOPT_URL,"http://zoomnation.selfhost.eu/jsonData/abteilungsstatus/abteilungFertigungenStatus.json" );
curl_setopt( $ch1, CURLOPT_HEADER, 0 );
curl_setopt( $ch1, CURLOPT_RETURNTRANSFER, true );
$abtStatus = curl_exec( $ch1 );
curl_close( $ch1 );

// Testausgabe
//echo($maschinen);

// Unwandlung von json in Array	
$jsonabtStatus = json_decode($abtStatus, TRUE);
//print_r($jsonabtStatus);



foreach($jsonabtStatus['fertigungsstatus'] as $fertigung)
{
//echo($fertigung['kennzahlen']['linienverfügkarkeit']);
//if($fertigung['fertigungsID'] == 2)
//{	
//	echo("AUSSGABE :" . $fertigung['fertigungsname']);	
//}
echo <<<DATA
<div class"gesammtbereich">
  <div class="jumbotron">
    <div class="container-fluid">
      <div class="row">
        <div class="row">
          <div class="col-sm-4">
            <lable for="linienname">{$fertigung['fertigungsname']}</lable>
          </div>
          <div class="col-sm-4">
            
          </div>
          <div class="col-sm-4">
            <lable for="verfügbarkeit">Linienverfügbarkeit:</lable>
            <div id="verfügbarkeit">
              <div class="progress-bar" role="progressbar" style="width: 25%;" aria-valuenow="100" aria-valuemin="0" aria-valuemax="100">{$fertigung['kennzahlen']['linienverfügkarkeit']}</div>
            </div>
          </div>
        </div>
      </div>
      <div class="row">
        <div class="col-sm-6">
          <lable for="a1">Informationen:</lable>
          <ul id="a1" class="list-group">
            <li class="list-group-item d-flex justify-content-between align-items-center"> Teilenummern <span class="badge badge-primary badge-pill">{$fertigung['kennzahlen']['teilenummernzahl']}<a href="../inArbeit.html" style="color:white"></a></span> </li>
            <li class="list-group-item d-flex justify-content-between align-items-center"> Stückzahl <span class="badge badge-primary badge-pill">Soll: {$fertigung['kennzahlen']['stueckzahlSoll']}</span> <span class="badge badge-primary badge-pill">Ist: {$fertigung['kennzahlen']['stueckzahlIst']}</span> </li>
            <li class="list-group-item d-flex justify-content-between align-items-center">offene Umbauten<span class="badge badge-primary badge-pill">Soll: {$fertigung['kennzahlen']['unbautenSoll']}</span> <span class="badge badge-primary badge-pill">Ist: {$fertigung['kennzahlen']['umbautenIst']}</span> </li>
          </ul>
        </div>
        <div class="col-sm-6">
          <lable for="aufgaben">Aufgaben:</lable>
          <ul id="aufgaben" class="list-group">
            <li class="list-group-item d-flex justify-content-between align-items-center"> Reperaturen <span class="badge badge-primary badge-pill">{$fertigung['kennzahlen']['reperaturen']}</span> </li>
            <li class="list-group-item d-flex justify-content-between align-items-center"> Wartungen <span class="badge badge-primary badge-pill">{$fertigung['kennzahlen']['wartungen']}</span> </li>
            <li class="list-group-item d-flex justify-content-between align-items-center"> Audits <span class="badge badge-primary badge-pill">{$fertigung['kennzahlen']['audits']}</span> </li>
          </ul>
        </div>
      </div>
      <div class="row">
        <div class="col-sm-2">{$fertigung['abteilungsdaten']['ansprechpartner']}</div>
        <div class="col-sm-2">Tel: {$fertigung['abteilungsdaten']['telefon']}</div>
        <div class="col-sm-2">Werk : {$fertigung['abteilungsdaten']['werk']}</div>
        <div class="col-sm-2">Halle : {$fertigung['abteilungsdaten']['halle']}</div>
        <div class="col-sm-4">aktuelle Schicht: {$fertigung['abteilungsdaten']['aktuelleSchicht']}</div>
      </div>
    </div>
  </div>
</div>

DATA;
};
?>