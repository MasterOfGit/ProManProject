<!--
Ersteller : Markus Kessler	
MatrNr 	  : 894361
Presentation: 28.04.2018
Theam : ProMan
-->
<?php
//echo "PHP Datenabfrage<br>";
$q = $_REQUEST["q"];
//echo "Anfrage : "  . $q . "<br>";
//$q= 0;
$ch1 = curl_init();



//curl_setopt($ch1, CURLOPT_URL, "http://zoomnation.selfhost.eu/jsonData/bauteile/bauteile.json");
curl_setopt($ch1, CURLOPT_URL, "http://zoomnation.selfhost.eu:8080/ProManAPI/api/bauteil");
//curl_setopt($ch1, CURLOPT_URL, "http://localhost/api/bauteil");

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

		var givenId = $q;
		var data = JSON.stringify(
		{
	
			"bauteileID"			:	$("#bauteileID").val(),

			"bauteilNummer"			:	$("#bauteilNummer").val(),

			"bauteilIndex"			:	$("#bauteilIndex").val(),

			"bauteilArt"			:	$("#bauteilArt").val(),

			"bauteilVersion"		:	$("#bauteilVersion").val(),

			"bauteilStatus"	 		:	$("#bauteilStatus").val(),
			
			"bauteilIDNachfolger"	:	$("#bauteilIDNachfolger").val()
		}
		);
		
		if(givenId==0)		{		
			saveBauteil(data);
		}
		else{
			updateBauteil(data,givenId);
			
		}
		
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
		  foreach($jsonbauteil as $bauteil)
				{
				// Neues Bauteil
			  	if( $bauteil['bauteileID'] == $q)
					{
										
						echo("<label for='bauteileID'>bauteileID</label>");
						echo("<input readonly type='text' class='form-control' id='bauteileID' aria-describedby='bauteileID' placeholder='' value={$bauteil['bauteileID']}>");
					
						echo("<label for='bauteilNummer'>bauteilNummer</label>");
						echo("<input type='text' class='form-control' id='bauteilNummer' aria-describedby='bauteilNummer' placeholder='' value={$bauteil['bauteilNummer']}>");
					
						echo("<label for='bauteilIndex'>bauteilIndex</label>");
						echo("<input type='text' class='form-control' id='bauteilIndex' aria-describedby='bauteilIndex' placeholder='' value={$bauteil['bauteilIndex']}>");
					
						echo("<label for='bauteilVersion'>bauteilVersion</label>");
						echo("<input type='text' class='form-control' id='bauteilVersion' aria-describedby='bauteilVersion' placeholder='' value={$bauteil['bauteilVersion']}>");
					
						echo("<label for='bauteilArt'>bauteilArt</label>");
						echo("<input type='text' class='form-control' id='bauteilArt' aria-describedby='bauteilArt' placeholder='' value={$bauteil['bauteilArt']}>");
						
						echo("<label for='bauteilStatus'>bauteilStatus</label>");
						echo("<input type='text' class='form-control' id='bauteilStatus' aria-describedby='bauteilStatus' placeholder='' value={$bauteil['bauteilStatus']}>");
					
						echo("<label for='bauteilIDNachfolger'>bauteilIDNachfolger</label>");
						echo("<input type='text' class='form-control' id='bauteilIDNachfolger' aria-describedby='bauteilIDNachfolger' placeholder='' value={$bauteil['bauteilIDNachfolger']}>");

					}
			  	};
           		if( $q == 0) //neues Bauteil
					{
					
				  		echo("<label for='bauteileID'>bauteileID</label>");
						echo("<input  readonly type='text' class='form-control' id='bauteileID' aria-describedby='bauteileID' placeholder='' value=0>");
						echo("<label for='bauteilNummer'>bauteilNummer</label>");
						echo("<input type='text' class='form-control' id='bauteilNummer' aria-describedby='bauteilNummer' placeholder='' value=0>");
						echo("<label for='bauteilIndex'>bauteilIndex</label>");
						echo("<input type='text' class='form-control' id='bauteilIndex' aria-describedby='bauteilIndex' placeholder='' value=0>");
						echo("<label for='bauteilVersion'>bauteilVersion</label>");
						echo("<input type='text' class='form-control' id='bauteilVersion' aria-describedby='bauteilVersion' placeholder='' value=0>");
						echo("<label for='bauteilArt'>bauteilArt</label>");
						echo("<input type='text' class='form-control' id='bauteilArt' aria-describedby='bauteilArt' placeholder='' value=0>");
						echo("<label for='bauteilStatus'>bauteilStatus</label>");
						echo("<input type='text' class='form-control' id='bauteilStatus' aria-describedby='bauteilStatus' placeholder='' value=0>");
						echo("<label for='bauteilIDNachfolger'>bauteilIDNachfolger</label>");
						echo("<input type='text' class='form-control' id='bauteilIDNachfolger' aria-describedby='bauteilIDNachfolger' placeholder='' value=0>");
			  		}
echo <<<FOOTER
		</div>
<button class='btn btn-primary' type="button" class="btn btn-primary" onclick="createData();"> Speichern</button>
<input class='btn btn-primary' type="button" value="Zurück" onclick="window.location.href='usercontent.html'" />
	      </form>
    </div>
  </div>
</div>
</div>
</div>



FOOTER;
?>

	



