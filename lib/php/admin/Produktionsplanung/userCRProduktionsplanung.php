
<?php
//echo "PHP Datenabfrage<br>";
//$q = $_REQUEST[ "q" ];
//echo "Anfrage : " . $q . "<br>";

$ch1 = curl_init();
$ch2 = curl_init();


curl_setopt( $ch1, CURLOPT_URL,"http://zoomnation.selfhost.eu/jsonData/produktionsplanung/produktionsplanung.json" );
curl_setopt( $ch1, CURLOPT_HEADER, 0 );
curl_setopt( $ch1, CURLOPT_RETURNTRANSFER, true );
$produktionsplan = curl_exec( $ch1 );
curl_close( $ch1 );
// Unwandlung von json in Array	
$jsonproduktionsplan = json_decode($produktionsplan, TRUE);
//print_r($jsonproduktionsplan);

curl_setopt( $ch2, CURLOPT_URL,"http://zoomnation.selfhost.eu/jsonData/produktionsplanung/lagerbestand.json" );
curl_setopt( $ch2, CURLOPT_HEADER, 0 );
curl_setopt( $ch2, CURLOPT_RETURNTRANSFER, true );
$lagerbestand = curl_exec( $ch2 );
curl_close( $ch2 );
// Unwandlung von json in Array	
$jsonlagerbestand = json_decode($lagerbestand, TRUE);
//print_r($jsonlagerbestand);

//print_r($jsonfertigungslinien);

echo <<<'HOME1_HEADER'



<div class="Produktionsplanung">
	<div class="jumbotron">
		<div class="container">

			<ul class="nav nav-tabs">
				<li class="active">
					<a data-toggle="tab" href="#home1">Produktionsprogramm</a>
				</li>
				<li>
					<a data-toggle="tab" href="#menu1">Lagerbestand</a>
				</li>
			</ul>
			<!-- Tab panes -->
			<div class="tab-content">
			<div id="home1" class="tab-pane fade in active"><br>

					  <div class="table-responsive-sm">
						<table class="table">
							<thead>
								<tr>
									<th>Folgenummer</th>
									<th>Bauteinummer</th>
									<th>Bauteilindex</th>
									<th>Verwendung</th>
									<th>Sollmenge</th>
									<th>Status</th>
									
								</tr>
							</thead>
							<tbody>
HOME1_HEADER;
			
							
						foreach($jsonproduktionsplan['produktionsplan'] as $prodschritt) 
						{	echo("<tr>");
							    echo("<td>{$prodschritt['folgenummer']}</td>");
								echo("<td>{$prodschritt['bauteilname']}</td>");
								echo("<td>{$prodschritt['bauteilindex']}</td>"); 
								echo("<td>{$prodschritt['bauteilverwendung']}</td>");
								echo("<td>{$prodschritt['prodMenge']}</td>");
								echo("<td>{$prodschritt['status']}</td>");
								echo("<td><input type='button' value='Verschieben'  onclick='moveProduktionplanSchritte({$prodschritt['folgenummer']});'></td>");
						 		echo("<td><input type='button' value='Löschen'  onclick='deleteProduktionplan({$prodschritt['folgenummer']});'></td>");
						 		echo("<td><input type='button' value='Status ändern'  onclick='changeSchrittStatusProduktionplan({$prodschritt['folgenummer']});'></td>");
						 
						};
echo("</tr>");
echo("<div>");
echo("<td><input type='button' value='Neue Produktionsmenge hinzufügen'  onclick='editProduktionplanSchritt();'></td>");
echo("<td><input type='button' value='Speichern'  onclick='saveProduktionplan();'></td>");
echo("</div>");

echo <<<'HOME1_FOOTER'
							</tbody>
						</table>
					</div>
				</div>
HOME1_FOOTER;

echo <<<MENU1_HEADER
				<div id="menu1" class="tab-pane fade">           
				  <div class="table-responsive-sm">
					<table class="table">
							<thead>
								<tr>
									<th>Lagerort</th>
									<th>Bauteiname</th>
									<th>Bauteilindex</th>
									<th>Verwendung</th>
									<th>Minmenge</th>
									<th>Sollmenge</th>
									
									
								</tr>
							</thead>
							<tbody>
MENU1_HEADER;
			
							
						foreach($jsonlagerbestand['lagerbestaende'] as $lagerbestand) 
						{	echo("<tr>");
							    echo("<td>{$lagerbestand['lagerplatz']}</td>");
						 		echo("<td>{$lagerbestand['bauteilname']}</td>");
								echo("<td>{$lagerbestand['bauteilindex']}</td>");
								echo("<td>{$lagerbestand['bauteilverwendung']}</td>"); 
								echo("<td>{$lagerbestand['minBestand']}</td>");
								echo("<td>{$lagerbestand['istBestand']}</td>");
								echo("<td><input type='button' value='Änder'  onclick='editLagerort({$lagerbestand['lagerplatz']});'></td>");
						 		echo("<td><input type='button' value='Löschen'  onclick='deleteLagerort({$lagerbestand['lagerplatz']});'></td>");
						 		
						 

						};
echo("</tr>");
echo("<div>");
echo("<td><input type='button' value='Neue Lagerort hinzufügen'  onclick='editLagerort(0);'></td>");
echo("<td><input type='button' value='Speichern'  onclick='saveAllLagerort();'></td>");
echo("</div>");

echo <<<'MENU1_FOOTER'
							</tbody>
						</table>
					</div>
				</div>
MENU1_FOOTER;
						 


?>
