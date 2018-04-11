<?php
//echo "PHP Datenabfrage<br>";
//$q = $_REQUEST["q"];
//echo "Abfragenummer : "  . $q . "<br>";
//echo "phpDateiName : "  . __FILE__ . "<br>";
$ch1 = curl_init();


//curl_setopt($ch2, CURLOPT_URL, "http://zoomnation.selfhost.eu:8080/ProManAPI/api/adminPage/?identifier=AdminPageAbteilung");

curl_setopt( $ch1, CURLOPT_URL,"http://zoomnation.selfhost.eu/jsonData/instandhaltung/instandhaltung.json" );
curl_setopt( $ch1, CURLOPT_HEADER, 0 );
curl_setopt( $ch1, CURLOPT_RETURNTRANSFER, true );
$instandhaltungsauftraege = curl_exec( $ch1 );
curl_close( $ch1 );
// Testausgabe
//echo($maschinen);

// Unwandlung von json in Array	
$jsoninstandhaltungsauftraege = json_decode($instandhaltungsauftraege, TRUE);
//print_r($instandhaltungsauftraege);




echo <<<Header1

<div class="Instandhaltung">
	<div class="jumbotron">
		<div class="container">
			<h2>Instandhaltungsaufträge</h2>
			<br>
			<!-- Nav tabs -->
			<ul class="nav nav-tabs" role="tablist">
				<li class="nav-item"> <a class="nav-link active" data-toggle="tab" href="#home1">offen Auftrage</a>&nbsp;</li>
				<li class="nav-item"> <a class="nav-link" data-toggle="tab" href="#menu1">angenommene Aufträge</a>
				</li>
				<li class="nav-item"> <a class="nav-link" data-toggle="tab" href="#menu2">erledigte Auftrage</a>
				</li>
				<li class="nav-item"> <a class="nav-link" data-toggle="tab" href="#menu3">Auftrage anlegen</a>
				</li>
			</ul>

			<!-- Tab panes -->
			<div class="tab-content">

				<div id="home1" class="container tab-pane fade"><br>
					<form class="form-inline" action="/action_page.php">
						<label for="abteilung">Abteilung</label>
						<select id="abteilung">
							<option>Abteilung_1</option>
							<option>Abteilung_2</option>
							<option>Abteilung_3</option>
						</select>
						<label for="maschine">Maschine</label>
						<select id="Machine">
							<option>Maschine_1</option>
							<option>Maschine_2</option>
						</select>
						<label for="fachrichtung">Fachrichtung</label>
						<select id="fachrichtung">
							<option>Elektrisch</option>
							<option>mechanisck</option>
						</select>
						<label for="fachbereich">Fachbereich</label>
						<select id="fachbereich">
							<option>Intern</option>
							<option>ectern</option>
						</select>

					</form>
					<div class="table-responsive-sm">
						<table class="table">
							<thead>
								<tr>
									<th>Auftragnummer</th>
									<th>Abteilung</th>
									<th>Fachrichtung</th>
									<th>Fachbereich</th>
									<th>Maschine</th>
									<th>Thema</th>
									<th>Fehlertext</th>
								</tr>
							</thead>
							<tbody>
Header1;
					foreach($jsoninstandhaltungsauftraege['instandhaltungsauftraege'] as $instandhaltungsauftrag)
					{
					
							if($instandhaltungsauftrag['auftragsstatus'] == "offen")
							{
							echo("<tr>");
									echo("<td>{$instandhaltungsauftrag['instandhaltungID']}</td>");
									echo("<td>{$instandhaltungsauftrag['abteilung']}</td>");
									echo("<td>{$instandhaltungsauftrag['fachrichtung']} </td>");
									echo("<td>{$instandhaltungsauftrag['fachbereich']}</td>");
									echo("<td>{$instandhaltungsauftrag['machinenIventarnummer']}</td>");
									echo("<td>{$instandhaltungsauftrag['thema']}<br>");
									echo("<td>{$instandhaltungsauftrag['fehlertext']}<br>");
									echo("</td>");
								
																		
									echo("<td><input type='button' value='Ansehen'  onclick='testbuttonaction();'></td>");
									echo("<td><input type='button' value='Annehmen'  onclick='testbuttonaction();'></td>");
									echo("<td><input type='button' value='Löschen'  onclick='testbuttonaction();'></td>");
									echo("<td><input type='button' value='Ändern'  onclick='testbuttonaction();'></td>");
									
									echo("</td>");
								echo("</tr>");
								};
							};
echo <<<FOOTER1

							</tbody>
						</table>

						<br>
						<input type="button" value="Aktualisieren" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">

					</div>
				</div>
FOOTER1;

echo <<<HEADER2
				<div id="menu1" class="container tab-pane fade"><br>
					<form class="form-inline" action="/action_page.php">
						<label for="abteilung">Abteilung</label>
						<select id="abteilung">
							<option>Abteilung_1</option>
							<option>Abteilung_2</option>
							<option>Abteilung_3</option>
						</select>
						<label for="maschine">Maschine</label>
						<select id="Machine">
							<option>Maschine_1</option>
							<option>Maschine_2</option>
						</select>
						<label for="fachrichtung">Fachrichtung</label>
						<select id="fachrichtung">
							<option>Elektrisch</option>
							<option>mechanisck</option>
						</select>
						<label for="fachbereich">Fachbereich</label>
						<select id="fachbereich">
							<option>Intern</option>
							<option>ectern</option>
						</select>

					</form>
					<div class="table-responsive-sm">
						<table class="table">
							<thead>
								<tr>
									<th>Auftragnummer</th>
									<th>Abteilung</th>
									<th>Fachrichtung</th>
									<th>Fachbereich</th>
									<th>Maschine</th>
									<th>Thema</th>
									<th>Fehlertext</th>
								</tr>
							</thead>
							<tbody>
