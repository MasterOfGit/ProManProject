<?php
//echo "PHP Datenabfrage<br>";
//$q = $_REQUEST["q"];
//echo "Anfrage : "  . $q . "<br>";

$ch1 = curl_init();

curl_setopt($ch1, CURLOPT_URL, "http://zoomnation.selfhost.eu:8080/ProManAPI/api/adminPage/?identifier=AdminPageBauteil");
curl_setopt($ch1, CURLOPT_HEADER, 0);
curl_setopt($ch1,CURLOPT_RETURNTRANSFER,true);
$result=curl_exec($ch1);
$json = json_decode( $result, TRUE );
curl_close( $ch1 );

print_r($result);

echo <<<'HOME1_HEADER'
<div class="Bauteil">
	<div class="jumbotron">
		<div class="container">
			<h2>Bauteil</h2>
			<br>
			<!-- Nav tabs -->
			<ul class="nav nav-tabs" role="tablist">
				<li class="nav-item"> 
					<a class="nav-link active" data-toggle="tab" href="#home1">Bauteie bearbeiten</a>&nbsp;</li>
				<li class="nav-item"> 
					<a class="nav-link" data-toggle="tab" href="#menu1">Bauteilverwendung</a>
				</li>
			</ul>

			<!-- Tab panes -->
			<div class="tab-content">
				<div id="home1" class="container tab-pane fade aktive"><br>
					
					<div class="table-responsive-sm">
						<table class="table">
							<thead>
								<tr>
									<th>Teilenummer</th>
									<th>Index</th>
									<th>Version</th>
									<th>Verwendungsort</th>
									<th>Abhaengigkkeit</th>
									<th></th>
								</tr>
							</thead>
						<tbody>

HOME1_HEADER;

foreach($json['Bauteile'] as $item)
	{
	echo("<tr>");
	echo("<td>{$item['ID']}</td>");
	echo("<td>{$item['Teilart']}</td>");
	echo("<td>{$item['Version']}</td>");
	echo("<td>{$item['Verwendungsort'] }</td>");
	echo("<td>{$item['Abhaengigkeiten']}</td>");
	
	echo("<td><input type='button' value='Bearbeiten'  onclick='testbuttonaction({$item['ID']});'></td>");
	echo("</tr>");
	};

echo <<<'HOME1_Footer'

					</tbody>
					</table>
				  </div>
				</div>
HOME1_Footer;

echo <<<'MENU1_HEADER'
<div id="menu1" class="container tab-pane"><br>
					<h3>Maschinen</h3>
					<form class="form-inline" action="/action_page.php">
						<input class="form-control mr-sm-2" type="text" placeholder="Search">
						<button class="btn btn-success" type="submit">Search</button>
					</form>
					<div class="table-responsive-sm">
						<table class="table">
							<thead>
								<tr>
									<th>Fertigungslinie</th>
									<th>Teilenummer</th>
									<th>Index</th>
									<th>MaschinenID</th>
									<th>Technologie</th>
									<th>Bearbeitung</th>
									<th>Bear.Schritt</th>
									<th>GType</th>
								</tr>
							</thead>
							<tbody>
								<tr>
									<td>Festrad 3</td>
									<td>123 445 777</td>
									<td>BB</td>
									<td>112254</td>
									<td>HardDrehen</td>
									<td>PlanF 10a</td>
									<td>1</td>
									<td>5.Gang Getrieb 1254as8</td>
									<td><input type="button" value="Verw. bearbeiten" onclick="loadDoc('lib/php/admin/adminContentRequestBauteilVerwBear.php?q=1111',myFunction1)">
									</td>
								</tr>
								<tr>
									<td>Festrad 3</td>
									<td>123 445 777</td>
									<td>AD</td>
									<td>125545</td>
									<td>Verz.Schleifen</td>
									<td>VZ Aussen</td>
									<td>2</td>
									<td>5.Gang Getrieb 1254as8</td>
									<td><input type="button" value="Verw. bearbeiten" onclick="loadDoc('lib/php/admin/adminContentRequestBauteilVerwBear.php?q=1111',myFunction1)">
									</td>
								</tr>
								<tr>
									<td></td>
									<td>123 445 777</td>
									<td>NEU</td>
									<td></td>
									<td>Verz.Schleifen</td>
									<td>VZ Aussen</td>
									<td>2</td>
									<td>5.Gang Getrieb 1254as99</td>
									<td><input type="button" value="Verw. bearbeiten" onclick="loadDoc('lib/php/admin/adminContentRequestBauteilVerwBear.php?q=1111',myFunction1)">
									</td>
								</tr>

							</tbody>
						</table>
						<input type="button" value="Neue Bauteil Verwendung anlegen" onclick="loadDoc('lib/php/admin/adminContentRequestBauteilVerwBear.php?q=1111',myFunction1)">
						</td>
					</div>
				</div>
			</div>
		</div>
	</div>
</div>
MENU1_HEADER;
?>


