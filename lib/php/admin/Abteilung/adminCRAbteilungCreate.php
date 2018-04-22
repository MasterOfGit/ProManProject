<?php

echo <<<HEADER

<script>
function createData()
{
		var data = JSON.stringify(
		{
	
			"abteilungsname"	:	$("#abteilungsname").val(),

			"WerkName"			:	$("#WerkName").val(),

		}
        );
		createAbteilung(data);

		
};
</script>




<div class="abteilungerstellen">
  <div class="jumbotron">
    <div class="jumbotron">
	 <div class="row">
      <div class="col-md-6 col-md-offset-3">
      <form>
        <div class="form-group">
         
HEADER;
		
echo("<label for='abteilungsname'>abteilungsname</label>");
echo("<input type='text' class='form-control' id='abteilungsname' aria-describedby='abteilungsname' placeholder='' value=>");
echo("<label for='WerkName'>WerkName</label>");
echo("<input type='text' class='form-control' id='WerkName' aria-describedby='WerkName' placeholder='' value=>");

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

	



