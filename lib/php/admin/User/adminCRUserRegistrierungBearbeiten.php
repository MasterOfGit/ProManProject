<?php
//echo "PHP Datenabfrage<br>";
$q = $_REQUEST["q"];
//echo "Anfrage : "  . $q . "<br>";
//$q= 1253;
$ch1 = curl_init();
$ch2 = curl_init();

//curl_setopt($ch2, CURLOPT_URL, "http://zoomnation.selfhost.eu:8080/ProManAPI/api/adminPage/?identifier=AdminPageAbteilung");

curl_setopt($ch1, CURLOPT_URL, "http://zoomnation.selfhost.eu/jsonData/user/userData.json");

curl_setopt($ch1, CURLOPT_HEADER, 0);
curl_setopt($ch1,CURLOPT_RETURNTRANSFER,true);
$userData=curl_exec($ch1);
curl_close($ch1);

// Testausgabe
//echo($maschinen);



curl_setopt($ch2, CURLOPT_URL, "http://zoomnation.selfhost.eu/jsonData/user/userLogin.json");

curl_setopt($ch2, CURLOPT_HEADER, 0);
curl_setopt($ch2,CURLOPT_RETURNTRANSFER,true);
$userLogin=curl_exec($ch2);
curl_close($ch2);

// Testausgabe
//echo($maschinen);

// Unwandlung von json in Array	
$jsonUserData = json_decode($userData, TRUE);
$jsonuserLogin = json_decode($userLogin, TRUE);


echo <<<HEADER
<div class="Userbearbeiten">
  <div class="jumbotron">
    <h1>User bearbeiten</h1>
    <div class="jumbotron">
      <div class="row">
      <div class="col-md-6 col-md-offset-3">
	  <form>
        <div class="form-group">
        		 
HEADER;
		echo("<label for='userLastLogin'>LastLogin</label>");
		echo("<input type='text' class='form-control' id='userLastLogin' aria-describedby='userLastLogin' placeholder='LastLogin' value=''>");
						
		echo("<label for='userStatus'>Status</label>");
		echo("<input type='text' class='form-control' id='userStatus' aria-describedby='userStatus' placeholder='Status' value=''>");
						
		echo("<label for='userbereich'>Userbereich</label>");
		echo("<input type='text' class='form-control' id='userbereich' aria-describedby='userbereich' placeholder='Userbereich' value=''>");
						
		echo("<label for='userKennung'>Userkennung</label>");
		echo("<input type='text' class='form-control' id='userKennung' aria-describedby='userKennung' placeholder='Userkennung' value=''>");
						
		echo("<label for='userpasswort'>Userpasswort</label>");
		echo("<input type='text' class='form-control' id='userpasswort' aria-describedby='userpasswort' placeholder='Userpasswort' value=''>");

				foreach($jsonUserData['users'] as $userdata)
				{
				
					if($userdata['userID'] == $q )
					{
						$userbild = "http://zoomnation.selfhost.eu" ;
						
						if($userdata['userBild']== null)
						{
							$userbild = "http://zoomnation.selfhost.eu/user/Bilder/standartbild.png";
						}
						
						$userbild .= $userdata['userBild'];
							
						
						echo("<label for='userID'>UserID</label>");
						echo("<input type='text' class='form-control' id='anrede' aria-describedby='userID' placeholder='UserID' value={$userdata['userID']}>");
						
						echo("<label for='anrede'>Anrede</label>");
						echo("<input type='text' class='form-control' id='anrede' aria-describedby='userID' placeholder='Anrede' value={$userdata['userAnrede']}>");
						
						echo("<label for='vorname'>Vorname</label>");
						echo("<input type='text' class='form-control' id='vorname' aria-describedby='userID' placeholder='Vorname' value={$userdata['userVorname']}>");
						
						echo("<label for='nachname'>Nachname</label>");
						echo("<input type='text' class='form-control' id='nachname' aria-describedby='userID' placeholder='Vorname' value={$userdata['userNachname']}>");
						
						// userbild
						echo("<label for='userbild'>Userbild</label>");
						echo("<img id='userbild' src=$userbild width='150' height='150' class='img-rounded img-responsive' alt='Placeholder image'>");
						
						echo("<label for='werk'>Wert</label>");
						echo("<input type='text' class='form-control' id='werk' aria-describedby='werk' placeholder='Werk' value={$userdata['userWerk']}>");
						
						echo("<label for='abteilung'>Abteilung</label>");
						echo("<input type='text' class='form-control' id='abteilung' aria-describedby='abteilung' placeholder='Abteilung' value={$userdata['userAbteilung']}>");
						
						echo("<label for='email'>eMail</label>");
						echo("<input type='text' class='form-control' id='email' aria-describedby='email' placeholder='eMail' value={$userdata['userEmail']}>");
						
						echo("<label for='festnetz'>Festnetz</label>");
						echo("<input type='text' class='form-control' id='festnetz' aria-describedby='email' placeholder='Festnetz' value={$userdata['userFestnetzNr']}>");
						
											
						echo("<label for='mobil'>Bemerkung</label>");
						echo("<input type='text' class='form-control' id='bemerkung' aria-describedby='bemerkung' placeholder='none' value={$userdata['userBemerkung']}>");
		       
					}
				};
           
echo <<<FOOTER
		</div>
<button type="button" class="btn btn-primary" onclick="saveNewRegistrierung('data')"> Speichern</button>
<input type="button" value="Zurück" onclick="window.location.href='usercontent.html'" />
	      </form>
    </div>
  </div>
</div>
</div>
</div>

FOOTER;
?>