<?php
//echo "PHP Datenabfrage<br>";
//$q = $_REQUEST["q"];
//echo "Anfrage : "  . $q . "<br>";

// Data load
$ch1 = curl_init();
$ch2 = curl_init();
//$ch3 = curl_init();

//curl_setopt($ch1, CURLOPT_URL, "http://zoomnation.selfhost.eu:8080/ProManAPI/api/adminPage/?identifier=AdminPageUser");

curl_setopt($ch1, CURLOPT_URL, "http://zoomnation.selfhost.eu/jsonData/sonderaufgaben/audits.json");

curl_setopt($ch1, CURLOPT_HEADER, 0);
curl_setopt($ch1,CURLOPT_RETURNTRANSFER,true);
$saudits=curl_exec($ch1);
curl_close($ch1);

//curl_setopt($ch2, CURLOPT_URL, "http://zoomnation.selfhost.eu:8080/ProManAPI/api/adminPage/?identifier=AdminPageAbteilung");

curl_setopt($ch2, CURLOPT_URL, "http://zoomnation.selfhost.eu/jsonData/sonderaufgaben/wartungen.json");

curl_setopt($ch2, CURLOPT_HEADER, 0);
curl_setopt($ch2,CURLOPT_RETURNTRANSFER,true);
$wartungen=curl_exec($ch2);
curl_close($ch2);


// Testausgabe
//print_r($bauteile);
//echo("<br>");
//echo("<br>");
//print_r($userLogin);
//echo("<br>");
//echo("<br>");
//print_r($userAnfragen);
	
// Unwandlung von json in Array	
$jsonsaudits = json_decode($saudits, TRUE);
$jsonwartungen = json_decode($wartungen, TRUE);

//echo($wartungen);

//print_r($jsonbauteile);
//echo("<br>");
//echo("<br>");
//print_r($bauteilVerwendung);
echo <<<'HOME1_HEADER'
<div class="Sonderaufgaben">
  	<div class="jumbotron">
    	<div class="container">

			<ul class="nav nav-tabs">
			  <li class="active">
			  	<a data-toggle="tab" href="#home1">Wartungen</a>
			  </li>
			  <li>
			    <a data-toggle="tab" href="#menu1">Audits</a>
			  </li>
			 

		   
			 <!-- Tab panes -->
			 <div class="tab-content">
					<div id="home1" class="tab-pane fade in active"><br>

					  <div class="table-responsive-sm">
						<table class="table">
						  <thead>
							<tr>
							  <th>wartungsID</th>	
							  <th>Abteilung</th>
							  <th>Fertigung</th>
							  <th>Fertigungslinie</th>
							  <th>Maschine</th>
							  <th>Terminturnus</th>
							  <th>Status</th>
						   </tr>
						  </thead>
						  <tbody>  
HOME1_HEADER;

				foreach($jsonwartungen['wartungen'] as $wartung)
				{
				 
					echo("<tr>");
					echo("<td>{$wartung['wartungsID']}</td>");
					echo("<td>{$wartung['abteilung']}</td>");
					echo("<td>{$wartung['fertigung']}</td>");
					echo("<td>{$wartung['fertigungslinie']}</td>");
					echo("<td>{$wartung['maschine']}</td>");
					echo("<td>{$wartung['terminturnus'] }</td>");
					echo("<td>{$wartung['status']}</td>");

					echo("<td><input type='button' value='Bearbeiten'  onclick='editWartung({$wartung['wartungsID']});'></td>");
					echo("<td><input type='button' value='Status ändern'  onclick='aenderWartungStatus({$wartung['wartungsID']});'></td>");
					echo("<td><input type='button' value='Löschen'  onclick='deleteWartung({$wartung['wartungsID']});'></td>");
					echo("<td><input type='button' value='Verschieben'  onclick='moveWartungDatum({$wartung['wartungsID']});'></td>");
				echo("</tr>");
				};
				echo("<td><input type='button' value='Neu Wartung anlegen'  onclick='editWartung(0);'></td>");
				echo("<td><input type='button' value='Speichern'  onclick='saveAllWartungen();'></td>");	


echo <<<HOME1_FOOTER
						 </tbody>
            		  </table>
          		   </div>
        		</div>
		
HOME1_FOOTER;

			  

echo <<<'MENU1_HEADER'
			     <div id="menu1" class="tab-pane fade">           
				  <div class="table-responsive-sm">
					<table class="table">
					  <thead>
						<tr>
						  <th>AuditID</th>
						  <th>Abteilung</th>
						  <th>Auditart</th>
						  <th>Termin</th>
						  <th>Status</th>
						  <th>Nacharbeit</th>
						  <th>Technologie</th>
						  <th>Terminturnus</th>
						  <th>Beurteilung</th>
						</tr>
					  </thead>
					  <tbody>
MENU1_HEADER;


				foreach($jsonsaudits['audits'] as $audit)
				{
					echo("<tr>");
					echo("<td>{$audit['auditID']}</td>");
					echo("<td>{$audit['abteilung']}</td>");
					echo("<td>{$audit['auditart']}</td>");
					echo("<td>{$audit['termin']}</td>");
					echo("<td>{$audit['status']}</td>");
					echo("<td>{$audit['nacharbeit']}</td>");
					echo("<td>{$audit['terminturnus'] }</td>");
					echo("<td>{$audit['beurteilung']}</td>");

					echo("<td><input type='button' value='Bearbeiten'  onclick='editAudit({$wartung['wartungsID']});'></td>");
					echo("<td><input type='button' value='Status ändern'  onclick='aenderAuditStatus({$audit['auditID']});'></td>");
					echo("<td><input type='button' value='Löschen'  onclick='deleteAudit({$audit['auditID']});'></td>");
					echo("<td><input type='button' value='Verschieben'  onclick='moveAuditDatum({$audit['auditID']});'></td>");
				echo("</tr>");
				};
				echo("<td><input type='button' value='Neu Audit anlegen'  onclick='editAudit();'></td>");
				echo("<td><input type='button' value='Speichern'  onclick='saveAllAudit();'></td>");	


echo <<<'MENU1_FOOTER'
							</tbody>
							</table>
							
						  </div>
						</div>
			</div>
	 </div>
   </div>
  </div>
</div>
MENU1_FOOTER;

?>