HEADER2;
					foreach($jsoninstandhaltungsauftraege['instandhaltungsauftraege'] as $instandhaltungsauftrag)
					{
					
							if($instandhaltungsauftrag['auftragsstatus'] == "angenommen")
							{
							echo("<tr>");
									echo("<td>{$instandhaltungsauftrag['instandhaltungID']}</td>");
									echo("<td>{$instandhaltungsauftrag['abteilung']}</td>");
									echo("<td>{$instandhaltungsauftrag['fachrichtung']} </td>");
									echo("<td>{$instandhaltungsauftrag['fachbereich']}</td>");
									echo("<td>{$instandhaltungsauftrag['machinenIventarnummer']}</td>");
									echo("<td>{$instandhaltungsauftrag['thema']}<br>");
									echo("<td>{$instandhaltungsauftrag['fehlertext']}<br>");
									echo("</td>");
								
																		
									echo("<td><input type='button' value='Ansehen'  onclick='testbuttonaction();'></td>");
									echo("<td><input type='button' value='Annehmen'  onclick='testbuttonaction();'></td>");
									echo("<td><input type='button' value='Löschen'  onclick='testbuttonaction();'></td>");
									echo("<td><input type='button' value='Ändern'  onclick='testbuttonaction();'></td>");
									
									echo("</td>");
								echo("</tr>");
								};
							};
echo <<<FOOTER2

							</tbody>
						</table>

						<br>
						<input type="button" value="Aktualisieren" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">

					</div>
				</div>
FOOTER2;


echo <<<HEADER3
				<div id="menu2" class="container tab-pane fade"><br>
					<form class="form-inline" action="/action_page.php">
						<label for="abteilung">Abteilung</label>
						<select id="abteilung">
							<option>Abteilung_1</option>
							<option>Abteilung_2</option>
							<option>Abteilung_3</option>
						</select>
						<label for="maschine">Maschine</label>
						<select id="Machine">
							<option>Maschine_1</option>
							<option>Maschine_2</option>
						</select>
						<label for="fachrichtung">Fachrichtung</label>
						<select id="fachrichtung">
							<option>Elektrisch</option>
							<option>mechanisck</option>
						</select>
						<label for="fachbereich">Fachbereich</label>
						<select id="fachbereich">
							<option>Intern</option>
							<option>ectern</option>
						</select>

					</form>
					<div class="table-responsive-sm">
						<table class="table">
							<thead>
								<tr>
									<th>Auftragnummer</th>
									<th>Abteilung</th>
									<th>Fachrichtung</th>
									<th>Fachbereich</th>
									<th>Maschine</th>
									<th>Thema</th>
									<th>Fehlertext</th>
								</tr>
							</thead>
							<tbody>
HEADER3;
					foreach($jsoninstandhaltungsauftraege['instandhaltungsauftraege'] as $instandhaltungsauftrag)
					{
					
							if($instandhaltungsauftrag['auftragsstatus'] == "erledigt")
							{
							echo("<tr>");
									echo("<td>{$instandhaltungsauftrag['instandhaltungID']}</td>");
									echo("<td>{$instandhaltungsauftrag['abteilung']}</td>");
									echo("<td>{$instandhaltungsauftrag['fachrichtung']} </td>");
									echo("<td>{$instandhaltungsauftrag['fachbereich']}</td>");
									echo("<td>{$instandhaltungsauftrag['machinenIventarnummer']}</td>");
									echo("<td>{$instandhaltungsauftrag['thema']}<br>");
									echo("<td>{$instandhaltungsauftrag['fehlertext']}<br>");
									echo("</td>");
								
																		
									echo("<td><input type='button' value='Ansehen'  onclick='testbuttonaction();'></td>");
									echo("<td><input type='button' value='Annehmen'  onclick='testbuttonaction();'></td>");
									echo("<td><input type='button' value='Löschen'  onclick='testbuttonaction();'></td>");
									echo("<td><input type='button' value='Ändern'  onclick='testbuttonaction();'></td>");
									
									echo("</td>");
								echo("</tr>");
								};
							};
echo <<<FOOTER3

							</tbody>
						</table>

						<br>
						<input type="button" value="Aktualisieren" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">

					</div>
				</div>
FOOTER3;

echo <<<HEADER4
				<div id="menu3" class="container tab-pane fade"><br>
					
					<form class="form-inline" action="/action_page.php">
					<lable>Auftragnummer</lable><br>
					<input type="text"><br>
					<lable>Abteilung</lable><br>
					<input type="text"><br>
					<lable>Fachrichtung</lable><br>
					<select id="Fachrichtung">
							<option>elektrisch</option>
							<option>mechanisch</option>
							<option>unbekannt</option>
					</select><br>
					<lable>Fachbereich</lable><br>
					<select id="Fachbereich">
							<option>intern</option>
							<option>extern</option>
					</select><br>
					<lable>Maschine</lable><br>
					<input type="text"><br>
					<lable>Standort</lable><br>
					<input type="text"><br>
					<lable>Problemthema</lable><br>
					<input type="text"><br>
					<lable>Problembeschreibung</lable><br>
					<input type="text"><br>
					<br>
					
					
					
					<input type="button" value="Neuen Auftrag erstellen" onclick="loadDoc('lib/php/inst/instCRAuftragAnzeigen.php?q=1111',myFunction1)">

					</form>

				</div>
			</div>
		</div>
	</div>
</div>

HEADER4;

?>