<?php
echo "PHP Datenabfrage<br>";
$q = $_REQUEST[ "q" ];
echo "Anfrage : " . $q . "<br>";

?>

<div class="jumbotron">
	<h1>Registrieren </h1>
	<div class="jumbotron">
		<h1>Bitte geben sie ihre Daten ein !!</h1>
		<form>
			<div class="form-group">

				<label for="userID">UserID (falls bekannt)</label>
				<input type="text" class="form-control" id="userID" aria-describedby="userID" placeholder="UserID">

				<label for="anrede">Anrede</label>
				<select class="form-control" id="anrede">
					<option>Herr</option>
					<option>Frau</option>
					<option>Dr.</option>
					<option>Prof.</option>
					<option>Prof.Dr.</option>
				</select>

				<label for="position">Position</label>
				<select class="form-control" id="position">
					<option>Administrator</option>
					<option>Maschinenführer</option>
					<option>Instandhalter</option>
					<option>Gruppensprecher</option>
					<option>Meister</option>
					<option>Sachbearbeiter</option>
				</select>
				<br>


				<img id="bild" src="http://via.placeholder.com/150x150" width="150" height="150" class="img-rounded img-responsive" alt="Placeholder image">
				<label for="bilddatei">Bilddatei auswählen</label>
				<input type="file" id="bilddatei" name="bilddatei" multiple>

				<label for="vorname">Vorname</label>
				<input type="text" class="form-control" id="vorname" aria-describedby="userID" placeholder="Vorname">
				<label for="nachname">Nachname</label>
				<input type="text" class="form-control" id="nachname" aria-describedby="userID" placeholder="Nachname">

				<label for="werk">Werk</label>
				<input type="text" class="form-control" id="werk" aria-describedby="Werk" placeholder="Werk">

				<label for="abteilung">Abteilung</label>
				<input type="text" class="form-control" id="Abteilung" aria-describedby="userID" placeholder="Abteilung">

				<label for="eMail">eMail</label>
				<input type="email" class="form-control" id="email" aria-describedby="eMail" placeholder="eMail">

				<label for="telfest">Festnetz</label>
				<input type="tel" class="form-control" id="telfest" aria-describedby="Festnetz" placeholder="Festnetz">

				<label for="mobil">Mobil</label>
				<input type="tel" "" class="form-control" id="mobil" aria-describedby="Mobil" placeholder="Mobil">

				<label for="bemerkung">Bemerkung</label>
				<input type="text" class="form-control" id="bemerkung" aria-describedby="Bemerkung" placeholder="Bemerkung">


			</div>

			<button type="button" 
					class="btn btn-primary" onclick="loadDoc('lib/php/admin/adminContentRequestRegistierenAntwort.php?q=2222',myFunction1)">
				Senden</button>
			<button type="reset" class="btn btn-primary">alles löschen</button>

		</form>
	</div>
</div>