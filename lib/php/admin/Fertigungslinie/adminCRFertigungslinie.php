<?php
//echo "PHP Datenabfrage<br>";
//$q = $_REQUEST[ "q" ];
//echo "Anfrage : " . $q . "<br>";

?>

<div class="Fertigungslinie">
	<div class="jumbotron">
		<div class="container">
			<h2>Fertigungslinie</h2>
			<br>
			<!-- Nav tabs -->
			<ul class="nav nav-tabs" role="tablist">
				<li class="nav-item"> <a class="nav-link active" data-toggle="tab" href="#home1">Fertigungslinien</a>&nbsp;</li>
				<li class="nav-item"> <a class="nav-link" data-toggle="tab" href="#menu1">Fertigungsliniengrafik</a>
				</li>
			</ul>

			<!-- Tab panes -->
			<div class="tab-content">

				<div id="home1" class="container tab-pane fade"><br>
					<form class="form-inline" action="/action_page.php">
						<label for="fertigung">Fertigungslinie</label>
						<select id="fertigung">
							<option>Fertigunglinie_1</option>
							<option>Fertigunglinie_2</option>
							<option>Fertigunglinie_3</option>
						</select>
						<label for="fertigungstype">Fertigungstyp</label>
						<select id="fertigungstype">
							<option>Grünfertigung</option>
							<option>Hardfertigung</option>
							<option>Härter</option>
							<option>Montage</option>
							<option>Qualitätssicherung</option>
						</select>
						<label for="teilenummer">Teilenummer</label>
						<select id="teilenummer">
							<option>Festrad_1</option>
							<option>Festrad_2</option>
							<option>Festrad_3</option>
							<option>Schaldradrad_1</option>
							<option>Schaldradrad_2</option>
							<option>Schaldradrad_3</option>
						</select>

					</form>
					<div class="table-responsive-sm">
						<table class="table">
							<thead>
								<tr>
									<th>Arbeitsfolge</th>
									<th>Maschine</th>
									<th>Technologie</th>
									<th>Fertigungstype</th>
									<th>Teilenummer</th>
									<th>Arbeitsplan</th>
								</tr>
							</thead>
							<tbody>
								<tr>
									<td>1</td>
									<td>
										<select>
											<option selected>Maschine_1</option>
											<option>Maschine_2</option>
											<option>Maschine_3</option>
											<option>Maschine_4</option>
											<option>Maschine_5</option>
										</select>
									</td>
									<td>
										Drehen
									</td>
									<td>
										Grünfertigung
									</td>
									<td>
										Festrad_1
									</td>
									<td>
										Rohteil drehen
									</td>
									<td><input type="button" value="Löschen" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
										<input type="button" value="Verschieben" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
									</td>
								</tr>
								<tr>
									<td>2</td>
									<td>
										<select>
											<option>Maschine_1</option>
											<option selected>Maschine_2</option>
											<option>Maschine_3</option>
											<option>Maschine_4</option>
											<option>Maschine_5</option>
										</select>
									</td>
									<td>
										Fräsen
									</td>
									<td>
										Grünfertigung
									</td>
									<td>
										Festrad_1
									</td>
									<td>
										Verzahnung fräsen
									</td>
									<td><input type="button" value="Löschen" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
										<input type="button" value="Verschieben" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
									</td>
								</tr>
								<tr>
									<td>3</td>
									<td>
										<select>
											<option>Maschine_1</option>
											<option>Maschine_2</option>
											<option selected>Maschine_3</option>
											<option>Maschine_4</option>
											<option>Maschine_5</option>
										</select>
									</td>
									<td>
										Entgraten
									</td>
									<td>
										Grünfertigung
									</td>
									<td>
										Festrad_1
									</td>
									<td>
										Verzahnung entgraten
									</td>
									<td><input type="button" value="Löschen" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
										<input type="button" value="Verschieben" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
									</td>
								</tr>
								<tr>
									<td>4</td>
									<td>
										<select>
											<option>Maschine_1</option>
											<option>Maschine_2</option>
											<option>Maschine_3</option>
											<option selected>Maschine_4</option>
											<option>Maschine_5</option>
										</select>
									</td>
									<td>
										Waschen
									</td>
									<td>
										Grünfertigung
									</td>
									<td>
										Festrad_1
									</td>
									<td>
										none
									</td>
									<td><input type="button" value="Löschen" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
										<input type="button" value="Verschieben" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
									</td>
								</tr>
								<tr>
									<td>5</td>
									<td>
										<select>
											<option>Maschine_1</option>
											<option>Maschine_2</option>
											<option>Maschine_3</option>
											<option>Maschine_4</option>
											<option selected>Maschine_5</option>
										</select>
									</td>
									<td>
										Messen
									</td>
									<td>
										Grünfertigung
									</td>
									<td>
										Festrad_1
									</td>
									<td>
										none
									</td>
									<td><input type="button" value="Löschen" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
										<input type="button" value="Verschieben" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
									</td>
								</tr>
							</tbody>
						</table>
						<div>
							<input type="button" value="Neu Arbeitsfolge hinzufügen" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
							<input type="button" value="Alles Speicher" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
							<input type="button" value="Reset" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
						</div>
						<br>
						<div>
							<input type="button" value="Neu Fertigungslinie anlegen" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
							<input type="button" value="Fertigungslinie löschen" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
							</divv>
							<br>
							<div>

							</div>
						</div>
					</div>
				</div>


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