<?php
//echo "PHP Datenabfrage<br>";
//$q = $_REQUEST["q"];
//echo "Abfragenummer : "  . $q . "<br>";
//echo "phpDateiName : "  . __FILE__ . "<br>";

echo <<<DATA

<div class="Sonderaufgaben">
  <div class="jumbotron">
    <div class="container">
      <h2>Sonderaufgaben </h2>
      <br>
      <!-- Nav tabs -->
      <ul class="nav nav-tabs" role="tablist">
        <li class="nav-item"> <a class="nav-link active" data-toggle="tab" href="#home900">Wartungen</a>&nbsp;</li>
        <li class="nav-item"> <a class="nav-link" data-toggle="tab" href="#menue901">Audit</a></li>
      </ul>
      
      <!-- Tab panes -->
      <div class="tab-content">
        <div id="home900" class="container tab-pane fade"><br>
          <form class="form-inline" action="/action_page.php">
            <label for="teilenummer">Abteilung</label>
            <select id="teilenummer">
              <option>alles</option>
              
            </select>
			 <label for="teilenummer">Fertigung</label>
            <select id="teilenummer">
              <option>alles</option>
             
            </select>
			   <label for="teilenummer">Fertigungslinie</label>
            <select id="teilenummer">
              <option>alles</option>
              
            </select>
			     <label for="teilenummer">Maschine</label>
            <select id="teilenummer">
              <option>alles</option>
              
            </select>
          </form>
          <div class="table-responsive-sm">
            <table class="table">
              <thead>
                <tr>
                  <th>Abteilung</th>
                  <th>Fertigung</th>
                  <th>Fertigungslinie</th>
                  <th>Maschine</th>
                  <th>Aufgabeart</th>
                  <th>Terminturnus</th>
                  <th>Status</th>
                  <th>Status</th>
                </tr>
              </thead>
              <tbody>
                <tr>
                  <td>Abteilung_1</td>
                  <td>Grünfertigung</td>
                  <td>Fertigungslinie_5</td>
                  <td>Maschine_8</td>
                  <td>Reinigung</td>
                  <td>wöchentlich</td>
                  <td>offen</td>
                  <td><input type="button" value="Status ändern" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
                    <input type="button" value="Löschen" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
                    <input type="button" value="Verschieben" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)"></td>
                </tr>
                <tr>
                  <td>Abteilung_1</td>
                  <td>Grünfertigung</td>
					<td>Fertigungslinie_6</td>
                  <td>Maschine_8</td>
                  <td>Reinigung</td>
                  <td>wöchentlich</td>
                  <td>offen</td>
                  <td><input type="button" value="Status ändern" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
                    <input type="button" value="Löschen" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
                    <input type="button" value="Verschieben" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)"></td>
                </tr>
                <tr>
                  <td>Abteilung_1</td>
                  <td>Grünfertigung</td>
                  <td>Fertigungslinie_4</td>
                  <td>Maschine_1</td>
					<td>Filter wechseln</td>
					<td>monatlich</td>
                  <td>erledigt</td>
                  <td><input type="button" value="Status ändern" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
                    <input type="button" value="Löschen" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
                    <input type="button" value="Verschieben" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)"></td>
                </tr>
                <tr>
                  <td>Abteilung_1</td>
                  <td>Grünfertigung</td>
                  <td>Fertigungslinie_5</td>
                  <td>Maschine_8</td>
                  <td>Reinigung</td>
                  <td>wöchentlich</td>
                  <td>verschoben</td>
                  <td><input type="button" value="Status ändern" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
                    <input type="button" value="Löschen" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
                    <input type="button" value="Verschieben" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)"></td>
                </tr>
              </tbody>
            </table>
            <div>
              <input type="button" value="Neu Wartung hinzufügen" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
            </div>
            <br>
            <div>
              <input type="button" value="Alles Speicher" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
            </div>
          </div>
        </div>
		<div id="menue901" class="container tab-pane fade"><br>
          <form class="form-inline" action="/action_page.php">
            <label for="teilenummer">Abteilung</label>
            <select id="teilenummer">
              <option>alles</option>
              
            </select>
			
          </form>
          <div class="table-responsive-sm">
            <table class="table">
              <thead>
                <tr>
                  <th>Abteilung</th>
                  <th>Auditart</th>
                  <th>Termin</th>
                  <th>Status</th>
                  <th>Nacharbeit</th>
                  <th>Terminturnus</th>
                  <th>Note</th>
                 
                </tr>
              </thead>
              <tbody>
                <tr>
                  <td>Abteilung_1</td>
                  <td>SOS</td>
                  <td>01.03.2018</td>
                  <td>offen</td>
                  <td>keine</td>
                  <td>jährlich</td>
                  <td>keine</td>
                  <td>
					  <input type="button" value="bearbeiten" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
                      <input type="button" value="Verschieben" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)"></td>
                </tr>
                <tr>
                  <td>Abteilung_2</td>
                  <td>SOS</td>
                  <td>01.01.2018</td>
                  <td>erledigt</td>
                  <td>ja</td>
                  <td>jährlich</td>
                  <td>90%(B)</td>
                  <td>
					  <input type="button" value="bearbeiten" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
                      <input type="button" value="Verschieben" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)"></td>
                </tr>
                 <tr>
                  <td>Abteilung_3</td>
                  <td>Arbeitssicherheit</td>
                  <td>01.01.2018</td>
                  <td>erledigt</td>
                  <td>ja</td>
                  <td>jährlich</td>
                  <td>60%(NB)</td>
                  <td>
					  <input type="button" value="bearbeiten" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
                      <input type="button" value="Verschieben" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)"></td>
                </tr>
              </tbody>
            </table>
            <div>
              <input type="button" value="Neu Audit hinzufügen" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
            </div>
            <br>
            <div>
              <input type="button" value="Alles Speicher" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
            </div>
          </div>
        </div>  
        
      </div>
    </div>
  </div>
</div>

DATA;

?>