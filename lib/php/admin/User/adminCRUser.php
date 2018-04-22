<!--
Ersteller : Markus Kessler	
MatrNr 	  : 894361
Presentation: 28.04.2018
Theam : ProMan
-->
<?php
//echo "PHP Datenabfrage<br>";
//$q = $_REQUEST["q"];
//echo "Anfrage : "  . $q . "<br>";

// Data load
$ch1 = curl_init();
$ch2 = curl_init();
$ch3 = curl_init();

//curl_setopt($ch1, CURLOPT_URL, "http://zoomnation.selfhost.eu/jsonData/user/userData.json");
curl_setopt($ch1, CURLOPT_URL, "http://zoomnation.selfhost.eu:8080/ProManAPI/api/user?needlogin=true");
//curl_setopt($ch1, CURLOPT_URL, "http://localhost:50435/api/user?needlogin=true");


curl_setopt($ch1, CURLOPT_HEADER, 0);
curl_setopt($ch1,CURLOPT_RETURNTRANSFER,true);
$userDatawithLogin=curl_exec($ch1);
curl_close($ch1);

//curl_setopt($ch2, CURLOPT_URL, "http://zoomnation.selfhost.eu/jsonData/user/userLogin.json");
curl_setopt($ch2, CURLOPT_URL, "http://zoomnation.selfhost.eu:8080/ProManAPI/api/user?needlogin=false");
//curl_setopt($ch2, CURLOPT_URL, "http://localhost:50435/api/user?needlogin=false");


curl_setopt($ch2, CURLOPT_HEADER, 0);
curl_setopt($ch2,CURLOPT_RETURNTRANSFER,true);
$userDatawithoutLogin=curl_exec($ch2);
curl_close($ch2);

//curl_setopt($ch3, CURLOPT_URL, "http://zoomnation.selfhost.eu/jsonData/user/userAnfragen.json");
curl_setopt($ch2, CURLOPT_URL, "http://zoomnation.selfhost.eu:8080/ProManAPI/api/useranfrage");
//curl_setopt($ch2, CURLOPT_URL, "http://localhost:50435/api/useranfrage");
curl_setopt($ch3, CURLOPT_HEADER, 0);
curl_setopt($ch3,CURLOPT_RETURNTRANSFER,true);
$userAnfragen=curl_exec($ch3);
curl_close($ch3);

// Testausgabe
//print_r($userData);
//echo("<br>");
//echo("<br>");
//print_r($userLogin);
//echo("<br>");
//echo("<br>");
//print_r($userAnfragen);
	
// Unwandlung von json in Array	
$jsonuserDatawithLogin = json_decode($userDatawithLogin, TRUE);
$jsonuserDatawithoutLogin = json_decode($userDatawithoutLogin, TRUE);
$jsonUserAnfrage = json_decode($userAnfragen, TRUE);

//print_r($jsonUserLogin);
//echo("<br>");
//echo("<br>");
//print_r($jsonUserData);
echo <<<'HOME1_HEADER'
<div class="User">
  	<div class="jumbotron">
    	<div class="container">

			<ul class="nav nav-tabs">
			  <li class="active"><a data-toggle="tab" href="#home1">Registrierte User</a></li>
			  <li><a data-toggle="tab" href="#menu1">Registrierungsanfragen</a></li>
			  <li><a data-toggle="tab" href="#menu2">Nachichten</a></li>
			</ul>

		   
			 <!-- Tab panes -->
			 <div class="tab-content">
					<div id="home1" class="tab-pane fade in active"><br>

					  <div class="table-responsive-sm">
						<table class="table">
						  <thead>
							<tr>
							  <th>UserID</th>
							  <th>Anrede</th>
							  <th>Vorname</th>
							  <th>Nachname</th>
							  <th>eMail</th>
							  <th>Telefon</th>
							  <th>Aktiv</th>
							</tr>
						  </thead>
						  <tbody>  
