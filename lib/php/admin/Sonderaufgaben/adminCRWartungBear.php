
<?php

$ch1 = curl_init();
	$q = 0;
	$q = $_REQUEST[ "q"] ;

curl_setopt( $ch1, CURLOPT_URL,"http://zoomnation.selfhost.eu/jsonData/sonderaufgaben/wartungen.json" );
	curl_setopt( $ch1, CURLOPT_HEADER, 0 );
	curl_setopt( $ch1, CURLOPT_RETURNTRANSFER, true );
	$wartungen = curl_exec( $ch1 );
	curl_close( $ch1 );


// Unwandlung von json in Array	
$jsonwartungen = json_decode($wartungen, TRUE);


// Besimmen des Noetigen Indexex des Wartung
	
	foreach($jsonwartungen['wartungen'] as $wartung){
		$maxWartung = 0;
		if($wartung['wartungsID'] > $maxWartung)
		{
			$maxWartung = $wartung['wartungsID'];
			$abteilung = $wartung['abteilung'];
			$fertigung = $wartung['fertigung'];
			$fertigungslinie = $wartung['fertigungslinie'];
			$maschine = $wartung['maschine'];
			$terminturnus = $wartung['terminturnus'];
			$status = $wartung['status'];
			
			if( $q == 0)
			{
			$maxWartung = $wartung['wartungsID'];
			$abteilung = 0;
			$fertigung = 0;
			$fertigungslinie = 0;
			$maschine = 0;
			$terminturnus = 0;
			$status = 0;
			}
			
		}
	}
	// Aktueller Index bei neuer Wartung
	$maxWartung++ ;

	// Aktueller Index bei aenderung einer Wartung
	if($q > 0)
	{
		$maxWartung = $q ;
		$zugriff = 1;
	}
	else 
		$zugriff = 0;




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
saveWartung(data,{$zugriff});

alert("createData saveWartung");

};
</script><div class="Lagerort">
	<div class="jumbotron">
		<div class="container">
		
HOME1_HEADER;
			
						// TODO: maxiD muss noch bestimmt werden

						echo("<label for='wartungsID'>wartungsID</label>");
						echo("<input readonly type='text' class='form-control' id='wartungsID' aria-describedby='wartungsID' placeholder='' value={$maxWartung}>");

					
						echo("<label for='abteilung'>abteilung</label>");
						echo("<input type='text' class='form-control' id='abteilung' aria-describedby='abteilung' placeholder='' value={$abteilung}>");
					
						echo("<label for='fertigung'>fertigung</label>");
						echo("<input type='text' class='form-control' id='fertigung' aria-describedby='fertigung' placeholder='' value={$fertigung}>");
					
						echo("<label for='fertigungslinie'>fertigungslinie</label>");
						echo("<input type='text' class='form-control' id='fertigungslinie' aria-describedby='fertigungslinie' placeholder='' value={$fertigungslinie}>");
					
						echo("<label for='maschine'>maschine</label>");
						echo("<input type='text' class='form-control' id='maschine' aria-describedby='maschine' placeholder='' value={$maschine}>");
						
						echo("<label for='terminturnus'>terminturnus</label>");
						echo("<input type='text' class='form-control' id='terminturnus' aria-describedby='terminturnus' placeholder='' value='{$terminturnus}'>");

						echo("<label for='status'>status</label>");
						echo("<input  type='text' class='form-control' id='status' aria-describedby='status' placeholder='' value='{$status}'>");
					
						echo("<br>");
						echo("<td><input type='button' value='Speichern'  onclick='createData({$q});'></td>");


echo <<<'HOME1_FOOTER'
						
					</div>
				</div>
			</div>
HOME1_FOOTER;
						 
?>

