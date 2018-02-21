<?php
header("Content-Type: application/json");

// Json extern laden (Web API Aufruf)
$jsonData = file_get_contents("data.json");
$jsonFileData = json_decode($jsonData);


$var1 = $_POST["var1"];
$var2 = $_POST["var2"];
 

$jsonDataVaribles = '{ "obj1":{ "propertyA":"' . ($jsonFileData->value1 + $var1) . '", "propertyB":"' . ($jsonFileData->value2 + $var2) .  '" }'. "}";


	
echo $jsonDataVaribles;



//$url = 'http://server.com/path';
//$data = array('key1' => 'value1', 'key2' => 'value2');
//
//// use key 'http' even if you send the request to https://...
//$options = array(
//    'http' => array(
//        'header'  => "Content-type: application/x-www-form-urlencoded\r\n",
//        'method'  => 'POST',
//        'content' => http_build_query($data)
//    )
//);
//$context  = stream_context_create($options);
//$result = file_get_contents($url, false, $context);

?>
