<?php
//echo "PHP Datenabfrage<br>";
//$q = $_REQUEST["q"];
//echo "Anfrage : "  . $q . "<br>";

// Data load
$ch1 = curl_init();
$ch2 = curl_init();
//$ch3 = curl_init();

//curl_setopt($ch1, CURLOPT_URL, "http://zoomnation.selfhost.eu:8080/ProManAPI/api/bauteil");
curl_setopt($ch1, CURLOPT_URL, "http://localhost:50435/api/bauteil");
//curl_setopt($ch1, CURLOPT_URL, "http://zoomnation.selfhost.eu/jsonData/bauteile/bauteile.json");

curl_setopt($ch1, CURLOPT_HEADER, 0);
curl_setopt($ch1,CURLOPT_RETURNTRANSFER,true);
$bauteile=curl_exec($ch1);

curl_close($ch1);

//curl_setopt($ch2, CURLOPT_URL, "http://zoomnation.selfhost.eu:8080/ProManAPI/api/bauteil");

curl_setopt($ch2, CURLOPT_URL, "http://zoomnation.selfhost.eu/jsonData/bauteile/bauteileVerwendung.json");
curl_setopt($ch2, CURLOPT_HEADER, 0);
curl_setopt($ch2,CURLOPT_RETURNTRANSFER,true);
$bauteilVerwendung=curl_exec($ch2);
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
$jsonbauteile = json_decode($bauteile, TRUE);
$jsonbauteilVerwendung = json_decode($bauteilVerwendung, TRUE);

//print_r($jsonbauteile);
//echo("<br>");
//echo("<br>");
//print_r($bauteilVerwendung);
echo <<<'HOME1_HEADER'
<div class="User">
  	<div class="jumbotron">
    	<div class="container">

			<ul class="nav nav-tabs">
			  <li class="active">
			  	<a data-toggle="tab" href="#home1">Bauteil bearbeiten</a>
			  </li>
			  <li>
			    <a data-toggle="tab" href="#menu1">Bauteilverwendung</a>
			  </li>
			 

		   
			 <!-- Tab panes -->
			 <div class="tab-content">
					<div id="home1" class="tab-pane fade in active"><br>

					  <div class="table-responsive-sm">
						<table class="table">
						  <thead>
							<tr>
							  <th>BauteilID</th>
							  <th>Bauteinummer</th>
							  <th>Index</th>
							  <th>Version</th>
							  <th>Bauteilart</th>
							  <th>Status</th>
							  <th>Nachvolger</th>
							</tr>
						  </thead>
						  <tbody>  
HOME1_HEADER;
				
				foreach($jsonbauteile as $bauteil)
				{
				 
					echo("<tr>");
					echo("<td>{$bauteil['bauteileID']}</td>");
					echo("<td>{$bauteil['bauteilNummer']}</td>");
					echo("<td>{$bauteil['bauteilIndex']}</td>");
					echo("<td>{$bauteil['bauteilVersion']}</td>");
					echo("<td>{$bauteil['bauteilArt'] }</td>");
					echo("<td>{$bauteil['bauteilStatus']}</td>");
					echo("<td>{$bauteil['bauteilIDNachfolger']}</td>");
					echo("<td><input class='btn btn-primary' type='button' value='Bearbeiten'  onclick='editBauteil({$bauteil['bauteileID']});'></td>");
					echo("</tr>");
				};
				echo("<td><input class='btn btn-primary' type='button' value='Neues Bauteil'  onclick='editBauteil(0);'></td>");


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
						  <th>BauteilID</th>
						  <th>Bauteilnummer</th>
						  <th>Index</th>
						  <th>Version</th>
						  <th>BauteilsverwendungsID</th>
						  <th>Fertigungslinie</th>
						  <th>Technologie</th>
						  <th>Bearbeitungsschritt</th>
						   <th>Verwendungszweck</th>
						</tr>
					  </thead>
					  <tbody>
MENU1_HEADER;

				foreach($jsonbauteilVerwendung['bauteilVerwendung'] as $bauteilverwendung)
				{
					echo("<tr>");
					foreach($jsonbauteile['bauteile'] as $bauteil)
					{
						
						if($bauteilverwendung['bauteileID'] == $bauteil['bauteileID'])
						{

							echo("<td>{$bauteil['bauteileID']}</td>");
							echo("<td>{$bauteil['bauteilNummer']}</td>");
							echo("<td>{$bauteil['bauteilIndex']}</td>");
							echo("<td>{$bauteil['bauteilVersion']}</td>");
						}
					};
						echo("<td>{$bauteilverwendung['bauteilverwendungsID']}</td>");
						echo("<td>{$bauteilverwendung['fertingungsLinienID']}</td>");
						echo("<td>{$bauteilverwendung['technologie']}</td>");
						echo("<td>{$bauteilverwendung['bearbeitungsschritt']}</td>");
						echo("<td>{$bauteilverwendung['verwendungsZweck']}</td>");
						echo("<td><input class='btn btn-primary' type='button' value='Bearbeiten'  onclick='editBauteilVerwendung({$bauteilverwendung['bauteileID']});'></td>");
					
				};
					echo("</tr>");
					echo("<td><input class='btn btn-primary' type='button' value='Neu Bauteil Verwendung anlegen'  onclick='editBauteilVerwendung(0);'></td>");


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


