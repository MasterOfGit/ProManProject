<?php
echo "PHP Datenabfrage<br>";
$q = $_REQUEST["q"];
echo "Anfrage : "  . $q . "<br>";

?>

<div class="Bauteil bearbeiten">
  <div class="jumbotron">
    <h1>Bauteil bearbeiten</h1>
    <div class="jumbotron">
      <form>
        <div class="form-group">
          <label for="bauteilID">Bauteinummer</label>
          <input type="text" class="form-control" id="bauteilID" aria-describedby="userID" placeholder="UserID">
          <label for="bauteilart">Bauteiltype</label>
          <select class="form-control" id="bauteilart">
            <option>Schaltrad</option>
            <option>Festrad</option>
            <option>Antriebswellen</option>
            <option>Abtriebswell</option>
            <option>Tellerrad</option>
          </select>
          <label for="bauteilIndex">Index</label>
          <input type="text" class="form-control" id="bauteilIndex" aria-describedby="userID" placeholder="UserID">
          <label for="bearbeitungsstand">Bearbeitungsstand</label>
          <select class="form-control" id="bearbeitungsstand">
            <option>Rohtzeil</option>
            <option>Angedreht</option>
            <option>Nacharbeit</option>
            <option>Fertigteil</option>
            <option>Änderung</option>
            <option>Ersatz</option>
            <option>NullSerie</option>
            <option>Sonstige</option>
            <option>Schrott</option>
          </select>
          <label for="bauteilVersion">Version</label>
          <input type="text" class="form-control" id="bauteilVersion" aria-describedby="userID" placeholder="UserID">
          <label for="bauteilZeichnungsnummer">Zeichnungsnummer</label>
          <input type="text" class="form-control" id="bauteilZeichnungsnummer" aria-describedby="userID" placeholder="UserID">
          <label for="Verwendungsort">Verwendungsort</label>
          <input type="text" class="form-control" id="verwendungsort" aria-describedby="userID" placeholder="UserID">
          <label for="bauteilbild">Bauteilbild</label>
          <img id="bauteilbild" src="http://via.placeholder.com/150x150" width="150" height="150" class="img-rounded img-responsive" alt="Placeholder image"> <br>
          <label for="bilddatei1">Bilddatei auswählen</label>
          <input type="file" id="bilddatei1" name="bilddatei" multiple>
        </div>
        <button type="button" 
					class="btn btn-primary" onclick="loadDoc('lib/php/admin/adminContentRequestRegistierenAntwort.php?q=2222',myFunction1)"> Speichern</button>
        <button type="button" 
					class="btn btn-danger" onclick="loadDoc('lib/php/admin/adminContentRequestRegistierenAntwort.php?q=2222',myFunction1)"> Löschen</button>
        <button type="button" 
					class="btn btn-danger" onclick="loadDoc('lib/php/admin/adminContentRequestRegistierenAntwort.php?q=2222',myFunction1)"> Ersetzen</button>
      </form>
    </div>
  </div>
</div>