<!--
Ersteller : Markus Kessler	
MatrNr 	  : 894361
Presentation: 28.04.2018
Theam : ProMan
-->
<?php
//echo "PHP Datenabfrage<br>";
$q = $_REQUEST[ "q" ];
//echo "Anfrage : " . $q . "<br>";

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
saveAbteilung(data, q);

alert("createData saveAbteilung");

};
</script>
<div class="Fetigung">
	<div class="jumbotron">
		<div class="container">
		
HOME1_HEADER;
			
						// TODO: maxiD muss noch bestimmt werden

						echo("<label for='instandhaltungID'>instandhaltungID</label>");
						echo("<input readonly type='text' class='form-control' id='instandhaltungID' aria-describedby='instandhaltungID' placeholder='' value={$q}>");

					
						echo("<label for='abteilung'>abteilung</label>");
						echo("<input type='text' class='form-control' id='abteilung' aria-describedby='abteilung' placeholder='' value=0>");
					
						echo("<label for='fachrichtung'>fachrichtung</label>");
						echo("<input type='text' class='form-control' id='fachrichtung' aria-describedby='fachrichtung' placeholder='' value=0>");
					
						echo("<label for='fachbereich'>fachbereich</label>");
						echo("<input type='text' class='form-control' id='fachbereich' aria-describedby='fachbereich' placeholder='' value=0>");

						echo("<label for='machinenIventarnummer'>machinenIventarnummer</label>");
						echo("<input type='text' class='form-control' id='machinenIventarnummer' aria-describedby='machinenIventarnummer' placeholder='' value=0>");
						
						echo("<label for='thema'>thema</label>");
						echo("<input type='text' class='form-control' id='thema' aria-describedby='thema' placeholder='' value=0>");


						echo("<label for='fehlertext'>fehlertext</label>");
						echo("<input type='text' class='form-control' id='fehlertext' aria-describedby='fehlertext' placeholder='' value=0>");

						echo("<label for='auftragsstatus'>auftragsstatus</label>");
						echo("<input type='text' class='form-control' id='auftragsstatus' aria-describedby='auftragsstatus' placeholder='' value=0>");
					
											
						echo("<br>");
						echo("<td><input type='button' value='Speichern'  onclick='createData({$q});'></td>");


echo <<<'HOME1_FOOTER'
						
					</div>
				</div>
			</div>
HOME1_FOOTER;
						 
?>