<?php
//echo "PHP Datenabfrage<br>";
$q = $_REQUEST["q"];
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

<script>
function createData(q)
{
		// TODO: Neue instandhaltungID muss ermittelt werden

		var data = JSON.stringify(
		{
	
			"instandhaltungID"			:	1,

			"abteilung"					: 	$("abteilungNew").val(),
			
			"fachrichtung"				:	$("fachrichtungNew").val(),

			"fachbereich"				:	$("fachbereichNew").val(),	

			"machinenIventarnummer"		:	$("machinenIventarnummerNew").val(),

			"thema"						:	$("themaNew").val(),

			"fehlertext"				:	$("fehlertextNew").val(),

			"auftragsstatus"			:	"offen"
		}
);
saveNewReperaturAuftrag(data);

alert("createData saveNewReperaturAuftrag");

};
</script>

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

				<div id="home1" class="container tab-pane fade in active"><br>
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
								
																		
									echo("<td><input type='button' value='Ansehen'  onclick='editReperaturAuftrag({$instandhaltungsauftrag['instandhaltungID']});'></td>");
									echo("<td><input type='button' value='Annehmen'  onclick='acceptReperaturAuftrag({$instandhaltungsauftrag['instandhaltungID']});'></td>");
									echo("<td><input type='button' value='Löschen'  onclick='deleteReperaturAuftrag({$instandhaltungsauftrag['instandhaltungID']});'></td>");
									
									
									echo("</td>");
								echo("</tr>");
								};
							};
echo <<<FOOTER1

							</tbody>
						</table>

						

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
								
									echo("<td><input type='button' value='Ansehen'  onclick='editReperaturAuftrag({$instandhaltungsauftrag['instandhaltungID']});'></td>");
									echo("<td><input type='button' value='Annehmen'  onclick='acceptReperaturAuftrag({$instandhaltungsauftrag['instandhaltungID']});'></td>");
									echo("<td><input type='button' value='Löschen'  onclick='deleteReperaturAuftrag({$instandhaltungsauftrag['instandhaltungID']});'></td>");
									
									echo("</td>");
								echo("</tr>");
								};
							};
echo <<<FOOTER2

							</tbody>
						</table>

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
								
									echo("<td><input type='button' value='Ansehen'  onclick='editReperaturAuftrag({$instandhaltungsauftrag['instandhaltungID']});'></td>");
									echo("<td><input type='button' value='Annehmen'  onclick='acceptReperaturAuftrag({$instandhaltungsauftrag['instandhaltungID']});'></td>");
									echo("<td><input type='button' value='Löschen'  onclick='deleteReperaturAuftrag({$instandhaltungsauftrag['instandhaltungID']});'></td>");
									
									echo("</td>");
								echo("</tr>");
								};
							};
echo <<<FOOTER3

							</tbody>
						</table>

						

					</div>
				</div>
FOOTER3;

echo <<<HEADER4
				<div id="menu3" class="container tab-pane fade"><br>
					
					<lable>Auftragnummer</lable><br>
					<input id="instandhaltungIDNew" type="text"><br>
					
					<lable>Abteilung</lable><br>
					<input id="abteilungNew" type="text"><br>
					
					<lable>Fachrichtung</lable><br>
					<select id="fachrichtungNew">
							<option>elektrisch</option>
							<option>mechanisch</option>
							<option>unbekannt</option>
					</select><br>
					
					<lable>Fachbereich</lable><br>
					<select id="fachbereichNew">
							<option>intern</option>
							<option>extern</option>
					</select><br>
					
					<lable>Maschine</lable><br>
					<input id="machinenIventarnummerNew" type="text"><br>
					
					<lable>Standort</lable><br>
					<input id="themaNew" type="text"><br>
					
					<lable>Problemthema</lable><br>
					<input id="fehlertextNew" type="text"><br>
					
					<lable>Problembeschreibung</lable><br>
					<input id="auftragsstatusNew" type="text"><br>
					<br>
					
					
					
					<input type="button" value="Neuen Auftrag erstellen" onclick="createData(0)">

					</form>

				</div>
			</div>
		</div>
	</div>
</div>

HEADER4;

?>