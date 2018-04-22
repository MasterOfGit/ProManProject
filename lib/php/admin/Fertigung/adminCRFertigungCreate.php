<?php

echo <<<HEADER

<script>
function createData()
{
		var data = JSON.stringify(
		{
	
			"fertigungsname"	:	$("#fertigungsname").val(),

            "fertigungstyp"	:	$("#fertigungstyp").val(),

			"abteilungName"			:	$("#abteilungName").val(),

		}
        );
		createFertigung(data);

		
};
</script>




<div class="fertigungerstellen">
  <div class="jumbotron">
    <div class="jumbotron">
	 <div class="row">
      <div class="col-md-6 col-md-offset-3">
      <form>
        <div class="form-group">
         
HEADER;
		
echo("<label for='fertigungsname'>fertigungsname</label>");
echo("<input type='text' class='form-control' id='fertigungsname' aria-describedby='fertigungsname' placeholder='' value=>");
echo("<label for='fertigungstyp'>fertigungstyp</label>");
echo("<input type='text' class='form-control' id='fertigungstyp' aria-describedby='fertigungstyp' placeholder='' value=>");
echo("<label for='abteilungName'>abteilungName</label>");
echo("<input type='text' class='form-control' id='abteilungName' aria-describedby='abteilungName' placeholder='' value=>");

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

	



