<?php
//echo "PHP Datenabfrage<br>";
//$q = $_REQUEST["q"];
//echo "Anfrage : "  . $q . "<br>";


// Data load

$ch1 = curl_init();
$ch2 = curl_init();
$ch3 = curl_init();


curl_setopt($ch1, CURLOPT_URL, "http://localhost/api/maschine");
//curl_setopt($ch1, CURLOPT_URL, "http://zoomnation.selfhost.eu:8080/ProManAPI/api/maschine);
//curl_setopt($ch1, CURLOPT_URL, "http://zoomnation.selfhost.eu/jsonData/maschinen/maschinen.json");

curl_setopt($ch1, CURLOPT_HEADER, 0);
curl_setopt($ch1,CURLOPT_RETURNTRANSFER,true);
$maschinen=curl_exec($ch1);
curl_close($ch1);

//curl_setopt($ch2, CURLOPT_URL, "http://zoomnation.selfhost.eu:8080/ProManAPI/api/adminPage/?identifier=AdminPageAbteilung");

curl_setopt($ch2, CURLOPT_URL, "http://zoomnation.selfhost.eu/jsonData/maschinen/maschinenVerwendung.json");
curl_setopt($ch2, CURLOPT_HEADER, 0);
curl_setopt($ch2,CURLOPT_RETURNTRANSFER,true);
$maschinenVerwendung=curl_exec($ch2);
curl_close($ch2);


// Testausgabe
//echo($maschinen);

// Unwandlung von json in Array	
$jsonmaschinen = json_decode($maschinen, TRUE);
$jsonmaschinenVerwendung = json_decode($maschinenVerwendung, TRUE);
echo($jsonmaschinen);
echo <<<'HOME1_HEADER'
<div class="User">
  	<div class="jumbotron">
    	<div class="container">

			<ul class="nav nav-tabs">
			  <li class="active">
			  	<a data-toggle="tab" href="#home1">Maschine bearbeiten</a>
			  </li>
			  <li>
			    <a data-toggle="tab" href="#menu1">Maschinenverwendung</a>
			  </li>
			 

		   
			 <!-- Tab panes -->
			 <div class="tab-content">
					<div id="home1" class="tab-pane fade in active"><br>

					  <div class="table-responsive-sm">
						<table class="table">
						  <thead>
							<tr>
							  <th>MaschineID</th>
							  <th>Inventarnummer</th>
							  <th>Hersteller</th>
							  <th>Technologie</th>
							  <th>Standort</th>
							  <th>Abteilung</th>
							  <th>Status</th>
							</tr>
						  </thead>
						  <tbody>  
HOME1_HEADER;

				foreach($jsonmaschinen as $maschine)
				{
				 
					echo("<tr>");
					echo("<td>{$maschine['maschinenID']}</td>");
					echo("<td>{$maschine['maschinenInventarNummer']}</td>");
					echo("<td>{$maschine['hersteller']}</td>");
					echo("<td>{$maschine['technologie']}</td>");
					echo("<td>{$maschine['standort'] }</td>");
					echo("<td>{$maschine['abteilung']}</td>");
					echo("<td>{$maschine['status']}</td>");
					echo("<td><input class='btn btn-primary' type='button' value='Bearbeiten'  onclick='editMaschine({$maschine['maschinenID']});'></td>");
				echo("</tr>");
				};
				echo("<td><input class='btn btn-primary' type='button' value='Neues Maschine anlegen'  onclick='editMaschine(0);'></td>");


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
						 <th>MaschinenID</th>
						  <th>Inventarnummer</th>
						  <th>Hersteller</th>
						  <th>Technologie</th>
						  <th>Status</th>
						  <th>Abteilung</th>
						  <th>Fertigungslinie</th>
						  <th>Arbeitsfolge</th>
						</tr>
					  </thead>
					  <tbody>
MENU1_HEADER;

				foreach($jsonmaschinenVerwendung['machinenVerwendung'] as $maschinenverwendung)
				{	
					
					
				 	foreach($jsonmaschinen['maschinen'] as $maschinen)
					{
						//echo($maschinen['maschinenID']);
						//echo("<br>");
						
						if($maschinen['maschinenID'] == $maschinenverwendung['maschinenID'] )
						{
						echo("<tr>");
						echo("<td>{$maschinen['maschinenID']}</td>");
						echo("<td>{$maschinen['maschinenInventarNummer']}</td>");
						echo("<td>{$maschinen['hersteller']}</td>");
						echo("<td>{$maschinen['technologie']}</td>");
						echo("<td>{$maschinen['status'] }</td>");
						echo("<td>{$maschinen['abteilung']}</td>");
						echo("<td>{$maschinenverwendung['fertigungID']}</td>");
						echo("<td>{$maschinenverwendung['arbeitsfolge']}</td>");
						echo("<td><input class='btn btn-primary' type='button' value='Bearbeiten'  
						onclick='editMaschineVerwendung({$maschinen['maschinenID']});'></td>");
						};
					};
				};
						
						echo("</tr>");
				
				echo("<td><input class='btn btn-primary' type='button' value='Neues Maschineverwendung anlegen'  onclick='editMaschineVerwendung();'></td>");


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


