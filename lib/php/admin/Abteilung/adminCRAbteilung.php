<?php
//echo "PHP Datenabfrage<br>";
//$q = $_REQUEST["q"];
//echo "Anfrage : "  . $q . "<br>";

//get request

$cSession = curl_init(); 
curl_setopt($cSession,CURLOPT_URL,"http://zoomnation.selfhost.eu:8080/ProManAPI/api/adminPage/?identifier=AdminPageAbteilung");
curl_setopt($cSession,CURLOPT_RETURNTRANSFER,true);
curl_setopt($cSession,CURLOPT_HEADER, false); 
$result=curl_exec($cSession);

curl_close($cSession);

$json = json_decode($result, TRUE);

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
						<?php
						foreach($json['Abteilungsnamen'] as $AbteilungsNameItem)
						{
							echo "<option>$AbteilungsNameItem</option>"
						};
						?>
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
<<<<<<< HEAD
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


=======
							<?php
								foreach($json['Abteilungen'] as $item)
								{
									echo "<tr>"
										echo "<td>"
											echo "<select>"
											echo "<option selected>Fertigung_1</option>"
											foreach($json['Fertigungsnamen'] as $FertigungsnamenItem)
											{
												echo "<option>$FertigungsnamenItem</option>"
											};
											echo "	</select>"
											echo "</td>"
											echo "</td>"
											echo "<td>$item['FertigungslinieCount']</td>"
											echo "<td><input type='button' value='Löschen' onclick='loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)'>"

										echo "</td>"
									echo "</tr>"
								};
							?>															
>>>>>>> origin/master
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
<<<<<<< HEAD
					<form class="form-inline" action="/action_page.php">
						<label for="abteilung">Abteilung</label>
						<select id="abteilung">
							<option>Abteilung_1</option>
							<option>Abteilung_2</option>
							<option>Abteilung_3</option>
=======
				  <form class="form-inline" action="/action_page.php">
				    <label for="abteilung">Abteilung</label>
				    <select id="abteilung">
							<?php
							foreach($json['Abteilungsnamen'] as $AbteilungsNameItem)
							{
								echo "<option>$AbteilungsNameItem</option>"
							};
							?>
>>>>>>> origin/master
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
<<<<<<< HEAD
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


=======
								<?php
								foreach($json['Abteilungen'] as $AbteilungsItem)
								{
									foreach($json[$AbteilungsItem['Abteilungen']] as $FertigungsItem)
									{
									echo "<tr>"
									echo "<td>$AbteilungsItem['Fertigungen']</td>"
									echo "<td>$FertigungsItem['Name'] </td>"
									echo "<td>$FertigungsItem['FertigungslinienAnzahl']</td>"
									echo "<td>$FertigungsItem['FertigungslinienAnzahl']</td>"

									echo "<td><input type='button' value='Bearbeiten' onclick='loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)'>"
									echo "<input type='button' value='Löschen' onclick='loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)'>"
									echo "</td>"
									echo "</tr>"
									};
								};
								?>
								
									
>>>>>>> origin/master
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
