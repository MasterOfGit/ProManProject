<?php
echo "PHP Datenabfrage<br>";
$q = $_REQUEST[ "q" ];
echo "Anfrage : " . $q . "<br>";

?>

<div class="Fertigung">
	<div class="jumbotron">
		<div class="container">
			<h2>Fertigungslinie</h2>
			<br>
			<!-- Nav tabs -->
			<ul class="nav nav-tabs" role="tablist">
				<li class="nav-item"> <a class="nav-link active" data-toggle="tab" href="#home100">Fertigung anlegen</a>&nbsp;</li>
				<li class="nav-item"> <a class="nav-link" data-toggle="tab" href="#menu100">Fertigung anzeigen</a>
				</li>
				<li class="nav-item"> <a class="nav-link" data-toggle="tab" href="#menu101">Fertigungsgrafik</a>
				</li>
			</ul>

			<!-- Tab panes -->
			<div class="tab-content">

				<div id="home100" class="container tab-pane fade"><br>
					<form class="form-inline" action="/action_page.php">
						<label for="fertigung">Fertigung</label>
						<select id="fertigung">
							<option>Fertigung_1</option>
							<option>Fertigung_2</option>
							<option>Fertigung_3</option>
						</select>
					</form>
					<div class="table-responsive-sm">
						<table class="table">
							<thead>
								<tr>
									<th>Fertigungslinien</th>
									<th>Fertigungstyp</th>
									<th>Maschinenzahl</th>

								</tr>
							</thead>
							<tbody>
								<tr>
									<td>
										<select>
											<option selected>Fertigunglinie_1</option>
											<option>Fertigunglinie_2</option>
											<option>Fertigunglinie_3</option>
											<option>Fertigunglinie_4</option>
											<option>Fertigunglinie_5</option>
										</select>
									</td>
									<td>Grünfertigung
									</td>
									<td>5</td>
									<td><input type="button" value="Löschen" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">

									</td>
								</tr>
								
								<tr>
									<td>
										<select>
											<option >Fertigunglinie_1</option>
											<option>Fertigunglinie_2</option>
											<option selected>Fertigunglinie_3</option>
											<option>Fertigunglinie_4</option>
											<option>Fertigunglinie_5</option>
										</select>
									</td>
									<td>Grünfertigung
									</td>
									<td>3</td>
									<td><input type="button" value="Löschen" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">

									</td>
								</tr>
								
								<tr>
									<td>
										<select>
											<option >Fertigunglinie_1</option>
											<option>Fertigunglinie_2</option>
											<option>Fertigunglinie_3</option>
											<option selected>Fertigunglinie_4</option>
											<option>Fertigunglinie_5</option>
										</select>
									</td>
									<td>Grünfertigung
									</td>
									<td>7</td>
									<td><input type="button" value="Löschen" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">

									</td>
								</tr>
								
								<tr>
									<td>
										<select>
											<option >Fertigunglinie_1</option>
											<option>Fertigunglinie_2</option>
											<option>Fertigunglinie_3</option>
											<option>Fertigunglinie_4</option>
											<option selected>Fertigunglinie_5</option>
										</select>
									</td>
									<td>Grünfertigung
									</td>
									<td>2</td>
									<td><input type="button" value="Löschen" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">

									</td>
								</tr>
								
							</tbody>
						</table>
						<br>
						<div>
							<input type="button" value="Neu Fertigungsline hinzufügen" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
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
						<label for="fertigung">Fertigung</label>
						<select id="fertigung">
							<option>Fertigung_1</option>
							<option>Fertigung_2</option>
							<option>Fertigung_3</option>
						</select>
						<label for="abteilung">Abteilung</label>
						<select id="abteilung">
							<option>Abteilung_1</option>
							<option>Abteilung_2</option>
							<option>Abteilung_3</option>
						</select>
						
						<label for="fertigungslinie">Fertigungslinie</label>
						<select id="fertigungslinie">
							<option>Fertigunglinie_1</option>
							<option>Fertigunglinie_2</option>
							<option>Fertigunglinie_3</option>
						</select>
						<label for="maschine">Maschine</label>
						<select id="Maschine">
							<option>Maschine_1</option>
							<option>Maschine_2</option>
							<option>Maschine_3</option>
						</select>


					</form>
					<div class="table-responsive-sm">
						<table class="table">
							<thead>
								<tr>
									<th>Fertigung</th>
									<th>Abteilung</th>
									<th>Fertigungslinie</th>
									<th>Maschinezahl</th>
								</tr>

							</thead>
							<tbody>
								<tr>
									<td>Fertigung_1</td>
									<td>Abteilung_2</td>
									<td>Fertigungsline_1</td>
									<td>2</td>

									<td><input type="button" value="Bearbeiten" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
										<input type="button" value="Löschen" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
									</td>
								</tr>
								
									<tr>
									<td>Fertigung_1</td>
									<td>Abteilung_2</td>
									<td>Fertigungsline_5</td>
									<td>5</td>

									<td><input type="button" value="Bearbeiten" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
										<input type="button" value="Löschen" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
									</td>
								</tr>
								
									<tr>
									<td>Fertigung_1</td>
									<td>Abteilung_2</td>
									<td>Fertigungsline_7</td>
									<td>7</td>

									<td><input type="button" value="Bearbeiten" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
										<input type="button" value="Löschen" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
									</td>
								</tr>
								
									<tr>
									<td>Fertigung_3</td>
									<td></td>
									<td>Fertigungsline_1</td>
									<td>3</td>

									<td><input type="button" value="Bearbeiten" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
										<input type="button" value="Löschen" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
									</td>
								</tr>
								
									<tr>
									<td>Fertigung_3</td>
									<td></td>
									<td>Fertigungsline_5</td>
									<td>7</td>

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