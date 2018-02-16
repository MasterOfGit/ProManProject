<?php
echo "PHP Datenabfrage<br>";
$q = $_REQUEST[ "q" ];
echo "Anfrage : " . $q . "<br>";

?>

<div class="Instandhaltung">
	<div class="jumbotron">
		<div class="container">
			<h2>Instandhaltungsaufträge</h2>
			<br>
			<!-- Nav tabs -->
			<ul class="nav nav-tabs" role="tablist">
				<li class="nav-item"> <a class="nav-link active" data-toggle="tab" href="#home100">offen Auftrage</a>&nbsp;</li>
				<li class="nav-item"> <a class="nav-link" data-toggle="tab" href="#menu100">angenommene Aufträge</a>
				</li>
				<li class="nav-item"> <a class="nav-link" data-toggle="tab" href="#menu101">erledigte Auftrage</a>
				</li>
				<li class="nav-item"> <a class="nav-link" data-toggle="tab" href="#menu102">Auftrage anlegen</a>
				</li>
			</ul>

			<!-- Tab panes -->
			<div class="tab-content">

				<div id="home100" class="container tab-pane fade"><br>
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
								</tr>
							</thead>
							<tbody>
								<tr>
									<td>100</td>
									<td>Abteilung_1</td>
									<td>Mechanisch </td>
									<td>Intern</td>
									<td>Maschine_7</td>
									<td> Pumpe def.<br>
									</td>

									<td>
										<input type="button" value="Ansehen" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)"><input type="button" value="Annehmen" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
										<input type="button" value="Löschen" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
										<input type="button" value="Ändern" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
									</td>
								</tr>
								<tr>
									<td>150</td>
									<td>Abteilung_1</td>
									<td>Elektrisch </td>
									<td>Intern</td>
									<td>Maschine_5</td>
									<td>Festplatte def.</td>

									<td>
										<input type="button" value="Ansehen" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)"><input type="button" value="Annehmen" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
										<input type="button" value="Löschen" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
										<input type="button" value="Ändern" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
									</td>
								</tr>



								<div>


								</div>


							</tbody>
						</table>

						<br>
						<input type="button" value="Aktualisieren" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">

					</div>
				</div>

				<div id="menu100" class="container tab-pane fade"><br>
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
							<option>Extern</option>
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
									<th>Arbeitsplan</th>
									<th>Status</th>
								</tr>
							</thead>
							<tbody>
								<tr>
									<td> 17</td>
									<td>Abteilung_1</td>
									<td>
										Mechanisch
									</td>
									<td>
										intern
									</td>
									<td>Maschine_45</td>
									<td>Pumpe def.</td>

									<td>in Arbeit</td>
									<td>
										<input type="button" value="Ansehen" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
										<input type="button" value="Abschliessen" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
										<input type="button" value="Weitergabe" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
										<input type="button" value="Löschen" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
										<input type="button" value="Ändern" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
									</td>

									<tr>
										<td>52</td>
										<td>Abteilung_1</td>
										<td>
											Elektrisch
										</td>
										<td>
											intern
										</td>
										<td>Maschine_45</td>
										<td>Kabelbruch</td>
										<td>An Extren</td>

										<td>
											<input type="button" value="Ansehen" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
											<input type="button" value="Abschliessen" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
											<input type="button" value="Weitergabe" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
											<input type="button" value="Löschen" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
											<input type="button" value="Ändern" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
										</td>
									</tr>

							</tbody>
						</table>

						<br>
						<div>
							<input type="button" value="Aktualisieren" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">

						</div>
					</div>
				</div>

				<div id="menu101" class="container tab-pane fade"><br>
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
									<th>Arbeitsplan</th>
									<th>Status</th>
								</tr>
							</thead>
							<tbody>
								<tr>
									<td> 11</td>
									<td>Abteilung_1</td>
									<td>
										Mechanisch
									</td>
									<td>
										intern
									</td>
									<td>Maschine_45</td>
									<td>Pumpe def.</td>

									<td>in Arbeit</td>
									<td>
										<input type="button" value="Ansehen" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
										<input type="button" value="Löschen" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
										<input type="button" value="Ändern" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
									</td>

									<tr>
										<td> 99</td>
										<td>Abteilung_1</td>
										<td>
											Elektrisch
										</td>
										<td>
											intern
										</td>
										<td>Maschine_45</td>
										<td>Kabelbruch</td>
										<td>An Extren</td>

										<td>
											<input type="button" value="Ansehen" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
											<input type="button" value="Löschen" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
											<input type="button" value="Ändern" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
										</td>
									</tr>

							</tbody>
						</table>
						<div>
							<input type="button" value="Aktualiesieren" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
						</div>
						<br>

					</div>
				</div>

				<div id="menu102" class="container tab-pane fade"><br>
					<form class="form-inline" action="/action_page.php">

						<input type="button" value="Neuen Auftrag erstellen" onclick="loadDoc('lib/php/inst/instCRAuftragAnzeigen.php?q=1111',myFunction1)">

					</form>

				</div>
			</div>
		</div>
	</div>
</div>