<?php
echo "PHP Datenabfrage<br>";
$q = $_REQUEST["q"];
echo "Anfrage : "  . $q . "<br>";

?>

<div class="Maschine bearbeiten">
  <div class="jumbotron">
    <h1>Maschine bearbeiten</h1>
    <div class="jumbotron">
      <form action="lib\php\admin\Maschine\adminCRMaschinen.php" method="post">
        <div class="form-group">
          <label for="inventarID">Inventarnummer</label>
          <input type="text" class="form-control" name="inventarID" id="inventarID" aria-describedby="userID" placeholder="Inventarnummer">
          <label for="technologie">Technologie</label>
          <select class="form-control" name="technologie" id="technologie">
            <option>Drehen</option>
            <option>Fräsen</option>
            <option>Rundschleifen</option>
            <option>Verzahnungsschleifen</option>
            <option>Planschleifen</option>
            <option>Räumen</option>
            <option>Schaben</option>
          </select>
          <label for="hersteller">Hersteller</label>
          <input type="text" class="form-control" name="hersteller" id="hersteller" aria-describedby="userID" placeholder="Hersteller">
          <label for="Status">Status</label>
          <select class="form-control" name="bearbeitungsstand" id="bearbeitungsstand">
            <option>Produktion</option>
            <option>Umbau</option>
            <option>Reperatur</option>
            <option>Wartung</option>
            <option>Ersatz</option>
            <option>NullSerie</option>
            <option>Sonstige</option>
            <option>Schrott</option>
            <option>Optimierung</option>
          </select>
          <label for="maschienVersion">Version</label>
          <input type="text" class="form-control" name="maschienVersion" id="maschienVersion" aria-describedby="userID" placeholder="UserID">
          <label for="maschineZeichnungsnummer">Zeichnungsnummer</label>
          <input type="text" class="form-control" name="maschineZeichnungsnummer" id="maschineZeichnungsnummer" aria-describedby="userID" placeholder="UserID">
          <label for="standort">Standort</label>
          <input type="text" class="form-control" name="bearbeitungsstand" id="standort" aria-describedby="userID" placeholder="UserID">
          <label for="anschaffungsdatum">Anschaffungsdatum</label>
          <input type="date" class="form-control" name="anschaffungsdatum" id="anschaffungsdatum" aria-describedby="userID" placeholder="UserID">
          <label for="garantieBis">GarantieBis</label>
          <input type="date" class="form-control" name="garantieBis" id="garantieBis" aria-describedby="userID" placeholder="UserID">
          <label for="maschinenBild">Maschinenbild</label>
          <img id="bauteilbild" src="http://via.placeholder.com/150x150" width="150" height="150" class="img-rounded img-responsive" alt="Placeholder image"> <br>
          <label for="maschinenBild">Bilddatei auswählen</label>
          <input type="file" id="maschinenBild" name="maschinenBild" multiple>
        </div>
        <button type="button" 
					class="btn btn-primary" onclick="loadDoc('lib/php/admin/adminContentRequestRegistierenAntwort.php?q=2222',myFunction1)"> Speichern</button>
        <button type="button" 
					class="btn btn-danger" onclick="loadDoc('lib/php/admin/adminContentRequestRegistierenAntwort.php?q=2222',myFunction1)"> Löschen</button>
        <button type="button" 
					class="btn btn-danger" onclick="loadDoc('lib/php/admin/adminContentRequestRegistierenAntwort.php?q=2222',myFunction1)"> Ersetzen</button>
          <input type="submit" name="savedb" value="GO" />
      </form>
    </div>
  </div>
</div>
