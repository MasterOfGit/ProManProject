
<?php
//echo "PHP Datenabfrage<br>";
$q = $_REQUEST[ "q" ];
//echo "Anfrage : " . $q . "<br>";

$ch1 = curl_init();


//curl_setopt($ch2, CURLOPT_URL, "http://zoomnation.selfhost.eu:8080/ProManAPI/api/adminPage/?identifier=AdminPageAbteilung");

//curl_setopt( $ch1, CURLOPT_URL,"http://zoomnation.selfhost.eu/jsonData/abteilung/abteilung.json" );
curl_setopt( $ch1, CURLOPT_URL,"http://zoomnation.selfhost.eu:8080/ProManAPI/api/addgetdeleteobject/?type=FertigungListe");
//curl_setopt( $ch1, CURLOPT_URL,"http://localhost:50435/api/addgetdeleteobject/?type=FertigungListe");
curl_setopt( $ch1, CURLOPT_HEADER, 0 );
curl_setopt( $ch1, CURLOPT_RETURNTRANSFER, true );
$fertigungsliste = curl_exec( $ch1 );
curl_close( $ch1 );

// Unwandlung von json in Array	
$jsonfertigungsliste = json_decode($fertigungsliste, TRUE);

echo <<<'HOME1_HEADER'

<script>
function createData(q)
{
	addFertigungAbteilung(q, $("#fertigungsID").val());
};
</script>
<div class="Fetigung">
	<div class="jumbotron">
		<div class="container">
		
HOME1_HEADER;
			
						echo("<label for='abteilungsID'>abteilungsID</label>");
						echo("<input readonly type='text' class='form-control' id='abteilungsID' aria-describedby='userID' placeholder='' value={$q}>");

						echo("<label for='fertigungsID'>fertigungsID</label>");
						echo("<input type='text' class='form-control' id='fertigungsID' aria-describedby='fertigungsID' placeholder='' value=0>");			
			
						echo("<br>");
						echo("<td><input type='button' value='Speichern'  onclick='createData({$q});'></td>");


echo <<<'HOME1_FOOTER'
						
					</div>
				</div>
			</div>
HOME1_FOOTER;
						 
?>

