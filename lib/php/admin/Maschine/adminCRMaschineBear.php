<?php
//echo "PHP Datenabfrage<br>";
$q = $_REQUEST["q"];
//echo "Anfrage : "  . $q . "<br>";
//$q= 0;
$ch1 = curl_init();


//curl_setopt($ch2, CURLOPT_URL, "http://zoomnation.selfhost.eu:8080/ProManAPI/api/adminPage/?identifier=AdminPageAbteilung");

curl_setopt($ch1, CURLOPT_URL, "http://zoomnation.selfhost.eu/jsonData/maschinen/maschinen.json");

curl_setopt($ch1, CURLOPT_HEADER, 0);
curl_setopt($ch1,CURLOPT_RETURNTRANSFER,true);
$maschine=curl_exec($ch1);
curl_close($ch1);

// Testausgabe
//echo($bauteil);

// Unwandlung von json in Array	
$jsonmaschine = json_decode($maschine, TRUE);


echo <<<HEADER

<script>
function createData()
{


		var data = JSON.stringify(
		{
	
			"maschinenID"				:	$("#maschinenID").val(),

			"maschinenInventarNummer"	:	$("#maschinenInventarNummer").val(),

			"hersteller"				:	$("#hersteller").val(),

			"technologie"				:	$("#technologie").val(),

			"standort"					:	$("#standort").val(),

			"abteilung"	 				:	$("#abteilung").val(),
			
			"status"					:	$("#status").val()
		}
);

saveMaschine(data);

alert("createData saveMaschine");

};
</script>



<div class="maschinebearbeiten">
 
    <div class="jumbotron">
	 <div class="row">
      <div class="col-md-6 col-md-offset-3">
      <form>
        <div class="form-group">
         
HEADER;
		  foreach($jsonmaschine['maschinen'] as $maschine)
				{
				// Neues Bauteil
			  	if( $maschine['maschinenID'] == $q)
					{
										
						echo("<label for='maschinenID'>maschinenID</label>");
						echo("<input readonly type='text' class='form-control' id='maschinenID' aria-describedby='userID' placeholder='' value={$maschine['maschinenID']}>");
													
						echo("<label for='maschinenInventarNummer'>maschinenInventarNummer</label>");
						echo("<input type='text' class='form-control' id='maschinenInventarNummer' aria-describedby='maschinenInventarNummer' placeholder='' value={$maschine['maschinenInventarNummer']}>");
					
						echo("<label for='hersteller'>hersteller</label>");
						echo("<input type='text' class='form-control' id='hersteller' aria-describedby='hersteller' placeholder='' value={$maschine['hersteller']}>");
					
						echo("<label for='technologie'>technologie</label>");
						echo("<input type='text' class='form-control' id='technologie' aria-describedby='userID' placeholder='' value={$maschine['technologie']}>");
					
						echo("<label for='standort'>standort</label>");
						echo("<input type='text' class='form-control' id='standort' aria-describedby='standort' placeholder='' value={$maschine['standort']}>");
					
						echo("<label for='abteilung'>abteilung</label>");
						echo("<input type='text' class='form-control' id='abteilung' aria-describedby='abteilung' placeholder='' value={$maschine['abteilung']}>");
					
						echo("<label for='status'>status</label>");
						echo("<input type='text' class='form-control' id='status' aria-describedby='status' placeholder='' value={$maschine['status']}>");

					}
			  	};
           		if( $q == 0) //neues Bauteil
					{
				  		foreach($jsonmaschine['maschinen'] as $maschine)
						{	$maschineidmax = 0;
							if($maschine['maschinenID']>$maschineidmax)
							{
								$maschineidmax = $maschine['maschinenID'];
								
							}
						 	$maschineidmax++;
						}
						
				  		echo("<label for='maschinenID'>maschinenID</label>");
						echo("<input readonly type='text' class='form-control' id='maschinenID' aria-describedby='userID' placeholder='' value=$maschineidmax>");
																					
						echo("<label for='maschinenInventarNummer'>maschinenInventarNummer</label>");
						echo("<input type='text' class='form-control' id='maschinenInventarNummer' aria-describedby='maschinenInventarNummer' placeholder='' value=0>");
					
						echo("<label for='hersteller'>hersteller</label>");
						echo("<input type='text' class='form-control' id='hersteller' aria-describedby='hersteller' placeholder='' value=0>");
					
						echo("<label for='technologie'>technologie</label>");
						echo("<input type='text' class='form-control' id='technologie' aria-describedby='userID' placeholder='' value=0>");
					
						echo("<label for='standort'>standort</label>");
						echo("<input type='text' class='form-control' id='standort' aria-describedby='standort' placeholder='' value=0>");
					
						echo("<label for='abteilung'>abteilung</label>");
						echo("<input type='text' class='form-control' id='abteilung' aria-describedby='abteilung' placeholder='' value=0>");
					
						echo("<label for='status'>status</label>");
						echo("<input type='text' class='form-control' id='status' aria-describedby='status' placeholder='' value=0>");
						
			  		}
echo <<<FOOTER
		</div>
<button type="button" class="btn btn-primary" onclick="createData()"> Speichern</button>
<input class='btn btn-primary' type="button" value="Zurück" onclick="window.location.href='usercontent.html'" />
	      </form>
    </div>
  </div>
</div>
</div>


FOOTER;
?>