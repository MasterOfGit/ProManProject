
<?php
//echo "PHP Datenabfrage<br>";
//$q = $_REQUEST[ "q" ];
//echo "Anfrage : " . $q . "<br>";

$ch1 = curl_init();


//curl_setopt($ch2, CURLOPT_URL, "http://zoomnation.selfhost.eu:8080/ProManAPI/api/adminPage/?identifier=AdminPageAbteilung");

curl_setopt( $ch1, CURLOPT_URL,"http://zoomnation.selfhost.eu/jsonData/fertigung/fertigungen.json" );
curl_setopt( $ch1, CURLOPT_HEADER, 0 );
curl_setopt( $ch1, CURLOPT_RETURNTRANSFER, true );
$fertigungen = curl_exec( $ch1 );
curl_close( $ch1 );

// Testausgabe
//echo($maschinen);

// Unwandlung von json in Array	
$jsonfertigungen = json_decode($fertigungen, TRUE);
//print_r($jsonfertigungen);

//print_r($jsonfertigungslinien);

echo <<<'HOME1_HEADER'
<div class="Fetigung">
	<div class="jumbotron">
		<div class="container">

			<ul class="nav nav-tabs">
				<li class="active">
					<a data-toggle="tab" href="#home1">Fertigung bearbeiten</a>
				</li>
				<li>
					<a data-toggle="tab" href="#menu1">Fertigung Grafik</a>
				</li>
			</ul>
			<!-- Tab panes -->
			<div class="tab-content">
				<div id="home1" class="tab-pane fade in active"><br>

					<div class="table-responsive-sm">
						<table class="table">
							<thead>
								<tr>
									<th>FertigungsID</th>
									<th>Fertigungsname</th>
									<th>FertigungslinienID</th>
									<th>Fertigungslinienname</th>
									<th>Fertigungstyp</th>
									<th>Maschinenzahl</th>
								</tr>
							</thead>
							<tbody>
HOME1_HEADER;
			
							
						foreach($jsonfertigungen['fertigungen'] as $fertigung) 
						{	echo("<tr>");
							
							foreach($fertigung['fertigungslinien'] as $fertigungslinie) 
								{ 	    echo("<td>{$fertigung['fertigungsID']}</td>");
										echo("<td>{$fertigung['fertigungsname']}</td>");
										echo("<td>{$fertigungslinie['fertigungslinienID']}</td>"); 
										echo("<td>{$fertigungslinie['fertigungslinienname']}</td>");
										echo("<td>{$fertigungslinie['fertigungstyp']}</td>");
										echo("<td>{$fertigungslinie['maschinenzahl']}</td>");
										echo("<td><input type='button' value='loeschen'  onclick='testbuttonaction();'></td>");
										
								echo("</tr>");
								};
						 
						};
echo("<td><input type='button' value='Fertigungslinie hinzufügen'  onclick='testbuttonaction();'></td>");
echo("<td><input type='button' value='Speichern'  onclick='testbuttonaction();'></td>");
echo("<td><input type='button' value='Reset'  onclick='testbuttonaction();'></td>");
echo("<td><input type='button' value='Neu Fertigung anlegen'  onclick='testbuttonaction();'></td>");
echo("<td><input type='button' value='Diese Fertigung löschen'  onclick='testbuttonaction();'></td>");


echo <<<'HOME1_FOOTER'
							</tbody>
						</table>
					</div>
				</div>
HOME1_FOOTER;

						 
echo <<<'MENU1_HEADER'
<div id="menu1" class="container tab-pane fade"><br>
					<form class="form-inline" action="/action_page.php">
					</form>
					<canvas id="myCanvas" width="400" height="400" style="border:1px solid #d3d3d3;">
						Your browser does not support the HTML5 canvas tag.</canvas>
					<input type="button" value="Grafik generierren" onclick="createCanvas()">

			</div>
		</div>
      </div>	
	</div>
</div>

MENU1_HEADER;
?>
