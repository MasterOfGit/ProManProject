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

//curl_setopt( $ch1, CURLOPT_URL,"http://zoomnation.selfhost.eu/jsonData/fertigung/fertigung.json" );
curl_setopt( $ch1, CURLOPT_URL,"http://zoomnation.selfhost.eu:8080/ProManAPI/api/addgetdeleteobject/?type=GetNoUseFertigungsLinie");
//curl_setopt( $ch1, CURLOPT_URL,"http://localhost:50435/api/addgetdeleteobject/?type=GetNoUseFertigungsLinie");
curl_setopt( $ch1, CURLOPT_HEADER, 0 );
curl_setopt( $ch1, CURLOPT_RETURNTRANSFER, true );
$fertigungslinien = curl_exec( $ch1 );
curl_close( $ch1 );

// Unwandlung von json in Array	
$jsonfertigungslinien = json_decode($fertigungslinien, TRUE);


echo <<<'HOME1_HEADER'

<script>
function createData(q)
{
	addFertigungslinieFertigung(q, $("#fertigungslinienID").val());

};
</script>
<div class="Fetigungslinie">
	<div class="jumbotron">
		<div class="container">
		
HOME1_HEADER;
			
						echo("<label for='fertigungsID'>fertigungsID</label>");
						echo("<input readonly type='text' class='form-control' id='fertigungsID' aria-describedby='userID' placeholder='' value={$q}>");

						echo("<label for='fertigungslinienID'>fertigungslinienID</label>");
						echo("<select id='fertigungslinienID' name='fertigungslinienID' aria-describedby='fertigungslinienID' class='form-control'>");
						foreach($jsonfertigungslinien as $fertigungslinienitem) 
						{
						  echo("<option value={$fertigungslinienitem['Key']}>{$fertigungslinienitem['Value']}</option>");
						};
					  	echo("</select>");
						echo("<br>");
						echo("<td><input class='btn btn-primary' type='button' value='Speichern'  onclick='createData({$q});'></td>");


echo <<<'HOME1_FOOTER'
						
					</div>
				</div>
			</div>
HOME1_FOOTER;
						 
?>

