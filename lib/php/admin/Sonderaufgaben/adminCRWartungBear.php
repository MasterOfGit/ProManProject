<!--
Ersteller : Markus Kessler	
MatrNr 	  : 894361
Presentation: 28.04.2018
Team : ProMan
modifikations : Sebastian Molkenthin
MartNr : 896734
-->
<?php

$ch1 = curl_init();
	$q = 0;
	$q = $_REQUEST[ "q"] ;

	
//curl_setopt( $ch1, CURLOPT_URL,"http://zoomnation.selfhost.eu/jsonData/sonderaufgaben/wartungen.json" );
curl_setopt( $ch1, CURLOPT_URL,"http://zoomnation.selfhost.eu:8080/ProManAPI/api/wartung" );
//curl_setopt( $ch1, CURLOPT_URL,"http://localhost:50435/api/wartung" );
curl_setopt( $ch1, CURLOPT_HEADER, 0 );
curl_setopt( $ch1, CURLOPT_RETURNTRANSFER, true );
$wartungen = curl_exec( $ch1 );
curl_close( $ch1 );

// Unwandlung von json in Array	
$jsonwartungen = json_decode($wartungen, TRUE);

//load maschines

$chmaschine = curl_init();
curl_setopt( $chmaschine, CURLOPT_URL,"http://zoomnation.selfhost.eu:8080/ProManAPI/api/maschine" );
//curl_setopt( $chmaschine, CURLOPT_URL,"http://localhost:50435/api/maschine" );
curl_setopt( $chmaschine, CURLOPT_HEADER, 0 );
curl_setopt( $chmaschine, CURLOPT_RETURNTRANSFER, true );
$maschinen = curl_exec( $chmaschine );
curl_close( $chmaschine );

// Unwandlung von json in Array	
$jsonmaschinen = json_decode($maschinen, TRUE);

//load enums

$ch2 = curl_init();
curl_setopt( $ch2, CURLOPT_URL,"http://zoomnation.selfhost.eu:8080/ProManAPI/api/addgetdeleteobject/?type=StatusArt" );
//curl_setopt( $ch2, CURLOPT_URL,"http://localhost:50435/api/addgetdeleteobject/?type=StatusArt" );
curl_setopt( $ch2, CURLOPT_HEADER, 0 );
curl_setopt( $ch2, CURLOPT_RETURNTRANSFER, true );
$StatusArt = curl_exec( $ch2 );
curl_close( $ch2 );

// Unwandlung von json in Array	
$jsonStatusArt = json_decode($StatusArt, TRUE);

$ch3 = curl_init();
curl_setopt( $ch3, CURLOPT_URL,"http://zoomnation.selfhost.eu:8080/ProManAPI/api/addgetdeleteobject/?type=Turnus" );
//curl_setopt( $ch3, CURLOPT_URL,"http://localhost:50435/api/addgetdeleteobject/?type=Turnus" );
curl_setopt( $ch3, CURLOPT_HEADER, 0 );
curl_setopt( $ch3, CURLOPT_RETURNTRANSFER, true );
$Turnus = curl_exec( $ch3 );
curl_close( $ch3 );

// Unwandlung von json in Array	
$jsonTurnus = json_decode($Turnus, TRUE);

// Bestimmen des Noetigen Indexex des Wartung
if( $q == 0)
{
	$maxWartung = $wartung['wartungsID'];
	$abteilung = 0;
	$fertigung = 0;
	$fertigungslinie = 0;
	$maschine = 0;
	$terminturnus = 0;
	$status = 0;

	$zugriff = 0;
}
else
{
	foreach($jsonwartungen as $wartung){
		$maxWartung = 0;
		if($wartung['wartungsID'] > $q)
		{
			$maxWartung = $wartung['wartungsID'];
			$abteilung = $wartung['abteilung'];
			$fertigung = $wartung['fertigung'];
			$fertigungslinie = $wartung['fertigungslinie'];
			$maschine = $wartung['maschine'];
			$terminturnus = $wartung['terminturnus'];
			$status = $wartung['status'];
		};
	}
	$zugriff = 1;
}


echo <<<HOME1_HEADER
<script>
function createData(q)
{


		var data = JSON.stringify(
		{
		
		
			"wartungsID"	:	$("#wartungsID").val(),

			"abteilung"		:	$("#abteilung").val(),

			"fertigung"		:	$("#fertigung").val(),

			"fertigungslinie"	:	$("#fertigungslinie").val(),

			"maschine"		:	$("#maschine").val(),

			"terminturnus"	:	$("#terminturnus").val(),

			"status"		:	$("#status").val()

		}
);
saveWartung(data,{$zugriff},$("#wartungsID").val());

alert("createData saveWartung");

};
</script><div class="Lagerort">
	<div class="jumbotron">
		<div class="container">
		
HOME1_HEADER;
			
						echo("<label for='wartungsID'>wartungsID</label>");
						echo("<input readonly type='text' class='form-control' id='wartungsID' aria-describedby='wartungsID' placeholder='' value={$q}>");

					
						echo("<label for='abteilung'>abteilung</label>");
						echo("<input readonly type='text' class='form-control' id='abteilung' aria-describedby='abteilung' placeholder='' value={$abteilung} >");
					
						echo("<label for='fertigung'>fertigung</label>");
						echo("<input readonly type='text' class='form-control' id='fertigung' aria-describedby='fertigung' placeholder='' value={$fertigung} >");
					
						echo("<label for='fertigungslinie'>fertigungslinie</label>");
						echo("<input readonly type='text' class='form-control' id='fertigungslinie' aria-describedby='fertigungslinie' placeholder='' value={$fertigungslinie} >");
					
						echo("<label for='maschine'>maschine</label>");
						echo("<select id='maschine' name='maschine' aria-describedby='maschine' class='form-control'>");
						foreach($jsonmaschinen as $Maschineitem) 
						{
							if($wartung['maschine']==$Maschineitem['maschinenInventarNummer'])
							{
								echo("<option value={$Maschineitem['maschinenID']} selected>{$Maschineitem['maschinenInventarNummer']}</option>");
							}
							else
							{
								echo("<option value={$Maschineitem['maschinenID']}>{$Maschineitem['maschinenInventarNummer']}</option>");
							}				  
						};
						echo("</select>");
						
						echo("<label for='terminturnus'>terminturnus</label>");
						echo("<select id='terminturnus' name='terminturnus' aria-describedby='terminturnus' class='form-control'>");
						foreach($jsonTurnus as $Turnusitem) 
						{
							if($wartung['terminturnus']==$Turnusitem['Value'])
							{
								echo("<option value={$Turnusitem['Key']} selected>{$Turnusitem['Value']}</option>");
							}
							else
							{
								echo("<option value={$Turnusitem['Key']}>{$Turnusitem['Value']}</option>");
							}				  
						};
						echo("</select>");

						echo("<label for='status'>status</label>");
						echo("<select id='status' name='status' aria-describedby='status' class='form-control'>");
						foreach($jsonStatusArt as $Statusitem) 
						{
							if($wartung['status']==$Statusitem['Value'])
							{
								echo("<option value={$Statusitem['Key']} selected>{$Statusitem['Value']}</option>");
							}
							else
							{
								echo("<option value={$Statusitem['Key']}>{$Statusitem['Value']}</option>");
							}			  
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

