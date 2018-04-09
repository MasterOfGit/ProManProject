
<?php
//echo "PHP Datenabfrage<br>";
//$q = $_REQUEST[ "q" ];
//echo "Anfrage : " . $q . "<br>";

$ch1 = curl_init();


//curl_setopt($ch2, CURLOPT_URL, "http://zoomnation.selfhost.eu:8080/ProManAPI/api/adminPage/?identifier=AdminPageAbteilung");

curl_setopt( $ch1, CURLOPT_URL,"http://zoomnation.selfhost.eu/jsonData/fertigungslinien/fertigungslinien.json" );
curl_setopt( $ch1, CURLOPT_HEADER, 0 );
curl_setopt( $ch1, CURLOPT_RETURNTRANSFER, true );
$fertigungslinien = curl_exec( $ch1 );
curl_close( $ch1 );

// Testausgabe
//echo($maschinen);

// Unwandlung von json in Array	
$jsonfertigungslinien = json_decode($fertigungslinien, TRUE);
//print_r($fertigungslinien);

//print_r($jsonfertigungslinien);

echo <<<'HOME1_HEADER'
<div class="Fetigungslinie">
	<div class="jumbotron">
		<div class="container">

			<ul class="nav nav-tabs">
				<li class="active">
					<a data-toggle="tab" href="#home1">Fertigungslinen bearbeiten</a>
				</li>
				<li>
					<a data-toggle="tab" href="#menu1">Gertigungslinien Grafik</a>
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
									<th>Fertigungslinienname</th>
									<th>Arbeitfolge</th>
									<th>Maschine</th>
									<th>Technologie</th>
									<th>Fertigungstyp</th>
									<th>Teilenummer</th>
									<th>Arbeitsplan</th>
								</tr>
							</thead>
							<tbody>
HOME1_HEADER;
			
							
						foreach($jsonfertigungslinien['fertigungslinie'] as $fertigungslinie) 
						{	echo("<tr>");
							
							foreach($fertigungslinie['arbeitsfolgen'] as $arbeitsfolge) 
								{ 	echo("<td>{$fertigungslinie['fertigungslinieID']}</td>");
								 	echo("<td>{$fertigungslinie['fertigunglinenname']}</td>");
										echo("<td>{$arbeitsfolge['arbeitsfolgeID']}</td>"); 
										echo("<td>{$arbeitsfolge['maschineID']}</td>");
										echo("<td>{$arbeitsfolge['technologie']}</td>");
										echo("<td>{$arbeitsfolge['fertigungstyp']}</td>");
										echo("<td>{$arbeitsfolge['bauteilID']}</td>");
										echo("<td>{$arbeitsfolge['arbeitplan']}</td>");

										echo("<td><input type='button' value='lÃ¶schen'  onclick='testbuttonaction();'></td>");
										echo("<td><input type='button' value='verschieben'  onclick='testbuttonaction();'></td>");
								echo("</tr>");
								};
						 
						};
echo("<td><input type='button' value='Neue Arbeitfolge'  onclick='testbuttonaction();'></td>");
echo("<td><input type='button' value='Speichern'  onclick='testbuttonaction();'></td>");
echo("<td><input type='button' value='Reset'  onclick='testbuttonaction();'></td>");
echo("<td><input type='button' value='Neu Fertigungslinie'  onclick='testbuttonaction();'></td>");
echo("<td><input type='button' value='Fertigunglinie lÃ¶schen'  onclick='testbuttonaction();'></td>");


echo <<<'HOME1_FOOTER'
							</tbody>
						</table>
					</div>
				</div>
HOME1_FOOTER;
						 
echo("test");
						 
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
