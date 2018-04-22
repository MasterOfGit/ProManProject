<?php

echo <<<HEADER

<script>
function createData()
{
		var data = JSON.stringify(
		{
	
			"fertigungslinienname"	:	$("#fertigungslinienname").val(),

		}
        );
		createFertigungslinie(data);

		
};
</script>



<div class="fertigunglinieerstellen">
  <div class="jumbotron">
    <div class="jumbotron">
	 <div class="row">
      <div class="col-md-6 col-md-offset-3">
      <form>
        <div class="form-group">
         
HEADER;
		
echo("<label for='fertigungslinienname'>fertigungslinienname</label>");
echo("<input type='text' class='form-control' id='fertigungslinienname' aria-describedby='fertigungslinienname' placeholder='' value=>");

echo <<<FOOTER
		</div>
<button class='btn btn-primary' type="button" class="btn btn-primary" onclick="createData();">Speichern</button>
<input class='btn btn-primary' type="button" value="Zurück" onclick="window.location.href='usercontent.html'" />
	      </form>
    </div>
  </div>
</div>
</div>
</div>

FOOTER;
?>

	



