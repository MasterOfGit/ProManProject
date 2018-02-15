<?php
echo "PHP Datenabfrage<br>";
$q = $_REQUEST["q"];
echo "Anfrage : "  . $q . "<br>";

?>

<div class="fertigung">
	<div class="jumbotron">
		<div class="container-fluid">
			<h2>Abteilungsübersicht</h2>
			<div class="row">
				<div class="col-sm-6">
				  <lable for="a1">Informationen:</lable>
				  <ul id="a1" class="list-group">
					<li class="list-group-item d-flex justify-content-between align-items-center"> Name <span class="badge badge-primary badge-pill"><a href="../inArbeit.html" style="color:white">1</a></span> </li>
					<li class="list-group-item d-flex justify-content-between align-items-center"> Abteilung <span class="badge badge-primary badge-pill">Halle 12 Werk Kassel</span></span> </li>
					<li class="list-group-item d-flex justify-content-between align-items-center"> Ansprechpartner<span class="badge badge-primary badge-pill">Hans Peter (0123/456798)</span> </li>
				  </ul>
				</div>
				<div class="col-sm-6">
				  <lable for="a1">Status:</lable>
				  <ul id="a1" class="list-group">
					<li class="list-group-item d-flex justify-content-between align-items-center"> Zugeordnete Fertigung <span class="badge badge-primary badge-pill"><a href="../inArbeit.html" style="color:white">5</a></span> </li>
					<li class="list-group-item d-flex justify-content-between align-items-center"> Reparaturen Insgesamt <span class="badge badge-primary badge-pill">5</span>  </li>
					<li class="list-group-item d-flex justify-content-between align-items-center"> Wartungen Insgesamt<span class="badge badge-primary badge-pill">2</span> </li>
				  </ul>
				</div>
			</div>
			<div class="row">
				<div class="col-sm-6">
					<details>
						<summary>Zugeordnete Fertigungen &darr;</summary>
						<div class="table-responsive-sm">
						<table class="table">
						  <thead>
							<tr>
							  <th>#</th>
							  <th>Bezeichnung</th>
							  <th>Status</th>
							</tr>
						  </thead>
						  <tbody>
							<tr>
							  <td>1</td>
							  <td><a href="../inArbeit.html" style="color:blue">Linie_1</a></td>
							  <td>ok</td>
							</tr>
							<tr>
							  <td>2</td>
							  <td><a href="../inArbeit.html" style="color:blue">Linie_2</a></td>
							  <td>Reparatur</td>
							</tr>
						  </tbody>
						</table>
					  </div>
				  </div>
				</details>
			</div>
		</div>
	</div>
</div>
