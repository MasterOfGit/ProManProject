<?php
//echo "PHP Datenabfrage<br>";
$q = $_REQUEST["q"];
//echo "Anfrage : "  . $q . "<br>";
//$q= 0;
$ch1 = curl_init();


//curl_setopt($ch2, CURLOPT_URL, "http://zoomnation.selfhost.eu:8080/ProManAPI/api/adminPage/?identifier=AdminPageAbteilung");

curl_setopt($ch1, CURLOPT_URL, "http://zoomnation.selfhost.eu/jsonData/bauteile/bauteile.json");

curl_setopt($ch1, CURLOPT_HEADER, 0);
curl_setopt($ch1,CURLOPT_RETURNTRANSFER,true);
$bauteil=curl_exec($ch1);
curl_close($ch1);

// Testausgabe
//echo($bauteil);

// Unwandlung von json in Array	
$jsonbauteil = json_decode($bauteil, TRUE);


echo <<<HEADER

<script>
function createData()
{


		var data = JSON.stringify(
		{
	
			"bauteileID"			:	$("#bauteileID").val(),

			"bauteinNummer"			:	$("#bauteinNummer").val(),

			"bauteilIndex"			:	$("#bauteilIndex").val(),

			"bauteilVersiom"		:	$("#bauteilVersiom").val(),

			"bauteilArt"			:	$("#bauteilArt").val(),

			"bauteilStatus"	 		:	$("#bauteilStatus").val(),
			
			"bauteilIDNachfolger"	:	$("#bauteilIDNachfolger").val()
		}
);
saveBauteil(data);

alert("createData()");

};
</script>




<div class="bautelbearbeiten">
  <div class="jumbotron">
    <div class="jumbotron">
	 <div class="row">
      <div class="col-md-6 col-md-offset-3">
      <form>
        <div class="form-group">
         
HEADER;
		  foreach($jsonbauteil['bauteile'] as $bauteil)
				{
				// Neues Bauteil
			  	if( $bauteil['bauteileID'] == $q)
					{
										
						echo("<label for='bauteileID'>bauteileID</label>");
						echo("<input readonly type='text' class='form-control' id='bauteileID' aria-describedby='userID' placeholder='' value={$bauteil['bauteileID']}>");
					
						echo("<label for='bauteinNummer'>bauteinNummer</label>");
						echo("<input type='text' class='form-control' id='bauteinNummer' aria-describedby='bauteinNummer' placeholder='' value={$bauteil['bauteinNummer']}>");
					
						echo("<label for='bauteilIndex'>bauteilIndex</label>");
						echo("<input type='text' class='form-control' id='bauteilIndex' aria-describedby='bauteilIndex' placeholder='' value={$bauteil['bauteilIndex']}>");
					
						echo("<label for='bauteilVersiom'>bauteilVersiom</label>");
						echo("<input type='text' class='form-control' id='bauteilVersiom' aria-describedby='bauteilVersiom' placeholder='' value={$bauteil['bauteilVersiom']}>");
					
						echo("<label for='bauteilArt'>bauteilArt</label>");
						echo("<input type='text' class='form-control' id='bauteilArt' aria-describedby='userID' placeholder='' value={$bauteil['bauteilArt']}>");
						
						echo("<label for='bauteilStatus'>bauteilStatus</label>");
						echo("<input type='text' class='form-control' id='bauteilStatus' aria-describedby='bauteilStatus' placeholder='' value={$bauteil['bauteilStatus']}>");
					
						echo("<label for='bauteilIDNachfolger'>bauteilIDNachfolger</label>");
						echo("<input type='text' class='form-control' id='bauteilIDNachfolger' aria-describedby='bauteilIDNachfolger' placeholder='' value={$bauteil['bauteilIDNachfolger']}>");

					}
			  	};
           		if( $q == 0) //neues Bauteil
					{
				  		foreach($jsonbauteil['bauteile'] as $bauteil)
						{	$bauteilidmax = 0;
							if($bauteil['bauteileID']>$bauteilidmax)
							{
								$bauteilidmax = $bauteil['bauteileID'];
								
							}
						 	$bauteilidmax++;
						}
						
				  		echo("<label for='bauteileID'>bauteileID</label>");
						echo("<input  readonly type='text' class='form-control' id='bauteileID' aria-describedby='userID' placeholder='' value=$bauteilidmax>");
						echo("<label for='bauteinNummer'>bauteinNummer</label>");
						echo("<input type='text' class='form-control' id='bauteinNummer' aria-describedby='bauteinNummer' placeholder='' value=0>");
						echo("<label for='bauteilIndex'>bauteilIndex</label>");
						echo("<input type='text' class='form-control' id='bauteilIndex' aria-describedby='bauteilIndex' placeholder='' value=0>");
						echo("<label for='bauteilVersiom'>bauteilVersiom</label>");
						echo("<input type='text' class='form-control' id='bauteilVersiom' aria-describedby='bauteilVersiom' placeholder='' value=0>");
						echo("<label for='bauteilArt'>bauteilArt</label>");
						echo("<input type='text' class='form-control' id='bauteilArt' aria-describedby='userID' placeholder='' value=0>");
						echo("<label for='bauteilStatus'>bauteilStatus</label>");
						echo("<input type='text' class='form-control' id='bauteilStatus' aria-describedby='bauteilStatus' placeholder='' value=0>");
						echo("<label for='bauteilIDNachfolger'>bauteilIDNachfolger</label>");
						echo("<input type='text' class='form-control' id='bauteilIDNachfolger' aria-describedby='bauteilIDNachfolger' placeholder='' value=0>");
			  		}
echo <<<FOOTER
		</div>
<button type="button" class="btn btn-primary" onclick="createData();"> Speichern</button>
<input type="button" value="Zurück" onclick="window.location.href='usercontent.html'" />
	      </form>
    </div>
  </div>
</div>
</div>
</div>



FOOTER;
?>

	



