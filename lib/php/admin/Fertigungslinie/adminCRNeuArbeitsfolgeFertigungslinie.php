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


//curl_setopt( $ch1, CURLOPT_URL,"http://zoomnation.selfhost.eu/jsonData/fertigungslinien/fertigungslinien.json" );
//curl_setopt($ch1, CURLOPT_URL, "http://zoomnation.selfhost.eu:8080/ProManAPI/api/adminPage/?identifier=AdminPageAbteilung");
//curl_setopt($ch1, CURLOPT_URL, "http://zoomnation.selfhost.eu:8080/ProManAPI/api/arbeitsfolge");
//curl_setopt( $ch1, CURLOPT_HEADER, 0 );
//curl_setopt( $ch1, CURLOPT_RETURNTRANSFER, true );
//$fertigungslinien = curl_exec( $ch1 );
//curl_close( $ch1 );

$chmaschine = curl_init();
curl_setopt( $chmaschine, CURLOPT_URL,"http://zoomnation.selfhost.eu:8080/ProManAPI/api/maschine" );
//curl_setopt( $chmaschine, CURLOPT_URL,"http://localhost:50435/api/maschine" );
curl_setopt( $chmaschine, CURLOPT_HEADER, 0 );
curl_setopt( $chmaschine, CURLOPT_RETURNTRANSFER, true );
$maschinen = curl_exec( $chmaschine );
curl_close( $chmaschine );

// Unwandlung von json in Array	
$jsonmaschinen = json_decode($maschinen, TRUE);

$chbauteil = curl_init();
curl_setopt( $chbauteil, CURLOPT_URL,"http://zoomnation.selfhost.eu:8080/ProManAPI/api/bauteil" );
//curl_setopt( $chbauteil, CURLOPT_URL,"http://localhost:50435/api/bauteil" );
curl_setopt( $chbauteil, CURLOPT_HEADER, 0 );
curl_setopt( $chbauteil, CURLOPT_RETURNTRANSFER, true );
$bauteile = curl_exec( $chbauteil );
curl_close( $chbauteil );

// Unwandlung von json in Array	
$jsonbauteile = json_decode($bauteile, TRUE);

// Testausgabe
//echo($maschinen);

// Unwandlung von json in Array	
//$jsonfertigungslinien = json_decode($fertigungslinien, TRUE);
//print_r($fertigungslinien);

//print_r($jsonfertigungslinien);

echo <<<'HOME1_HEADER'

<script>
function createData(q)
{


		var data = JSON.stringify(
		{
		
			"fertigungslinieID"			:	$("#fertigungslinieID").val(),

			"arbeitsfolgeID"			:	$("#arbeitsfolgeID").val(),

			"maschineID"				:	$("#maschineID").val(),

			"bauteilID"					:	$("#bauteilID").val(),

			"arbeitplan"	 			:	$("#arbeitplan").val()

		}
);
SaveNewArbeitsfolgeInFertigunglinie(data);

alert("createData SaveNewArbeitsfolgeInFertigunglinie");

};
</script>
<div class="Fetigungslinie">
	<div class="jumbotron">
		<div class="container">
		
HOME1_HEADER;
			
						echo("<label for='fertigungslinieID'>fertigungslinieID</label>");
						echo("<input readonly type='text' class='form-control' id='fertigungslinieID' aria-describedby='userID' placeholder='' value=$q>");

						echo("<label for='arbeitsfolgeID'>arbeitsfolgeID</label>");
						echo("<input readonly type='text' class='form-control' id='arbeitsfolgeID' aria-describedby='userID' placeholder='' value=0>");
					
						echo("<label for='maschineID'>maschineID</label>");
						echo("<select id='maschineID' name='maschineID' aria-describedby='maschineID' class='form-control'>");
						foreach($jsonmaschinen as $Maschineitem) 
						{
							echo("<option value={$Maschineitem['maschinenID']}>{$Maschineitem['maschinenInventarNummer']}</option>");
										  
						};
						echo("</select>");


										
						echo("<label for='bauteilID'>bauteilID</label>");
						echo("<select id='bauteilID' name='bauteilID' aria-describedby='bauteilID' class='form-control'>");
						foreach($jsonbauteile as $Bauteilitem) 
						{
							echo("<option value={$Bauteilitem['bauteileID']}>{$Bauteilitem['bauteilIndex']}</option>");
											  
						};
						echo("</select>");

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

