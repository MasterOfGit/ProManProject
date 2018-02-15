<?php
echo "PHP Datenabfrage<br>";
$q = $_REQUEST["q"];
echo "Anfrage : "  . $q . "<br>";

?>

<div class="Maschinen">
  <div class="jumbotron">
    <div class="container">
      <h2>Maschine</h2>
      <br>
      <!-- Nav tabs -->
      <ul class="nav nav-tabs" role="tablist">
        <li class="nav-item"> <a class="nav-link active" data-toggle="tab" href="#home40">Maschine suchen</a>&nbsp;</li>
        <li class="nav-item"> <a class="nav-link" data-toggle="tab" href="#menu40">Maschinenverwendung</a></li>
      </ul>
      
      <!-- Tab panes -->
      <div class="tab-content">
        <div id="home40" class="container tab-pane fade"><br>
          <h3>Login Anfragen</h3>
          <div class="table-responsive-sm">
            <table class="table">
              <thead>
                <tr>
                  <th>Inventarnummer</th>
                  <th>Hersteller</th>
                  <th>Technologie</th>
                  <th>Standort</th>
                  <th>Status</th>
                </tr>
              </thead>
              <tbody>
                <tr>
                  <td>19555455</td>
                  <td>Scherer</td>
                  <td>Fräsen</td>
                  <td>Werk 12 Halle 10 Feld C3 HG</td>
                  <td>Produktiv</td>
                  <td><input type="button" value="Maschdaten bearbeiten"
							 onclick="loadDoc('lib/php/admin/adminContentRequestMaschineBear.php?q=1111',myFunction1)"></td>
                </tr>
                <tr>
                  <td>9998855</td>
                  <td>Weisser</td>
                  <td>Schleifen</td>
                  <td>Werk 12 Halle 1 Feld A5 EG</td>
                  <td>Produktiv</td>
                  <td><input type="button" value="Maschdaten bearbeiten"  onclick="loadDoc('lib/php/admin/adminContentRequestMaschineBear.php?q=1111',myFunction1)"></td>
                </tr>
              </tbody>
            </table>
            <tr>
              <td>dvc2222</td>
              <td>Peter</td>
              <td>Müller</td>
              <td>peter.mueller@proman.de</td>
              <td>0561/884455</td>
              <td><input class="form-check-input" type="checkbox" checked value="" id="defaultCheck88" disabled></td>
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
                  <th>Inventarnummer</th>
                  <th>Hersteller</th>
                  <th>Technologie</th>
                  <th>Standort</th>
                  <th>Status</th>
                  <th>Abteilung</th>
                  <th>Fertigung</th>
                  <th>Fertigungslinie</th>
                  <th>Bear.Schritt</th>
                </tr>
              </thead>
              <tbody>
                <tr>
                  <td>19555455</td>
                  <td>Scherer</td>
                  <td>Fräsen</td>
                  <td>Werk 12 Halle 10 Feld C3 HG</td>
                  <td>Produktiv</td>
                  <td>1015-5</td>
                  <td>Grünfertigung</td>
                  <td>Festrad 7</td>
                  <td>5</td>
                  <td><input type="button" value="Verw. Bearbeiten"  onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)"></td>
                </tr>
                <tr>
                  <td>9998855</td>
                  <td>Weisser</td>
                  <td>Schleifen</td>
                  <td>Werk 12 Halle 1 Feld A5 EG</td>
                  <td>Umbau</td>
                  <td>1015-5</td>
                  <td>Hardfertigung</td>
                  <td>Festrad 4</td>
                  <td>4</td>
                  <td><input type="button" value="Verw. earbeiten" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)"></td>
                </tr>
              </tbody>
            </table>
          </div>
        </div>
      </div>
    </div>
  </div>
</div>