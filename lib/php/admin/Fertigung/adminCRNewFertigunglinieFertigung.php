
<?php
//echo "PHP Datenabfrage<br>";
$q = $_REQUEST[ "q" ];
//echo "Anfrage : " . $q . "<br>";

$ch1 = curl_init();


//curl_setopt($ch2, CURLOPT_URL, "http://zoomnation.selfhost.eu:8080/ProManAPI/api/adminPage/?identifier=AdminPageAbteilung");

curl_setopt( $ch1, CURLOPT_URL,"http://zoomnation.selfhost.eu/jsonData/fertigung/fertigung.json" );
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
	
						"fertigungsID"		:	$("#fertigungsID").val(),

		 				"fertigungsname"	:	$("#fertigungsname").val(),

		 				"fertigungslinien"	:

							[

								{

									"fertigungslinienID"	:	$("#fertigungslinienID").val(),

									"fertigungslinienname"	:	$("#fertigungslinienname").val(),		

									"fertigungstyp"			:	$("#fertigungstyp").val(),

									"maschinenzahl"			:	$("#maschinenzahl").val()

								}
							]
		}
);
saveFertigung(data, q);

alert("createData SaveNewArbeitsfolgeInFertigunglinie");

};
</script>
<div class="Fetigungslinie">
	<div class="jumbotron">
		<div class="container">
		
HOME1_HEADER;
			
						// TODO: maxiD muss noch bestimmt werden

						echo("<label for='fertigungsID'>fertigungsID</label>");
						echo("<input readonly type='text' class='form-control' id='fertigungsID' aria-describedby='userID' placeholder='' value=0>");

					
						echo("<label for='fertigungsname'>fertigungsname</label>");
						echo("<input type='text' class='form-control' id='fertigungsname' aria-describedby='fertigungsname' placeholder='' value=0>");
					
						echo("<label for='fertigungslinienID'>fertigungslinienID</label>");
						echo("<input type='text' class='form-control' id='fertigungslinienID' aria-describedby='fertigungslinienID' placeholder='' value=0>");
					
						echo("<label for='fertigungslinienname'>fertigungslinienname</label>");
						echo("<input type='text' class='form-control' id='fertigungslinienname' aria-describedby='fertigungslinienname' placeholder='' value=0>");
					
						echo("<label for='fertigungstyp'>fertigungstyp</label>");
						echo("<input type='text' class='form-control' id='fertigungstyp' aria-describedby='fertigungstyp' placeholder='' value=0>");
						
						echo("<label for='maschinenzahl'>maschinenzahl</label>");
						echo("<input type='text' class='form-control' id='maschinenzahl' aria-describedby='maschinenzahl' placeholder='' value=0>");
					
						echo("<br>");
						echo("<td><input class='btn btn-primary' type='button' value='Speichern'  onclick='createData({$q});'></td>");


echo <<<'HOME1_FOOTER'
						
					</div>
				</div>
			</div>
HOME1_FOOTER;
						 
?>

