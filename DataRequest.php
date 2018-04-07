
<?php
// Data load
function loadData(url,param)
{
	result = "Test";
	return result;
}

function loadData(url)
{
	$cSession = curl_init(); 
	curl_setopt($cSession,CURLOPT_URL,url);

	curl_setopt($cSession,CURLOPT_RETURNTRANSFER,true);
	
	curl_setopt($cSession,CURLOPT_HEADER, false); 

	$result=curl_exec($cSession);

	curl_close($cSession);
	
	
	
	return $result;
}


echo loadData("http://zoomnation.selfhost.eu:8080/ProManAPIDummy/api/adminPage/?identifier=AdminPageUser");

?>

