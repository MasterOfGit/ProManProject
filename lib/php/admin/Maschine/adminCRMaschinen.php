<?php
//echo "PHP Datenabfrage<br>";
//$q = $_REQUEST["q"];
//echo "Anfrage : "  . $q . "<br>";

//post request
if($_SERVER['REQUEST_METHOD'] == "POST" and isset($_POST['savedb']) and isset($_POST['inventarID']))
{
      SendFunction();
}
function SendFunction()
  {
      $data = array("Inventarnummer"=>$_POST['inventarID'],"Technologie"=>$_POST['technologie'],"Hersteller"=>$_POST['hersteller'],"Status"=>$_POST['bearbeitungsstand'],"Version"=>$_POST['maschienVersion'],"Zeichnungsnummer"=>$_POST['maschineZeichnungsnummer'],"Standort"=>$_POST['standort'],"Anschaffungsdatum"=>$_POST['anschaffungsdatum'],"Garantie"=>$_POST['garantieBis']);                                                                    
      $data_string = json_encode($data);                                                                                   
                                                               
      $ch = curl_init();  
      curl_setopt($ch,CURLOPT_URL,"http://zoomnation.selfhost.eu:8080/ProManAPI/api/maschine");                                                                    
      curl_setopt($ch, CURLOPT_CUSTOMREQUEST, "POST");                                                                     
      curl_setopt($ch, CURLOPT_POSTFIELDS, $data_string);                                                                  
      curl_setopt($ch, CURLOPT_RETURNTRANSFER, true);                                                                      
      curl_setopt($ch, CURLOPT_HTTPHEADER, array(                                                                          
          'Content-Type: application/json',                                                                                
          'Content-Length: ' . strlen($data_string))                                                                       
      );  
      curl_exec($ch);
  }


//get request

$cSession = curl_init(); 
curl_setopt($cSession,CURLOPT_URL,"http://zoomnation.selfhost.eu:8080/ProManAPI/api/adminPage/?identifier=AdminPageMaschine");
curl_setopt($cSession,CURLOPT_RETURNTRANSFER,true);
curl_setopt($cSession,CURLOPT_HEADER, false); 
$result=curl_exec($cSession);

curl_close($cSession);

$json = json_decode($result, TRUE);


echo <<<'HOME1_HEADER'

<div class="Maschinen">
  <div class="jumbotron">
    <div class="container">
      <h2>Maschine</h2>
      <br>
      <!-- Nav tabs -->
      <ul class="nav nav-tabs" role="tablist">
        <li class="nav-item"> <a class="nav-link active" data-toggle="tab" href="#home1">Maschine bearbeiten</a>&nbsp;</li>
        <li class="nav-item"> <a class="nav-link" data-toggle="tab" href="#menu1">Maschinenverwendung</a></li>
      </ul>
      
      <!-- Tab panes -->
      <div class="tab-content">
        <div id="home1" class="container tab-pane fade"><br>
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
				  <th></th>
                </tr>
              </thead>
              <tbody>
			  
			  	<tr>
                  <td>Maschine_1</td>
                  <td>Scherre</td>
                  <td>Drehen</td>
                  <td>Werk 1 Halle 5 Feld D6</td>
                  <td>Prouktiv</td>
				  <td><input type="button" value="Maschine bearbeiten"  onclick="loadDoc('lib/php/admin/Maschine/adminCRMaschineBear.php?q=1111',myFunction1)"></td>
                </tr>
				
				<tr>
                  <td>Maschin_11232</td>
                  <td>Weisser</td>
                  <td>Schleifen</td>
                  <td>Werk 16 Halle 1 Feld A7</td>
                  <td>ImAufbau</td>
				  <td><input type="button" value="Maschine bearbeiten"  onclick="loadDoc('lib/php/admin/Maschine/adminCRMaschineBear.php?q=1111',myFunction1)"></td>
                </tr> 
				<tr>
                  <td>Maschin_888</td>
                  <td>Weisser</td>
                  <td>Schleifen</td>
                  <td>Werk 16 Halle 3 Feld E1</td>
                  <td>Umbau</td>
				  <td><input type="button" value="Maschine bearbeiten"  onclick="loadDoc('lib/php/admin/Maschine/adminCRMaschineBear.php?q=1111',myFunction1)"></td>
                </tr> 
			  
HOME1_HEADER;
   /*           foreach($json['Maschinen'] as $item)
				{
				 
				echo("<tr>");
				echo("<td>{$item['Zeichnungsnummer']}</td>");
				echo("<td>{$item['Hersteller']}</td>");
	  			echo("<td>{$item['Technologie']}</td>");
				echo("<td>{$item['Standort'] }</td>");
				echo("<td>{$item['Status']}</td>");
	  			echo("<td><input type='button' value='Maschdaten bearbeiten' onclick='loadDoc('lib/php/admin/adminContentRequestMaschineBear.php?q=1111,myFunction1)'></td>");
				echo("</tr>");
				};
	*/				

echo <<<'HOME1_FOOTER'
			</tbody>

			</table>
            <br>
			  <input type="button" value="Neue Maschine"  onclick="loadDoc('lib/php/admin/Maschine/adminCRMaschineBear.php?q=1111',myFunction1)">
          </div>
        </div>
HOME1_FOOTER;

echo <<<'MENU1_FOOTER'

        <div id="menu1" class="container tab-pane active"><br>
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
				  <th>Teilename</th>	
                  <th>Arbeitsfolge</th>
                </tr>
              </thead>
              <tbody>
                <tr>
                  <td>Maschine_10</td>
                  <td>Scherer</td>
                  <td>Fräsen</td>
                  <td>Werk 12 Halle 10 Feld C3 HG</td>
                  <td>Produktiv</td>
                  <td>Abteilung_1</td>
                  <td>Grünfertigung</td>
                  <td>Fertigungslinie_7</td>
				  <td>Festrad_5</td>	
                  <td>5</td>
                  <td><input type="button" value="Verw. Bearbeiten"  onclick="loadDoc('lib/php/admin/Maschine/adminCRMaschineVerwBear.php?q=1111',myFunction1)"></td>
                </tr>
                <tr>
                  <td>Maschine_300</td>
                  <td>Weisser</td>
                  <td>Schleifen</td>
                  <td>Werk 12 Halle 1 Feld A5 EG</td>
                  <td>Umbau</td>
                  <td> Abteilung_7</td>
                  <td>Hardfertigung</td>
                  <td>Fertigungslinie_4</td>
					<td>Festrad_7</td>
					
                  <td>4</td>
                  <td><input type="button" value="Verw. Bearbeiten" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)"></td>
					
                </tr>
				  
				   <tr>
                  <td>Maschine_1000</td>
                  <td>Weisser</td>
                  <td>Schleifen</td>
                  <td></td>
                  <td>Neu</td>
                  <td></td>
                  <td>Hardfertigung</td>
				  <td></td>	   
                  <td>Festrad_4</td>
                  <td> </td>
                  <td><input type="button" value="Verw. Bearbeiten" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)"></td>
                </tr>
              </tbody>
            </table>
			<input type="button" value="Neue Maschinen Verwendung anlegen" onclick="loadDoc('lib/php/admin/adminContentRequestMaschineVerwBear.php?q=1111',myFunction1)">
          </div>
        </div>
      </div>
    </div>
  </div>
</div>
MENU1_FOOTER;

?>