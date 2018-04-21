<!--
Ersteller : Markus Kessler	
MatrNr 	  : 894361
Presentation: 28.04.2018
Theam : ProMan
-->
<?php
//echo "PHP Datenabfrage<br>";
//$q = $_REQUEST[ "q" ];
//echo "Anfrage : " . $q . "<br>";

$ch1 = curl_init();


//curl_setopt($ch2, CURLOPT_URL, "http://zoomnation.selfhost.eu:8080/ProManAPI/api/adminPage/?identifier=AdminPageAbteilung");

curl_setopt( $ch1, CURLOPT_URL,"http://zoomnation.selfhost.eu/jsonData/abteilung/abteilung.json" );
//curl_setopt( $ch1, CURLOPT_URL,"http://localhost:50435/api/abteilung" );
curl_setopt( $ch1, CURLOPT_HEADER, 0 );
curl_setopt( $ch1, CURLOPT_RETURNTRANSFER, true );
$abteilungen = curl_exec( $ch1 );
curl_close( $ch1 );

// Unwandlung von json in Array	
$jsonabteilungen = json_decode($abteilungen, TRUE);

echo <<<'HOME1_HEADER'

<script>
function removeentry(parent,id)
{
	alert("Remove"+parent+id);
	deleteFertigungAbteilung(parent, id);
};
</script>

<div class="Abteilung">
	<div class="jumbotron">
		<div class="container">

			<ul class="nav nav-tabs">
				<li class="active">
					<a data-toggle="tab" href="#home1">Abteilung bearbeiten</a>
				</li>
				<li>
					<a data-toggle="tab" href="#menu1">Abteilung Grafik</a>
				</li>
			</ul>
			<!-- Tab panes -->
			<div class="tab-content">
				<div id="home1" class="tab-pane fade in active"><br>

					<div class="table-responsive-sm">
						<table class="table">
							<thead>
								<tr>
									<th>AbteilungsID</th>
									<th>Abteilungsname</th>
									<th>FertigungsID</th>
									<th>Fertigungsname</th>
								</tr>
							</thead>
							<tbody>
HOME1_HEADER;
			
							
						foreach($jsonabteilungen as $abteilung) 
						{	echo("<tr>");
							
							foreach($abteilung['Fertigungen'] as $fertigung) 
								{ 	   	echo("<td>{$abteilung['abteilungsID']}</td>");
										echo("<td>{$abteilung['abteilungsname']}</td>");
										echo("<td>{$fertigung['fertigungsID']}</td>"); 
										echo("<td>{$fertigung['fertigungsname']}</td>");	
										echo("<td><input class='btn btn-primary' type='button' value='entfernen'  onclick='deleteFertigungAbteilung({$abteilung['abteilungsID']},{$fertigung['fertigungsID']});'></td>");
										
								echo("</tr>");
								};
						 echo("<td><input class='btn btn-primary' type='button' value='Neue Fertigung zu {$abteilung['abteilungsname']} hinzufügen'  onclick='editFertigungAbteilung({$abteilung['abteilungsID']});'></td>");
						};
			echo("</tbody>");
			echo("</table>");
			echo("<br>");
echo("<br>");
echo("<td><input class='btn btn-primary' type='button' value='Neue Abteilung hinzufügen'  onclick='newAbteilung();'></td>");
echo("<td><input class='btn btn-primary' type='button' value='Alles Speichern'  onclick='saveAbteilungen();'></td>");


echo <<<'HOME1_FOOTER'
						
					</div>
				</div>
HOME1_FOOTER;

						 
echo <<<'MENU1_HEADER'
<div id="menu1" class="container tab-pane fade"><br>
					<form class="form-inline" action="/action_page.php">
					</form>
					<canvas id="myCanvas" width="400" height="400" style="border:1px solid #d3d3d3;">
						Your browser does not support the HTML5 canvas tag.</canvas>
					<input class='btn btn-primary'  type="button" value="Grafik generierren" onclick="createCanvas()">

			</div>
		</div>
      </div>	
	</div>
</div>

MENU1_HEADER;
?>
