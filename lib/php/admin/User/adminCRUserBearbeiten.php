<?php
echo "PHP Datenabfrage<br>";
$q = $_REQUEST["q"];
echo "Anfrage : "  . $q . "<br>";

?>

<div class="Registrtierung bearbeiten">
  <div class="jumbotron">
    <h1>User bearbeiten</h1>
    <div class="jumbotron">
      <form>
        <div class="form-group">
          <label for="userID">UserID (falls bekannt)</label>
          <input type="text" class="form-control" id="userID11" aria-describedby="userID" placeholder="UserID">
          <label for="anrede">Anrede</label>
          <select class="form-control" id="anrede1">
            <option>Herr</option>
            <option>Frau</option>
            <option>Dr.</option>
            <option>Prof.</option>
            <option>Prof.Dr.</option>
          </select>
          <label for="position">Position</label>
          <select class="form-control" id="position1">
            <option>Administrator</option>
            <option>Maschinenführer</option>
            <option>Instandhalter</option>
            <option>Gruppensprecher</option>
            <option>Meister</option>
            <option>Sachbearbeiter</option>
          </select>
          <br>
          <img id="bild1" src="http://via.placeholder.com/150x150" width="150" height="150" class="img-rounded img-responsive" alt="Placeholder image">
          <label for="bilddatei1">Bilddatei auswählen</label>
          <input type="file" id="bilddatei1" name="bilddatei" multiple>
          <label for="vorname1">Vorname</label>
          <input type="text" class="form-control" id="vorname1" aria-describedby="userID" placeholder="Vorname">
          <label for="nachname1">Nachname</label>
          <input type="text" class="form-control" id="nachname1" aria-describedby="userID" placeholder="Nachname">
          <label for="werk">Werk</label>
          <input type="text" class="form-control" id="werk1" aria-describedby="Werk" placeholder="Werk">
          <label for="abteilung">Abteilung</label>
          <input type="text" class="form-control" id="Abteilung1" aria-describedby="userID" placeholder="Abteilung">
          <label for="eMail">eMail</label>
          <input type="email" class="form-control" id="email1" aria-describedby="eMail" placeholder="eMail">
          <label for="telfest">Festnetz</label>
          <input type="tel" class="form-control" id="telfest1" aria-describedby="Festnetz" placeholder="Festnetz">
          <label for="mobil1">Mobil</label>
          <input type="tel" class="form-control" id="mobil1" aria-describedby="Mobil" placeholder="Mobil">
          <label for="bemerkung1">Bemerkung</label>
          <input type="text" class="form-control" id="bemerkung1" aria-describedby="Bemerkung" placeholder="Bemerkung">
		  <label for="aktive">Aktiviert</label>
          <input id="aktive" type="checkbox">
		        </div>
        <button type="button" 
					class="btn btn-primary" onclick="loadDoc('lib/php/admin/adminContentRequestRegistierenAntwort.php?q=2222',myFunction1)"> Speichern</button>
		  <button type="button" 
					class="btn btn-danger" onclick="loadDoc('lib/php/admin/adminContentRequestRegistierenAntwort.php?q=2222',myFunction1)"> Löschen</button>
		  <br>
		  <br>
		  <button type="button" 
					class="btn btn-block" onclick="loadDoc('lib/php/admin/adminContentRequestRegistierenAntwort.php?q=2222',myFunction1)"> Änderungsnachicht Senden</button>
        
      </form>
    </div>
  </div>
</div>
