
<?php
//echo "PHP Datenabfrage<br>";
$q = $_REQUEST[ "q" ];
//echo "Anfrage : " . $q . "<br>";

$ch1 = curl_init();


//curl_setopt($ch2, CURLOPT_URL, "http://zoomnation.selfhost.eu:8080/ProManAPI/api/adminPage/?identifier=AdminPageAbteilung");

curl_setopt( $ch1, CURLOPT_URL,"http://zoomnation.selfhost.eu/jsonData/sonderaufgaben/audits.json" );
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
		
			"auditID"	:	{$q},

			"abteilung"	:	$("#abteilung").val(),

			"auditart"	:	$("#auditart").val(),

			"termin"	:	$("#termin").val(),

			"status"	:	$("#status").val(),

			"nacharbeit"	:	$("#nacharbeit").val(),

			"terminturnus"	:	$("#terminturnus").val(),

			"beurteilung"	:	$("#beurteilung").val()

		}
);
saveAudit(data);

alert("createData saveAudit");

};
</script><div class="Produktionplanschritt">
	<div class="jumbotron">
		<div class="container">
		
HOME1_HEADER;
			
						// TODO: maxiD muss noch bestimmt werden

						echo("<label for='auditID'>auditID</label>");
						echo("<input readonly type='text' class='form-control' id='auditID' aria-describedby='auditID' placeholder='' value=1>");

					
						echo("<label for='abteilung'>abteilung</label>");
						echo("<input type='text' class='form-control' id='abteilung' aria-describedby='abteilung' placeholder='' value=0>");
					
						echo("<label for='auditart'>auditart</label>");
						echo("<input type='text' class='form-control' id='auditart' aria-describedby='auditart' placeholder='' value=0>");
					
						echo("<label for='termin'>termin</label>");
						echo("<input type='text' class='form-control' id='termin' aria-describedby='termin' placeholder='' value=0>");
					
						echo("<label for='status'>status</label>");
						echo("<input type='text' class='form-control' id='status' aria-describedby='status' placeholder='' value=0>");
						
						echo("<label for='nacharbeit'>nacharbeit</label>");
						echo("<input readonly type='text' class='form-control' id='nacharbeit' aria-describedby='nacharbeit' placeholder='' value='inArbeit'>");
					
						echo("<label for='terminturnus'>terminturnus</label>");
						echo("<input readonly type='text' class='form-control' id='terminturnus' aria-describedby='terminturnus' placeholder='' value='inArbeit'>");
						
						echo("<label for='beurteilung'>beurteilung</label>");
						echo("<input readonly type='text' class='form-control' id='beurteilung' aria-describedby='beurteilung' placeholder='' value='inArbeit'>");

						echo("<br>");
						echo("<td><input type='button' value='Speichern'  onclick='createData({$q});'></td>");


echo <<<'HOME1_FOOTER'
						
					</div>
				</div>
			</div>
HOME1_FOOTER;
						 
?>

