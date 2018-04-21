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

curl_setopt( $ch1, CURLOPT_URL,"http://zoomnation.selfhost.eu/jsonData/fertigungslinien/fertigungslinien.json" );
curl_setopt( $ch1, CURLOPT_HEADER, 0 );
curl_setopt( $ch1, CURLOPT_RETURNTRANSFER, true );
$fertigungslinien = curl_exec( $ch1 );
curl_close( $ch1 );

// Testausgabe
//echo($maschinen);

// Unwandlung von json in Array	
$jsonfertigungslinien = json_decode($fertigungslinien, TRUE);
//print_r($fertigungslinien);

//print_r($jsonfertigungslinien);

echo <<<'HOME1_HEADER'

<script>
function createData(q)
{


		var data = JSON.stringify(
		{
	
			"arbeitsfolgeID"			:	$("#arbeitsfolgeID").val(),

			"maschineID"				:	$("#maschineID").val(),

			"bauteilID"					:	$("#bauteilID").val(),

			"arbeitplan"	 			:	$("#arbeitplan").val()

		}
);
SaveNewArbeitsfolgeInFertigunglinie(data, q);

alert("createData SaveNewArbeitsfolgeInFertigunglinie");

};
</script>
<div class="Fetigungslinie">
	<div class="jumbotron">
		<div class="container">
		
HOME1_HEADER;
			
						echo("<label for='arbeitsfolgeID'>arbeitsfolgeID</label>");
						echo("<input readonly type='text' class='form-control' id='arbeitsfolgeID' aria-describedby='userID' placeholder='' value=0>");
					
						echo("<label for='maschineID'>maschineID</label>");
						echo("<input type='text' class='form-control' id='maschineID' aria-describedby='maschineID' placeholder='' value=0>");
										
						echo("<label for='bauteilID'>bauteilID</label>");
						echo("<input type='text' class='form-control' id='bauteilID' aria-describedby='userID' placeholder='' value=0>");
						
						echo("<label for='arbeitplan'>arbeitplan</label>");
						echo("<input type='text' class='form-control' id='arbeitplan' aria-describedby='arbeitplan' placeholder='' value=0>");
					
						echo("<br>");
						echo("<td><input class='btn btn-primary' type='button' value='Speichern'  onclick='createData({$q});'></td>");


echo <<<'HOME1_FOOTER'
						
					</div>
				</div>
			</div>
HOME1_FOOTER;
						 
?>

