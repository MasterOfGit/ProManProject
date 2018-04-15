
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

echo <<<HOME1_HEADER
<script>
function createData(q)
{


		var data = JSON.stringify(
		{
	
			"folgenummer"		:	{$q},

			"bauteilname"		:	$("#bauteilname").val(),

			"bauteilindex"		:	$("#bauteilindex").val(),

			"bauteilverwendung"	:	$("#bauteilverwendung").val(),

			"prodMenge"			:	$("#prodMenge").val(),

			"status"			:	"inArbeit"	
	
			

		}
);
saveProduktionplanSchritt(data);

alert("createData saveProduktionplanSchritt");

};
</script><div class="Produktionplanschritt">
	<div class="jumbotron">
		<div class="container">
		
HOME1_HEADER;
			
						// TODO: maxiD muss noch bestimmt werden

						echo("<label for='folgenummer'>folgenummer</label>");
						echo("<input readonly type='text' class='form-control' id='folgenummer' aria-describedby='userID' placeholder='' value=1>");

					
						echo("<label for='bauteilname'>bauteilname</label>");
						echo("<input type='text' class='form-control' id='bauteilname' aria-describedby='bauteilname' placeholder='' value=0>");
					
						echo("<label for='bauteilindex'>bauteilindex</label>");
						echo("<input type='text' class='form-control' id='bauteilindex' aria-describedby='bauteilindex' placeholder='' value=0>");
					
						echo("<label for='bauteilverwendung'>bauteilverwendung</label>");
						echo("<input type='text' class='form-control' id='bauteilverwendung' aria-describedby='bauteilverwendung' placeholder='' value=0>");
					
						echo("<label for='prodMenge'>prodMenge</label>");
						echo("<input type='text' class='form-control' id='prodMenge' aria-describedby='prodMenge' placeholder='' value=0>");
						
						echo("<label for='maschinenzahl'>maschinenzahl</label>");
						echo("<input readonly type='text' class='form-control' id='maschinenzahl' aria-describedby='maschinenzahl' placeholder='' value='inArbeit'>");
					
						echo("<br>");
						echo("<td><input type='button' value='Speichern'  onclick='createData({$q});'></td>");


echo <<<'HOME1_FOOTER'
						
					</div>
				</div>
			</div>
HOME1_FOOTER;
						 
?>

