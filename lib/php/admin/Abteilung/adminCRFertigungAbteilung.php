<!--
Ersteller : Markus Kessler	
MatrNr 	  : 894361
Presentation: 28.04.2018
Team : ProMan
modifikations : Sebastian Molkenthin
MartNr : 896734
-->
<?php
//echo "PHP Datenabfrage<br>";
$q = $_REQUEST[ "q" ];
//echo "Anfrage : " . $q . "<br>";

$ch1 = curl_init();

//curl_setopt( $ch1, CURLOPT_URL,"http://zoomnation.selfhost.eu/jsonData/abteilung/abteilung.json" );
curl_setopt( $ch1, CURLOPT_URL,"http://zoomnation.selfhost.eu:8080/ProManAPI/api/addgetdeleteobject/?type=GetNoUseFertigung");
//curl_setopt( $ch1, CURLOPT_URL,"http://localhost:50435/api/addgetdeleteobject/?type=GetNoUseFertigung");
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
						echo("<select id='fertigungsID' name='fertigungsID' aria-describedby='fertigungsID' class='form-control'>");
						foreach($jsonfertigungsliste as $fertigungsitem) 
						{
						  echo("<option value={$fertigungsitem['Key']}>{$fertigungsitem['Value']}</option>");
						};
						  echo("</select>");

						echo("<br>");
						echo("<td><input type='button' value='Speichern'  onclick='createData({$q});'></td>");


echo <<<'HOME1_FOOTER'
						
					</div>
				</div>
			</div>
HOME1_FOOTER;
						 
?>

