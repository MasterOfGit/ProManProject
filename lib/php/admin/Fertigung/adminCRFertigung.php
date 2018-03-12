<?php
//echo "PHP Datenabfrage<br>";
//$q = $_REQUEST[ "q" ];
//echo "Anfrage : " . $q . "<br>";

?>

<div class="Fertigung">
	<div class="jumbotron">
		<div class="container">
			<h2>Fertigung</h2>
			<br>
			<!-- Nav tabs -->
			<ul class="nav nav-tabs" role="tablist">
				<li class="nav-item"> <a class="nav-link active" data-toggle="tab" href="#home1">Fertigung</a>&nbsp;</li>
				
				<li class="nav-item"> <a class="nav-link" data-toggle="tab" href="#menu1">Fertigungsgrafik</a>
				</li>
			</ul>

			<!-- Tab panes -->
			<div class="tab-content">

				<div id="home1" class="container tab-pane fade"><br>
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
									<td>Härterei
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
									<td>Hardfertigung
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
									<td>Qualitätssicherung
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
						<br>
						
					  <div>
							<input type="button" value="Neu Fertigung anlegen" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
						  <input type="button" value="Diese Fertigung löschen" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
						</div>
					</div>
				</div>

				

				<div id="menu1" class="container tab-pane fade"><br>
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