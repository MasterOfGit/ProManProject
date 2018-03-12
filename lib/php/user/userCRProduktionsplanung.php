<?php
//echo "PHP Datenabfrage<br>";
//$q = $_REQUEST["q"];
//echo "Abfragenummer : "  . $q . "<br>";
//echo "phpDateiName : "  . __FILE__ . "<br>";

echo <<<DATA

<div class="produktionsprogramm">
  <div class="jumbotron">
    <div class="container">
      <h2>Produktionsplanung </h2>
      <br>
      <!-- Nav tabs -->
      <ul class="nav nav-tabs" role="tablist">
        <li class="nav-item"> <a class="nav-link active" data-toggle="tab" href="#home800">Produktionsprogramm</a>&nbsp;</li>
        <li class="nav-item"> <a class="nav-link" data-toggle="tab" href="#menue801">Lagerbestand</a></li>
		 
      </ul>
      
      <!-- Tab panes -->
      <div class="tab-content">
		  
		  
        <div id="home800" class="container tab-pane fade"><br>
          <form class="form-inline" action="/action_page.php">
                     
           
            <label for="teilenummer">Teilenummer</label>
            <select id="teilenummer">
              <option>alles</option>
              <option>Festrad_1</option>
              <option>Festrad_2</option>
              <option>Festrad_3</option>
              <option>Schaldrad_1</option>
              <option>Schaldrad_2</option>
              <option>Schaldrad_3</option>
				
            </select>
          </form>
          <div class="table-responsive-sm">
            <table class="table">
              <thead>
                <tr>
                  <th>Folgenummer</th>
                  <th>Teilenummer</th>
                  <th>Verwendung</th>
				  <th>Sollmenge</th>
				  <th>Status</th>
				  </tr>
              </thead>
              <tbody>
			    <tr>
					  <td>1</td>
					  <td>Festrad_1</td>
					  <td>Getriebe 15ab7</td>
					  <td>600</td>
					  <td>inArbeit</td>
					
					  <td>
						  <input type="button" value="Verschieben" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
						  <input type="button" value="Einfügen" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
						  <input type="button" value="Löschen" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
					  </td>
                </tr>
                <tr>
					  <td>2</td>
					  <td>Festrad_2</td>
					  <td>Getriebe 15cc7</td>
					  <td>200</td>
					<td>offen</td>
					  <td>
						  <input type="button" value="Verschieben" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
						  <input type="button" value="Einfügen" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
						  <input type="button" value="Löschen" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
					  </td>
                </tr>
                <tr>
					  <td>3</td>
					  <td>Schaldrad_1 </td>
					  <td>Getriebe 15bb7</td>
					  <td>600</td>
					<td>offen</td>
					  <td>
						  <input type="button" value="Verschieben" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
						  <input type="button" value="Einfügen" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
						  <input type="button" value="Löschen" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
					  </td>
                </tr>
                <tr>
					  <td>4</td>
					  <td>Festrad_1</td>
					  <td>Getriebe 15ab7</td>
					  <td>400</td>
					  <td>erledigt (Fremdzukauf)</td>
					  <td>
						  <input type="button" value="Verschieben" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
						  <input type="button" value="Einfügen" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
						  <input type="button" value="Löschen" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
					  </td>
                </tr>
                
                  
               
              </tbody>
            </table>
            <div>
              <input type="button" value="Neu Produktionsmenge hinzufügen" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
            </div>
            <br>
            <div>
              <input type="button" value="Alles Speicher" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
            </div>
          </div>
        </div>
		 
        <div id="menue801" class="container tab-pane fade"><br>
          <form class="form-inline" action="/action_page.php">
                     
           
            <label for="teilenummer">Teilenummer</label>
            <select id="teilenummer">
              <option>alles</option>
              <option>Festrad_1</option>
              <option>Festrad_2</option>
              <option>Festrad_3</option>
              <option>Schaldrad_1</option>
              <option>Schaldrad_2</option>
              <option>Schaldrad_3</option>
				
            </select>
          </form>
          <div class="table-responsive-sm">
            <table class="table">
              <thead>
                <tr>
                  <th>Teilenummer</th>
                  <th>Verwendung</th>
                  <th>MinMenge</th>
                  <th>Sollmenge</th>
                </tr>
              </thead>
              <tbody>
			    <tr>
					  <td>Festrad_1</td>
					  <td>Getriebe 15ab7</td>
					  <td>500</td>
					  <td>200</td>
					  
					<td>
						  <input type="button" value="Ändern" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
						  <input type="button" value="Löschen" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
					  </td>
                </tr>
				<tr>
					  <td>Festrad_2</td>
					  <td>Getriebe 15ab7</td>
					  <td>400</td>
					  <td>600</td>
					  
					<td>
						  <input type="button" value="Ändern" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
						  <input type="button" value="Löschen" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
					  </td>
                </tr>
				<tr>
					  <td>Festrad_5</td>
					  <td>Getriebe 15cc7</td>
					  <td>0</td>
					  <td>0</td>
					  
					<td>
						  <input type="button" value="Ändern" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
						  <input type="button" value="Löschen" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
					  </td>
                </tr>
				<tr>
					  <td>Schaldrad_1</td>
					  <td>Getriebe 881ab7</td>
					  <td>800</td>
					  <td>200</td>
					  
					<td>
						  <input type="button" value="Ändern" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
						  <input type="button" value="Löschen" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
					  </td>
                </tr>  
				
                
                
                  
               
              </tbody>
            </table>
            <div>
              <input type="button" value="Neu Lagerort hinzufügen" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
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