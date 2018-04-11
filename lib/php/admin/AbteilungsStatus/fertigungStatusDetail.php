<?php
//echo "PHP Datenabfrage<br>";
//$q = $_REQUEST["q"];
//echo "Abfragenummer : "  . $q . "<br>";
//echo "phpDateiName : "  . __FILE__ . "<br>";
$ch1 = curl_init();


//curl_setopt($ch2, CURLOPT_URL, "http://zoomnation.selfhost.eu:8080/ProManAPI/api/adminPage/?identifier=AdminPageAbteilung");

curl_setopt( $ch1, CURLOPT_URL,"http://zoomnation.selfhost.eu/jsonData/abteilungsstatus/fertigungStatusDetail.json" );
curl_setopt( $ch1, CURLOPT_HEADER, 0 );
curl_setopt( $ch1, CURLOPT_RETURNTRANSFER, true );
$fertigungLinienStatus = curl_exec( $ch1 );
curl_close( $ch1 );

// Testausgabe
//echo($maschinen);

// Unwandlung von json in Array	
$jsonfertigungLinienStatus = json_decode($fertigungLinienStatus, TRUE);
//print_r($jsonfertigungLinienStatus);



foreach($jsonfertigungLinienStatus['fertigungslinienstatus'] as $fertigunglinie)
{
//echo($fertigung['kennzahlen']['linienverfügkarkeit']);
//if($fertigung['fertigungsID'] == 2)
//{	
//	echo("AUSSGABE :" . $fertigung['fertigungsname']);	
//}
	
echo <<<DATA
<h1>Fertigungsübersicht</h1>

<div class"Fertigungslinie">
  <div class="jumbotron">
    <div class="container-fluid">
      <div class="row">
        <div class="row">
		<div class="col-sm-2"> {$fertigunglinie['fertigungslinienname']}</div>
		</div>
      </div>
	    <div class="row">
        <div class="col-sm-2">{$fertigunglinie['abteilungsdaten']['ansprechpartner']}</div>
        <div class="col-sm-2">Tel: {$fertigunglinie['abteilungsdaten']['telefon']}</div>
        <div class="col-sm-2">Werk : {$fertigunglinie['abteilungsdaten']['werk']}</div>
        <div class="col-sm-4">aktuelle Schicht: {$fertigunglinie['abteilungsdaten']['aktuelleSchicht']}</div>
      </div>
		<div class="row">
		<br>
		</div>
      
      <div class="row">
        <div class="col-sm-6">
          <lable for="a1">Produktionsdaten:</lable>
          <ul id="a1" class="list-group">
            <li class="list-group-item d-flex justify-content-between align-items-center"> Aktuelle Teilenummer <span class="badge badge-primary badge-pill">
			{$fertigunglinie['produktionsdaten']['teilenummerAktuell']}
			{$fertigunglinie['produktionsdaten']['teileIndexAktuell']}
			</span> </li>
            <li class="list-group-item d-flex justify-content-between align-items-center"> Aktuelle Stückzahl <span class="badge badge-primary badge-pill">Ist : 
			{$fertigunglinie['produktionsdaten']['stueckzahlIst']}</span> <span class="badge badge-primary badge-pill">Soll : {$fertigunglinie['produktionsdaten']['stueckzahlSoll']}</span></li>
            <li class="list-group-item d-flex justify-content-between align-items-center"> Nächste Teilnummer<span class="badge badge-primary badge-pill">
			{$fertigunglinie['produktionsdaten']['teilenummerNaechste']} 
			{$fertigunglinie['produktionsdaten']['teileIndexNaechste']}
			</span> </li>
            <li class="list-group-item d-flex justify-content-between align-items-center"> Nächste Stückzahl<span class="badge badge-primary badge-pill">Soll 
			{$fertigunglinie['produktionsdaten']['stueckzahlNaechste']}</span></li>
          </ul>
        </div>
        <div class="row">
          <div class="col-sm-6">
            <lable for="aufgaben">Aufgaben in dieser Schicht:</lable>
            <ul id="aufgaben" class="list-group">
              <li class="list-group-item d-flex justify-content-between align-items-center"> Reperaturen <span class="badge badge-primary badge-pill">offene 
			  {$fertigunglinie['schichtAufgaben']['reperaturen']}</span> </li>
              <li class="list-group-item d-flex justify-content-between align-items-center"> Wartungen <span class="badge badge-primary badge-pill">offene {$fertigunglinie['schichtAufgaben']['wartungen']}</span> </li>
			  <li class="list-group-item d-flex justify-content-between align-items-center"> Wartungen <span class="badge badge-primary badge-pill">offene {$fertigunglinie['schichtAufgaben']['audits']}</span> </li>
            </ul>
          </div>
        </div>
      </div>
      <div class="row">
        <div class="col-sm-6">
          <lable for="a1">Maschinendaten:</lable>
          <ul id="a1" class="list-group">
            <li class="list-group-item d-flex justify-content-between align-items-center"> Maschinenzahl <span class="badge badge-primary badge-pill">{$fertigunglinie['maschinendaten']['maschineanzahl']}</span> </li>
            <li class="list-group-item d-flex justify-content-between align-items-center"> geplannte Umbauten <span class="badge badge-primary badge-pill">{$fertigunglinie['maschinendaten']['geplannteUmbauten']}</span> </li>
            <li class="list-group-item d-flex justify-content-between align-items-center"> geplannte Optimierungen <span class="badge badge-primary badge-pill">{$fertigunglinie['maschinendaten']['geplannteOpimierungen']}</span> </li>
           
        </div>
        <div class="row">
          <div class="col-sm-6">
            <lable for="aufgaben">Informationen:</lable>
            <ul id="aufgaben" class="list-group">
              
			    <li class="list-group-item d-flex justify-content-between align-items-center"> Reperaturen 
				  <span class="badge badge-primary badge-info" style="background: blue">Historie {$fertigunglinie['informationen']['reperarturenHistorie']}</span>
				  <span class="badge badge-primary badge-pill" style="background: red">offene {$fertigunglinie['informationen']['reperaturenOffen']}</span> 
				  <span class="badge badge-primary badge-pillstyle=" style="background: green">erledigt {$fertigunglinie['informationen']['repeaturenErledigt']}</span>
				</li>
				
				  <li class="list-group-item d-flex justify-content-between align-items-center"> Wartungen 
				  <span class="badge badge-primary badge-info" style="background: blue">Historie {$fertigunglinie['informationen']['wartungHistorie']}</span>
				  <span class="badge badge-primary badge-pill" style="background: red">offene {$fertigunglinie['informationen']['reperaturenOffen']}</span> 
				  <span class="badge badge-primary badge-pillstyle=" style="background: green">erledigt {$fertigunglinie['informationen']['repeaturenErledigt']}</span>
				</li>
				
				 <li class="list-group-item d-flex justify-content-between align-items-center"> Audits 
				   <span class="badge badge-primary badge-pill" style="background: red">offene {$fertigunglinie['informationen']['auditsOffen']}</span> 
				  <span class="badge badge-primary badge-pillstyle=" style="background: green">erledigt {$fertigunglinie['informationen']['auditsErledigt']}</span>
				</li>
             
         		<li class="list-group-item d-flex justify-content-between align-items-center"> Optimierungen 
				   <span class="badge badge-primary badge-pill" style="background: red">offene {$fertigunglinie['informationen']['optimierungenOffen']}</span> 
				  <span class="badge badge-primary badge-pillstyle=" style="background: green">erledigt {$fertigunglinie['informationen']['optimierungenErledigt']}</span>
				</li>
             
            </ul>
          </div>
        </div>
      </div>
      
      <div class="row">
	      <div class="col-sm-5">
          <lable for="status">Status einer Maschine dieser Fertigungslinie ändern:</lable>
		  <br>
          <select name="status">
            <option value="Produktion">Produktion</option>
            <option value="Umbau">Umbau</option>
            <option value="Wartung">Wartung</option>
            <option value="Reperatur">Reperatur</option>
          </select>
          <button type="button">Status ändern</button>
        </div>
		 <div class="col-sm-4">
          <lable for="status">Gesammtstatus dieser Fertigungslinie ändern:</lable>
		  <br>
          <select name="status">
            <option value="Produktion">Produktion</option>
            <option value="Umbau">Umbau</option>
            <option value="Wartung">Wartung</option>
            <option value="Reperatur">Reperatur</option>
          </select>
          <button type="button">Status ändern</button>
        </div>
	  </div>
    </div>
  </div>
</div>


DATA;
};

?>