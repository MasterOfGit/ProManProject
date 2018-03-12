<?php
//echo "PHP Datenabfrage<br>";
//$q = $_REQUEST["q"];
//echo "Anfrage : "  . $q . "<br>";

?>

<div class="Abteilung">
	<div class="jumbotron">
		<div class="container">
			<h2>Abteilung</h2>
			<br>
			<!-- Nav tabs -->
			<ul class="nav nav-tabs" role="tablist">
				<li class="nav-item"> <a class="nav-link active" data-toggle="tab" href="#home100">Abteilung</a>&nbsp;</li>

				<li class="nav-item"> <a class="nav-link" data-toggle="tab" href="#menu101">Abteilungsgrafik</a>
				</li>
			</ul>

			<!-- Tab panes -->
			<div class="tab-content">

				<div id="home100" class="container tab-pane fade"><br>
					<form class="form-inline" action="/action_page.php">
						<label for="Abteilung">Abteilung</label>
						<select id="AbteilungAbteilung">
							<option>Abteilung_1</option>
							<option>Abteilung_2</option>
							<option>Abteilung_3</option>
						</select>
					</form>
					<div class="table-responsive-sm">
						<table class="table">
							<thead>
								<tr>
									<th>Fertigung</th>
									<th>Fertigungslinienabzahl</th>

								</tr>
							</thead>
							<tbody>
								<tr>
									<td>
										<select>
											<option selected>Fertigung_1</option>
											<option>Fertigung_2</option>
											<option>Fertigung_3</option>
											<option>Fertigung_4</option>
											<option>Fertigung_5</option>
										</select>
									</td>
									</td>
									<td>5</td>
									<td><input type="button" value="Löschen" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">

									</td>
								</tr>
								<tr>
									<td>
										<select>
											<option>Fertigung_1</option>
											<option>Fertigung_2</option>
											<option selected>Fertigung_3</option>
											<option>Fertigung_4</option>
											<option>Fertigung_5</option>
										</select>
									</td>
									</td>
									<td>5</td>
									<td>
										<input type="button" value="Löschen" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
									</td>

								</tr>


							</tbody>
						</table>
						<br>
						<div>
							<input type="button" value="Neu Fertigung hinzufügen" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
						</div>
						<div>
							<input type="button" value="Alles Speicher" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
							<input type="button" value="Reset" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
						</div>
						<br>
						<div>
							<input type="button" value="Neu Abteilung anlegen" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
							<input type="button" value="Abteilung löschen" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
						</div>
						<br>

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
					</form>
					<div class="table-responsive-sm">
						<table class="table">
							<thead>
								<tr>
									<th>Abteilung</th>
									<th>Fertigung</th>
									<th>Fertigungsliniezahl</th>
									<th>Gesamtmaschinenzahl</th>
								</tr>

							</thead>
							<tbody>
								<tr>
									<td>Abteilung_1</td>
									<td>Fertigung_1</td>
									<td>5</td>
									<td>50</td>

									<td><input type="button" value="Bearbeiten" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
										<input type="button" value="Löschen" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
									</td>
								</tr>

								<tr>
									<td>Abteilung_1</td>
									<td>Fertigung_3</td>
									<td>2</td>
									<td>20</td>

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