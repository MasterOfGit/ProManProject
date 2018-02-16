<?php
echo "PHP Datenabfrage<br>";
$q = $_REQUEST[ "q" ];
echo "Anfrage : " . $q . "<br>";

?>

<div class="Fertigungslinie">
	<div class="jumbotron">
		<div class="container">
			<h2>Fertigungslinie</h2>
			<br>
			<!-- Nav tabs -->
			<ul class="nav nav-tabs" role="tablist">
				<li class="nav-item"> <a class="nav-link active" data-toggle="tab" href="#home100">Fertigungslinie anlegen</a>&nbsp;</li>
				<li class="nav-item"> <a class="nav-link" data-toggle="tab" href="#menu100">Fertigungslinien anzeigen</a>
				</li>
				<li class="nav-item"> <a class="nav-link" data-toggle="tab" href="#menu101">Fertigungsgrafik</a>
				</li>
			</ul>

			<!-- Tab panes -->
			<div class="tab-content">

				<div id="home100" class="container tab-pane fade"><br>
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
						
						MEHRERE TEILENUMMERM PRO FERTIGUNGSLINIE ????
					</form>
					<div class="table-responsive-sm">
						<table class="table">
							<thead>
								<tr>
									<th>Arbeitsfolge</th>
									<th>Maschine</th>
									<th>Technologie</th>
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
						</div>
						<br>
						<div>
							<input type="button" value="Alles Speicher" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
							<input type="button" value="Reset" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
						</div>
					</div>
				</div>

				<div id="menu100" class="container tab-pane fade"><br>
					<form class="form-inline" action="/action_page.php">
<label for="fertigung">Fertigungslinie</label>
						<select id="fertigung">
							<option>Fertigunglinie_1</option>
							<option>Fertigunglinie_2</option>
							<option>Fertigunglinie_3</option>
						</select>

					</form>
					<div class="table-responsive-sm">
						<table class="table">
							<thead>
								<tr>
									<th>Fertigungslinie</th>
									<th>Maschine</th>
									
								</tr>

							</thead>
							<tbody>
								<tr>
									
									<td>Fertigung_1</td>
									<td>Maschine_1</td>

									<td><input type="button" value="Bearbeiten" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
										<input type="button" value="Löschen" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
									</td>
								</tr>
								<tr>
									
									<td>Fertigung_1</td>
									<td>Maschine_3</td>

									<td><input type="button" value="Bearbeiten" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
										<input type="button" value="Löschen" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
									</td>
								</tr>
								<tr>
									
									<td>Fertigung_1</td>
									<td>Maschine_7</td>

									<td><input type="button" value="Bearbeiten" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
										<input type="button" value="Löschen" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
									</td>
								</tr>

							
							</tbody>
						</table>

					</div>
				</div>

				<div id="menu101" class="container tab-pane fade"><br>
					<form class="form-inline" action="/action_page.php">
						
						
					</form>
					<canvas id="myCanvas" width="400" height="500" style="border:1px solid #d3d3d3;">
						Your browser does not support the HTML5 canvas tag.</canvas>


						<input type="button" value="Grafik generierren" onclick="createCanvas()">

				</div>
			</div>
		</div>
	</div>
</div>