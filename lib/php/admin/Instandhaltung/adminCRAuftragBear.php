
<?php
//echo "PHP Datenabfrage<br>";
$q = $_REQUEST[ "q" ];
//echo "Anfrage : " . $q . "<br>";
//$q = 0;
$ch1 = curl_init();


//curl_setopt($ch2, CURLOPT_URL, "http://zoomnation.selfhost.eu:8080/ProManAPI/api/adminPage/?identifier=AdminPageAbteilung");

curl_setopt( $ch1, CURLOPT_URL,"http://zoomnation.selfhost.eu/jsonData/instandhaltung/instandhaltung.json" );
curl_setopt( $ch1, CURLOPT_HEADER, 0 );
curl_setopt( $ch1, CURLOPT_RETURNTRANSFER, true );
$instandhaltung = curl_exec( $ch1 );
curl_close( $ch1 );

// Testausgabe
//echo($instandhaltung);

// Unwandlung von json in Array	
$jsoninstandhaltung = json_decode($instandhaltung, TRUE);
//print_r($fertigungslinien);

//print_r($jsonfertigungslinien);

echo <<<'HOME1_HEADER'

<script>
function createData(q)
{


		var data = JSON.stringify(
		{
	
			"instandhaltungID"			:	1,

			"abteilung"					: 	5,
			
			"fachrichtung"				:	"mechanisch",

			"fachbereich"				:	"intern",	

			"machinenIventarnummer"		:	"94055455",

			"thema"						:	"Pumpen problem",

			"fehlertext"				:	"Die pumpe läuft aus",

			"auftragsstatus"			:	"offen"

);
saveNewReperaturAuftrag(data);

alert("createData saveNewReperaturAuftrag");

};
</script>

<div class="Fertigung">
	<div class="jumbotron">
		<div class="container">
		
HOME1_HEADER;
			
						// TODO: maxiD muss noch bestimmt werden

						echo("<label for='instandhaltungID'>instandhaltungID</label>");
						echo("<input readonly type='text' class='form-control' id='instandhaltungID' aria-describedby='instandhaltungID' placeholder='' value={$q}>");

					
						echo("<label for='abteilunngsname'>abteilunngsname</label>");
						echo("<input type='text' class='form-control' id='abteilunngsname' aria-describedby='abteilunngsname' placeholder='' value=0>");
					
						echo("<label for='fertigungsID'>fertigungsID</label>");
						echo("<input type='text' class='form-control' id='fertigungsID' aria-describedby='fertigungsID' placeholder='' value=0>");
					
						echo("<label for='fertifertigungsname'>fertifertigungsname</label>");
						echo("<input type='text' class='form-control' id='fertifertigungsname' aria-describedby='fertifertigungsname' placeholder='' value=0>");
					
											
						echo("<br>");
						echo("<td><input class='btn btn-primary' type='button' value='Speichern'  onclick='createData({$q});'></td>");


echo <<<'HOME1_FOOTER'
						
					</div>
				</div>
			</div>
HOME1_FOOTER;
						 
?>