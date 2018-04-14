
<?php
//echo "PHP Datenabfrage<br>";
$q = $_REQUEST[ "q" ];
//echo "Anfrage : " . $q . "<br>";

$ch1 = curl_init();


//curl_setopt($ch2, CURLOPT_URL, "http://zoomnation.selfhost.eu:8080/ProManAPI/api/adminPage/?identifier=AdminPageAbteilung");

curl_setopt( $ch1, CURLOPT_URL,"http://zoomnation.selfhost.eu/jsonData/abteilung/abteilung.json" );
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
	
						"abteilungsID"		:	$("#abteilungsID").val(),

		 				"abteilunngsname"	:	$("#abteilunngsname").val(),

		 	

		 				"fertigungen"	:

							[

								{

									"fertigungsID"			:	$("#fertigungsID").val(),

									"fertifertigungsname"	:	$("#fertifertigungsname").val()		

								}
						    ]
		}
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

						echo("<label for='abteilungsID'>abteilungsID</label>");
						echo("<input readonly type='text' class='form-control' id='abteilungsID' aria-describedby='userID' placeholder='' value={$q}>");

					
						echo("<label for='abteilunngsname'>abteilunngsname</label>");
						echo("<input type='text' class='form-control' id='abteilunngsname' aria-describedby='abteilunngsname' placeholder='' value=0>");
					
						echo("<label for='fertigungsID'>fertigungsID</label>");
						echo("<input type='text' class='form-control' id='fertigungsID' aria-describedby='fertigungsID' placeholder='' value=0>");
					
						echo("<label for='fertifertigungsname'>fertifertigungsname</label>");
						echo("<input type='text' class='form-control' id='fertifertigungsname' aria-describedby='fertifertigungsname' placeholder='' value=0>");
					
											
						echo("<br>");
						echo("<td><input type='button' value='Speichern'  onclick='createData({$q});'></td>");


echo <<<'HOME1_FOOTER'
						
					</div>
				</div>
			</div>
HOME1_FOOTER;
						 
?>

