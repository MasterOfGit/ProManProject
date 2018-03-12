<?php
//echo "PHP Datenabfrage<br>";
//$q = $_REQUEST["q"];
//echo "Anfrage : "  . $q . "<br>";

$cSession = curl_init(); 
curl_setopt($cSession,CURLOPT_URL,"http://zoomnation.selfhost.eu:8080/ProManAPIDummy/api/adminPage/?identifier=AdminPageBauteil");
curl_setopt($cSession,CURLOPT_RETURNTRANSFER,true);
curl_setopt($cSession,CURLOPT_HEADER, false); 
$result=curl_exec($cSession);

curl_close($cSession);
//step5
//echo $result;

$json = json_decode($result, TRUE);

?>

<div class="Bauteil">
  <div class="jumbotron">
    <div class="container">
      <h2>Bauteil</h2>
      <br>
      <!-- Nav tabs -->
      <ul class="nav nav-tabs" role="tablist">
        <li class="nav-item"> <a class="nav-link active" data-toggle="tab" href="#home40">Bauteie bearbeiten</a>&nbsp;</li>
        <li class="nav-item"> <a class="nav-link" data-toggle="tab" href="#menu40">Bauteilverwendung</a></li>
      </ul>
      
      <!-- Tab panes -->
      <div class="tab-content">
        <div id="home40" class="container tab-pane fade"><br>
          <h3>Login Anfragen</h3>
          <div class="table-responsive-sm">
            <table class="table">
              <thead>
                <tr>
                  <th>Teilenummer</th>
                  <th>Index</th>
                  <th>Bearbeitungsstand</th>
                  <th>Version</th>
                  <th>Status</th>
                  <th></th>
				  </tr>
              </thead>
              <tbody>
				 <tr>
                  <td>123 123 423</td>
                  <td>AB</td>
                  <td>vorgedeht</td>
                  <td>1.1.1</td>
                  <td>serie</td>
					 <td><input type="button" value="Bauteil bearbeiten" onclick="loadDoc('lib/php/admin/Bauteil/adminCRBauteilBear.php?q=1111',myFunction1)"></td>
                </tr>  
				   <tr>
                  <td>123 123 423</td>
                  <td>DD</td>
                  <td>vorgedeht</td>
                  <td>1.2</td>
                  <td>nullserie</td>
					   <td><input type="button" value="Bauteil bearbeiten" onclick="loadDoc('lib/php/admin/Bauteil/adminCRBauteilBear.php?q=1111',myFunction1)"></td>
                </tr> 
				     <tr>
                  <td>123 123 423</td>
                  <td>XX</td>
                  <td>vorgedeht</td>
                  <td>1.0</td>
                  <td>protoyp</td>
						 <td><input type="button" value="Bauteil bearbeiten" onclick="loadDoc('lib/php/admin/Bauteil/adminCRBauteilBear.php?q=1111',myFunction1)"></td>
                </tr> 
				  
				  
              <!--<?php foreach($json['Bauteile'] as $item) : ?>
                <tr>
                  <td>not defined. Gibt es nicht in der Datenbank!</td>
                  <td><?= $item['ID'] ?></td>
                  <td>not defined. Gibt es nicht in der Datenbank!</td>
                  <td><?= $item['Version'] ?></td>
                  <td><?= $item['Teilart'] ?></td>
                  <td><input type="button" value="Bauteildaten bearbeiten" onclick="loadDoc('lib/php/admin/adminContentRequestBauteilBear.php?q=1111',myFunction1)" ></td>
                </tr>
                <?php endforeach ?>-->
              </tbody>
            </table>
            <input type="button" value="Neues Bauteil" onclick="loadDoc('lib/php/admin/Bauteil/adminCRBauteilBear.php?q=1111',myFunction1)">
          </div>
        </div>
		  
        <div id="menu40" class="container tab-pane active"><br>
          <h3>Maschinen</h3>
          <form class="form-inline" action="/action_page.php">
            <input class="form-control mr-sm-2" type="text" placeholder="Search">
            <button class="btn btn-success" type="submit">Search</button>
          </form>
          <div class="table-responsive-sm">
            <table class="table">
              <thead>
                <tr>
                 <th>Fertigungslinie</th>
				 <th>Teilenummer</th>
                  <th>Index</th>
                  <th>MaschinenID</th>
                  <th>Technologie</th>
                  <th>Bearbeitung</th>
					<th>Bear.Schritt</th>
					<th>GType</th>
                </tr>
              </thead>
                   <tbody>
                <tr>
                  <td>Festrad 3</td>
					<td>123 445 777</td>
                  <td>BB</td>
                  <td>112254</td>
                  <td>HardDrehen</td>
                  <td>PlanF 10a</td>
					<td>1</td>
					<td>5.Gang Getrieb 1254as8</td>
                  <td><input type="button" value="Verw. bearbeiten" onclick="loadDoc('lib/php/admin/adminContentRequestBauteilVerwBear.php?q=1111',myFunction1)"></td>
                </tr>
                <tr>
					<td>Festrad 3</td>
                  <td>123 445 777</td>
                  <td>AD</td>
                  <td>125545</td>
                  <td>Verz.Schleifen</td>
                  <td>VZ Aussen</td>
					<td>2</td>
					<td>5.Gang Getrieb 1254as8</td>
                  <td><input type="button" value="Verw. bearbeiten" onclick="loadDoc('lib/php/admin/adminContentRequestBauteilVerwBear.php?q=1111',myFunction1)"></td>
                </tr>
					    <tr>
					<td></td>
                  <td>123 445 777</td>
                  <td>NEU</td>
                  <td></td>
                  <td>Verz.Schleifen</td>
                  <td>VZ Aussen</td>
					<td>2</td>
					<td>5.Gang Getrieb 1254as99</td>
                  <td><input type="button" value="Verw. bearbeiten" onclick="loadDoc('lib/php/admin/adminContentRequestBauteilVerwBear.php?q=1111',myFunction1)"></td>
                </tr>
				
              </tbody>
            </table>
          <input type="button" value="Neue Bauteil Verwendung anlegen" onclick="loadDoc('lib/php/admin/adminContentRequestBauteilVerwBear.php?q=1111',myFunction1)"></td>
			</div>
        </div>
      </div>
    </div>
  </div>
</div>