HOME1_HEADER;

				foreach($jsonuserDatawithLogin as $itemuserdatawithLogin)
				{
				 
				echo("<tr>");
				echo("<td>{$itemuserdatawithLogin['userID']}</td>");
				echo("<td>{$itemuserdatawithLogin['userAnrede']}</td>");
				echo("<td>{$itemuserdatawithLogin['userVorname']}</td>");
	  			echo("<td>{$itemuserdatawithLogin['userNachname']}</td>");
				echo("<td>{$itemuserdatawithLogin['userEmail'] }</td>");
				echo("<td>{$itemuserdatawithLogin['userFestnetzNr']}</td>");
				  
				echo("<td><input class='btn btn-primary' type='button' value='Bearbeiten'  onclick='changeRegistUser({$userdata['userID']});'></td>");

/* 				foreach($jsonUserLogin as $userlogin)
				{
	  				if($userdata['userID'] == $userlogin['userID'] )
					{
						if($userlogin['userStatus'] == true)
						{
							echo("<td><input class='form-check-input' type='checkbox' id='defaultCheck2' checked disabled><td>");
						}
						else
						{
							echo("<td><input class='form-check-input' type='checkbox' id='defaultCheck2' disabled><td>");
						}
					
						
					}
				}; */
	  			//value = {$item['ID']};
		  
				echo("</tr>");
				};


echo <<<HOME1_FOOTER
						 </tbody>
            		  </table>
          		   </div>
        		</div>
		
HOME1_FOOTER;

			  

echo <<<'MENU1_HEADER'
			     <div id="menu1" class="tab-pane fade">           
				  <div class="table-responsive-sm">
					<table class="table">
					  <thead>
						<tr>
						  <th>UserID</th>
						  <th>Anrede</th>
						  <th>Vorname</th>
						  <th>Nachname</th>
						  <th>eMail</th>
						  <th>Telefon</th>
						</tr>
					  </thead>
					  <tbody>
MENU1_HEADER;

				foreach($jsonuserDatawithoutLogin as $itemuserdatawithoutLogin)
				{
/* 				foreach($jsonUserLogin['logins'] as $userlogin)
				{
	  				if(($userdata['userID'] == $userlogin['userID']) && ($userlogin['userStatus'] == false))
					{ */
						echo("<tr>");
							echo("<td>{$itemuserdatawithoutLogin['userID']}</td>");
							echo("<td>{$itemuserdatawithoutLogin['userAnrede']}</td>");
							echo("<td>{$itemuserdatawithoutLogin['userVorname']}</td>");
							echo("<td>{$itemuserdatawithoutLogin['userNachname']}</td>");
							echo("<td>{$itemuserdatawithoutLogin['userEmail'] }</td>");
							echo("<td>{$itemuserdatawithoutLogin['userFestnetzNr']}</td>");
							echo("<td><input class='btn btn-primary' type='button' value='Bearbeiten'  onclick='changeNewRegistUser({$userdata['userID']});'></td>");
					//}	
				//};
	  			  
						echo("</tr>");
				};


echo <<<'MENU1_FOOTER'
							</tbody>
							</table>
						  </div>
						</div>
MENU1_FOOTER;

			  
			  
echo <<<'MENU2_HEADER'
				<div id="menu2" class="tab-pane fade">
					 <div class="table-responsive-sm">
						<table class="table">
						  <thead>
							<tr>
							  <th>UserID</th>
							  <th>Vorname</th>
							  <th>Nachname</th>
							  <th>Grund</th>
							  <th>Thema</th>
							  <th>Nachicht</th>
							</tr>
						  </thead>
						  <tbody>
MENU2_HEADER;

						foreach($jsonUserAnfrage as $useranfragen)
						{	
				
						echo("<tr>");
							echo("<td>{$useranfragen['userID']}</td>");
							
							foreach($jsonUserData['users'] as $userdata)
							{
								if($userdata['userID'] == $useranfragen['userID'])
								   {
									echo("<td>{$userdata['userAnrede']}</td>");
									echo("<td>{$userdata['userVorname']}</td>");
									echo("<td>{$userdata['userNachname']}</td>");
								   }
							};
							
							echo("<td>{$useranfragen['userGrund']}</td>");
							echo("<td>{$useranfragen['userNachicht']}</td>");
							echo("<td><input class='btn btn-primary' type='button' value='Bearbeiten'  onclick='testbuttonaction({$useranfragen['userID']});'></td>");
							
					
						echo("</tr>");
				};

echo <<<'HOME2_FOOTER'
						</tbody>
            		</table>
          		</div>
        	</div>
		</div>
	 </div>
   </div>
  </div>
</div>

HOME2_FOOTER;

?>

